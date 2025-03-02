using DataAccess.Repository;
using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models;
using Utility;

namespace Amanek.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = $"{SD.AdminRole}, {SD.CompanyRole}")]
    public class PackageController : Controller
    {
        private readonly IUnitOfWorks unitOfWorks;
        private readonly UserManager<ApplicationUser> userManager;

        public PackageController(IUnitOfWorks unitOfWorks , UserManager<ApplicationUser> userManager)
        {
            this.unitOfWorks = unitOfWorks;
            this.userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            string userId = userManager.GetUserId(User);
            var user = unitOfWorks.ApplicationUserRepository.GetOne(expression: e=> e.Id == userId);
            var packages = unitOfWorks.InsurancePackageRepository.Get(expression:e=>e.CompanyId == user.CompanyId);
            if (User.IsInRole($"{SD.AdminRole}"))
            {
              return View(unitOfWorks.InsurancePackageRepository.Get());
            }

            return View(unitOfWorks.InsurancePackageRepository.Get(expression: e => e.CompanyId == user.CompanyId));
        }
        public IActionResult UpSert(int? id)
        {
            InsurancePackage? package = new InsurancePackage();
            if (id != null)
            {
                package = unitOfWorks.InsurancePackageRepository.GetOne(e => e.Id == id);
            }

            return package != null ? View(package) : NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpSert(InsurancePackage package)
        {
            string userId = userManager.GetUserId(User);
            var company = unitOfWorks.ApplicationUserRepository.GetOne(expression: e => e.Id == userId);
            package.CompanyId = (int)(company?.CompanyId);
            
            if (ModelState.IsValid)
            {

                if (package.Id == 0)
                {
                    unitOfWorks.InsurancePackageRepository.Add(package);
                    TempData["alert"] = "Added successfully";
                }
                else
                {
                    unitOfWorks.InsurancePackageRepository.Update(package);

                    TempData["alert"] = "Edited successfully";
                }

                unitOfWorks.Commit();
                return RedirectToAction(nameof(Index));
            }

            return View(package);
        }

        public IActionResult Delete(int id)
        {
            var package = unitOfWorks.InsurancePackageRepository.GetOne(e => e.Id == id);

            if (package != null)
            {
                unitOfWorks.InsurancePackageRepository.Remove(package);
                unitOfWorks.Commit();

                TempData["alert"] = "Deleted successfully";

                return RedirectToAction(nameof(Index));
            }

            return NotFound();
        }

    }
}
