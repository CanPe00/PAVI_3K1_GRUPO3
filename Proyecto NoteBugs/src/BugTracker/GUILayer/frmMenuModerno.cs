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
        private Panel leftBorderBtn;
        public frmMenuModerno()
        {
            InitializeComponent();
            customizeDesing();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 45);
            panelSideMenuLateral.Controls.Add(leftBorderBtn);
        }

        private void ActivateButton(object senderBtn, int Y)
        {
            if (senderBtn != null)
            {
                //DisableButton();  
                //Left border button
                leftBorderBtn.BackColor = Color.FromArgb(250, 250, 250); 
                leftBorderBtn.Location = new Point(0, Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
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
            ActivateButton(sender,107);

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
            ActivateButton(sender, 152);

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
            ActivateButton(sender, 197);
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
            ActivateButton(sender, 242);
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
            lblBienvenido.Text = "Bienvenido " + login.UsuarioLogueado;

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

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, 287);
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCategoriasXCurso_Click(object sender, EventArgs e)
        {
            openChildForm(new EstadisticoCategoriasCursos());
            //
            //
            //
            hideSubMenu();
        }

        private void panelConenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tmFechaHora_Tick_1(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
