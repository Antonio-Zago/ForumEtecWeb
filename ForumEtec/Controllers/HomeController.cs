using ForumEtec.Models;
using ForumEtec.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ForumEtec.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        private readonly IPerguntaRepository _perguntaRepository;

        public HomeController(ILogger<HomeController> logger, IPerguntaRepository perguntaRepository)
        {
            _perguntaRepository = perguntaRepository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var perguntas = _perguntaRepository.Perguntas;

            return View(perguntas);
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
