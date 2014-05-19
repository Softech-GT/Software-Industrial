namespace Software_Industrial
{
    partial class departamentos
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.descripcion_text = new System.Windows.Forms.TextBox();
            this.depto_dgw = new System.Windows.Forms.DataGridView();
            this.funcion_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.depto_dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(197, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(278, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 38);
            this.button4.TabIndex = 3;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // descripcion_text
            // 
            this.descripcion_text.Enabled = false;
            this.descripcion_text.Location = new System.Drawing.Point(17, 144);
            this.descripcion_text.Margin = new System.Windows.Forms.Padding(2);
            this.descripcion_text.Name = "descripcion_text";
            this.descripcion_text.Size = new System.Drawing.Size(495, 20);
            this.descripcion_text.TabIndex = 10;
            // 
            // depto_dgw
            // 
            this.depto_dgw.AllowUserToAddRows = false;
            this.depto_dgw.AllowUserToDeleteRows = false;
            this.depto_dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.depto_dgw.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.depto_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depto_dgw.Location = new System.Drawing.Point(20, 199);
            this.depto_dgw.Margin = new System.Windows.Forms.Padding(2);
            this.depto_dgw.Name = "depto_dgw";
            this.depto_dgw.ReadOnly = true;
            this.depto_dgw.RowTemplate.Height = 24;
            this.depto_dgw.Size = new System.Drawing.Size(491, 297);
            this.depto_dgw.TabIndex = 14;
            // 
            // funcion_text
            // 
            this.funcion_text.Enabled = false;
            this.funcion_text.Location = new System.Drawing.Point(70, 176);
            this.funcion_text.Margin = new System.Windows.Forms.Padding(2);
            this.funcion_text.Name = "funcion_text";
            this.funcion_text.Size = new System.Drawing.Size(443, 20);
            this.funcion_text.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Función:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Descripción:";
            // 
            // nombre_text
            // 
            this.nombre_text.Enabled = false;
            this.nombre_text.Location = new System.Drawing.Point(70, 101);
            this.nombre_text.Margin = new System.Windows.Forms.Padding(2);
            this.nombre_text.Name = "nombre_text";
            this.nombre_text.Size = new System.Drawing.Size(443, 20);
            this.nombre_text.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre:";
            // 
            // departamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Software_Industrial.Properties.Resources.Wallpapper____Blue;
            this.ClientSize = new System.Drawing.Size(538, 379);
            this.Controls.Add(this.descripcion_text);
            this.Controls.Add(this.depto_dgw);
            this.Controls.Add(this.funcion_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "departamentos";
            this.Text = "departamentos";
            this.Load += new System.EventHandler(this.departamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.depto_dgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox descripcion_text;
        private System.Windows.Forms.DataGridView depto_dgw;
        private System.Windows.Forms.TextBox funcion_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre_text;
        private System.Windows.Forms.Label label1;
    }
}