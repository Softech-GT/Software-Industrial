using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Industrial
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           // toolTip1.SetToolTip(textBox1.Text, "Este es el mensaje");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usu = textBox1.Text;
            string pas=textBox2.Text;

            if (!string.IsNullOrWhiteSpace(textBox1.Text) || !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                //MessageBox.Show("Lleno");
                if (usu.Equals("demo") && pas.Equals("demo"))
                {
                    MDI mdi = new MDI();
                    mdi.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y contraseña: demo", "Inicio de session",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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
    }
}
