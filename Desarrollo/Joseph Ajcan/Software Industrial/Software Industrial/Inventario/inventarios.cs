﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Industrial.Inventario
{
    public partial class inventarios : Form
    {
        public inventarios()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            productos p = new productos();
            p.Show();
        }
    }
}
