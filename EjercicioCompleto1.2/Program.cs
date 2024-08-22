using EjercicioCompleto1._2;

public static class Program
{
    public static void Main()
    {
        Pila oPila = new Pila(3);

        Console.WriteLine(oPila.EstaVacia());
        Console.WriteLine(oPila.Extraer());
        Console.WriteLine(oPila.Primero());
        Console.WriteLine(oPila.Aniadir("manzana"));

        Console.WriteLine(oPila.EstaVacia());
        Console.WriteLine(oPila.Extraer());
        Console.WriteLine(oPila.Primero());
        Console.WriteLine(oPila.Aniadir("banana"));

        Console.WriteLine(oPila.EstaVacia());
        Console.WriteLine(oPila.Extraer());
        Console.WriteLine(oPila.Primero());
        Console.WriteLine(oPila.Aniadir("durazno"));

        Console.WriteLine(oPila.EstaVacia());
        Console.WriteLine(oPila.Extraer());
        Console.WriteLine(oPila.Primero());
        Console.WriteLine(oPila.Aniadir("pera"));

        Console.WriteLine(oPila.EstaVacia());
        Console.WriteLine(oPila.Extraer());
        Console.WriteLine(oPila.Primero());
        Console.WriteLine(oPila.Aniadir("sandia"));

        Console.WriteLine(oPila.Primero());


        Cola oCola = new Cola();

        Console.WriteLine(oCola.EstaVacia());
        Console.WriteLine(oCola.Extraer());
        Console.WriteLine(oCola.Primero());
        Console.WriteLine(oCola.Aniadir("manzana"));

        Console.WriteLine(oCola.EstaVacia());
        Console.WriteLine(oCola.Extraer());
        Console.WriteLine(oCola.Primero());
        Console.WriteLine(oCola.Aniadir("banana"));

        Console.WriteLine(oCola.EstaVacia());
        Console.WriteLine(oCola.Extraer());
        Console.WriteLine(oCola.Primero());
        Console.WriteLine(oCola.Aniadir("pera"));

        Console.WriteLine(oCola.Primero());
    }
}
