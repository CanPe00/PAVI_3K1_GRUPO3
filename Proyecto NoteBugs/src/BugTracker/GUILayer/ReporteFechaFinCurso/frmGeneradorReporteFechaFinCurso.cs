﻿using System;
using BugTracker.BusinessLayer;
using BugTracker.GUILayer.Reportes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BugTracker.Entities;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Reporting.WinForms;

namespace BugTracker.GUILayer.ReporteFechaFinCurso
{
    public partial class frmGeneradorReporteFechaFinCurso : Form
    {
        

        private CursoService oCursoService;

        private UsuarioService oUsuarioService;
        public frmGeneradorReporteFechaFinCurso()
        {
            InitializeComponent();
            oCursoService = new CursoService();
            oUsuarioService = new UsuarioService();
        }
        
        
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DataManager oDm = new DataManager();
            oDm.Open();
            string sql = " SELECT U.usuario, C.nombre, CAST(UC.fecha_inicio AS Date) AS fecha_inicio, CAST(UC.fecha_fin AS Date) AS fecha_fin " +
                        " FROM UsuariosCurso AS UC INNER JOIN Usuarios AS U ON UC.id_usuario = U.id_usuario INNER JOIN Cursos AS C ON UC.id_curso = C.id_curso " +
                        " WHERE(UC.fecha_fin IS NOT NULL) ";


