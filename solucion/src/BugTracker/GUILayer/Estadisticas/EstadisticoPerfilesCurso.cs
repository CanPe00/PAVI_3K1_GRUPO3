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
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.EstadisticoPerfilesEnCursos' Puede moverla o quitarla según sea necesario.
            //this.estadisticoPerfilesEnCursosTableAdapter.Fill(this.dataSet1.EstadisticoPerfilesEnCursos, dtpFechaDesde.Value, dtpFechaHasta.Value);

           // this.reportViewer1.RefreshReport();
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            //reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
            //    new ReportParameter("prFecha_Desde", dtpFechaDesde.Value.ToString("dd/MM/yyyy")),
            //    new ReportParameter("prFechaHasta", dtpFechaHasta.Value.ToString("dd/MM/yyyy")) });

            this.estadisticoPerfilesEnCursosTableAdapter.Fill(this.dataSet1.EstadisticoPerfilesEnCursos, dtpFechaDesde.Value, dtpFechaHasta.Value);
          
            this.reportViewer1.RefreshReport();
        }
    }
}
