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

namespace Software_Industrial.Inventario
{
    public partial class nota_ingreso : Form
    {
        DBConnect db = new DBConnect("conexion");
        public nota_ingreso()
        {
            InitializeComponent();
        }
        private void actualizar()

        {
            try {
            ComboBox2.DataSource = db.consulta_ComboBox("Select idproveedores from proveedores");
            ComboBox2.DisplayMember = "nombre";
            comboBox3.ValueMember = "idproveedores";

            comboBox3.DataSource = db.consulta_ComboBox("Select idtipo, nombre from tipo");
            comboBox3.DisplayMember = "nombre";
            comboBox3.ValueMember = "idtipo";

            DataGridView1.DataSource = db.consulta_DataGridView("select identrada as Entrada, fecha as Fecha, proveedores_ideproveedores as Proveedor, tipo_idtipo as 'Tipo de producto',encargado as Encargado from entrada");
        
         int i = DataGridView1.RowCount;
            i = i + 1;
            textBox1.Text = i.ToString();
            }
            catch{

            }
            }
        private void limpiar()
        {
            TextBox3.Clear();
        }
    
        
        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void barra1_click_guardar_button()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("identrada", textBox1.Text);
            dict.Add("fecha", DateTimePicker2.Text);
            dict.Add("", TextBox3.Text);
            dict.Add("tipo_idtipo", comboBox3.SelectedValue.ToString());
            db.insertar("entrada", dict);

            actualizar();
            limpiar();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nota_ingreso_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void barra1_click_nuevo_button()
        {
            DateTimePicker2.Enabled = true;
            ComboBox2.Enabled = true;
            TextBox3.Enabled = true;
            comboBox3.Enabled = true;
        }
    }
}
