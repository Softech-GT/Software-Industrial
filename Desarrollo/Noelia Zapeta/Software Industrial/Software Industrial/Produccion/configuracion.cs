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

    public partial class configuracion : Form
    {
        public configuracion()
        {
            InitializeComponent();
        }

        Boolean bcb1 = false;
        Boolean bcb2 = false;


        DBConnect db = new DBConnect("conexion");

        private void actualizar()
        {
            try
            {
                string query = "select idmedidas as Codigo, nombre as Nombre, abreviatura as Abreviatura from medidas;";
                dataGridView1.DataSource = db.consulta_DataGridView(query);


                string query1 = "select iddepreciaciones as Codigo, equipo as Equipo, porcentaje as '%'  from depre_deley;";
                dataGridView2.DataSource = db.consulta_DataGridView(query1);


                string cbpais = "select idpais,nombre from pais_m";
                comboBox2.DataSource = db.consulta_ComboBox(cbpais);
                comboBox2.DisplayMember = "nombre";
                comboBox2.ValueMember = "idpais";



                string cbmone = "select nombre from moneda where idpais=" + comboBox2.SelectedValue;
                comboBox3.DataSource = db.consulta_ComboBox(cbmone);
                comboBox3.DisplayMember = "nombre";
                comboBox3.ValueMember = "nombre";


                int c1 = dataGridView1.RowCount;
                c1 = c1 -1;
                //textBox1.Text = c1.ToString();


                int c2 = dataGridView2.RowCount;
                c2 = c2 + 1;
                textBox6.Text = c2.ToString();

                string id;
                id = dataGridView1.Rows[c1].Cells[0].Value.ToString();

                textBox1.Text = id;

            

            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
          
           
           
        }

        private void limpiar() 
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }



        private void barra1_click_guardar_button()
        {

            string seleccion1 = tabControl1.SelectedTab.Text;
            string seleccion2 = tabControl1.SelectedTab.Text;


 
            if (seleccion1.Equals("Medidas"))
            {
                if (MessageBox.Show("Desea guardar", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("idmedidas", textBox1.Text);
                    dict.Add("nombre", textBox2.Text);
                    dict.Add("abreviatura", textBox3.Text);
                    db.insertar("medidas", dict);
                    limpiar();
                    actualizar();
                }
                else
                {
                    MessageBox.Show("Cancelacion de guardado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (seleccion1.Equals("Moneda"))
            {
                if (label20.Visible == false)
                {
                    if (MessageBox.Show("Desea guardar", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Dictionary<string, string> dict = new Dictionary<string, string>();
                        dict.Add("idcontiente", "1");
                        dict.Add("idpais", comboBox2.SelectedValue.ToString());
                        dict.Add("moneda", comboBox3.SelectedValue.ToString());
                        dict.Add("simbologia", label10.Text);
                        db.insertar("moneda_local", dict);
                        limpiar();
                        actualizar();
                    }
                    else
                    {
                        MessageBox.Show("Cancelacion de guardado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else 
                {
                    MessageBox.Show("No puede guardar este campo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                

            }


            if (seleccion1.Equals("Depreciaciones"))
            {
                if (MessageBox.Show("Desea guardar", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
              
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("iddepreciaciones", textBox6.Text);
                dict.Add("equipo", textBox7.Text);
                dict.Add("porcentaje", textBox8.Text);
                db.insertar("depre_deley", dict);
                limpiar();
                actualizar();
                }
                else
                {
                    MessageBox.Show("Cancelacion de guardado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } 



           
        }

        private void configuracion_Load(object sender, EventArgs e)
        {
            actualizar();
        }

     

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (bcb1)
            {
                string cbmone = "select nombre from moneda where idpais=" + comboBox2.SelectedValue;
                comboBox3.DataSource = db.consulta_ComboBox(cbmone);
                comboBox3.DisplayMember = "nombre";
                comboBox3.ValueMember = "nombre";


                
            }
            bcb1 = true;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bcb2)
            {
                //ssageBox.Show(comboBox3.SelectedValue.ToString());
                label13.Visible = true;
                string simone = "select simbologia from moneda where nombre='" + comboBox3.SelectedValue+"'";
                System.Collections.ArrayList array = db.consultar(simone);
                foreach (Dictionary<string, string> dict in array)               
                {

                    label13.Text = dict["simbologia"];
                }
                
            }
            bcb2 = true;
        }

        private void bloquea_tab1()
        {
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            label20.Visible = true;
        }

       

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex.ToString()=="1")
            {
                
                int c1 = comboBox2.Items.Count;                
                int c2 = comboBox3.Items.Count;
                
                if ((c1 < 1) ||(c2<1))
                {
                    bloquea_tab1();
                }
                               
            }
        }

        private void barra1_click_nuevo_button()
        {

            string seleccion = tabControl1.SelectedTab.Text;

            if (seleccion.Equals("Medidas"))
            {
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
            }
            if (seleccion.Equals("Moneda"))
            {

            }
            if (seleccion.Equals("Depreciaciones"))
            {
                textBox7.ReadOnly = false;
                textBox8.ReadOnly = false;
            }
        }

        private void barra1_click_eliminar_button()
        {
            string id;

            try
            {
                if (tabControl2.SelectedIndex.ToString() == "1")
                {
                    int i = dataGridView1.CurrentRow.Index;
                    id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show("Desea eliminar el dato", "Eliminacion de datos", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string condicion = "idmedidas=" + id;
                        db.eliminar("medidas", condicion);
                        actualizar();
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }


                if (tabControl4.SelectedIndex.ToString() == "1")
                {
                    int i = dataGridView1.CurrentRow.Index;
                    id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show("Desea eliminar el dato", "Eliminacion de datos", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string condicion = "iddepreciaciones=" + id;
                        db.eliminar("depre_deley", condicion);
                        actualizar();
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
            }
            catch
            { 
            }

        }

       
    }
}
