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
    public partial class pedido : Form
    {
        public pedido()
        {
            InitializeComponent();
        }

        //DBConnect db = new DBConnect("final_s");
        DBConnect db = new DBConnect("conexion");
    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pedido_Load(object sender, EventArgs e)
        {
            mostrar();
        }



        private void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            //textBox4.Clear();

        }


        private void barra1_click_guardar_button()
        {

            string tabla = "pedido_mp";
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("descr", textBox1.Text);
            d.Add("cantidad", textBox3.Text);
            d.Add("precios", textBox2.Text);
            // d.Add("fechas", textBox4.Text);
            //nac = dt_fecha.Text;
            d.Add("fechas", dt_fecha.Text);



            db.insertar(tabla, d);
            mostrar();

            limpiar1();


           





        }


        private void mostrar()
        {

            //string query = "select id_pedido, descr as 'Descripcion ' , cantidad as 'Cantidad', precios as 'Precio', fechas as 'Fecha' from pedido_mp";
            //dataGridView2.DataSource = db.consulta_DataGridView(query);

            string query1 = "select id_pedido, descr as 'Descripcion ' , cantidad as 'Cantidad', precios as 'Precio', fechas as 'Fecha' from pedido_mp";
            dataGridView1.DataSource = db.consulta_DataGridView(query1);

            //string query = "select id_pedido , descr as 'Descripcion ' from pedido_mp";
            //dataGridView2.DataSource = db.consulta_DataGridView(query);


            // string query = "select *from  pedido_mp";
            //dataGridView2.DataSource = db.consulta_DataGridView(query);


            //string query2 = "select id_prov, nombre as 'Nombre ' , direccion as 'Direccion', telefono as 'Telefono', email as 'E-mail', paginaweb as 'Pagina Web', nit as 'NIT' from proveedor_mp";
            //dataGridView2.DataSource = db.consulta_DataGridView(query2);


            //llenar combo box para buscar pedidos

            string querycd = "select id_pedido,descr from pedido_mp";
            comboBox1.DataSource = db.consulta_ComboBox(querycd);
            comboBox1.DisplayMember = "descr";
            comboBox1.ValueMember = "id_pedido";




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void barra1_click_editar_button()
        {


            string query = "select *from pedido_mp where id_pedido=" + comboBox1.SelectedValue.ToString();
            System.Collections.ArrayList array = db.consultar(query);
            foreach (Dictionary<string, string> dict in array)
            {
                textBox7.Text = dict["precios"];
                textBox8.Text = dict["descr"];
                textBox6.Text = dict["cantidad"];
                textBox5.Text = dict["fechas"];





            }

        }

        private void barra1_click_actualizar_button()
        {
            //mostrar();

            string tabla = "pedido_mp";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("descr", textBox8.Text);
            string condicion = "id_pedido=" + comboBox1.SelectedValue;
            db.actualizar(tabla, dict, condicion);

            dict.Add("precios", textBox7.Text);
            string condicion1 = "id_pedido=" + comboBox1.SelectedValue;
            db.actualizar(tabla, dict, condicion1);

            dict.Add("cantidad", textBox6.Text);
            string condicion2 = "id_pedido=" + comboBox1.SelectedValue;
            db.actualizar(tabla, dict, condicion2);

            dict.Add("fechas", textBox5.Text);
            string condicion3 = "id_pedido=" + comboBox1.SelectedValue;
            db.actualizar(tabla, dict, condicion3);



            mostrar();


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }



        private void limpiar1()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
     
        }


        private void barra1_click_nuevo_button()
        {



            limpiar1();


        }

        private void barra1_click_imprimir_button()
        {



            

        }
    }

}