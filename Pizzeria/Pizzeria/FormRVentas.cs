using BL.Pizzeria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class FormRVentas : Form
    {
        public FormRVentas()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            var _facturasBL = new FacturaBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _facturasBL.ObtenerFacturas();

            var reporte = new ReporteVentas();
            reporte.SetDataSource(bindingSource);


            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();

        }
    }
}
