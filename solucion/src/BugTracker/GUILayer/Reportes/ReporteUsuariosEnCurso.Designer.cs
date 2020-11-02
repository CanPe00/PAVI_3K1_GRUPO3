namespace BugTracker.GUILayer.Reportes
{
    partial class ReporteUsuariosEnCurso
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.usuariosEnCursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new BugTracker.DataSet1();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpFecha_Hasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha_Desde = new System.Windows.Forms.DateTimePicker();
            this.lblFecha_hasta = new System.Windows.Forms.Label();
            this.lblFecha_desde = new System.Windows.Forms.Label();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosEnCursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usuariosEnCursoBindingSource
            // 
            this.usuariosEnCursoBindingSource.DataMember = "UsuariosEnCurso";
            this.usuariosEnCursoBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.dataSet1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.usuariosEnCursoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BugTracker.UsuariosEnCurso.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 105);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(616, 336);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(224, 54);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(151, 36);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Generar reporte";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpFecha_Hasta
            // 
            this.dtpFecha_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_Hasta.Location = new System.Drawing.Point(462, 19);
            this.dtpFecha_Hasta.Name = "dtpFecha_Hasta";
            this.dtpFecha_Hasta.Size = new System.Drawing.Size(103, 20);
            this.dtpFecha_Hasta.TabIndex = 9;
            // 
            // dtpFecha_Desde
            // 
            this.dtpFecha_Desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_Desde.Location = new System.Drawing.Point(114, 19);
            this.dtpFecha_Desde.Name = "dtpFecha_Desde";
            this.dtpFecha_Desde.Size = new System.Drawing.Size(103, 20);
            this.dtpFecha_Desde.TabIndex = 8;
            // 
            // lblFecha_hasta
            // 
            this.lblFecha_hasta.AutoSize = true;
            this.lblFecha_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha_hasta.Location = new System.Drawing.Point(371, 23);
            this.lblFecha_hasta.Name = "lblFecha_hasta";
            this.lblFecha_hasta.Size = new System.Drawing.Size(85, 16);
            this.lblFecha_hasta.TabIndex = 7;
            this.lblFecha_hasta.Text = "Fecha hasta:";
            this.lblFecha_hasta.Click += new System.EventHandler(this.lblFecha_hasta_Click);
            // 
            // lblFecha_desde
            // 
            this.lblFecha_desde.AutoSize = true;
            this.lblFecha_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha_desde.Location = new System.Drawing.Point(24, 23);
            this.lblFecha_desde.Name = "lblFecha_desde";
            this.lblFecha_desde.Size = new System.Drawing.Size(91, 16);
            this.lblFecha_desde.TabIndex = 6;
            this.lblFecha_desde.Text = "Fecha desde:";
            // 
            // chkTodos
            // 
            this.chkTodos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkTodos.AutoSize = true;
            this.chkTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTodos.Location = new System.Drawing.Point(498, 54);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(67, 21);
            this.chkTodos.TabIndex = 31;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // ReporteUsuariosEnCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(616, 389);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpFecha_Hasta);
            this.Controls.Add(this.dtpFecha_Desde);
            this.Controls.Add(this.lblFecha_hasta);
            this.Controls.Add(this.lblFecha_desde);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReporteUsuariosEnCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteUsuariosEnCurso";
            this.Load += new System.EventHandler(this.ReporteUsuariosEnCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosEnCursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private DataSet1TableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.BindingSource usuariosEnCursoBindingSource;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpFecha_Hasta;
        private System.Windows.Forms.DateTimePicker dtpFecha_Desde;
        private System.Windows.Forms.Label lblFecha_hasta;
        private System.Windows.Forms.Label lblFecha_desde;
        public System.Windows.Forms.CheckBox chkTodos;
    }
}