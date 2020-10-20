using BugTracker.Cursos;
using BugTracker.GUILayer.Usuarios;
using BugTracker.GUILayer.Objetivos;
using BugTracker.GUILayer.Categorias;
using BugTracker.GUILayer.Actividades;
using BugTracker.GUILayer.ReporteFechaFinCurso;
using BugTracker.GUILayer.Usuarios_Curso;
using BugTracker.GUILayer.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BugTracker.GUILayer.NewFolder1;
using BugTracker.GUILayer.Estadisticas;

namespace BugTracker.GUILayer
{
    public partial class frmMenuModerno : Form
    {
        public frmMenuModerno()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelAgregarSubmenu.Visible = false;
            panelListadoSubmenu.Visible = false;
            panelSoporteSubmenu.Visible = false;
            panelReportesSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelAgregarSubmenu.Visible == true)
            {
                panelAgregarSubmenu.Visible = false;
            }
            if (panelSoporteSubmenu.Visible == true)
            {
                panelSoporteSubmenu.Visible = false;
            }
            if (panelListadoSubmenu.Visible == true)
            {
                panelListadoSubmenu.Visible = false;
            }
            if (panelReportesSubmenu.Visible == true)
            {
                panelReportesSubmenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAgregarSubmenu);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUsuarios());
            //
            //
            //
            hideSubMenu();
        }

        private void btnActividades_Click(object sender, EventArgs e)
        {
            openChildForm(new frmActividades());
            //
            //
            //
            hideSubMenu();
        }

        private void btnObjetivos_Click(object sender, EventArgs e)
        {
            openChildForm(new frmObjetivos());
            //
            //
            //
            hideSubMenu();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCategorias());
            //
            //
            //
            hideSubMenu();
        }

        private void btnSoporte_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSoporteSubmenu);
        }

        private void btnUsuariosXCurso_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUsuarioCurso());
            //
            //
            //
            hideSubMenu();
        }

        private void btnConsultarProgreso_Click(object sender, EventArgs e)
        {
            openChildForm(new frmConsultarProgreso());
            //
            //
            //
            hideSubMenu();
        }

        private void btnCursosFinalizadosXFecha_Click(object sender, EventArgs e)
        {
            
            //
            //
            //
            hideSubMenu();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            showSubMenu(panelListadoSubmenu);
        }

        private void btnListadoCursos_Click(object sender, EventArgs e)
        {
            openChildForm(new ListadoCursos());
            //
            //
            //
            hideSubMenu();
        }

        private void btnListadoActividades_Click(object sender, EventArgs e)
        {
            openChildForm(new ListadoActividades());
            //
            //
            //
            hideSubMenu();
        }

        private void btnListadoUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new ListadoUsuarios());
            //
            //
            //
            hideSubMenu();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReportesSubmenu);
        }

        private void btnCursosFinalizadosFecha_Click(object sender, EventArgs e)
        {
            openChildForm(new frmGeneradorReporteFechaFinCurso());
            //
            //
            //
            hideSubMenu();
        }

        private void btnCantUsuariosCurso_Click(object sender, EventArgs e)
        {
            openChildForm(new EstadisticoCantUsuariosCursos());
            //
            //
            //
            hideSubMenu();
        }

        private void btnPerfilesXCurso_Click(object sender, EventArgs e)
        {
            openChildForm(new EstadisticoPerfilesCurso());
            //
            //
            //
            hideSubMenu();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelConenedor.Controls.Add(childForm);
            panelConenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();



        }

        private void frmMenuModerno_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            frmLogin login = new frmLogin();
            login.ShowDialog();
            btnNombre.Text = "Bienvenido " + login.UsuarioLogueado;
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCursos());
            //
            //
            //
            hideSubMenu();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCategoriasXCurso_Click(object sender, EventArgs e)
        {
            openChildForm(new EstadisticoCategoriasCursos());
            //
            //
            //
            hideSubMenu();
        }
    }
}
