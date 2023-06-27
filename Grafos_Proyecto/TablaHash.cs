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

        public void MostrarTablaHash()
        {
            Console.WriteLine("Tabla Hash:");

            for (int i = 0; i < tamano; i++)
            {
                Console.Write($"Índice {i}: ");

                Nodo nodo = elementos[i];
                if (nodo != null)
                {
                    Console.Write($"{nodo.Dato}");

                    if (nodo.Enlaces.Count > 0)
                    {
                        Console.Write(" -> ");
                        foreach (Nodo enlace in nodo.Enlaces)
                        {
                            Console.Write($"{enlace.Dato} ");
                        }
                    }
                }
                else
                {
                    Console.Write("Vacío");
                }
                Console.WriteLine();
            }
        }

    }
}
