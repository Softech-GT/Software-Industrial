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
    public partial class crear_receta : Form
    {

        DBConnect db = new DBConnect("conexion");
        bool editar = false, nuevo = false, cambio = false;
        int id = 0;
        public crear_receta()
        {
            InitializeComponent();
         
        }
        
        bool band_nuevo = false;

        private void barra1_click_buscar_button()
        {
            new buscar_formula(this).ShowDialog();  
        }

        public void recibe_datos(string codigo,string nombre,string descripcion,string estado,string fecha) 
        {
            textBox1.Text = codigo;
            textBox2.Text = nombre;
            textBox5.Text = descripcion;
            textBox3.Text = fecha;
            habilita_detalle();
            detalle_receta();
        }

        private void actualiza() 
        {
            DateTime fechaHoy = DateTime.Now;
            string fecha = fechaHoy.ToString("yyyy-MM-dd");
            textBox3.Text = fecha;

            string elemento = "select idproducto, nombre from producto where tipo_idtipo=1;";
            comboBox2.DataSource = db.consulta_ComboBox(elemento);
            comboBox2.DisplayMember = "nombre";
            comboBox2.ValueMember = "idproducto";


            string medida = "select idmedidas,nombre from medidas;";
            comboBox3.DataSource = db.consulta_ComboBox(medida);
            comboBox3.DisplayMember = "nombre";
            comboBox3.ValueMember = "idmedidas";

            int numero = 1;
            string val_ant="";
            string query = "select MAX(idreceta) as ultimo from receta;";
            System.Collections.ArrayList array = db.consultar(query);
            foreach (Dictionary<string, string> dict in array)
            {
                val_ant=dict["ultimo"];
            }


            if (val_ant.Equals(""))
            {
                textBox1.Text = numero.ToString();
            }
            else {
                numero = numero + (int.Parse(val_ant));            
                textBox1.Text = numero.ToString(); 
            }

            



        }

        private void detalle_receta()
        {
            string query = "select p.nombre,d.cantidad ,m.abreviatura from producto as p,detalle_receta as d,medidas as m where p.idproducto = d.idproducto and m.idmedidas = d.idmedidas and idreceta=" + textBox1.Text;
            receta_dgw.DataSource = db.consulta_DataGridView(query);
        }


        private void crear_receta_Load(object sender, EventArgs e)
        {
            actualiza();
        }

        string estado = "De alta";

        private void habilita_detalle()
        {
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            textBox4.ReadOnly = false;
        }
        
        private void barra1_click_guardar_button()
        {
           

            if (radioButton2.Checked == true)
             {
                 estado = "De Baja";
             }

            if (band_nuevo)
            {
               if (MessageBox.Show("Desea guardar", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("nombre", textBox2.Text);
                    dict.Add("descripcion", textBox5.Text);
                    dict.Add("estado", estado);
                    dict.Add("fecha", textBox3.Text);
                    db.insertar("receta", dict);

                    habilita_detalle();

                }


                textBox2.ReadOnly = true;
                textBox5.ReadOnly = true;
                band_nuevo = false;
            }
            else
            {
                Dictionary<string, string> dict1 = new Dictionary<string, string>();
                dict1.Add("idreceta", textBox1.Text);
                dict1.Add("idproducto", comboBox2.SelectedValue.ToString());
                dict1.Add("idmedidas", comboBox3.SelectedValue.ToString());
                dict1.Add("cantidad", textBox4.Text);
                db.insertar("detalle_receta", dict1);
               
                detalle_receta();
                
            }


        }

        

        private void barra1_click_nuevo_button()
        {
            textBox2.ReadOnly = false;
            textBox5.ReadOnly = false;
            textBox2.Focus();
            band_nuevo = true;
            textBox2.Clear();
            textBox5.Clear();
            receta_dgw.DataSource = null;
       }

        private void barra1_click_eliminar_button()
        {
            if (cambio)
            {
                int k = receta_dgw.CurrentRow.Index;
                id = Convert.ToInt32(receta_dgw.Rows[k].Cells[0].Value);
                if (MessageBox.Show("¿Desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.eliminar("receta", "idreceta=" + id);
                    actualiza();
                }
            }
        }

        private void receta_dgw_SelectionChanged(object sender, EventArgs e)
        {
            cambio = true;
        }

        private void barra1_click_actualizar_button()
        {
            actualiza();
        }
    }
}
