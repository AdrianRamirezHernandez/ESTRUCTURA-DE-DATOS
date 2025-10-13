using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERACIONESPILA
{
    internal class PILA
    {
        private char[] elementos;
        private int tope;
        private int max;

        public PILA(int tamano)
        {
            max = tamano;
            elementos = new char[max];
            tope = -1;
        }

        public bool EstaVacia()
        {
            if(tope == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EstaLlena() {
            if(tope == max - 1)
            {
                return true;
            }
            else { return false;}
                }

        public void Push(char valor)
        {
            if (!EstaLlena())
            {
                elementos[++tope] = valor;
            }
        }

        public char Pop()
        {
            if (!EstaVacia())
            {
                return elementos[tope--];
            }
            return '\0';
        }

       
    }
}
