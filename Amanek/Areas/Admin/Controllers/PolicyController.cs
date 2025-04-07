using DataAccess.Repository;
using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
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
        // get , getone, update , add , delete
        public PolicyController(IUnitOfWorks unitOfWorks) {
            this.unitOfWorks = unitOfWorks;
        }
        //get all
        // join 
        public IActionResult Index()
        {
            var policies = unitOfWorks.InsurancePolicyRepository.Get(
                   includeProperties: new Expression<Func<InsurancePolicy, object>>[]
                        {
                           e=>e.Company,
                           e=>e.Claims,
                           e=>e.User
                        }
                );
            return View(policies);
        }
        //get one
        public IActionResult Details(int Id) {
            var policy = unitOfWorks.InsurancePolicyRepository.GetOne(
                e => e.Id == Id,
                includeProperties: new Expression<Func<InsurancePolicy, object>>[]
                        {
                           e=>e.Company,
                           e=>e.Claims,
                           e=>e.User
                        }
                        );
            return policy != null ? View(policy) : NotFound();
        }
       
    }
}
