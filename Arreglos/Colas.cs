using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Arreglos
{
    public class Colas
    {
        private string[] array;
        private int max;
        private int principio;
        private int final;

        public Colas(int tamanio)
        {
            this.array = new string[tamanio];
            this.max = array.Length - 1;
            this.principio = 0;
            this.final = 0;
        }

        private bool ValidaVacio() 
        {
            return ((principio < 1 && final < 1) || principio == final);
        }

        private bool ValidaLleno() 
        {
            return (final > max);
        }

        public void Agregar(string dato) 
        {
            if (ValidaLleno()) 
            {
                throw new Exception("arreglo lleno");
            }

            array[final] = dato;
            final++;
        }

        public void Eliminar() 
        {
            if (ValidaVacio()) 
            {
                throw new Exception("arreglo vacío");
            }

            array[principio] = null;
            principio++;
        }

        public string Imprimir() 
        {
            string datos = string.Empty;

            if (ValidaVacio()) 
            {
                return "arreglo vacío";
            }

            for(int i = principio; i < final; i++) 
            {
                if (i > principio) 
                {
                    datos += "\n";
                }

                datos += $"[{i}] - {array[i]}";
            }

            return datos;
        }
    }
}
