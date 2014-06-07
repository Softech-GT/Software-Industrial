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
    public partial class asignacion_maquinaria : Form
    {
        public asignacion_maquinaria()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void barra1_click_buscar_button()
        {
            busca_empleado be = new busca_empleado();
            be.Show();
        }
    }
}
