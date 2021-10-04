using ForumEtec.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumEtec.Controllers
{
    public class PerguntaController : Controller
    {
        private readonly IPerguntaRepository _perguntaRepository;

        public PerguntaController(IPerguntaRepository perguntaRepository)
        {
            _perguntaRepository = perguntaRepository;
        }

        public IActionResult List()
        {
            var Perguntas = _perguntaRepository.Perguntas;

            return View(Perguntas);
        }
    }
}
