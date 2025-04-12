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

        public IActionResult Index(string searchTerm, int carModel, double? carPrice, double? packageMinPrice, double? packageMaxPrice, int page = 1)
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

            if (carPrice.HasValue)
            {
                packagesQuery = packagesQuery.Where(p => p.CarMinPrice <= carPrice.Value && p.CarMaxPrice >= carPrice.Value);
            }

            if (packageMinPrice.HasValue)
            {
                packagesQuery = packagesQuery.Where(p => p.PolicyPrice >= packageMinPrice.Value);
            }

            if (packageMaxPrice.HasValue)
            {
                packagesQuery = packagesQuery.Where(p => p.PolicyPrice <= packageMaxPrice.Value);
            }

            if (carModel > 2005)
            {
                packagesQuery = packagesQuery.Where(p => p.CarStartModels <= carModel && p.CarEndModels >= carModel);
            }

            int totalPackages = packagesQuery.Count();
            var paginatedPackages = packagesQuery
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            ViewBag.TotalPages = (int)Math.Ceiling((double)totalPackages / pageSize);
            ViewBag.CurrentPage = page;
            ViewBag.SearchTerm = searchTerm;
            ViewBag.CarModel = carModel;
            ViewBag.CarPrice = carPrice;
            ViewBag.PackageMinPrice = packageMinPrice;
            ViewBag.PackageMaxPrice = packageMaxPrice;

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
