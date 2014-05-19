namespace Software_Industrial
{
    partial class puestos
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
            this.departamento_cmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.salario_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.descripcion_text = new System.Windows.Forms.TextBox();
            this.puesto_dgw = new System.Windows.Forms.DataGridView();
            this.requisitos_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sueldo_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.puesto_dgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // departamento_cmb
            // 
            this.departamento_cmb.Enabled = false;
            this.departamento_cmb.FormattingEnabled = true;
            this.departamento_cmb.Location = new System.Drawing.Point(103, 201);
            this.departamento_cmb.Margin = new System.Windows.Forms.Padding(2);
            this.departamento_cmb.Name = "departamento_cmb";
            this.departamento_cmb.Size = new System.Drawing.Size(413, 21);
            this.departamento_cmb.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Departamento:";
            // 
            // salario_text
            // 
            this.salario_text.Enabled = false;
            this.salario_text.Location = new System.Drawing.Point(103, 178);
            this.salario_text.Margin = new System.Windows.Forms.Padding(2);
            this.salario_text.Name = "salario_text";
            this.salario_text.Size = new System.Drawing.Size(412, 20);
            this.salario_text.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Salario base:";
            // 
            // descripcion_text
            // 
            this.descripcion_text.Enabled = false;
            this.descripcion_text.Location = new System.Drawing.Point(103, 133);
            this.descripcion_text.Margin = new System.Windows.Forms.Padding(2);
            this.descripcion_text.Name = "descripcion_text";
            this.descripcion_text.Size = new System.Drawing.Size(413, 20);
            this.descripcion_text.TabIndex = 35;
            // 
            // puesto_dgw
            // 
            this.puesto_dgw.AllowUserToAddRows = false;
            this.puesto_dgw.AllowUserToDeleteRows = false;
            this.puesto_dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.puesto_dgw.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.puesto_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.puesto_dgw.Location = new System.Drawing.Point(531, 113);
            this.puesto_dgw.Margin = new System.Windows.Forms.Padding(2);
            this.puesto_dgw.Name = "puesto_dgw";
            this.puesto_dgw.ReadOnly = true;
            this.puesto_dgw.RowTemplate.Height = 24;
            this.puesto_dgw.Size = new System.Drawing.Size(491, 167);
            this.puesto_dgw.TabIndex = 41;
            this.puesto_dgw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.puesto_dgw_CellContentClick);
            // 
            // requisitos_text
            // 
            this.requisitos_text.Enabled = false;
            this.requisitos_text.Location = new System.Drawing.Point(103, 155);
            this.requisitos_text.Margin = new System.Windows.Forms.Padding(2);
            this.requisitos_text.Name = "requisitos_text";
            this.requisitos_text.Size = new System.Drawing.Size(413, 20);
            this.requisitos_text.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Requisitos: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Descripción:";
            // 
            // sueldo_text
            // 
            this.sueldo_text.Enabled = false;
            this.sueldo_text.Location = new System.Drawing.Point(103, 110);
            this.sueldo_text.Margin = new System.Windows.Forms.Padding(2);
            this.sueldo_text.Name = "sueldo_text";
            this.sueldo_text.Size = new System.Drawing.Size(413, 20);
            this.sueldo_text.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Sueldo:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(290, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 38);
            this.button4.TabIndex = 30;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(209, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 29;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 38);
            this.button2.TabIndex = 28;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 38);
            this.button1.TabIndex = 27;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Software_Industrial.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(706, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 94);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // puestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Software_Industrial.Properties.Resources.Wallpapper____Blue;
            this.ClientSize = new System.Drawing.Size(1033, 291);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.departamento_cmb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.salario_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descripcion_text);
            this.Controls.Add(this.puesto_dgw);
            this.Controls.Add(this.requisitos_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sueldo_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "puestos";
            this.Text = "puestos";
            this.Load += new System.EventHandler(this.puestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.puesto_dgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox departamento_cmb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox salario_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descripcion_text;
        private System.Windows.Forms.DataGridView puesto_dgw;
        private System.Windows.Forms.TextBox requisitos_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sueldo_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}