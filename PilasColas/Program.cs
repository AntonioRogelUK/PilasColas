using Arreglos;
using System;

namespace PilasColas
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                ArrayPilas pila = new ArrayPilas(5);

                pila.Agregar("Cero");
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("---------");
                pila.Agregar("Uno");
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("---------");
                pila.Agregar("Dos");
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("---------");
                pila.Agregar("Tres");
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("---------");
                pila.Agregar("Cuatro");
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("---------");
                pila.Agregar("Cinco");
                Console.WriteLine(pila.Imprimir());


                Console.WriteLine("---------");
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("---------");
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("---------");
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("---------");
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("---------");
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        
        }
    }
}
