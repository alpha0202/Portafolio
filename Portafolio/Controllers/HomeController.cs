using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var  proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Proyectos= proyectos };

            return View(modelo);
        }

        public List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO>() {
                new ProyectoDTO
            {
                Titulo = "SYC",
                Descripcion="Implementador de Componetes en C#. Aplicativo de escritorio para la transferencia de documentos a bd Mongo",
                Link = "https://www.syc.com.co",
                ImagenURL="/imagenes/syc.png"


            },

                new ProyectoDTO
            {
                Titulo = "SYC",
                Descripcion="Desarrollo de Aplicativo radicador de documentos de escritorio en visual basic.net",
                Link = "https://www.syc.com.co",
                ImagenURL="/imagenes/syc.png"


            },
               
            new ProyectoDTO
            {
                Titulo = "SYC",
                Descripcion="Desarrollo Aplicativo Web ASP.NET, Publicador de Configuraciones, c# y jquery",
                Link = "https://www.syc.com.co",
                ImagenURL="/imagenes/syc.png"


            }
            };

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