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
    public partial class EstadisticoPerfilesCurso : Form
    {
        public EstadisticoPerfilesCurso()
        {
            InitializeComponent();
        }

        private void EstadisticoPerfilesCurso_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {

            DataManager oDm = new DataManager();
            oDm.Open();
            string sql = " SELECT COUNT(Usuarios.usuario) AS Expr1, Perfiles.nombre AS Perfil_usuario, Cursos.nombre AS 'Curso' " +
                        " FROM UsuariosCurso INNER JOIN Usuarios ON UsuariosCurso.id_usuario = Usuarios.id_usuario INNER JOIN Perfiles ON Usuarios.id_perfil = Perfiles.id_perfil INNER JOIN Cursos ON UsuariosCurso.id_curso = Cursos.id_curso " +
                        " WHERE(UsuariosCurso.borrado = 0) ";


            if (chkTodos.Checked)
            {
                sql += " GROUP BY Perfiles.nombre, Cursos.nombre" +
                        " ORDER BY COUNT(Usuarios.usuario)";

                reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
                new ReportParameter("prFecha_Desde", " "),
                new ReportParameter("prFechaHasta", " ") });

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", oDm.ConsultaSQL(sql)));
                reportViewer1.RefreshReport();
            }

            else
            {
                if (dtpFecha_Desde.Value > dtpFechaHasta.Value)
                {
                    MessageBox.Show("Fechas erróneas, por favor ingrese fechas válidas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
                    dtpFecha_Desde.Focus();
                    return;
                }

                else
                {
                    sql += " AND (UsuariosCurso.fecha_inicio BETWEEN '" + dtpFecha_Desde.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "')" +
                        " GROUP BY Perfiles.nombre, Cursos.nombre" +
                        " ORDER BY COUNT(Usuarios.usuario)";

                    reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
                    new ReportParameter("prFecha_Desde", "Período Desde: " + dtpFecha_Desde.Value.ToString("dd/MM/yyyy")),
                    new ReportParameter("prFechaHasta", "  Hasta: " + dtpFechaHasta.Value.ToString("dd/MM/yyyy")) });

                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", oDm.ConsultaSQL(sql)));
                    reportViewer1.RefreshReport();
                }
            }

            //reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
            //    new ReportParameter("prFecha_Desde", dtpFecha_Desde.Value.ToString("dd/MM/yyyy")),
            //    new ReportParameter("prFechaHasta", dtpFechaHasta.Value.ToString("dd/MM/yyyy")) });

            //this.estadisticoPerfilesEnCursosTableAdapter.Fill(this.dataSet1.EstadisticoPerfilesEnCursos, dtpFecha_Desde.Value, dtpFechaHasta.Value);

            //this.reportViewer1.RefreshReport();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                dtpFecha_Desde.Enabled = false;
                dtpFechaHasta.Enabled = false;
            }
            else
            {
                dtpFecha_Desde.Enabled = true;
                dtpFechaHasta.Enabled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
