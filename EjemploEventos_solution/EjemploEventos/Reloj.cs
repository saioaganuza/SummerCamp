using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEventos
{
    internal class Reloj
    {
        // Delegado
        public delegate void CambioSegudoDelegado(Object reloj, InformacionTiempoEventArgs informacionTiempo); //Se manda un object en el delegado y no se manda el propio tipo de la clase (Reloj) (Norma no establecida)

        // Evento
        public event CambioSegudoDelegado CambioSegundoEvento;

        public Reloj()
        {
            
        }

        private int segundo;
        public void IniciaReloj()
        {
            DateTime fechaHoraActual;
            for(; ; ) // Un bucle infinito
            {
                Thread.Sleep(100);
                fechaHoraActual = DateTime.Now;
                if (fechaHoraActual.Second != segundo)
                {
                   
                    // Guardar info tiempo
                    var informacionTiempo = new InformacionTiempoEventArgs(fechaHoraActual.Hour, fechaHoraActual.Minute, fechaHoraActual.Second);

                    // lanzar el evento
                    if(CambioSegundoEvento != null) 
                    {
                    CambioSegundoEvento(this, informacionTiempo);
                    }
                    
                }
                segundo = fechaHoraActual.Second;

            }

        }
    }
}
