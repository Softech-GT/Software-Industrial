namespace Software_Industrial
{
    partial class ausencias
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
            this.tb_tcant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_tiempo = new System.Windows.Forms.TextBox();
            this.tb_descripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dg_ausencia = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ausencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_tcant
            // 
            this.tb_tcant.Enabled = false;
            this.tb_tcant.Location = new System.Drawing.Point(123, 149);
            this.tb_tcant.Margin = new System.Windows.Forms.Padding(2);
            this.tb_tcant.Name = "tb_tcant";
            this.tb_tcant.Size = new System.Drawing.Size(412, 20);
            this.tb_tcant.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 73;
            this.label4.Text = "Salario base:";
            // 
            // tb_tiempo
            // 
            this.tb_tiempo.Enabled = false;
            this.tb_tiempo.Location = new System.Drawing.Point(123, 124);
            this.tb_tiempo.Margin = new System.Windows.Forms.Padding(2);
            this.tb_tiempo.Name = "tb_tiempo";
            this.tb_tiempo.Size = new System.Drawing.Size(413, 20);
            this.tb_tiempo.TabIndex = 72;
            // 
            // tb_descripcion
            // 
            this.tb_descripcion.Enabled = false;
            this.tb_descripcion.Location = new System.Drawing.Point(123, 96);
            this.tb_descripcion.Margin = new System.Windows.Forms.Padding(2);
            this.tb_descripcion.Name = "tb_descripcion";
            this.tb_descripcion.Size = new System.Drawing.Size(413, 20);
            this.tb_descripcion.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 71;
            this.label3.Text = "Requisitos: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 70;
            this.label2.Text = "Descripción:";
            // 
            // dg_ausencia
            // 
            this.dg_ausencia.AllowUserToAddRows = false;
            this.dg_ausencia.AllowUserToDeleteRows = false;
            this.dg_ausencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_ausencia.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dg_ausencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ausencia.Location = new System.Drawing.Point(35, 184);
            this.dg_ausencia.Margin = new System.Windows.Forms.Padding(2);
            this.dg_ausencia.Name = "dg_ausencia";
            this.dg_ausencia.ReadOnly = true;
            this.dg_ausencia.RowTemplate.Height = 24;
            this.dg_ausencia.Size = new System.Drawing.Size(782, 118);
            this.dg_ausencia.TabIndex = 77;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(291, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 38);
            this.button4.TabIndex = 81;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(210, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 80;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 38);
            this.button2.TabIndex = 79;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 38);
            this.button1.TabIndex = 78;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Software_Industrial.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(562, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 94);
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // ausencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Software_Industrial.Properties.Resources.Wallpapper____Blue;
            this.ClientSize = new System.Drawing.Size(878, 326);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dg_ausencia);
            this.Controls.Add(this.tb_tcant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_tiempo);
            this.Controls.Add(this.tb_descripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ausencias";
            this.Text = "ausencias";
            this.Load += new System.EventHandler(this.ausencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_ausencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_tcant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_tiempo;
        private System.Windows.Forms.TextBox tb_descripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg_ausencia;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}