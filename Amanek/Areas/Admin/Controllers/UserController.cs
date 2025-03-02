using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.ViewModels;
using Models;
using Utility;

namespace Amanek.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = $"{SD.AdminRole}")]
    public class UserController : Controller
    {
        private readonly IUnitOfWorks unitOfWork;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public UserController(IUnitOfWorks unitOfWork, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.unitOfWork = unitOfWork;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public IActionResult Index() => View();

        public async Task<IActionResult> RoleManagement(string userId)
        {
            var user = unitOfWork.ApplicationUserRepository.GetOne(e => e.Id == userId, includeProperties: e => e.InsuranceCompany);

            if (user != null)
            {
                UserRoleVM userRoleVm = new()
                {
                    Id = userId,
                    Name = user.FullName,
                    Email = user.Email,
                    Role = string.Join(", ", await userManager.GetRolesAsync(user)),
                    ListOfRoles = roleManager.Roles.Select(e => new SelectListItem
                    {
                        Value = e.Name,
                        Text = e.Name
                    }),
                    Company = user.InsuranceCompany?.Id,
                    ListOfCompanies = unitOfWork.InsuranceCompanyRepository.Get().Select(e => new SelectListItem
                    {
                        Text = e.Name,
                        Value = e.Id.ToString()
                    })
                };
                return View(userRoleVm);
            }

            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RoleManagement(UserRoleVM userRoleVM)
        {
            if (ModelState.IsValid)
            {
                var user = unitOfWork.ApplicationUserRepository.GetOne(e => e.Id == userRoleVM.Id, tracked: true, includeProperties: e => e.InsuranceCompany);

                if (user != null)
                {
                    await userManager.RemoveFromRolesAsync(user, await userManager.GetRolesAsync(user));
                    await userManager.AddToRoleAsync(user, userRoleVM.Role);

                    user.CompanyId = userRoleVM.Role == SD.CompanyRole ? userRoleVM.Company : null;

                    unitOfWork.Commit();

                    TempData["alert"] = "Edited successfully";
                    return RedirectToAction(nameof(Index));
                }

                return NotFound();
            }
            return View(userRoleVM);
        }

        #region APIs
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = unitOfWork.ApplicationUserRepository.Get(includeProperties: e => e.InsuranceCompany);

            var userList = new List<object>();

            foreach (var user in users)
            {
                userList.Add(new
                {
                    id = user.Id,
                    fullName = user.FullName, // Ensure lowercase to match DataTables
                    email = user.Email,
                    phoneNumber = user.PhoneNumber,
                    company = new { name = user.InsuranceCompany?.Name ?? "N/A" }, // Handle null
                    role = string.Join(", ", await userManager.GetRolesAsync(user)),
                    lockoutEnd = user.LockoutEnd
                });
            }

            return Json(userList);
        }


        [HttpPost]
        public async Task<IActionResult> LockUnlock([FromBody] string userId)
        {
            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return Json(new { success = false, message = "User not found" });
            }

            if (user.LockoutEnd != null && user.LockoutEnd > DateTime.Now)
            {
                // Unlock the user
                user.LockoutEnd = null;
                await userManager.UpdateAsync(user);
                return Json(new { success = true, message = "User unlocked successfully" });
            }
            else
            {
                // Lock the user
                user.LockoutEnd = DateTime.Now.AddYears(1000);
                await userManager.UpdateAsync(user);
                return Json(new { success = true, message = "User locked successfully" });
            }
        }

        #endregion
    }
}
