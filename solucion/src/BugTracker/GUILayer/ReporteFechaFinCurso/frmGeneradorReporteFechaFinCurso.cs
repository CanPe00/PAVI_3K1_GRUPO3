using System;
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

            if (chkTodos.Checked)
            {
                this.dataTable1TableAdapter.FillBy(this.dataSet1.DataTable1);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                if ((cbcCurso.SelectedIndex == -1) && (cbcUsuario.SelectedIndex == -1) && (!chkTodos.Checked))
                {
                    this.dataTable1TableAdapter.FillByFechas(this.dataSet1.DataTable1, dtpFechaDesde.Value, dtpFechaHasta.Value);
                    this.reportViewer1.RefreshReport();
                }

                else
                {
                    if ((cbcCurso.SelectedIndex == -1) && (cbcUsuario.SelectedIndex != -1) && (!chkTodos.Checked))
                    {
                        this.dataTable1TableAdapter.FillBy1(this.dataSet1.DataTable1, dtpFechaDesde.Value, dtpFechaHasta.Value, Convert.ToInt32(cbcUsuario.SelectedValue));
                        this.reportViewer1.RefreshReport();
                    }

                    else
                    {
                        if ((cbcUsuario.SelectedIndex == -1) && (cbcCurso.SelectedIndex != -1) && (!chkTodos.Checked))
                        {
                            this.dataTable1TableAdapter.FillBy2(this.dataSet1.DataTable1, dtpFechaDesde.Value, dtpFechaHasta.Value, Convert.ToInt32(cbcCurso.SelectedValue));
                            this.reportViewer1.RefreshReport();
                        }

                        else
                        {
                            this.dataTable1TableAdapter.FillTodos(this.dataSet1.DataTable1, dtpFechaDesde.Value, dtpFechaHasta.Value, Convert.ToInt32(cbcUsuario.SelectedValue), Convert.ToInt32(cbcCurso.SelectedValue));
                            this.reportViewer1.RefreshReport();
                        }
                    }
                }
                
            }
        }

        private void frmGeneradorReporteFechaFinCurso_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.DataTable1' Puede moverla o quitarla según sea necesario.
            
            LlenarCombo(cbcCurso, oCursoService.ObtenerTodos(), "nombre", "id_curso");
            LlenarCombo(cbcUsuario, oUsuarioService.ObtenerTodos(), "nombreUsuario", "idUsuario");
            

            
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {

        }

        

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                cbcCurso.Enabled = false;
                cbcUsuario.Enabled = false;
                dtpFechaHasta.Enabled = false;
                dtpFechaDesde.Enabled = false;
                cbcCurso.SelectedIndex = -1;
                cbcUsuario.SelectedIndex = -1;
                dtpFechaDesde.Value = Convert.ToDateTime("17/10/2020 12:16");
                dtpFechaHasta.Value = Convert.ToDateTime("17/10/2020 12:16");
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
            gra.FechaDesde = dtpFechaDesde.Value; 
            gra.FechaHasta = dtpFechaHasta.Value;
            gra.Curso = Convert.ToInt32(cbcCurso.SelectedValue);
            gra.Usuario = Convert.ToInt32(cbcUsuario.SelectedValue);
            gra.ShowDialog();
        }
    }
}
