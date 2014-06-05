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
    public partial class Recursos_Humanos : Form
    {
        public Recursos_Humanos()
        {
            InitializeComponent();
        }

        private void Recursos_Humanos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rrhh rh = new rrhh();
            rh.MdiParent = this.MdiParent;
            rh.Show(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tiempo_laborado tl = new tiempo_laborado();
            tl.MdiParent = this.MdiParent;
            tl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vacaciones vc = new vacaciones();
            vc.MdiParent = this.MdiParent;
            vc.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ausencias au = new ausencias();
            au.MdiParent = this.MdiParent;
            au.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            personal p = new personal();
            p.MdiParent = this.MdiParent;
            p.Show();
        }
    }
}
