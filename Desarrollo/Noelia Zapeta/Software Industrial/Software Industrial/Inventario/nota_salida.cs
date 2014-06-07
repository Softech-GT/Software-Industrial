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

namespace Software_Industrial.Inventario
{
    public partial class salida : Form
    {
        DBConnect db = new DBConnect("conexion");

        string editfecha = "", editencargado = "", editproducto = "";
        public salida()
        {
            InitializeComponent();
        }
        private void actualizar()
        {
            try { 
            comboBox2.DataSource = db.consulta_ComboBox("Select idtipo, nombre from tipo");
            comboBox2.DisplayMember = "nombre";
            comboBox2.ValueMember = "idtipo";

            DataGridView1.DataSource = db.consulta_DataGridView("select idsalida as Salida, fecha as Fecha, encargado as Encargado, tipo_idtipo as 'Tipo de producto' from salida");

            int i = DataGridView1.RowCount;
            i = i + 1;
            textBox1.Text = i.ToString();
            }
            catch
            {

            }
        }


        private void salida_Load(object sender, EventArgs e)
        {
            actualizar();
        }
        private void limpiar()
        {
            TextBox3.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void barra1_click_nuevo_button()
        {
            DateTimePicker2.Enabled = true;
            TextBox3.Enabled = true;
            comboBox2.Enabled = true;

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void barra1_click_guardar_button()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("idsalida", textBox1.Text);
            dict.Add("fecha", DateTimePicker2.Text);
            dict.Add("encargado", TextBox3.Text);
            dict.Add("tipo_idtipo", comboBox2.SelectedValue.ToString());
            db.insertar("salida", dict);

            actualizar();
            limpiar();
        }

        private void barra1_click_editar_button()
        {
            DateTimePicker2.Enabled = true;
            TextBox3.Enabled = true;
            comboBox2.Enabled = true;
            editar();
            actualizar();
            limpiar();
        }
        public void editar()
        {
            string tabla = "salida";
            string condicion = "idsalida" + textBox1.Text;
           
            if (DateTimePicker2.Text.Equals(editfecha))
            {
                Console.WriteLine("No hubo cambio");
            }
            else
            {
                Console.WriteLine("Si hubo cambio");
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("fecha", DateTimePicker2.Text);

                db.actualizar(tabla, dict, condicion);
            }
            if (TextBox3.Text.Equals(editencargado))
            {
                Console.WriteLine("No hubo cambio");
            }
            else
            {
                Console.WriteLine("Si hubo cambio");
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("encargado", TextBox3.Text);

                db.actualizar(tabla, dict, condicion);
            }
            Dictionary<string, string> dicttipo = new Dictionary<string, string>();
            dicttipo.Add("tipo_idtipo", comboBox2.SelectedValue.ToString());

            db.actualizar(tabla, dicttipo, condicion);

            actualizar();
            limpiar();
        }

        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = DataGridView1.CurrentCell.RowIndex;
            Console.WriteLine("Estoy en la fila " + x);

            textBox1.Text = DataGridView1.Rows[x].Cells[0].Value.ToString();
                       //cmb_linea.SelectedIndex = cmb_linea.FindStringExact(DataGridView1.Rows[x].Cells[4].Value.ToString()); --> guardar 
            DateTimePicker2.Value = Convert.ToDateTime(DataGridView1.Rows[x].Cells[1].Value.ToString());
            TextBox3.Text = DataGridView1.Rows[x].Cells[2].Value.ToString();
            comboBox2.Text= DataGridView1.Rows[x].Cells[3].Value.ToString();
            editfecha = DateTimePicker2.Text;
            editencargado = TextBox3.Text;
            editproducto = comboBox2.Text;
        }
    }
}
