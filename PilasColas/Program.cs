using Arreglos;
using Listas;
using System;

namespace PilasColas
{
    class Program
    {
        static void Main(string[] args)
        {
            ListasColas();
        }

        static void ArregloPilas() 
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
        static void ArregloColas() 
        {
            try
            {
                Arreglos.Colas colas = new Arreglos.Colas(5);

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

        static void ListasPilas()
        {
            try
            {
                Listas.Pilas pila = new Listas.Pilas();

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
        static void ListasColas()
        {
            try
            {
                Listas.Colas colas = new Listas.Colas();

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
