using DataAccess.Repository;
using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Utility;

namespace Amanek.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = $"{SD.AdminRole}, {SD.CompanyRole}")]
    public class PolicyController : Controller
    {
        private readonly IUnitOfWorks unitOfWorks;

        public PolicyController(IUnitOfWorks unitOfWorks) {
            this.unitOfWorks = unitOfWorks;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
