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

namespace BugTracker.GUILayer.ReporteFechaFinCurso
{
    public partial class Grafico : Form
    {
        public DateTime FechaDesde { get; set; } 
        public DateTime FechaHasta { get; set; }
        public int Usuario { get; set; }
        public int Curso { get; set; }
        public bool Todos { get; set; }

        public Grafico()
        {
            InitializeComponent();
        }

        private void Grafico_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.GraficoCursosTerminados' Puede moverla o quitarla según sea necesario.
            


            //this.graficoCursosTerminadosTableAdapter.FillByUsuario(this.dataSet1.GraficoCursosTerminados, FechaDesde, FechaHasta, Usuario);
            //reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
            //    new ReportParameter("prFechaDesde", "Período Desde: " + FechaDesde.ToString("dd/MM/yyyy")),
            //    new ReportParameter("prFechaHasta", "  Hasta: " + FechaHasta.ToString("dd/MM/yyyy")) });

            //SELECT UC.id_curso, C.nombre, COUNT(UC.id_curso) AS Terminados
            //FROM UsuariosCurso AS UC INNER JOIN Cursos AS C ON UC.id_curso = C.id_curso INNER JOIN Usuarios AS U ON UC.id_usuario = U.id_usuario
            //WHERE(UC.fecha_fin IS NOT NULL) AND(UC.borrado = 1)
            //GROUP BY UC.id_curso, C.nombre
            //ORDER BY COUNT(UC.id_curso)
            
            DataManager oDm = new DataManager();
            oDm.Open();
            string sql = " SELECT UC.id_curso, C.nombre, COUNT(UC.id_curso) AS Terminados " +
                        " FROM UsuariosCurso AS UC INNER JOIN Cursos AS C ON UC.id_curso = C.id_curso INNER JOIN Usuarios AS U ON UC.id_usuario = U.id_usuario " +
                        " WHERE(UC.fecha_fin IS NOT NULL) AND (UC.borrado = 1) ";
            
            if (Todos)
            {
                sql += " GROUP BY UC.id_curso, C.nombre " +
                       " ORDER BY COUNT(UC.id_curso) ";

                reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
                        new ReportParameter("prFechaDesde", " "),
                        new ReportParameter("prFechaHasta", " ") });

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", oDm.ConsultaSQL(sql)));
                reportViewer1.RefreshReport();
            }

            else
            {
                if ((Curso == 0) && (Usuario == 0))
                {
                    sql += " AND (UC.fecha_fin BETWEEN '" + FechaDesde.ToString("yyyy-MM-dd") + "' AND '" + FechaHasta.ToString("yyyy-MM-dd") + "')" +
                            " GROUP BY UC.id_curso, C.nombre " +
                            " ORDER BY COUNT(UC.id_curso) ";

                    reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
                            new ReportParameter("prFechaDesde", "Período Desde: " + FechaDesde.ToString("dd/MM/yyyy")),
                            new ReportParameter("prFechaHasta", "  Hasta: " + FechaHasta.ToString("dd/MM/yyyy")) });

                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", oDm.ConsultaSQL(sql)));
                    reportViewer1.RefreshReport();
                }

                else
                {
                    if ((Curso == 0) && (Usuario > 0))
                    {
                        sql += " AND (UC.fecha_fin BETWEEN '" + FechaDesde.ToString("yyyy-MM-dd") + "' AND '" + FechaHasta.ToString("yyyy-MM-dd") + "') AND (U.id_usuario = " +  Usuario + ") " +
                                " GROUP BY UC.id_curso, C.nombre " +
                                " ORDER BY COUNT(UC.id_curso) ";

                        reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
                            new ReportParameter("prFechaDesde", "Período Desde: " + FechaDesde.ToString("dd/MM/yyyy")),
                            new ReportParameter("prFechaHasta", "  Hasta: " + FechaHasta.ToString("dd/MM/yyyy")) });

                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", oDm.ConsultaSQL(sql)));
                        reportViewer1.RefreshReport();
                    }
                    else
                    {
                        if ((Curso > 0) && (Usuario == 0))
                        {
                            sql += " AND (UC.fecha_fin BETWEEN '" + FechaDesde.ToString("yyyy-MM-dd") + "' AND '" + FechaHasta.ToString("yyyy-MM-dd") + "') AND (C.id_curso = " + Curso + ") " +
                                " GROUP BY UC.id_curso, C.nombre " +
                                " ORDER BY COUNT(UC.id_curso) ";

                            reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
                            new ReportParameter("prFechaDesde", "Período Desde: " + FechaDesde.ToString("dd/MM/yyyy")),
                            new ReportParameter("prFechaHasta", "  Hasta: " + FechaHasta.ToString("dd/MM/yyyy")) });

                            reportViewer1.LocalReport.DataSources.Clear();
                            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", oDm.ConsultaSQL(sql)));
                            reportViewer1.RefreshReport();
                        }

                        else
                        {
                            sql += " AND (UC.fecha_fin BETWEEN '" + FechaDesde.ToString("yyyy-MM-dd") + "' AND '" + FechaHasta.ToString("yyyy-MM-dd") + "') AND (C.id_curso = " + Curso + ") AND (U.id_usuario = " + Usuario + ") " +
                                " GROUP BY UC.id_curso, C.nombre " +
                                " ORDER BY COUNT(UC.id_curso) ";

                            reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
                            new ReportParameter("prFechaDesde", "Período Desde: " + FechaDesde.ToString("dd/MM/yyyy")),
                            new ReportParameter("prFechaHasta", "  Hasta: " + FechaHasta.ToString("dd/MM/yyyy")) });

                            reportViewer1.LocalReport.DataSources.Clear();
                            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", oDm.ConsultaSQL(sql)));
                            reportViewer1.RefreshReport();
                        }

                        
                    }
                }
            }
        }
    }

    
}
