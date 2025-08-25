namespace TP3_SistemaDeFacturacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTituloFactura = new Label();
            lblFecha = new Label();
            groupBoxProducto = new GroupBox();
            CmbProducto = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtPrecio = new TextBox();
            TxtCantidad = new TextBox();
            BtnAgregar = new Button();
            BtnFinalizar = new Button();
            BtnNuevaFactura = new Button();
            TxtCuit = new TextBox();
            label2 = new Label();
            Cliente = new Label();
            groupBoxCliente = new GroupBox();
            CmbCliente = new ComboBox();
            PnlDetalle = new Panel();
            groupBoxProducto.SuspendLayout();
            groupBoxCliente.SuspendLayout();
            SuspendLayout();
            // 
            // lblTituloFactura
            // 
            lblTituloFactura.AutoSize = true;
            lblTituloFactura.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTituloFactura.ForeColor = Color.DarkBlue;
            lblTituloFactura.Location = new Point(57, 11);
            lblTituloFactura.Name = "lblTituloFactura";
            lblTituloFactura.Size = new Size(327, 32);
            lblTituloFactura.TabIndex = 29;
            lblTituloFactura.Text = "SISTEMA DE FACTURACIÓN";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10F);
            lblFecha.ForeColor = Color.Gray;
            lblFecha.Location = new Point(727, 21);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(122, 19);
            lblFecha.TabIndex = 30;
            lblFecha.Text = "18/08/2025 16:34";
            // 
            // groupBoxProducto
            // 
            groupBoxProducto.Controls.Add(CmbProducto);
            groupBoxProducto.Controls.Add(label3);
            groupBoxProducto.Controls.Add(label4);
            groupBoxProducto.Controls.Add(label5);
            groupBoxProducto.Controls.Add(TxtPrecio);
            groupBoxProducto.Controls.Add(TxtCantidad);
            groupBoxProducto.Controls.Add(BtnAgregar);
            groupBoxProducto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxProducto.ForeColor = Color.DarkGreen;
            groupBoxProducto.Location = new Point(57, 147);
            groupBoxProducto.Name = "groupBoxProducto";
            groupBoxProducto.Size = new Size(820, 120);
            groupBoxProducto.TabIndex = 32;
            groupBoxProducto.TabStop = false;
            groupBoxProducto.Text = " AGREGAR PRODUCTO ";
            // 
            // CmbProducto
            // 
            CmbProducto.FormattingEnabled = true;
            CmbProducto.Location = new Point(100, 30);
            CmbProducto.Name = "CmbProducto";
            CmbProducto.Size = new Size(360, 25);
            CmbProducto.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(20, 35);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 18;
            label3.Text = "PRODUCTO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(20, 70);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 19;
            label4.Text = "PRECIO $:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(300, 70);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 20;
            label5.Text = "CANTIDAD:";
            // 
            // TxtPrecio
            // 
            TxtPrecio.Font = new Font("Segoe UI", 9F);
            TxtPrecio.Location = new Point(100, 67);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.Size = new Size(150, 23);
            TxtPrecio.TabIndex = 4;
            TxtPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtCantidad
            // 
            TxtCantidad.Font = new Font("Segoe UI", 9F);
            TxtCantidad.Location = new Point(380, 67);
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(80, 23);
            TxtCantidad.TabIndex = 5;
            TxtCantidad.TextAlign = HorizontalAlignment.Right;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.DarkGreen;
            BtnAgregar.FlatAppearance.BorderSize = 0;
            BtnAgregar.FlatStyle = FlatStyle.Flat;
            BtnAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnAgregar.ForeColor = Color.White;
            BtnAgregar.Location = new Point(634, 35);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(180, 50);
            BtnAgregar.TabIndex = 6;
            BtnAgregar.Text = "AGREGAR";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnFinalizar
            // 
            BtnFinalizar.BackColor = Color.DarkBlue;
            BtnFinalizar.FlatAppearance.BorderSize = 0;
            BtnFinalizar.FlatStyle = FlatStyle.Flat;
            BtnFinalizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnFinalizar.ForeColor = Color.White;
            BtnFinalizar.Location = new Point(57, 537);
            BtnFinalizar.Name = "BtnFinalizar";
            BtnFinalizar.Size = new Size(620, 50);
            BtnFinalizar.TabIndex = 27;
            BtnFinalizar.Text = "FINALIZAR FACTURA";
            BtnFinalizar.UseVisualStyleBackColor = false;
            BtnFinalizar.Click += BtnFinalizar_Click;
            // 
            // BtnNuevaFactura
            // 
            BtnNuevaFactura.BackColor = Color.Gray;
            BtnNuevaFactura.FlatAppearance.BorderSize = 0;
            BtnNuevaFactura.FlatStyle = FlatStyle.Flat;
            BtnNuevaFactura.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnNuevaFactura.ForeColor = Color.White;
            BtnNuevaFactura.Location = new Point(691, 537);
            BtnNuevaFactura.Name = "BtnNuevaFactura";
            BtnNuevaFactura.Size = new Size(180, 50);
            BtnNuevaFactura.TabIndex = 28;
            BtnNuevaFactura.Text = "NUEVA FACTURA";
            BtnNuevaFactura.UseVisualStyleBackColor = false;
            // 
            // TxtCuit
            // 
            TxtCuit.Font = new Font("Segoe UI", 9F);
            TxtCuit.Location = new Point(448, 32);
            TxtCuit.Name = "TxtCuit";
            TxtCuit.Size = new Size(220, 23);
            TxtCuit.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(406, 35);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 17;
            label2.Text = "CUIT:";
            // 
            // Cliente
            // 
            Cliente.AutoSize = true;
            Cliente.Font = new Font("Segoe UI", 9F);
            Cliente.ForeColor = Color.Black;
            Cliente.Location = new Point(20, 35);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(55, 15);
            Cliente.TabIndex = 16;
            Cliente.Text = "CLIENTE:";
            // 
            // groupBoxCliente
            // 
            groupBoxCliente.Controls.Add(CmbCliente);
            groupBoxCliente.Controls.Add(Cliente);
            groupBoxCliente.Controls.Add(label2);
            groupBoxCliente.Controls.Add(TxtCuit);
            groupBoxCliente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxCliente.ForeColor = Color.DarkBlue;
            groupBoxCliente.Location = new Point(57, 61);
            groupBoxCliente.Name = "groupBoxCliente";
            groupBoxCliente.Size = new Size(820, 71);
            groupBoxCliente.TabIndex = 31;
            groupBoxCliente.TabStop = false;
            groupBoxCliente.Text = " DATOS DEL CLIENTE ";
            // 
            // CmbCliente
            // 
            CmbCliente.FormattingEnabled = true;
            CmbCliente.Location = new Point(81, 30);
            CmbCliente.Name = "CmbCliente";
            CmbCliente.Size = new Size(279, 25);
            CmbCliente.TabIndex = 18;
            // 
            // PnlDetalle
            // 
            PnlDetalle.AutoScroll = true;
            PnlDetalle.BackColor = SystemColors.AppWorkspace;
            PnlDetalle.BorderStyle = BorderStyle.FixedSingle;
            PnlDetalle.Location = new Point(57, 294);
            PnlDetalle.Name = "PnlDetalle";
            PnlDetalle.Size = new Size(820, 215);
            PnlDetalle.TabIndex = 33;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 622);
            Controls.Add(PnlDetalle);
            Controls.Add(lblTituloFactura);
            Controls.Add(lblFecha);
            Controls.Add(groupBoxCliente);
            Controls.Add(groupBoxProducto);
            Controls.Add(BtnFinalizar);
            Controls.Add(BtnNuevaFactura);
            Name = "Form1";
            Text = "Sistema de Facturacion";
            Load += Form1_Load;
            groupBoxProducto.ResumeLayout(false);
            groupBoxProducto.PerformLayout();
            groupBoxCliente.ResumeLayout(false);
            groupBoxCliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloFactura;
        private Label lblFecha;
        private GroupBox groupBoxProducto;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TxtPrecio;
        private TextBox TxtCantidad;
        private Button BtnAgregar;
        private Button BtnFinalizar;
        private Button BtnNuevaFactura;
        private TextBox TxtCuit;
        private Label label2;
        private Label Cliente;
        private GroupBox groupBoxCliente;
        private ComboBox CmbCliente;
        private Panel PnlDetalle;
        private ComboBox CmbProducto;
    }
}
