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

namespace BugTracker.GUILayer.Reportes
{
    public partial class ReporteCursosPorUsuario : Form
    {
        public int idUsuario;
        public ReporteCursosPorUsuario(int idUsuario)
        {
            this.idUsuario = idUsuario;
            InitializeComponent();
        }

        private void ReporteCursosPorUsuario_Load(object sender, EventArgs e)
        {
            //this.cursosPorUsuarioTableAdapter.Fill(this.dataSet1.CursosPorUsuario, idUsuario);
            //this.reportViewer1.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
            DataManager oDm = new DataManager();
            oDm.Open();
            string sql = "SELECT Cursos.nombre, Cursos.descripcion, Categorias.nombre AS Expr1, Usuarios.usuario" +
                        " FROM UsuariosCurso INNER JOIN Cursos ON UsuariosCurso.id_curso = Cursos.id_curso INNER JOIN Categorias ON Cursos.id_categoria = Categorias.id_categoria INNER JOIN Usuarios ON UsuariosCurso.id_usuario = Usuarios.id_usuario" +
                        " WHERE (UsuariosCurso.id_usuario = " + idUsuario + ") AND(UsuariosCurso.borrado = 0)";

            if (chkTodos.Checked)
            {
                reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
                new ReportParameter("prFechaDesde", " "),
                new ReportParameter("prFechaHasta", " ") });

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", oDm.ConsultaSQL(sql)));
                reportViewer1.RefreshReport();
            }
            else
            {
                // AND(UsuariosCurso.fecha_inicio BETWEEN @fecha_inicio AND @fecha_fin)
                sql += " AND (UsuariosCurso.fecha_inicio BETWEEN '" + dtpFecha_Desde.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpFecha_Hasta.Value.ToString("yyyy-MM-dd") + "')";
                reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
                new ReportParameter("prFechaDesde", dtpFecha_Desde.Value.ToString("dd/MM/yyyy")),
                new ReportParameter("prFechaHasta", dtpFecha_Hasta.Value.ToString("dd/MM/yyyy")) });

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", oDm.ConsultaSQL(sql)));
                reportViewer1.RefreshReport();

            }
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                dtpFecha_Desde.Enabled = false;
                dtpFecha_Hasta.Enabled = false;
            }
            else
            {
                dtpFecha_Desde.Enabled = true;
                dtpFecha_Hasta.Enabled = true;
            }
        }
    }
}
