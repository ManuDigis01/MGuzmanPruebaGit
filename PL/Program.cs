using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Program
    {
        static void Main(string[] args)
        {
            ML.Result result = BL.Pintura.GetAll();

            foreach (ML.Pintura cineLocal in result.Objects)
            {

                Console.WriteLine("Nombre Color: " + cineLocal.Color);
                Console.WriteLine("Fecha De Produccion: " + cineLocal.FechaDeProduccion);
                Console.WriteLine("Fecha De Caducacion: " + cineLocal.FechaDeCaducacion);
                
                Console.WriteLine("----------------------------------------");

            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
