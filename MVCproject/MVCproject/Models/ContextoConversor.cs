using Microsoft.EntityFrameworkCore;

namespace MVCproject.Models
{
    public class ContextoConversor : DbContext
    {
        // 1-Desde la consola del administrador de paquetes NuGet escribimos
        //        add-migration "inicial"
        // 2-Crear la BBDD mediante el siguiente comando (Tambien desde la consola)
        //        update-database



       
       

            public ContextoConversor(DbContextOptions<ContextoConversor> opciones) : base(opciones)
            {

            }

            public DbSet<Moneda> Monedas { get; set; }
            public DbSet<Pais> Paises { get; set; }

        
    }
}
