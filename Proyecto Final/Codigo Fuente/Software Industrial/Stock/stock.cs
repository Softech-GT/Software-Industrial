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
using System.Collections;
using i3nRiqJSON;
namespace Software_Industrial
{
   
    public partial class stock : Form
    {
        DBConnect db = new DBConnect("conexion");
        i3nRiqJson db1 = new i3nRiqJson();
        
        public stock()
        {
            InitializeComponent();
        }

        private void stock_Load(object sender, EventArgs e)
        {
           // WSSSUP("1");
            combox();
        }   
        public void combox(){
            comboBox1.DataSource = db1.WSSSSELCOM(); 
            comboBox1.ValueMember = "idtbm_ordendeproduccion";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = "";
            dataGridView1.Columns.Clear();
            String codigo = "", cant = "", nombre = "", idpro = "";
            int va1 = 0, va2 = 0, falta = 0, res=0;
            ArrayList array, arrayv,arrayv1;
            codigo= comboBox1.SelectedValue.ToString();
            dataGridView1.DataSource = db1.consulta_DataGridView(db1.WSSSSELDAT(codigo));
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            nombre = dataGridView1.Rows[0].Cells[2].Value.ToString();

            string qq = "select a.idproducto as 'ID',a.existencia_minima as 'existencia',a.nombre,a.tipo_idtipo from producto as a where a.nombre='"+nombre+"' and a.tipo_idtipo='2'";

            array = db.consultar(qq);
            int a = array.Count;
            if (a > 0)
            {
                foreach (Dictionary<string, string> dict in array)
                {
                    cant = dict["existencia"];
                    idpro=dict["ID"];
                }
                dataGridView1.Columns.Add(cant, "Existencia");
                dataGridView1.Rows[0].Cells[7].Value = cant;
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                chk.HeaderText = "Verificación";
                chk.Name = "chk";
                chk.TrueValue = false;
                dataGridView1.Columns.Add(chk);
                dataGridView1.Visible = true;
                dataGridView1.Columns[8].ReadOnly = true;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    va1 = 0;
                    va2 = 0;

                    int.TryParse(row.Cells[7].Value.ToString(), out va1);
                    int.TryParse(row.Cells[3].Value.ToString(), out va2);

                    if (va1 >= va2)
                    {
                        row.Cells[7].Style.BackColor = Color.Green;
                        row.Cells[3].Style.BackColor = Color.Green;
                        dataGridView1.Rows[0].Cells["chk"].Value = true;

                        res = Convert.ToInt32(cant)-va2;
                        string tabla = "producto";
                        Dictionary<string, string> dicto = new Dictionary<string, string>();
                        dicto.Add("existencia_minima", res.ToString());
                        string condicion="idproducto="+idpro;
                        db.actualizar(tabla, dicto, condicion);
                        string id=row.Cells[0].Value.ToString();
                        
                        MessageBox.Show("La orden se ha completado con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db1.WSSSUP(id);
                        combox();
                    }
                    else
                    {
                        row.Cells[7].Style.BackColor = Color.Red;
                        row.Cells[3].Style.BackColor = Color.Red;
                        falta = va2 - va1;
                        String tablita = "tbm_ordenproduccion";
                        String name=row.Cells[2].Value.ToString();
                        string querys = "select tx_nombre, cantidad_solicitada from tbm_ordenproduccion where tx_nombre='"+name+"' and cantidad_solicitada='"+falta+"' and estado='0'";
                        arrayv = db.consultar(querys);
                        int count = arrayv.Count;
                        if (count > 0)
                        {
                            MessageBox.Show("La orden ya esta ingresada, se esta procesando", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            combox();
                        }
                        else { 
                        Dictionary<string, string> dicts = new Dictionary<string, string>();
                        dicts.Add("tx_nombre", name);
                        dicts.Add("cantidad_solicitada", falta.ToString());
                        db.insertar(tablita, dicts);
                        MessageBox.Show("La orden se ha mandado a producción", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        combox();
                    }
                    }



                }
            }
            else
            {
                String tablita = "tbm_ordenproduccion";
                String name = dataGridView1.Rows[0].Cells[2].Value.ToString();
                string querys1 = "select tx_nombre, cantidad_solicitada from tbm_ordenproduccion where tx_nombre='" + name + "' and cantidad_solicitada='" + dataGridView1.Rows[0].Cells[3].Value.ToString() + "' and estado='0'";
                arrayv1 = db.consultar(querys1);
                int count1 = arrayv1.Count;
                if (count1 > 0)
                {
                    MessageBox.Show("La orden ya esta ingresada, se esta procesando", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    combox();
                }
                else
                {
                    MessageBox.Show("El producto solicitado, no esta registrado" + "\n" + "se procesara la producción del nuevo producto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dictionary<string, string> dicts = new Dictionary<string, string>();
                    dicts.Add("tx_nombre", name);
                    dicts.Add("cantidad_solicitada", dataGridView1.Rows[0].Cells[3].Value.ToString());
                    db.insertar(tablita, dicts);
                    combox();
                }

            }
           }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }
       

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
