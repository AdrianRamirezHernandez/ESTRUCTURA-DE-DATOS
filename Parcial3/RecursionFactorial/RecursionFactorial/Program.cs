using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intResultado = 0;
            int intNumFac = 0;
            Console.WriteLine("Coloque el numero que quiere calcular su factorial");
            intNumFac= int.Parse(Console.ReadLine());
            if (intNumFac > 0)
            {
                int Contador = intNumFac - 1;
                CalcularFac(intNumFac, ref Contador, ref intResultado);
            }
            else
            {
                Console.WriteLine("Si haz colocado 0, debes de saber que su factorial es 1" + "\n" +
                    "SI haz colocado uno negativo, no se aceptan numeros negativos");
            }

             
            Console.ReadKey();
        }
        static void CalcularFac(int Numero, ref int Contador, ref int Resultado)
        {
            if (Contador==1) 
            {
                Console.WriteLine("EL RESULTADO ES:");
                Console.WriteLine( Resultado= Resultado * Contador);
            }
            else
            {
               Resultado =Numero* Contador;
                Numero--;
                Contador--;
                CalcularFac( Numero, ref  Contador, ref  Resultado);

            }
        }
    }
}
