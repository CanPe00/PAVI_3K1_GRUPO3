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
    public partial class ListadoActividades : Form
    {
        public ListadoActividades()
        {
            InitializeComponent();
        }

        private void ListadoActividades_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Actividades' Puede moverla o quitarla según sea necesario.
            this.actividadesTableAdapter.Fill(this.dataSet1.Actividades);

            this.reportViewer1.RefreshReport();
        }
    }
}
