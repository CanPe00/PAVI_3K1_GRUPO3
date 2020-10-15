using System;
using BugTracker.GUILayer.Reportes;
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
    public partial class frmGeneradorReporteFechaFinCurso : Form
    {
        public frmGeneradorReporteFechaFinCurso()
        {
            InitializeComponent();
        }
        
        
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            ReporteCursosFinalizadosPorFecha rep = new ReporteCursosFinalizadosPorFecha();
            rep.FechaDesde = dtpFechaDesde.Value;
            rep.FechaHasta = dtpFechaHasta.Value;
            rep.ShowDialog();
        }

        private void frmGeneradorReporteFechaFinCurso_Load(object sender, EventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
