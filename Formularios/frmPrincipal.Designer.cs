using Entidades;
namespace Formularios
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.dgvCompletados = new System.Windows.Forms.DataGridView();
            this.timerActualizarPedidos = new System.Windows.Forms.Timer(this.components);
            this.lblFechaYHora = new System.Windows.Forms.Label();
            this.lstEnPreparacion = new System.Windows.Forms.ListView();
            this.idPedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombreCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fechaYHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tiempoPreparacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.Location = new System.Drawing.Point(482, 406);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(150, 44);
            this.btnNuevoPedido.TabIndex = 0;
            this.btnNuevoPedido.Text = "Nuevo Pedido";
            this.btnNuevoPedido.UseVisualStyleBackColor = true;
            this.btnNuevoPedido.Click += new System.EventHandler(this.btnNuevoPedido_Click);
            // 
            // dgvCompletados
            // 
            this.dgvCompletados.AllowUserToAddRows = false;
            this.dgvCompletados.AllowUserToDeleteRows = false;
            this.dgvCompletados.AllowUserToResizeColumns = false;
            this.dgvCompletados.AllowUserToResizeRows = false;
            this.dgvCompletados.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvCompletados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompletados.Enabled = false;
            this.dgvCompletados.Location = new System.Drawing.Point(561, 49);
            this.dgvCompletados.MultiSelect = false;
            this.dgvCompletados.Name = "dgvCompletados";
            this.dgvCompletados.ReadOnly = true;
            this.dgvCompletados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompletados.Size = new System.Drawing.Size(521, 339);
            this.dgvCompletados.TabIndex = 2;
            this.dgvCompletados.VirtualMode = true;
            // 
            // timerActualizarPedidos
            // 
            this.timerActualizarPedidos.Enabled = true;
            this.timerActualizarPedidos.Interval = 1000;
            this.timerActualizarPedidos.Tick += new System.EventHandler(this.timerActualizarPedidos_Tick);
            // 
            // lblFechaYHora
            // 
            this.lblFechaYHora.AutoSize = true;
            this.lblFechaYHora.Location = new System.Drawing.Point(410, 21);
            this.lblFechaYHora.Name = "lblFechaYHora";
            this.lblFechaYHora.Size = new System.Drawing.Size(0, 13);
            this.lblFechaYHora.TabIndex = 4;
            this.lblFechaYHora.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lstEnPreparacion
            // 
            this.lstEnPreparacion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idPedido,
            this.nombreCliente,
            this.fechaYHora,
            this.total,
            this.tiempoPreparacion});
            this.lstEnPreparacion.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstEnPreparacion.HideSelection = false;
            this.lstEnPreparacion.Location = new System.Drawing.Point(21, 49);
            this.lstEnPreparacion.MultiSelect = false;
            this.lstEnPreparacion.Name = "lstEnPreparacion";
            this.lstEnPreparacion.Size = new System.Drawing.Size(523, 339);
            this.lstEnPreparacion.TabIndex = 5;
            this.lstEnPreparacion.UseCompatibleStateImageBehavior = false;
            this.lstEnPreparacion.View = System.Windows.Forms.View.Details;
            // 
            // idPedido
            // 
            this.idPedido.Text = "Nro de pedido";
            this.idPedido.Width = 100;
            // 
            // nombreCliente
            // 
            this.nombreCliente.Text = "Cliente";
            this.nombreCliente.Width = 120;
            // 
            // fechaYHora
            // 
            this.fechaYHora.Text = "Fecha y hora";
            this.fechaYHora.Width = 120;
            // 
            // total
            // 
            this.total.Text = "Total";
            // 
            // tiempoPreparacion
            // 
            this.tiempoPreparacion.Text = "Tiempo de preparacion";
            this.tiempoPreparacion.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pedidos en preparación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pedidos para entregar/enviar";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 470);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstEnPreparacion);
            this.Controls.Add(this.lblFechaYHora);
            this.Controls.Add(this.dgvCompletados);
            this.Controls.Add(this.btnNuevoPedido);
            this.Name = "frmPrincipal";
            this.Text = "Pizzeria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.DataGridView dgvCompletados;
        private System.Windows.Forms.Timer timerActualizarPedidos;
        private System.Windows.Forms.Label lblFechaYHora;
        private System.Windows.Forms.ListView lstEnPreparacion;
        private System.Windows.Forms.ColumnHeader idPedido;
        private System.Windows.Forms.ColumnHeader nombreCliente;
        private System.Windows.Forms.ColumnHeader fechaYHora;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.ColumnHeader tiempoPreparacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

