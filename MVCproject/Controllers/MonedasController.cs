using Microsoft.AspNetCore.Mvc;
using MVCproject.Models;
using MVCproject.Servicios;

namespace MVCproject.Controllers
{
    public class MonedasController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServicioMonedas servicioMonedas;
        private readonly IRepositorioMonedas repositorioMonedas;
        public MonedasController(ILogger<HomeController> logger, IRepositorioMonedas repositorioMonedas)
        {
            _logger = logger;
            this.repositorioMonedas = repositorioMonedas;
        }
        public IActionResult Index()
        {
            IEnumerable<Moneda> lista = repositorioMonedas.ObtenerMonedas();
            return View(lista);
        }
    }
}
