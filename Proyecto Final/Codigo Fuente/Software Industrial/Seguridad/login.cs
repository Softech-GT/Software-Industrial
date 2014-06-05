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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect("conexion");
        private void Form1_Load(object sender, EventArgs e)
        {
            
           // toolTip1.SetToolTip(textBox1.Text, "Este es el mensaje");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usu = "";
            string pas = "";

            string query = ("select nombre, pass from usuarios where nombre = '" + textBox1.Text + "' and pass='" + textBox2.Text + "'");
            System.Collections.ArrayList array = db.consultar(query);
            foreach (Dictionary<string, string> dict in array)
            {
                usu = dict["nombre"];
                pas = dict["pass"];
            }

            if (!string.IsNullOrWhiteSpace(textBox1.Text) || !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                //MessageBox.Show("Lleno");
                if (usu.Equals(textBox1.Text) && pas.Equals(textBox2.Text))
                {
                    //  bit.recibe_usuario(usu);
                    MDI mdi = new MDI(usu);
                    mdi.Show();
                    this.Hide();

                    //bit.recibe_usuario("marito chanquin");
                }
                else
                {
                    MessageBox.Show("Usuario y contraseña: INCORRECTO", "Inicio de session", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox1.Text = "";
                    textBox2.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Error al iniciar session", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que dese salir?", "Salir",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Gracias por utilizar nuestro producto");
                Application.Exit();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registro_usuarios ru = new registro_usuarios();
            ru.MdiParent = this.MdiParent;
            ru.Show();
        } 
    }
}
