using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos_Proyecto
{
    internal class Nodo
    {
        public int Dato { get; set;}
        public List<Nodo> Enlaces { get; set;}

        public Nodo (int dato, Nodo enlace=null)
        {
            Dato = dato;
            Enlaces = new List<Nodo>();
        }
    }
}
