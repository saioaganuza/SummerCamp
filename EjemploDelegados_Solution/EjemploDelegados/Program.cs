using EjemploDelegados.Medios;
using static EjemploDelegados.InventarioMedios;


namespace EjemploDelegados
{
    public class Program
    {
        //Programa para archivo de medios de una biblioteca
        //1. Según el tipo de medio indicar al usuario los pasos a dar para reproducir ese medio y verificar si está en buen estado para archivarlo
        //2. Aplicación que diga qué pasos dar independientemente del tipo de medio
        //3. Mostrar el contenido del medio según el tipo de medio. pasar código de barras o identificador para localizar el medio
        // CDs- Mostrar lista de canciones
        // Vinilo- Mostrar lista de canciones en la contraportada
        // Vhs- Mostrar información de la película
        static void Main(string[] args)
        {
            //++ 1-Crear instancias 

            // Crear la instancia del inventario de medios
            var inventarioMedios = new InventarioMedios();

            // Crear instancia reproductor de cassette
            var reproductorCassette = new ReproductorCassette();

            // Crear instancia Tocadiscos
            var tocaDiscos = new Tocadiscos();

            // Crear instancia reproductor VHS
            var videoVhs = new VideoVhs();

            // Crear instancia reproductor CDs
            var repCD = new ReproductorCDS();


            //++ 2-Crear instancias de delegados

            // Crear instancia del delegado para probar discos de vinilo
            ProbarMediosDelegado probarDiscosDelegado =
                new ProbarMediosDelegado(tocaDiscos.ProbarVinilo);

            // Crear instancia del delegado para probar cintas vhs
            ProbarMediosDelegado probarCintasVhsDelegado =
                                 new ProbarMediosDelegado(videoVhs.ProbarVideoVhs);

            // Crear instancia del delegado para probar CD
            ProbarMediosDelegado probarCDDelegado =
                                 new ProbarMediosDelegado(repCD.ProbarDC);

            // Crear instancia del delegado para probar cassettes
            ProbarMediosDelegado probarCassetteDelegado =
                                 new ProbarMediosDelegado(reproductorCassette.ProbarCassette);



            //++ 3-Utilizar delegados

            // Probar un vinilo
            inventarioMedios.ResultadoProbarMedios(probarDiscosDelegado);

            // Probar una cinta VHS
            inventarioMedios.ResultadoProbarMedios(probarCintasVhsDelegado);

            // Probar un CD
            inventarioMedios.ResultadoProbarMedios(probarCDDelegado);

            // Probar un cassette
            inventarioMedios.ResultadoProbarMedios(probarCassetteDelegado);



            //+ Utilizar los delegados de InfoMedios
            // Crear instancia del delegado para probar discos de vinilo
            InfoMediosDelegado InfoDiscosDelegado =
                new InfoMediosDelegado(tocaDiscos.ObtenerCancionesDisco);

            // Crear instancia del delegado para probar cintas vhs
            InfoMediosDelegado InfoVideosVhsDelegado =
            new InfoMediosDelegado(videoVhs.ObtenerCancionesVideoVhs);

            // Crear instancia del delegado para probar CD
            InfoMediosDelegado InfoCDDelegado =
                new InfoMediosDelegado(repCD.ObtenerCancionesCD);

            // Crear instancia del delegado para probar cassettes
            InfoMediosDelegado InfoCassetteDelegado =
                new InfoMediosDelegado(reproductorCassette.ObtenerCancionesCassette);

            inventarioMedios.ResultadoinfoMedios(InfoDiscosDelegado, "1314");
            inventarioMedios.ResultadoinfoMedios(reproductorCassette.ObtenerCancionesCassette, "6436"); //También se puede poner así
            inventarioMedios.ResultadoinfoMedios(videoVhs.ObtenerCancionesVideoVhs, "5435");
            inventarioMedios.ResultadoinfoMedios(repCD.ObtenerCancionesCD, "43643");


        }
    }
}