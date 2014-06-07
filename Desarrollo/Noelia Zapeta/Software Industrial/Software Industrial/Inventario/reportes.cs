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


namespace Software_Industrial.Inventario
{
    public partial class reportes : Form
    {
        DBConnect db = new DBConnect("conexion");
        public reportes()
        {
            InitializeComponent();
        }

        private void reportes_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void actualizar()
        {
            dt_producto.DataSource = db.consulta_DataGridView("Select nombre as Nombre, tipo_idtipo as Tipo, peso as Peso, existencia_minima as 'Existencia Minima', costo_unitario as 'Costo Unitario', fecha_ingreso as 'Fecha de Ingreso' from producto");
            dataGridView3.DataSource = db.consulta_DataGridView("select idsalida as Salida, fecha as Fecha, encargado as Encargado, tipo_idtipo as 'Tipo de producto' from salida");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
