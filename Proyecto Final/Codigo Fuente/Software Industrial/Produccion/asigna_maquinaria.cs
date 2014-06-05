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
    public partial class asigna_maquinaria : Form
    {
        DBConnect db = new DBConnect("conexion");
        planificacion envia;
        public asigna_maquinaria(planificacion p)
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
                    string query = "select idmaquinaria as Codigo, marca as Marca,modelo as Modelo,descripcion as Descripcion from maquinaria where idmaquinaria =" + textBox1.Text;
                    dataGridView1.DataSource = db.consulta_DataGridView(query);
                }
                               

            }
            if (comboBox1.SelectedItem.ToString().Equals("Nombre"))
            {
                string query = "select idmaquinaria as Codigo, marca as Marca,modelo as Modelo,descripcion as Descripcion from maquinaria where descripcion='" + textBox1.Text + "'";
                dataGridView1.DataSource = db.consulta_DataGridView(query);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                // MessageBox.Show("Debe llenar el cambio buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string query = "select idmaquinaria as Codigo, marca as Marca,modelo as Modelo,descripcion as Descripcion from maquinaria;";
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
            string marca= "";
            string modelo = "";
            string descripcion = "";


            string cont = "select idmaquinaria,modelo,marca,descripcion from maquinaria where idmaquinaria =" + id;
            System.Collections.ArrayList arra = db.consultar(cont);
            foreach (Dictionary<string, string> dicc in arra)
            {
                codigo = dicc["idmaquinaria"];
                marca = dicc["modelo"];
                modelo = dicc["marca"];
                descripcion = dicc["descripcion"];
         
            }

           envia.recibe_maquinaria(codigo, marca, modelo, descripcion);
           this.Close();
        }
    }
}
