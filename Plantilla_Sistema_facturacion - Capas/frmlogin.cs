using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Capa_LogicaDeNegocios;


namespace Plantilla_Sistema_facturacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text != "" && TxtContraseña.Text != string.Empty)
            {
                Validar_usuario Obj_Validar = new Validar_usuario();

                Obj_Validar.C_StrUsuario = TxtUsuario.Text;
                Obj_Validar.C_StrClave = TxtContraseña.Text;

                Obj_Validar.ValidarUsuario();

                if (Obj_Validar.C_IdEmpleado != 0)
                {
                    MessageBox.Show("Datos de verificacion Validos");
                    frmPrincipal principal = new frmPrincipal();
                    this.Hide();
                    principal.Show();
                }
                else
                {
                    MessageBox.Show("USUARIOS Y CLAVES NO ENCONTRADOS");
                    TxtUsuario.Text = "";
                    TxtUsuario.Focus();
                    TxtContraseña.Text = "";
                }
            }
            else
            {
                MessageBox.Show("DEBE INGRESAR UN USUARIO Y UNA CONTRASEÑA");
            }
        }                  

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
