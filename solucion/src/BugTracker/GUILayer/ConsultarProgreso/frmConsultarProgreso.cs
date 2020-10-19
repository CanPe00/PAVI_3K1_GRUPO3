using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BugTracker.BusinessLayer;
using BugTracker.Entities;
using BugTracker.GUILayer.Usuario_Curso_Avance;

namespace BugTracker.GUILayer
{
    public partial class frmConsultarProgreso : Form
    {
        private CursoService oCursoService;
        private UsuarioService oUsuarioService;
        private ComboBox cboUsuarios;
        private ComboBox cboCursos;
        private Label lblUsuarios;
        private Label lblCurso;
        private Button btnConsultar;
        private UsuariosCursoService oUsuarioCursoService;





        public frmConsultarProgreso()
        {
            InitializeComponent();
            oCursoService = new CursoService();
            oUsuarioService = new UsuarioService();
            oUsuarioCursoService = new UsuariosCursoService();
        }

        private void frmConsultarActividades_Load_1(object sender, EventArgs e)
        {
            this.CenterToParent();
            habilitar(true);
            LlenarCombo(cboCursos, oCursoService.ObtenerTodos(), "nombre", "id_curso");
            LlenarCombo(cboUsuarios, oUsuarioService.ObtenerTodos(), "nombreUsuario", "idUsuario");
        }

        private void habilitar(bool x)
        {
            cboUsuarios.Enabled = x;
            cboCursos.Enabled = x;
            btnConsultar.Enabled = x;
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
           
            if (ExisteUsuarioEnCurso())
            {   
                frmUsuarioCursoAvance frmDetalle = new frmUsuarioCursoAvance((int)cboCursos.SelectedValue, (int)cboUsuarios.SelectedValue);
            
                frmDetalle.ShowDialog();

            }
            else
                MessageBox.Show("Relacion usuario-curso no encontrado!. Ingrese un nombre de usuario o curso diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private bool ExisteUsuarioEnCurso()
        {
            string usuario = cboUsuarios.SelectedValue.ToString();
            string curso = cboCursos.SelectedValue.ToString();

            return oUsuarioCursoService.ObtenerUsuariosCurso(curso, usuario) != null;
        }
        private void InitializeComponent()
        {
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.cboCursos = new System.Windows.Forms.ComboBox();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cboUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.cboUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.Location = new System.Drawing.Point(255, 197);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(243, 24);
            this.cboUsuarios.TabIndex = 0;
            // 
            // cboCursos
            // 
            this.cboCursos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cboCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.cboCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCursos.FormattingEnabled = true;
            this.cboCursos.Location = new System.Drawing.Point(255, 279);
            this.cboCursos.Name = "cboCursos";
            this.cboCursos.Size = new System.Drawing.Size(243, 24);
            this.cboCursos.TabIndex = 1;
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.Location = new System.Drawing.Point(171, 195);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(64, 20);
            this.lblUsuarios.TabIndex = 2;
            this.lblUsuarios.Text = "Usuario";
            // 
            // lblCurso
            // 
            this.lblCurso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(184, 280);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(51, 20);
            this.lblCurso.TabIndex = 3;
            this.lblCurso.Text = "Curso";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(277, 364);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(160, 44);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmConsultarProgreso
            // 
            this.ClientSize = new System.Drawing.Size(694, 593);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.cboCursos);
            this.Controls.Add(this.cboUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultarProgreso";
            this.Text = "Consultar Progreso";
            this.Load += new System.EventHandler(this.frmConsultarActividades_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
    }
}
