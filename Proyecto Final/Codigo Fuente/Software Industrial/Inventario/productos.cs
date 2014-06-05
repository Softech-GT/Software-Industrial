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
    public partial class productos : Form
    {
        DBConnect db = new DBConnect("conexion");
        public productos()
        {
            InitializeComponent();
        }


        private void actualizar()
        {
            try {
                ComboBox4.DataSource = db.consulta_ComboBox("select idmedidas,nombre from medidas;");
                ComboBox4.DisplayMember = "nombre";
                ComboBox4.ValueMember = "idmedidas";


                ComboBox1.DataSource = db.consulta_ComboBox("select idlinea, nombre from linea;");
                ComboBox1.DisplayMember = "nombre";
                ComboBox1.ValueMember = "idlinea";


                ComboBox2.DataSource = db.consulta_ComboBox("select idtipo, nombre from tipo;");
                ComboBox2.DisplayMember = "nombre";
                ComboBox2.ValueMember = "idtipo";

                ComboBox5.DataSource = db.consulta_ComboBox("select idproveedores, nombre from proveedores;");
                ComboBox5.DisplayMember = "nombre";
                ComboBox5.ValueMember = "idproveedores";


                comboBox3.DataSource = db.consulta_ComboBox("select idalmacen, nombre from almace;");
                comboBox3.DisplayMember = "nombre";
                comboBox3.ValueMember = "idalmacen";

                DataGridView1.DataSource = db.consulta_DataGridView("select idproducto as Codigo,nombre as Nombre ,costo_unitario as 'Costo Unitario' , fecha_ingreso as 'Fecha de Ingreso' , existencia_minima as 'Existencia minima' from producto");


                int i = DataGridView1.RowCount;
                i = i + 1;
                TextBox2.Text = i.ToString();

            }
           catch {
               //MessageBox.Show("Llenar catalogo de medidas");
           }


            
        }


        private void productos_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void limpiar() 
        {
            TextBox1.Clear();
        }

        string estado = "";

        private void barra1_click_guardar_button()
        {
           /*string seleccion = TabControl1.SelectedTab.Text;
            //MessageBox.Show(seleccion);
            //if(seleccion1.Equals("datos prid")){
                
             }*/

            
            if(checkBox1.Checked==true){
                estado="Activo";
            }
            else
            {
                estado="Desactivo";
            }

            Dictionary<string,string> dict = new Dictionary<string,string>();
            dict.Add("idproducto", TextBox2.Text);   
            dict.Add("estado", estado);     
            dict.Add("nombre",TextBox1.Text);
            dict.Add("abreviatura", TextBox4.Text);                   
            dict.Add("peso", textBox5.Text);
            dict.Add("existencia_minima", TextBox7.Text);
            dict.Add("costo_unitario", TextBox6.Text);
            dict.Add("fecha_ingreso", DateTimePicker1.Text);
            dict.Add("descripcion", TextBox3.Text);
            dict.Add("linea_idlinea", ComboBox1.SelectedValue.ToString());
            dict.Add("tipo_idtipo", ComboBox2.SelectedValue.ToString());
            dict.Add("almace_idalmacen", comboBox3.SelectedValue.ToString());
            dict.Add("proveedores_idproveedores", ComboBox5.SelectedValue.ToString());
            dict.Add("medidas_idmedidas", ComboBox4.SelectedValue.ToString()); 
            db.insertar("producto",dict);

            actualizar();
            limpiar();
        }
         
    }
}
