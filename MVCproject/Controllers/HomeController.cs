using Microsoft.AspNetCore.Mvc;
using MVCproject.Models;
using MVCproject.Servicios;
using System.Diagnostics;

namespace MVCproject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServicioMonedas servicioMonedas;
        private readonly IRepositorioMonedas repositorioMonedas;
        private readonly IMail mail;

        public HomeController(ILogger<HomeController> logger, IRepositorioMonedas repositorioMonedas)
        {
            _logger = logger;
            this.repositorioMonedas = repositorioMonedas;
            //this.servicioMonedas = servicioMonedas;
            //this.mail = mail;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Estoy en el index");
            //var serviciomonedas = new ServicioMonedas();
            //var serviciomonedas = new ServicioCriptoMonedas();
            //IServicioMonedas serviciomonedas = new ServicioCriptoMonedas();
            //var lista = servicioMonedas.ObtenerMonedas();
            IEnumerable<Moneda> lista = repositorioMonedas.ObtenerMonedas();
            return View(lista);
        }

        public IActionResult Privacy()
        {
            //throw new Exception();
            ////var serviciomonedas = new ServicioMonedas();
            ////var serviciomonedas = new ServicioCriptoMonedas();
            ////IServicioMonedas serviciomonedas = new ServicioCriptoMonedas();
            //var lista = servicioMonedas.ObtenerMonedas();
            //mail.Envio();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}