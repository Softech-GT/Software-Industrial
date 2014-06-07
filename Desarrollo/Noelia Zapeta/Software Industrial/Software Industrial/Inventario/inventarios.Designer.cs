namespace Software_Industrial.Inventario
{
    partial class inventarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventarios));
            this.Button5 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button5
            // 
            this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.ForeColor = System.Drawing.Color.Maroon;
            this.Button5.Image = ((System.Drawing.Image)(resources.GetObject("Button5.Image")));
            this.Button5.Location = new System.Drawing.Point(294, 247);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(182, 138);
            this.Button5.TabIndex = 9;
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.Color.Maroon;
            this.Button2.Image = ((System.Drawing.Image)(resources.GetObject("Button2.Image")));
            this.Button2.Location = new System.Drawing.Point(475, 71);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(182, 138);
            this.Button2.TabIndex = 6;
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.Maroon;
            this.Button1.Image = ((System.Drawing.Image)(resources.GetObject("Button1.Image")));
            this.Button1.Location = new System.Drawing.Point(94, 71);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(182, 138);
            this.Button1.TabIndex = 5;
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(98, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingreso de productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(511, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Movimientos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Reportes ";
            // 
            // inventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(780, 443);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Name = "inventarios";
            this.Text = " Menu Inventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}