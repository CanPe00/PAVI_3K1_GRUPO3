namespace BugTracker.GUILayer.Usuarios_Curso
{
    partial class frmUsuarioCurso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarioCurso));
            this.lblN_Curso = new System.Windows.Forms.Label();
            this.lblN_Usuario = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.UsuarioCurso = new System.Windows.Forms.GroupBox();
            this.dgvUsuarioCurso = new System.Windows.Forms.DataGridView();
            this.btnReiniciarCombos = new System.Windows.Forms.Button();
            this.btnReporteUsuarioCurso = new System.Windows.Forms.Button();
            this.btnReporteCursosPorUsuario = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.UsuarioCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // lblN_Curso
            // 
            this.lblN_Curso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblN_Curso.AutoSize = true;
            this.lblN_Curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN_Curso.ForeColor = System.Drawing.Color.Black;
            this.lblN_Curso.Location = new System.Drawing.Point(78, 33);
            this.lblN_Curso.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblN_Curso.Name = "lblN_Curso";
            this.lblN_Curso.Size = new System.Drawing.Size(91, 15);
            this.lblN_Curso.TabIndex = 0;
            this.lblN_Curso.Text = "Nombre curso: ";
            this.lblN_Curso.Click += new System.EventHandler(this.lblN_Curso_Click);
            // 
            // lblN_Usuario
            // 
            this.lblN_Usuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblN_Usuario.AutoSize = true;
            this.lblN_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN_Usuario.ForeColor = System.Drawing.Color.Black;
            this.lblN_Usuario.Location = new System.Drawing.Point(67, 65);
            this.lblN_Usuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblN_Usuario.Name = "lblN_Usuario";
            this.lblN_Usuario.Size = new System.Drawing.Size(102, 15);
            this.lblN_Usuario.TabIndex = 1;
            this.lblN_Usuario.Text = "Nombre usuario: ";
            this.lblN_Usuario.Click += new System.EventHandler(this.lblN_Usuario_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(426, 35);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(6);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(129, 50);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // chkTodos
            // 
            this.chkTodos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkTodos.AutoSize = true;
            this.chkTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTodos.ForeColor = System.Drawing.Color.Black;
            this.chkTodos.Location = new System.Drawing.Point(181, 98);
            this.chkTodos.Margin = new System.Windows.Forms.Padding(6);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(60, 19);
            this.chkTodos.TabIndex = 5;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // cboUsuario
            // 
            this.cboUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(181, 65);
            this.cboUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(210, 23);
            this.cboUsuario.TabIndex = 7;
            // 
            // cboCurso
            // 
            this.cboCurso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(181, 32);
            this.cboCurso.Margin = new System.Windows.Forms.Padding(6);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(210, 23);
            this.cboCurso.TabIndex = 8;
            // 
            // UsuarioCurso
            // 
            this.UsuarioCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsuarioCurso.Controls.Add(this.dgvUsuarioCurso);
            this.UsuarioCurso.Controls.Add(this.btnReiniciarCombos);
            this.UsuarioCurso.Controls.Add(this.cboCurso);
            this.UsuarioCurso.Controls.Add(this.cboUsuario);
            this.UsuarioCurso.Controls.Add(this.chkTodos);
            this.UsuarioCurso.Controls.Add(this.btnConsultar);
            this.UsuarioCurso.Controls.Add(this.lblN_Usuario);
            this.UsuarioCurso.Controls.Add(this.lblN_Curso);
            this.UsuarioCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsuarioCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioCurso.ForeColor = System.Drawing.Color.Black;
            this.UsuarioCurso.Location = new System.Drawing.Point(15, 15);
            this.UsuarioCurso.Margin = new System.Windows.Forms.Padding(6);
            this.UsuarioCurso.Name = "UsuarioCurso";
            this.UsuarioCurso.Padding = new System.Windows.Forms.Padding(6);
            this.UsuarioCurso.Size = new System.Drawing.Size(663, 479);
            this.UsuarioCurso.TabIndex = 9;
            this.UsuarioCurso.TabStop = false;
            this.UsuarioCurso.Text = "Buscar Usuario en Curso";
            this.UsuarioCurso.Enter += new System.EventHandler(this.UsuarioCurso_Enter);
            // 
            // dgvUsuarioCurso
            // 
            this.dgvUsuarioCurso.AllowUserToAddRows = false;
            this.dgvUsuarioCurso.AllowUserToDeleteRows = false;
            this.dgvUsuarioCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarioCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarioCurso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsuarioCurso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvUsuarioCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarioCurso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarioCurso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarioCurso.ColumnHeadersHeight = 30;
            this.dgvUsuarioCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsuarioCurso.EnableHeadersVisualStyles = false;
            this.dgvUsuarioCurso.GridColor = System.Drawing.Color.Black;
            this.dgvUsuarioCurso.Location = new System.Drawing.Point(9, 126);
            this.dgvUsuarioCurso.Name = "dgvUsuarioCurso";
            this.dgvUsuarioCurso.ReadOnly = true;
            this.dgvUsuarioCurso.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarioCurso.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarioCurso.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUsuarioCurso.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuarioCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarioCurso.Size = new System.Drawing.Size(645, 344);
            this.dgvUsuarioCurso.TabIndex = 20;
            // 
            // btnReiniciarCombos
            // 
            this.btnReiniciarCombos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReiniciarCombos.BackColor = System.Drawing.Color.Transparent;
            this.btnReiniciarCombos.FlatAppearance.BorderSize = 0;
            this.btnReiniciarCombos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciarCombos.Image = ((System.Drawing.Image)(resources.GetObject("btnReiniciarCombos.Image")));
            this.btnReiniciarCombos.Location = new System.Drawing.Point(392, 45);
            this.btnReiniciarCombos.Name = "btnReiniciarCombos";
            this.btnReiniciarCombos.Size = new System.Drawing.Size(33, 30);
            this.btnReiniciarCombos.TabIndex = 9;
            this.btnReiniciarCombos.UseVisualStyleBackColor = false;
            this.btnReiniciarCombos.Click += new System.EventHandler(this.btnReiniciarCombos_Click);
            // 
            // btnReporteUsuarioCurso
            // 
            this.btnReporteUsuarioCurso.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReporteUsuarioCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.btnReporteUsuarioCurso.FlatAppearance.BorderSize = 0;
            this.btnReporteUsuarioCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteUsuarioCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteUsuarioCurso.ForeColor = System.Drawing.Color.White;
            this.btnReporteUsuarioCurso.Location = new System.Drawing.Point(274, 523);
            this.btnReporteUsuarioCurso.Name = "btnReporteUsuarioCurso";
            this.btnReporteUsuarioCurso.Size = new System.Drawing.Size(144, 55);
            this.btnReporteUsuarioCurso.TabIndex = 14;
            this.btnReporteUsuarioCurso.Text = "Reporte Usuarios en Curso";
            this.btnReporteUsuarioCurso.UseVisualStyleBackColor = false;
            this.btnReporteUsuarioCurso.Click += new System.EventHandler(this.btnReporteUsuarioCurso_Click);
            // 
            // btnReporteCursosPorUsuario
            // 
            this.btnReporteCursosPorUsuario.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReporteCursosPorUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.btnReporteCursosPorUsuario.FlatAppearance.BorderSize = 0;
            this.btnReporteCursosPorUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteCursosPorUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteCursosPorUsuario.ForeColor = System.Drawing.Color.White;
            this.btnReporteCursosPorUsuario.Location = new System.Drawing.Point(424, 523);
            this.btnReporteCursosPorUsuario.Name = "btnReporteCursosPorUsuario";
            this.btnReporteCursosPorUsuario.Size = new System.Drawing.Size(144, 55);
            this.btnReporteCursosPorUsuario.TabIndex = 15;
            this.btnReporteCursosPorUsuario.Text = "Reporte Cursos por usuario";
            this.btnReporteCursosPorUsuario.UseVisualStyleBackColor = false;
            this.btnReporteCursosPorUsuario.Click += new System.EventHandler(this.btnReporteCursosPorUsuario_Click);
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
            this.btnSalir.Location = new System.Drawing.Point(606, 523);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 55);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.btnQuitar.Enabled = false;
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.Color.White;
            this.btnQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Image")));
            this.btnQuitar.Location = new System.Drawing.Point(174, 523);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(6);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(60, 55);
            this.btnQuitar.TabIndex = 12;
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(102, 523);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(60, 55);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(30, 523);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(6);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(60, 55);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmUsuarioCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(694, 593);
            this.Controls.Add(this.btnReporteCursosPorUsuario);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnReporteUsuarioCurso);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.UsuarioCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuarioCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios regitrados y activos en Cursos ";
            this.Load += new System.EventHandler(this.frmUsuarioCurso_Load);
            this.UsuarioCurso.ResumeLayout(false);
            this.UsuarioCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioCurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblN_Curso;
        private System.Windows.Forms.Label lblN_Usuario;
        private System.Windows.Forms.Button btnConsultar;
        internal System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.GroupBox UsuarioCurso;
        internal System.Windows.Forms.Button btnNuevo;
        internal System.Windows.Forms.Button btnEditar;
        internal System.Windows.Forms.Button btnQuitar;
        internal System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnReporteUsuarioCurso;
        private System.Windows.Forms.Button btnReporteCursosPorUsuario;
        internal System.Windows.Forms.Button btnReiniciarCombos;
        private System.Windows.Forms.DataGridView dgvUsuarioCurso;
    }
}