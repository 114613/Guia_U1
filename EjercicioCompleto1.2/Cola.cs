using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCompleto1._2
{
    public class Cola : IColleccion
    {
        private List<object> elementos;

        public Cola()
        {
            elementos = new List<object>();
        }

        public bool EstaVacia()
        {
            return elementos.Count == 0;
        }

        public object Extraer()
        {
            if (!EstaVacia())
            {
                object elemento = elementos[0];
                elementos.RemoveAt(0);
                return elemento;
            }
            else
            {
                return "La Lista está vacía, no se puede extraer ningún elemento";
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
                return "La Lista está vacía";
            }
        }

        public bool Aniadir(object elemento)
        {
            elementos.Insert(0, elemento);
            return true;
        }
    }
}
