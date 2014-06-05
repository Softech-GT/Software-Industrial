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

namespace Software_Industrial.Produccion
{
    public partial class busca_ordenpro : Form
    {

        elaboracion envia;
        DBConnect db = new DBConnect("conexion");
        public busca_ordenpro(elaboracion p)
        {
            InitializeComponent();
            envia = p;
        }


        private void actualiza()
        {
            
            int valor = 0;
            if (!Int32.TryParse(textBox1.Text, out valor))
            {
                MessageBox.Show("Debe incluir solo numeros", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "select idtmb_ordenproduccion as Codigo, tx_nombre as 'Producto a elaborar', cantidad_solicitada as  Cantidad from tbm_ordenproduccion where idtmb_ordenproduccion=" + textBox1.Text;
                dataGridView1.DataSource = db.consulta_DataGridView(query);
            }
                

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                // MessageBox.Show("Debe llenar el cambio buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string query = "select idtmb_ordenproduccion as Codigo, tx_nombre as 'Producto a elaborar', cantidad_solicitada as  Cantidad from tbm_ordenproduccion where estado=0;";
                dataGridView1.DataSource = db.consulta_DataGridView(query);

                string i = dataGridView1.RowCount.ToString();
                if (i.Equals("0"))
                {
                    MessageBox.Show("Sin resultados de busqueda", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    button1.Enabled = true;
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
                    button1.Enabled = true;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = "";
            int i = dataGridView1.CurrentRow.Index;
            id = dataGridView1.Rows[i].Cells[0].Value.ToString();

            string cod = "";
            string nom_pro = "";
            string cant = "";



            string cont = "select idtmb_ordenproduccion as Codigo, tx_nombre as 'Producto a elaborar', cantidad_solicitada as  Cantidad from tbm_ordenproduccion  where estado=0 and idtmb_ordenproduccion  =" + id;
            System.Collections.ArrayList arra = db.consultar(cont);
            foreach (Dictionary<string, string> dicc in arra)
            {
                cod = dicc["Codigo"];
                nom_pro = dicc["Producto a elaborar"];
                cant = dicc["Cantidad"];
             
            }

            envia.recibe_datos(cod,nom_pro,cant);
            this.Close();
        }
    }
}
