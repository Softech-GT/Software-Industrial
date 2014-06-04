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
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.ds_prod' Puede moverla o quitarla según sea necesario.
            this.ds_prodTableAdapter.Fill(this.DataSet1.ds_prod);

            this.reportViewer1.RefreshReport();
        }
    }
}
