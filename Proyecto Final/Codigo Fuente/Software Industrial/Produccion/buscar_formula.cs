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
    public partial class buscar_formula : Form
    {
        DBConnect db = new DBConnect("conexion");
        crear_receta envia;
        public buscar_formula(crear_receta p)
        {
            InitializeComponent();
            envia = p;
            comboBox1.SelectedIndex = 0;
        }
        private void actualizar()
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
                    string query = "select  idreceta as Codigo, nombre as Nombre from receta where idreceta=" + textBox1.Text;
                    dataGridView1.DataSource = db.consulta_DataGridView(query);

                }
               
            }
            if (comboBox1.SelectedItem.ToString().Equals("Nombre"))
            {
                string query = "select  idreceta as Codigo, nombre as Nombre from receta where nombre='" + textBox1.Text + "'";
                dataGridView1.DataSource = db.consulta_DataGridView(query);
            }
           
        }

      
        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                //MessageBox.Show("Debe llenar el cambio buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                string query = "select  idreceta as Codigo, nombre as Nombre from receta";
                dataGridView1.DataSource = db.consulta_DataGridView(query);
                string i = dataGridView1.RowCount.ToString();
                if (i.Equals("0"))
                {
                    MessageBox.Show("Sin resultados de busqueda", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    button3.Enabled = true;
                }
            
            }
            else
            {
                actualizar();
                string i = dataGridView1.RowCount.ToString();
                if (i.Equals("0"))
                {
                    MessageBox.Show("Sin resultados de busqueda", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = "";
            int i = dataGridView1.CurrentRow.Index;
            id = dataGridView1.Rows[i].Cells[0].Value.ToString();

            string codigo = "";
            string nombre = "";
            string descripcion = "";
            string estado = "";
            string fecha = "";


            string cont = "select idreceta,nombre,descripcion,estado,fecha from receta where idreceta=" + id;
            System.Collections.ArrayList arra = db.consultar(cont);
            foreach (Dictionary<string, string> dicc in arra)
            {
                codigo = dicc["idreceta"];
                nombre = dicc["nombre"];
                descripcion = dicc["descripcion"];
                estado = dicc["estado"];
                fecha = dicc["fecha"];
            }


            fecha = fecha.Substring(0, 10);
            envia.recibe_datos(codigo, nombre, descripcion, estado, fecha);
            this.Close();
        }
    }
}
