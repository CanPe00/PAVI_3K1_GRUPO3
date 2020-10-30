namespace BugTracker.GUILayer.Reportes
{
    partial class AvanceCursoUsuario
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
            this.avanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new BugTracker.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFecha_hasta = new System.Windows.Forms.Label();
            this.lblFecha_desde = new System.Windows.Forms.Label();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.avanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // avanceBindingSource
            // 
            this.avanceBindingSource.DataMember = "Avance";
            this.avanceBindingSource.DataSource = this.dataSet1;
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
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.avanceBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BugTracker.Avance.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 79);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(742, 371);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(579, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(151, 36);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Generar reporte";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(418, 20);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(131, 20);
            this.dtpFechaHasta.TabIndex = 14;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(155, 20);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(131, 20);
            this.dtpFechaDesde.TabIndex = 13;
            // 
            // lblFecha_hasta
            // 
            this.lblFecha_hasta.AutoSize = true;
            this.lblFecha_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha_hasta.Location = new System.Drawing.Point(306, 24);
            this.lblFecha_hasta.Name = "lblFecha_hasta";
            this.lblFecha_hasta.Size = new System.Drawing.Size(85, 16);
            this.lblFecha_hasta.TabIndex = 12;
            this.lblFecha_hasta.Text = "Fecha hasta:";
            // 
            // lblFecha_desde
            // 
            this.lblFecha_desde.AutoSize = true;
            this.lblFecha_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha_desde.Location = new System.Drawing.Point(43, 24);
            this.lblFecha_desde.Name = "lblFecha_desde";
            this.lblFecha_desde.Size = new System.Drawing.Size(91, 16);
            this.lblFecha_desde.TabIndex = 11;
            this.lblFecha_desde.Text = "Fecha desde:";
            // 
            // chkTodos
            // 
            this.chkTodos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkTodos.AutoSize = true;
            this.chkTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTodos.Location = new System.Drawing.Point(616, 53);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(67, 21);
            this.chkTodos.TabIndex = 29;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // AvanceCursoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.lblFecha_hasta);
            this.Controls.Add(this.lblFecha_desde);
            this.Controls.Add(this.reportViewer1);
            this.Name = "AvanceCursoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Avance Usuario";
            this.Load += new System.EventHandler(this.AvanceCursoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource avanceBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.AvanceTableAdapter avanceTableAdapter;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFecha_hasta;
        private System.Windows.Forms.Label lblFecha_desde;
        public System.Windows.Forms.CheckBox chkTodos;
    }
}