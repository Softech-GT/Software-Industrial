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
            c.MdiParent = this.MdiParent;
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                   

        }

        private void button3_Click(object sender, EventArgs e)
        {
            maquinaria mq = new maquinaria();
            mq.MdiParent = this.MdiParent;
            mq.MdiParent = this.MdiParent;
            mq.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            asignacion_maquinaria am = new asignacion_maquinaria();
            am.MdiParent = this.MdiParent;
            am.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gestion_produccion gp = new gestion_produccion();
            gp.MdiParent = this.MdiParent;
            gp.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            centro_produccion cp = new centro_produccion();
            cp.MdiParent = this.MdiParent;
            cp.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           

            configuracion conf = new configuracion();
            conf.MdiParent = this.MdiParent;
            conf.Show();
                      
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            crear_receta cr = new crear_receta();
            cr.MdiParent = this.MdiParent;
            cr.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            centro_produccion cp = new centro_produccion();
            cp.MdiParent = this.MdiParent;
            cp.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            maquinaria mq = new maquinaria();
            mq.MdiParent = this.MdiParent;
            mq.Show();


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            gestion_produccion gp = new gestion_produccion();
            gp.MdiParent = this.MdiParent;
            gp.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            asignacion_maquinaria am = new asignacion_maquinaria();
            am.MdiParent = this.MdiParent;
            am.Show();
        }

      
    }
}
