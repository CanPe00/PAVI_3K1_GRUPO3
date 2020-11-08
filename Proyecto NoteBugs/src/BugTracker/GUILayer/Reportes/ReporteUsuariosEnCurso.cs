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
    public partial class ReporteUsuariosEnCurso : Form
    {
        public int idCurso;
        
        
        public ReporteUsuariosEnCurso(int idCurso)
        {
            this.idCurso = idCurso;
        
            InitializeComponent();
        }

        private void ReporteUsuariosEnCurso_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Usuarios' Puede moverla o quitarla según sea necesario.
            
            
            //this.usuariosEnCursoTableAdapter.Fill(this.dataSet1.UsuariosEnCurso, idCurso);
            //this.reportViewer1.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataManager oDm = new DataManager();
            oDm.Open();
            string sql = "SELECT Usuarios.usuario, Usuarios.email, Perfiles.nombre, Cursos_1.nombre AS Expr1"+
                           " FROM Usuarios INNER JOIN UsuariosCurso ON Usuarios.id_usuario = UsuariosCurso.id_usuario INNER JOIN Cursos ON UsuariosCurso.id_curso = Cursos.id_curso INNER JOIN Perfiles ON Usuarios.id_perfil = Perfiles.id_perfil INNER JOIN Cursos AS Cursos_1 ON UsuariosCurso.id_curso = Cursos_1.id_curso" +
                           " WHERE (UsuariosCurso.id_curso =" + idCurso + ") AND (UsuariosCurso.borrado = 0) ";

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

        private void lblFecha_hasta_Click(object sender, EventArgs e)
        {

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
