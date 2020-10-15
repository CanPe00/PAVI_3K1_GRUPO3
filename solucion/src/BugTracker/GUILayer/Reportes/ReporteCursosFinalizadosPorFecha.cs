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
    public partial class ReporteCursosFinalizadosPorFecha : Form
    {
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public ReporteCursosFinalizadosPorFecha()
        {
            InitializeComponent();
        }

        private void ReporteCursosFinalizadosPorFecha_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.DataTable1' Puede moverla o quitarla según sea necesario.
            this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1,FechaDesde,FechaHasta);

            this.reportViewer1.RefreshReport();
        }
    }
}
