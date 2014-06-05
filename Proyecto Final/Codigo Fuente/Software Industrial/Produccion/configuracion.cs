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
        bool editar = false;

        string id = "";

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

                string idc="";

                string cont = "SELECT COUNT(*) as total FROM moneda_local;";
                System.Collections.ArrayList arra = db.consultar(cont);
                foreach(Dictionary<string,string> dicc in arra)
                {
                    idc=dicc["total"];
                }

                

                //label1.Text = "a";
                
                //string simone = "select p.nombre,m.moneda, m.simbologia from pais_m as p , moneda_local as m where p.idpais = m.idmoneda_local = "+idc;
                string simone = "select (select nombre from pais_m where idpais=(select max(idpais) from moneda_local)) as Pais, moneda as Moneda, simbologia as Simbologia from moneda_local  where idmoneda_local = (select max(idmoneda_local) as mayor from moneda_local);";
                System.Collections.ArrayList array = db.consultar(simone);
                foreach (Dictionary<string, string> dict in array)
                {

                    label15.Text = dict["Pais"];
                    label17.Text = dict["Moneda"];
                    label19.Text = dict["Simbologia"];
                }



                if ((label15.Text != "label15") || (label17.Text != "label17") || (label17.Text != "label19"))
                {
                    label15.Visible = true;
                    label17.Visible = true;
                    label19.Visible = true;

                    comboBox2.Enabled = false;
                    comboBox3.Enabled = false;

                    label20.Text = "Ya cueta con el registro de su moneda local";
                    label20.Visible = true;
                }


            }


                catch(Exception e){
                    Console.WriteLine("{0} Exception caught.", e);
                }

             
           
        }

        private void limpiar() 
        {           
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }



        private void barra1_click_guardar_button()
        {

            string seleccion1 = tabControl1.SelectedTab.Text;
            string seleccion2 = tabControl1.SelectedTab.Text;


            if (editar)
            {
                if (seleccion1.Equals("Medidas"))
                {
                    if (MessageBox.Show("Desea guardar", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Dictionary<string, string> dict = new Dictionary<string, string>();
                        //dict.Add("idmedidas", textBox1.Text);
                        dict.Add("nombre", textBox2.Text);
                        dict.Add("abreviatura", textBox3.Text);
                        //db.insertar("medidas", dict);
                        db.actualizar("medidas",dict,"idmedidas="+id);
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
                   /* if (label20.Text == "") // if (label20.Visible == false)
                    {
                        if (MessageBox.Show("Desea cambiar de moneca local", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            Dictionary<string, string> dict = new Dictionary<string, string>();
                            dict.Add("idcontiente", "1");
                            dict.Add("idpais", comboBox2.SelectedValue.ToString());
                            dict.Add("moneda", comboBox3.SelectedValue.ToString());
                            dict.Add("simbologia", label13.Text);
                           // db.insertar("moneda_local", dict);

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
                    */
                }


                if (seleccion1.Equals("Depreciaciones"))
                {
                    if (MessageBox.Show("Desea guardar", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {

                        Dictionary<string, string> dict = new Dictionary<string, string>();
                        //dict.Add("iddepreciaciones", textBox6.Text);
                        dict.Add("equipo", textBox7.Text);
                        dict.Add("porcentaje", textBox8.Text);
                        db.actualizar("depre_deley", dict, "iddepreciaciones" + id);
                        limpiar();
                        actualizar();
                    }
                    else
                    {
                        MessageBox.Show("Cancelacion de guardado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
            else
            {

                if (seleccion1.Equals("Medidas"))
                {
                    if (MessageBox.Show("Desea guardar", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Dictionary<string, string> dict = new Dictionary<string, string>();
                        //dict.Add("idmedidas", textBox1.Text);
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
                    if (label20.Text == "") // if (label20.Visible == false)
                    {
                        if (MessageBox.Show("Desea cambiar de moneca local", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            Dictionary<string, string> dict = new Dictionary<string, string>();
                            dict.Add("idcontiente", "1");
                            dict.Add("idpais", comboBox2.SelectedValue.ToString());
                            dict.Add("moneda", comboBox3.SelectedValue.ToString());
                            dict.Add("simbologia", label13.Text);
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
                        //dict.Add("iddepreciaciones", textBox6.Text);
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

           
        }

        private void configuracion_Load(object sender, EventArgs e)
        {
            try
            {
                actualizar();
            }
            catch{}
                
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
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.White;
            }
            if (seleccion.Equals("Moneda"))
            {
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                label15.Text = "";
                label17.Text = "";
                label19.Text = "";
                label20.Text = "";

                
            }
            if (seleccion.Equals("Depreciaciones"))
            {
                textBox7.ReadOnly = false;
                textBox8.ReadOnly = false;
                textBox7.BackColor = Color.White;
                textBox8.BackColor = Color.White;
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

        private void barra1_click_editar_button()
        {
            string seleccion = tabControl1.SelectedTab.Text;
       

            editar = true;


            if (seleccion.Equals("Medidas"))
            {
                int i = dataGridView1.CurrentRow.Index;
                id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                //MessageBox.Show(id);
                tabControl2.SelectedIndex = 1;
                textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false; 

            }
            if (seleccion.Equals("Moneda"))
            {
                
            }
            if (seleccion.Equals("Depreciaciones"))
            {
                int i = dataGridView2.CurrentRow.Index;
                id = dataGridView2.Rows[i].Cells[0].Value.ToString();
                textBox7.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
                textBox8.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
                textBox7.ReadOnly = false;
                textBox8.ReadOnly = false;
               // MessageBox.Show(id);
            }
        }

        private void barra1_click_actualizar_button()
        {
            actualizar();
        }

       
    }
}
