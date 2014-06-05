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
    public partial class Causencias : Form
    {
        public Causencias()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect("conexion");
        bool editar = false, nuevo = false, cambio = false;
        int id = 0;
        
        
        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x;
            if (comboBox2.SelectedItem.ToString() == "No Activo")
            {
                comboBox3.Text = "";
                comboBox3.Enabled = true;
                x = "N";
                textBox1.Text = x;
                
                
            }

            else
            {
                x = "A";
                comboBox3.Text = "";
                comboBox3.Enabled =false;
                comboBox3.Text = "Null";
                textBox1.Text = x;
                
                
                
            }


        }

        private void Causencias_Load(object sender, EventArgs e)
        {
            consulta();


            comboBox1.DataSource = db.consulta_ComboBox("select idemple, nomemple from tbempleado;");
            comboBox1.DisplayMember = "nomemple";

            
            
            

            comboBox3.DataSource = db.consulta_ComboBox("select  tbtipoausencia_descripcion from tbtipoausencia;");
            comboBox3.DisplayMember = "tbtipoausencia_descripcion";
            
            

        
            
            
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void barra1_click_nuevo_button()
        {
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            nuevo = true;
            editar = false;
            

        }

        private void barra1_click_guardar_button()
        {
            string tabla = "tbausencias";
            Dictionary<string, string> d = new Dictionary<string, string>();
            
                d.Add("empleado", comboBox1.Text);
                d.Add("estado", comboBox2.Text);
                d.Add("tipo", comboBox3.Text);
                d.Add("id_empe_ausencia", textBox1.Text);
            
            

                consulta();

                if (nuevo)
                {
                    db.insertar(tabla, d);
                    nuevo = false;
                    consulta();
                    limpiar();
                }
                if (editar)
                {
                    db.actualizar(tabla, d, "tbtipoausencia_id=" + id);
                    editar = false;
                    consulta();
                    limpiar();
                }
            }
        



        private void consulta()
        {
            ausencia_dgw.DataSource = db.consulta_DataGridView("select *from tbausencias");
        }


        private void limpiar()
        {
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;

        }

        private void barra1_click_editar_button()
        {
            if (cambio)
            {
                nuevo = false;
                int k = ausencia_dgw.CurrentRow.Index;
                id = Convert.ToInt32(ausencia_dgw.Rows[k].Cells[0].Value);
                comboBox1.Text  = ausencia_dgw.Rows[k].Cells[1].Value.ToString();
                comboBox2.Text = ausencia_dgw.Rows[k].Cells[2].Value.ToString();
                comboBox3.Text = ausencia_dgw.Rows[k].Cells[3].Value.ToString();

                editar = true;
            }
        }

        private void barra1_click_buscar_button()
        {
            consulta();
        }

        private void ausencia_dgw_SelectionChanged(object sender, EventArgs e)
        {
            cambio = true;
        }

        private void barra1_click_eliminar_button()
        {
            if (cambio)
            {
                int k = ausencia_dgw.CurrentRow.Index;
                id = Convert.ToInt32(ausencia_dgw.Rows[k].Cells[0].Value);
                if (MessageBox.Show("¿Desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.eliminar("tbausencias", "id=" + id);
                    consulta();
                }
            }
        }

        private void ausencia_dgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            consulta();
        }

        private void barra1_click_actualizar_button()
        {
            consulta();
        }
        







    }
}
