
namespace Plantilla_Sistema_facturacion
{
    partial class FrmEditarProducto
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
            this.lblId = new MaterialSkin.Controls.MaterialLabel();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrecioCompra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNumStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCodigoReferencia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIdCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioVenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.rtbDescripcionProducto = new System.Windows.Forms.RichTextBox();
            this.lblDatosAdicionales = new MaterialSkin.Controls.MaterialLabel();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtpFechaModifica = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Depth = 0;
            this.lblId.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblId.Location = new System.Drawing.Point(87, 112);
            this.lblId.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 19);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "ID";
            this.lblId.Visible = false;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(21, 112);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(60, 20);
            this.txtIdProducto.TabIndex = 1;
            this.txtIdProducto.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrecioCompra);
            this.groupBox1.Controls.Add(this.txtNombreProducto);
            this.groupBox1.Controls.Add(this.txtNumStock);
            this.groupBox1.Controls.Add(this.txtCodigoReferencia);
            this.groupBox1.Controls.Add(this.txtIdCategoria);
            this.groupBox1.Controls.Add(this.txtPrecioVenta);
            this.groupBox1.Location = new System.Drawing.Point(20, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 289);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Depth = 0;
            this.txtPrecioCompra.Hint = "Precio Compra";
            this.txtPrecioCompra.Location = new System.Drawing.Point(20, 148);
            this.txtPrecioCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.PasswordChar = '\0';
            this.txtPrecioCompra.SelectedText = "";
            this.txtPrecioCompra.SelectionLength = 0;
            this.txtPrecioCompra.SelectionStart = 0;
            this.txtPrecioCompra.Size = new System.Drawing.Size(206, 23);
            this.txtPrecioCompra.TabIndex = 5;
            this.txtPrecioCompra.UseSystemPasswordChar = false;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Depth = 0;
            this.txtNombreProducto.Hint = "Nombre Producto";
            this.txtNombreProducto.Location = new System.Drawing.Point(20, 19);
            this.txtNombreProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.PasswordChar = '\0';
            this.txtNombreProducto.SelectedText = "";
            this.txtNombreProducto.SelectionLength = 0;
            this.txtNombreProducto.SelectionStart = 0;
            this.txtNombreProducto.Size = new System.Drawing.Size(302, 23);
            this.txtNombreProducto.TabIndex = 2;
            this.txtNombreProducto.UseSystemPasswordChar = false;
            // 
            // txtNumStock
            // 
            this.txtNumStock.Depth = 0;
            this.txtNumStock.Hint = "Numero Stock";
            this.txtNumStock.Location = new System.Drawing.Point(20, 236);
            this.txtNumStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumStock.Name = "txtNumStock";
            this.txtNumStock.PasswordChar = '\0';
            this.txtNumStock.SelectedText = "";
            this.txtNumStock.SelectionLength = 0;
            this.txtNumStock.SelectionStart = 0;
            this.txtNumStock.Size = new System.Drawing.Size(206, 23);
            this.txtNumStock.TabIndex = 7;
            this.txtNumStock.UseSystemPasswordChar = false;
            // 
            // txtCodigoReferencia
            // 
            this.txtCodigoReferencia.Depth = 0;
            this.txtCodigoReferencia.Hint = "Código Referencia";
            this.txtCodigoReferencia.Location = new System.Drawing.Point(20, 65);
            this.txtCodigoReferencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigoReferencia.Name = "txtCodigoReferencia";
            this.txtCodigoReferencia.PasswordChar = '\0';
            this.txtCodigoReferencia.SelectedText = "";
            this.txtCodigoReferencia.SelectionLength = 0;
            this.txtCodigoReferencia.SelectionStart = 0;
            this.txtCodigoReferencia.Size = new System.Drawing.Size(206, 23);
            this.txtCodigoReferencia.TabIndex = 3;
            this.txtCodigoReferencia.UseSystemPasswordChar = false;
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Depth = 0;
            this.txtIdCategoria.Hint = "Id Categoria";
            this.txtIdCategoria.Location = new System.Drawing.Point(20, 193);
            this.txtIdCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.PasswordChar = '\0';
            this.txtIdCategoria.SelectedText = "";
            this.txtIdCategoria.SelectionLength = 0;
            this.txtIdCategoria.SelectionStart = 0;
            this.txtIdCategoria.Size = new System.Drawing.Size(206, 23);
            this.txtIdCategoria.TabIndex = 6;
            this.txtIdCategoria.UseSystemPasswordChar = false;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Depth = 0;
            this.txtPrecioVenta.Hint = "Precio Venta";
            this.txtPrecioVenta.Location = new System.Drawing.Point(20, 106);
            this.txtPrecioVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.PasswordChar = '\0';
            this.txtPrecioVenta.SelectedText = "";
            this.txtPrecioVenta.SelectionLength = 0;
            this.txtPrecioVenta.SelectionStart = 0;
            this.txtPrecioVenta.Size = new System.Drawing.Size(206, 23);
            this.txtPrecioVenta.TabIndex = 4;
            this.txtPrecioVenta.UseSystemPasswordChar = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(87, 77);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(179, 19);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "ACTUALIZAR PRODUCTO";
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(256, 604);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(101, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(20, 604);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(97, 23);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // rtbDescripcionProducto
            // 
            this.rtbDescripcionProducto.Location = new System.Drawing.Point(20, 485);
            this.rtbDescripcionProducto.Name = "rtbDescripcionProducto";
            this.rtbDescripcionProducto.Size = new System.Drawing.Size(337, 101);
            this.rtbDescripcionProducto.TabIndex = 8;
            this.rtbDescripcionProducto.Text = "";
            // 
            // lblDatosAdicionales
            // 
            this.lblDatosAdicionales.AutoSize = true;
            this.lblDatosAdicionales.Depth = 0;
            this.lblDatosAdicionales.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDatosAdicionales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDatosAdicionales.Location = new System.Drawing.Point(17, 452);
            this.lblDatosAdicionales.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDatosAdicionales.Name = "lblDatosAdicionales";
            this.lblDatosAdicionales.Size = new System.Drawing.Size(178, 19);
            this.lblDatosAdicionales.TabIndex = 19;
            this.lblDatosAdicionales.Text = "Descripción del Producto";
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // dtpFechaModifica
            // 
            this.dtpFechaModifica.Location = new System.Drawing.Point(273, 452);
            this.dtpFechaModifica.Name = "dtpFechaModifica";
            this.dtpFechaModifica.Size = new System.Drawing.Size(84, 20);
            this.dtpFechaModifica.TabIndex = 20;
            this.dtpFechaModifica.Visible = false;
            // 
            // FrmEditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 639);
            this.Controls.Add(this.dtpFechaModifica);
            this.Controls.Add(this.lblDatosAdicionales);
            this.Controls.Add(this.rtbDescripcionProducto);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Name = "FrmEditarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Producto";
            this.Load += new System.EventHandler(this.FrmEditarProducto_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblId;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumStock;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigoReferencia;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioVenta;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioCompra;
        private System.Windows.Forms.RichTextBox rtbDescripcionProducto;
        private MaterialSkin.Controls.MaterialLabel lblDatosAdicionales;
        private System.Windows.Forms.ErrorProvider MensajeError;
        private System.Windows.Forms.DateTimePicker dtpFechaModifica;
    }
}