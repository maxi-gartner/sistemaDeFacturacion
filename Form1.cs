using System.Security.Cryptography.X509Certificates;

namespace TP3_SistemaDeFacturacion
{
    public partial class Form1 : Form
    {
        private List<ProductoFactura> productoFacturas = new List<ProductoFactura>();
        private decimal totalFactura = 0; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1Load(object sender, EventArgs e)
        {
            ConfigurarDetalles();
        }

        private void ConfigurarDetalles()
        {
            //Si textDetalle es un ListBox, configurarlo
            if (TxtDetalle is ListBox listBox)
            {
                listBox.Items.Clear();
                listBox.Items.Add("DETALLE DE PRODUCTOS:");
                listBox.Items.Add("------------------------");
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //validar que todos los campos estén completos
                if (string.IsNullOrEmpty(TxtProducto.Text) ||
                   string.IsNullOrEmpty(TxtPrecio.Text) ||
                   string.IsNullOrEmpty(TxtCantidad.Text)
                    )
                {
                    MessageBox.Show("Por favor, complete todos los campos del producto.", "Campos imcompletos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                //validar que precio y cantidad sean números válidos
                if (!decimal.TryParse(TxtPrecio.Text, out decimal precio) || precio <= 0)
                {
                    MessageBox.Show("El precio debe ser un número válido mayor a 0.", "Precio invalido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    TxtPrecio.Focus();
                    return;
                }
                if (!int.TryParse(TxtCantidad.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("El cantidad debe ser un número válido mayor a 0.", "Cantidad invalida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    TxtCantidad.Focus();
                    return;
                }

                //Crear nuevo producto
                var producto = new ProductoFactura
                {
                    Nombre = TxtProducto.Text.Trim(),
                    Precio = precio,
                    Cantidad = cantidad,
                    Subtotal = precio * cantidad
                };

                //Agregar el producto a la lista
                productoFacturas.Add(producto);
                totalFactura += producto.Subtotal;

                //Actualizar la visualización
                ActualizarDetalles();
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Error al finalizar factura: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ;
        }

        private void ActualizarDetalles()
        {
            if(TxtDetalle is ListBox listBox)
            {
                listBox.Items.Clear();
                listBox.Items.Add("DETALLE DE PRODUCTOS:");
                listBox.Items.Add("------------------------");

                foreach(var producto in productoFacturas)
                {
                    listBox.Items.Add($"{producto.Nombre} - Cant: {producto.Cantidad} - " +
                                    $"Precio: ${producto.Precio:F2} - Subtotal: ${producto.Subtotal:F2}");
                }
            }
        }

    };
    public class ProductoFactura
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }

    }
}
