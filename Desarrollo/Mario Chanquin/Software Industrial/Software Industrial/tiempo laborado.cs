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
    public partial class tiempo_laborado : Form
    {
        public tiempo_laborado()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect("recursos_humanos");
        private void tiempo_laborado_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = db.consulta_ComboBox("select nome from tbempleado;");
            comboBox1.DisplayMember = "nome";
        }
    }
}
