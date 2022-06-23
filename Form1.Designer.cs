namespace simulacroPAV
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbMaterias = new System.Windows.Forms.ComboBox();
            this.grdMaterias_x_Alumno = new System.Windows.Forms.DataGridView();
            this.codigo_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnTransaccion = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterias_x_Alumno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Legajo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Materias";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(101, 47);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(214, 22);
            this.txtLegajo.TabIndex = 1;
            this.txtLegajo.Text = "85920";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(101, 85);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(343, 22);
            this.txtApellido.TabIndex = 3;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(101, 123);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(343, 22);
            this.txtNombres.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(331, 46);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(113, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbMaterias
            // 
            this.cmbMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterias.FormattingEnabled = true;
            this.cmbMaterias.Location = new System.Drawing.Point(101, 155);
            this.cmbMaterias.Name = "cmbMaterias";
            this.cmbMaterias.Size = new System.Drawing.Size(343, 24);
            this.cmbMaterias.TabIndex = 5;
            // 
            // grdMaterias_x_Alumno
            // 
            this.grdMaterias_x_Alumno.AllowUserToAddRows = false;
            this.grdMaterias_x_Alumno.AllowUserToDeleteRows = false;
            this.grdMaterias_x_Alumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMaterias_x_Alumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_materia,
            this.nombre_materia});
            this.grdMaterias_x_Alumno.Location = new System.Drawing.Point(26, 203);
            this.grdMaterias_x_Alumno.Name = "grdMaterias_x_Alumno";
            this.grdMaterias_x_Alumno.ReadOnly = true;
            this.grdMaterias_x_Alumno.RowHeadersWidth = 51;
            this.grdMaterias_x_Alumno.RowTemplate.Height = 24;
            this.grdMaterias_x_Alumno.Size = new System.Drawing.Size(418, 194);
            this.grdMaterias_x_Alumno.TabIndex = 10;
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
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(331, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(113, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(26, 415);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(113, 23);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(145, 415);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(113, 23);
            this.btnGrabar.TabIndex = 6;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnTransaccion
            // 
            this.btnTransaccion.Location = new System.Drawing.Point(202, 12);
            this.btnTransaccion.Name = "btnTransaccion";
            this.btnTransaccion.Size = new System.Drawing.Size(113, 23);
            this.btnTransaccion.TabIndex = 11;
            this.btnTransaccion.Text = "Transaccion";
            this.btnTransaccion.UseVisualStyleBackColor = true;
            this.btnTransaccion.Click += new System.EventHandler(this.btnTransaccion_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(331, 12);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(113, 23);
            this.btnReporte.TabIndex = 12;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 450);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnTransaccion);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grdMaterias_x_Alumno);
            this.Controls.Add(this.cmbMaterias);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALTA DE MATERIAS POR ALUMNO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterias_x_Alumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbMaterias;
        private System.Windows.Forms.DataGridView grdMaterias_x_Alumno;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_materia;
        private System.Windows.Forms.Button btnTransaccion;
        private System.Windows.Forms.Button btnReporte;
    }
}

