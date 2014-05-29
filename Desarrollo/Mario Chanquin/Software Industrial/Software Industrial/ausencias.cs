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
    public partial class ausencias : Form
    {
        public ausencias()
        {
            InitializeComponent();
        }

        
        DBConnect db = new DBConnect("recursos_humanos");
        bool editar = false, nuevo = false, cambio = false;
        int id = 0;
       

        private void ausencias_Load(object sender, EventArgs e)
        {
            
            ausencia_dgw.DataSource = db.consulta_DataGridView("select *from tbtipoausencia");
        }

        

    

        private void barra1_click_nuevo_button()
        {
            tb_tiempo.Enabled = tb_descripcion.Enabled = true;
            nuevo = true;
            editar = false;
        }

        private void barra1_click_guardar_button()
        {
            string tabla = "tbtipoausencia";
            Dictionary<string, string> d = new Dictionary<string, string>();

            d.Add("tbtipoausencia_descripcion", tb_tiempo.Text);
            d.Add("tbtipoausencia_tiempo", tb_descripcion.Text);
           
            
       
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

        private void barra1_click_editar_button()
        {
            if (cambio)
            {
                nuevo = false;
                int k = ausencia_dgw.CurrentRow.Index;
                id = Convert.ToInt32(ausencia_dgw.Rows[k].Cells[0].Value);
                tb_descripcion.Text = ausencia_dgw.Rows[k].Cells[2].Value.ToString();
                tb_tiempo.Text = ausencia_dgw.Rows[k].Cells[1].Value.ToString();
               
                
                editar = true;
                tb_descripcion.Enabled  = tb_tiempo.Enabled  = true;
            }
        }

       

        private void ausencia_dgw_SizeChanged(object sender, EventArgs e)
        {
            cambio = true;
        }

        private void consulta()
        {
            ausencia_dgw.DataSource = db.consulta_DataGridView("select *from tbtipoausencia");
        }


        private void limpiar()
        {
             tb_descripcion.Text = "";
            tb_tiempo.Text = "";
          

           tb_descripcion.Enabled = false;
           tb_tiempo.Enabled = false;
           

        }

        private void barra1_click_eliminar_button()
        {
            if (cambio)
            {
                int k = ausencia_dgw.CurrentRow.Index;
                id = Convert.ToInt32(ausencia_dgw.Rows[k].Cells[0].Value);
                if (MessageBox.Show("¿Desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.eliminar("tbtipoausencia", "tbtipoausencia_id=" + id);
                    consulta();
                }
            }
        }

        private void ausencia_dgw_SelectionChanged(object sender, EventArgs e)
        {
            cambio = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Causencias ca = new Causencias();
            ca.Show();
        }
    }
}
