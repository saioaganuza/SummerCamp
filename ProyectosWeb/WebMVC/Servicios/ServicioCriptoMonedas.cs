﻿using WebMVC.Models;

namespace WebMVC.Servicios
{
    public class ServicioCriptoMonedas : IServicioMonedas
    {
        public List<Moneda> Monedas { get; set; }


        public List<Moneda> ObtenerMonedas()
        {
            return Monedas;
        }
    }
}
