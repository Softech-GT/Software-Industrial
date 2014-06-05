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
            this.Button5 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(348, 222);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(120, 41);
            this.Button5.TabIndex = 9;
            this.Button5.Text = "reportes ";
            this.Button5.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(508, 102);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(120, 40);
            this.Button2.TabIndex = 6;
            this.Button2.Text = "Movimientos ";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(148, 102);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(126, 40);
            this.Button1.TabIndex = 5;
            this.Button1.Text = "Registro de productos";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // inventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 443);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Name = "inventarios";
            this.Text = " Menu Inventario";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
    }
}