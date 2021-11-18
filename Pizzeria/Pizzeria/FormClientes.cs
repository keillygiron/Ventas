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
    public partial class FormClientes : Form
    {
        contexto _contexto;

        public FormClientes()
        {
            InitializeComponent();

            _contexto = new contexto();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = new Cliente();
            nuevoCliente.Nombre = textBox1.Text;

            _contexto.Clientes.Add(nuevoCliente);
            _contexto.SaveChanges();

            MessageBox.Show("¡Cliente creado!");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
