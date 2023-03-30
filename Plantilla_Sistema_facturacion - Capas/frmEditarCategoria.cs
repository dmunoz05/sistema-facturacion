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
    public partial class frmEditarCategoria : MaterialForm
    {
        public frmEditarCategoria()
        {
            InitializeComponent();
        }

        public int IdCategoria { get; set; }

        DataTable dt = new DataTable();
        Cls_Categorias Categorias = new Cls_Categorias();

        private void LLENAR_CATEGORIA()
        {
            if (IdCategoria == 0)
            {
                lblTitulo.Text = "ACTUALIZAR CATEGORIA";
            }
            else
            {
                dt = Categorias.ConsultaCategoria(IdCategoria);

                foreach (DataRow row in dt.Rows)
                {
                    txtIdCategoria.Text = row[0].ToString();
                    txtNombreCategoria.Text = row[1].ToString();
                }
            }
        }

        private Boolean validar()
        {
            Boolean errorCampos = true;

            if (txtNombreCategoria.Text == string.Empty)
            {
                MensajeError.SetError(txtNombreCategoria, "Debe de ingresar una valor en el campo de Nombre Categoria");
                txtNombreCategoria.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtNombreCategoria, ""); }         

            return errorCampos;
        }

        public void Guardar()
        {
            string mensaje = "";

            try
            {
                if (validar())
                {
                    Categorias.C_IdCategoria = IdCategoria;
                    Categorias.C_StrDescripcion = txtNombreCategoria.Text;
                    Categorias.C_DtmFechaModifica = dtpFechaModifica.Value;
                    Categorias.C_StrUsuarioModifico = "Javier";

                    mensaje = Categorias.ActualizarCategoria();
                    MessageBox.Show(mensaje);
                }
            }
            catch (Exception ex)
            {
                mensaje = "Falló en la insercción" + ex.Message;
            }
        }

        public void Limpiar()
        {
            txtIdCategoria.Text = string.Empty;
            txtNombreCategoria.Text = string.Empty;
        }        

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
            Limpiar();
            this.Close();
        }

        private void frmEditarCategoria_Load(object sender, EventArgs e)
        {
            LLENAR_CATEGORIA();
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
