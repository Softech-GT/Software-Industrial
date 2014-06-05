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

using Software_Industrial.Inventario;

namespace Software_Industrial
{
    public partial class MDI : Form
    {
        int id = 0;
        public MDI(string x)
        {
            InitializeComponent();
            button7.Location=new Point(10,129);
            button1.Location = new Point(107, 129);
            verifica(x); 
        }



        private void verifica(string x)
        {
            if (x.Equals("admin"))
            {

                pictureBox6.Visible = true;
                label6.Visible = true;
            }
            else
            {

                id = 1;

            }
        }

        private void MDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {         
            produccion child = new produccion();  
            child.MdiParent = this;            
            child.Show();           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            inventarios inv = new inventarios();
            inv.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            produccion child = new produccion();
            child.MdiParent = this;
            child.Show();
        }

        bool band=true;
        private void button7_Click(object sender, EventArgs e)
        {
            if (band)
            {
                button7.Text = "Mostrar";
                splitter1.Visible = false;
                pictureBox1.Visible = false;
                label1.Visible = false;
                pictureBox2.Visible = false;
                label2.Visible = false;
                pictureBox3.Visible = false;
                label3.Visible = false;
                pictureBox4.Visible = false;
                label4.Visible = false;
                pictureBox5.Visible = false;
                label5.Visible = false;
                button7.Location = new Point(10, 0);
                button1.Location = new Point(107, 0);
                label6.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                band = false;
            }
            else
            {

                if (id == 0)
                {
                    button7.Text = "Ocultar";
                    splitter1.Visible = true;
                    pictureBox1.Visible = true;
                    label1.Visible = true;
                    pictureBox2.Visible = true;
                    label2.Visible = true;
                    pictureBox3.Visible = true;
                    label3.Visible = true;
                    pictureBox4.Visible = true;
                    label4.Visible = true;
                    pictureBox5.Visible = true;
                    label5.Visible = true;
                    button7.Location = new Point(10, 129);
                    button1.Location = new Point(107, 129);
                    label6.Visible = true;
                    pictureBox6.Visible = true;
                    pictureBox7.Visible = true;
                    band = true;
                }

                else 
                { 
                button7.Text = "Ocultar";
                splitter1.Visible = true;
                pictureBox1.Visible = true;
                label1.Visible = true;
                pictureBox2.Visible = true;
                label2.Visible = true;
                pictureBox3.Visible = true;
                label3.Visible = true;
                pictureBox4.Visible = true;
                label4.Visible = true;
                pictureBox5.Visible = true;
                label5.Visible = true;
                button7.Location = new Point(10, 129);
                button1.Location = new Point(107, 129);
                label6.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
                band = true;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Recursos_Humanos child = new Recursos_Humanos();
            
            child.MdiParent = this;
            child.Show();   
        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            
            compras c = new compras();
            c.MdiParent = this;
            c.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            productos p = new productos();
            p.MdiParent = this;
            p.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            stock s = new stock();
            s.MdiParent = this;
            s.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            produccion child = new produccion();
            child.MdiParent = this;
            child.Show();   
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            bitacora b = new bitacora();
            b.MdiParent = this;
            b.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            gastos g = new gastos();
            g.MdiParent = this.MdiParent;
            g.Show();
        }

       
        
    }
}
