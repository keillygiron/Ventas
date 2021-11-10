using BL.Pizzeria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class FormVentas : Form
    {
        contexto _contexto;
        double _subtotal;

        public FormVentas()
        {
            InitializeComponent();

            _contexto = new contexto();
            CargarProductos();
        }

        private void CargarProductos()
        {
            int x = 10;
            int y = 20;
            int contador = 1;

            foreach (var producto in _contexto.Productos)
            {
                Button btn = new Button();
                btn.Text = producto.Descripción;
                btn.Tag = producto.Precio;
                btn.Location = new Point(x, y);
                btn.Width = 130;

               // btn.Click += button_Click;

                x += 150;

                groupBox1.Controls.Add(btn);

                if (contador >= 5)
                {
                    contador = 1;
                     y += 50;
                     x = 10;
                }
                else
                {
                    contador++;
                }
            }
        }

        /*private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            ListViewItem item = new ListViewItem();
            item.Text = btn.Text;
            item.SubItems.Add(btn.Tag.ToString());

            listView1.Items.Add(item);

            _subtotal += double.Parse(btn.Tag.ToString());

            label7.Text = _subtotal.ToString();
            label3.Text = (_subtotal * 0.15).ToString();
            label4.Text = ((_subtotal * 0.15) + _subtotal).ToString();
        }*/

        private void label2_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nuevo();
            _subtotal += 0;
        }

        private void Nuevo()
        {
            listView1.Items.Clear();
            label7.Text = "0.00";
            label3.Text = "0.00";
            label4.Text = "0.00";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Factura f = new Factura();
            f.ClienteId = 1;
            f.Subtotal = double.Parse(label7.Text);
            f.Impuesto = double.Parse(label3.Text);
            f.Total = double.Parse(label4.Text);
            f.Fecha = DateTime.Now;

            foreach (var item in listView1.Items)
            {
                FacturaDetalle d = new FacturaDetalle();
                d.ProductoId = 1;
                d.Precio = 1;
                d.Subtotal = 0;

                f.Detalle.Add(d);
            }

            _contexto.Facturas.Add(f);
            _contexto.SaveChanges();

            MessageBox.Show("¡Factura guardada!");
            Nuevo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = "Pizza Pepperoni";
            item.SubItems.Add("115");

            listView1.Items.Add(item);

            Button btn = (Button)sender;

            _subtotal += 115;

            label7.Text = _subtotal.ToString();
            label3.Text = (_subtotal * 0.15).ToString();
            label4.Text = ((_subtotal * 0.15) + _subtotal).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = "Pizza Jamón";
            item.SubItems.Add("115");

            listView1.Items.Add(item);

            Button btn = (Button)sender;

            _subtotal += 115;

            label7.Text = _subtotal.ToString();
            label3.Text = (_subtotal * 0.15).ToString();
            label4.Text = ((_subtotal * 0.15) + _subtotal).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = "Pizza Hawaiana";
            item.SubItems.Add("140");

            listView1.Items.Add(item);

            Button btn = (Button)sender;

            _subtotal += 140;

            label7.Text = _subtotal.ToString();
            label3.Text = (_subtotal * 0.15).ToString();
            label4.Text = ((_subtotal * 0.15) + _subtotal).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = "Pizza Deluxe";
            item.SubItems.Add("180");

            listView1.Items.Add(item);

            Button btn = (Button)sender;

            _subtotal += 180;

            label7.Text = _subtotal.ToString();
            label3.Text = (_subtotal * 0.15).ToString();
            label4.Text = ((_subtotal * 0.15) + _subtotal).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = "Pan de ajo (4 unids)";
            item.SubItems.Add("60");

            listView1.Items.Add(item);

            Button btn = (Button)sender;

            _subtotal += 60;

            label7.Text = _subtotal.ToString();
            label3.Text = (_subtotal * 0.15).ToString();
            label4.Text = ((_subtotal * 0.15) + _subtotal).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = "Pan de ajo (6 unids)";
            item.SubItems.Add("90");

            listView1.Items.Add(item);

            Button btn = (Button)sender;

            _subtotal += 90;

            label7.Text = _subtotal.ToString();
            label3.Text = (_subtotal * 0.15).ToString();
            label4.Text = ((_subtotal * 0.15) + _subtotal).ToString();
        }
    }
}


