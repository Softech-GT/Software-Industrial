using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Software_Industrial
{
    public partial class produccion : Form
    {
        public produccion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            configuracion c = new configuracion();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crear_receta cr = new crear_receta();
            cr.Show();           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            maquinaria mq = new maquinaria();
            mq.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            asignacion_maquinaria am = new asignacion_maquinaria();
            am.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gestion_produccion gp = new gestion_produccion();
            gp.Show();
        }
    }
}
