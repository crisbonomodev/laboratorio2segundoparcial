
namespace Formularios
{
    partial class frmNuevoPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCategoriaProducto = new System.Windows.Forms.DataGridView();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblEnvio = new System.Windows.Forms.Label();
            this.cmbEnvio = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.lblPrecioData = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriaProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategoriaProducto
            // 
            this.dgvCategoriaProducto.AllowUserToAddRows = false;
            this.dgvCategoriaProducto.AllowUserToDeleteRows = false;
            this.dgvCategoriaProducto.AllowUserToResizeColumns = false;
            this.dgvCategoriaProducto.AllowUserToResizeRows = false;
            this.dgvCategoriaProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvCategoriaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoriaProducto.Location = new System.Drawing.Point(12, 12);
            this.dgvCategoriaProducto.MultiSelect = false;
            this.dgvCategoriaProducto.Name = "dgvCategoriaProducto";
            this.dgvCategoriaProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoriaProducto.Size = new System.Drawing.Size(365, 156);
            this.dgvCategoriaProducto.TabIndex = 0;
            this.dgvCategoriaProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoriaProducto_CellClick);
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AllowUserToAddRows = false;
            this.dgvCarrito.AllowUserToDeleteRows = false;
            this.dgvCarrito.AllowUserToResizeColumns = false;
            this.dgvCarrito.AllowUserToResizeRows = false;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Location = new System.Drawing.Point(443, 12);
            this.dgvCarrito.MultiSelect = false;
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.ReadOnly = true;
            this.dgvCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarrito.Size = new System.Drawing.Size(345, 261);
            this.dgvCarrito.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(632, 415);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(713, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(440, 382);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total: ";
            // 
            // lblEnvio
            // 
            this.lblEnvio.AutoSize = true;
            this.lblEnvio.Location = new System.Drawing.Point(440, 319);
            this.lblEnvio.Name = "lblEnvio";
            this.lblEnvio.Size = new System.Drawing.Size(73, 13);
            this.lblEnvio.TabIndex = 5;
            this.lblEnvio.Text = "Tipo de Envio";
            // 
            // cmbEnvio
            // 
            this.cmbEnvio.FormattingEnabled = true;
            this.cmbEnvio.Location = new System.Drawing.Point(578, 316);
            this.cmbEnvio.Name = "cmbEnvio";
            this.cmbEnvio.Size = new System.Drawing.Size(210, 21);
            this.cmbEnvio.TabIndex = 7;
            this.cmbEnvio.SelectedIndexChanged += new System.EventHandler(this.cmbEnvio_SelectedIndexChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(578, 343);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(210, 20);
            this.txtDireccion.TabIndex = 8;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(440, 346);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(754, 382);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(34, 13);
            this.lblValorTotal.TabIndex = 10;
            this.lblValorTotal.Text = "$0.00";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(578, 290);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(210, 20);
            this.txtNombreCliente.TabIndex = 11;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(440, 293);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(47, 13);
            this.lblNombreCliente.TabIndex = 12;
            this.lblNombreCliente.Text = "Nombre:";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(383, 120);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(54, 48);
            this.btnAgregarProducto.TabIndex = 13;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.Location = new System.Drawing.Point(383, 174);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(54, 48);
            this.btnQuitarProducto.TabIndex = 14;
            this.btnQuitarProducto.Text = "Quitar";
            this.btnQuitarProducto.UseVisualStyleBackColor = true;
            this.btnQuitarProducto.Click += new System.EventHandler(this.btnQuitarProducto_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 207);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(365, 156);
            this.dgvProductos.TabIndex = 15;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // lblPrecioData
            // 
            this.lblPrecioData.AutoSize = true;
            this.lblPrecioData.Location = new System.Drawing.Point(343, 382);
            this.lblPrecioData.Name = "lblPrecioData";
            this.lblPrecioData.Size = new System.Drawing.Size(34, 13);
            this.lblPrecioData.TabIndex = 18;
            this.lblPrecioData.Text = "$0.00";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(12, 382);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 19;
            this.lblPrecio.Text = "Precio:";
            // 
            // frmNuevoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblPrecioData);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnQuitarProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.cmbEnvio);
            this.Controls.Add(this.lblEnvio);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.dgvCarrito);
            this.Controls.Add(this.dgvCategoriaProducto);
            this.Name = "frmNuevoPedido";
            this.Text = "Nuevo Pedido";
            this.Load += new System.EventHandler(this.frmNuevoPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriaProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategoriaProducto;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblEnvio;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cmbEnvio;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label lblPrecioData;
        private System.Windows.Forms.Label lblPrecio;
    }
}