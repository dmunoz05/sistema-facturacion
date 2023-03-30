using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin.Controls;
using System.Windows.Forms;
using Capa_LogicaDeNegocios; 

namespace Plantilla_Sistema_facturacion
{
    public partial class FrmEditarFactura : MaterialForm
    {
        public FrmEditarFactura()
        {
            InitializeComponent();
        }

        public int IdFactura { get; set; }

        DataTable dt = new DataTable();
        Cls_Facturacion Facturacion = new Cls_Facturacion();

        private void LLENAR_FACTURA()
        {
            if (IdFactura == 0)
            {
                lblTitulo.Text = "INGRESO NUEVA FACTURA";
            }
            else
            {
                lblTitulo.Text = "MODIFICAR FACTURA";
                txtIdFactura.Text = "";
                Llenar_Campos();
            }
        }

        public void Filtrar_Combo_EstadoFactura()
        {
            cmbEstadoFactura.DataSource = Facturacion.Consultar_Estado_Factura(Convert.ToInt32(cmbEstadoFactura.ValueMember.ToString()));
            cmbEstadoFactura.DisplayMember = "StrDescripcion";
            cmbEstadoFactura.ValueMember = "IdEstadoFactura";
        }

        public void Llenar_Combo_EstadoFactura()
        {
            cmbEstadoFactura.DataSource = Facturacion.ConsultarEstado();
            cmbEstadoFactura.DisplayMember = "StrDescripcion";
            cmbEstadoFactura.ValueMember = "IdEstadoFactura";
        }

        private void Llenar_Campos()
        {
            dt = Facturacion.Filtrar_Factura(IdFactura);

            foreach (DataRow row in dt.Rows)
            {
                txtIdFactura.Text = row[0].ToString();
                dtpFechaCreacion.Value = Convert.ToDateTime(row[1].ToString());
                txtIdCliente.Text = row[2].ToString();
                txtIdEmpleado.Text = row[3].ToString();
                txtDescuento.Text = row[4].ToString();
                txtImpuesto.Text = row[5].ToString();
                txtValorTotal.Text = row[6].ToString();
                cmbEstadoFactura.ValueMember = row[7].ToString();
                dtpFechaModifica.Value = Convert.ToDateTime(row[8].ToString());

                dtpMostrarFechaCreacion.Value = dtpFechaCreacion.Value;
                dtpMostrarFechaModificacion.Value = dtpFechaModifica.Value;
            }
        }

        private Boolean validar()
        {
            Boolean errorCampos = true;

            if (!esNumerico(txtIdEmpleado.Text))
            {
                MensajeError.SetError(txtIdEmpleado, "Debe ingresar el Id del Empleado registrado ");
                txtIdEmpleado.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtIdEmpleado, ""); }

            if (!esNumerico(txtIdCliente.Text))
            {
                MensajeError.SetError(txtIdCliente, "Debe ingresar el Id del Cliente existente");
                txtIdCliente.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtIdCliente, ""); }

            if (!esNumerico(txtDescuento.Text))
            {
                MensajeError.SetError(txtDescuento, "Debe ingresar un valor de descuento");
                txtDescuento.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtDescuento, ""); }

            if (!esNumerico(txtImpuesto.Text))
            {
                MensajeError.SetError(txtImpuesto, "Debe ingresar un valor de impuesto");
                txtImpuesto.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtImpuesto, ""); }

            if (!esNumerico(txtValorTotal.Text))
            {
                MensajeError.SetError(txtValorTotal, "Debe ingresar un valor total");
                txtValorTotal.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtValorTotal, ""); }

            if (cmbEstadoFactura.Text == string.Empty)
            {
                MensajeError.SetError(cmbEstadoFactura, "Debe de seleccionar un Estado");
                cmbEstadoFactura.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(cmbEstadoFactura, ""); }

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

        public void Actualizar()
        {
            string mensaje = "";

            if (validar())
            {
                try
                {
                    Facturacion.IdFactura = IdFactura;
                    Facturacion.IdCliente = int.Parse(txtIdCliente.Text) ;
                    Facturacion.IdEmpleado = int.Parse(txtIdEmpleado.Text);
                    Facturacion.IdEstado = int.Parse(cmbEstadoFactura.SelectedValue.ToString());
                    Facturacion.NumDescuento = int.Parse(txtDescuento.Text);
                    Facturacion.NumImpuesto = int.Parse(txtImpuesto.Text);
                    Facturacion.NumValorTotal = int.Parse(txtValorTotal.Text);
                    Facturacion.DtmFecha = dtpFechaCreacion.Value;
                    Facturacion.DtmFechaModifica = dtpFechaModifica.Value;

                    mensaje = Facturacion.Actualizar_Factura();

                    MessageBox.Show(mensaje);
                }
                catch (Exception ex)
                {
                    mensaje = "FALLÓ LA ACTUALIZACION DE FACTURA" + ex.Message;
                }
            }
        }

        public void Limpiar()
        {
            txtIdFactura.Text = string.Empty;;
            txtIdCliente.Text = string.Empty; ;
            txtIdEmpleado.Text = string.Empty; ;
            cmbEstadoFactura.Text = string.Empty; ;
            txtDescuento.Text = string.Empty; ;
            txtImpuesto.Text = string.Empty; ;
            txtValorTotal.Text = string.Empty; ;
            dtpFechaCreacion.Text = string.Empty; ;
            dtpFechaModifica.Text = string.Empty; ;
        }

        private void FrmEditarFactura_Load(object sender, EventArgs e)
        {
            LLENAR_FACTURA();

            if (txtIdFactura.Text != string.Empty)
            {
                Llenar_Campos();
                Filtrar_Combo_EstadoFactura();
            }

            if (txtIdFactura.Text == string.Empty)
            {
                Limpiar();
                Llenar_Combo_EstadoFactura();
                cmbEstadoFactura.Text = "";
            }
        }

        private void btnEditarEstadoFactura_Click(object sender, EventArgs e)
        {
            Llenar_Combo_EstadoFactura();
            cmbEstadoFactura.Text = "";
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            Actualizar();
            this.Close();            
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
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
