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

        public Grafico()
        {
            InitializeComponent();
        }

        private void Grafico_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.GraficoCursosTerminados' Puede moverla o quitarla según sea necesario.
            frmGeneradorReporteFechaFinCurso rep = new frmGeneradorReporteFechaFinCurso();


            //this.graficoCursosTerminadosTableAdapter.FillByUsuario(this.dataSet1.GraficoCursosTerminados, FechaDesde, FechaHasta, Usuario);
            reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
                new ReportParameter("prFechaDesde", "Período Desde: " + FechaDesde.ToString("dd/MM/yyyy")),
                new ReportParameter("prFechaHasta", "  Hasta: " + FechaHasta.ToString("dd/MM/yyyy")) });


            if ((Curso == 0) && (Usuario == 0) && !rep.chkTodos.Checked)
            {
                this.graficoCursosTerminadosTableAdapter.FillByFecha(this.dataSet1.GraficoCursosTerminados, FechaDesde, FechaHasta);
                this.reportViewer1.RefreshReport();
            }
            
            if ((Curso == 0) && (Usuario > 0))
            {
                this.graficoCursosTerminadosTableAdapter.FillByUsuario(this.dataSet1.GraficoCursosTerminados, FechaDesde, FechaHasta, Usuario);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                if ((Curso > 0) && (Usuario == 0))
                {
                    this.graficoCursosTerminadosTableAdapter.FillByCurso(this.dataSet1.GraficoCursosTerminados, FechaDesde, FechaHasta, Curso);
                    this.reportViewer1.RefreshReport();
                }

                else
                {
                    if ((Curso > 0) && (Usuario > 0))
                    {
                        this.graficoCursosTerminadosTableAdapter.FillBy(this.dataSet1.GraficoCursosTerminados, FechaDesde, FechaHasta, Usuario, Curso);
                        this.reportViewer1.RefreshReport();
                    }

                    else
                    {
                        if ((Curso == 0) && (Usuario == 0) && (FechaDesde != FechaHasta))
                        {
                            this.graficoCursosTerminadosTableAdapter.FillByFecha(this.dataSet1.GraficoCursosTerminados, FechaDesde, FechaHasta);
                            this.reportViewer1.RefreshReport();

                        }

                        else
                        {
                            this.graficoCursosTerminadosTableAdapter.Fill(this.dataSet1.GraficoCursosTerminados);
                            this.reportViewer1.RefreshReport();
                            reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
                            new ReportParameter("prFechaDesde", " "),
                            new ReportParameter("prFechaHasta", " ") });

                        }
                        
                    }
                    
                }
                
                
            }


        }

    }
}
