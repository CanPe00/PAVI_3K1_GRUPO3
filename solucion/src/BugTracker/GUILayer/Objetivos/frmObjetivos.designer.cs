namespace BugTracker.GUILayer.Objetivos
{
    partial class frmObjetivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmObjetivos));
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblNombre_corto = new System.Windows.Forms.Label();
            this.lblNombre_largo = new System.Windows.Forms.Label();
            this.txtNombre_corto = new System.Windows.Forms.TextBox();
            this.txtNombre_largo = new System.Windows.Forms.TextBox();
            this.dgvObjetivos = new System.Windows.Forms.DataGridView();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(24, 494);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(60, 55);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(90, 494);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(58, 55);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.ForeColor = System.Drawing.Color.White;
            this.btnQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Image")));
            this.btnQuitar.Location = new System.Drawing.Point(154, 494);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(60, 55);
            this.btnQuitar.TabIndex = 9;
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(604, 494);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 55);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.lblNombre_corto);
            this.groupBox1.Controls.Add(this.lblNombre_largo);
            this.groupBox1.Controls.Add(this.txtNombre_corto);
            this.groupBox1.Controls.Add(this.txtNombre_largo);
            this.groupBox1.Controls.Add(this.dgvObjetivos);
            this.groupBox1.Controls.Add(this.chkTodos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 479);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Objetivos";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(432, 36);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(129, 50);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblNombre_corto
            // 
            this.lblNombre_corto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombre_corto.AutoSize = true;
            this.lblNombre_corto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre_corto.ForeColor = System.Drawing.Color.Black;
            this.lblNombre_corto.Location = new System.Drawing.Point(76, 37);
            this.lblNombre_corto.Name = "lblNombre_corto";
            this.lblNombre_corto.Size = new System.Drawing.Size(82, 15);
            this.lblNombre_corto.TabIndex = 0;
            this.lblNombre_corto.Text = "Nombre corto";
            // 
            // lblNombre_largo
            // 
            this.lblNombre_largo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombre_largo.AutoSize = true;
            this.lblNombre_largo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre_largo.ForeColor = System.Drawing.Color.Black;
            this.lblNombre_largo.Location = new System.Drawing.Point(76, 67);
            this.lblNombre_largo.Name = "lblNombre_largo";
            this.lblNombre_largo.Size = new System.Drawing.Size(83, 15);
            this.lblNombre_largo.TabIndex = 1;
            this.lblNombre_largo.Text = "Nombre largo";
            // 
            // txtNombre_corto
            // 
            this.txtNombre_corto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre_corto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.txtNombre_corto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre_corto.Location = new System.Drawing.Point(175, 36);
            this.txtNombre_corto.Name = "txtNombre_corto";
            this.txtNombre_corto.Size = new System.Drawing.Size(213, 21);
            this.txtNombre_corto.TabIndex = 2;
            // 
            // txtNombre_largo
            // 
            this.txtNombre_largo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre_largo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.txtNombre_largo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre_largo.Location = new System.Drawing.Point(175, 66);
            this.txtNombre_largo.Name = "txtNombre_largo";
            this.txtNombre_largo.Size = new System.Drawing.Size(213, 21);
            this.txtNombre_largo.TabIndex = 3;
            // 
            // dgvObjetivos
            // 
            this.dgvObjetivos.AllowUserToAddRows = false;
            this.dgvObjetivos.AllowUserToDeleteRows = false;
            this.dgvObjetivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvObjetivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObjetivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.dgvObjetivos.ColumnHeadersHeight = 30;
            this.dgvObjetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvObjetivos.Location = new System.Drawing.Point(6, 161);
            this.dgvObjetivos.Name = "dgvObjetivos";
            this.dgvObjetivos.RowHeadersWidth = 82;
            this.dgvObjetivos.Size = new System.Drawing.Size(648, 312);
            this.dgvObjetivos.TabIndex = 5;
            // 
            // chkTodos
            // 
            this.chkTodos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkTodos.AutoSize = true;
            this.chkTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTodos.ForeColor = System.Drawing.Color.Black;
            this.chkTodos.Location = new System.Drawing.Point(175, 97);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(60, 19);
            this.chkTodos.TabIndex = 4;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged_1);
            // 
            // frmObjetivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmObjetivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Objetivos";
            this.Load += new System.EventHandler(this.frmObjetivos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblNombre_corto;
        private System.Windows.Forms.Label lblNombre_largo;
        private System.Windows.Forms.TextBox txtNombre_corto;
        private System.Windows.Forms.TextBox txtNombre_largo;
        private System.Windows.Forms.DataGridView dgvObjetivos;
        private System.Windows.Forms.CheckBox chkTodos;
    }
}