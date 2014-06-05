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
    public partial class estados_produccion : Form
    {
        public estados_produccion()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }
        DBConnect db = new DBConnect("conexion");
        private void estados_produccion_Load(object sender, EventArgs e)
        {


            if(comboBox1.SelectedItem.Equals("Terminado"))
            {
            string query = ("select idtmb_ordenproduccion as Codigo, tx_nombre as 'Producto a elaborar', cantidad_solicitada as  Cantidad from tbm_ordenproduccion where estado=0");
            dataGridView1.DataSource = db.consulta_DataGridView(query);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Focus();
            }



            
               
                   





        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("En Proceso"))
            {
                string query = ("select idtmb_ordenproduccion as Codigo, tx_nombre as 'Producto a elaborar', cantidad_solicitada as  Cantidad from tbm_ordenproduccion where estado=0");
                dataGridView1.DataSource = db.consulta_DataGridView(query);
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Focus();
            }
            else
            {
                string query = ("select idtmb_ordenproduccion as Codigo, tx_nombre as 'Producto a elaborar', cantidad_solicitada as  Cantidad from tbm_ordenproduccion where estado=1");
                dataGridView1.DataSource = db.consulta_DataGridView(query);
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Focus();
            }
        }
    }
}
