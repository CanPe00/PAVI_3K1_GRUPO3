namespace BugTracker.GUILayer.NewFolder1
{
    partial class EstadisticoCantUsuariosCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstadisticoCantUsuariosCursos));
            this.estadisticoUsuariosCursosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new BugTracker.DataSet1();
            this.EstadisticoPerfilesEnCursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadisticoUsuariosCursosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.estadisticoUsuariosCursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.estadisticoUsuariosCursosTableAdapter = new BugTracker.DataSet1TableAdapters.EstadisticoUsuariosCursosTableAdapter();
            this.graficoCursosTerminadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.graficoCursosTerminadosTableAdapter = new BugTracker.DataSet1TableAdapters.GraficoCursosTerminadosTableAdapter();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticoUsuariosCursosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstadisticoPerfilesEnCursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticoUsuariosCursosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticoUsuariosCursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoCursosTerminadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // estadisticoUsuariosCursosBindingSource2
            // 
            this.estadisticoUsuariosCursosBindingSource2.DataMember = "EstadisticoUsuariosCursos";
            this.estadisticoUsuariosCursosBindingSource2.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EstadisticoPerfilesEnCursosBindingSource
            // 
            this.EstadisticoPerfilesEnCursosBindingSource.DataMember = "EstadisticoPerfilesEnCursos";
            this.EstadisticoPerfilesEnCursosBindingSource.DataSource = this.dataSet1;
            // 
            // estadisticoUsuariosCursosBindingSource1
            // 
            this.estadisticoUsuariosCursosBindingSource1.DataMember = "EstadisticoUsuariosCursos";
            this.estadisticoUsuariosCursosBindingSource1.DataSource = this.dataSet1;
            // 
            // estadisticoUsuariosCursosBindingSource
            // 
            this.estadisticoUsuariosCursosBindingSource.DataMember = "EstadisticoUsuariosCursos";
            this.estadisticoUsuariosCursosBindingSource.DataSource = this.dataSet1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(588, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha Hasta:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha Desde:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(780, 62);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(260, 36);
            this.dtpFechaHasta.TabIndex = 6;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(266, 62);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(260, 36);
            this.dtpFechaDesde.TabIndex = 5;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.estadisticoUsuariosCursosBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BugTracker.CantUsuarios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(24, 185);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1250, 610);
            this.reportViewer1.TabIndex = 17;
            // 
            // estadisticoUsuariosCursosTableAdapter
            // 
            this.estadisticoUsuariosCursosTableAdapter.ClearBeforeFill = true;
            // 
            // graficoCursosTerminadosBindingSource
            // 
            this.graficoCursosTerminadosBindingSource.DataMember = "GraficoCursosTerminados";
            this.graficoCursosTerminadosBindingSource.DataSource = this.dataSet1;
            // 
            // graficoCursosTerminadosTableAdapter
            // 
            this.graficoCursosTerminadosTableAdapter.ClearBeforeFill = true;
            // 
            // btnGrafico
            // 
            this.btnGrafico.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGrafico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.btnGrafico.FlatAppearance.BorderSize = 0;
            this.btnGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrafico.Image = ((System.Drawing.Image)(resources.GetObject("btnGrafico.Image")));
            this.btnGrafico.Location = new System.Drawing.Point(1156, 52);
            this.btnGrafico.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(92, 71);
            this.btnGrafico.TabIndex = 16;
            this.btnGrafico.UseVisualStyleBackColor = false;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // chkTodos
            // 
            this.chkTodos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkTodos.AutoSize = true;
            this.chkTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTodos.Location = new System.Drawing.Point(918, 120);
            this.chkTodos.Margin = new System.Windows.Forms.Padding(6);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(122, 35);
            this.chkTodos.TabIndex = 18;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            // 
            // EstadisticoCantUsuariosCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1300, 819);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "EstadisticoCantUsuariosCursos";
            this.Text = "EstadisticoCantUsuariosCursos";
            this.Load += new System.EventHandler(this.EstadisticoCantUsuariosCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estadisticoUsuariosCursosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstadisticoPerfilesEnCursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticoUsuariosCursosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticoUsuariosCursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoCursosTerminadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Button btnGrafico;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource estadisticoUsuariosCursosBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.EstadisticoUsuariosCursosTableAdapter estadisticoUsuariosCursosTableAdapter;
        private System.Windows.Forms.BindingSource graficoCursosTerminadosBindingSource;
        private DataSet1TableAdapters.GraficoCursosTerminadosTableAdapter graficoCursosTerminadosTableAdapter;
        private System.Windows.Forms.BindingSource estadisticoUsuariosCursosBindingSource1;
        private System.Windows.Forms.BindingSource EstadisticoPerfilesEnCursosBindingSource;
        private System.Windows.Forms.BindingSource estadisticoUsuariosCursosBindingSource2;
        public System.Windows.Forms.CheckBox chkTodos;
    }
}