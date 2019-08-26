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
    public partial class Vista : Form

    {
        public Vista()
        {
            InitializeComponent();
        }

        private void Vista_Load(object sender, EventArgs e)
        {
            database da = new database();
            dataGridView1.DataSource = database.consulta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlador co = new controlador();
            co.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            database da = new database();
            dataGridView1.DataSource = database.consulta();
        }
    }
}
