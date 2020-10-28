using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace BugTracker.GUILayer.Reportes
{
    public partial class AvanceCursoUsuario : Form
    {
        public int idCurso;
        public int idUsuario;
        public int total2;
        public AvanceCursoUsuario(int idCurso,int idUsuario)
        {
            InitializeComponent();
            this.idCurso = idCurso;
            this.idUsuario = idUsuario;
        }

        private void AvanceCursoUsuario_Load(object sender, EventArgs e)
        {
            //this.avanceTableAdapter.Fill(this.dataSet1.Avance,idUsuario,idCurso);
            //this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
//            SELECT A.nombre, A.descripcion, UCA.finalizado, U.usuario,C.nombre
//            FROM            UsuariosCursoAvance AS UCA INNER JOIN Usuarios AS U ON UCA.id_usuario = U.id_usuario INNER JOIN Cursos AS C ON UCA.id_curso = C.id_curso INNER JOIN Actividades AS A ON UCA.id_actividad = A.id_actividad
//              WHERE (UCA.id_usuario = @id_usuario) AND (UCA.id_curso = @id_curso)

            DataManager oDm = new DataManager();
            oDm.Open();
            string sql = " SELECT A.nombre, A.descripcion, UCA.finalizado, U.usuario,C.nombre " +
                        " FROM UsuariosCursoAvance AS UCA INNER JOIN Usuarios AS U ON UCA.id_usuario = U.id_usuario INNER JOIN Cursos AS C ON UCA.id_curso = C.id_curso INNER JOIN Actividades AS A ON UCA.id_actividad = A.id_actividad " +
                        " WHERE (UCA.id_usuario = " + idUsuario + ") AND (UCA.id_curso = " + idCurso + ") ";

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
                sql += " AND (UCA.fin BETWEEN '" + dtpFechaDesde.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "')";
                reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
                new ReportParameter("prFechaDesde", dtpFechaDesde.Value.ToString("dd/MM/yyyy")),
                new ReportParameter("prFechaHasta", dtpFechaHasta.Value.ToString("dd/MM/yyyy")) });

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", oDm.ConsultaSQL(sql)));
                reportViewer1.RefreshReport();
            }
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
    }
}
