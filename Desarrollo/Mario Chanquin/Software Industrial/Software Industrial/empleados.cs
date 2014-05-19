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
        bool editar = false;
        string id;

        private void empleados_Load(object sender, EventArgs e)
        {
            dg_registrodeempleado.DataSource = db.consulta_DataGridView("select *from tbempleado");
            this.dg_registrodeempleado.Columns[0].Visible = false; // llena consulta de cuentas dataGridView2.DataSource = db.consulta_DataGridView("SELECT * FROM tbt_cuentas_bancarias;");

            idpuesto_cmb.DataSource = db.consulta_ComboBox("select tbPuesto_id from tbPuesto;");
            idpuesto_cmb.DisplayMember = "tbPuesto_id";
            idpuesto_cmb.ValueMember = "tbPuesto_id";

            idcomisiones_cmb.DataSource = db.consulta_ComboBox("select tbdepto_id from tbdepto;");
            idcomisiones_cmb.DisplayMember = "tbdepto_id";
            idcomisiones_cmb.ValueMember = "tbdepto_id";

           
        }
            

        private void button1_Click(object sender, EventArgs e)
        {
            nombre_text.ReadOnly = false;
            apellido_text.ReadOnly = false;
            segurosocial_text.ReadOnly = false;
            licencia_text.ReadOnly = false;
            edad_text.ReadOnly = false;
            genero_text.ReadOnly = false;
            nacionalidad_text.ReadOnly = false;
            telefono_text.ReadOnly = false;
            dpi_text.ReadOnly = false;
            estadocivil_text.ReadOnly = false;
            direccion_text.ReadOnly = false;
            sueldo_text.ReadOnly = false;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            editar = true;
            nombre_text.ReadOnly = false;
            apellido_text.ReadOnly = false;
            segurosocial_text.ReadOnly = false;
            licencia_text.ReadOnly = false;
            edad_text.ReadOnly = false;
            genero_text.ReadOnly = false;
            nacionalidad_text.ReadOnly = false;
            telefono_text.ReadOnly = false;
            dpi_text.ReadOnly = false;
            estadocivil_text.ReadOnly = false;
            direccion_text.ReadOnly = false;
            sueldo_text.ReadOnly = false;
            int i = dg_registrodeempleado.CurrentRow.Index;
            id = dg_registrodeempleado.Rows[i].Cells[0].Value.ToString();
            nombre_text.Text = dg_registrodeempleado.Rows[i].Cells[1].Value.ToString();
            apellido_text.Text = dg_registrodeempleado.Rows[i].Cells[2].Value.ToString();
            segurosocial_text.Text = dg_registrodeempleado.Rows[i].Cells[3].Value.ToString();
            licencia_text.Text = dg_registrodeempleado.Rows[i].Cells[4].Value.ToString();
            edad_text.Text = dg_registrodeempleado.Rows[i].Cells[5].Value.ToString();
            genero_text.Text = dg_registrodeempleado.Rows[i].Cells[6].Value.ToString();
            nacionalidad_text.Text = dg_registrodeempleado.Rows[i].Cells[7].Value.ToString();
            telefono_text.Text = dg_registrodeempleado.Rows[i].Cells[8].Value.ToString();
            dpi_text.Text = dg_registrodeempleado.Rows[i].Cells[9].Value.ToString();
            estadocivil_text.Text = dg_registrodeempleado.Rows[i].Cells[10].Value.ToString();
            direccion_text.Text = dg_registrodeempleado.Rows[i].Cells[11].Value.ToString();
            sueldo_text.Text = dg_registrodeempleado.Rows[i].Cells[12].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = dg_registrodeempleado.CurrentRow.Index;
            id = dg_registrodeempleado.Rows[i].Cells[0].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("ESTA SEGURO QUE DESEA ELIMINAR EL DATO", "ELIMINACION DE DATO", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string condicion = "tbempleado_idemple=" + id;
                db.eliminar("tbempleado", condicion);
                dg_registrodeempleado.DataSource = db.consulta_DataGridView("select *from tbempleado");

            }
            else if (dialogResult == DialogResult.No)
            {

            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nombre_text.ReadOnly == false)
            {
                string tabla = "tbempleado";
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("tbempleado_nome", nombre_text.Text);
                dict.Add("tbempleado_apellemple", apellido_text.Text);
                dict.Add("tbempleado_dpi", dpi_text.Text);
                dict.Add("tbempleado_edad", edad_text.Text);
                dict.Add("tbempleado_genero", genero_text.Text);
                dict.Add("tbempleado_nacionalidad", nacionalidad_text.Text);
                dict.Add("tbempleado_estadocivil", estadocivil_text.Text);
                dict.Add("tbempleado_tel", telefono_text.Text);
                dict.Add("tbempleado_direc", direccion_text.Text);
                dict.Add("tbempleado_noSegSocial", segurosocial_text.Text);
                dict.Add("tbempleado_licencia", licencia_text.Text);
                dict.Add("tbempleado_sueldo", sueldo_text.Text);
                dict.Add("tbPuesto_tbPuesto_id", idpuesto_cmb.SelectedValue.ToString());
                dict.Add("tbdepto_tbdepto_id", idcomisiones_cmb.SelectedValue.ToString());
                
                db.insertar(tabla, dict);
               

                if (editar)
                {
                    db.actualizar("tbempleado", dict, "tbempleado_idemple=" + id);
                    editar = false;
                }
                else
                {
                    db.insertar("tbempleado", dict);
                }

                dg_registrodeempleado.DataSource = db.consulta_DataGridView("select *from tbempleado");
            }
            else
            {
                MessageBox.Show("Debe precionar la opcion nuevo");
            }
            nombre_text.Text = "";
            nombre_text.ReadOnly = true;
            apellido_text.Text = "";
            apellido_text.ReadOnly = true;
            segurosocial_text.Text = "";
            segurosocial_text.ReadOnly = true;
            licencia_text.Text = "";
            licencia_text.ReadOnly = true;
            edad_text.Text = "";
            edad_text.ReadOnly = true;
            genero_text.Text = "";
            genero_text.ReadOnly = true;
            nacionalidad_text.Text = "";
            nacionalidad_text.ReadOnly = true;
            telefono_text.Text = "";
            telefono_text.ReadOnly = true;
            dpi_text.Text = "";
            dpi_text.ReadOnly = true;
            estadocivil_text.Text = "";
            estadocivil_text.ReadOnly = true;
            direccion_text.Text = "";
            direccion_text.ReadOnly = true;

            //manejo de cuentas
        }
            
    }
}
