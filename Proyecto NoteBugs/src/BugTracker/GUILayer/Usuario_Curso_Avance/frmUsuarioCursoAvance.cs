﻿using BugTracker.BusinessLayer;
using BugTracker.GUILayer.Reportes;
using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BugTracker.GUILayer.Usuarios_Curso;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BugTracker.GUILayer.Usuario_Curso_Avance
{ 
    public partial class frmUsuarioCursoAvance : Form
    {
        private UsuarioCursoAvanceService oUsuarioCursoAvanceService;
        public int idCurso;
        public int idUsuario;
        
       
       
        public frmUsuarioCursoAvance()
        {
            InitializeComponent();
            InitializeDataGridView();
            oUsuarioCursoAvanceService = new UsuarioCursoAvanceService();

        }
        public frmUsuarioCursoAvance(int idCurso, int idUsuario)
        {
            InitializeComponent();
            InitializeDataGridView();
            this.idCurso = idCurso;
            this.idUsuario = idUsuario;
            oUsuarioCursoAvanceService = new UsuarioCursoAvanceService();
            
        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvUsuarioCursoAvance.ColumnCount = 2;
            dgvUsuarioCursoAvance.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvUsuarioCursoAvance.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            //DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            //columnHeaderStyle.BackColor = Color.Beige;
            //columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            //dgvUsuarioCursoAvance.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            dgvUsuarioCursoAvance.Columns[0].Name = "Actividades";
            dgvUsuarioCursoAvance.Columns[0].DataPropertyName = "Actividad";
            // Definimos el ancho de la columna.;
            //dgvUsuarioCursoAvance.Columns[1].Name = "Descripción";
            //dgvUsuarioCursoAvance.Columns[1].DataPropertyName = "Descripcion";

            dgvUsuarioCursoAvance.Columns[1].Name = "Finalizado";
            dgvUsuarioCursoAvance.Columns[1].DataPropertyName = "Finalizado";


            // Cambia el tamaño de la altura de los encabezados de columna.
            //dgvUsuarioCursoAvance.AutoResizeColumnHeadersHeight();

            //// Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            //dgvUsuarioCursoAvance.AutoResizeRows(
            //    DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void UsuarioCurso_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmUsuarioCursoAvance_Load(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            String condiciones = "";
            condiciones += " AND UCA.id_curso=" + idCurso;
            condiciones += " AND UCA.id_usuario=" + idUsuario;

            dgvUsuarioCursoAvance.DataSource = oUsuarioCursoAvanceService.ConsultarConFiltrosSinParametros(condiciones);

            int filas_totales = dgvUsuarioCursoAvance.RowCount;
            int count = 0;
            for (int fila = 0; fila < filas_totales ; fila++)
            {

                if (dgvUsuarioCursoAvance.Rows[fila].Cells[1].Value is true)
                {
                    count += 1;
                }
            }
            int filas_true = count;
            decimal total;
            if (filas_totales == 0)
            {
                total = 0;
            }
            else
            {
                total = (filas_true * 100) / filas_totales;
            }
            
            label2.Text = Convert.ToString(total) + '%';

            int total2 = Convert.ToInt32(total);
            pbrPorcentaje.Value = total2;
            //oUsuarioCursoAvanceService.ActividadesRealizadas();

            if ((filas_totales == filas_true) && (filas_totales != 0))
            {
                oUsuarioCursoAvanceService.ActualizarFechaFin(idCurso,idUsuario);
                MessageBox.Show("Curso finalizado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void pgreBar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var actividad = (UsuarioCursoAvance)dgvUsuarioCursoAvance.CurrentRow.DataBoundItem;

            var id_usuario = actividad.Usuario.IdUsuario;
            var id_curso = actividad.Curso.Id_curso;
            var id_actividad = actividad.Actividad.Id_actividad;
            oUsuarioCursoAvanceService.ActualizarActUsuarioCursoAvance(id_usuario, id_curso, id_actividad);
            
            frmUsuarioCursoAvance_Load(sender, e);
            btnNuevo.Enabled = true;
            

            //oUsuarioCursoAvance.Fin = DateTime.Today;

            //oUsuarioCursoAvanceService.ActualizarUsuarioCursoAvance(oUsuarioCursoAvance);

        }
        private void btnReporte_Click(object sender, EventArgs e)
        {
            AvanceCursoUsuario avance = new AvanceCursoUsuario(idCurso,idUsuario);
            avance.ShowDialog();
            

        }



        private void dgvUsuarioCursoAvance_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsuarioCursoAvance_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvUsuarioCursoAvance.Columns[e.ColumnIndex].Name == "Finalizado")
            {
                if (e.Value is true)
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White;
                 
                }
                else
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
            if (e.ColumnIndex == 1)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Si" : "No";
                    e.FormattingApplied = true;
                    

                }
            }
        }
    }
}
