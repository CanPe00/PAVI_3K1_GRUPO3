namespace BugTracker.GUILayer.Reportes
{
    partial class ReporteCursosPorUsuario
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
            this.cursosPorUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new BugTracker.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cursosPorUsuarioTableAdapter = new BugTracker.DataSet1TableAdapters.CursosPorUsuarioTableAdapter();
            this.lblFecha_desde = new System.Windows.Forms.Label();
            this.lblFecha_hasta = new System.Windows.Forms.Label();
            this.dtpFecha_Desde = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha_Hasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cursosPorUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // cursosPorUsuarioBindingSource
            // 
            this.cursosPorUsuarioBindingSource.DataMember = "CursosPorUsuario";
            this.cursosPorUsuarioBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.cursosPorUsuarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BugTracker.ReporteCursosPorUsuario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 84);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(616, 356);
            this.reportViewer1.TabIndex = 0;
            // 
            // cursosPorUsuarioTableAdapter
            // 
            this.cursosPorUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // lblFecha_desde
            // 
            this.lblFecha_desde.AutoSize = true;
            this.lblFecha_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha_desde.Location = new System.Drawing.Point(22, 18);
            this.lblFecha_desde.Name = "lblFecha_desde";
            this.lblFecha_desde.Size = new System.Drawing.Size(91, 16);
            this.lblFecha_desde.TabIndex = 1;
            this.lblFecha_desde.Text = "Fecha desde:";
            // 
            // lblFecha_hasta
            // 
            this.lblFecha_hasta.AutoSize = true;
            this.lblFecha_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha_hasta.Location = new System.Drawing.Point(385, 18);
            this.lblFecha_hasta.Name = "lblFecha_hasta";
            this.lblFecha_hasta.Size = new System.Drawing.Size(85, 16);
            this.lblFecha_hasta.TabIndex = 2;
            this.lblFecha_hasta.Text = "Fecha hasta:";
            // 
            // dtpFecha_Desde
            // 
            this.dtpFecha_Desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_Desde.Location = new System.Drawing.Point(112, 17);
            this.dtpFecha_Desde.Name = "dtpFecha_Desde";
            this.dtpFecha_Desde.Size = new System.Drawing.Size(103, 20);
            this.dtpFecha_Desde.TabIndex = 3;
            // 
            // dtpFecha_Hasta
            // 
            this.dtpFecha_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_Hasta.Location = new System.Drawing.Point(476, 18);
            this.dtpFecha_Hasta.Name = "dtpFecha_Hasta";
            this.dtpFecha_Hasta.Size = new System.Drawing.Size(103, 20);
            this.dtpFecha_Hasta.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(223, 47);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(158, 31);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Generar reporte";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ReporteCursosPorUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(616, 389);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpFecha_Hasta);
            this.Controls.Add(this.dtpFecha_Desde);
            this.Controls.Add(this.lblFecha_hasta);
            this.Controls.Add(this.lblFecha_desde);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteCursosPorUsuario";
            this.Text = "ReporteCursosPorUsuario";
            this.Load += new System.EventHandler(this.ReporteCursosPorUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cursosPorUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource cursosPorUsuarioBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.CursosPorUsuarioTableAdapter cursosPorUsuarioTableAdapter;
        private System.Windows.Forms.Label lblFecha_desde;
        private System.Windows.Forms.Label lblFecha_hasta;
        private System.Windows.Forms.DateTimePicker dtpFecha_Desde;
        private System.Windows.Forms.DateTimePicker dtpFecha_Hasta;
        private System.Windows.Forms.Button btnBuscar;
    }
}