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
    public partial class departamentos : Form
    {
        public departamentos()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect("conexion");
        bool editar = false, nuevo = false, cambio = false;
        int id = 0;
       
        private void departamentos_Load(object sender, EventArgs e)
        {
            consulta();
        }

        

        private void consulta()
        {
            string query = "select tbdepto_id, tbdepto_nombre as 'Nombre', tbdepto_descripcion as 'Descripcion', tbdepto_funcion as 'Funcion' from tbdepto";
            depto_dgw.DataSource = db.consulta_DataGridView(query);
            depto_dgw.Columns[0].Visible = false;
            depto_dgw.Focus();
        }

       

        private void limpiar()
        {
            nombre_text.Text = descripcion_text.Text = funcion_text.Text = "";
            nombre_text.Enabled = descripcion_text.Enabled = funcion_text.Enabled = false;
        }

        


        private void depto_dgw_SelectionChanged(object sender, EventArgs e)
        {
            cambio = true;
        }

        

        private void depto_dgw_SelectionChanged_1(object sender, EventArgs e)
        {
            cambio = true;
        }

        private void barra1_click_nuevo_button()
        {
            nombre_text.Enabled = true;
            descripcion_text.Enabled = true;
            funcion_text.Enabled = true;
            nombre_text.Focus();
            nuevo = true;
            editar = false; 
        }

        private void barra1_click_guardar_button()
        {
            string tabla = "tbdepto";
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("tbdepto_nombre", nombre_text.Text);
            d.Add("tbdepto_descripcion", descripcion_text.Text);
            d.Add("tbdepto_funcion", funcion_text.Text);
            if (nuevo)
            {
                db.insertar(tabla, d);
                nuevo = false;
                consulta();
                limpiar();
            }
            if (editar)
            {
                db.actualizar(tabla, d, "tbdepto_id=" + id);
                editar = false;
                consulta();
                limpiar();
            }
        }

        private void barra1_click_editar_button()
        {
            if (cambio)
            {
                nuevo = false;
                int k = depto_dgw.CurrentRow.Index;
                id = Convert.ToInt32(depto_dgw.Rows[k].Cells[0].Value);
                nombre_text.Text = depto_dgw.Rows[k].Cells[1].Value.ToString();
                descripcion_text.Text = depto_dgw.Rows[k].Cells[2].Value.ToString();
                funcion_text.Text = depto_dgw.Rows[k].Cells[3].Value.ToString();
                nombre_text.Enabled = descripcion_text.Enabled = funcion_text.Enabled = true;
                editar = true;
            }
        }

        private void barra1_click_eliminar_button()
        {
            if (cambio)
            {
                int k = depto_dgw.CurrentRow.Index;
                id = Convert.ToInt32(depto_dgw.Rows[k].Cells[0].Value);
                if (MessageBox.Show("¿Desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.eliminar("tbdepto", "tbdepto_id=" + id);
                    consulta();
                }
            }
        }

        private void barra1_click_actualizar_button()
        {
            consulta();
        }




    }
}
