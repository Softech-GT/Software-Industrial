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
    public partial class empleados : Form
    {
        public empleados()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect("recursos_humanos");
        bool editar = false, nuevo = false, cambio = false;
        int id = 0;



        private void barra1_click_nuevo_button()
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            
            textBox1.Focus();
            nuevo = true;
            editar = false;
        }





        private void empleados_Load(object sender, EventArgs e)
        {
            
            consulta();

        }

     

        private void barra1_click_guardar_button()
        {
            string tabla = "tbempleado";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("nomemple", textBox1.Text);
            dict.Add("apellemple", textBox2.Text);

            dict.Add("dpi", textBox3.Text);
                dict.Add("edad", textBox4.Text);
                    dict.Add("genero", textBox5.Text);
                        dict.Add("nacionalidad", textBox6.Text);
                            dict.Add("estadocivil", textBox7.Text);
                                dict.Add("tel", textBox8.Text);
                                    dict.Add("direc", textBox9.Text);
                                        dict.Add("nosegsocial", textBox10.Text);
                                        dict.Add("licencia", textBox11.Text);

            if (nuevo) 
            {
                db.insertar(tabla, dict);
                nuevo = false;
                consulta();
                limpiar();
            }
            if (editar)
            {
                db.actualizar(tabla, dict, "idemple=" + id);
                editar = false;
                consulta();
                limpiar();
            }
        }


        private void consulta()
        {
            empleado_dgw.DataSource = db.consulta_DataGridView("select *from tbempleado");
        }

        private void limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            
        }

        

        private void barra1_click_editar_button()
        {
            if (cambio)
            {
                nuevo = false;
                int k = empleado_dgw.CurrentRow.Index;
                id = Convert.ToInt32(empleado_dgw.Rows[k].Cells[0].Value);
                textBox1.Text = empleado_dgw.Rows[k].Cells[1].Value.ToString();
                textBox2.Text = empleado_dgw.Rows[k].Cells[2].Value.ToString();

                textBox3.Text = empleado_dgw.Rows[k].Cells[3].Value.ToString();
                textBox4.Text = empleado_dgw.Rows[k].Cells[4].Value.ToString();
                textBox5.Text = empleado_dgw.Rows[k].Cells[5].Value.ToString();
                textBox6.Text = empleado_dgw.Rows[k].Cells[6].Value.ToString();
                textBox7.Text = empleado_dgw.Rows[k].Cells[7].Value.ToString();
                textBox8.Text = empleado_dgw.Rows[k].Cells[8].Value.ToString();
                textBox9.Text = empleado_dgw.Rows[k].Cells[9].Value.ToString();
                textBox10.Text = empleado_dgw.Rows[k].Cells[10].Value.ToString();
                textBox11.Text = empleado_dgw.Rows[k].Cells[11].Value.ToString();
               


                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                textBox9.Enabled = true;
                textBox10.Enabled = true;
                textBox11.Enabled = true;
                

                editar = true;
            }
        }





        private void empleado_dgw_SelectionChanged(object sender, EventArgs e)
        {
            cambio = true;
        }

        private void barra1_click_buscar_button()
        {
            consulta();
        }

        private void barra1_click_eliminar_button()
        {
            if (cambio)
            {
                int k = empleado_dgw.CurrentRow.Index;
                id = Convert.ToInt32(empleado_dgw.Rows[k].Cells[0].Value);
                if(MessageBox.Show("Desea eliminar el registro", "Eliminar",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    db.eliminar("tbempleado", "idemple=" + id);
                    consulta();
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            
        }














    }
}
