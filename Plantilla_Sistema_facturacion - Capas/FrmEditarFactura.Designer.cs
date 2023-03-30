
namespace Plantilla_Sistema_facturacion
{
    partial class FrmEditarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarFactura));
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditarEstadoFactura = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblDetalleAdicional = new MaterialSkin.Controls.MaterialLabel();
            this.dtpMostrarFechaModificacion = new System.Windows.Forms.DateTimePicker();
            this.rtbDatosAdicionales = new System.Windows.Forms.RichTextBox();
            this.dtpMostrarFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.lblEstadoFactura = new MaterialSkin.Controls.MaterialLabel();
            this.cmbEstadoFactura = new System.Windows.Forms.ComboBox();
            this.txtIdEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtValorTotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtImpuesto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDescuento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dtpFechaModifica = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIngreso = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.txtIdCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.DtmFecha = new MaterialSkin.Controls.MaterialLabel();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblIdFactura = new MaterialSkin.Controls.MaterialLabel();
            this.txtIdFactura = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(310, 70);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(168, 19);
            this.lblTitulo.TabIndex = 21;
            this.lblTitulo.Text = "ACTUALIZAR FACTURA";
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(626, 525);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(125, 23);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(32, 525);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(125, 23);
            this.btnActualizar.TabIndex = 19;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditarEstadoFactura);
            this.groupBox1.Controls.Add(this.lblDetalleAdicional);
            this.groupBox1.Controls.Add(this.dtpMostrarFechaModificacion);
            this.groupBox1.Controls.Add(this.rtbDatosAdicionales);
            this.groupBox1.Controls.Add(this.dtpMostrarFechaCreacion);
            this.groupBox1.Controls.Add(this.lblEstadoFactura);
            this.groupBox1.Controls.Add(this.cmbEstadoFactura);
            this.groupBox1.Controls.Add(this.txtIdEmpleado);
            this.groupBox1.Controls.Add(this.txtValorTotal);
            this.groupBox1.Controls.Add(this.txtImpuesto);
            this.groupBox1.Controls.Add(this.txtDescuento);
            this.groupBox1.Controls.Add(this.dtpFechaModifica);
            this.groupBox1.Controls.Add(this.lblFechaIngreso);
            this.groupBox1.Controls.Add(this.dtpFechaCreacion);
            this.groupBox1.Controls.Add(this.txtIdCliente);
            this.groupBox1.Controls.Add(this.DtmFecha);
            this.groupBox1.Location = new System.Drawing.Point(32, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 390);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // btnEditarEstadoFactura
            // 
            this.btnEditarEstadoFactura.Depth = 0;
            this.btnEditarEstadoFactura.Location = new System.Drawing.Point(618, 23);
            this.btnEditarEstadoFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarEstadoFactura.Name = "btnEditarEstadoFactura";
            this.btnEditarEstadoFactura.Primary = true;
            this.btnEditarEstadoFactura.Size = new System.Drawing.Size(81, 23);
            this.btnEditarEstadoFactura.TabIndex = 37;
            this.btnEditarEstadoFactura.Text = "Editar";
            this.btnEditarEstadoFactura.UseVisualStyleBackColor = true;
            this.btnEditarEstadoFactura.Click += new System.EventHandler(this.btnEditarEstadoFactura_Click);
            // 
            // lblDetalleAdicional
            // 
            this.lblDetalleAdicional.AutoSize = true;
            this.lblDetalleAdicional.Depth = 0;
            this.lblDetalleAdicional.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDetalleAdicional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDetalleAdicional.Location = new System.Drawing.Point(353, 180);
            this.lblDetalleAdicional.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDetalleAdicional.Name = "lblDetalleAdicional";
            this.lblDetalleAdicional.Size = new System.Drawing.Size(110, 19);
            this.lblDetalleAdicional.TabIndex = 34;
            this.lblDetalleAdicional.Text = "Detalle Factura";
            // 
            // dtpMostrarFechaModificacion
            // 
            this.dtpMostrarFechaModificacion.Location = new System.Drawing.Point(479, 133);
            this.dtpMostrarFechaModificacion.Name = "dtpMostrarFechaModificacion";
            this.dtpMostrarFechaModificacion.Size = new System.Drawing.Size(220, 20);
            this.dtpMostrarFechaModificacion.TabIndex = 36;
            // 
            // rtbDatosAdicionales
            // 
            this.rtbDatosAdicionales.Location = new System.Drawing.Point(357, 211);
            this.rtbDatosAdicionales.Name = "rtbDatosAdicionales";
            this.rtbDatosAdicionales.Size = new System.Drawing.Size(342, 164);
            this.rtbDatosAdicionales.TabIndex = 33;
            this.rtbDatosAdicionales.Text = resources.GetString("rtbDatosAdicionales.Text");
            // 
            // dtpMostrarFechaCreacion
            // 
            this.dtpMostrarFechaCreacion.Location = new System.Drawing.Point(484, 77);
            this.dtpMostrarFechaCreacion.Name = "dtpMostrarFechaCreacion";
            this.dtpMostrarFechaCreacion.Size = new System.Drawing.Size(215, 20);
            this.dtpMostrarFechaCreacion.TabIndex = 35;
            // 
            // lblEstadoFactura
            // 
            this.lblEstadoFactura.AutoSize = true;
            this.lblEstadoFactura.Depth = 0;
            this.lblEstadoFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstadoFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadoFactura.Location = new System.Drawing.Point(353, 23);
            this.lblEstadoFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadoFactura.Name = "lblEstadoFactura";
            this.lblEstadoFactura.Size = new System.Drawing.Size(122, 19);
            this.lblEstadoFactura.TabIndex = 34;
            this.lblEstadoFactura.Text = "Estado Factura  :";
            // 
            // cmbEstadoFactura
            // 
            this.cmbEstadoFactura.FormattingEnabled = true;
            this.cmbEstadoFactura.Location = new System.Drawing.Point(484, 24);
            this.cmbEstadoFactura.Name = "cmbEstadoFactura";
            this.cmbEstadoFactura.Size = new System.Drawing.Size(128, 21);
            this.cmbEstadoFactura.TabIndex = 33;
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Depth = 0;
            this.txtIdEmpleado.Hint = "Id Empleado";
            this.txtIdEmpleado.Location = new System.Drawing.Point(6, 24);
            this.txtIdEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.PasswordChar = '\0';
            this.txtIdEmpleado.SelectedText = "";
            this.txtIdEmpleado.SelectionLength = 0;
            this.txtIdEmpleado.SelectionStart = 0;
            this.txtIdEmpleado.Size = new System.Drawing.Size(219, 23);
            this.txtIdEmpleado.TabIndex = 32;
            this.txtIdEmpleado.UseSystemPasswordChar = false;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Depth = 0;
            this.txtValorTotal.Hint = "Valor Total";
            this.txtValorTotal.Location = new System.Drawing.Point(6, 292);
            this.txtValorTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.PasswordChar = '\0';
            this.txtValorTotal.SelectedText = "";
            this.txtValorTotal.SelectionLength = 0;
            this.txtValorTotal.SelectionStart = 0;
            this.txtValorTotal.Size = new System.Drawing.Size(219, 23);
            this.txtValorTotal.TabIndex = 26;
            this.txtValorTotal.UseSystemPasswordChar = false;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Depth = 0;
            this.txtImpuesto.Hint = "Impuesto";
            this.txtImpuesto.Location = new System.Drawing.Point(6, 222);
            this.txtImpuesto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.PasswordChar = '\0';
            this.txtImpuesto.SelectedText = "";
            this.txtImpuesto.SelectionLength = 0;
            this.txtImpuesto.SelectionStart = 0;
            this.txtImpuesto.Size = new System.Drawing.Size(219, 23);
            this.txtImpuesto.TabIndex = 25;
            this.txtImpuesto.UseSystemPasswordChar = false;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Depth = 0;
            this.txtDescuento.Hint = "Descuento";
            this.txtDescuento.Location = new System.Drawing.Point(6, 155);
            this.txtDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.PasswordChar = '\0';
            this.txtDescuento.SelectedText = "";
            this.txtDescuento.SelectionLength = 0;
            this.txtDescuento.SelectionStart = 0;
            this.txtDescuento.Size = new System.Drawing.Size(219, 23);
            this.txtDescuento.TabIndex = 24;
            this.txtDescuento.UseSystemPasswordChar = false;
            // 
            // dtpFechaModifica
            // 
            this.dtpFechaModifica.Location = new System.Drawing.Point(282, 133);
            this.dtpFechaModifica.Name = "dtpFechaModifica";
            this.dtpFechaModifica.Size = new System.Drawing.Size(65, 20);
            this.dtpFechaModifica.TabIndex = 31;
            this.dtpFechaModifica.Visible = false;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Depth = 0;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaIngreso.Location = new System.Drawing.Point(353, 135);
            this.lblFechaIngreso.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(120, 19);
            this.lblFechaIngreso.TabIndex = 29;
            this.lblFechaIngreso.Text = "Fecha Modifica :";
            // 
            // dtpFechaCreacion
            // 
            this.dtpFechaCreacion.Location = new System.Drawing.Point(282, 77);
            this.dtpFechaCreacion.Name = "dtpFechaCreacion";
            this.dtpFechaCreacion.Size = new System.Drawing.Size(65, 20);
            this.dtpFechaCreacion.TabIndex = 30;
            this.dtpFechaCreacion.Visible = false;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Depth = 0;
            this.txtIdCliente.Hint = "Id Cliente";
            this.txtIdCliente.Location = new System.Drawing.Point(6, 89);
            this.txtIdCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.PasswordChar = '\0';
            this.txtIdCliente.SelectedText = "";
            this.txtIdCliente.SelectionLength = 0;
            this.txtIdCliente.SelectionStart = 0;
            this.txtIdCliente.Size = new System.Drawing.Size(219, 23);
            this.txtIdCliente.TabIndex = 23;
            this.txtIdCliente.UseSystemPasswordChar = false;
            // 
            // DtmFecha
            // 
            this.DtmFecha.AutoSize = true;
            this.DtmFecha.Depth = 0;
            this.DtmFecha.Font = new System.Drawing.Font("Roboto", 11F);
            this.DtmFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DtmFecha.Location = new System.Drawing.Point(353, 77);
            this.DtmFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.DtmFecha.Name = "DtmFecha";
            this.DtmFecha.Size = new System.Drawing.Size(125, 19);
            this.DtmFecha.TabIndex = 26;
            this.DtmFecha.Text = "Fecha Creación  :";
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // lblIdFactura
            // 
            this.lblIdFactura.AutoSize = true;
            this.lblIdFactura.Depth = 0;
            this.lblIdFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblIdFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIdFactura.Location = new System.Drawing.Point(98, 91);
            this.lblIdFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdFactura.Name = "lblIdFactura";
            this.lblIdFactura.Size = new System.Drawing.Size(93, 19);
            this.lblIdFactura.TabIndex = 26;
            this.lblIdFactura.Text = "ID FACTURA";
            this.lblIdFactura.Visible = false;
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.Location = new System.Drawing.Point(32, 92);
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.Size = new System.Drawing.Size(60, 20);
            this.txtIdFactura.TabIndex = 25;
            this.txtIdFactura.Text = "0";
            this.txtIdFactura.Visible = false;
            // 
            // FrmEditarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 560);
            this.Controls.Add(this.lblIdFactura);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtIdFactura);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Name = "FrmEditarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarFactura";
            this.Load += new System.EventHandler(this.FrmEditarFactura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtValorTotal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtImpuesto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescuento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdEmpleado;
        private System.Windows.Forms.ErrorProvider MensajeError;
        private System.Windows.Forms.DateTimePicker dtpFechaModifica;
        private MaterialSkin.Controls.MaterialLabel lblFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaCreacion;
        private MaterialSkin.Controls.MaterialLabel DtmFecha;
        private System.Windows.Forms.ComboBox cmbEstadoFactura;
        private System.Windows.Forms.DateTimePicker dtpMostrarFechaModificacion;
        private System.Windows.Forms.DateTimePicker dtpMostrarFechaCreacion;
        private MaterialSkin.Controls.MaterialLabel lblEstadoFactura;
        private MaterialSkin.Controls.MaterialLabel lblDetalleAdicional;
        private System.Windows.Forms.RichTextBox rtbDatosAdicionales;
        private MaterialSkin.Controls.MaterialLabel lblIdFactura;
        private System.Windows.Forms.TextBox txtIdFactura;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditarEstadoFactura;
    }
}