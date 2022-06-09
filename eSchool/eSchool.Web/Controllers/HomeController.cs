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
        //private readonly ISubjectService _subjectService;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger,IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            //_subjectService = subjectService;
        }

        public IActionResult Index()
        {
            // var predmet = _subjectService.GetByName("Matematika");
            var predmet = _unitOfWork._SubjectRepository.GetByName("Matematika");
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