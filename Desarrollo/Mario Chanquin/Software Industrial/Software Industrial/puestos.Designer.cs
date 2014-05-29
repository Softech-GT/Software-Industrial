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
            this.barra1 = new Navegador.Barra();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.puesto_dgw)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // departamento_cmb
            // 
            this.departamento_cmb.Enabled = false;
            this.departamento_cmb.FormattingEnabled = true;
            this.departamento_cmb.Location = new System.Drawing.Point(90, 118);
            this.departamento_cmb.Margin = new System.Windows.Forms.Padding(2);
            this.departamento_cmb.Name = "departamento_cmb";
            this.departamento_cmb.Size = new System.Drawing.Size(363, 21);
            this.departamento_cmb.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(9, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Departamento:";
            // 
            // salario_text
            // 
            this.salario_text.Enabled = false;
            this.salario_text.Location = new System.Drawing.Point(90, 84);
            this.salario_text.Margin = new System.Windows.Forms.Padding(2);
            this.salario_text.Name = "salario_text";
            this.salario_text.Size = new System.Drawing.Size(362, 20);
            this.salario_text.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Salario base:";
            // 
            // descripcion_text
            // 
            this.descripcion_text.Enabled = false;
            this.descripcion_text.Location = new System.Drawing.Point(89, 50);
            this.descripcion_text.Margin = new System.Windows.Forms.Padding(2);
            this.descripcion_text.Name = "descripcion_text";
            this.descripcion_text.Size = new System.Drawing.Size(363, 20);
            this.descripcion_text.TabIndex = 35;
            // 
            // puesto_dgw
            // 
            this.puesto_dgw.AllowUserToAddRows = false;
            this.puesto_dgw.AllowUserToDeleteRows = false;
            this.puesto_dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.puesto_dgw.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.puesto_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.puesto_dgw.Location = new System.Drawing.Point(25, 47);
            this.puesto_dgw.Margin = new System.Windows.Forms.Padding(2);
            this.puesto_dgw.Name = "puesto_dgw";
            this.puesto_dgw.ReadOnly = true;
            this.puesto_dgw.RowTemplate.Height = 24;
            this.puesto_dgw.Size = new System.Drawing.Size(420, 142);
            this.puesto_dgw.TabIndex = 41;
            this.puesto_dgw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.puesto_dgw_CellContentClick);
            this.puesto_dgw.SelectionChanged += new System.EventHandler(this.puesto_dgw_SelectionChanged);
            // 
            // requisitos_text
            // 
            this.requisitos_text.Enabled = false;
            this.requisitos_text.Location = new System.Drawing.Point(715, 103);
            this.requisitos_text.Margin = new System.Windows.Forms.Padding(2);
            this.requisitos_text.Name = "requisitos_text";
            this.requisitos_text.Size = new System.Drawing.Size(108, 20);
            this.requisitos_text.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(712, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Requisitos: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Descripción:";
            // 
            // sueldo_text
            // 
            this.sueldo_text.Enabled = false;
            this.sueldo_text.Location = new System.Drawing.Point(715, 58);
            this.sueldo_text.Margin = new System.Windows.Forms.Padding(2);
            this.sueldo_text.Name = "sueldo_text";
            this.sueldo_text.Size = new System.Drawing.Size(108, 20);
            this.sueldo_text.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(712, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Sueldo:";
            // 
            // barra1
            // 
            this.barra1.BackColor = System.Drawing.Color.Transparent;
            this.barra1.Location = new System.Drawing.Point(124, 11);
            this.barra1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(268, 42);
            this.barra1.TabIndex = 45;
            this.barra1.click_nuevo_button += new Navegador.Barra.delegadoButton(this.barra1_click_nuevo_button);
            this.barra1.click_guardar_button += new Navegador.Barra.delegadoButton(this.barra1_click_guardar_button);
            this.barra1.click_editar_button += new Navegador.Barra.delegadoButton(this.barra1_click_editar_button);
            this.barra1.click_eliminar_button += new Navegador.Barra.delegadoButton(this.barra1_click_eliminar_button);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(26, 81);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(476, 220);
            this.tabControl1.TabIndex = 46;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.departamento_cmb);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.descripcion_text);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.salario_text);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(468, 194);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingreso de datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.puesto_dgw);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(468, 194);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // puestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 328);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.barra1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sueldo_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.requisitos_text);
            this.Name = "puestos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "puestos";
            this.Load += new System.EventHandler(this.puestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.puesto_dgw)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
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
        private Navegador.Barra barra1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}