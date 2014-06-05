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
    public partial class puestos : Form
    {
        public puestos()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect("conexion");
        bool editar = false, nuevo = false, cambio = false;
        int id = 0;


        private void consulta()
        {
            string query = "select tbPuesto_id as 'ID Puesto', tbPuesto_descripcion as 'Descripcion', tbPuesto_salarioBase as 'Salario Base' from tbPuesto";
            puesto_dgw.DataSource = db.consulta_DataGridView(query);
            //puesto_dgw.DataSource = db.consulta_DataGridView("select *from tbpuesto");
            //puesto_dgw.Columns[0].Visible = false;
            puesto_dgw.Columns[6].Visible = false;
            puesto_dgw.Focus();

            

        }

        private void limpiar()
        {
            sueldo_text.Text = descripcion_text.Text = requisitos_text.Text = salario_text.Text = "";
            sueldo_text.Enabled = descripcion_text.Enabled = requisitos_text.Enabled = salario_text.Enabled = departamento_cmb.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void puestos_Load(object sender, EventArgs e)

        {
            departamento_cmb.DataSource = db.consulta_ComboBox("select tbdepto_id,tbdepto_nombre from tbdepto");
            departamento_cmb.DisplayMember = "tbdepto_nombre";
            departamento_cmb.ValueMember = "tbdepto_id";
            consulta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void puesto_dgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void barra1_click_nuevo_button()
        {
            sueldo_text.Enabled = descripcion_text.Enabled = requisitos_text.Enabled = salario_text.Enabled = departamento_cmb.Enabled = true;
            sueldo_text.Focus();
            nuevo = true;
            editar = false;
        }

        private void barra1_click_guardar_button()
        {
            string tabla = "tbpuesto";
            Dictionary<string, string> d = new Dictionary<string, string>();
            
            d.Add("tbpuesto_descripcion", descripcion_text.Text);
            
            d.Add("tbpuesto_salariobase", salario_text.Text);
            d.Add("tbdepto_tbdepto_id", departamento_cmb.SelectedValue.ToString());
            if (nuevo)
            {
                db.insertar(tabla, d);
                nuevo = false;
                consulta();
                limpiar();
            }
            if (editar)
            {
                db.actualizar(tabla, d, "tbpuesto_id=" + id);
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
                int k = puesto_dgw.CurrentRow.Index;
                id = Convert.ToInt32(puesto_dgw.Rows[k].Cells[0].Value);
               
                descripcion_text.Text = puesto_dgw.Rows[k].Cells[1].Value.ToString();
               
                salario_text.Text = puesto_dgw.Rows[k].Cells[2].Value.ToString();
                //int l = Convert.ToInt32(puesto_dgw.Rows[k].Cells[6].Value);
                departamento_cmb.SelectedValue =  puesto_dgw.Rows[k].Cells[3].Value.ToString();
                sueldo_text.Enabled = descripcion_text.Enabled = requisitos_text.Enabled = salario_text.Enabled = departamento_cmb.Enabled = true;
                editar = true;
            }
        }

        private void barra1_click_eliminar_button()
        {
            if (cambio)
            {
                int k = puesto_dgw.CurrentRow.Index;
                id = Convert.ToInt32(puesto_dgw.Rows[k].Cells[0].Value);
                if (MessageBox.Show("¿Desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.eliminar("tbpuesto", "tbpuesto_id=" + id);
                    consulta();
                }
            }
        }

        private void puesto_dgw_SelectionChanged(object sender, EventArgs e)
        {
            cambio = true;
        }



       


    }
}
