using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models;
using Utility;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Amanek.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = ($"{SD.AdminRole}"))]
    public class CompanyController : Controller
    {
        private readonly IUnitOfWorks unitOfWork;

        public CompanyController(IUnitOfWorks unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IActionResult Index() => View();

        public IActionResult UpSert(int? id)
        {
            InsuranceCompany? company = new InsuranceCompany();
            if (id != null)
            {
                company = unitOfWork.InsuranceCompanyRepository.GetOne(e => e.Id == id);
            }

            return company != null ? View(company) : NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpSert(InsuranceCompany company)
        {
            if (ModelState.IsValid)
            {
                if (company.Id == 0)
                {
                    unitOfWork.InsuranceCompanyRepository.Add(company);

                    TempData["alert"] = "Added successfully";
                }
                else
                {
                    unitOfWork.InsuranceCompanyRepository.Update(company);

                    TempData["alert"] = "Edited successfully";
                }

                unitOfWork.Commit();
                return RedirectToAction(nameof(Index));
            }

            return View(company);
        }

        public IActionResult Delete(int id)
        {
            var company = unitOfWork.InsuranceCompanyRepository.GetOne(e => e.Id == id);

            if (company != null)
            {
                unitOfWork.InsuranceCompanyRepository.Remove(company);
                unitOfWork.Commit();

                TempData["alert"] = "Deleted successfully";

                return RedirectToAction(nameof(Index));
            }

            return NotFound();
        }

        #region APIs
        [HttpGet]
        public IActionResult GetAll() => Json(unitOfWork.InsuranceCompanyRepository.Get());
        #endregion
    }
}
