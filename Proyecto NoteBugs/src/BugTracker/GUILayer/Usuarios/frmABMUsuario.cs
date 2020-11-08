using BugTracker.BusinessLayer;
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

namespace BugTracker.GUILayer.Usuarios
{
    public partial class frmABMUsuario : Form
    {
        private FormMode formMode = FormMode.insert;

        private readonly UsuarioService oUsuarioService;
        private readonly PerfilService oPerfilService;
        private Usuario oUsuarioSelected;

        public frmABMUsuario()
        {
            InitializeComponent();
            oUsuarioService = new UsuarioService();
            oPerfilService = new PerfilService();
        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }

        private void frmABMUsuario_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboPerfil, oPerfilService.ObtenerTodos(), "Nombre", "IdPerfil");
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Usuario";
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Actualizar Usuario";
                        // Recuperar usuario seleccionado en la grilla 
                        MostrarDatos();
                        txtNombre.Enabled = true;
                        txtEmail.Enabled = true;
                        txtEmail.Enabled = true;
                        txtPassword.Enabled = true;
                        txtConfirmarPass.Enabled = true;
                        cboPerfil.Enabled = true;
                        break;
                    }

                case FormMode.delete:
                    {
                        MostrarDatos();
                        this.Text = "Habilitar/Deshabilitar Usuario";
                        txtNombre.Enabled = false;
                        txtEmail.Enabled = false;
                        txtEmail.Enabled = false;
                        txtPassword.Enabled = false;
                        cboPerfil.Enabled = false;
                        txtConfirmarPass.Enabled = false;
                        break;
                    }
            }

        }

        public void SeleccionarUsuario(FormMode op, Usuario usuarioSelected)
        {
            formMode = op;
            oUsuarioSelected = usuarioSelected;
        }

        private void MostrarDatos()
        {
            if (oUsuarioSelected != null)
            {
                txtNombre.Text = oUsuarioSelected.NombreUsuario;
                txtEmail.Text = oUsuarioSelected.Email;
                txtPassword.Text = oUsuarioSelected.Password;
                txtConfirmarPass.Text = txtPassword.Text;
                cboPerfil.Text = oUsuarioSelected.Perfil.Nombre;
            }
        }

        
        private bool ValidarCampos()
        {
            // campos obligatorios
            if (txtNombre.Text == string.Empty)
            {
                txtNombre.BackColor = Color.FromArgb(255, 181, 66);
                txtNombre.Focus();
                return false;
            }
            else
                txtNombre.BackColor = Color.White;

            if (txtEmail.Text == string.Empty)
            {
                txtEmail.BackColor = Color.FromArgb(255, 181, 66);
                txtEmail.Focus();
                return false;
            }
            else
                txtEmail.BackColor = Color.White;

            if ((txtPassword.Text == string.Empty) || (txtConfirmarPass.Text == string.Empty))
            {
                txtConfirmarPass.BackColor = Color.FromArgb(255, 181, 66);
                txtPassword.BackColor = Color.FromArgb(255, 181, 66);
                return false;
            }

            else
            {
                if (txtPassword.Text != txtConfirmarPass.Text)
                {
                    txtConfirmarPass.BackColor = Color.Red;
                    txtPassword.BackColor = Color.Red;
                    MessageBox.Show("Las contraseñas no coinciden.");
                }
                else
                {
                    txtConfirmarPass.BackColor = Color.White;
                    txtPassword.BackColor = Color.White;
                }

            }

            if (cboPerfil.SelectedIndex == -1)
            {
                cboPerfil.BackColor = Color.FromArgb(255, 181, 66);
                return false;
            }
            else
            {
                cboPerfil.BackColor = Color.White;
            }

            return true;
        }

        private bool ExisteUsuario()
        {
            return oUsuarioService.ObtenerUsuario(txtNombre.Text) != null;
        }


        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        

        private void btnSalir_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (ExisteUsuario() == false)
                        {
                            if (ValidarCampos())
                            {
                                var oUsuario = new Usuario();
                                oUsuario.NombreUsuario = txtNombre.Text;
                                oUsuario.Password = txtPassword.Text;
                                oUsuario.Email = txtEmail.Text;
                                oUsuario.Perfil = new Perfil();
                                oUsuario.Perfil.IdPerfil = (int)cboPerfil.SelectedValue;
                                oUsuario.Estado = "S";

                                if (oUsuarioService.CrearUsuario(oUsuario))
                                {
                                    MessageBox.Show("Usuario insertado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                        else
                            MessageBox.Show("Nombre de usuario existente, ingrese un nombre diferente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case FormMode.update:
                    {
                        if (ValidarCampos())
                        {
                            oUsuarioSelected.NombreUsuario = txtNombre.Text;
                            oUsuarioSelected.Password = txtPassword.Text;
                            oUsuarioSelected.Email = txtEmail.Text;
                            oUsuarioSelected.Perfil = new Perfil();
                            oUsuarioSelected.Perfil.IdPerfil = (int)cboPerfil.SelectedValue;

                            if (oUsuarioService.ActualizarUsuario(oUsuarioSelected))
                            {
                                MessageBox.Show("Usuario actualizado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el usuario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }

                case FormMode.delete:
                    {
                        if (MessageBox.Show("¿Seguro que desea habilitar/deshabilitar el usuario seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {

                            if (oUsuarioService.BorrarUsuario(oUsuarioSelected))
                            {
                                MessageBox.Show("Usuario Habilitado/Deshabilitado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al actualizar usuario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }
            }

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

