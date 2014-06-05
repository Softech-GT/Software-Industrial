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
    public partial class proveedores : Form
    {
        public proveedores()
        {
            InitializeComponent();
        }

          //DBConnect db = new DBConnect("final_s");
        DBConnect db = new DBConnect("conexion");
          bool editar = false;
          string id;
        private void barra1_click_guardar_button()
        {


            string tabla = "proveedor_mp";
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("nombre", textBox1.Text);
            d.Add("direccion", textBox2.Text);
            d.Add("telefono", textBox3.Text);
            d.Add("email", textBox4.Text);
            d.Add("paginaweb", textBox5.Text);
            d.Add("nit", textBox6.Text);

            db.insertar(tabla, d);
            mostrar();
            limpiar();
            



        }

        private void barra1_click_nuevo_button()
        {



            limpiar();


        }





        private void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }



        private void proveedores_Load(object sender, EventArgs e)
        {
           mostrar();

            //llenar combo box para buscar proveedores

           string querycd = "select id_prov,nombre from proveedor_mp";
           comboBox1.DataSource = db.consulta_ComboBox(querycd);
           comboBox1.DisplayMember = "nombre";
           comboBox1.ValueMember = "id_prov";



        }

        private void barra1_click_actualizar_button()
        {
            //mostrar();

            string tabla = "proveedor_mp";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("nombre", textBox7.Text);
            string condicion = "id_prov=" + comboBox1.SelectedValue;
            db.actualizar(tabla, dict, condicion);

            dict.Add("direccion", textBox8.Text);
            string condicion1 = "id_prov=" + comboBox1.SelectedValue;
            db.actualizar(tabla, dict, condicion1);

            dict.Add("telefono", textBox9.Text);
            string condicion2 = "id_prov=" + comboBox1.SelectedValue;
            db.actualizar(tabla, dict, condicion2);

            dict.Add("email", textBox10.Text);
            string condicion3 = "id_prov=" + comboBox1.SelectedValue;
            db.actualizar(tabla, dict, condicion3);

            dict.Add("paginaweb", textBox11.Text);
            string condicion4 = "id_prov=" + comboBox1.SelectedValue;
            db.actualizar(tabla, dict, condicion4);

            dict.Add("nit", textBox12.Text);
            string condicion5 = "id_prov=" + comboBox1.SelectedValue;
            db.actualizar(tabla, dict, condicion5);



            mostrar();
           

            

        }



        private void mostrar()
        {

            //string query = "select id_prov, nombre as 'Nombre ' , direccion as 'Direccion', telefono as 'Telefono', email as 'E-mail', paginaweb as 'Pagina Web', nit as 'NIT' from proveedor_mp";
            //dataGridView1.DataSource = db.consulta_DataGridView(query);

            string query2 = "select id_prov, nombre as 'Nombre ' , direccion as 'Direccion', telefono as 'Telefono', email as 'E-mail', paginaweb as 'Pagina Web', nit as 'NIT' from proveedor_mp";
            dataGridView2.DataSource = db.consulta_DataGridView(query2);


        }

        private void barra1_click_editar_button()
        {


            string query = "select *from proveedor_mp where id_prov=" + comboBox1.SelectedValue.ToString();
            System.Collections.ArrayList array = db.consultar(query);
            foreach (Dictionary<string, string> dict in array)
            {
                textBox7.Text = dict["nombre"];
                textBox8.Text = dict["direccion"];
                textBox9.Text = dict["telefono"];
                textBox10.Text = dict["email"];
                textBox11.Text = dict["paginaweb"];
                textBox12.Text = dict["nit"];



            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            mostrar();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void barra1_click_buscar_button()
        {

        }

        private void barra1_click_imprimir_button()
        {
            
        }

    
       

    }
}
