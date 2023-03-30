
namespace Plantilla_Sistema_facturacion
{
    partial class frmEmpleados
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLimpiar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgEmpleados = new System.Windows.Forms.DataGridView();
            this.id_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strRolEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strFechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strFechaRetiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strDatosAdicionales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnConsultar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscarNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnRegistros = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(350, 30);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(247, 19);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "ADMINISTRACION DE EMPLEADOS";
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(765, 493);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(99, 23);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Location = new System.Drawing.Point(548, 97);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(99, 23);
            this.btnNuevo.TabIndex = 18;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Depth = 0;
            this.btnLimpiar.Location = new System.Drawing.Point(765, 97);
            this.btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Primary = true;
            this.btnLimpiar.Size = new System.Drawing.Size(99, 23);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgEmpleados
            // 
            this.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Empleado,
            this.strEmpleado,
            this.strDocumento,
            this.strDireccion,
            this.strTelefono,
            this.strEmail,
            this.strRolEmpleado,
            this.strFechaIngreso,
            this.strFechaRetiro,
            this.strDatosAdicionales,
            this.btnEditar,
            this.btnBorrar});
            this.dgEmpleados.Location = new System.Drawing.Point(81, 126);
            this.dgEmpleados.Name = "dgEmpleados";
            this.dgEmpleados.Size = new System.Drawing.Size(783, 361);
            this.dgEmpleados.TabIndex = 21;
            this.dgEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmpleados_CellContentClick);
            // 
            // id_Empleado
            // 
            this.id_Empleado.HeaderText = "ID";
            this.id_Empleado.Name = "id_Empleado";
            this.id_Empleado.Width = 80;
            // 
            // strEmpleado
            // 
            this.strEmpleado.HeaderText = "NOMBRE EMPLEADO";
            this.strEmpleado.Name = "strEmpleado";
            this.strEmpleado.Width = 300;
            // 
            // strDocumento
            // 
            this.strDocumento.HeaderText = "DOCUMENTO";
            this.strDocumento.Name = "strDocumento";
            // 
            // strDireccion
            // 
            this.strDireccion.HeaderText = "DIRECCION";
            this.strDireccion.Name = "strDireccion";
            // 
            // strTelefono
            // 
            this.strTelefono.HeaderText = "TELEFONO";
            this.strTelefono.Name = "strTelefono";
            // 
            // strEmail
            // 
            this.strEmail.HeaderText = "EMAIL";
            this.strEmail.Name = "strEmail";
            // 
            // strRolEmpleado
            // 
            this.strRolEmpleado.HeaderText = "ROL EMPLEADO";
            this.strRolEmpleado.Name = "strRolEmpleado";
            // 
            // strFechaIngreso
            // 
            this.strFechaIngreso.HeaderText = "FECHA INGRESO";
            this.strFechaIngreso.Name = "strFechaIngreso";
            // 
            // strFechaRetiro
            // 
            this.strFechaRetiro.HeaderText = "FECHA RETIRO";
            this.strFechaRetiro.Name = "strFechaRetiro";
            // 
            // strDatosAdicionales
            // 
            this.strDatosAdicionales.HeaderText = "DATOS ADICIONALES";
            this.strDatosAdicionales.Name = "strDatosAdicionales";
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
            // btnBorrar
            // 
            this.btnBorrar.HeaderText = "BORRAR";
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnBorrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseColumnTextForButtonValue = true;
            this.btnBorrar.Width = 80;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Depth = 0;
            this.btnConsultar.Location = new System.Drawing.Point(443, 97);
            this.btnConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Primary = true;
            this.btnConsultar.Size = new System.Drawing.Size(99, 23);
            this.btnConsultar.TabIndex = 22;
            this.btnConsultar.Text = "BUSCAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Depth = 0;
            this.txtBuscarNombre.Hint = "Buscar por Nombre Empleado";
            this.txtBuscarNombre.Location = new System.Drawing.Point(81, 97);
            this.txtBuscarNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.PasswordChar = '\0';
            this.txtBuscarNombre.SelectedText = "";
            this.txtBuscarNombre.SelectionLength = 0;
            this.txtBuscarNombre.SelectionStart = 0;
            this.txtBuscarNombre.Size = new System.Drawing.Size(356, 23);
            this.txtBuscarNombre.TabIndex = 23;
            this.txtBuscarNombre.UseSystemPasswordChar = false;
            // 
            // BtnRegistros
            // 
            this.BtnRegistros.Depth = 0;
            this.BtnRegistros.Location = new System.Drawing.Point(660, 97);
            this.BtnRegistros.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnRegistros.Name = "BtnRegistros";
            this.BtnRegistros.Primary = true;
            this.BtnRegistros.Size = new System.Drawing.Size(99, 23);
            this.BtnRegistros.TabIndex = 24;
            this.BtnRegistros.Text = "REGISTROS";
            this.BtnRegistros.UseVisualStyleBackColor = true;
            this.BtnRegistros.Click += new System.EventHandler(this.BtnRegistros_Click);
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 586);
            this.Controls.Add(this.BtnRegistros);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtBuscarNombre);
            this.Controls.Add(this.dgEmpleados);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpleados";
            this.Text = "frmEmpleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private System.Windows.Forms.ErrorProvider MensajeError;
        private MaterialSkin.Controls.MaterialRaisedButton btnLimpiar;
        private System.Windows.Forms.DataGridView dgEmpleados;
        private MaterialSkin.Controls.MaterialRaisedButton btnConsultar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn strEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn strDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn strDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn strTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn strEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn strRolEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn strFechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn strFechaRetiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn strDatosAdicionales;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnRegistros;
    }
}