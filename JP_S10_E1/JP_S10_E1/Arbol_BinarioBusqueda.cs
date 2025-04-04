using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JP_S10_E1
{
    public class Arbol_BinarioBusqueda
    {
        private Nodo raiz;

        public Arbol_BinarioBusqueda()
        {
            raiz = null;
        }

        public void Insertar(int valor)
        {
            if (raiz == null)
            {
                raiz = new Nodo(valor);
            }
            else
            {
                InsertarRecursivo(raiz, valor);
            }
        }

        private void InsertarRecursivo(Nodo nodoActual, int valor)
        {
            if (valor < nodoActual.dato)
            {
                if (nodoActual.izquierda == null)
                {
                    nodoActual.izquierda = new Nodo(valor);
                }
                else
                {
                    InsertarRecursivo(nodoActual.izquierda, valor);
                }
            }
            else
            {
                if (nodoActual.derecha == null)
                {
                    nodoActual.derecha = new Nodo(valor);
                }
                else
                {
                    InsertarRecursivo(nodoActual.derecha, valor);
                }
            }
        }

        public void MostrarEnOrden(Nodo nodo, ListBox listBox)
        {
            if (nodo != null)
            {
                MostrarEnOrden(nodo.izquierda, listBox);  

                listBox.Items.Add(nodo.dato);

                MostrarEnOrden(nodo.derecha, listBox);    
            }
        }

        public void ActualizarListBox(ListBox listBox)
        {
            listBox.Items.Clear();

            MostrarEnOrden(raiz, listBox);
        }
    }
}

