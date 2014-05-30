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
using Software_Industrial.Produccion;

namespace Software_Industrial
{
    public partial class asignacion_maquinaria : Form
    {

        DBConnect db = new DBConnect("conexion");
        public asignacion_maquinaria()
        {
            InitializeComponent();
        }



        public void recibe_datos(string cod,string nom,string edad,string tel,string dir)
        {
            textBox1.Text = cod;
            textBox2.Text = nom;
            textBox3.Text = edad;
            textBox4.Text = tel;
            textBox5.Text = dir;


            Dictionary<string,string> dict = new Dictionary<string,string>();
            // dict.Add();

        }

        private void barra1_click_buscar_button()
        {
            new busca_empleado(this).ShowDialog();  
        }
    }
}
