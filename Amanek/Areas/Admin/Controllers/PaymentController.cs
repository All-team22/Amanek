using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Linq.Expressions;
using Utility;

namespace Amanek.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = ($"{SD.AdminRole},{SD.CompanyRole}"))]
    public class PaymentController : Controller
    {
        private readonly IUnitOfWorks unitOfWorks;

        public PaymentController(IUnitOfWorks unitOfWorks)
        {
            this.unitOfWorks = unitOfWorks;
        }
        [ValidateAntiForgeryToken]
        [HttpGet]
        public IActionResult Index()
        {
            var payments = unitOfWorks.PaymentRepository.Get(
                     includeProperties: new Expression<Func<Payment, object>>[]
                        {
                        e => e.InsuranceCompany,
                        e => e.InsurancePolicy,
                        e => e.ApplicationUser,
                        e=>e.Claim!
                        }
                );
            return View(payments);
        }
        [ValidateAntiForgeryToken]
        [HttpGet]
        public IActionResult Details(int Id)
        {
            var payment = unitOfWorks.PaymentRepository.GetOne(
                    expression: e => e.Id == Id,
                    includeProperties: new Expression<Func<Payment, object>>[]
                        {
                        e => e.InsuranceCompany,
                        e => e.InsurancePolicy,
                        e => e.ApplicationUser,
                        e=>e.Claim!
                        }
             );
            if (payment == null)
            {
                return NotFound();
            }
            return View(payment);
        }
        [ValidateAntiForgeryToken]
        [HttpGet]
        public IActionResult UpSert(int? Id)
        {
            Payment? payment = new Payment();
            if (Id != null)
            {
                payment = unitOfWorks.PaymentRepository.GetOne(expression: e => e.Id == Id);
            }
            return payment != null ? View(payment) : NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpSert(Payment payment)
        {
            if (ModelState.IsValid)
            {
                if (payment.Id == 0)
                {
                    unitOfWorks.PaymentRepository.Add(payment);
                    TempData["alert"] = "payment done successfully";
                }
                else
                {
                    unitOfWorks.PaymentRepository.Update(payment);
                    TempData["alert"] = "payment updated successfully";
                }
                unitOfWorks.Commit();
                return RedirectToAction("Index");
            }
            return View(payment);
        }
        public IActionResult Delete(int Id)
        {
            var payment = unitOfWorks.PaymentRepository.GetOne(expression: e => e.Id == Id);
            if (payment != null)
            {
                unitOfWorks.PaymentRepository.Remove(payment);
                unitOfWorks.Commit();
                TempData["alert"] = "Deleted successfully";
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}
