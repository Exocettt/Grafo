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
            grafo.AgregarNodo("Hola");
            grafo.AgregarNodo("Mundo!!");
            grafo.AgregarNodo("Como");
            grafo.AgregarNodo("Usar");
            grafo.AgregarNodo("C#");

            grafo.AgregarArista("Hola", "Mundo");
            grafo.AgregarArista("Hola", "C#");
            grafo.AgregarArista("Mundo", "Como");
            grafo.AgregarArista("Mundo", "Usar");
            grafo.AgregarArista("Mundo", "C#");
            grafo.AgregarArista("Como", "Usar");
            grafo.AgregarArista("Usar", "C#");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------");
            Console.WriteLine("------Grafo------");
            Console.WriteLine("-----------------");
            Console.ForegroundColor = ConsoleColor.White;
            grafo.MostrarGrafo();

            Console.ReadLine();
        }
    }
}
