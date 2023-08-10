using Microsoft.EntityFrameworkCore;

namespace MVCproject.Models
{
    public class RepositorioMonedas
    {
        private ContextoConversor _context;
        public RepositorioMonedas(ContextoConversor contexto)
        {
            _context = contexto;
        }
        public void AgregarMoneda(Moneda moneda)
        {
            _context.Monedas.Add(moneda);
            _context.SaveChanges();
        }

        public Moneda ObtenerMoneda(int id)
        {
            return _context.Monedas.FirstOrDefault(_context => _context.Id == id);
        }

        public IEnumerable<Moneda> ObtenerMonedas()
        {
            return _context.Monedas;
            
        }
    }
}
