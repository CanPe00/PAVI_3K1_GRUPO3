using BugTracker.DataSet1TableAdapters;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BugTracker.GUILayer.NewFolder1
{
    public partial class EstadisticoCantUsuariosCursos : Form
    {
        public EstadisticoCantUsuariosCursos()
        {
            InitializeComponent();
        }

        private void EstadisticoCantUsuariosCursos_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {

            DataManager oDm = new DataManager();
            oDm.Open();

            // SELECT Count(usuario) , cursos.nombre as 'Curso'
            //FROM Usuarios INNER JOIN UsuariosCurso ON Usuarios.id_usuario = UsuariosCurso.id_usuario INNER JOIN Cursos ON UsuariosCurso.id_curso = Cursos.id_curso
            //WHERE(UsuariosCurso.borrado = 0) AND(UsuariosCurso.fecha_inicio BETWEEN @fecha_inicio AND @fecha_fin)
            //GROUP BY Cursos.nombre
            //ORDER BY Count(usuario)

            string sql = " SELECT Count(usuario) , cursos.nombre as 'Curso' " +
                        " FROM Usuarios INNER JOIN UsuariosCurso ON Usuarios.id_usuario = UsuariosCurso.id_usuario INNER JOIN Cursos ON UsuariosCurso.id_curso = Cursos.id_curso " +
                        " WHERE(UsuariosCurso.borrado = 0) ";


            if (chkTodos.Checked)
            {
                sql += " GROUP BY Cursos.nombre " +
                        " ORDER BY Count(usuario) ";

                reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
                new ReportParameter("prFechaDesde", " "),
                new ReportParameter("prFechaHasta", " ") });

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", oDm.ConsultaSQL(sql)));
                reportViewer1.RefreshReport();
            }

            else
            {
                if (dtpFechaDesde.Value > dtpFechaHasta.Value)
                {
                    MessageBox.Show("Fechas erróneas, por favor ingrese fechas válidas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
                    dtpFechaDesde.Focus();
                    return;
                }

                else
                {
                    sql += " AND (UsuariosCurso.fecha_inicio BETWEEN '" + dtpFechaDesde.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "') " +
                        " GROUP BY Cursos.nombre " +
                        " ORDER BY Count(usuario) ";

                    reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
                    new ReportParameter("prFechaDesde", "Período Desde: " + dtpFechaDesde.Value.ToString("dd/MM/yyyy")),
                    new ReportParameter("prFechaHasta", "  Hasta: " + dtpFechaHasta.Value.ToString("dd/MM/yyyy")) });

                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", oDm.ConsultaSQL(sql)));
                    reportViewer1.RefreshReport();
                }
            }

            //reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
            //    new ReportParameter("prFechaDesde", dtpFechaDesde.Value.ToString("dd/MM/yyyy")),
            //    new ReportParameter("prFechaHasta", dtpFechaHasta.Value.ToString("dd/MM/yyyy")) });

            //this.estadisticoUsuariosCursosTableAdapter.Fill(this.dataSet1.EstadisticoUsuariosCursos, dtpFechaDesde.Value, dtpFechaHasta.Value);

            //this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                dtpFechaDesde.Enabled = false;
                dtpFechaHasta.Enabled = false;
            }
            else
            {
                dtpFechaDesde.Enabled = true;
                dtpFechaHasta.Enabled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
