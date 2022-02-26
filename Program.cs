using System;

namespace LeerTeclado
{
    /// <summary>
    /// Leer datos del teclado
    ///</sumary>
    class LeerTeclado
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma de números");
            Console.Write("Ingresa número 1: ");
            // los datos se leen como cadena
            string dato = Console.ReadLine();
            // convertir a numero con int.Parse
            int n1 = int.Parse(dato);

            Console.WriteLine("Ingresa número 2: ");
            dato = Console.ReadLine();
            int n2 = int.Parse(dato);
            int suma = n1 + n2;
            Console.WriteLine("El resultado es: {0}", suma);
        }
    }
}
