namespace pryGarcia
{
    partial class FrmEmpleados
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBarrio = new System.Windows.Forms.TabPage();
            this.tabApellido = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBuscarApellido = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar1 = new System.Windows.Forms.Button();
            this.btnCancelar2 = new System.Windows.Forms.Button();
            this.txtBuscarApellido = new System.Windows.Forms.TextBox();
            this.dgvGrilla1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabBarrio.SuspendLayout();
            this.tabApellido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBarrio);
            this.tabControl1.Controls.Add(this.tabApellido);
            this.tabControl1.Location = new System.Drawing.Point(29, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(323, 189);
            this.tabControl1.TabIndex = 0;
            // 
            // tabBarrio
            // 
            this.tabBarrio.Controls.Add(this.btnCancelar);
            this.tabBarrio.Controls.Add(this.btnBuscar);
            this.tabBarrio.Controls.Add(this.txt1);
            this.tabBarrio.Controls.Add(this.label1);
            this.tabBarrio.Location = new System.Drawing.Point(4, 29);
            this.tabBarrio.Name = "tabBarrio";
            this.tabBarrio.Padding = new System.Windows.Forms.Padding(3);
            this.tabBarrio.Size = new System.Drawing.Size(315, 156);
            this.tabBarrio.TabIndex = 0;
            this.tabBarrio.Text = "Barrio";
            this.tabBarrio.UseVisualStyleBackColor = true;
            // 
            // tabApellido
            // 
            this.tabApellido.Controls.Add(this.txtBuscarApellido);
            this.tabApellido.Controls.Add(this.btnCancelar2);
            this.tabApellido.Controls.Add(this.btnBuscar1);
            this.tabApellido.Controls.Add(this.lblBuscarApellido);
            this.tabApellido.Location = new System.Drawing.Point(4, 29);
            this.tabApellido.Name = "tabApellido";
            this.tabApellido.Padding = new System.Windows.Forms.Padding(3);
            this.tabApellido.Size = new System.Drawing.Size(315, 156);
            this.tabApellido.TabIndex = 1;
            this.tabApellido.Text = "Apellido";
            this.tabApellido.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barrio:";
            // 
            // lblBuscarApellido
            // 
            this.lblBuscarApellido.AutoSize = true;
            this.lblBuscarApellido.Location = new System.Drawing.Point(19, 34);
            this.lblBuscarApellido.Name = "lblBuscarApellido";
            this.lblBuscarApellido.Size = new System.Drawing.Size(69, 20);
            this.lblBuscarApellido.TabIndex = 0;
            this.lblBuscarApellido.Text = "Apellido:";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(104, 28);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(146, 26);
            this.txt1.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(79, 78);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(175, 78);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 30);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscar1
            // 
            this.btnBuscar1.Location = new System.Drawing.Point(91, 80);
            this.btnBuscar1.Name = "btnBuscar1";
            this.btnBuscar1.Size = new System.Drawing.Size(75, 33);
            this.btnBuscar1.TabIndex = 1;
            this.btnBuscar1.Text = "Buscar";
            this.btnBuscar1.UseVisualStyleBackColor = true;
            this.btnBuscar1.Click += new System.EventHandler(this.btnBuscar1_Click);
            // 
            // btnCancelar2
            // 
            this.btnCancelar2.Location = new System.Drawing.Point(188, 80);
            this.btnCancelar2.Name = "btnCancelar2";
            this.btnCancelar2.Size = new System.Drawing.Size(80, 33);
            this.btnCancelar2.TabIndex = 2;
            this.btnCancelar2.Text = "Cancelar";
            this.btnCancelar2.UseVisualStyleBackColor = true;
            this.btnCancelar2.Click += new System.EventHandler(this.btnCancelar2_Click);
            // 
            // txtBuscarApellido
            // 
            this.txtBuscarApellido.Location = new System.Drawing.Point(99, 34);
            this.txtBuscarApellido.Name = "txtBuscarApellido";
            this.txtBuscarApellido.Size = new System.Drawing.Size(164, 26);
            this.txtBuscarApellido.TabIndex = 3;
            // 
            // dgvGrilla1
            // 
            this.dgvGrilla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla1.Location = new System.Drawing.Point(33, 253);
            this.dgvGrilla1.Name = "dgvGrilla1";
            this.dgvGrilla1.RowHeadersWidth = 62;
            this.dgvGrilla1.RowTemplate.Height = 28;
            this.dgvGrilla1.Size = new System.Drawing.Size(315, 248);
            this.dgvGrilla1.TabIndex = 1;
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 585);
            this.Controls.Add(this.dgvGrilla1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmEmpleados";
            this.Text = "Listado de empleados";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabBarrio.ResumeLayout(false);
            this.tabBarrio.PerformLayout();
            this.tabApellido.ResumeLayout(false);
            this.tabApellido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBarrio;
        private System.Windows.Forms.TabPage tabApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txtBuscarApellido;
        private System.Windows.Forms.Button btnCancelar2;
        private System.Windows.Forms.Button btnBuscar1;
        private System.Windows.Forms.Label lblBuscarApellido;
        private System.Windows.Forms.DataGridView dgvGrilla1;
    }
}