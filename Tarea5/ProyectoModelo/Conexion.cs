using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System;

namespace Biblioteca.Modelo
{
    public class Conexion
    {
        string consulta = "";
        string cadenaConexion
        {
            get;
            set;
        }

        public MySqlConnection conexionBD
        {
            get;
            set;
        }

        public string InicializarCadena()
        {
            string servidor = "localhost";
            string bd = "libros";
            string usuario = "root";
            string password = "root";
            try
            {
                cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";
            } catch (MySqlException e)
            {
                MessageBox.Show("Ha ocurrido un error con Sql \n" + e);
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error \n" + e);
            }
            return cadenaConexion;
        }

        public void CrearConexion()
        {
            InicializarCadena();

            try
            {
                conexionBD = new MySqlConnection(cadenaConexion);
                conexionBD.Open();
                MessageBox.Show("Conectado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido conectar \n" + ex);
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error \n" + e);
            }

        }

        public DataSet LlenarGrid()
        {
            DataSet ds = new DataSet();
            try
            {
                consulta = "Select * from alumnos";
                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conexionBD);
                
                adapter.Fill(ds);
            } catch (MySqlException e)
            {
                MessageBox.Show("Ha habido un error al llenar la tabla \n" + e);
            } catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error \n" + e);
            }
            return ds;
        }
    }
}
