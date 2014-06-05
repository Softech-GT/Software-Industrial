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

using Software_Industrial.Produccion;
namespace Software_Industrial.Produccion
{
    public partial class busca_produccion : Form
    {
        planificacion envia;
        public busca_produccion(planificacion p)
        {
            InitializeComponent();
            envia = p;
            comboBox1.SelectedIndex = 0;
        }

        DBConnect db = new DBConnect("conexion");
       
        private void actualiza()
        {

            if (comboBox1.SelectedItem.ToString().Equals("Codigo"))
            {
                int valor = 0;
                if (!Int32.TryParse(textBox1.Text, out valor))
                {
                    MessageBox.Show("Debe incluir solo numeros", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = "select idproduccion_pro as Codigo , orden_pro as 'No. Orden', descripcion as Descripcion from produccion_pro where idproduccion_pro=" + textBox1.Text;
                    dataGridView1.DataSource = db.consulta_DataGridView(query);
                }                

            }
            if (comboBox1.SelectedItem.ToString().Equals("No. Orden"))
            {
                string query = "select idproduccion_pro as Codigo , orden_pro as 'No. Orden', descripcion as Descripcion from produccion_pro where orden_pro='" + textBox1.Text + "'";
                dataGridView1.DataSource = db.consulta_DataGridView(query);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                //MessageBox.Show("Debe llenar el cambio buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string query = "select idproduccion_pro as Codigo , orden_pro as 'No. Orden', descripcion as Descripcion from produccion_pro";
                dataGridView1.DataSource = db.consulta_DataGridView(query);

                string i = dataGridView1.RowCount.ToString();
                if (i.Equals("0"))
                {
                    MessageBox.Show("Sin resultados de busqueda", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    button2.Enabled = true;
                }
            }
            else
            {
                actualiza();
                string i = dataGridView1.RowCount.ToString();
                if (i.Equals("0"))
                {
                    MessageBox.Show("Sin resultados de busqueda", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    button2.Enabled = true;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = "";
            int i = dataGridView1.CurrentRow.Index;
            id = dataGridView1.Rows[i].Cells[0].Value.ToString();
            // MessageBox.Show(id.ToString());

            string id_pro = "";
            string orden_pro = "";
            string descripcion = "";
            string fecha_ini = "";
            string fecha_fin = "";


            string cont = "select idproduccion_pro,orden_pro,descripcion,fecha_ini,fecha_fin from produccion_pro where idproduccion_pro=" + id;
            System.Collections.ArrayList arra = db.consultar(cont);
            foreach (Dictionary<string, string> dicc in arra)
            {
                id_pro = dicc["idproduccion_pro"];
                orden_pro= dicc["orden_pro"];
                descripcion = dicc["descripcion"];
                fecha_ini= dicc["fecha_ini"];
                fecha_fin = dicc["fecha_fin"];
            }

            envia.recibe_produccion(id_pro,orden_pro, descripcion, fecha_ini, fecha_fin);
            this.Close();
        }
    }
}
