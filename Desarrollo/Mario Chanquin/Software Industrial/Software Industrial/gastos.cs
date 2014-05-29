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
    public partial class gastos : Form
    {
        public gastos()
        {
            InitializeComponent();
        }
        DBConnect db=new DBConnect("recursos_humanos");
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x;
            double z;
            x = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text);
            z = x/ Convert.ToInt32(textBox4.Text);
            textBox5.Text = z.ToString();

            textBox14.Text = textBox4.Text;
            textBox9.Text = textBox4.Text;
            textBox17.Text = textBox4.Text;

            textBox14.Enabled = false;
            textBox9.Enabled = false;
            textBox14.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x;
            double z;
            x = Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox7.Text) + Convert.ToInt32(textBox8.Text);
            z = x / Convert.ToInt32(textBox9.Text);
            textBox10.Text = z.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x;
            double z;
            x = Convert.ToInt32(textBox11.Text) + Convert.ToInt32(textBox12.Text) + Convert.ToInt32(textBox13.Text);
            z = x / Convert.ToInt32(textBox14.Text);
            textBox15.Text = z.ToString();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void gastos_Load(object sender, EventArgs e)
        {

            DateTime dt = DateTime.Now;
            //Response.Write(dt.Year.ToString());
            textBox19.Text=dt.Year.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double m;
            double n;
            m = Convert.ToDouble(textBox5.Text) + Convert.ToDouble(textBox10.Text) + Convert.ToDouble(textBox15.Text);
            textBox16.Text = "Q"+ m.ToString();

            n=  m* Convert.ToDouble(textBox17.Text);
            textBox18.Text = "Q"+ n.ToString();

            string tabla="tbm_gf";
            string mes = "",costou="",costoto="";
            costou = textBox16.Text;
            costou = costou.Replace("Q","");
            costoto = textBox18.Text;
            costoto = costoto.Replace("Q", "");
            mes = comboBox1.SelectedItem.ToString();
            Dictionary<string, string> dict=new Dictionary<string,string>();
            dict.Add("unidades_prod",textBox17.Text);
            dict.Add("costo_unit",costou);
            dict.Add("costo_total",costoto);
            dict.Add("mes",mes);
            dict.Add("año",textBox19.Text);
            db.insertar(tabla,dict);

            
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            string query = ("select unidades_prod as 'Unidades Producidas',costo_unit as 'Costo Unitario',costo_total as 'Costo Total',mes as 'Mes', año as 'Año' from tbm_gf");
            dataGridView1.DataSource = db.consulta_DataGridView(query);
        }


    }
}
