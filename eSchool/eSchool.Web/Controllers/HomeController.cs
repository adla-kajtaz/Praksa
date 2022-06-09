using eSchool.Infrastructure.UnitOfWork;
using eSchool.Service.Services;
using eSchool.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eSchool.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISubjectService _subjectService;
        

        public HomeController(ILogger<HomeController> logger, ISubjectService subjectService)
        {
            _logger = logger;
            
            _subjectService = subjectService;
        }

        public IActionResult Index()
        {
           
            var predmet =_subjectService.GetByName("Matematika");
            return View(predmet);
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