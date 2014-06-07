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
       

       // editar
        string editnom = "", editcosto = "", editingreso = "", editexistencia = "";
        
        //
       
        public productos()
        {
            InitializeComponent();
        }


        private void actualizar()
        {
            try {
                cmb_medida.DataSource = db.consulta_ComboBox("select idmedidas,nombre from medidas;");
                cmb_medida.DisplayMember = "nombre";
                cmb_medida.ValueMember = "idmedidas";


                cmb_linea.DataSource = db.consulta_ComboBox("select idlinea, nombre from linea;");
                cmb_linea.DisplayMember = "nombre";
                cmb_linea.ValueMember = "idlinea";


                cmb_tipo.DataSource = db.consulta_ComboBox("select idtipo, nombre from tipo;");
                cmb_tipo.DisplayMember = "nombre";
                cmb_tipo.ValueMember = "idtipo";

                cmb_prov.DataSource = db.consulta_ComboBox("select idproveedores, nombre from proveedores;");
                cmb_prov.DisplayMember = "nombre";
                cmb_prov.ValueMember = "idproveedores";


                cmb_ubi.DataSource = db.consulta_ComboBox("select idalmacen, nombre from almace;");
                cmb_ubi.DisplayMember = "nombre";
                cmb_ubi.ValueMember = "idalmacen";

                DataGridView1.DataSource = db.consulta_DataGridView("select idproducto as Codigo,nombre as Nombre ,costo_unitario as 'Costo Unitario' , fecha_ingreso as 'Fecha de Ingreso' , existencia_minima as 'Existencia minima' from producto");


                int i = DataGridView1.RowCount;
                i = i + 1;
                txt_codigo.Text = i.ToString();

            }
           catch {
               //MessageBox.Show("Llenar catalogo de medidas");
           }
    

            
        }
        private void consultar ()
        {
            
        }

        private void productos_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void limpiar() 
        {
            TextBox1.Clear();
            TextBox4.Clear();
            textBox5.Clear();
            TextBox6.Clear();
            TextBox7.Clear();
            TextBox3.Clear();
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
            dict.Add("idproducto", txt_codigo.Text);   
            dict.Add("estado", estado);     
            dict.Add("nombre",TextBox1.Text);
            dict.Add("abreviatura", TextBox4.Text);                   
            dict.Add("peso", textBox5.Text);
            dict.Add("existencia_minima", TextBox7.Text);
            dict.Add("costo_unitario", TextBox6.Text);
            dict.Add("fecha_ingreso", DateTimePicker1.Text);
            dict.Add("descripcion", TextBox3.Text);
            dict.Add("linea_idlinea", cmb_linea.SelectedValue.ToString());
            dict.Add("tipo_idtipo", cmb_tipo.SelectedValue.ToString());
            dict.Add("almace_idalmacen", cmb_ubi.SelectedValue.ToString());
            dict.Add("proveedores_idproveedores", cmb_prov.SelectedValue.ToString());
            dict.Add("medidas_idmedidas", cmb_medida.SelectedValue.ToString()); 
            db.insertar("producto",dict);

            actualizar();
            limpiar();
        }
        

        private void barra1_click_editar_button()
        {
            cmb_ubi.Enabled = true;
            textBox5.Enabled = true;
            TextBox6.Enabled = true;
            TextBox7.Enabled = true;
            DateTimePicker1.Enabled = true;
            TextBox3.Enabled = true;
            cmb_linea.Enabled = true;
            cmb_tipo.Enabled = true;
            TextBox1.Enabled = true;
            TextBox4.Enabled = true;
            cmb_medida.Enabled = true;
            cmb_prov.Enabled = true;
            GroupBox1.Enabled = true;
            editar();
            actualizar();
            limpiar();
            


        }
        public void editar ()
        {
            string tabla = "producto";
            string condicion = "idproducto=" + txt_codigo.Text;
            if (TextBox1.Text.Equals(editnom)) {
                Console.WriteLine("No hubo cambio");
            } else {
                Console.WriteLine("Si hubo cambio");
              
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("nombre", TextBox1.Text);
               
                db.actualizar(tabla, dict,condicion);
            }
            if (TextBox6.Text.Equals(editcosto))
            {
                Console.WriteLine("No hubo cambio");
            } else {
                Console.WriteLine("Si hubo cambio");
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("costo_unitario", TextBox6.Text);

                db.actualizar(tabla, dict, condicion);
            }
            if (DateTimePicker1.Text.Equals(editingreso))
            {
                Console.WriteLine("No hubo cambio");
            }
            else
            {
                Console.WriteLine("Si hubo cambio");
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("fecha_ingreso", DateTimePicker1.Text);

                db.actualizar(tabla, dict, condicion);
            }
            if (TextBox7.Text.Equals(editexistencia))
            {
                Console.WriteLine("No hubo cambio");
            }
            else
            {
                Console.WriteLine("Si hubo cambio");
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("existencia_minima", TextBox7.Text);

                db.actualizar(tabla, dict, condicion);
            }
            //cmb linea
            Dictionary<string, string> dictlinea = new Dictionary<string, string>();
            dictlinea.Add("linea_idlinea", cmb_linea.SelectedValue.ToString());

            db.actualizar(tabla, dictlinea, condicion);

            //cmb_tipo
            Dictionary<string, string> dicttipo = new Dictionary<string, string>();
            dicttipo.Add("tipo_idtipo",cmb_tipo.SelectedValue.ToString());

            db.actualizar(tabla, dicttipo, condicion);
  
              //      cmb proveedores
            Dictionary<string, string> dictproveedores = new Dictionary<string, string>();
            dictproveedores.Add("proveedores_idproveedores",cmb_prov.SelectedValue.ToString());

            db.actualizar(tabla, dictproveedores, condicion);
                //        cmb ubicacion 
            Dictionary<string, string> dictubi = new Dictionary<string, string>();
            dictubi.Add("almace_idalmacen",cmb_ubi.SelectedValue.ToString());

            db.actualizar(tabla, dictubi, condicion);

            //medida
            Dictionary<string, string> dictmedida = new Dictionary<string, string>();
            dictmedida.Add("medidas_idmedidas", cmb_medida.SelectedValue.ToString());

            db.actualizar(tabla, dictmedida, condicion);
            actualizar();
            limpiar();

        }
       
        private void consulta()
        {
            DataGridView1.DataSource = db.consulta_DataGridView("Select nombre as Nombre, estado as Estado, tipo_idtipo as Tipo, abreviatura as Abreviatura, peso as Peso, existencia_minima as 'Existencia Minima', costo_unitario as 'Costo Unitario', fecha_ingreso as 'Fecha de Ingreso' from producto");
            
        }

        private void barra1_click_nuevo_button()
        {
           
            cmb_ubi.Enabled = true;
            textBox5.Enabled = true;
            TextBox6.Enabled = true;
            TextBox7.Enabled = true;
            DateTimePicker1.Enabled = true;
            TextBox3.Enabled = true;
            cmb_linea.Enabled = true;
            cmb_tipo.Enabled = true;
            TextBox1.Enabled = true;
            TextBox4.Enabled = true;
            cmb_medida.Enabled = true;
            cmb_prov.Enabled = true;
            GroupBox1.Enabled = true;


        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void barra1_click_buscar_button()
        {
            consulta();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = DataGridView1.CurrentCell.RowIndex;
            Console.WriteLine("Estoy en la fila " + x);

            txt_codigo.Text = DataGridView1.Rows[x].Cells[0].Value.ToString();
            TextBox1.Text = DataGridView1.Rows[x].Cells[1].Value.ToString();
            TextBox6.Text = DataGridView1.Rows[x].Cells[2].Value.ToString();
            TextBox7.Text = DataGridView1.Rows[x].Cells[4].Value.ToString();
                        //cmb_linea.SelectedIndex = cmb_linea.FindStringExact(DataGridView1.Rows[x].Cells[4].Value.ToString()); --> guardar 
            DateTimePicker1.Value = Convert.ToDateTime(DataGridView1.Rows[x].Cells[3].Value.ToString());
            editnom = txt_codigo.Text;
            editcosto = TextBox6.Text;
            editingreso = DateTimePicker1.Text;
            editexistencia = TextBox7.Text;
        }

        private void barra1_click_actualizar_button()
        {
            actualizar();

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Label12_TextAlignChanged(object sender, EventArgs e)
        {

        }
         
    }
}
