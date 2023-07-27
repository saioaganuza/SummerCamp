using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factor
    {
        public Factor()
        {
            
        }
        public Factor(string origen, string destino, double fact)
        {
            Origen = origen;
            Destino = destino;
            Fact = fact;
        }

        public string Origen { get; set; }
        public string Destino { get; set; }
        public double Fact { get; set; }
    }
}
