using DataAccess.Repository;
using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Diagnostics;

namespace Amanek.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public IUnitOfWorks UnitOfWorks { get; }

        public HomeController(ILogger<HomeController> logger, IUnitOfWorks unitOfWorks)
        {
            _logger = logger;
            UnitOfWorks = unitOfWorks;
        }

        public IActionResult Index(string searchTerm, int page = 1)
        {
            int pageSize = 9;

            var packagesQuery = UnitOfWorks.InsurancePackageRepository
                .Get(includeProperties: e => e.Company)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                searchTerm = searchTerm.ToLower();

                packagesQuery = packagesQuery.Where(p =>
                    p.PackageName.ToLower().Contains(searchTerm) ||
                    p.Company.Name.ToLower().Contains(searchTerm));

            }

            int totalPackages = packagesQuery.Count();

            var paginatedPackages = packagesQuery
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            ViewBag.TotalPages = (int)Math.Ceiling((double)totalPackages / pageSize);
            ViewBag.CurrentPage = page;
            ViewBag.SearchTerm = searchTerm;

            return View(paginatedPackages);
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
