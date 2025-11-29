using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoInsercion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int [] Arreglo = {3,4,6,2,7,3,8,1};

            Console.WriteLine("Su arreglo es");
            for(int i = 0; i < Arreglo.Length - 1; i++)
            {
                Console.WriteLine(Arreglo[i]);
            }
            Console.WriteLine("ARREGLO ORDENADO");
            OrdenarInsercion(Arreglo);
        }
        static void OrdenarInsercion( int[]Arreglo)
        {
            int Aux;
            int j;
            for (int i = 0; i < Arreglo.Length-1; i++)
            {
                Aux = Arreglo[i];
                j = i - 1;
                while (j>=0 && Arreglo[j]>Aux)
                {
                    Arreglo[j + 1] = Arreglo[j];
                    j--;
                }
                Arreglo[j + 1] = Aux;
            }

            for (int Joss = 0; Joss < Arreglo.Length - 1; Joss++)
            {
                Console.WriteLine(Arreglo[Joss]);
            }
        }
    }
}
