using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Capa_LogicaDeNegocios;


namespace Plantilla_Sistema_facturacion
{
    public partial class frmAdminSeguridad : Form
    {
        public frmAdminSeguridad()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        Cls_AdminSeguridad seguridadEmpleado = new Cls_AdminSeguridad();

        private void llenar_CboEmpleado()
        {
            cmbEmpleado.DataSource = seguridadEmpleado.ConsultarEmpleados();
            cmbEmpleado.DisplayMember = "strNombre";
            cmbEmpleado.ValueMember = "IdEmpleado";
        }

        public void Consultar()
        {
            int IdEmpleado = int.Parse(cmbEmpleado.SelectedValue.ToString());
            dt = seguridadEmpleado.Consulta_SeguridadEmpleado(IdEmpleado);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    txtUsuario.Text = row[0].ToString();
                    txtClave.Text = row[1].ToString();
                }
            }                
            else
            {
                txtClave.Text = "";
                txtUsuario.Text = "";
                MessageBox.Show("No se le ha asignado Usuario y Contraseña");
            }
        }

        private Boolean validar()
        {
            Boolean errorCampos = true;

            if (txtUsuario.Text == string.Empty)
            {
                MensajeError.SetError(txtUsuario, "Debe ingresar un valor de Usuario");
                txtUsuario.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtUsuario, ""); }

            if (txtClave.Text == "")
            {
                MensajeError.SetError(txtClave, "Debe ingresar un valor de clave");
                txtClave.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtClave, ""); }
            return errorCampos;
        }

        private bool IsNumeric(string num)
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
            if (validar())
            {
                seguridadEmpleado.C_IdEmpleado = int.Parse(cmbEmpleado.SelectedValue.ToString());
                seguridadEmpleado.C_StrUsuario = txtUsuario.Text;
                seguridadEmpleado.C_StrClave = int.Parse(txtClave.Text);
                seguridadEmpleado.C_StrUsuarioModifico = "javier";
                mensaje = seguridadEmpleado.ActualizarSeguridadEmpleado();
                MessageBox.Show(mensaje);
            }
            txtClave.Text = "";
            txtUsuario.Text = "";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        public void Eliminar()
        {
            if (MessageBox.Show($"ESTA SEGURO DE BORRAR EL REGISTRO DE:\n {cmbEmpleado.Text}", "CONFIRMACION",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                seguridadEmpleado.C_IdEmpleado = int.Parse(cmbEmpleado.SelectedValue.ToString());
                string mensaje = seguridadEmpleado.EliminarSeguridad();

                if (mensaje != "")

                {
                    MessageBox.Show(mensaje);
                }
                else
                {
                    MessageBox.Show($"BORRADO EL REGISTRO");
                }
                txtClave.Text = "";
                txtUsuario.Text = "";
            }
        }

        private void frmAdminSeguridad_Load(object sender, EventArgs e)
        {
            llenar_CboEmpleado();
            cmbEmpleado.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbEmpleado.Text = "";
            txtClave.Text = "";
            txtUsuario.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Rta;

            Rta = MessageBox.Show("¿ Desea salir del programa ?", "MENSAJE DE ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Rta == DialogResult.OK)
            {
                this.Close();
                Application.Exit();
            }
        }
    }
}