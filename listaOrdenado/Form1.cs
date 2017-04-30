using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listaOrdenado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Inventario inventario = new Inventario();



        private void btnAgregarOrdenado_Click_1(object sender, EventArgs e)
        {
            bool agregado = inventario.buscarInicio(Convert.ToInt16(txtCodigo.Text));
            Producto producto = new Producto(Convert.ToInt16(txtCodigo.Text), txtNombre.Text, Convert.ToInt16(txtCantidad.Text), Convert.ToInt16(txtPrecio.Text));
            inventario.agregarOrdenado(producto);

            if (agregado == false)
            {
                MessageBox.Show("Producto guardado");
                txtReporte.Text = producto.ToString();
            }
            else
            {
                MessageBox.Show("Ese código ya existe");
                txtReporte.Text = "";
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            txtReporte.Text = inventario.reporte();
        }

        private void btnReporteVolteado_Click_1(object sender, EventArgs e)
        {
            txtReporte.Text = inventario.reporteVolteado();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            Producto buscado = inventario.buscarProducto(Convert.ToInt16(txtCodigoConsulta.Text));
            if (buscado != null)
            {
                txtReporte.Text = buscado.ToString();
            }
            else
                MessageBox.Show("Error, producto no encontrado");
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            Producto buscado = inventario.buscarProducto(Convert.ToInt16(txtCodigoConsulta.Text));
            if (buscado != null)
            {
            inventario.eliminarProducto(Convert.ToInt16(txtCodigoConsulta.Text));
            txtReporte.Text = "";
            MessageBox.Show("Producto eliminado");
            }
            else
                MessageBox.Show("Error, producto no encontrado");
        }

        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            bool agregado = inventario.buscarInicio(Convert.ToInt16(txtCodigo.Text));

            Producto producto = new Producto(Convert.ToInt16(txtCodigo.Text), txtNombre.Text, Convert.ToInt16(txtCantidad.Text), Convert.ToInt16(txtPrecio.Text));
            inventario.insertarPosicion(producto, Convert.ToInt16(txtPos.Text));

            if (agregado == false)
            {
                MessageBox.Show("Producto insertado");
                txtReporte.Text = producto.ToString();
            }
            else
            {
                MessageBox.Show("Ese código ya existe");
                txtReporte.Text = "";
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarInicio_Click(object sender, EventArgs e)
        {
            bool agregado = inventario.buscarInicio(Convert.ToInt16(txtCodigo.Text));
            Producto producto = new Producto(Convert.ToInt16(txtCodigo.Text), txtNombre.Text, Convert.ToInt16(txtCantidad.Text), Convert.ToInt16(txtPrecio.Text));
            inventario.agregarEnInicio(producto);

            if (agregado == false)
            {
                MessageBox.Show("Producto guardado");
                txtReporte.Text = producto.ToString();
            }
            else
            {
                MessageBox.Show("Ese código ya existe");
                txtReporte.Text = "";
            }
        }
    }
}