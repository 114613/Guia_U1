using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCompleto1._2
{
    public class Pila : IColleccion
    {
        private object[] elementos;
        private int contador;

        public Pila(int tam)
        {
            elementos = new object[tam];
            contador = 0;
        }

        public bool EstaVacia()
        {
            return contador == 0;
        }

        public object Extraer()
        {
            if (!EstaVacia())
            {
                contador--;
                object elemento = elementos[0];
                elementos[0] = null;
                return elemento;
            }
            else
            {
                return "La Pila está vacía, no se puede extraer";
            }
        }

        public object Primero()
        {
            if (!EstaVacia())
            {
                return elementos[0];
            }
            else
            {
                return "La Pila está vacía";
            }
        }

        public bool Aniadir(object elemento)
        {
            if(contador >= elementos.Length)
            {
                return false;
            }
            else
            {
                elementos[contador] = elemento;
                contador++;
                return true;
            }
        }
    }
}
