using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Capa_LogicaDeNegocios;

namespace Plantilla_Sistema_facturacion
{
    public partial class frmEditarEmpleado : MaterialForm
    {
        public frmEditarEmpleado()
        {
            InitializeComponent();
        }

        public int IdEmpleado { get; set; }

        DataTable dt = new DataTable();
        Cls_Empleados empleados = new Cls_Empleados();

        private void LLENAR_EMPLEADO()
        {
            if (IdEmpleado == 0)
            {
                lblTitulo.Text = "INGRESO NUEVO EMPLEADO";
            }
            else
            {
                lblTitulo.Text = "MODIFICAR EMPLEADO";
                Llenar_Campos();
            }
        }

        public void Llenar_Combo_Empleados()
        {
            cmbRolEmpleado.DataSource = empleados.ConsultarRol();
            cmbRolEmpleado.DisplayMember = "StrDescripcion";
            cmbRolEmpleado.ValueMember = "IdRolEmpleado";                   
        }

        public void Llenar_Combo_IdRolEmpleado_()
        {
            cmbRolEmpleado.DataSource = empleados.ConsultarRolEmpleado(Convert.ToInt32(cmbRolEmpleado.ValueMember.ToString()));
            cmbRolEmpleado.DisplayMember = "StrDescripcion";
            cmbRolEmpleado.ValueMember = "IdRolEmpleado";
        }

        public void Llenar_Campos()
        {
            dt = empleados.Consulta_Empleado(IdEmpleado);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {                    
                    txtIdEmpleado.Text = row[0].ToString();
                    txtNombreEmpleado.Text = row[1].ToString();
                    txtDocumentoEmpleado.Text = row[2].ToString();
                    txtDireccionEmpleado.Text = row[3].ToString();
                    txtTelefonoEmpleado.Text = row[4].ToString();
                    txtEmailEmpleado.Text = row[5].ToString();
                    cmbRolEmpleado.ValueMember = row[6].ToString();
                    dtpFechaIngreso.Value = Convert.ToDateTime(row[7].ToString());
                    dtpFechaRetiro.Value = Convert.ToDateTime(row[8].ToString());
                    rtbDatosAdicionales.Text = row[9].ToString();
                }
            }
        }

        private Boolean validar()
        {
            Boolean errorCampos = true;

            if (!esNumerico(txtIdEmpleado.Text))
            {
                MensajeError.SetError(txtIdEmpleado, "");
                txtIdEmpleado.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtNombreEmpleado, ""); }


            if (txtNombreEmpleado.Text == string.Empty)
            {
                MensajeError.SetError(txtNombreEmpleado, "Debe ingresar un valor de Nombre de Empleado");
                txtNombreEmpleado.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtNombreEmpleado, ""); }

            if (!esNumerico(txtDocumentoEmpleado.Text))
            {
                MensajeError.SetError(txtDocumentoEmpleado, "Debe ingresar un valor de Documento númerico");
                txtDocumentoEmpleado.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtDocumentoEmpleado, ""); }

            if (txtDireccionEmpleado.Text == string.Empty)
            {
                MensajeError.SetError(txtDireccionEmpleado, "Debe ingresar un valor de Dirección");
                txtDireccionEmpleado.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtDireccionEmpleado, ""); }

            if (!esNumerico(txtTelefonoEmpleado.Text))
            {
                MensajeError.SetError(txtTelefonoEmpleado, "Debe ingresar un valor de Teléfono númerico");
                txtTelefonoEmpleado.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtTelefonoEmpleado, ""); }

            if (txtEmailEmpleado.Text == string.Empty)
            {
                MensajeError.SetError(txtEmailEmpleado, "Debe ingresar un valor de Email");
                txtEmailEmpleado.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtEmailEmpleado, ""); }

            return errorCampos;
        }

        private bool esNumerico(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Guardar()
        {
            string mensaje = "";

            try
            {
                if (validar())
                {
                    empleados.C_IdEmpleado = IdEmpleado;
                    empleados.C_strNombre = txtNombreEmpleado.Text;
                    empleados.C_NumDocumento = double.Parse(txtDocumentoEmpleado.Text);
                    empleados.C_strDireccion = txtDireccionEmpleado.Text;
                    empleados.C_strTelefono = txtTelefonoEmpleado.Text;
                    empleados.C_strEmail = txtEmailEmpleado.Text;
                    empleados.C_IdRolEmpleado = int.Parse(cmbRolEmpleado.SelectedValue.ToString());
                    empleados.C_strDatosAdicionales = rtbDatosAdicionales.Text;
                    empleados.C_DtmIngreso = dtpFechaIngreso.Value;
                    empleados.C_DtmRetiro = dtpFechaRetiro.Value;
                    empleados.C_DtmFechaModifica = dtpFechaModifico.Value;
                    empleados.C_strUsuarioModifico = TxtUsuarioModifico.Text;
                    mensaje = empleados.ActualizarEmpleado();
                    MessageBox.Show(mensaje);
                }
            }
            catch (Exception ex)
            {
                mensaje = "FALLÓ LA ACTUALIZACION EMPLEADO" + ex.Message;
            }
        }                    

        public void Limpiar()
        {
            txtIdEmpleado.Text = string.Empty;
            txtNombreEmpleado.Text = string.Empty;
            txtDocumentoEmpleado.Text = string.Empty;
            txtDireccionEmpleado.Text = string.Empty;
            txtTelefonoEmpleado.Text = string.Empty;
            txtEmailEmpleado.Text = string.Empty;
            cmbRolEmpleado.Text = string.Empty;
            rtbDatosAdicionales.Text = string.Empty;
            dtpFechaIngreso.Text = "";
            dtpFechaRetiro.Text = "";
        }

        private void frmEditarEmpleado_Load(object sender, EventArgs e)
        {
            LLENAR_EMPLEADO();

            if(txtNombreEmpleado.Text != string.Empty)
            {
                Llenar_Combo_IdRolEmpleado_();
            }

            if (txtNombreEmpleado.Text == string.Empty)
            {
                Llenar_Combo_Empleados();
                cmbRolEmpleado.Text = "";
            }
        }


        private void btnEditarRolEmpleado_Click(object sender, EventArgs e)
        {
            Llenar_Combo_Empleados();        
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Rta;

            Rta = MessageBox.Show("¿ Desea salir de la edición ?", "MENSAJE DE ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Rta == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
