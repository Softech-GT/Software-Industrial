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
    public partial class vacaciones : Form
    {
        public vacaciones()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect("recursos_humanos");
        bool editar = false, nuevo = false, cambio = false;
        int id = 0;






        private void label1_Click(object sender, EventArgs e)
        {

        }




        private void vacaciones_Load(object sender, EventArgs e)
        {
            consulta();
            comboBox1.DataSource = db.consulta_ComboBox("select nomemple from tbempleado;");
            comboBox1.DisplayMember = "nomemple";
           // comboBox1.ValueMember = "idemple";

            comboBox2.DataSource = db.consulta_ComboBox("select tbtipoausencia_tiempo from tbtipoausencia;");
            comboBox2.DisplayMember = "tbtipoausencia_tiempo";

            consulta();
        }





        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void barra1_click_nuevo_button()
        {
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            textBox1.Enabled = true;
            nuevo = true;
            editar = true;
        }

        private void barra1_click_guardar_button()
        {
            string tabla = "tbvacaciones";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("empleado", comboBox1.Text );
            dict.Add("dias", comboBox2.Text);
            dict.Add("inicio", dateTimePicker1.Text );
            dict.Add("fin", dateTimePicker2.Text);
            dict.Add("observaciones", textBox1.Text );
            //db.insertar(tabla, dict);
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
            vacaciones_dgw.DataSource = db.consulta_DataGridView("select *from tbvacaciones");
        }



        private void limpiar()
        {
            textBox1.Text = "";
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            textBox1.Enabled = false;

        }

        private void barra1_click_editar_button()
        {
            if (cambio)
            {
                nuevo = false;
                int k = vacaciones_dgw.CurrentRow.Index;
                id = Convert.ToInt32(vacaciones_dgw.Rows[k].Cells[0].Value);
                comboBox1.Text = vacaciones_dgw.Rows[k].Cells[1].Value.ToString();
                comboBox2.Text = vacaciones_dgw.Rows[k].Cells[2].Value.ToString();
                //dateTimePicker1.Text = vacaciones_dgw.Rows[k].Cells[3].Value.ToString();
                //dateTimePicker2.Text = vacaciones_dgw.Rows[k].Cells[4].Value.ToString();
                textBox1.Text = vacaciones_dgw.Rows[k].Cells[5].Value.ToString();


                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                textBox1.Enabled = true;
                
               
                editar = true;
            }
        }

        private void barra1_click_buscar_button()
        {
            consulta();
        }

        private void vacaciones_dgw_SelectionChanged(object sender, EventArgs e)
        {
            cambio = true;

        }

        private void barra1_click_eliminar_button()
        {
            if (cambio)
            {
                int k = vacaciones_dgw.CurrentRow.Index;
                id = Convert.ToInt32(vacaciones_dgw.Rows[k].Cells[0].Value);
                if (MessageBox.Show("Desea eliminar el registro", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.eliminar("tbvacaciones", "id=" + id);
                    consulta();
                }
            }
        }











    }
}
