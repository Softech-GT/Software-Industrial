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
    public partial class registro_usuarios : Form
    {
        public registro_usuarios()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect("conexion");
        private void button1_Click(object sender, EventArgs e)
        {
            string usu = "";
            string pas = "";

            string query = ("select nombre, pass from usuarios where nombre = '" + textBox1.Text +"' and pass='"+textBox2.Text+"'" );
            System.Collections.ArrayList array = db.consultar(query);
            foreach (Dictionary<string, string> dict in array)
            {
                usu= dict ["nombre"];
                pas = dict["pass"];
            }

            

            if (!string.IsNullOrWhiteSpace(textBox1.Text) || !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                //MessageBox.Show("Lleno");
                if (usu.Equals(textBox1.Text ) && pas.Equals(textBox2.Text ))
                {
                    asignar_usuarios  au = new asignar_usuarios ();
                    au.MdiParent = this.MdiParent;
                    au.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y contraseña INCORRECTO", "Inicio de session",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    textBox1.Text = "";
                    textBox2.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Error al iniciar session", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        }
    }

