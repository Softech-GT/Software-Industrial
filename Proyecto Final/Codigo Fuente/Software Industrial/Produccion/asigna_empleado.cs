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
    public partial class asigna_empleado : Form
    {
        DBConnect db = new DBConnect("conexion");
        planificacion envia;

        public asigna_empleado(planificacion p)
        {
            InitializeComponent();
            envia = p;
            comboBox1.SelectedIndex = 0;
        }

        private void actualiza()
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
                    string query = "select idemple as Codigo, concat(nomemple, ' ',apellemple) as Nombre from tbempleado where  idemple=" + textBox1.Text;
                    dataGridView1.DataSource = db.consulta_DataGridView(query);
                }
                
                
               
            }
            if (comboBox1.SelectedItem.ToString().Equals("Nombre"))
            {
                string query = "select idemple as Codigo, concat(nomemple, ' ',apellemple) as Nombre from tbempleado where  Nombre='" + textBox1.Text + "'";
                dataGridView1.DataSource = db.consulta_DataGridView(query);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
               // MessageBox.Show("Debe llenar el cambio buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string query = "select idemple as Codigo, concat(nomemple, ' ',apellemple) as Nombre from tbempleado;";
                dataGridView1.DataSource = db.consulta_DataGridView(query);

                string i = dataGridView1.RowCount.ToString();
                if (i.Equals("0"))
                {
                    MessageBox.Show("Sin resultados de busqueda", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    button2.Enabled = true;
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
                    button2.Enabled = true;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = "";
            int i = dataGridView1.CurrentRow.Index;
            id = dataGridView1.Rows[i].Cells[0].Value.ToString();
            // MessageBox.Show(id.ToString());

            string codigo = "";
            string nombre = "";
            string edad = "";
            string telefono = "";
            string direccion = "";
            string cont = "select idEmple as Codigo, concat(nomEmple,' ',apellEmple) as Nombre, edad as Edad, tel as Telefono, direc as Direccion from tbEmpleado where idEmple =" + id;
            System.Collections.ArrayList arra = db.consultar(cont);
            foreach (Dictionary<string, string> dicc in arra)
            {
                codigo = dicc["Codigo"];
                nombre = dicc["Nombre"];
                edad = dicc["Edad"];
                telefono = dicc["Telefono"];
                direccion = dicc["Direccion"];
            }

           envia.recibe_empleado(codigo, nombre, edad, telefono, direccion);
           this.Close();
        }
    }
}
