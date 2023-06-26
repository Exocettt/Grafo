using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos_Proyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grafo grafo = new Grafo();
            grafo.AgregarNodo(0);
            grafo.AgregarNodo(1);
            grafo.AgregarNodo(2);
            grafo.AgregarNodo(3);
            grafo.AgregarNodo(4);

            grafo.AgregarArista(0, 1);
            grafo.AgregarArista(0, 4);
            grafo.AgregarArista(1, 2);
            grafo.AgregarArista(1, 3);
            grafo.AgregarArista(1, 4);
            grafo.AgregarArista(2, 3);
            grafo.AgregarArista(3, 4);

            grafo.MostrarGrafo();

            Console.ReadLine();
        }
    }
}
