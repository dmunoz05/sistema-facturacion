
namespace Plantilla_Sistema_facturacion
{
    partial class frmFacturas
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
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnRegistros = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnConsultar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscarIdFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnLimpiar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgFacturas = new System.Windows.Forms.DataGridView();
            this.id_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_lmpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strFechaModifica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(400, 30);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(235, 19);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "ADMINISTRACION DE FACTURAS";
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(754, 515);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(137, 23);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // BtnRegistros
            // 
            this.BtnRegistros.Depth = 0;
            this.BtnRegistros.Location = new System.Drawing.Point(611, 97);
            this.BtnRegistros.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnRegistros.Name = "BtnRegistros";
            this.BtnRegistros.Primary = true;
            this.BtnRegistros.Size = new System.Drawing.Size(137, 23);
            this.BtnRegistros.TabIndex = 29;
            this.BtnRegistros.Text = "REGISTROS";
            this.BtnRegistros.UseVisualStyleBackColor = true;
            this.BtnRegistros.Click += new System.EventHandler(this.BtnRegistros_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Depth = 0;
            this.btnConsultar.Location = new System.Drawing.Point(329, 97);
            this.btnConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Primary = true;
            this.btnConsultar.Size = new System.Drawing.Size(137, 23);
            this.btnConsultar.TabIndex = 27;
            this.btnConsultar.Text = "BUSCAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtBuscarIdFactura
            // 
            this.txtBuscarIdFactura.Depth = 0;
            this.txtBuscarIdFactura.Hint = "Buscar por Numero de Factura";
            this.txtBuscarIdFactura.Location = new System.Drawing.Point(107, 97);
            this.txtBuscarIdFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarIdFactura.Name = "txtBuscarIdFactura";
            this.txtBuscarIdFactura.PasswordChar = '\0';
            this.txtBuscarIdFactura.SelectedText = "";
            this.txtBuscarIdFactura.SelectionLength = 0;
            this.txtBuscarIdFactura.SelectionStart = 0;
            this.txtBuscarIdFactura.Size = new System.Drawing.Size(216, 23);
            this.txtBuscarIdFactura.TabIndex = 28;
            this.txtBuscarIdFactura.UseSystemPasswordChar = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Depth = 0;
            this.btnLimpiar.Location = new System.Drawing.Point(754, 97);
            this.btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Primary = true;
            this.btnLimpiar.Size = new System.Drawing.Size(137, 23);
            this.btnLimpiar.TabIndex = 26;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Location = new System.Drawing.Point(468, 97);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(137, 23);
            this.btnNuevo.TabIndex = 25;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // dgFacturas
            // 
            this.dgFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Factura,
            this.strFecha,
            this.Id_Cliente,
            this.Id_Empleado,
            this.Num_Descuento,
            this.Num_lmpuesto,
            this.Valor_Total,
            this.Id_Estado,
            this.strFechaModifica,
            this.btnEditar});
            this.dgFacturas.Location = new System.Drawing.Point(108, 142);
            this.dgFacturas.Name = "dgFacturas";
            this.dgFacturas.Size = new System.Drawing.Size(783, 355);
            this.dgFacturas.TabIndex = 30;
            this.dgFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFacturas_CellContentClick);
            // 
            // id_Factura
            // 
            this.id_Factura.HeaderText = "NRO FACTURA";
            this.id_Factura.Name = "id_Factura";
            this.id_Factura.Width = 80;
            // 
            // strFecha
            // 
            this.strFecha.HeaderText = "FECHA CREACION";
            this.strFecha.Name = "strFecha";
            // 
            // Id_Cliente
            // 
            this.Id_Cliente.HeaderText = "NOMBRE CLIENTE";
            this.Id_Cliente.Name = "Id_Cliente";
            // 
            // Id_Empleado
            // 
            this.Id_Empleado.HeaderText = "NOMBRE EMPLEADO";
            this.Id_Empleado.Name = "Id_Empleado";
            // 
            // Num_Descuento
            // 
            this.Num_Descuento.HeaderText = "DESCUENTO";
            this.Num_Descuento.Name = "Num_Descuento";
            // 
            // Num_lmpuesto
            // 
            this.Num_lmpuesto.HeaderText = "IMPUESTO";
            this.Num_lmpuesto.Name = "Num_lmpuesto";
            // 
            // Valor_Total
            // 
            this.Valor_Total.HeaderText = "VALOR TOTAL";
            this.Valor_Total.Name = "Valor_Total";
            // 
            // Id_Estado
            // 
            this.Id_Estado.HeaderText = "ESTADO FACTURA";
            this.Id_Estado.Name = "Id_Estado";
            // 
            // strFechaModifica
            // 
            this.strFechaModifica.HeaderText = "FECHA MODIFICACION";
            this.strFechaModifica.Name = "strFechaModifica";
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "EDITAR";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseColumnTextForButtonValue = true;
            this.btnEditar.Width = 80;
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 586);
            this.Controls.Add(this.dgFacturas);
            this.Controls.Add(this.BtnRegistros);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtBuscarIdFactura);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFacturas";
            this.Text = "frmFacturas";
            this.Load += new System.EventHandler(this.frmFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton BtnRegistros;
        private MaterialSkin.Controls.MaterialRaisedButton btnConsultar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarIdFactura;
        private MaterialSkin.Controls.MaterialRaisedButton btnLimpiar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private System.Windows.Forms.DataGridView dgFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn strFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_lmpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn strFechaModifica;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
    }
}