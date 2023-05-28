using LearnMVCwithFigma.Models;
using LearnMVCwithFigma.Repositories;
using LearnMVCwithFigma.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LearnMVCwithFigma.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAccountRepository _repository;
        public HomeController(ILogger<HomeController> logger, IAccountRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
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
        [HttpPost("api/add")]
        public IActionResult AddAccount([FromBody] AddAccountViewModel obj)
        {
            try
            {
                _repository.AddAccount(obj);
                return Ok();
            }
            catch ( Exception e)
            {
                _logger.LogError(e, "Failed to add Accout");
                return BadRequest();
            }
        }
    }
}