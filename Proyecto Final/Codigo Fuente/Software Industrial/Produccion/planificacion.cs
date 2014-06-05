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

namespace Software_Industrial.Produccion
{
    public partial class planificacion : Form
    {

        DBConnect db = new DBConnect("conexion");

        public planificacion()
        {
            InitializeComponent();
            contar();
        }

        private int idpro=1;
        private string idb = "";



        private void contar() 
        {
            string idc = "";

            string cont = "select MAX(idproduccion_pro) as ultmo from produccion_pro;";
            System.Collections.ArrayList arra = db.consultar(cont);
            foreach (Dictionary<string, string> dicc in arra)
            {
                idc = dicc["ultmo"];
            }

            if (idc.Equals(""))
            {
                idpro=1;
            }
            else
            {
                idpro = idpro + (int.Parse(idc));
             }

            //MessageBox.Show(idpro.ToString());
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new asigna_empleado(this).ShowDialog();  
        }

        bool band = false;
        public void recibe_empleado(string codigo, string nombre, string edad, string telefono, string direccion) 
        {
            //MessageBox.Show(idpro.ToString());
            if (band)
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("idproduccion_pro",idb);
                dict.Add("orden_pro",textBox1.Text); 
                dict.Add("codigo",codigo);
                dict.Add("nombre",nombre);
                dict.Add("edad",edad);
                dict.Add("telefono",telefono);
                dict.Add("direccion",direccion);
                db.insertar("detpro_person", dict);
                actualiza_detales();

            }
            else 
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("idproduccion_pro", idpro.ToString());
                dict.Add("orden_pro", textBox1.Text);
                dict.Add("codigo", codigo);
                dict.Add("nombre", nombre);
                dict.Add("edad", edad);
                dict.Add("telefono", telefono);
                dict.Add("direccion", direccion);
                db.insertar("detpro_person", dict);
                actualiza_detales();

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new asigna_maquinaria(this).ShowDialog();  
        }

        public void recibe_maquinaria(string codigo,string marca,string modelo, string descripcion)
        {
            if (band)
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("idproduccion_pro", idb);
                dict.Add("orden_pro", textBox1.Text);
                dict.Add("codigo", codigo);
                dict.Add("marca", marca);
                dict.Add("modelo", modelo);
                dict.Add("descripcion", descripcion);
                db.insertar("detpro_maq", dict);
                actualiza_detales();
            }
            else
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("idproduccion_pro", idpro.ToString());
                dict.Add("orden_pro", textBox1.Text);
                dict.Add("codigo", codigo);
                dict.Add("marca", marca);
                dict.Add("modelo", modelo);
                dict.Add("descripcion", descripcion);
                db.insertar("detpro_maq", dict);
                actualiza_detales();
            }


        }

        private void barra1_click_nuevo_button()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void barra1_click_guardar_button()
        {
            if ((textBox1.Text == "")|| (textBox2.Text==""))
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Desea guardar", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("orden_pro", textBox1.Text);
                    dict.Add("descripcion", textBox2.Text);
                    dict.Add("fecha_ini", dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"));
                    dict.Add("fecha_fin", dateTimePicker2.Value.Date.ToString("yyyy-MM-dd"));
                    db.insertar("produccion_pro", dict);

                    textBox1.ReadOnly = true;
                    textBox2.ReadOnly = true;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                }
                
            }
        }

        private void barra1_click_buscar_button()
        {
            new busca_produccion(this).ShowDialog();  
        }

        public void recibe_produccion(string id_pro,string orden_pro,string descripcion,string fecha_ini,string fecha_fin)
        {
            textBox1.Text = orden_pro;
            textBox2.Text = descripcion;
            dateTimePicker1.Text = fecha_ini;
            idb = id_pro;
           // MessageBox.Show(idb);
            band = true;
            actualiza_detales();
            
        }

        private void actualiza_detales() 
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            if (band)
            {
                string queryp = "select iddetpro_person, nombre as Nombre, edad as Edad, telefono as Telefono, direccion as Direccion from detpro_person where idproduccion_pro=" + idb;
                dataGridView1.DataSource = db.consulta_DataGridView(queryp);
                dataGridView1.Columns[0].Visible = false;

                string querym = "select iddetpro_maq, marca as Marca,modelo as Modelo,descripcion as Descripcio from detpro_maq  where idproduccion_pro=" + idb;
                dataGridView2.DataSource = db.consulta_DataGridView(querym);
                dataGridView2.Columns[0].Visible = false;
            }
            else 
            {
                string queryp = "select iddetpro_person, nombre as Nombre, edad as Edad, telefono as Telefono, direccion as Direccion from detpro_person where idproduccion_pro=" + idpro.ToString();
                dataGridView1.DataSource = db.consulta_DataGridView(queryp);
                dataGridView1.Columns[0].Visible = false;

                string querym = "select iddetpro_maq, marca as Marca,modelo as Modelo,descripcion as Descripcio from detpro_maq  where idproduccion_pro=" + idpro.ToString();
                dataGridView2.DataSource = db.consulta_DataGridView(querym);
                dataGridView2.Columns[0].Visible = false;
            }
            

            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = "";
            int i = dataGridView1.CurrentRow.Index;
            id = dataGridView1.Rows[i].Cells[0].Value.ToString();

            string condicion = "iddetpro_person=" + id;
            db.eliminar("detpro_person", condicion);
            actualiza_detales();
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = "";
            int i = dataGridView2.CurrentRow.Index;
            id = dataGridView2.Rows[i].Cells[0].Value.ToString();

            string condicion = "iddetpro_maq=" + id;
            db.eliminar("detpro_maq", condicion);
            actualiza_detales();
        }

        private void barra1_click_actualizar_button()
        {
            
        }
    }
}
