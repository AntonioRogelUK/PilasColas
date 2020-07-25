using System;
using System.Collections.Generic;
using System.Text;

namespace Arreglos
{
    public class Pilas
    {
        private string[] array;
        private int max;
        private int tope;

        public Pilas(int tamanio)
        {
            this.array = new string[tamanio];
            this.tope = 0;
            this.max = array.Length - 1;
        }

        private bool ValidaVacio()
        {
            return (tope < 1);
        }

        private bool ValidaLleno()
        {
            return (tope > max);
        }

        public void Agregar(string dato)
        {
            if (ValidaLleno())
            {
                throw new Exception("arreglo lleno");
            }

            array[tope] = dato;
            tope++;
        }

        public void Eliminar()
        {
            if (ValidaVacio())
            {
                throw new Exception("arreglo vacío");
            }

            tope--;
            array[tope] = null;
        }

        public string Imprimir()
        {
            string dato = string.Empty;

            if (ValidaVacio())
            {
                return "arreglo vacío";
            }

            for (int i = 0; i < tope; i++)
            {
                if (i > 0)
                {
                    dato += "\n";
                }

                dato += $"[{i}] - {array[i]}";
            }

            return dato;
        }
    }
}
