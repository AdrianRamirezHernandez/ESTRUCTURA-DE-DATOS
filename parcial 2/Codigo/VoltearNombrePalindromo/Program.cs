using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoltearNombrePalindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            string strPalabra="";
            string strResultado = "";
            Console.WriteLine("VOLTEAR  PALABRA Y VER SI ES PALINDROMO");
            Console.WriteLine("Coloca la palabra");
             strPalabra=Console.ReadLine();
            PILA unaPila= new PILA(strPalabra.Length);
            for (int i = 0; i < strPalabra.Length; i++) {

                char c = strPalabra[i];
                unaPila.Push(c);
            }
            
            while (!unaPila.EstaVacia()  )
            {
                char c = unaPila.Pop();
                strResultado = strResultado +c;
            }
            Console.WriteLine("Su palabra al reves es : "+strResultado);
            if (strResultado == strPalabra)
            {
                Console.WriteLine("SU PALABRA ES PALINDROMO");
            }
            else
            {
                Console.WriteLine("SU PALABRA NO ES PALINDROMO");
            }
            
            Console.ReadKey();
        }
    }
}
