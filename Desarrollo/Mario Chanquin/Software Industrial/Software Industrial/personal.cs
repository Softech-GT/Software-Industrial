

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
    public partial class personal : Form
    {
        public personal()
        {
            InitializeComponent();
        }


        DBConnect db = new DBConnect("recursos_humanos");
        bool editar = false, nuevo = false, cambio = false;
        int id = 0;


        private void personal_Load(object sender, EventArgs e)
        {
            
            comboBox1.DataSource = db.consulta_ComboBox("select nomemple from tbempleado;");
            comboBox1.DisplayMember = "nomemple";
            

            comboBox2.DataSource = db.consulta_ComboBox("select tbDepto_nombre from tbdepto;");
            comboBox2.DisplayMember = "tbDepto_nombre";
            

            comboBox3.DataSource = db.consulta_ComboBox("select tbPuesto_descripcion from tbpuesto;");
            comboBox3.DisplayMember = "tbPuesto_descripcion";
            consulta();
            


            
        }

        private void barra1_click_nuevo_button()
        {
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            textBox1.Enabled = true;
            comboBox4.Enabled = true;
            comboBox5.Enabled = true;
            nuevo = true;
            editar = true;

        }

        private void barra1_click_guardar_button()
        {
            string tabla = "personal";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("nombre", comboBox1.Text);
            dict.Add("departamento", comboBox2.Text);
            dict.Add("puesto", comboBox3.Text);
            dict.Add("sueldo", textBox1.Text );
            dict.Add("estado", comboBox4.Text);
            
            consulta();
            limpiar();


            if (nuevo)
            {
                db.insertar(tabla, dict);
                nuevo = false;
                consulta();
                limpiar();
            }
            if (editar)
            {
                db.actualizar(tabla, dict, "id=" + id);
                editar = false;
                consulta();
                limpiar();
            }
        }



        private void consulta()
        {
            empleado_dgw.DataSource = db.consulta_DataGridView("select *from personal");
            ausentes_dgw.DataSource = db.consulta_DataGridView("select *from tbvacaciones");
        }



        private void limpiar()
        {
            textBox1.Text = "";
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            textBox1.Enabled = false;

        }

        private void barra1_click_editar_button()
        {
            if (cambio)
            {
                nuevo = false;
                int k = empleado_dgw.CurrentRow.Index;
                
                id = Convert.ToInt32(empleado_dgw.Rows[k].Cells[0].Value);
                comboBox1.Text = empleado_dgw.Rows[k].Cells[1].Value.ToString();
                comboBox2.Text = empleado_dgw.Rows[k].Cells[2].Value.ToString();
                comboBox3.Text = empleado_dgw.Rows[k].Cells[3].Value.ToString();
                textBox1.Text = empleado_dgw.Rows[k].Cells[4].Value.ToString();
                comboBox4.Text = empleado_dgw.Rows[k].Cells[5].Value.ToString();

                
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                comboBox4.Enabled = true;
                comboBox5.Enabled = true;
                textBox1.Enabled = true;


                editar = true;
            }
        }

        private void barra1_click_buscar_button()
        {
            consulta();
        }

        private void empleado_dgw_SelectionChanged(object sender, EventArgs e)
        {
            cambio = true;
        }

        private void barra1_click_eliminar_button()
        {
            if (cambio)
            {
                int k = empleado_dgw.CurrentRow.Index;
                id = Convert.ToInt32(empleado_dgw.Rows[k].Cells[0].Value);
                if (MessageBox.Show("Desea eliminar el registro", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.eliminar("personal", "id=" + id);
                    consulta();
                }
            }
        }

        private void empleado_dgw_SelectionChanged_1(object sender, EventArgs e)
        {
            cambio = true;
        }

        private void comboBox5_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
             
                    
            
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox5.Text == "Salario por Obra")
            {
                comboBox7.Enabled = true;
                comboBox6.Enabled = true;
                textBox2.Enabled = true;
            }
            else
            {
                comboBox7.Enabled = false;
                comboBox6.Enabled = false;
                textBox2.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double z;

            z = Convert.ToDouble(comboBox6.Text) * Convert.ToDouble(textBox2.Text);
            textBox1.Text = "Q "+ z.ToString();
            
        }

        



























    }
}
