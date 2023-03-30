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
    public partial class frmListaClientes : Form
    {
        public frmListaClientes()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        Cls_Clientes Clientes = new Cls_Clientes();

        public void Llenar_grid()
        {
            dgClientes.Rows.Clear();

            dt = Clientes.Consulta_Clientes();

            foreach (DataRow row in dt.Rows)
            {
                dgClientes.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6]);
            }
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            Llenar_grid();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditarCliente Cliente = new FrmEditarCliente();
            Cliente.IdCliente = 0;
            Cliente.ShowDialog();
            Llenar_grid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.Text != string.Empty)
                {
                    DataTable dt = new DataTable();

                    dgClientes.Rows.Clear();

                    dt = Clientes.FiltrarCliente(txtBuscar.Text);

                    foreach (DataRow row in dt.Rows)
                    {
                        dgClientes.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6]);
                        txtBuscar.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros con tal nombre");
                    Llenar_grid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar" + ex);
            }           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgClientes.Rows.Clear();
        }

        private void BtnRegistros_Click(object sender, EventArgs e)
        {
            Llenar_grid();
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgClientes.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgClientes.CurrentRow.Index;

                if (MessageBox.Show("Seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int IdCliente = Convert.ToInt32(dgClientes[0, posActual].Value.ToString());
                    Clientes.C_IdCliente = IdCliente;
                    string Mensaje = Clientes.Elimina_Cliente();

                    MessageBox.Show(Mensaje);
                }
            }

            if (dgClientes.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgClientes.CurrentRow.Index;
                FrmEditarCliente Cliente = new FrmEditarCliente();

                Cliente.IdCliente = int.Parse(dgClientes[0, posActual].Value.ToString());
                Cliente.ShowDialog();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
