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
    public partial class maquinaria : Form
    {
        DBConnect db = new DBConnect("conexion");

        bool editar = false, nuevo = false, cambio = false;
        int id = 0;

        public maquinaria()
        {
            InitializeComponent();
        }

        private void actualizar()
        {
            string query = "select idmaquinaria as Codigo,marca as Marca, modelo as Modelo,no_serie as 'No. Serie',descripcion as Descripcion from maquinaria;";
            m_dgw.DataSource = db.consulta_DataGridView(query);


            string cc1 = "select idcolor_maquinaria,descripcion from color_maquinaria;";
            comboBox1.DataSource = db.consulta_ComboBox(cc1);
            comboBox1.DisplayMember = "descripcion";
            comboBox1.ValueMember = "idcolor_maquinaria";


            string cc2 = "select idcategoria_maquinaria,descripcion from categoria_maquinaria;";
            comboBox2.DataSource = db.consulta_ComboBox(cc2);
            comboBox2.DisplayMember = "descripcion";
            comboBox2.ValueMember = "idcategoria_maquinaria";


            string cc3 = "select idarea, descripion from area;";
            comboBox3.DataSource = db.consulta_ComboBox(cc3);
            comboBox3.DisplayMember = "descripion";
            comboBox3.ValueMember = "idarea";


        }

        private void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void maquinaria_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void barra1_click_guardar_button()
        {
            string seleccion1 = tabControl1.SelectedTab.Text;
            if (seleccion1.Equals("Ingreso de maquinaria"))
            {
                if (MessageBox.Show("Desea guardar", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("marca", textBox1.Text);
                    dict.Add("modelo", textBox2.Text);
                    dict.Add("no_serie", textBox3.Text);
                    dict.Add("descripcion", textBox4.Text);
                    dict.Add("idcolor_maquinaria", comboBox1.SelectedValue.ToString());
                    dict.Add("idcategoria_maquinaria", comboBox2.SelectedValue.ToString());
                    dict.Add("idarea", comboBox3.SelectedValue.ToString());
                    db.insertar("maquinaria", dict);
                    actualizar();
                    limpiar();
                }
            }
            if (seleccion1.Equals("Consulta de maquinaria"))
            {
                
            }

        }

        private void barra1_click_eliminar_button()
        {
            if (cambio)
            {
                int k = m_dgw.CurrentRow.Index;
                id = Convert.ToInt32(m_dgw.Rows[k].Cells[0].Value);
                if (MessageBox.Show("¿Desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.eliminar("maquinaria", "idmaquinaria=" + id);
                    actualizar();
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            cambio = true;
        }

        private void barra1_click_actualizar_button()
        {
            actualizar();
        }
    }
}
