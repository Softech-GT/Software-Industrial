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
    public partial class gestion_produccion : Form
    {
        public gestion_produccion()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fases_produccion fp = new fases_produccion();
            fp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            estados_produccion ep = new estados_produccion();
            ep.Show();
        }
    }
}
