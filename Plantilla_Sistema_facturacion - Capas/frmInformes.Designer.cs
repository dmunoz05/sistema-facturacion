
namespace Plantilla_Sistema_facturacion
{
    partial class frmInformes
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
            this.gbxFactura = new System.Windows.Forms.GroupBox();
            this.rbnExcel = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbnEnPDF = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbnPantalla = new MaterialSkin.Controls.MaterialRadioButton();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.cmbOrdenarPor = new System.Windows.Forms.ComboBox();
            this.lblFechaInicio = new MaterialSkin.Controls.MaterialLabel();
            this.lblSeleccioneInforme = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaFinal = new MaterialSkin.Controls.MaterialLabel();
            this.lblOrderpor = new MaterialSkin.Controls.MaterialLabel();
            this.cmbSeleccionInforme = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.btnGenerarInforme = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.gbxFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxFactura
            // 
            this.gbxFactura.Controls.Add(this.rbnExcel);
            this.gbxFactura.Controls.Add(this.rbnEnPDF);
            this.gbxFactura.Controls.Add(this.rbnPantalla);
            this.gbxFactura.Controls.Add(this.dtpFechaFinal);
            this.gbxFactura.Controls.Add(this.dtpFechaInicio);
            this.gbxFactura.Controls.Add(this.cmbOrdenarPor);
            this.gbxFactura.Controls.Add(this.lblFechaInicio);
            this.gbxFactura.Controls.Add(this.lblSeleccioneInforme);
            this.gbxFactura.Controls.Add(this.lblFechaFinal);
            this.gbxFactura.Controls.Add(this.lblOrderpor);
            this.gbxFactura.Controls.Add(this.cmbSeleccionInforme);
            this.gbxFactura.Location = new System.Drawing.Point(108, 52);
            this.gbxFactura.Name = "gbxFactura";
            this.gbxFactura.Size = new System.Drawing.Size(785, 225);
            this.gbxFactura.TabIndex = 15;
            this.gbxFactura.TabStop = false;
            // 
            // rbnExcel
            // 
            this.rbnExcel.AutoSize = true;
            this.rbnExcel.Depth = 0;
            this.rbnExcel.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbnExcel.Location = new System.Drawing.Point(522, 169);
            this.rbnExcel.Margin = new System.Windows.Forms.Padding(0);
            this.rbnExcel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbnExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbnExcel.Name = "rbnExcel";
            this.rbnExcel.Ripple = true;
            this.rbnExcel.Size = new System.Drawing.Size(81, 30);
            this.rbnExcel.TabIndex = 26;
            this.rbnExcel.TabStop = true;
            this.rbnExcel.Text = "En Excel";
            this.rbnExcel.UseVisualStyleBackColor = true;
            // 
            // rbnEnPDF
            // 
            this.rbnEnPDF.AutoSize = true;
            this.rbnEnPDF.Depth = 0;
            this.rbnEnPDF.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbnEnPDF.Location = new System.Drawing.Point(364, 169);
            this.rbnEnPDF.Margin = new System.Windows.Forms.Padding(0);
            this.rbnEnPDF.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbnEnPDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbnEnPDF.Name = "rbnEnPDF";
            this.rbnEnPDF.Ripple = true;
            this.rbnEnPDF.Size = new System.Drawing.Size(73, 30);
            this.rbnEnPDF.TabIndex = 25;
            this.rbnEnPDF.TabStop = true;
            this.rbnEnPDF.Text = "En PDF";
            this.rbnEnPDF.UseVisualStyleBackColor = true;
            // 
            // rbnPantalla
            // 
            this.rbnPantalla.AutoSize = true;
            this.rbnPantalla.Depth = 0;
            this.rbnPantalla.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbnPantalla.Location = new System.Drawing.Point(199, 169);
            this.rbnPantalla.Margin = new System.Windows.Forms.Padding(0);
            this.rbnPantalla.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbnPantalla.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbnPantalla.Name = "rbnPantalla";
            this.rbnPantalla.Ripple = true;
            this.rbnPantalla.Size = new System.Drawing.Size(98, 30);
            this.rbnPantalla.TabIndex = 24;
            this.rbnPantalla.TabStop = true;
            this.rbnPantalla.Text = "En Pantalla";
            this.rbnPantalla.UseVisualStyleBackColor = true;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(476, 100);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFinal.TabIndex = 23;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(125, 98);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 22;
            // 
            // cmbOrdenarPor
            // 
            this.cmbOrdenarPor.FormattingEnabled = true;
            this.cmbOrdenarPor.Location = new System.Drawing.Point(557, 37);
            this.cmbOrdenarPor.Name = "cmbOrdenarPor";
            this.cmbOrdenarPor.Size = new System.Drawing.Size(160, 21);
            this.cmbOrdenarPor.TabIndex = 20;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Depth = 0;
            this.lblFechaInicio.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaInicio.Location = new System.Drawing.Point(21, 98);
            this.lblFechaInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(98, 19);
            this.lblFechaInicio.TabIndex = 18;
            this.lblFechaInicio.Text = "Fecha Inicio :";
            // 
            // lblSeleccioneInforme
            // 
            this.lblSeleccioneInforme.AutoSize = true;
            this.lblSeleccioneInforme.Depth = 0;
            this.lblSeleccioneInforme.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSeleccioneInforme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSeleccioneInforme.Location = new System.Drawing.Point(21, 40);
            this.lblSeleccioneInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSeleccioneInforme.Name = "lblSeleccioneInforme";
            this.lblSeleccioneInforme.Size = new System.Drawing.Size(147, 19);
            this.lblSeleccioneInforme.TabIndex = 17;
            this.lblSeleccioneInforme.Text = "Seleccione Informe :";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Depth = 0;
            this.lblFechaFinal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaFinal.Location = new System.Drawing.Point(377, 100);
            this.lblFechaFinal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(93, 19);
            this.lblFechaFinal.TabIndex = 10;
            this.lblFechaFinal.Text = "Fecha Final :";
            // 
            // lblOrderpor
            // 
            this.lblOrderpor.AutoSize = true;
            this.lblOrderpor.Depth = 0;
            this.lblOrderpor.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblOrderpor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOrderpor.Location = new System.Drawing.Point(452, 37);
            this.lblOrderpor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOrderpor.Name = "lblOrderpor";
            this.lblOrderpor.Size = new System.Drawing.Size(99, 19);
            this.lblOrderpor.TabIndex = 9;
            this.lblOrderpor.Text = "Ordenar por : ";
            // 
            // cmbSeleccionInforme
            // 
            this.cmbSeleccionInforme.FormattingEnabled = true;
            this.cmbSeleccionInforme.Location = new System.Drawing.Point(174, 38);
            this.cmbSeleccionInforme.Name = "cmbSeleccionInforme";
            this.cmbSeleccionInforme.Size = new System.Drawing.Size(242, 21);
            this.cmbSeleccionInforme.TabIndex = 12;
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
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "ADMINISTRACION DE FACTURAS";
            // 
            // btnGenerarInforme
            // 
            this.btnGenerarInforme.Depth = 0;
            this.btnGenerarInforme.Location = new System.Drawing.Point(108, 307);
            this.btnGenerarInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerarInforme.Name = "btnGenerarInforme";
            this.btnGenerarInforme.Primary = true;
            this.btnGenerarInforme.Size = new System.Drawing.Size(150, 23);
            this.btnGenerarInforme.TabIndex = 17;
            this.btnGenerarInforme.Text = "GENERAR INFORME";
            this.btnGenerarInforme.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(743, 307);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(150, 23);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Location = new System.Drawing.Point(108, 350);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.Size = new System.Drawing.Size(785, 180);
            this.dgvFacturas.TabIndex = 19;
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 586);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGenerarInforme);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gbxFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInformes";
            this.Text = "frmInformes";
            this.gbxFactura.ResumeLayout(false);
            this.gbxFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFactura;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.ComboBox cmbOrdenarPor;
        private MaterialSkin.Controls.MaterialLabel lblFechaInicio;
        private MaterialSkin.Controls.MaterialLabel lblSeleccioneInforme;
        private MaterialSkin.Controls.MaterialLabel lblFechaFinal;
        private MaterialSkin.Controls.MaterialLabel lblOrderpor;
        private System.Windows.Forms.ComboBox cmbSeleccionInforme;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private MaterialSkin.Controls.MaterialRadioButton rbnExcel;
        private MaterialSkin.Controls.MaterialRadioButton rbnEnPDF;
        private MaterialSkin.Controls.MaterialRadioButton rbnPantalla;
        private MaterialSkin.Controls.MaterialRaisedButton btnGenerarInforme;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.DataGridView dgvFacturas;
    }
}