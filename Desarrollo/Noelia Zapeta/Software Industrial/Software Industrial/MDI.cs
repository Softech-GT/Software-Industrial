using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ODBCConnect;

using Software_Industrial.Inventario;

namespace Software_Industrial
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            produccion p = new produccion();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            inventarios inv = new inventarios();
            inv.Show();
        }
    }
}
