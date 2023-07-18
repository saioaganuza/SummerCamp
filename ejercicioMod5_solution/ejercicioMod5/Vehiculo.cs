using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioMod5
{
    internal class Vehiculo
    {
        public enum TipoEtiqueta { 
        sin,
        B,
        C,
        ECO, 
        CERO
        }
        public Vehiculo() { }
        public Vehiculo(double precio, TipoEtiqueta etiqueta, int años)
        {
            Precio = precio;
            Etiqueta = etiqueta;
            Años = años;
        }

        public double Precio { get; set; }
        public TipoEtiqueta Etiqueta { get; set; }
        public int Años { get; set; }

        internal double SacarImpuesto( Vehiculo v)
        {
            double impuesto=0;
            
            double valor_etiqueta=0; 

            switch (v.Etiqueta)
            {
                case TipoEtiqueta.sin:
                    valor_etiqueta = 0.25;
                    break;
                case TipoEtiqueta.B:
                    valor_etiqueta = 0.15;
                    break;
                case TipoEtiqueta.C:
                    valor_etiqueta = 0.1;
                    break;
                case TipoEtiqueta.ECO: 
                    valor_etiqueta = 0.05;
                    break;
                case TipoEtiqueta.CERO:
                    valor_etiqueta= 0;
                    break;

            }

            impuesto = v.Precio + (DateTime.Now.Year - v.Años) * v.Precio * 0.01;
            impuesto = impuesto + impuesto *valor_etiqueta;

            // throw new NotImplementedException();
            return impuesto;

        }
    }
}
