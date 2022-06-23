namespace simulacroPAV
{
    partial class Form3
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
            this.grdMaterias_x_Alumno = new System.Windows.Forms.DataGridView();
            this.codigo_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbMaterias = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterias_x_Alumno)).BeginInit();
            this.SuspendLayout();
            // 
            // grdMaterias_x_Alumno
            // 
            this.grdMaterias_x_Alumno.AllowUserToAddRows = false;
            this.grdMaterias_x_Alumno.AllowUserToDeleteRows = false;
            this.grdMaterias_x_Alumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMaterias_x_Alumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_materia,
            this.nombre_materia});
            this.grdMaterias_x_Alumno.Location = new System.Drawing.Point(37, 116);
            this.grdMaterias_x_Alumno.Name = "grdMaterias_x_Alumno";
            this.grdMaterias_x_Alumno.ReadOnly = true;
            this.grdMaterias_x_Alumno.RowHeadersWidth = 51;
            this.grdMaterias_x_Alumno.RowTemplate.Height = 24;
            this.grdMaterias_x_Alumno.Size = new System.Drawing.Size(418, 194);
            this.grdMaterias_x_Alumno.TabIndex = 20;
            // 
            // codigo_materia
            // 
            this.codigo_materia.DataPropertyName = "Código Materia";
            this.codigo_materia.HeaderText = "Código Materia";
            this.codigo_materia.MinimumWidth = 6;
            this.codigo_materia.Name = "codigo_materia";
            this.codigo_materia.ReadOnly = true;
            this.codigo_materia.Width = 60;
            // 
            // nombre_materia
            // 
            this.nombre_materia.DataPropertyName = "Nombre Materia";
            this.nombre_materia.HeaderText = "Nombre Materia";
            this.nombre_materia.MinimumWidth = 6;
            this.nombre_materia.Name = "nombre_materia";
            this.nombre_materia.ReadOnly = true;
            this.nombre_materia.Width = 200;
            // 
            // cmbMaterias
            // 
            this.cmbMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterias.FormattingEnabled = true;
            this.cmbMaterias.Location = new System.Drawing.Point(112, 68);
            this.cmbMaterias.Name = "cmbMaterias";
            this.cmbMaterias.Size = new System.Drawing.Size(343, 24);
            this.cmbMaterias.TabIndex = 19;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(342, 25);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtLegajo
            // 
            this.txtLegajo.Enabled = false;
            this.txtLegajo.Location = new System.Drawing.Point(112, 26);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(214, 22);
            this.txtLegajo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Materias";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Legajo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(342, 331);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(113, 23);
            this.btnAceptar.TabIndex = 21;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 378);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grdMaterias_x_Alumno);
            this.Controls.Add(this.cmbMaterias);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterias_x_Alumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdMaterias_x_Alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_materia;
        private System.Windows.Forms.ComboBox cmbMaterias;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
    }
}