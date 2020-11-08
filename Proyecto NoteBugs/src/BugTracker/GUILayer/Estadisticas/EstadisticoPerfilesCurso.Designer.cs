namespace BugTracker.GUILayer.NewFolder1
{
    partial class EstadisticoPerfilesCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstadisticoPerfilesCurso));
            this.estadisticoPerfilesEnCursosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new BugTracker.DataSet1();
            this.estadisticoCategoriasCursosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.estadisticoPerfilesEnCursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EstadisticoCategoriasCursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.dtpFecha_Desde = new System.Windows.Forms.DateTimePicker();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticoPerfilesEnCursosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticoCategoriasCursosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticoPerfilesEnCursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstadisticoCategoriasCursosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // estadisticoPerfilesEnCursosBindingSource1
            // 
            this.estadisticoPerfilesEnCursosBindingSource1.DataMember = "EstadisticoPerfilesEnCursos";
            this.estadisticoPerfilesEnCursosBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estadisticoCategoriasCursosBindingSource1
            // 
            this.estadisticoCategoriasCursosBindingSource1.DataMember = "EstadisticoCategoriasCursos";
            this.estadisticoCategoriasCursosBindingSource1.DataSource = this.dataSet1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fecha Hasta:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Fecha Desde:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(412, 29);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(124, 22);
            this.dtpFechaHasta.TabIndex = 18;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.estadisticoPerfilesEnCursosBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BugTracker.PerfilesCurso.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 94);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(660, 455);
            this.reportViewer1.TabIndex = 22;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // btnGrafico
            // 
            this.btnGrafico.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGrafico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.btnGrafico.FlatAppearance.BorderSize = 0;
            this.btnGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrafico.Image = ((System.Drawing.Image)(resources.GetObject("btnGrafico.Image")));
            this.btnGrafico.Location = new System.Drawing.Point(588, 29);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(46, 37);
            this.btnGrafico.TabIndex = 21;
            this.btnGrafico.UseVisualStyleBackColor = false;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // estadisticoPerfilesEnCursosBindingSource
            // 
            this.estadisticoPerfilesEnCursosBindingSource.DataMember = "EstadisticoPerfilesEnCursos";
            this.estadisticoPerfilesEnCursosBindingSource.DataSource = this.dataSet1;
            // 
            // EstadisticoCategoriasCursosBindingSource
            // 
            this.EstadisticoCategoriasCursosBindingSource.DataMember = "EstadisticoCategoriasCursos";
            this.EstadisticoCategoriasCursosBindingSource.DataSource = this.dataSet1;
            // 
            // chkTodos
            // 
            this.chkTodos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkTodos.AutoSize = true;
            this.chkTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTodos.Location = new System.Drawing.Point(469, 62);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(67, 21);
            this.chkTodos.TabIndex = 23;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // dtpFecha_Desde
            // 
            this.dtpFecha_Desde.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFecha_Desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha_Desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_Desde.Location = new System.Drawing.Point(151, 31);
            this.dtpFecha_Desde.Name = "dtpFecha_Desde";
            this.dtpFecha_Desde.Size = new System.Drawing.Size(124, 22);
            this.dtpFecha_Desde.TabIndex = 24;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(627, 504);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(45, 45);
            this.btnSalir.TabIndex = 40;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // EstadisticoPerfilesCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtpFecha_Desde);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaHasta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EstadisticoPerfilesCurso";
            this.Text = "EstadisticoPerfilesCurso";
            this.Load += new System.EventHandler(this.EstadisticoPerfilesCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estadisticoPerfilesEnCursosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticoCategoriasCursosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticoPerfilesEnCursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstadisticoCategoriasCursosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource estadisticoPerfilesEnCursosBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.EstadisticoPerfilesEnCursosTableAdapter estadisticoPerfilesEnCursosTableAdapter;
        private System.Windows.Forms.BindingSource EstadisticoCategoriasCursosBindingSource;
        private System.Windows.Forms.BindingSource estadisticoCategoriasCursosBindingSource1;
        private System.Windows.Forms.BindingSource estadisticoPerfilesEnCursosBindingSource1;
        public System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.DateTimePicker dtpFecha_Desde;
        internal System.Windows.Forms.Button btnSalir;
    }
}