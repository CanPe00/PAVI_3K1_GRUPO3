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
    public partial class EstadisticoCantUsuariosCursos : Form
    {
        public EstadisticoCantUsuariosCursos()
        {
            InitializeComponent();
        }

        private void EstadisticoCantUsuariosCursos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.GraficoCursosTerminados' Puede moverla o quitarla según sea necesario.
            //this.graficoCursosTerminadosTableAdapter.Fill(this.dataSet1.GraficoCursosTerminados);


            //this.reportViewer1.RefreshReport();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            this.estadisticoUsuariosCursosTableAdapter.Fill(this.dataSet1.EstadisticoUsuariosCursos, dtpFechaDesde.Value, dtpFechaHasta.Value);
           
            this.reportViewer1.RefreshReport();
        }
    }
}
