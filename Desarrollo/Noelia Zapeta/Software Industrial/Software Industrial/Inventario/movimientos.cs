using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Industrial.Inventario
{
    public partial class movimientos : Form
    {
        public movimientos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nota_ingreso ni = new nota_ingreso();
            ni.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salida s = new salida();
            s.Show();
        }
    }
}
