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
            reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
                new ReportParameter("prFecha_Desde", dtpFecha_Desde.Value.ToString("dd/MM/yyyy")),
                new ReportParameter("prFechaHasta", dtpFechaHasta.Value.ToString("dd/MM/yyyy")) });

            this.estadisticoPerfilesEnCursosTableAdapter.Fill(this.dataSet1.EstadisticoPerfilesEnCursos, dtpFecha_Desde.Value, dtpFechaHasta.Value);
          
            this.reportViewer1.RefreshReport();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
