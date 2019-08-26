using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calificaciones
{
    
    public partial class modelo : Form
    {
       
        public modelo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlador co = new controlador();
            co.Show();
            this.Close();
        }

        private void modelo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre;
            string apellido;
            int u1;
            int u2;
            int u3;
            double promedio;
            nombre = nombretxt.Text;
            apellido = apellidotxt.Text;
            u1 = int.Parse(U1txt.Text);
            u2 = int.Parse(U2txt.Text);
            u3 = int.Parse(U3txt.Text);
            promedio = (u1 + u2 + u3) / 3;
            database da = new database();
            da.registrar(nombre,apellido,u1,u2,u3,promedio);
            // MessageBox.Show("Alumno registrado"); 
            MessageBox.Show("Alumno  '" + nombre + "'  '" + apellido + "' fue registrado");
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
     
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
     
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

       
    }
}
