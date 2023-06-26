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
                    nodoOrigen.Enlace = nodoDestino;
                }
            }


            public void MostrarGrafo()
            {
                foreach (Nodo nodo in nodos)
                {
                    Console.Write("" + nodo.Dato + " -> ");
                    if (nodo.Enlace != null)
                    {
                        Console.WriteLine(nodo.Enlace.Dato);
                    }
                    else
                    {
                        Console.WriteLine("No tiene enlaces");
                    }
                }
            }
        }
    }

