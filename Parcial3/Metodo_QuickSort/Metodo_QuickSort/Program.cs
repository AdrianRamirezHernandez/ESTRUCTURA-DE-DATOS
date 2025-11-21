using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            int[] Arreglo = { 2,1,6,9,2,8,4,7};

            Console.WriteLine("Antes de usar el metodo"+"\n");
            foreach (int i in Arreglo)
            {
                Console.WriteLine(i);
            }
            OrdernarQuicksort(ref Arreglo,0,Arreglo.Length-1);
            Console.WriteLine("LLISto");

            foreach (int i in Arreglo)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

        }

        public static void OrdernarQuicksort( ref  int [] Arreglo,int intInicio,int intFinal )
        {
            if (intInicio < intFinal) 
            {

                int intPivote = Partircionar(ref Arreglo, intInicio, intFinal);
                OrdernarQuicksort(ref Arreglo,intInicio,intPivote-1);
                OrdernarQuicksort(ref Arreglo,intPivote+1,intFinal);


            }

        }
        public static int Partircionar( ref int[] Arreglo, int intInicio, int intFinal)
        {



             int intPivote = Arreglo[intFinal];
               int i = intInicio - 1;

               for (int j = intInicio; j <= intFinal - 1; j++)
               {
                   if (Arreglo[j] < intPivote)
                   {
                       i++;
                       Cambiar(ref Arreglo, i, j);

                   }
               }
               Cambiar(ref Arreglo, i + 1, intFinal);

               return i + 1;


           /* int pivote = Arreglo[(intInicio + intFinal) / 2];  // ← pivote en medio
            int i = intInicio;
            int j = intFinal;

            while (i <= j)
            {
                while (Arreglo[i] < pivote)
                    i++;

                while (Arreglo[j] > pivote)
                    j--;

                if (i <= j)
                {
                    Cambiar(ref Arreglo, i, j);
                    i++;
                    j--;
                }
            }

            return i;*/




        }
        public static void Cambiar(ref int [] Arreglo,int a, int b )
        {
            int temp = Arreglo[a];
            Arreglo[a] = Arreglo[b];
            Arreglo[b] = temp;


        }



    }
}
