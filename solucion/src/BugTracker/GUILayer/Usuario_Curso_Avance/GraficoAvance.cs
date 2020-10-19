using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker.GUILayer.Usuario_Curso_Avance
{
    public partial class GraficoAvance : Form
    {
        public int idCurso;
        public int idUsuario;
        public GraficoAvance(int idCurso, int idUsuario)
        {
            InitializeComponent();
            this.idCurso = idCurso;
            this.idUsuario = idUsuario;
        }

        private void GraficoAvance_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
