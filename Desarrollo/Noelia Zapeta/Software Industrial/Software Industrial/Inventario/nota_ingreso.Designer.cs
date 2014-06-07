namespace Software_Industrial.Inventario
{
    partial class nota_ingreso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nota_ingreso));
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.barra1 = new Navegador.Barra();
            this.GroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.GroupBox4.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox5
            // 
            this.GroupBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GroupBox5.Controls.Add(this.DataGridView1);
            this.GroupBox5.Location = new System.Drawing.Point(36, 315);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(662, 171);
            this.GroupBox5.TabIndex = 9;
            this.GroupBox5.TabStop = false;
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(19, 20);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(623, 133);
            this.DataGridView1.TabIndex = 0;
            // 
            // GroupBox4
            // 
            this.GroupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GroupBox4.Controls.Add(this.TextBox3);
            this.GroupBox4.Controls.Add(this.Label7);
            this.GroupBox4.Location = new System.Drawing.Point(36, 243);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(662, 57);
            this.GroupBox4.TabIndex = 8;
            this.GroupBox4.TabStop = false;
            // 
            // TextBox3
            // 
            this.TextBox3.Enabled = false;
            this.TextBox3.Location = new System.Drawing.Point(101, 12);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(223, 20);
            this.TextBox3.TabIndex = 1;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(22, 20);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(62, 13);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "Encargado ";
            // 
            // GroupBox3
            // 
            this.GroupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GroupBox3.Controls.Add(this.comboBox3);
            this.GroupBox3.Controls.Add(this.ComboBox2);
            this.GroupBox3.Controls.Add(this.Label6);
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Location = new System.Drawing.Point(36, 187);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(662, 44);
            this.GroupBox3.TabIndex = 7;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Enter += new System.EventHandler(this.GroupBox3_Enter);
            // 
            // comboBox3
            // 
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(439, 13);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(192, 21);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // ComboBox2
            // 
            this.ComboBox2.Enabled = false;
            this.ComboBox2.FormattingEnabled = true;
            this.ComboBox2.Location = new System.Drawing.Point(84, 13);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(216, 21);
            this.ComboBox2.TabIndex = 3;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(333, 16);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(91, 13);
            this.Label6.TabIndex = 2;
            this.Label6.Text = "Tipo de producto ";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(19, 16);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(59, 13);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Proveedor ";
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GroupBox2.Controls.Add(this.textBox1);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.DateTimePicker2);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Location = new System.Drawing.Point(36, 93);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(295, 88);
            this.GroupBox2.TabIndex = 6;
            this.GroupBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(101, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 7;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(15, 57);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(40, 13);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Fecha ";
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.Enabled = false;
            this.DateTimePicker2.Location = new System.Drawing.Point(73, 57);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.DateTimePicker2.TabIndex = 5;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(15, 20);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(74, 13);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "No. de Orden ";
            // 
            // barra1
            // 
            this.barra1.BackColor = System.Drawing.Color.Transparent;
            this.barra1.Location = new System.Drawing.Point(216, 11);
            this.barra1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(268, 42);
            this.barra1.TabIndex = 10;
            this.barra1.click_nuevo_button += new Navegador.Barra.delegadoButton(this.barra1_click_nuevo_button);
            this.barra1.click_guardar_button += new Navegador.Barra.delegadoButton(this.barra1_click_guardar_button);
            // 
            // nota_ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(731, 501);
            this.Controls.Add(this.barra1);
            this.Controls.Add(this.GroupBox5);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Name = "nota_ingreso";
            this.Text = "Nota de Ingreso";
            this.Load += new System.EventHandler(this.nota_ingreso_Load);
            this.GroupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.TextBox TextBox3;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.ComboBox ComboBox2;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.DateTimePicker DateTimePicker2;
        internal System.Windows.Forms.Label Label3;
        private Navegador.Barra barra1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox1;
    }
}