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

            private List<Nodo> nodos;

            public Grafo()
            {
                nodos = new List<Nodo>();
            }

            public void ANodo(string dato)
            {
                Nodo nuevoNodo = new Nodo(dato);
                nodos.Add(nuevoNodo);
            }

            private Nodo BuscarNodo(string dato)
            {
                foreach (Nodo nodo in nodos)
                {
                    if (nodo.Dato == dato)
                    {
                        return nodo;
                    }
                }
                return null;
            }

            public void Arista(string Origen, string Destino)
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
                foreach (Nodo nodo in nodos)
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
    }
}

