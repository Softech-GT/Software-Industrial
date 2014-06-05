namespace Software_Industrial
{
    partial class bitacora
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
            this.bitacora_dgw = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bitacora_dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // bitacora_dgw
            // 
            this.bitacora_dgw.AllowUserToAddRows = false;
            this.bitacora_dgw.AllowUserToDeleteRows = false;
            this.bitacora_dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bitacora_dgw.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bitacora_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bitacora_dgw.Location = new System.Drawing.Point(11, 50);
            this.bitacora_dgw.Margin = new System.Windows.Forms.Padding(2);
            this.bitacora_dgw.Name = "bitacora_dgw";
            this.bitacora_dgw.ReadOnly = true;
            this.bitacora_dgw.RowTemplate.Height = 24;
            this.bitacora_dgw.Size = new System.Drawing.Size(605, 201);
            this.bitacora_dgw.TabIndex = 51;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bitacora_dgw);
            this.Name = "bitacora";
            this.Text = "Bitacora";
            this.Load += new System.EventHandler(this.bitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bitacora_dgw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bitacora_dgw;
        private System.Windows.Forms.Button button1;
    }
}