
namespace Plantilla_Sistema_facturacion
{
    partial class frmRolEmpleados
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgRoles = new System.Windows.Forms.DataGridView();
            this.Id_RolEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strNombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscarNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnRegistros = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLimpiar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(423, 31);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(150, 19);
            this.materialLabel1.TabIndex = 16;
            this.materialLabel1.Text = "ROL DE EMPLEADOS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgRoles);
            this.groupBox2.Controls.Add(this.btnConsultar);
            this.groupBox2.Controls.Add(this.txtBuscarNombre);
            this.groupBox2.Location = new System.Drawing.Point(81, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(785, 360);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // dgRoles
            // 
            this.dgRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_RolEmpleado,
            this.strNombreCategoria});
            this.dgRoles.Location = new System.Drawing.Point(208, 76);
            this.dgRoles.Name = "dgRoles";
            this.dgRoles.Size = new System.Drawing.Size(422, 278);
            this.dgRoles.TabIndex = 24;
            this.dgRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRoles_CellContentClick);
            // 
            // Id_RolEmpleado
            // 
            this.Id_RolEmpleado.HeaderText = "ID";
            this.Id_RolEmpleado.Name = "Id_RolEmpleado";
            this.Id_RolEmpleado.Width = 80;
            // 
            // strNombreCategoria
            // 
            this.strNombreCategoria.HeaderText = "NOMBRE ROL";
            this.strNombreCategoria.Name = "strNombreCategoria";
            this.strNombreCategoria.Width = 300;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Depth = 0;
            this.btnConsultar.Location = new System.Drawing.Point(506, 30);
            this.btnConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Primary = true;
            this.btnConsultar.Size = new System.Drawing.Size(124, 23);
            this.btnConsultar.TabIndex = 21;
            this.btnConsultar.Text = "BUSCAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Depth = 0;
            this.txtBuscarNombre.Hint = "Buscar por Nombre Rol";
            this.txtBuscarNombre.Location = new System.Drawing.Point(208, 30);
            this.txtBuscarNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.PasswordChar = '\0';
            this.txtBuscarNombre.SelectedText = "";
            this.txtBuscarNombre.SelectionLength = 0;
            this.txtBuscarNombre.SelectionStart = 0;
            this.txtBuscarNombre.Size = new System.Drawing.Size(292, 23);
            this.txtBuscarNombre.TabIndex = 22;
            this.txtBuscarNombre.UseSystemPasswordChar = false;
            // 
            // BtnRegistros
            // 
            this.BtnRegistros.Depth = 0;
            this.BtnRegistros.Location = new System.Drawing.Point(81, 478);
            this.BtnRegistros.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnRegistros.Name = "BtnRegistros";
            this.BtnRegistros.Primary = true;
            this.BtnRegistros.Size = new System.Drawing.Size(173, 23);
            this.BtnRegistros.TabIndex = 25;
            this.BtnRegistros.Text = "REGISTROS";
            this.BtnRegistros.UseVisualStyleBackColor = true;
            this.BtnRegistros.Click += new System.EventHandler(this.BtnRegistros_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Depth = 0;
            this.btnLimpiar.Location = new System.Drawing.Point(400, 478);
            this.btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Primary = true;
            this.btnLimpiar.Size = new System.Drawing.Size(173, 23);
            this.btnLimpiar.TabIndex = 27;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(693, 478);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(173, 23);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // frmRolEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 586);
            this.Controls.Add(this.BtnRegistros);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRolEmpleados";
            this.Text = "frmRolEmpleados";
            this.Load += new System.EventHandler(this.frmRolEmpleados_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgRoles;
        private MaterialSkin.Controls.MaterialRaisedButton btnConsultar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarNombre;
        private MaterialSkin.Controls.MaterialRaisedButton BtnRegistros;
        private MaterialSkin.Controls.MaterialRaisedButton btnLimpiar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_RolEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn strNombreCategoria;
    }
}