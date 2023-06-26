using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos_Proyecto
{
    internal class Lista
    {
        class Grafo
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
        }
    }
}
