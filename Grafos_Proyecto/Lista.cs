using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Grafos_Proyecto
{
    internal class Grafo
    {

        private Dictionary<string, Nodo> nodos;

        public Grafo()
        {
            nodos = new Dictionary<string, Nodo>();
        }

        public void AgregarNodo(string dato)
        {
            Nodo nuevoNodo = new Nodo(dato);
            nodos[dato] = nuevoNodo;
        }
            
        private Nodo BuscarNodo(string dato)
        {
            if (nodos.ContainsKey(dato))
            {
                return nodos[dato];
            }
            return null;
        }

        public void AgregarArista(string Origen, string Destino)
        {
            Nodo nOrigen = BuscarNodo(Origen);
            Nodo nDestino = BuscarNodo(Destino);

            if (nOrigen != null && nDestino != null)
            {
                nOrigen.Enlaces.Add(nDestino);
            }
        }


        public void MostrarGrafo()
        {
            Console.WriteLine("Grafo:");

            foreach (Nodo nodo in nodos.Values)
            {
                Console.Write($"Nodo: {nodo.Dato} -> ");

                if (nodo.Enlaces.Count > 0)
                {
                    foreach (Nodo enlace in nodo.Enlaces)
                    {
                        Console.Write($"{enlace.Dato} ");
                    }
                }
                else
                {
                    Console.Write("No tiene enlaces");
                }
                Console.WriteLine();
            }
        }

        public Dictionary<string, Nodo> ObtenerNodos()
        {
            return nodos;
        }
    }
}

