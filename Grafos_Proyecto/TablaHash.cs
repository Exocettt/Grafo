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
    }
}
