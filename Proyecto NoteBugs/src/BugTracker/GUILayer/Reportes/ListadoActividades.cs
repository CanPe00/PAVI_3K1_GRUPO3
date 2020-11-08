using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

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

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataManager oDm = new DataManager();
            oDm.Open();

            string sql = " SELECT id_actividad, nombre, descripcion FROM Actividades WHERE (borrado = 0) ";

            if (!chkTodos.Checked)
            {
                if (txtActividad.Text != string.Empty)
                {
                    sql += "AND nombre LIKE " + "'%" + txtActividad.Text.ToString() + "%'";
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", oDm.ConsultaSQL(sql)));
                    reportViewer1.RefreshReport();
                }

                if (txtActividad.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar al menos un criterio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", oDm.ConsultaSQL(sql)));
                reportViewer1.RefreshReport();
            }
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                txtActividad.Enabled = false;
            }
            else
            {
                txtActividad.Enabled = true;
            }
        }

        private void btnReiniciarCombos_Click(object sender, EventArgs e)
        {
            txtActividad.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
