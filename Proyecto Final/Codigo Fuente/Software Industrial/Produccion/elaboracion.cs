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
    public partial class elaboracion : Form
    {

       // 0 en producción/fabricación y 1 terminado


        DBConnect db = new DBConnect("conexion");

        public elaboracion()
        {
            InitializeComponent();
           
        }

        private void cuenta() {

            int count = comboBox1.Items.Count;

            int count2 = dataGridView1.Rows.Count;

            if (count == count2)
            {
                MessageBox.Show("Producto terminado");
                comboBox1.Enabled = false;
                button3.Visible = true;
            }

            checkBox1.Checked = false;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                new busca_ordenpro(this).ShowDialog();
            }
            else
            {
                int valor = 0;
                if (!Int32.TryParse(textBox1.Text, out valor))
                {
                    MessageBox.Show("Debe incluir solo numeros", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string cod = "";
                    string nom_pro = "";
                    string cant = "";


                    string query = "select idtmb_ordenproduccion as Codigo, tx_nombre as 'Producto a elaborar', cantidad_solicitada as  Cantidad from tbm_ordenproduccion  where estado=0 and idtmb_ordenproduccion  =" + textBox1.Text;
                    System.Collections.ArrayList arra = db.consultar(query);
                    foreach (Dictionary<string, string> dicc in arra)
                    {
                        cod = dicc["Codigo"];
                        nom_pro = dicc["Producto a elaborar"];
                        cant = dicc["Cantidad"];

                    }

                   recibe_datos(cod, nom_pro,  cant);
                    if (cod.Equals(""))                    
                   {
                       MessageBox.Show("No se encuentra orden de produccion");
                   }
                   //detalle_pedido();
               }
            }
        }

        public void recibe_datos(string cod, string nom_pro, string can)
        {
            try
            {
                groupBox2.Visible = true;
                textBox2.Text = cod;
                textBox3.Text = nom_pro;
                textBox4.Text = can;
                detalle_pedido();
                cuenta();
            }
            catch { 
            }
        }

  


        private void detalle_pedido()
        {

          /*  try { 
            string query = "select idfases_produccion, fase as 'Fase de produccion' from fases_produccion where receta_idreceta= (select idreceta from receta where nombre='"+textBox3.Text+"'); ";
            dataGridView1.DataSource = db.consulta_DataGridView(query);                
            dataGridView1.Columns[0].Visible = false;
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            dataGridView1.Columns.Add(chk);
            chk.HeaderText = "Realizado";
            chk.Name = "chk";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No existen datos");
            }
           */

            try
            {
                string cbpais = "select idfases_produccion, fase  from fases_produccion where receta_idreceta= (select idreceta from receta where nombre='" + textBox3.Text + "'); ";
                comboBox1.DataSource = db.consulta_ComboBox(cbpais);
                comboBox1.DisplayMember = "fase";
                comboBox1.ValueMember = "fase";
            }
            catch 
            {
            }

            try
            {
                string query = "select fase as Fase from control_estados where idtmb_ordenproduccion=" + textBox2.Text;
                dataGridView1.DataSource = db.consulta_DataGridView(query);

            }
            catch { }
                    
                
            
           

        }

        int ia = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            string estado = "1";
            if (checkBox1.Checked)            
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("fase", comboBox1.SelectedValue.ToString());
                dict.Add("estado", estado);
                dict.Add("idtmb_ordenproduccion", textBox2.Text);
                db.insertar("control_estados", dict);


                detalle_pedido();
            }
            else 
            {
                MessageBox.Show("Debe seleccionar realizado");
            }

            int count = comboBox1.Items.Count;
         
            int count2 = dataGridView1.Rows.Count;

            if (count == count2) {
                MessageBox.Show("Producto terminado");
                comboBox1.Enabled = false;
                button3.Visible = true;
                checkBox1.Enabled = false;
            }

            checkBox1.Checked = false;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string actual = "0";
            string id="0";
            string query = "select  idproducto, existencia_minima from producto where nombre ='"+textBox3.Text+"'";
            System.Collections.ArrayList array = db.consultar(query);
            foreach (Dictionary<string, string> dict in array)
            {
                actual = dict["existencia_minima"];
                id = dict["idproducto"];
            }
            if(actual.Equals (""))
            {
                actual = "0";
            }
           double a;
           a = Convert.ToInt32(actual) + Convert.ToInt32(textBox4.Text);
           //MessageBox.Show(actual.ToString());

            string tabla = "producto";
            Dictionary<string, string> dicta = new Dictionary<string, string>();
            dicta.Add("existencia_minima", a.ToString());
            string condicion = "idproducto="+id;
            db.actualizar(tabla, dicta, condicion);

            string tablap = "tbm_ordenproduccion";
            Dictionary<string, string> dictp = new Dictionary<string, string>();
            dictp.Add("estado", "1");
            string condicionp = "idtmb_ordenproduccion= " + textBox2.Text;
            db.actualizar(tablap, dictp, condicionp);

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }
      
       /* private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
       
            int i = dataGridView2.CurrentRow.Index;
            string valor = dataGridView2.Rows[i].Cells[0].Value.ToString();

            
            string query = "select idfases_produccion, fase as 'Fase de produccion' from fases_produccion where receta_idreceta= (select idreceta from receta where nombre='"+valor+"')";
            dataGridView1.DataSource = db.consulta_DataGridView(query);
            dataGridView1.Columns[0].Visible = false;

            if (ia == 0)
            {
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                dataGridView1.Columns.Add(chk);
                chk.HeaderText = "Realizado";
                chk.Name = "chk";
                ia++;
            }
            
            
        }*/

        
    }
}
