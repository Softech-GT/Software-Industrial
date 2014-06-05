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
    public partial class rrhh : Form
    {
        public rrhh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            departamentos dp = new departamentos();
            dp.MdiParent = this.MdiParent;
            dp.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            puestos pt = new puestos();
            pt.MdiParent = this.MdiParent;
            pt.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            empleados emp = new empleados();
            emp.MdiParent = this.MdiParent;
            emp.Show();
        }
    }
}
