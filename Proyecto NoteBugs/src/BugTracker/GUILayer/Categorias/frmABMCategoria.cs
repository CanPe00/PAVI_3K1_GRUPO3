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

namespace BugTracker.GUILayer.Categorias
{
    public partial class frmABMCategoria : Form
    {
        private FormMode formMode = FormMode.insert;

        private readonly CategoriaService oCategoriaService;
        private Categoria oCategoriaSelected;
        public frmABMCategoria()
        {
            InitializeComponent();
            oCategoriaService = new CategoriaService();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }

        private void frmABMCategoria_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nueva Categoría";
                        txtNombre.Enabled = true;
                        txtDescripcion.Enabled = true;
                        break;
                    }
                case FormMode.update:
                    {
                        MostrarDatos();
                        this.Text = "Actualizar Categoría";
                        txtNombre.Enabled = true;
                        txtDescripcion.Enabled = true;
                        break;
                    }
                case FormMode.delete:
                    {
                        MostrarDatos();
                        this.Text = "Habilitar/Deshabilitar Categoría";
                        txtNombre.Enabled = false;
                        txtDescripcion.Enabled = false;
                        break;
                    }
            }

        }

        private void MostrarDatos()
        {
            if (oCategoriaSelected != null)
            {
                txtNombre.Text = oCategoriaSelected.Nombre;
                txtDescripcion.Text = oCategoriaSelected.Descripcion;
            }
        }

        public void SeleccionarCategoria(FormMode op, Categoria categoriaSelected)
        {
            formMode = op;
            oCategoriaSelected = categoriaSelected;
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

            return true;
        }

        private bool ExisteCategoria()
        {
            return oCategoriaService.ObtenerCategoria(txtNombre.Text) != null;
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {

                        if (ExisteCategoria() == false)
                        {

                            if (ValidarCampos())
                            {
                                var oCategoria = new Categoria();
                                oCategoria.Nombre = txtNombre.Text;
                                oCategoria.Descripcion = txtDescripcion.Text;


                                if (oCategoriaService.CrearCategoria(oCategoria))
                                {
                                    MessageBox.Show("Categoría insertada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();


                                }
                            }
                        }
                        else
                            MessageBox.Show("Nombre de categoría existente, ingrese un nombre diferente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case FormMode.update:
                    {
                        if (ValidarCampos())
                        {
                            oCategoriaSelected.Nombre = txtNombre.Text;
                            oCategoriaSelected.Descripcion = txtDescripcion.Text;

                            if (oCategoriaService.ActualizarCategoria(oCategoriaSelected))
                            {
                                MessageBox.Show("Categoría actualizada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar categoría.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }

                case FormMode.delete:
                    {
                        if (MessageBox.Show("¿Seguro que desea habilitar/deshabilitar la categoría seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {

                            if (oCategoriaService.BorrarCategoria(oCategoriaSelected))
                            {
                                MessageBox.Show("Categoría Habilitada/Deshabilitada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al actualizar la categoría.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }
            }

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
