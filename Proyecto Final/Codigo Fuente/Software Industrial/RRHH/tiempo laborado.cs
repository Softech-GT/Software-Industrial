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
    public partial class tiempo_laborado : Form
    {
        public tiempo_laborado()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect("conexion");
        bool editar = false, nuevo = false, cambio = false;
        int id = 0;

        private void tiempo_laborado_Load(object sender, EventArgs e)
        {
            consulta();
            comboBox1.DataSource = db.consulta_ComboBox("select nomemple from tbempleado;");
            comboBox1.DisplayMember = "nomemple";
            
        }

        private void barra1_click_nuevo_button()
        {
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            dateTimePicker3.Enabled = true;

        }

        private void barra1_click_guardar_button()
        {
            string tabla = "tbtiempo";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("empleado", comboBox1.Text);
            dict.Add("inicio", dateTimePicker1.Text);
            dict.Add("fin", dateTimePicker2.Text);
            dict.Add("de", comboBox2.Text);
            dict.Add("a", comboBox3.Text);
            dict.Add("inicioc", dateTimePicker3.Text );
            db.insertar(tabla, dict);
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
            tiempo_dgw.DataSource = db.consulta_DataGridView("select *from tbtiempo");
        }


        private void limpiar()
        {
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            dateTimePicker3.Enabled = false;

        }

        private void barra1_click_editar_button()
        {
            if (cambio)
            {
                nuevo = false;
                int k = tiempo_dgw.CurrentRow.Index;
                id = Convert.ToInt32(tiempo_dgw.Rows[k].Cells[0].Value);
                comboBox1.Text = tiempo_dgw.Rows[k].Cells[1].Value.ToString();
                //dateTimePicker1.Text = tiempo_dgw.Rows[k].Cells[2].Value.ToString();
                //dateTimePicker2.Text = tiempo_dgw.Rows[k].Cells[3].Value.ToString();
                comboBox2.Text = tiempo_dgw.Rows[k].Cells[4].Value.ToString();
                comboBox3.Text = tiempo_dgw.Rows[k].Cells[5].Value.ToString();
                //dateTimePicker3.Text = tiempo_dgw.Rows[k].Cells[6].Value.ToString();



                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                dateTimePicker3.Enabled = true;


                editar = true;
            }
        }

        private void barra1_click_buscar_button()
        {
            consulta();
        }

        private void tiempo_dgw_SelectionChanged(object sender, EventArgs e)
        {
            cambio = true;
        }

        private void barra1_click_eliminar_button()
        {
            if (cambio)
            {
                int k = tiempo_dgw.CurrentRow.Index;
                id = Convert.ToInt32(tiempo_dgw.Rows[k].Cells[0].Value);
                if (MessageBox.Show("Desea eliminar el registro", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.eliminar("tbtiempo", "id=" + id);
                    consulta();
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = comboBox4.Text + comboBox5.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = comboBox4.Text + ':'  + comboBox5.Text +':' +comboBox6.Text ;
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Text = comboBox9.Text + ':' + comboBox8.Text + ':' + comboBox7.Text;
        }








    }
}
