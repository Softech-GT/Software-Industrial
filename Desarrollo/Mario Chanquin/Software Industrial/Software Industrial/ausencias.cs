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

namespace Software_Industrial
{
    public partial class ausencias : Form
    {
        public ausencias()
        {
            InitializeComponent();
        }

        int id = 0;
        DBConnect db = new DBConnect("recursos_humanos");

        private void ausencias_Load(object sender, EventArgs e)
        {
            
            dg_ausencia.DataSource = db.consulta_DataGridView("select *from tbtipoausencia");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_tiempo.Enabled = tb_descripcion.Enabled = tb_tcant.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string tabla = "tbtipoausencia";
            Dictionary<string, string> d = new Dictionary<string, string>();

            d.Add("descripcion", tb_tiempo.Text);
            d.Add("tiempo", tb_descripcion.Text);
            d.Add("cant", tb_tcant.Text);
            db.insertar(tabla, d);
            dg_ausencia.DataSource = new DBConnect("recursos_humanos").consulta_DataGridView("select * from tbtipoausencia");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect("recursos_humanos");
            int k = dg_ausencia.CurrentRow.Index;
            id = Convert.ToInt32(dg_ausencia.Rows[k].Cells[0].Value);
            if (MessageBox.Show("¿Desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.eliminar("tbtipoausencia", "id=" + id);
                dg_ausencia.DataSource = new DBConnect("recursos_humanos").consulta_DataGridView("select * from tbtipoausencia");

            }
        }
    }
}
