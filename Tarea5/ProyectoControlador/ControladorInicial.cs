using System;
using MySql.Data.MySqlClient;
using Biblioteca.Modelo;
using System.Windows.Forms;
using Biblioteca.Vista;
using System.Data.SqlTypes;

namespace Biblioteca.Controlador
{
    public class ControladorInicial
    {

        VistaPrincipal vista;
        Buscar vistaBuscar;
        Listar vistaListar;
        Conexion conector;
        
        MySqlConnection conexionBaseDatos
        {
            get;
            set;
        }


        public void Iniciar()
        {
            conector = new Conexion();
            vista = new VistaPrincipal();
            vistaBuscar = new Buscar();
            vistaListar = new Listar();

            AsignarBoton(vista, vistaBuscar, vistaListar);

            conector.CrearConexion();
            conexionBaseDatos = conector.conexionBD;

            vista.ShowDialog();
        }
        private void AsignarBoton(VistaPrincipal vistaP, Buscar vistaB, Listar vistaL)
        {
            vistaP.clickBoton += ClickBoton;
            vistaB.clickBoton += ClickBoton;
            vistaL.clickBoton += ClickBoton;
        }

        private void ClickBoton(int valor)
        {
            switch (valor)
            {
                case 0: 
                    Application.Exit();
                    break;
                case 1:
                    vista.Visible = false;
                    vistaBuscar.ShowDialog();
                    break;
                case 2:
                    vista.Visible = false;
                    LlenarTabla();
                    vistaListar.ShowDialog();
                    break;
                case 3:
                    VentanaAnterior();
                    break;
                case 4:
                    BuscarAlumno();
                    break;
                case 5:
                    EliminarAlumno();
                    break;
            }
        }
        public void VentanaAnterior()
        {
            vistaBuscar.Visible = false;
            vistaListar.Visible = false;
            vista.Visible=true;
        }

        public void LlenarTabla()
        {
            try
            {
                vistaListar.getDataGrid.DataSource = conector.LlenarGrid().Tables[0];
            }
            catch (SqlNullValueException e)
            {
                MessageBox.Show("El valor es nulo \n" + e);
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show("La operación no es válida \n" + e);
            }
            catch (NotSupportedException e)
            {
                MessageBox.Show("el método no está soportado \n" + e);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("ha habido un error con la obtencion de datos SQL \n" + e);
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error \n" + e);
            }
        }

        public void BuscarAlumno()
        {
            
            try
            {
                string dni = vistaBuscar.getTxtDni;
                string consulta = "Select * from alumnos where dni= '" + dni + "'";
                BusquedaAlumno(dni, consulta);

            }
            catch (SqlNullValueException e)
            {
                MessageBox.Show("El valor es nulo \n" + e);
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show("La operación no es válida \n" + e);
            }
            catch (NotSupportedException e)
            {
                MessageBox.Show("el método no está soportado \n" + e);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("ha habido un error con la obtencion de datos SQL \n" + e);
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error \n" + e);
            }
            
        }

        public void BusquedaAlumno(string vDni, string vConsulta)
        {
            MySqlCommand comando = new MySqlCommand(vConsulta, conexionBaseDatos);

            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    vistaBuscar.getTextBoxApe1.Text = Convert.ToString(reader.GetString("apellido1"));
                    vistaBuscar.getTextBoxApe2.Text = Convert.ToString(reader.GetString("apellido2"));
                    vistaBuscar.getTextBoxNombre.Text = Convert.ToString(reader.GetString("nombre"));
                }
            }
            else
            {
                MessageBox.Show("El alumno no existe");
            }

            reader.Close();
        }

        public void EliminarAlumno()
        {
            string dni = vistaBuscar.getTxtDni;
            string codDni = dni.Remove(dni.Length - 1);
            try
            {
                ComprobarYBorrarAlumno( codDni, dni);
            }
            catch(FormatException e)
            {
                MessageBox.Show("Error de formato\n" + e);
            }
            catch (SqlNullValueException e)
            {
                MessageBox.Show("El valor es nulo \n" + e);
            }
            catch (IndexOutOfRangeException e)
            {
                MessageBox.Show("El valor actual no existe \n" + e);
            }
            
        }

        public void ComprobarYBorrarAlumno(string vCodDni, string vDni)
        {
            int vNDni = Int32.Parse(vCodDni);
            string consulta = "Select * from prestamos where codAlumno= '" + vNDni + "'";
            MySqlCommand comando = new MySqlCommand(consulta, conexionBaseDatos);

            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                MessageBox.Show("No se puede eliminar un alumno con préstamo de libro");
                reader.Close();
            }
            else
            {
                reader.Close();
                string consultaBorrar = "Delete from alumnos where dni= '" + vDni + "'";
                using (MySqlCommand comandoBorrar = new MySqlCommand(consultaBorrar, conexionBaseDatos))
                {
                    comandoBorrar.ExecuteNonQuery();
                }
                MessageBox.Show("El alumno ha sido eliminado");
                vistaBuscar.getTextBoxApe1.Text = "";
                vistaBuscar.getTextBoxApe2.Text = "";
                vistaBuscar.getTextBoxNombre.Text = "";
                vistaBuscar.getTextBoxDni.Text = "";
            }
        }

    }

}
