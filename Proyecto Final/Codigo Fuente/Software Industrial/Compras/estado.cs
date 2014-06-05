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
    public partial class estado : Form
    {
        public estado()
        {
            InitializeComponent();
        }

        //DBConnect db = new DBConnect("final_s");
        DBConnect db = new DBConnect("conexion");

        private void barra1_click_guardar_button()
        {
            //guardar


            string tabla = "catalogo";
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("estado", textBox1.Text);
            d.Add("id_pedidomp", comboBox1.SelectedValue.ToString());
           

            //.SelectedValue.ToString();

            d.Add("fecha_entrega", dt_fecha.Text);



            db.insertar(tabla, d);
            mostrar();
            limpiar2();
         

           



        }

        private void mostrar()
        {

            //llenar combo box para buscar pedidos

           string querycd = "select id_pedido,descr from pedido_mp";
            comboBox1.DataSource = db.consulta_ComboBox(querycd);
            comboBox1.DisplayMember = "descr";
            comboBox1.ValueMember = "id_pedido";





        }

        private void estado_Load(object sender, EventArgs e)
        {
            mostrar();
        }


        private void limpiar2()
        {
            textBox1.Clear();
         
        }

        
        private void barra1_click_nuevo_button()
        {

            limpiar2();
        }
    }
}
