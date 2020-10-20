﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace BugTracker.GUILayer.Estadisticas
{
    public partial class EstadisticoCategoriasCursos : Form
    {
        public EstadisticoCategoriasCursos()
        {
            InitializeComponent();
        }

        private void EstadisticoCategoriasCursos_Load(object sender, EventArgs e)
        {
            chkTodos.Checked = true;
            btnGrafico_Click(sender, e);
            this.reportViewer1.RefreshReport();
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            DataManager oDm = new DataManager();
            oDm.Open();
            string sql = " SELECT COUNT(CA.id_categoria) AS Cantidad, CA.nombre AS Nombre " +
                        " FROM  Cursos C JOIN Categorias CA ON C.id_categoria = CA.id_categoria " +
                        " WHERE (C.borrado = 0) AND (CA.borrado = 0) ";

            if (chkTodos.Checked)
            {
                sql += " GROUP BY CA.id_categoria, CA.nombre ";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", oDm.ConsultaSQL(sql)));
                reportViewer1.RefreshReport();

            }

            else
            {
                if (dtpFechaDesde.Value > dtpFechaHasta.Value)
                {
                    MessageBox.Show("Fechas erroneas!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
                    dtpFechaDesde.Focus();
                    return;
                }
                else
                {
                    sql += " AND (C.fecha_vigencia BETWEEN '" + dtpFechaDesde.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "'" +
                        ") GROUP BY CA.id_categoria, CA.nombre ";
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", oDm.ConsultaSQL(sql)));
                    reportViewer1.RefreshReport();
                }
            }
            
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                dtpFechaDesde.Enabled = false;
                dtpFechaHasta.Enabled = false;
            }
            else
            {
                dtpFechaDesde.Enabled = true;
                dtpFechaHasta.Enabled = true;
            }
            
        }
    }
}