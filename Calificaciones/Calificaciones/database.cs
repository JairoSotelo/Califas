using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Calificaciones
{
 
    public class database
    {

        public static MySqlConnection conn = new MySqlConnection("server=127.0.0.1; database=calificaciones; Uid=jairo; pwd=12345");
        MySqlCommand code = new MySqlCommand();
        MySqlCommand test = new MySqlCommand();
        MySqlConnection connecting = new MySqlConnection();
      

           

        public void registrar(string nombre, string apellido, int u1, int u2, int u3,double promedio)
        {
            conn.Open();
            code.Connection = conn;
            test.Connection = conn;
            code.CommandText = ("INSERT INTO `calificaciones`(`nombre`, `apellido`, `U1`, `U2`, `U3`, `promedio`) VALUES ('" + nombre + "','" + apellido + "','" + u1 + "','" + u2 + "','" + u3 + "','" + promedio + "')  ");
            MySqlDataReader read = code.ExecuteReader();
            conn.Close();

        }
        public void eliminar(string nombre2, string apellido2)
        {
            conn.Open();
            code.Connection = conn;
            test.Connection = conn;
            code.CommandText = ("DELETE FROM `calificaciones` WHERE `nombre`= '" + nombre2 + "' and `apellido`='" + apellido2 + "' )  ");
            MySqlDataReader read = code.ExecuteReader();
            conn.Close();

            if (read.Read())
            {
                MessageBox.Show("Historial de  '" + nombre2 + "'  '" + apellido2 + "' fue eliminado");
               
            }
            else
            {
                MessageBox.Show("Este alumno no existe");

            }
        }
        public static void TestConn()
        {
            try
            {
                conn.Open();
                MessageBox.Show("Conectado a BD");
                conn.Close();
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message);
            }
            finally { conn.Close(); }
        }

        public static DataTable consulta()
        {
            DataTable table1 = new DataTable();
            try
            {

                MySqlDataAdapter msj = new MySqlDataAdapter(string.Format("select* from calificaciones "), conn);

                conn.Open();
                msj.Fill(table1);
                conn.Close();
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message);
            }
            finally { conn.Close(); }

            return table1;
        }

    }

}
