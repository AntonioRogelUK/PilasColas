using Arreglos;
using System;

namespace PilasColas
{
    class Program
    {
        static void Main(string[] args)
        {

            Colas();
        
        }

        static void Pilas() 
        {
            try
            {
                Arreglos.Pilas Arraypila = new Arreglos.Pilas(5);

                //pila.Agregar("Cero");
                //Console.WriteLine(pila.Imprimir());

                //Console.WriteLine("---------");
                //pila.Agregar("Uno");
                //Console.WriteLine(pila.Imprimir());

                //Console.WriteLine("---------");
                //pila.Agregar("Dos");
                //Console.WriteLine(pila.Imprimir());

                //Console.WriteLine("---------");
                //pila.Agregar("Tres");
                //Console.WriteLine(pila.Imprimir());

                //Console.WriteLine("---------");
                //pila.Agregar("Cuatro");
                //Console.WriteLine(pila.Imprimir());


                //Console.WriteLine("---------");
                //pila.Eliminar();
                //Console.WriteLine(pila.Imprimir());

                //Console.WriteLine("---------");
                //pila.Eliminar();
                //Console.WriteLine(pila.Imprimir());

                //Console.WriteLine("---------");
                //pila.Eliminar();
                //Console.WriteLine(pila.Imprimir());

                //Console.WriteLine("---------");
                //pila.Eliminar();
                //Console.WriteLine(pila.Imprimir());

                //Console.WriteLine("---------");
                //pila.Eliminar();
                //Console.WriteLine(pila.Imprimir());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Colas() 
        {
            try
            {
                Colas colas = new Colas(5);

                Console.WriteLine(colas.Imprimir());
                colas.Agregar("Cero");
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Agregar("Uno");
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Agregar("Dos");
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Agregar("Tres");
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Agregar("Cuatro");
                Console.WriteLine(colas.Imprimir());


                Console.WriteLine("---------");
                colas.Eliminar();
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Eliminar();
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Eliminar();
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Eliminar();
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Eliminar();
                Console.WriteLine(colas.Imprimir());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
