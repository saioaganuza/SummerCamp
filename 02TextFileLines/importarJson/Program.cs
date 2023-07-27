using Newtonsoft.Json;

namespace importarJson
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string json = @"{
            //  'Name': 'Bad Boys',
            //  'ReleaseDate': '1995-4-7T00:00:00',
            //  'Genres': [
            //    'Action',
            //    'Comedy'
            //  ]
            //}";

            //Movie m = JsonConvert.DeserializeObject<Movie>(json);

            //string name = m.Name;


            string monedas = File.ReadAllText("monedas.json");
            List<Moneda> Lista_monedas = JsonConvert.DeserializeObject<List<Moneda>>(monedas);            foreach (var moneda in Lista_monedas)            {                Console.WriteLine(moneda.nombre);            }

        }
    }
}