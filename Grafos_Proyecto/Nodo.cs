using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos_Proyecto
{
    internal class Nodo
    {
        public string Dato { get; set;}
        public List<Nodo> Enlaces { get; set;}

        public Nodo (string dato)
        {
            Dato = dato;
            Enlaces = new List<Nodo>();
        }
    }
}
