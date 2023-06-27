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
            grafo.ANodo("Hola");
            grafo.ANodo("Mundo!!");
            grafo.ANodo("Como");
            grafo.ANodo("Usar");
            grafo.ANodo("C#");

            grafo.Arista("Hola", "Mundo");
            grafo.Arista("Hola", "C#");
            grafo.Arista("Mundo", "Como");
            grafo.Arista("Mundo", "Usar");
            grafo.Arista("Mundo", "C#");
            grafo.Arista("Como", "Usar");
            grafo.Arista("Usar", "C#");

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
