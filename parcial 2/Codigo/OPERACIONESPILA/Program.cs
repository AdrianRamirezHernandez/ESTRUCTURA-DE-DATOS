using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERACIONESPILA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escribe una expresión: ");
            string expre = Console.ReadLine();

            Console.WriteLine(EsBalanceada(expre)
    ? "La expresión está correctamente balanceada"
                : " La expresión tiene error en los paréntesis");

            Console.ReadKey();
        }
        public static bool EsBalanceada(string expre)
        {
            PILA pila = new PILA(expre.Length);

            for(int i = 0; i < expre.Length; i++)
            {
                char c = expre[i];
                if (c == '(' || c == '[' || c == '{')
                {
                    pila.Push(c);
                }

                else if (c == ')' || c == ']' || c == '}')
                {
                    if (pila.EstaVacia())
                    {
                        return false;
                    }
                    char simbolo = pila.Pop();

                    if (!Coinciden(simbolo, c))
                    {
                        return false;
                    }
                }
            }

            return pila.EstaVacia();
        }

        private static bool Coinciden(char apertura, char cierre)
        {
            return (apertura == '(' && cierre == ')') ||
                   (apertura == '[' && cierre == ']') ||
                   (apertura == '{' && cierre == '}');
        }
    }
}
