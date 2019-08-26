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
    public partial class controlador : Form
    {
        
        
        public controlador()
        {
            InitializeComponent();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            modelo mo = new modelo();
            mo.Show();
            this.Hide();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            Vista vi = new Vista();
            vi.Show();
            this.Hide();
        }

        private void controlador_Load(object sender, EventArgs e)
        {

        }

        private void alumno_Click(object sender, EventArgs e)
        {
            modelo mo = new modelo();
            mo.Show();
            this.Hide();
        }
    }
}
