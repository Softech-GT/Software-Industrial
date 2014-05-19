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
            rrhh rrhh = new rrhh();
            rrhh.Show();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tiempo_laborado tl = new tiempo_laborado();
            tl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vacaciones vc = new vacaciones();
            vc.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ausencias au=new ausencias ();
            au.Show();

        }
    }
}
