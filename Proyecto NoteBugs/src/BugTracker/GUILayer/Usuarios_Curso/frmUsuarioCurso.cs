﻿using BugTracker.BusinessLayer;
using BugTracker.Entities;
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

namespace BugTracker.GUILayer.Usuarios_Curso
{
    
    public partial class frmUsuarioCurso : Form
    {
        private UsuariosCursoService oUsuariosCursoService;
        private CursoService oCursoService;
        private UsuarioService oUsuarioService;
        public frmUsuarioCurso()
        {
            InitializeComponent();
            InitializeDataGridView();
            oUsuariosCursoService = new UsuariosCursoService();
            oCursoService = new CursoService();
            oUsuarioService = new UsuarioService();
            
        }
        
        private void frmUsuarioCurso_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            LlenarCombo(cboCurso, oCursoService.ObtenerTodos(), "nombre", "id_curso");
            LlenarCombo(cboUsuario, oUsuarioService.ObtenerTodos(), "nombreUsuario", "idUsuario");
            //btnReporteUsuarioCurso.Enabled = false;
            //btnReporteCursosPorUsuario.Enabled = false;
            habilitar(false);
        }

        //private void habilitar(bool x)
        //{
        //    cboCurso.Enabled = x;
        //    cboUsuario.Enabled = x;
        //    btnEditar.Enabled = !x;
        //    btnNuevo.Enabled = !x;
        //    btnQuitar.Enabled = !x;
        //}

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvUsuarioCurso.ColumnCount = 3;
            dgvUsuarioCurso.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvUsuarioCurso.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            //DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            //columnHeaderStyle.BackColor = Color.Beige;
            //columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            //dgvUsuarioCurso.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            dgvUsuarioCurso.Columns[0].Name = "Usuario";
            dgvUsuarioCurso.Columns[0].DataPropertyName = "Usuario";
            // Definimos el ancho de la columna.

            dgvUsuarioCurso.Columns[1].Name = "Curso";
            dgvUsuarioCurso.Columns[1].DataPropertyName = "Curso";

            dgvUsuarioCurso.Columns[2].Name = "Puntuación";
            dgvUsuarioCurso.Columns[2].DataPropertyName = "Puntuacion";

         


            // Cambia el tamaño de la altura de los encabezados de columna.
            //dgvUsuarioCurso.AutoResizeColumnHeadersHeight();

            //// Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            //dgvUsuarioCurso.AutoResizeRows(
            //    DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            String condiciones = "";
            var filters = new Dictionary<string, object>();
            //usa filters para pasar los parámetros
            //usa condiciones para no usar parámetros en la consulta
            

            if (!chkTodos.Checked)
            {
                // Validar si el combo 'Curso' esta seleccionado.
                if (cboCurso.Text != string.Empty)
                {
                    // Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
                    filters.Add("UC.id_curso", cboCurso.SelectedValue);
                    condiciones += " AND UC.id_curso=" + cboCurso.SelectedValue.ToString();
                    //btnReporteUsuarioCurso.Enabled = true;

                }

                if (cboUsuario.Text != string.Empty)
                {
                    // Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
                    filters.Add("UC.id_usuario", cboCurso.SelectedValue);
                    condiciones += " AND UC.id_usuario=" + cboUsuario.SelectedValue.ToString();
                    //btnReporteCursosPorUsuario.Enabled = true;

                }


                if (filters.Count > 0)
                {
                    //si agrego alguna condicion
                    //SIN PARAMETROS

                    //MessageBox.Show("condiciones para el where del sql " + condiciones, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    dgvUsuarioCurso.DataSource = oUsuariosCursoService.ConsultarConFiltrosSinParametros(condiciones);
                    int filas = dgvUsuarioCurso.RowCount;
                    if (filas == 0)
                    {
                        habilitar(false);
                    }
                    else
                    {
                        habilitar(true);
                    }

                    //CON PARAMETROS
                    //dgvCursos.DataSource = oCursoService.ConsultarConFiltrosConParametros(filters);
                }
                else
                    MessageBox.Show("Debe ingresar al menos un criterio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {   //selecciono el checkbox(todos)
                dgvUsuarioCurso.DataSource = oUsuariosCursoService.ObtenerTodos();
                
                habilitar(true);
            }
        }


       

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (chkTodos.Checked)
                {
                    cboUsuario.Enabled = false;
                    cboCurso.Enabled = false;
                }
                else
                {
                    cboUsuario.Enabled = true;
                    cboCurso.Enabled = true;
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmAMBUsuarioCurso formulario = new frmAMBUsuarioCurso();
            formulario.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmAMBUsuarioCurso formulario = new frmAMBUsuarioCurso();
            var usCurso = (UsuariosCurso)dgvUsuarioCurso.CurrentRow.DataBoundItem;
            formulario.SeleccionarUsuarioCurso(frmAMBUsuarioCurso.FormMode.update, usCurso);
            formulario.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            frmAMBUsuarioCurso formulario = new frmAMBUsuarioCurso();
            var usCurso = (UsuariosCurso)dgvUsuarioCurso.CurrentRow.DataBoundItem;
            formulario.SeleccionarUsuarioCurso(frmAMBUsuarioCurso.FormMode.delete, usCurso);
            formulario.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void UsuarioCurso_Enter(object sender, EventArgs e)
        {

        }

        private void btnReporteUsuarioCurso_Click(object sender, EventArgs e)
        {
            if (cboCurso.Text != string.Empty)
            {
                ReporteUsuariosEnCurso formulario = new ReporteUsuariosEnCurso((int)cboCurso.SelectedValue);
                formulario.ShowDialog();
            }
            else
                MessageBox.Show("Debe ingresar al menos un Curso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnReporteCursosPorUsuario_Click(object sender, EventArgs e)
        {
            if (cboUsuario.Text != string.Empty)
            {
                ReporteCursosPorUsuario formulario = new ReporteCursosPorUsuario((int)cboUsuario.SelectedValue);
                formulario.ShowDialog();
            }
            else
                MessageBox.Show("Debe ingresar al menos un Usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void habilitar(bool x)
        {
            btnEditar.Enabled = x;
            btnQuitar.Enabled = x;
        }

        private void btnReiniciarCombos_Click(object sender, EventArgs e)
        {
            cboCurso.SelectedIndex = -1;
            cboUsuario.SelectedIndex = -1;

        }

        private void lblN_Curso_Click(object sender, EventArgs e)
        {

        }

        private void lblN_Usuario_Click(object sender, EventArgs e)
        {

        }
    }
}
