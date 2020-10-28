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
            reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
                new ReportParameter("prFechaDesde", dtpFecha_Desde.Value.ToString("dd/MM/yyyy")),
                new ReportParameter("prFechaHasta", dtpFecha_Hasta.Value.ToString("dd/MM/yyyy")) });

            this.cursosPorUsuarioTableAdapter.FillBy(this.dataSet1.CursosPorUsuario, idUsuario, dtpFecha_Desde.Value, dtpFecha_Hasta.Value);
            this.reportViewer1.RefreshReport();
            //dtpFecha_Desde.Value;
        }
    }
}
