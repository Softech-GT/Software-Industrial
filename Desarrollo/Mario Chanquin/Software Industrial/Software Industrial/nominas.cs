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
    public partial class nominas : Form
    {
        public nominas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datos_nomina dn = new datos_nomina();
            dn.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            planilla p = new planilla();
            p.Show();
        }
    }
}
