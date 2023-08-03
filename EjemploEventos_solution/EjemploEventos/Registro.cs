namespace EjemploEventos
{
    internal class Registro
    {
        DateTime FechaAnterior;
        public Registro()
        {
        }

        internal void Subscribir(Reloj reloj)
        {
            reloj.CambioSegundoEvento += Reloj_CambioSegundoEvento;
        }

        private void Reloj_CambioSegundoEvento(object reloj, InformacionTiempoEventArgs e)
        {
                TimeSpan resta = DateTime.Now - FechaAnterior;
                if (resta.Seconds > 10)
                {
                    Console.WriteLine($"Hora Actual Registro (cada 10s):{DateTime.Now.Year}  {e.Hora.ToString()}:" +
                                      $"{e.Minuto.ToString()}:" +
                                      $"{e.Segundo.ToString()}");

                    FechaAnterior = DateTime.Now;
                }
            

            
        }
    }
}