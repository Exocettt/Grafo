using System;
using System.Collections.Generic;
using System.Linq;
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

            public void AgregarNodo(int dato)
            {
                Nodo nuevoNodo = new Nodo(dato);
                nodos.Add(nuevoNodo);
            }

            private Nodo BuscarNodo(int dato)
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

            public void AgregarArista(int valorOrigen, int valorDestino)
            {
                Nodo nodoOrigen = BuscarNodo(valorOrigen);
                Nodo nodoDestino = BuscarNodo(valorDestino);

                if (nodoOrigen != null && nodoDestino != null)
                {
                    nodoOrigen.Enlaces.Add(nodoDestino);
                }
            }


            public void MostrarGrafo()
            {
                foreach (Nodo nodo in nodos)
                {
                Console.Write($"Nodo {nodo.Dato} -> ");

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

