using DataAccess.Repository;
using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Models;
using System.Linq.Expressions;
using Utility;


namespace Amanek.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = $"{SD.AdminRole}, {SD.CompanyRole}")]
    public class PolicyController : Controller
    {
        private readonly IUnitOfWorks unitOfWorks;
        private readonly UserManager<ApplicationUser> userManager;

        public PolicyController(IUnitOfWorks unitOfWorks , UserManager<ApplicationUser> userManager)
        {
            this.unitOfWorks = unitOfWorks;
            this.userManager = userManager;
        }
        public IActionResult Index(int? page, string searchString, string statusFilter)
        {
            int pageSize = 10; 
            int pageNumber = (page ?? 1);

            IEnumerable<InsurancePolicy> policies;

            if (User.IsInRole(SD.AdminRole))
            {
               
                policies = unitOfWorks.InsurancePolicyRepository.Get(
                    includeProperties: new Expression<Func<InsurancePolicy, object>>[]
                    {
                e => e.Company,
                e => e.Claims,
                e => e.User,
                e=> e.Package
                    });
            }
            else
            {
              
                string companyId = userManager.GetUserId(User);
                var company = unitOfWorks.ApplicationUserRepository.GetOne(e => e.Id == companyId);
                policies = unitOfWorks.InsurancePolicyRepository.Get(e => e.CompanyId == company.CompanyId,
                    includeProperties: new Expression<Func<InsurancePolicy, object>>[]
                    {
                e => e.Company,
                e => e.Claims,
                e => e.User,
                e=> e.Package
                    });
            }

           
            if (!string.IsNullOrEmpty(searchString))
            {
                policies = policies.Where(e => e.User.FullName.Contains(searchString) || e.LicenseNumber.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(statusFilter))
            {
                policies = policies.Where(e => e.PolicyStatus.ToString() == statusFilter);
            }

          
            var totalCount = policies.Count();
            var pagedPolicies = policies.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

         
            ViewBag.CurrentFilter = searchString;
            ViewBag.CurrentStatus = statusFilter;
            ViewBag.TotalCount = totalCount;
            ViewBag.PageNumber = pageNumber;
            ViewBag.PageSize = pageSize;
            ViewBag.TotalPages = (int)Math.Ceiling((double)totalCount / pageSize);

            return View(pagedPolicies);
        }




        public IActionResult Details(int Id)
        {
            var policy = unitOfWorks.InsurancePolicyRepository.GetOne(
                e => e.Id == Id,
                includeProperties: new Expression<Func<InsurancePolicy, object>>[]
                        {
                           e=>e.Company,
                           e=>e.Claims,
                           e=>e.User,
                           e=> e.Package
                        }
                        );
            return policy != null ? View(policy) : NotFound();
        }

        public IActionResult Create(int packageId, int companyId)
        {
            var userId = userManager.GetUserId(User);
            InsurancePolicy policy = new InsurancePolicy() { 
                UserId = userId,
                CompanyId = companyId,
                packageId = packageId
            };

            return View(policy);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(InsurancePolicy policy, IFormFile UserDocs)
        {
            if (ModelState.IsValid)
            {
                if (UserDocs.Length > 0)
                {
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(UserDocs.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", fileName);

                    using (var stream = System.IO.File.Create(filePath))
                    {
                        UserDocs.CopyTo(stream);
                    }
                    policy.UserDocs = fileName;
                }
                unitOfWorks.InsurancePolicyRepository.Add(policy);
                TempData["alert"] = "Policy created successfully!";
                unitOfWorks.Commit();
                return RedirectToAction("Index");
            }
            TempData["alert"] = "Failed to create policy. Please try again.";
            return View(policy);
        }

        public IActionResult Edit(int Id)
        {
            var policy = unitOfWorks.InsurancePolicyRepository.GetOne(e => e.Id == Id);
            if (policy == null)
            {
                TempData["alert"] = "Failed to get this policy. Please try again.";
                return NotFound();
            }
            return View(policy);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(InsurancePolicy policy, IFormFile UserDocs)
        {
            ModelState.Remove("UserDocs");
            var oldPolicy = unitOfWorks.InsurancePolicyRepository.GetOne(e => e.Id == policy.Id, tracked: false);
            if (oldPolicy == null)
            {
                TempData["alert"] = "Policy not found!";
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                if (UserDocs != null && UserDocs.Length > 0)
                {
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(UserDocs.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", fileName);
                    var oldFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", oldPolicy.UserDocs);

                    using (var stream = System.IO.File.Create(filePath))
                    {
                        UserDocs.CopyTo(stream);
                    }

                    if (System.IO.File.Exists(oldFilePath))
                    {
                        System.IO.File.Delete(oldFilePath);
                    }

                    policy.UserDocs = fileName;
                }
                else
                {
                    policy.UserDocs = oldPolicy.UserDocs;
                }
                unitOfWorks.InsurancePolicyRepository.Update(policy);
                unitOfWorks.Commit();
                return RedirectToAction("index");
            }
            TempData["alert"] = "Failed to update policy. Please try again.";
            policy.UserDocs = oldPolicy.UserDocs;
            return View(policy);
        }

        public IActionResult Delete(int id)
        {
            var policy = unitOfWorks.InsurancePolicyRepository.GetOne(e => e.Id == id);
            if (policy == null)
            {
                TempData["alert"] = "policy not found!";
                return RedirectToAction(nameof(Index));
            }
            var oldFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", policy.UserDocs);
            if (System.IO.File.Exists(oldFilePath))
            {
                System.IO.File.Delete(oldFilePath);
            }

            unitOfWorks.InsurancePolicyRepository.Remove(policy);
            TempData["successMessage"] = "Product deleted successfully!";
            unitOfWorks.Commit();
            return RedirectToAction(nameof(Index));
        }
    }
}
