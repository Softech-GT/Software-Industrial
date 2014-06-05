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
    public partial class asignar_usuarios : Form
    {
        public asignar_usuarios()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect("conexion");
        bool editar = false, nuevo = false, cambio = false;
        int id = 0;

        private void asignar_usuarios_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = db.consulta_ComboBox("select nomemple, idemple from tbempleado;");
            comboBox1.DisplayMember = "nomemple";
            comboBox1.ValueMember = "idemple";
            consulta();


        }

        private void barra1_click_nuevo_button()
        {
            comboBox1.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            nuevo = true;
            editar = true;

        }

        private void barra1_click_guardar_button()
        {
            string tabla = "usuarios";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("id_emple_us", comboBox1.SelectedValue.ToString());
            dict.Add("nombre", textBox1.Text);
            dict.Add("pass", textBox2.Text);


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
            //usuario_dgw.DataSource = db.consulta_DataGridView("select *from usuarios");
            string query = "select id, id_emple_us as 'ID Empleado', nombre as 'Usuario', pass as 'Password' from usuarios";
            usuario_dgw.DataSource = db.consulta_DataGridView(query);
            usuario_dgw.Columns[0].Visible = false;
            usuario_dgw.Focus();

           

           

        }



        private void limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Enabled = false;

            textBox1.Enabled = false;
            textBox2.Enabled = false;

        }

        private void empleado_dgw_SelectionChanged(object sender, EventArgs e)
        {
            cambio = true;
        }

        private void barra1_click_editar_button()
        {
            if (cambio)
            {
                nuevo = false;
                int k = usuario_dgw.CurrentRow.Index;

                id = Convert.ToInt32(usuario_dgw.Rows[k].Cells[0].Value);
                comboBox1.SelectedItem = usuario_dgw.Rows[k].Cells[1].Value.ToString();
                textBox1.Text = usuario_dgw.Rows[k].Cells[2].Value.ToString();
                textBox2.Text = usuario_dgw.Rows[k].Cells[3].Value.ToString();

                comboBox1.Enabled = true;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                editar = true;
            }





        }

        private void barra1_click_buscar_button()
        {
            consulta();
        }

        private void barra1_click_eliminar_button()
        {
            if (cambio)
            {
                int k = usuario_dgw.CurrentRow.Index;
                id = Convert.ToInt32(usuario_dgw.Rows[k].Cells[0].Value);
                if (MessageBox.Show("Desea eliminar el registro", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.eliminar("usuarios", "id=" + id);
                    consulta();
                }
            }
        }

    }
}