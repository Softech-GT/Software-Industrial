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
    public partial class bitacora : Form
    {
        public bitacora()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect("recursos_humanos");
        private void bitacora_Load(object sender, EventArgs e)
        {
            string query = "select idbitacora, usu_bit as 'ID', ip_local as 'IP Local', ip_publica as 'IP Publica', fecha as 'Fecha', descr as 'Descripcion' from bitacora";
            bitacora_dgw.DataSource = db.consulta_DataGridView(query);
            bitacora_dgw.Columns[0].Visible = false;
            bitacora_dgw.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
