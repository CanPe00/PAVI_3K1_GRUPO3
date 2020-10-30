using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BugTracker.BusinessLayer;
using Microsoft.Reporting.WinForms;


namespace BugTracker.GUILayer.Reportes
{
    public partial class ListadoUsuarios : Form
    {
        private PerfilService oPerfilService;
        public ListadoUsuarios()
        {
            InitializeComponent();
            oPerfilService = new PerfilService();
        }

        private void ListadoUsuarios_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboPerfil, oPerfilService.ObtenerTodos(), "Nombre", "IdPerfil");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataManager oDm = new DataManager();
            oDm.Open();
     
            string sql = " SELECT U.id_usuario, P.nombre AS perfil, U.usuario, U.email FROM Usuarios AS U INNER JOIN Perfiles AS P ON U.id_perfil = P.id_perfil WHERE(U.borrado = 0) ";

            if (!chkTodos.Checked)
            {
                if (txtNombre.Text != string.Empty)
                {
                    sql += "AND U.usuario LIKE " + "'%" + txtNombre.Text.ToString() + "%'";
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", oDm.ConsultaSQL(sql)));
                    reportViewer1.RefreshReport();
                }

                if (cboPerfil.SelectedIndex != -1)
                {
                    sql += " AND P.id_perfil=" + cboPerfil.SelectedValue.ToString(); ;
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", oDm.ConsultaSQL(sql)));
                    reportViewer1.RefreshReport();
                }

                if (txtNombre.Text != string.Empty && cboPerfil.SelectedIndex != -1)
                {
                    sql += "AND U.usuario LIKE " + "'%" + txtNombre.Text.ToString() + "%' AND P.id_perfil=" + cboPerfil.SelectedValue.ToString();
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", oDm.ConsultaSQL(sql)));
                    reportViewer1.RefreshReport();
                }

                if (txtNombre.Text == string.Empty && cboPerfil.SelectedIndex == -1)
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

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                txtNombre.Enabled = false;
                cboPerfil.Enabled = false;
            }
            else
            {
                txtNombre.Enabled = true;
                cboPerfil.Enabled = true;
            }
        }

        private void btnReiniciarCombos_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            cboPerfil.SelectedIndex = -1; 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
