using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Capa_LogicaDeNegocios;

namespace Plantilla_Sistema_facturacion
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        Cls_Empleados empleado = new Cls_Empleados();

        public void Llenar_grid()
        {

            dgEmpleados.Rows.Clear();

            dt = empleado.ConsultaEmpleado();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)               
                    dgEmpleados.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9]);
            }
            else
            {
                MessageBox.Show("No se encontraron registros");
            }
        }

        public void Consultar()
        {
            if (txtBuscarNombre.Text != string.Empty)
            {
                dgEmpleados.Rows.Clear();

                dt = empleado.FiltrarEmpleado(txtBuscarNombre.Text);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                        dgEmpleados.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(), row[9].ToString());
                    txtBuscarNombre.Text = "";
                }
                else
                {
                    MessageBox.Show("No se encontraron registrar por la busqueda solicitada"); Llenar_grid();
                }
            }
            else
            {
                Llenar_grid();
            }
            txtBuscarNombre.Text = "";
        }

        private void dgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgEmpleados.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgEmpleados.CurrentRow.Index;

                if (MessageBox.Show("Seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int IdEmpleado = Convert.ToInt32(dgEmpleados[0, posActual].Value.ToString());
                    empleado.C_IdEmpleado = IdEmpleado;
                    string Mensaje = empleado.EliminaEmpleado();

                    MessageBox.Show(Mensaje);

                    Llenar_grid();
                }
            }

            if (dgEmpleados.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgEmpleados.CurrentRow.Index;
                frmEditarEmpleado Empleado = new frmEditarEmpleado();

                Empleado.IdEmpleado = int.Parse(dgEmpleados[0, posActual].Value.ToString());
                Empleado.ShowDialog();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarEmpleado Empleado = new frmEditarEmpleado();
            Empleado.IdEmpleado = 0;
            Empleado.ShowDialog();
            Llenar_grid();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            Llenar_grid();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void BtnRegistros_Click(object sender, EventArgs e)
        {
            Llenar_grid();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgEmpleados.Rows.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}