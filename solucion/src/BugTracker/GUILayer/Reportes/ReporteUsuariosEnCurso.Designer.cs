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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.usuariosEnCursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new BugTracker.DataSet1();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usuariosTableAdapter = new BugTracker.DataSet1TableAdapters.UsuariosTableAdapter();
            this.usuariosEnCursoTableAdapter = new BugTracker.DataSet1TableAdapters.UsuariosEnCursoTableAdapter();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpFecha_Hasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha_Desde = new System.Windows.Forms.DateTimePicker();
            this.lblFecha_hasta = new System.Windows.Forms.Label();
            this.lblFecha_desde = new System.Windows.Forms.Label();
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
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.usuariosEnCursoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BugTracker.UsuariosEnCurso.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 49);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(664, 338);
            this.reportViewer1.TabIndex = 0;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosEnCursoTableAdapter
            // 
            this.usuariosEnCursoTableAdapter.ClearBeforeFill = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::BugTracker.Properties.Resources.BUSCAR01;
            this.btnBuscar.Location = new System.Drawing.Point(579, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(41, 41);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpFecha_Hasta
            // 
            this.dtpFecha_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_Hasta.Location = new System.Drawing.Point(422, 16);
            this.dtpFecha_Hasta.Name = "dtpFecha_Hasta";
            this.dtpFecha_Hasta.Size = new System.Drawing.Size(103, 20);
            this.dtpFecha_Hasta.TabIndex = 9;
            // 
            // dtpFecha_Desde
            // 
            this.dtpFecha_Desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_Desde.Location = new System.Drawing.Point(107, 15);
            this.dtpFecha_Desde.Name = "dtpFecha_Desde";
            this.dtpFecha_Desde.Size = new System.Drawing.Size(103, 20);
            this.dtpFecha_Desde.TabIndex = 8;
            // 
            // lblFecha_hasta
            // 
            this.lblFecha_hasta.AutoSize = true;
            this.lblFecha_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha_hasta.Location = new System.Drawing.Point(335, 16);
            this.lblFecha_hasta.Name = "lblFecha_hasta";
            this.lblFecha_hasta.Size = new System.Drawing.Size(81, 13);
            this.lblFecha_hasta.TabIndex = 7;
            this.lblFecha_hasta.Text = "Fecha hasta:";
            // 
            // lblFecha_desde
            // 
            this.lblFecha_desde.AutoSize = true;
            this.lblFecha_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha_desde.Location = new System.Drawing.Point(17, 16);
            this.lblFecha_desde.Name = "lblFecha_desde";
            this.lblFecha_desde.Size = new System.Drawing.Size(84, 13);
            this.lblFecha_desde.TabIndex = 6;
            this.lblFecha_desde.Text = "Fecha desde:";
            // 
            // ReporteUsuariosEnCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 337);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpFecha_Hasta);
            this.Controls.Add(this.dtpFecha_Desde);
            this.Controls.Add(this.lblFecha_hasta);
            this.Controls.Add(this.lblFecha_desde);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteUsuariosEnCurso";
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
        private DataSet1TableAdapters.UsuariosEnCursoTableAdapter usuariosEnCursoTableAdapter;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpFecha_Hasta;
        private System.Windows.Forms.DateTimePicker dtpFecha_Desde;
        private System.Windows.Forms.Label lblFecha_hasta;
        private System.Windows.Forms.Label lblFecha_desde;
    }
}