            if (chkTodo.Checked)
            {
                //this.dataTable1TableAdapter.FillBy(this.dataSet1.DataTable1);
                //this.reportViewer1.RefreshReport();
                reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
                        new ReportParameter("prFechaDesde", " "),
                        new ReportParameter("prFechaHasta", " ") });
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", oDm.ConsultaSQL(sql)));
                reportViewer1.RefreshReport();
            }
        

            else
            {
                if (dtpFechaDesde.Value > dtpFechaHasta.Value)
                {
                    MessageBox.Show("Fechas erróneas, por favor ingrese fechas válidas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
                    dtpFechaDesde.Focus();
                    return;
                }

                else
                {
                    if ((cbcCurso.SelectedIndex == -1) && (cbcUsuario.SelectedIndex == -1) && (!chkTodo.Checked))
                    {
                        //this.dataTable1TableAdapter.FillByFechas(this.dataSet1.DataTable1, dtpFechaDesde.Value, dtpFechaHasta.Value);
                        //this.reportViewer1.RefreshReport();
                        sql += " AND (UC.fecha_fin BETWEEN '" + dtpFechaDesde.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpFechaHasta.Value.ToString("yyyy-MM-dd")  + "')  ";

                        reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
                            new ReportParameter("prFechaDesde", "Período Desde: " + dtpFechaDesde.Value.ToString("dd/MM/yyyy")),
                            new ReportParameter("prFechaHasta", "  Hasta: " + dtpFechaHasta.Value.ToString("dd/MM/yyyy")) });


                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", oDm.ConsultaSQL(sql)));
                        reportViewer1.RefreshReport();


                    }

                    else
                    {
                        if ((cbcCurso.SelectedIndex == -1) && (cbcUsuario.SelectedIndex != -1) && (!chkTodo.Checked))
                        {
                            //this.dataTable1TableAdapter.FillBy1(this.dataSet1.DataTable1, dtpFechaDesde.Value, dtpFechaHasta.Value, Convert.ToInt32(cbcUsuario.SelectedValue));
                            //this.reportViewer1.RefreshReport();

                            sql += " AND (UC.fecha_fin BETWEEN '" + dtpFechaDesde.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "') AND (U.id_usuario = " + Convert.ToInt32(cbcUsuario.SelectedValue) + ") ";

                            reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
                            new ReportParameter("prFechaDesde", "Período Desde: " + dtpFechaDesde.Value.ToString("dd/MM/yyyy")),
                            new ReportParameter("prFechaHasta", "  Hasta: " + dtpFechaHasta.Value.ToString("dd/MM/yyyy")) });


                            reportViewer1.LocalReport.DataSources.Clear();
                            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", oDm.ConsultaSQL(sql)));
                            reportViewer1.RefreshReport();
                        }

                        else
                        {
                            if ((cbcUsuario.SelectedIndex == -1) && (cbcCurso.SelectedIndex != -1) && (!chkTodo.Checked))
                            {
                                //this.dataTable1TableAdapter.FillBy2(this.dataSet1.DataTable1, dtpFechaDesde.Value, dtpFechaHasta.Value, Convert.ToInt32(cbcCurso.SelectedValue));
                                //this.reportViewer1.RefreshReport();

                                sql += " AND (UC.fecha_fin BETWEEN '" + dtpFechaDesde.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "') AND (C.id_curso = " + Convert.ToInt32(cbcCurso.SelectedValue) + ") ";

                                reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
                                    new ReportParameter("prFechaDesde", "Período Desde: " + dtpFechaDesde.Value.ToString("dd/MM/yyyy")),
                                    new ReportParameter("prFechaHasta", "  Hasta: " + dtpFechaHasta.Value.ToString("dd/MM/yyyy")) });


                                reportViewer1.LocalReport.DataSources.Clear();
                                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", oDm.ConsultaSQL(sql)));
                                reportViewer1.RefreshReport();
                            }

                            else
                            {
                                sql += " AND (UC.fecha_fin BETWEEN '" + dtpFechaDesde.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "') AND (C.id_curso = " + Convert.ToInt32(cbcCurso.SelectedValue) + ") AND (U.id_usuario = " + Convert.ToInt32(cbcUsuario.SelectedValue) + ") ";

                                reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
                                    new ReportParameter("prFechaDesde", "Período Desde: " + dtpFechaDesde.Value.ToString("dd/MM/yyyy")),
                                    new ReportParameter("prFechaHasta", "  Hasta: " + dtpFechaHasta.Value.ToString("dd/MM/yyyy")) });


                                reportViewer1.LocalReport.DataSources.Clear();
                                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", oDm.ConsultaSQL(sql)));
                                reportViewer1.RefreshReport();

                                //this.dataTable1TableAdapter.FillTodos(this.dataSet1.DataTable1, dtpFechaDesde.Value, dtpFechaHasta.Value, Convert.ToInt32(cbcUsuario.SelectedValue), Convert.ToInt32(cbcCurso.SelectedValue));
                                //this.reportViewer1.RefreshReport();
                            }
                        }
                    }
                }

            }

            //if (!chkTodo.Checked)
            //{
            //    reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
            //    new ReportParameter("prFechaDesde", "Período Desde: " + dtpFechaDesde.Value.ToString("dd/MM/yyyy")),
            //    new ReportParameter("prFechaHasta", "  Hasta: " + dtpFechaHasta.Value.ToString("dd/MM/yyyy")) });
            //}

            //else
            //{
            //    reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
            //    new ReportParameter("prFechaDesde", " "),
            //    new ReportParameter("prFechaHasta", " ") });
            //}
        }

        private void frmGeneradorReporteFechaFinCurso_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.DataTable1' Puede moverla o quitarla según sea necesario.
            
            LlenarCombo(cbcCurso, oCursoService.ObtenerTodos(), "nombre", "id_curso");
            LlenarCombo(cbcUsuario, oUsuarioService.ObtenerTodos(), "nombreUsuario", "idUsuario");
            reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
                new ReportParameter("prFechaDesde", " "),
                new ReportParameter("prFechaHasta", " ") });



        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {

        }

        

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodo.Checked)
            {
                cbcCurso.Enabled = false;
                cbcUsuario.Enabled = false;
                dtpFechaHasta.Enabled = false;
                dtpFechaDesde.Enabled = false;
                //cbcCurso.SelectedIndex = -1;
                //cbcUsuario.SelectedIndex = -1;
                //dtpFechaDesde.Value = Convert.ToDateTime("17/10/2020 12:16");
                //dtpFechaHasta.Value = Convert.ToDateTime("17/10/2020 12:16");
                //btnGrafico.Enabled = true;

            }
            else 
            {
                cbcCurso.Enabled = true;
                cbcUsuario.Enabled = true;
                dtpFechaHasta.Enabled = true;
                dtpFechaDesde.Enabled = true;
                //btnGrafico.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Grafico gra = new Grafico();
            gra.Todos = chkTodo.Checked;
            gra.FechaDesde = dtpFechaDesde.Value; 
            gra.FechaHasta = dtpFechaHasta.Value;
            gra.Curso = Convert.ToInt32(cbcCurso.SelectedValue);
            gra.Usuario = Convert.ToInt32(cbcUsuario.SelectedValue);

            if ((dtpFechaDesde.Value > dtpFechaHasta.Value) && !chkTodo.Checked)
            {
                MessageBox.Show("Fechas erróneas, por favor ingrese fechas válidas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
                dtpFechaDesde.Focus();
                return;
            }
            else
            {
                gra.ShowDialog();
            }
                
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnReiniciarCombos_Click(object sender, EventArgs e)
        {
            cbcCurso.SelectedIndex = -1;
            cbcUsuario.SelectedIndex = -1;
             
            frmGeneradorReporteFechaFinCurso_Load(sender, e);
        }
    }
}
