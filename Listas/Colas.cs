﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Listas
{
    public class Colas
    {
        private List<string> lista;
        public Colas()
        {
            lista = new List<string>();
        }

        public void Agregar(string dato) 
        {
            lista.Add(dato);
        }

        private bool ValidaVacio()
        {
            return (lista.Count == 0);
        }

        public void Eliminar() 
        {
            if (ValidaVacio()) 
            {
                throw new Exception("Lista vacía");
            }

            lista.RemoveAt(0);
        }

        public string Imprimir() 
        {
            string datos = string.Empty;

            if (ValidaVacio()) 
            {
                return "lista vacía";
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
