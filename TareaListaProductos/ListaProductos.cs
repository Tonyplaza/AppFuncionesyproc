using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaListaProductos
{
    public partial class ListaProductos : Form
    {
        private List<Clase.ClaseLista> lista = new List<Clase.ClaseLista>();
        public ListaProductos()
        {
            InitializeComponent();
        }

        private void ListaProductos_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Clase.ClaseLista Productos = new Clase.ClaseLista();
            Productos.Codigo = this.txtCodigo.Text;
            Productos.NombreProducto = this.txtNombrePro.Text;
            Productos.PrecioVenta = Convert.ToDouble(this.txtPrecioVenta.Text);
            Productos.FechaCompra = Convert.ToDateTime(this.txtFechaCompra.Text);
            Productos.Unidad = Convert.ToInt32(this.txtUnidad.Text);

            lista.Add(Productos);
            //Mostrar los elementos en el ListView
            ListViewItem item = new ListViewItem(Productos.Codigo);
            listViewProductos.Items.Add(item);
            item.SubItems.Add(Productos.NombreProducto);
            item.SubItems.Add(Productos.PrecioVenta.ToString());
            item.SubItems.Add(Productos.FechaCompra.ToString());
            item.SubItems.Add(Productos.Unidad.ToString());
        }
    }
}
