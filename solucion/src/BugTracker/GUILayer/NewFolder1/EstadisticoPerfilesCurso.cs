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

            this.reportViewer1.RefreshReport();
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            this.estadisticoPerfilesEnCursosTableAdapter.Fill(this.dataSet1.EstadisticoPerfilesEnCursos, dtpFechaDesde.Value, dtpFechaHasta.Value);
          
            this.reportViewer1.RefreshReport();
        }
    }
}
