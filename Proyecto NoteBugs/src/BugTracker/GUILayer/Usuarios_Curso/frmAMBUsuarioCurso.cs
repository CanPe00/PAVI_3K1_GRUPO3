using BugTracker.BusinessLayer;
using BugTracker.GUILayer.Usuario_Curso_Avance;
using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker.GUILayer.Usuarios_Curso
{
    public partial class frmAMBUsuarioCurso : Form
    {
        private FormMode formMode = FormMode.insert;

        private readonly UsuariosCursoService oUsuariosCursoService;
        
        private UsuariosCurso oUsuarioCursoSelected;
        private CursoService oCursoService;
        
        private UsuarioService oUsuarioService;
        

        public frmAMBUsuarioCurso()
        {
            InitializeComponent();
            oUsuariosCursoService = new UsuariosCursoService();
            oCursoService = new CursoService();
            oUsuarioService = new UsuarioService();

        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }

        private void frmAMBUsuarioCurso_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboCurso, oCursoService.ObtenerTodos(), "nombre", "id_curso");
            LlenarCombo(cboUsuario, oUsuarioService.ObtenerTodos(), "nombreUsuario", "idUsuario");
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Usuario en Curso";
                        dtpFecha_fin.Enabled = false;
                        break;
                    }

                case FormMode.update:
                    {
                        dtpFecha_fin.Hide();
                        lblFecha_Fin.Hide();
                        this.Text = "Actualizar datos Usuario-Curso";
                        // Recuperar usuario seleccionado en la grilla 
                        MostrarDatos();
                        cboCurso.Enabled = false;
                        cboUsuario.Enabled = false;
                        txtPuntuacion.Enabled = true;
                        txtObservaciones.Enabled = true;
                        dtpFechaInicio.Enabled = true;
                        //dtpFecha_fin.Enabled = true;
                        break;
                    }

                case FormMode.delete:
                    {
                        MostrarDatos();
                        this.Text = "Habilitar/Deshabilitar Usuario en Curso";
                        cboCurso.Enabled = false;
                        cboUsuario.Enabled = false;
                        txtPuntuacion.Enabled = false;
                        txtObservaciones.Enabled = false;
                        dtpFecha_fin.Enabled = false;
                        dtpFechaInicio.Enabled = false;
                        break;
                    }
            }

        }

        public void SeleccionarUsuarioCurso(FormMode op, UsuariosCurso usuarioCursoSelected)
        {
            formMode = op;
            oUsuarioCursoSelected= usuarioCursoSelected;
        }

        private void MostrarDatos()
        {
            if (oUsuarioCursoSelected != null)
            {
                cboUsuario.Text = oUsuarioCursoSelected.Usuario.NombreUsuario;
                cboCurso.Text = oUsuarioCursoSelected.Curso.Nombre;
                txtPuntuacion.Text = oUsuarioCursoSelected.Puntuacion.ToString();
                txtObservaciones.Text = oUsuarioCursoSelected.Observaciones;
                dtpFechaInicio.Value = oUsuarioCursoSelected.Fecha_inicio;
                dtpFecha_fin.Value = oUsuarioCursoSelected.Fecha_fin;

            }
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private bool ValidarCampos()
        {
            
            // campos obligatorios
            if (cboUsuario.SelectedIndex == -1)
            {
                cboUsuario.BackColor = Color.FromArgb(255, 181, 66);
                cboUsuario.Focus();
                return false;
            }
            else
            {
                cboUsuario.BackColor = Color.White;
            }

            if (cboCurso.SelectedIndex == -1)
            {
                cboCurso.BackColor = Color.FromArgb(255, 181, 66); 
                cboCurso.Focus();
                return false;
            }
            else
                cboCurso.BackColor = Color.White;

            if (txtPuntuacion.Text == "") 
            {
                txtPuntuacion.BackColor = Color.FromArgb(255, 181, 66);
                txtPuntuacion.Focus();
                MessageBox.Show("Debe ingresar un valor numérico en Puntuación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                txtPuntuacion.BackColor = Color.White;
            }

            return true;

            
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (ValidarCampos())
                        {

                            if (ExisteUsuarioEnCurso() == false)
                            {
                                var oUsuarioCurso = new UsuariosCurso();
                                oUsuarioCurso.Curso = new Curso();
                                oUsuarioCurso.Curso.Id_curso = (int)cboCurso.SelectedValue;
                                oUsuarioCurso.Usuario = new Usuario();
                                oUsuarioCurso.Usuario.IdUsuario = (int)cboUsuario.SelectedValue;

                                oUsuarioCurso.Puntuacion = Convert.ToInt32(txtPuntuacion.Text.ToString());
                                oUsuarioCurso.Observaciones = txtObservaciones.Text;
                                oUsuarioCurso.Fecha_inicio = dtpFechaInicio.Value;

                                if (oUsuariosCursoService.CrearUsuarioCurso(oUsuarioCurso))
                                {
                                    MessageBox.Show("Usuario en curso insertado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    frmUsuarioCursoAvance avance = new frmUsuarioCursoAvance((int)cboCurso.SelectedValue, (int)cboUsuario.SelectedValue);
                                    avance.ShowDialog();
                                    this.Close();

                                }
                                else

                                    MessageBox.Show("Relación Usuario-Curso con éxito, ingrese un nombre de Usuario o Curso diferente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                            }
                            

                        }
                        break;
                    }

                case FormMode.update:
                    {
                        if (ValidarCampos())
                        {
                        
                            oUsuarioCursoSelected.Usuario.IdUsuario = (int)cboUsuario.SelectedValue;
                            oUsuarioCursoSelected.Curso.Id_curso = (int)cboCurso.SelectedValue;
                            oUsuarioCursoSelected.Puntuacion = Convert.ToInt32(txtPuntuacion.Text.ToString());
                            oUsuarioCursoSelected.Observaciones = txtObservaciones.Text;
                            oUsuarioCursoSelected.Fecha_inicio =dtpFechaInicio.Value;
                            oUsuarioCursoSelected.Fecha_fin = dtpFecha_fin.Value;
                            

                            if (oUsuariosCursoService.ActualizarUsuarioCurso(oUsuarioCursoSelected))
                            {
                                MessageBox.Show("Usuario-Curso actualizado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el Usuario-Curso.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }

                case FormMode.delete:
                    {
                        if (MessageBox.Show("¿Seguro que desea habilitar/deshabilitar el usuario en curso seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {

                            if (oUsuariosCursoService.BorrarUsuarioCurso(oUsuarioCursoSelected))
                            {
                                MessageBox.Show("Usuario en curso Habilitado/Deshabilitado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al actualizar el Usuario y/o Curso.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }
            }
        }

        private bool ExisteUsuarioEnCurso()
        {
            string usuario = cboUsuario.SelectedValue.ToString();
            string curso = cboCurso.SelectedValue.ToString();
            return oUsuariosCursoService.ObtenerUsuariosCurso(curso , usuario) != null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void cboUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPuntuacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPuntuacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else

            if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
    }
}
