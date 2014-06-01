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

namespace Software_Industrial
{
    public partial class asignacion_maquinaria : Form
    {

        DBConnect db = new DBConnect("conexion");
        public asignacion_maquinaria()
        {
            InitializeComponent();
            actualizar();
           
        }

        private void actualizar()
        {
            comboBox1.DataSource = db.consulta_ComboBox("select idcategoria_maquinaria, tipo from categoria_maquinaria");
            comboBox1.DisplayMember = "tipo";
            comboBox1.ValueMember = "idcategoria_maquinaria";

            comboBox2.DataSource = db.consulta_ComboBox("select idmaquinaria,descripcion from maquinaria where idcategoria_maquinaria =" + comboBox1.SelectedValue);
            comboBox2.DisplayMember = "descripcion";
            comboBox2.ValueMember = "idmaquinaria";

        }
        string codigo = "";

        public void recibe_datos(string cod,string nom,string edad,string tel,string dir)
        {
            textBox1.Text = cod;
            textBox2.Text = nom;
            textBox3.Text = edad;
            textBox4.Text = tel;
            textBox5.Text = dir;


            codigo = cod;
        }

        private void barra1_click_buscar_button()
        {
            new busca_empleado(this).ShowDialog();  
        }

        bool band = false;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (band)
            {
                comboBox2.DataSource = db.consulta_ComboBox("select idmaquinaria,descripcion from maquinaria where idcategoria_maquinaria =" + comboBox1.SelectedValue);
                comboBox2.DisplayMember = "descripcion";
                comboBox2.ValueMember = "idmaquinaria";
            }
            band = true;

        }

        private void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }


        private void barra1_click_guardar_button()
        {
            if (MessageBox.Show("Desea guardar", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string estado = "De Alta";


                if (radioButton2.Checked)
                {
                    estado = "De baja";
                }

                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("idEmple", codigo);
                dict.Add("idmaquinaria", comboBox2.SelectedValue.ToString());
                dict.Add("fecha_ini", dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"));
                dict.Add("fecha_fin", dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"));
                dict.Add("estado", estado);
                dict.Add("descripcion", textBox6.Text);
                db.insertar("asignacion_equipo", dict);
                limpiar();
            }
        }
    }
}
