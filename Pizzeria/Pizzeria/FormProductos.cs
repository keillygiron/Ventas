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
    public partial class FormProductos : Form
    {
        ProductosBL _productos;

        public FormProductos()
        {
            InitializeComponent();

            _productos = new ProductosBL();
            listaProductosBindingSource.DataSource = _productos.ObtenerProductos();
        }

        private void listaProductosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void activoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
