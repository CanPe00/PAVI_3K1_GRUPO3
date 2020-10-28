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
            reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
                new ReportParameter("prFechaDesde", dtpFecha_Desde.Value.ToString("dd/MM/yyyy")),
                new ReportParameter("prFechaHasta", dtpFecha_Hasta.Value.ToString("dd/MM/yyyy")) });

            this.usuariosEnCursoTableAdapter.FillBy(this.dataSet1.UsuariosEnCurso, idCurso, dtpFecha_Desde.Value, dtpFecha_Hasta.Value);
            this.reportViewer1.RefreshReport();
        }

        private void lblFecha_hasta_Click(object sender, EventArgs e)
        {

        }
    }
}
