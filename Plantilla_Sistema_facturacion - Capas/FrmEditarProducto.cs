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
    public partial class FrmEditarProducto : MaterialForm
    {
        public FrmEditarProducto()
        {
            InitializeComponent();
        } 

        public int IdProducto { get; set; }

        DataTable dt = new DataTable();
        Cls_Productos Producto = new Cls_Productos();

        private void LLENAR_PRODUCTO()
        {
            if (IdProducto == 0)
            {
                lblTitulo.Text = "ACTUALIZAR PRODUCTO";
            }
            else
            {
                dt = Producto.Filtrar_Producto(IdProducto);
                foreach (DataRow row in dt.Rows)
                {
                    txtIdProducto.Text = row[0].ToString();
                    txtNombreProducto.Text = row[1].ToString();
                    txtCodigoReferencia.Text = row[2].ToString();
                    txtPrecioCompra.Text = row[3].ToString();
                    txtPrecioVenta.Text = row[4].ToString();
                    txtIdCategoria.Text = row[5].ToString();
                    rtbDescripcionProducto.Text = row[6].ToString();
                    txtNumStock.Text = row[8].ToString();
                    dtpFechaModifica.Value = Convert.ToDateTime(row[9].ToString());
                }
            }
        }


        private Boolean validar()
        {
            Boolean errorCampos = true;

            if (txtNombreProducto.Text == string.Empty)
            {
                MensajeError.SetError(txtNombreProducto, "Debe de ingresar el nombre del producto");
                txtNombreProducto.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtNombreProducto, ""); }

            if (!esNumerico(txtCodigoReferencia.Text))
            {
                MensajeError.SetError(txtCodigoReferencia, "El código de referencia debe ser númerico");
                txtCodigoReferencia.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtCodigoReferencia, ""); }

            if (!esNumerico(txtPrecioCompra.Text))
            {
                MensajeError.SetError(txtPrecioCompra, "El precio de compra debe ser númerico");
                txtPrecioCompra.Focus();
                return false;
            }
            MensajeError.SetError(txtPrecioCompra, "");

            if (!esNumerico(txtPrecioVenta.Text))
            {
                MensajeError.SetError(txtPrecioVenta, "El precio de venta debe ser númerico");
                txtPrecioVenta.Focus();
                return false;
            }
            MensajeError.SetError(txtPrecioCompra, "");

            if (!esNumerico(txtIdCategoria.Text))
            {
                MensajeError.SetError(txtIdCategoria, "El Id Categoria debe ser númerico");
                txtIdCategoria.Focus();
                return false;
            }
            MensajeError.SetError(txtIdCategoria, "");

            if (!esNumerico(txtNumStock.Text))
            {
                MensajeError.SetError(txtNumStock, "El Stock debe ser númerico");
                txtNumStock.Focus();
                return false;
            }
            MensajeError.SetError(txtNumStock, "");

            if (rtbDescripcionProducto.Text == string.Empty)
            {
                MensajeError.SetError(rtbDescripcionProducto, "Debe de ingresar una descripción del producto en este campo");
                rtbDescripcionProducto.Focus();
                return false;
            }
            MensajeError.SetError(rtbDescripcionProducto, "");

            return errorCampos;
        }

        public void Guardar()
        {
            string mensaje = "";

            try
            {
                if (validar())
                {
                    Producto.C_IdProducto = IdProducto;
                    Producto.C_strNombre = txtNombreProducto.Text;
                    Producto.C_StrCodigo = int.Parse(txtCodigoReferencia.Text);
                    Producto.C_NumPrecioCompra = int.Parse(txtPrecioCompra.Text);
                    Producto.C_NumPrecioVenta = int.Parse(txtPrecioVenta.Text);
                    Producto.C_IdCategoria = int.Parse(txtIdCategoria.Text);
                    Producto.C_StrDetalle = rtbDescripcionProducto.Text;
                    Producto.C_NumStock = int.Parse(txtNumStock.Text);
                    Producto.C_DtmFechaModifica = dtpFechaModifica.Value;

                    mensaje = Producto.ActualizarProducto();
                    MessageBox.Show(mensaje);
                }                
            }
            catch (Exception ex)
            {
                mensaje = "Falló insercción" + ex.Message;
            }
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            Guardar();
            Limpiar();
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

        public void Limpiar()
        {
            txtIdProducto.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            txtCodigoReferencia.Text = string.Empty;
            txtPrecioCompra.Text = string.Empty;
            txtPrecioVenta.Text = string.Empty;
            txtIdCategoria.Text = string.Empty;
            txtNumStock.Text = string.Empty;
            rtbDescripcionProducto.Text = string.Empty;
        }

        private void FrmEditarProducto_Load(object sender, EventArgs e)
        {
            LLENAR_PRODUCTO();
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
