using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOSDECOLAS
{
    internal class Cola
    {
        private int Max = 0;
        private char[] Arreglo;
        private int frente;
        private int final;
        private int tamano;
       
        public Cola (int Max)
        {
            this.Max = Max;
            Arreglo=new char[Max];
            frente = 0;
            final = -1;
            tamano = 0;
        }
        public bool EstaVacia()
        {
            return tamano == 0;
        }
        public bool EstaLLena()
        {
            return tamano == Max;
        }

        public void Insertar(char valor)
        {
            if (EstaLLena())
            {
                Console.WriteLine("Ësta LLena");
            }
            final = (final + 1) % Max;
            Arreglo[final] = valor;
            tamano++;
        }
        public char Eliminar()
        {
            if (EstaVacia()) {
                Console.WriteLine("Esta vacia");
                return '0';
            }
            char valor = Arreglo[frente];
            frente = (frente + 1) % Max;
            tamano--;
            return valor;
        }
        public bool Contiene(char Valor)
        {
            for (int i = 0; i < tamano; i++) {
            
                int indice=(frente+i) % Max;
                if (Arreglo[indice] == Valor) {

                    return true;
                 }    
            }
            return false;
        }




    }
}
