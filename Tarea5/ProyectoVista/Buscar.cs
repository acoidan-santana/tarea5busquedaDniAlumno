using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Vista
{
    public partial class Buscar : Form
    {
        public delegate void accionBoton(int valor);
        public event accionBoton clickBoton;

        public TextBox getTextBoxApe1
        {
            get { return this.textBoxApe1; }
        }

        public TextBox getTextBoxApe2
        {
            get { return this.textBoxApe2; }
        }

        public TextBox getTextBoxNombre
        {
            get { return this.textBoxNombre; }
        }

        public TextBox getTextBoxDni
        {
            get { return this.textBoxDni; }
        }

        public string getTxtDni
        {
            get { return this.textBoxDni.Text; }
        }

        public Buscar()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            clickBoton(4);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            clickBoton(5);
        }

        private void textBoxDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buscar_Load(object sender, EventArgs e)
        {

        }

        private void textBoxApe1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxApe2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            clickBoton(0);
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            clickBoton(3);
        }

        private void Buscar_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
