using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoBurbuja1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            int [] Arreglo= new int[4];
            int intDatos = 0;
            Random ramNumero = new Random();

            for (int i = 0; i < Arreglo.Length; i++)
            {
                intDatos = ramNumero.Next(0,10);
                Arreglo[i] = intDatos;
            }

            for(int i = 0;i < Arreglo.Length; i++)
            {
                Console.WriteLine(Arreglo[i]+"\n"   );
            }

            Ordenar(ref  Arreglo);

            Console.ReadKey();


        }
        public static void Ordenar( ref int[] Arreglo2)
        {
            for (int i = 0; i < Arreglo2.Length-1; i++)
            {

                for (int j = Arreglo2.Length-1; j > i; j--)
                {
                    if (Arreglo2[j] < Arreglo2[j - 1])
                    {
                        int intTemp = Arreglo2[j];
                        Arreglo2[j] = Arreglo2[j - 1];
                        Arreglo2[j - 1] = intTemp;

                    }
                }


            }
            for (int i = 0; i < Arreglo2.Length; i++)
            {
                Console.WriteLine(Arreglo2[i] + "\n");
            }



        }



    }
    
}
