using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace Plantilla_Sistema_facturacion
{
    public partial class frmRolEmpleados : Form
    {
        public frmRolEmpleados()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        DataTable dt = new DataTable();
        Cls_Roles Roles = new Cls_Roles();


        public void Llenar_grid()
        {
            dgRoles.Rows.Clear();

            dt = Roles.Consultar_RolEmpleado();

            foreach (DataRow row in dt.Rows)
            {
                dgRoles.Rows.Add(row[0], row[1]);
            }
        }

        public void Consultar()
        {
            try
            {
                if (txtBuscarNombre.Text != string.Empty)
                {
                    DataTable dt = new DataTable();

                    dgRoles.Rows.Clear();

                    dt = Roles.FiltrarRolEmpleado(txtBuscarNombre.Text);

                    foreach (DataRow row in dt.Rows)
                    {
                        dgRoles.Rows.Add(row[0], row[1]);
                    }
                }
                else
                {
                    Llenar_grid();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontraron datos similares");
                txtBuscarNombre.Text = string.Empty;
            }
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgRoles.Rows.Clear();
            Consultar();
        }

        private void BtnRegistros_Click(object sender, EventArgs e)
        {
            Llenar_grid();
        }

        private void frmRolEmpleados_Load(object sender, EventArgs e)
        {
            Llenar_grid();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgRoles.Rows.Clear();
            txtBuscarNombre.Text = string.Empty;
        }

        private void dgRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Llenar_grid();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
