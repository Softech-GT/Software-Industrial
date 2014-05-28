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
using System.Collections;
namespace Software_Industrial
{
   
    public partial class stock : Form
    {
        DBConnect db = new DBConnect("conexion");
        public stock()
        {
            InitializeComponent();
        }

        private void stock_Load(object sender, EventArgs e)
        {

            String sql = "Select codigo_pedido from pedido";
            comboBox1.DataSource = db.consulta_ComboBox(sql);
            comboBox1.ValueMember = "codigo_pedido";

        }
        String val = "", query = "", faltante = "", pfa="";
        private void button1_Click(object sender, EventArgs e)
        {

            val = ""; query = ""; faltante = ""; pfa = "";
            //dataGridView1.DataSource = "";
            dataGridView1.Columns.Clear();
           // dataGridView1.Visible = false;
            int va1 = 0, va2 = 0,rowcant=0;
            ArrayList array;
            string aas = "", aas1 = "";
            string codigo = ""; 
            int falta = 0;
            codigo= comboBox1.SelectedValue.ToString();
            string qq = "select codigo_pedido,codigo_producto from orden_pedido where codigo_pedido="+codigo;
            array = db.consultar(qq);
            foreach (Dictionary<string, string> dict in array)
            {
                aas = "";
                aas1 = "";
                aas = dict["codigo_pedido"];
                aas1 = dict["codigo_producto"];

                if (aas.Equals(codigo))
                {
                    val = "select a.codigo_pedido, b.descripcion as 'Descripcion', a.cant as 'Cantidad Solicitada', a.codigo_producto, b.codigo_producto, c.codigo_producto, c.existencia as 'Existencia en Bodega', d.codigo_pedido from orden_pedido as a, producto as b, inventarios as c, pedido as d where  a.codigo_pedido=d.codigo_pedido and a.codigo_producto=c.codigo_producto and a.codigo_pedido=" + aas + " and a.codigo_producto=" + aas1 + " and c.codigo_producto=" + aas1 + " and b.codigo_producto=" + aas1 + "";

                    query += val + " union ";
                    //MessageBox.Show(query);
                }

            }
            string query1 = query.Substring(0, query.Length - 6);
           // MessageBox.Show(query1);       
                    dataGridView1.DataSource = db.consulta_DataGridView(query1);
                   dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[3].Visible = false;
                    dataGridView1.Columns[4].Visible=false;
                    dataGridView1.Columns[5].Visible=false;
                    dataGridView1.Columns[7].Visible = false;
                    DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();

                    

                    chk.HeaderText = "Verificación";
                    
                    chk.Name = "chk";
                    chk.TrueValue = false;
                    dataGridView1.Columns.Add(chk);

                    
                    dataGridView1.Visible = true;
                    dataGridView1.Columns[5].ReadOnly = true;
                    
                    
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        va1 = 0;
                        va2 = 0;
                        
                        int aa = dataGridView1.Rows.Count;
                        //MessageBox.Show(aa.ToString());
                        if (aa > 0)
                        {
                            faltante = "";
                            if ((row.Cells["Existencia en Bodega"].Value == null) && (row.Cells["Cantidad Solicitada"].Value == null))
                            {
                            }
                            else
                            {
                                int.TryParse(row.Cells["Existencia en Bodega"].Value.ToString(), out va1);
                                int.TryParse(row.Cells["Cantidad Solicitada"].Value.ToString(), out va2);


                                if (va1 >= va2)
                                {
                                    row.Cells["Existencia en Bodega"].Style.BackColor = Color.Green;
                                    row.Cells["Cantidad Solicitada"].Style.BackColor = Color.Green;

                                    //MessageBox.Show(rowcant.ToString());
                                        dataGridView1.Rows[rowcant].Cells["chk"].Value = true;
                                    
                                    
                                }
                                else
                                {                                    
                                    row.Cells["Existencia en Bodega"].Style.BackColor = Color.Red;                                   
                                    row.Cells["Cantidad Solicitada"].Style.BackColor = Color.Red;
                                    falta = va2 - va1;
                                    //MessageBox.Show(falta.ToString());
                                    faltante = "Para cumplir la orden de " + row.Cells["Descripcion"].Value.ToString() + ", hacen falta: " + falta.ToString();
                                    pfa += faltante + "\n";
                                    
                                }
                            }
                            rowcant++;
                        }
                        
                    }
                    if (pfa.Length > 0) { 
                    MessageBox.Show(pfa);
        } 

          
        }
    }
}
