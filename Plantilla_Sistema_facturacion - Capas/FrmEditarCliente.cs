using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;
using Capa_LogicaDeNegocios;

namespace Plantilla_Sistema_facturacion
{
    public partial class FrmEditarCliente : MaterialForm
    {
        public FrmEditarCliente()
        {
            InitializeComponent();
        }

        public int IdCliente { get; set; }

        DataTable dt = new DataTable();
        Cls_Clientes Clientes = new Cls_Clientes();

        private void LLENAR_CLIENTE()
        {
            if (IdCliente == 0)
            {
                lblTitulo.Text = "INGRESO NUEVO CLIENTE";
            }
            else
            {
                dt = Clientes.ConsultaCliente(IdCliente);

                foreach (DataRow row in dt.Rows)
                {
                    txtIdCliente.Text = row[0].ToString();
                    txtNombre.Text = row[1].ToString();
                    txtDocumento.Text = row[2].ToString();
                    txtDireccion.Text = row[3].ToString();
                    txtTelefono.Text = row[4].ToString();
                    txtEmail.Text = row[5].ToString();
                    dtpFechaModificacion.Value = Convert.ToDateTime(row[6].ToString());
                }
            }
        }

        private void FrmEditarCliente_Load(object sender, EventArgs e)
        {
            LLENAR_CLIENTE();
        }

        public void Guardar()
        {
            string mensaje = "";
           
            if (validar())
            {
                try
                {
                    Clientes.C_IdCliente = IdCliente;
                    Clientes.C_StrNombre = txtNombre.Text;
                    Clientes.C_NumDocumento = int.Parse(txtDocumento.Text);
                    Clientes.C_StrDireccion = txtDireccion.Text;
                    Clientes.C_StrTelefono = int.Parse(txtTelefono.Text);
                    Clientes.C_StrEmail = txtEmail.Text;
                    Clientes.C_DtmFechaModifica = dtpFechaModificacion.Value;

                    mensaje = Clientes.ActualizarCliente();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falló insercción" + ex);
                }
            }
        }

        private Boolean validar()
        {
            Boolean errorCampos = true;

            if (txtNombre.Text == string.Empty)
            {
                MensajeError.SetError(txtNombre, "Debe de ingresar el nombre del cliente");
                txtNombre.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtNombre, ""); }

            if (!esNumerico(txtDocumento.Text))
            {
                MensajeError.SetError(txtTelefono, "El documento debe ser númerico");
                txtDocumento.Focus();
                return false;
            }
            MensajeError.SetError(txtDocumento, "");

            if (txtDireccion.Text == string.Empty)
            {
                MensajeError.SetError(txtDireccion, "Debe de ingresar un valor de Dirección");
                txtDireccion.Focus();
                return false;
            }
            MensajeError.SetError(txtDireccion, "");

            if (txtEmail.Text == string.Empty)
            {
                MensajeError.SetError(txtDireccion, "Debe de ingresar un valor de Email");
                txtEmail.Focus();
                return false;
            }
            MensajeError.SetError(txtEmail, "");

            return errorCampos;
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
            this.Close();
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
