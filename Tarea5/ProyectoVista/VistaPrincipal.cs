using System;
using System.Windows.Forms;

namespace Biblioteca.Vista
{
    public partial class VistaPrincipal : Form
    {
        public delegate void accionBoton(int valor);
        public event accionBoton clickBoton;


        Buscar vistaBuscar = new Buscar();
        Listar vistaListar = new Listar();
        public VistaPrincipal()
        {
            InitializeComponent();
        }
       
       
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            clickBoton(1);
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            clickBoton(2);
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            clickBoton(0);
        }

        private void VistaPrincipal_Load(object sender, EventArgs e)
        {

        }

        public void VistaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("¿Seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo);
            if (confirmar == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (confirmar == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
