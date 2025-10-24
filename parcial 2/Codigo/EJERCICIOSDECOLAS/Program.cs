using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOSDECOLAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resultado = "";
            Console.WriteLine("COLOQUE SU CADENA DE TEXTO ");
            string Cadena = Console.ReadLine();

            Cola unaCola = new Cola(Cadena.Length);
            foreach (char i in Cadena)
            {
                if (!unaCola.Contiene(i))
                {
                    unaCola.Insertar(i);
                }
            }

            while (!unaCola.EstaVacia())
            {
                char letra= unaCola.Eliminar();
                resultado += letra;
            }
            Console.WriteLine("La cadena sin duplicados es "+ resultado  );
            


            Console.ReadKey();  


        }
    }
}
