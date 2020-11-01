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
    public partial class Listar : Form
    {
        public delegate void accionBoton(int valor);
        public event accionBoton clickBoton;
        
        public DataGridView getDataGrid
        {
            get { return this.dataGridAlumno; }
        }

        public Listar()
        {
            InitializeComponent();
        }

        /*private void DataGridAlumno_Load(object sender, EventArgs e)
        {

        }*/

        private void dataGridAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            clickBoton(3);
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            clickBoton(0);
        }

        private void Listar_Load(object sender, EventArgs e)
        {

        }

        private void Listar_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
