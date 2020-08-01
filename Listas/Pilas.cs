using System;
using System.Collections.Generic;
using System.Text;

namespace Listas
{
    public class Pilas
    {
        private List<string> lista;
        public Pilas()
        {
            lista = new List<string>();
        }

        public void Agregar(string dato) 
        {
            lista.Add(dato);
        }

        private bool ValidaVacio() 
        {
            //Regresa bool con if
            //if (lista.Count == 0) 
            //{
            //    return true;
            //}
            //else 
            //{
            //    return false;
            //}
            
            //Regresa bool con un operador ternario
            //return (lista.Count == 0) ? true : false;

            //If es una operacion booleana,
            //si la condicion se cumple, regresa true
            //si no se cumple regresa false
            //por lo tanto, se puede simplificar de la siguiente manera
            return (lista.Count == 0);
        }
        
        public void Eliminar() 
        {
            if (ValidaVacio()) 
            {
                throw new Exception("Lista vacía");
            }

            lista.RemoveAt(lista.Count - 1);
        }

        public string Imprimir() 
        {
            string datos = string.Empty;

            if (ValidaVacio()) 
            {
                return "Lista vacía";
            }

            int lstCount = lista.Count;
            for (int i = 0; i < lstCount; i++) 
            {
                if (i > 0) 
                {
                    datos += "\n";
                }

                datos += $"[{i}] - {lista[i]}";
            }

            return datos;
        }
    }
}
