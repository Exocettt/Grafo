using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos_Proyecto
{
    internal class TablaHash
    {
        private Nodo[] elementos;
        private int tamano;

        public TablaHash(int tamano)
        {
            this.tamano = tamano;
            elementos = new Nodo[tamano];
        }

        private int FuncionHash(string clave)
        {
            int hashCode = clave.GetHashCode();
            int indice = Math.Abs(hashCode) % tamano;
            return indice;
        }

        public void Agregar(string clave, string dato)
        {
            int indice = FuncionHash(clave);

            if (elementos[indice] == null)
            {
                Nodo nuevoNodo = new Nodo(dato);
                elementos[indice] = nuevoNodo;
            }
            else
            {
                Nodo nodoExistente = elementos[indice];
                while (nodoExistente.Enlaces.Count > 0)
                {
                    nodoExistente = nodoExistente.Enlaces[0];
                }

                Nodo nuevoNodo = new Nodo(dato);
                nodoExistente.Enlaces.Add(nuevoNodo);
            }
        }

    }
}
