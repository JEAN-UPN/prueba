using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JP_S10_E1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        Arbol_BinarioBusqueda arbol = new Arbol_BinarioBusqueda();
        private void btn_Insertar_Click(object sender, EventArgs e)
        {

            int numero;

            if (int.TryParse(txt_Numero.Text, out numero))
            {
                arbol.Insertar(numero);

                txt_Numero.Clear();

                arbol.ActualizarListBox(listBox1);
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido.");
            }
        }
    }
}
