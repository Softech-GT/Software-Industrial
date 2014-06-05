using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Software_Industrial.Produccion;

namespace Software_Industrial.Produccion
{
    public partial class centro_produccion : Form
    {
        public centro_produccion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toma_inventario ti = new toma_inventario();
            ti.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            planificacion p = new planificacion();
            p.Show();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            elaboracion el = new elaboracion();
            el.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            toma_inventario ti = new toma_inventario();
            ti.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            planificacion p = new planificacion();
            p.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            elaboracion el = new elaboracion();
            el.Show();
        }

        private void centro_produccion_Load(object sender, EventArgs e)
        {

        }
    }
}
