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
    public partial class buscar_formula : Form
    {
        DBConnect db = new DBConnect("conexion");

        public buscar_formula()
        {
            InitializeComponent();
        }
        private void actualizar()
        {
            string tipo = "select idtipo_receta,nombre from tipo_receta;";
            comboBox1.DataSource = db.consulta_ComboBox(tipo);
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "idtipo_receta";
        }

        private void buscar_formula_Load(object sender, EventArgs e)
        {
            actualizar();
        }
    }
}
