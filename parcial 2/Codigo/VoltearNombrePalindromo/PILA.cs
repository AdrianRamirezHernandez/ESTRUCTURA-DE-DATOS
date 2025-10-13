using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoltearNombrePalindromo
{
    internal class PILA
    {
        private char[] elementos;
        private int tope;
        private int max;

        public PILA(int tamaño)
        {
            max = tamaño;
            elementos = new char[max];
            tope = -1;
        }

        public bool EstaVacia() => tope == -1;
        public bool EstaLlena() => tope == max - 1;

        public void Push(char valor)
        {
            if (!EstaLlena())
                elementos[++tope] = valor;
        }

        public char Pop()
        {
            if (!EstaVacia())
                return elementos[tope--];
            return '\0';
        }

        
    }
}
