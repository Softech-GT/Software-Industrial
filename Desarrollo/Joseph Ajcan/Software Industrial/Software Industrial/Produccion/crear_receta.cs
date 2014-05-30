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
    public partial class crear_receta : Form
    {

        DBConnect db = new DBConnect("conexion");
        public crear_receta()
        {
            InitializeComponent();
        }

        private void barra1_click_buscar_button()
        {
            buscar_formula bf = new buscar_formula();
            bf.Show();
        }


        private void actualiza() 
        {
            DateTime fechaHoy = DateTime.Now;
            string fecha = fechaHoy.ToString("d");
            textBox3.Text = fecha;

            string tipo = "select idtipo_receta,nombre from tipo_receta;";
            comboBox1.DataSource = db.consulta_ComboBox(tipo);
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "idtipo_receta";


            string elemento = "select idproducto, nombre from producto;";
            comboBox2.DataSource = db.consulta_ComboBox(elemento);
            comboBox2.DisplayMember = "nombre";
            comboBox2.ValueMember = "idproducto";


            string medida = "select idmedidas,nombre from medidas;";
            comboBox3.DataSource = db.consulta_ComboBox(medida);
            comboBox3.DisplayMember = "nombre";
            comboBox3.ValueMember = "idmedidas";
        }

        private void detalle_receta()
        {
            string query = "select *from detalle_receta where idreceta=" + textBox1.Text;
            dataGridView1.DataSource = db.consulta_DataGridView(query);
        }

        int i = 1;
        private void crear_receta_Load(object sender, EventArgs e)
        {
            actualiza();
        }

        string estado = "";
        private void barra1_click_guardar_button()
        {
            
            if (radioButton1.Checked == true)
            {
                estado = "De altas";
            }
            else 
            {
                estado="De baja";
            }


            if (i == 1) 
            {
                if (MessageBox.Show("Desea guardar", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("idreceta", textBox1.Text);
                    dict.Add("descripcion", textBox2.Text);
                    dict.Add("idtipo_receta", comboBox1.SelectedValue.ToString());
                    dict.Add("estado", estado);
                    dict.Add("fecha", textBox3.Text);
                    db.insertar("receta", dict);                   
                }


                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;             
                i++;
            }

            else
            {
                Dictionary<string, string> dict1 = new Dictionary<string, string>();
                dict1.Add("idreceta", textBox1.Text);
                dict1.Add("idproducto", comboBox2.SelectedValue.ToString());
                //dict.Add("idtipo_receta", comboBox1.SelectedValue.ToString());
                dict1.Add("cantidad", textBox4.Text);
                dict1.Add("idmedidas", comboBox3.SelectedValue.ToString());
                db.insertar("detalle_receta", dict1);
                detalle_receta();
            }

        }
    }
}
