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
    public partial class fases_produccion : Form
    {


        DBConnect db = new DBConnect("conexion");

        public fases_produccion()
        {
            InitializeComponent();
            actualiza();
        }

        private void actualiza()
        {
            string querycombo = "select idreceta, nombre from receta;";
            comboBox1.DataSource = db.consulta_ComboBox(querycombo);
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "idreceta";

            string query = "select idfases_produccion,fase as 'Fase de produccion'from fases_produccion where receta_idreceta=" + comboBox1.SelectedValue.ToString();
            dataGridView1.DataSource = db.consulta_DataGridView(query);
            dataGridView1.Columns[0].Visible = false;
                   
        }

        private void actualiza_detalle()
        { 
             /*string query = "select d.iddetalle_fase as Codigo,d.fase as Fase from detalle_fase as d, fases_produccion as f where d.idfases_produccion = f.idfases_produccion and receta_idreceta=" + comboBox1.SelectedValue.ToString();
             dataGridView1.DataSource = db.consulta_DataGridView(query);
             //dataGridView1.Columns[0].Visible = false;*/
            string query = "select idfases_produccion, fase as 'Fase de produccion' from fases_produccion where receta_idreceta=" + comboBox1.SelectedValue.ToString();
            dataGridView1.DataSource = db.consulta_DataGridView(query);
            dataGridView1.Columns[0].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Debe llenar el campo de fase de produccion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.Text  = "";
            }
            else
            {
              

                Dictionary<string, string> dictd = new Dictionary<string, string>();
                dictd.Add("receta_idreceta",comboBox1.SelectedValue.ToString());
                dictd.Add("fase", textBox1.Text);
                db.insertar("fases_produccion", dictd);
                actualiza_detalle();
                textBox1.Text = "";
               
            }

        }


        bool band=false;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (band)
            {
                actualiza_detalle();
            }


            band = true;
            
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            string id = "";
            int i = dataGridView1.CurrentRow.Index;
            id = dataGridView1.Rows[i].Cells[0].Value.ToString();

            string condicion = "idfases_produccion=" + id;
            db.eliminar("fases_produccion", condicion);
            actualiza_detalle();
        }
        
   }
}
