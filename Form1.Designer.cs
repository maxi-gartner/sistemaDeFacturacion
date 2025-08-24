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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtProducto = new TextBox();
            TxtPrecio = new TextBox();
            TxtCantidad = new TextBox();
            BtnAgregar = new Button();
            groupBoxDetalle = new GroupBox();
            TxtDetalle = new ListBox();
            BtnEliminarProducto = new Button();
            lblTotal = new Label();
            BtnFinalizar = new Button();
            BtnNuevaFactura = new Button();
            TxtCuit = new TextBox();
            TxtCliente = new TextBox();
            label2 = new Label();
            Cliente = new Label();
            groupBoxCliente = new GroupBox();
            groupBoxProducto.SuspendLayout();
            groupBoxDetalle.SuspendLayout();
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
            groupBoxProducto.Controls.Add(label3);
            groupBoxProducto.Controls.Add(label4);
            groupBoxProducto.Controls.Add(label5);
            groupBoxProducto.Controls.Add(TxtProducto);
            groupBoxProducto.Controls.Add(TxtPrecio);
            groupBoxProducto.Controls.Add(TxtCantidad);
            groupBoxProducto.Controls.Add(BtnAgregar);
            groupBoxProducto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxProducto.ForeColor = Color.DarkGreen;
            groupBoxProducto.Location = new Point(57, 171);
            groupBoxProducto.Name = "groupBoxProducto";
            groupBoxProducto.Size = new Size(820, 120);
            groupBoxProducto.TabIndex = 32;
            groupBoxProducto.TabStop = false;
            groupBoxProducto.Text = " AGREGAR PRODUCTO ";
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
            // TxtProducto
            // 
            TxtProducto.Font = new Font("Segoe UI", 9F);
            TxtProducto.Location = new Point(100, 32);
            TxtProducto.Name = "TxtProducto";
            TxtProducto.Size = new Size(690, 23);
            TxtProducto.TabIndex = 3;
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
            BtnAgregar.Location = new Point(650, 60);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(140, 40);
            BtnAgregar.TabIndex = 6;
            BtnAgregar.Text = "AGREGAR";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // groupBoxDetalle
            // 
            groupBoxDetalle.Controls.Add(TxtDetalle);
            groupBoxDetalle.Controls.Add(BtnEliminarProducto);
            groupBoxDetalle.Controls.Add(lblTotal);
            groupBoxDetalle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxDetalle.ForeColor = Color.DarkRed;
            groupBoxDetalle.Location = new Point(57, 311);
            groupBoxDetalle.Name = "groupBoxDetalle";
            groupBoxDetalle.Size = new Size(820, 230);
            groupBoxDetalle.TabIndex = 33;
            groupBoxDetalle.TabStop = false;
            groupBoxDetalle.Text = " DETALLE DE LA FACTURA ";
            // 
            // TxtDetalle
            // 
            TxtDetalle.Font = new Font("Consolas", 9F);
            TxtDetalle.FormattingEnabled = true;
            TxtDetalle.ItemHeight = 14;
            TxtDetalle.Location = new Point(20, 30);
            TxtDetalle.Name = "TxtDetalle";
            TxtDetalle.Size = new Size(620, 158);
            TxtDetalle.TabIndex = 12;
            // 
            // BtnEliminarProducto
            // 
            BtnEliminarProducto.BackColor = Color.Firebrick;
            BtnEliminarProducto.FlatAppearance.BorderSize = 0;
            BtnEliminarProducto.FlatStyle = FlatStyle.Flat;
            BtnEliminarProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnEliminarProducto.ForeColor = Color.White;
            BtnEliminarProducto.Location = new Point(660, 30);
            BtnEliminarProducto.Name = "BtnEliminarProducto";
            BtnEliminarProducto.Size = new Size(130, 35);
            BtnEliminarProducto.TabIndex = 7;
            BtnEliminarProducto.Text = "ELIMINAR PRODUCTO";
            BtnEliminarProducto.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotal.ForeColor = Color.DarkRed;
            lblTotal.Location = new Point(500, 195);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(127, 25);
            lblTotal.TabIndex = 27;
            lblTotal.Text = "TOTAL: $0.00";
            // 
            // BtnFinalizar
            // 
            BtnFinalizar.BackColor = Color.DarkBlue;
            BtnFinalizar.FlatAppearance.BorderSize = 0;
            BtnFinalizar.FlatStyle = FlatStyle.Flat;
            BtnFinalizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnFinalizar.ForeColor = Color.White;
            BtnFinalizar.Location = new Point(57, 561);
            BtnFinalizar.Name = "BtnFinalizar";
            BtnFinalizar.Size = new Size(620, 50);
            BtnFinalizar.TabIndex = 27;
            BtnFinalizar.Text = "FINALIZAR FACTURA";
            BtnFinalizar.UseVisualStyleBackColor = false;
            // 
            // BtnNuevaFactura
            // 
            BtnNuevaFactura.BackColor = Color.Gray;
            BtnNuevaFactura.FlatAppearance.BorderSize = 0;
            BtnNuevaFactura.FlatStyle = FlatStyle.Flat;
            BtnNuevaFactura.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnNuevaFactura.ForeColor = Color.White;
            BtnNuevaFactura.Location = new Point(697, 561);
            BtnNuevaFactura.Name = "BtnNuevaFactura";
            BtnNuevaFactura.Size = new Size(180, 50);
            BtnNuevaFactura.TabIndex = 28;
            BtnNuevaFactura.Text = "NUEVA FACTURA";
            BtnNuevaFactura.UseVisualStyleBackColor = false;
            // 
            // TxtCuit
            // 
            TxtCuit.Font = new Font("Segoe UI", 9F);
            TxtCuit.Location = new Point(90, 67);
            TxtCuit.Name = "TxtCuit";
            TxtCuit.Size = new Size(220, 23);
            TxtCuit.TabIndex = 2;
            // 
            // TxtCliente
            // 
            TxtCliente.Font = new Font("Segoe UI", 9F);
            TxtCliente.Location = new Point(90, 32);
            TxtCliente.Name = "TxtCliente";
            TxtCliente.Size = new Size(700, 23);
            TxtCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(20, 70);
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
            groupBoxCliente.Controls.Add(Cliente);
            groupBoxCliente.Controls.Add(label2);
            groupBoxCliente.Controls.Add(TxtCliente);
            groupBoxCliente.Controls.Add(TxtCuit);
            groupBoxCliente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxCliente.ForeColor = Color.DarkBlue;
            groupBoxCliente.Location = new Point(57, 61);
            groupBoxCliente.Name = "groupBoxCliente";
            groupBoxCliente.Size = new Size(820, 104);
            groupBoxCliente.TabIndex = 31;
            groupBoxCliente.TabStop = false;
            groupBoxCliente.Text = " DATOS DEL CLIENTE ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 622);
            Controls.Add(lblTituloFactura);
            Controls.Add(lblFecha);
            Controls.Add(groupBoxCliente);
            Controls.Add(groupBoxProducto);
            Controls.Add(groupBoxDetalle);
            Controls.Add(BtnFinalizar);
            Controls.Add(BtnNuevaFactura);
            Name = "Form1";
            Text = "Form1";
            groupBoxProducto.ResumeLayout(false);
            groupBoxProducto.PerformLayout();
            groupBoxDetalle.ResumeLayout(false);
            groupBoxDetalle.PerformLayout();
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
        private TextBox TxtProducto;
        private TextBox TxtPrecio;
        private TextBox TxtCantidad;
        private Button BtnAgregar;
        private GroupBox groupBoxDetalle;
        private ListBox TxtDetalle;
        private Button BtnEliminarProducto;
        private Label lblTotal;
        private Button BtnFinalizar;
        private Button BtnNuevaFactura;
        private TextBox TxtCuit;
        private TextBox TxtCliente;
        private Label label2;
        private Label Cliente;
        private GroupBox groupBoxCliente;
    }
}
