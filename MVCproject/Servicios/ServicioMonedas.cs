using MVCproject.Models;

namespace MVCproject.Servicios
{
    public class ServicioMonedas : IServicioMonedas
    {
        private readonly ILogger<ServicioMonedas> logger;
        public ServicioMonedas(ILogger<ServicioMonedas> logger)
        {
            this.logger = logger;
        }
        public List<Moneda> lista = new List<Moneda>();
        public List<Moneda> ObtenerMonedas()
        {
            return lista;
        }
    }
}
