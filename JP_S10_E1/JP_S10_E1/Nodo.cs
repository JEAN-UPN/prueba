using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JP_S10_E1
{
    public  class Nodo
    {
        public int dato;
        public Nodo izquierda;
        public Nodo derecha;

        public Nodo(int valor)
        {
            dato = valor;
            izquierda = null;
            derecha = null;
        }
    }
}
