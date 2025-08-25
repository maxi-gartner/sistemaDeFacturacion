using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TP3_SistemaDeFacturacion
{
    public partial class Form1 : Form
    {
        private List<ProductoFactura> productoFacturas = new List<ProductoFactura>();
        private decimal totalFactura = 0;
        private List<Cliente> clientesPredefinidos = new List<Cliente>();
        private List<Producto> productosPredefinidos = new List<Producto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigurarDetalles();
            InicializarClientesPredefinidos();
            InicializarProductosPredefinidos();
            ConfigurarComboBoxClientes();
            ConfigurarComboBoxProductos();
        }

        private void InicializarClientesPredefinidos()
        {
            clientesPredefinidos = new List<Cliente>
            {
                new Cliente { Nombre = "Juan Pérez", Cuit = "20-12345678-9" },
                new Cliente { Nombre = "María González", Cuit = "27-87654321-4" },
                new Cliente { Nombre = "Carlos López", Cuit = "20-11223344-5" },
                new Cliente { Nombre = "Ana Martínez", Cuit = "27-55667788-9" },
                new Cliente { Nombre = "Luis Rodríguez", Cuit = "20-99887766-3" },
                new Cliente { Nombre = "Empresa ABC S.A.", Cuit = "30-12345678-9" },
                new Cliente { Nombre = "Comercial XYZ", Cuit = "30-98765432-1" }
            };
        }

        private void InicializarProductosPredefinidos()
        {
            productosPredefinidos = new List<Producto>
            {
                new Producto { Nombre = "Laptop HP Pavilion", Precio = 85000m },
                new Producto { Nombre = "Mouse Inalámbrico Logitech", Precio = 3500m },
                new Producto { Nombre = "Teclado Mecánico", Precio = 12000m },
                new Producto { Nombre = "Monitor 24\" Samsung", Precio = 45000m },
                new Producto { Nombre = "Impresora Multifunción Canon", Precio = 28000m },
                new Producto { Nombre = "Disco SSD 500GB", Precio = 15000m },
                new Producto { Nombre = "Memoria RAM 8GB DDR4", Precio = 8500m },
                new Producto { Nombre = "Webcam HD Logitech", Precio = 7200m },
                new Producto { Nombre = "Auriculares Bluetooth Sony", Precio = 18000m },
                new Producto { Nombre = "Tablet Samsung Galaxy", Precio = 65000m }
            };
        }

        private void ConfigurarComboBoxClientes()
        {
            if (CmbCliente != null)
            {
                CmbCliente.DropDownStyle = ComboBoxStyle.DropDown;
                CmbCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                CmbCliente.AutoCompleteSource = AutoCompleteSource.ListItems;

                // Limpiar y agregar items
                CmbCliente.Items.Clear();
                CmbCliente.Items.Add("--- Agregar nuevo cliente ---");

                foreach (var cliente in clientesPredefinidos)
                {
                    CmbCliente.Items.Add(cliente.Nombre);
                }

                CmbCliente.SelectedIndexChanged += CmbCliente_SelectedIndexChanged;
                CmbCliente.TextChanged += CmbCliente_TextChanged;
            }
        }

        private void ConfigurarComboBoxProductos()
        {
            // Asumo que tienes un ComboBox llamado CmbProducto en el diseñador
            if (CmbProducto != null)
            {
                CmbProducto.DropDownStyle = ComboBoxStyle.DropDown;
                CmbProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                CmbProducto.AutoCompleteSource = AutoCompleteSource.ListItems;

                // Limpiar y agregar items
                CmbProducto.Items.Clear();
                CmbProducto.Items.Add("--- Agregar nuevo producto ---");

                foreach (var producto in productosPredefinidos)
                {
                    CmbProducto.Items.Add(producto.Nombre);
                }

                CmbProducto.SelectedIndexChanged += CmbProducto_SelectedIndexChanged;
                CmbProducto.TextChanged += CmbProducto_TextChanged;
            }
        }

        private void CmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbProducto.SelectedIndex == 0) // "--- Agregar nuevo producto ---"
            {
                // Limpiar campos para permitir entrada manual
                CmbProducto.Text = "";
                TxtPrecio.Text = "";
                TxtPrecio.ReadOnly = false;
                TxtPrecio.BackColor = SystemColors.Window;
                AbrirFormularioNuevoProducto();
                return;
            }

            // Buscar el producto seleccionado
            string nombreSeleccionado = CmbProducto.Text;
            var productoSeleccionado = productosPredefinidos.FirstOrDefault(p => p.Nombre == nombreSeleccionado);

            if (productoSeleccionado != null)
            {
                // Autocompletar precio
                TxtPrecio.Text = productoSeleccionado.Precio.ToString("F2");
                TxtPrecio.ReadOnly = true;
                TxtPrecio.BackColor = SystemColors.Control;

                // Enfocar en cantidad para que el usuario solo tenga que escribir la cantidad
                TxtCantidad.Focus();
            }
            else
            {
                // Producto no encontrado en predefinidos, permitir edición manual
                TxtPrecio.ReadOnly = false;
                TxtPrecio.BackColor = SystemColors.Window;
            }
        }

        private void CmbProducto_TextChanged(object sender, EventArgs e)
        {
            // Si el texto no corresponde a un producto predefinido, permitir edición del precio
            string textoActual = CmbProducto.Text;
            var productoExistente = productosPredefinidos.FirstOrDefault(p => p.Nombre == textoActual);
        }

        private void CmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbCliente.SelectedIndex == 0) // "--- Agregar nuevo cliente ---"
            {
                // Abrir formulario para agregar nuevo cliente
                AbrirFormularioNuevoCliente();
                return;
            }

            // Buscar el cliente seleccionado
            string nombreSeleccionado = CmbCliente.Text;
            var clienteSeleccionado = clientesPredefinidos.FirstOrDefault(c => c.Nombre == nombreSeleccionado);

            if (clienteSeleccionado != null)
            {
                // Autocompletar CUIT
                TxtCuit.Text = clienteSeleccionado.Cuit;
                TxtCuit.ReadOnly = true;
                TxtCuit.BackColor = SystemColors.Control;
            }
            else
            {
                // Cliente no encontrado en predefinidos, permitir edición manual
                TxtCuit.ReadOnly = false;
                TxtCuit.BackColor = SystemColors.Window;
            }
        }

        private void CmbCliente_TextChanged(object sender, EventArgs e)
        {
            string textoActual = CmbCliente.Text;
            var clienteExistente = clientesPredefinidos.FirstOrDefault(c => c.Nombre == textoActual);

            if (clienteExistente == null && textoActual != "--- Agregar nuevo cliente ---")
            {
                TxtCuit.ReadOnly = false;
                TxtCuit.BackColor = SystemColors.Window;
                if (string.IsNullOrEmpty(textoActual))
                {
                    TxtCuit.Text = "";
                }
            }
        }

        private void AbrirFormularioNuevoCliente()
        {
            using (var formCliente = new FormNuevoCliente())
            {
                if (formCliente.ShowDialog() == DialogResult.OK)
                {
                    var nuevoCliente = new Cliente
                    {
                        Nombre = formCliente.NombreCliente,
                        Cuit = formCliente.CuitCliente
                    };

                    // Verificar si ya existe
                    if (!clientesPredefinidos.Any(c => c.Cuit == nuevoCliente.Cuit))
                    {
                        clientesPredefinidos.Add(nuevoCliente);
                        CmbCliente.Items.Add(nuevoCliente.Nombre);

                        // Seleccionar el nuevo cliente
                        CmbCliente.Text = nuevoCliente.Nombre;
                        TxtCuit.Text = nuevoCliente.Cuit;
                        TxtCuit.ReadOnly = true;
                        TxtCuit.BackColor = SystemColors.Control;

                        MessageBox.Show($"Cliente '{nuevoCliente.Nombre}' agregado exitosamente.",
                                      "Cliente agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un cliente con ese CUIT.",
                                      "Cliente duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Usuario canceló, limpiar selección
                    CmbCliente.SelectedIndex = -1;
                    CmbCliente.Text = "";
                }
            }
        }

        private void AbrirFormularioNuevoProducto()
        {
            using (var formProducto = new FormNuevoProducto())
            {
                if (formProducto.ShowDialog() == DialogResult.OK)
                {
                    var nuevoProducto = new Producto
                    {
                        Nombre = formProducto.NombreProducto,
                        Precio = formProducto.PrecioProducto
                    };

                    // Verificar si ya existe
                    if (!productosPredefinidos.Any(p => p.Nombre.Equals(nuevoProducto.Nombre, StringComparison.OrdinalIgnoreCase)))
                    {
                        productosPredefinidos.Add(nuevoProducto);
                        CmbProducto.Items.Add(nuevoProducto.Nombre);

                        // Seleccionar el nuevo producto
                        CmbProducto.Text = nuevoProducto.Nombre;
                        TxtPrecio.Text = nuevoProducto.Precio.ToString("F2");
                        TxtPrecio.ReadOnly = true;
                        TxtPrecio.BackColor = SystemColors.Control;


                        // Enfocar en cantidad
                        TxtCantidad.Focus();

                        MessageBox.Show($"Producto '{nuevoProducto.Nombre}' agregado exitosamente.",
                                      "Producto agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un producto con ese nombre.",
                                      "Producto duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Usuario canceló, limpiar selección
                    CmbProducto.SelectedIndex = -1;
                    CmbProducto.Text = "";
                }
            }
        }

        private void ConfigurarDetalles()
        {
            PnlDetalle.Controls.Clear();
            PnlDetalle.AutoScroll = true;

            var lblTitulo = new Label
            {
                Text = " DETALLE DE LA FACTURA:",
                Font = new Font("Arial", 10, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(10, 10)
            };
            PnlDetalle.Controls.Add(lblTitulo);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que todos los campos estén completos
                if (string.IsNullOrEmpty(CmbProducto.Text) ||
                   string.IsNullOrEmpty(TxtPrecio.Text) ||
                   string.IsNullOrEmpty(TxtCantidad.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos del producto.", "Campos incompletos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que precio y cantidad sean números válidos
                if (!decimal.TryParse(TxtPrecio.Text, out decimal precio) || precio <= 0)
                {
                    MessageBox.Show("El precio debe ser un número válido mayor a 0.", "Precio inválido",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtPrecio.Focus();
                    return;
                }

                if (!int.TryParse(TxtCantidad.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("La cantidad debe ser un número válido mayor a 0.", "Cantidad inválida",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtCantidad.Focus();
                    return;
                }

                // Crear nuevo producto para la factura
                var producto = new ProductoFactura
                {
                    Nombre = CmbProducto.Text.Trim(),
                    Precio = precio,
                    Cantidad = cantidad,
                    Subtotal = precio * cantidad
                };

                // Agregar el producto a la lista
                productoFacturas.Add(producto);
                totalFactura += producto.Subtotal;

                // Actualizar la visualización
                ActualizarDetalles();

                // Limpiar campos de producto pero mantener cliente
                LimpiarCamposProducto();

                MessageBox.Show($"Producto '{producto.Nombre}' agregado exitosamente.",
                              "Producto agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar producto: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarDetalles()
        {
            if (PnlDetalle != null)
            {
                ActualizarDetallesConBotones();
                return;
            }
        }

        private void ActualizarDetallesConBotones()
        {
            PnlDetalle.SuspendLayout();
            PnlDetalle.Controls.Clear();

            // Título
            var lblTitulo = new Label
            {
                Text = "DETALLE DE PRODUCTOS:",
                Font = new Font("Arial", 10, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(10, 10)
            };
            PnlDetalle.Controls.Add(lblTitulo);

            int yPosition = 40;

            // Agregar cada producto con su botón de eliminar
            for (int i = 0; i < productoFacturas.Count; i++)
            {
                var producto = productoFacturas[i];

                // Crear panel para cada producto
                var pnlProducto = new Panel
                {
                    Location = new Point(10, yPosition),
                    Size = new Size(PnlDetalle.Width - 40, 70),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.WhiteSmoke
                };

                // Label con información del producto
                var lblProducto = new Label
                {
                    Text = $"{producto.Nombre}\n" +
                           $"Cantidad: {producto.Cantidad} - Precio: ${producto.Precio:F2}\n" +
                           $"Subtotal: ${producto.Subtotal:F2}",
                    Location = new Point(10, 10),
                    Size = new Size(pnlProducto.Width - 100, 50),
                    Font = new Font("Arial", 9)
                };

                // Botón eliminar
                var btnEliminar = new Button
                {
                    Text = "❌",
                    Location = new Point(pnlProducto.Width - 80, 20),
                    Size = new Size(60, 30),
                    BackColor = Color.LightCoral,
                    ForeColor = Color.White,
                    Font = new Font("Arial", 8, FontStyle.Bold),
                    Tag = i,
                    UseVisualStyleBackColor = false
                };

                btnEliminar.Click += BtnEliminarProducto_Click;

                pnlProducto.Controls.Add(lblProducto);
                pnlProducto.Controls.Add(btnEliminar);
                PnlDetalle.Controls.Add(pnlProducto);

                yPosition += 80;
            }

            // Agregar total al final
            if (productoFacturas.Count > 0)
            {
                var lblTotalFinal = new Label
                {
                    Text = $"TOTAL FACTURA: ${totalFactura:F2}",
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = Color.DarkBlue,
                    AutoSize = true,
                    Location = new Point(10, yPosition + 10)
                };
                PnlDetalle.Controls.Add(lblTotalFinal);
            }

            PnlDetalle.ResumeLayout();
        }

        private void BtnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender is Button btn && btn.Tag is int indice)
                {
                    if (indice >= 0 && indice < productoFacturas.Count)
                    {
                        var producto = productoFacturas[indice];

                        var resultado = MessageBox.Show(
                            $"¿Está seguro que desea eliminar el producto '{producto.Nombre}'?",
                            "Confirmar eliminación",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            totalFactura -= producto.Subtotal;
                            productoFacturas.RemoveAt(indice);
                            ActualizarDetalles();

                            MessageBox.Show($"Producto '{producto.Nombre}' eliminado correctamente.",
                                          "Producto eliminado",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar producto: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCamposProducto()
        {
            var productoActual = productosPredefinidos.FirstOrDefault(p => p.Nombre == CmbProducto.Text);
            bool esProductoPredefinido = productoActual != null;

            // Solo limpiar cantidad, mantener producto y precio si es predefinido
            TxtCantidad.Text = "";

            if (!esProductoPredefinido)
            {
                CmbProducto.SelectedIndex = -1;
                CmbProducto.Text = "";
                TxtPrecio.Text = "";
                TxtPrecio.ReadOnly = false;
                TxtPrecio.BackColor = SystemColors.Window;
                CmbProducto.Focus();
            }
            else
            {
                TxtCantidad.Focus(); // Solo enfocar en cantidad para productos predefinidos
            }
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(CmbCliente.Text) ||
                    string.IsNullOrEmpty(TxtCuit.Text))
                {
                    MessageBox.Show("Por favor, complete los datos del cliente (Nombre y CUIT).",
                                  "Datos del cliente incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (productoFacturas.Count == 0)
                {
                    MessageBox.Show("Debe agregar al menos un producto para finalizar la factura.",
                                  "Sin productos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string facturaCompleta = GenerarFacturaCompleta();

                MessageBox.Show(facturaCompleta, "Factura Finalizada",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);

                var resultado = MessageBox.Show("¿Desea crear una nueva factura?",
                                              "Nueva Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    ReiniciarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al finalizar factura: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerarFacturaCompleta()
        {
            var factura = new System.Text.StringBuilder();
            factura.AppendLine("=== FACTURA ===");
            factura.AppendLine($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}");
            factura.AppendLine();
            factura.AppendLine("DATOS DEL CLIENTE:");
            factura.AppendLine($"Nombre: {CmbCliente.Text}");
            factura.AppendLine($"CUIT: {TxtCuit.Text}");
            factura.AppendLine();
            factura.AppendLine("DETALLE DE PRODUCTOS:");
            factura.AppendLine("----------------------------------------");

            foreach (var producto in productoFacturas)
            {
                factura.AppendLine($"{producto.Nombre}");
                factura.AppendLine($"  Cantidad: {producto.Cantidad} - Precio unitario: ${producto.Precio:F2}");
                factura.AppendLine($"  Subtotal: ${producto.Subtotal:F2}");
                factura.AppendLine();
            }

            factura.AppendLine("----------------------------------------");
            factura.AppendLine($"TOTAL FACTURA: ${totalFactura:F2}");
            factura.AppendLine("=======================================");

            return factura.ToString();
        }

        private void ReiniciarFormulario()
        {
            // Limpiar campos de cliente
            CmbCliente.SelectedIndex = -1;
            CmbCliente.Text = "";
            TxtCuit.Clear();
            TxtCuit.ReadOnly = false;
            TxtCuit.BackColor = SystemColors.Window;

            // Limpiar campos de producto
            LimpiarCamposProducto();

            // Reiniciar listas y totales
            productoFacturas.Clear();
            totalFactura = 0;

            // Limpiar detalles
            ConfigurarDetalles();

            // Enfocar en cliente para nueva factura
            CmbCliente.Focus();
        }
    }

    public class ProductoFactura
    {
        public required string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
    }

    public class Cliente
    {
        public required string Nombre { get; set; }
        public required string Cuit { get; set; }
    }

    public class Producto
    {
        public required string Nombre { get; set; }
        public decimal Precio { get; set; }
    }

    // Formulario para agregar nuevo cliente
    public partial class FormNuevoCliente : Form
    {
        public string NombreCliente { get; private set; } = "";
        public string CuitCliente { get; private set; } = "";

        private TextBox txtNombre;
        private TextBox txtCuit;
        private Button btnAceptar;
        private Button btnCancelar;

        public FormNuevoCliente()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Agregar Nuevo Cliente";
            this.Size = new Size(400, 200);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            var lblNombre = new Label
            {
                Text = "Nombre:",
                Location = new Point(20, 20),
                Size = new Size(60, 23)
            };

            txtNombre = new TextBox
            {
                Location = new Point(90, 20),
                Size = new Size(270, 23)
            };

            var lblCuit = new Label
            {
                Text = "CUIT:",
                Location = new Point(20, 60),
                Size = new Size(60, 23)
            };

            txtCuit = new TextBox
            {
                Location = new Point(90, 60),
                Size = new Size(270, 23),
                MaxLength = 13 // Formato: 20-12345678-9
            };

            btnAceptar = new Button
            {
                Text = "Aceptar",
                Location = new Point(200, 110),
                Size = new Size(80, 30),
                DialogResult = DialogResult.OK
            };
            btnAceptar.Click += BtnAceptar_Click;

            btnCancelar = new Button
            {
                Text = "Cancelar",
                Location = new Point(290, 110),
                Size = new Size(80, 30),
                DialogResult = DialogResult.Cancel
            };

            this.Controls.AddRange(new Control[] { lblNombre, txtNombre, lblCuit, txtCuit, btnAceptar, btnCancelar });
            this.AcceptButton = btnAceptar;
            this.CancelButton = btnCancelar;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCuit.Text))
            {
                MessageBox.Show("Ingrese el CUIT del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCuit.Focus();
                return;
            }

            NombreCliente = txtNombre.Text.Trim();
            CuitCliente = txtCuit.Text.Trim();
        }
    }

    // Formulario para agregar nuevo producto
    public partial class FormNuevoProducto : Form
    {
        public string NombreProducto { get; private set; } = "";
        public decimal PrecioProducto { get; private set; }

        private TextBox txtNombre;
        private TextBox txtPrecio;
        private Button btnAceptar;
        private Button btnCancelar;

        public FormNuevoProducto()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Agregar Nuevo Producto";
            this.Size = new Size(400, 200);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            var lblNombre = new Label
            {
                Text = "Nombre:",
                Location = new Point(20, 20),
                Size = new Size(60, 23)
            };

            txtNombre = new TextBox
            {
                Location = new Point(90, 20),
                Size = new Size(270, 23)
            };

            var lblPrecio = new Label
            {
                Text = "Precio:",
                Location = new Point(20, 60),
                Size = new Size(60, 23)
            };

            txtPrecio = new TextBox
            {
                Location = new Point(90, 60),
                Size = new Size(270, 23)
            };

            btnAceptar = new Button
            {
                Text = "Aceptar",
                Location = new Point(200, 110),
                Size = new Size(80, 30),
                DialogResult = DialogResult.OK
            };
            btnAceptar.Click += BtnAceptar_Click;

            btnCancelar = new Button
            {
                Text = "Cancelar",
                Location = new Point(290, 110),
                Size = new Size(80, 30),
                DialogResult = DialogResult.Cancel
            };

            this.Controls.AddRange(new Control[] { lblNombre, txtNombre, lblPrecio, txtPrecio, btnAceptar, btnCancelar });
            this.AcceptButton = btnAceptar;
            this.CancelButton = btnCancelar;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio válido mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return;
            }

            NombreProducto = txtNombre.Text.Trim();
            PrecioProducto = precio;
        }
    }
}