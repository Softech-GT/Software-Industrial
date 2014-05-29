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
    public partial class datos_nomina : Form
    {
        public datos_nomina()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect("recursos_humanos");
        bool editar = false, nuevo = false, cambio = false;
        int id = 0;

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void barra1_click_nuevo_button()
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            nuevo = true;
            editar = true;
        }



        private void datos_nomina_Load(object sender, EventArgs e)
        {
            consulta();
        }

        private void barra1_click_guardar_button()
        {
            string tabla = "datos_nomina";
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("iggs", textBox1.Text );
            d.Add("irtra", textBox2.Text);
            d.Add("isr", textBox3.Text);
            d.Add("bonificacion", textBox4.Text);
            if (nuevo)
            {
                db.insertar(tabla, d);
                nuevo = false;
                consulta();
                limpiar();
            }
            if (editar)
            {
                db.actualizar(tabla, d, "id=" + id);
                editar = false;
                consulta();
                limpiar();
            }
        }


         private void consulta()
        {
           datos_dgw.DataSource = db.consulta_DataGridView("select *from datos_nomina");
        }



         private void limpiar()
         {
             textBox1.Text = "";
             textBox2.Text = "";
             textBox3.Text = "";
             textBox4.Text = "";
             textBox1.Enabled = false;
             textBox2.Enabled = false;
             textBox3.Enabled = false;
             textBox4.Enabled = false;
         }

         private void barra1_click_editar_button()
         {
             if (cambio)
             {
                 nuevo = false;
                 int k = datos_dgw.CurrentRow.Index;
                 id = Convert.ToInt32(datos_dgw.Rows[k].Cells[4].Value);
                 
                 textBox1.Text  = datos_dgw.Rows[k].Cells[0].Value.ToString();
                 textBox2.Text = datos_dgw.Rows[k].Cells[1].Value.ToString();
                 textBox3.Text = datos_dgw.Rows[k].Cells[2].Value.ToString();
                 textBox4.Text = datos_dgw.Rows[k].Cells[3].Value.ToString();
                 textBox1.Enabled=true;
                 textBox2.Enabled=true;
                 textBox3.Enabled=true;
                     textBox4.Enabled= true;

                 editar = true;
             }
         }

         private void textBox1_TextChanged(object sender, EventArgs e)
         {
            

         }

         private void datos_dgw_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
         {
             cambio = true;
         }

         private void datos_dgw_SelectionChanged(object sender, EventArgs e)
         {
             cambio = true;
         }

         private void barra1_click_eliminar_button()
         {
             if (cambio)
             {
                 int k = datos_dgw.CurrentRow.Index;
                 id = Convert.ToInt32(datos_dgw.Rows[k].Cells[4].Value);
                 if (MessageBox.Show("Desea eliminar el registro", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                 {
                     db.eliminar("datos_nomina", "id=" + id);
                     consulta();
                 }
             }
         }




    }
}
