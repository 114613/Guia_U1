﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCompleto1._2
{
    public interface IColleccion
    {
        bool EstaVacia();
        object Extraer();
        object Primero();
        bool Aniadir(object elemento);
    }
}
