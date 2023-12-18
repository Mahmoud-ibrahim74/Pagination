using Pagination.Models;
using Pagination.Paganation;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Pagination.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPaginationService _pagination;

        public HomeController(ILogger<HomeController> logger, IPaginationService pagination)
        {
            _logger = logger;
            _pagination = pagination;
        }

        public IActionResult Index()
        {


            return View(Product.GetProducts());
        }
        [HttpGet]
        public IActionResult Pagination(int pageSize = 3, int pageIndex = 2)
        {
            _pagination.pageIndex = pageIndex;
            _pagination.pageSize = pageSize;
            ViewData["IsPreviousButtonDisabled"] = pageIndex <= 1;
            ViewData["IsNextButtonDisabled"] = pageIndex >= _pagination.pageCount;
            return View(_pagination.GetPage());
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
