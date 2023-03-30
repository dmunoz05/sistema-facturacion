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
    public partial class frmFacturas : Form
    {
        public frmFacturas()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        Cls_Facturacion facturacion = new Cls_Facturacion();

        public void Llenar_grid()
        {
            dgFacturas.Rows.Clear();

            dt = facturacion.Consultar_Facturas();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                    dgFacturas.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
            }
            else
            {
                MessageBox.Show("No se encontraron registros");
            }

        }

        public void Consultar()
        {
            try
            {
                if (txtBuscarIdFactura.Text != string.Empty)
                {
                    dt = facturacion.Filtrar_Factura(int.Parse(txtBuscarIdFactura.Text));

                    foreach (DataRow row in dt.Rows)
                    {
                        dgFacturas.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
                        txtBuscarIdFactura.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron facturas con tal número");
                    Llenar_grid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar" + ex);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditarFactura Factura = new FrmEditarFactura();
            Factura.IdFactura = 0;
            Factura.ShowDialog();
            Llenar_grid();
        }


        private void dgFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgFacturas.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgFacturas.CurrentRow.Index;
                FrmEditarFactura Factura = new FrmEditarFactura();

                Factura.IdFactura = int.Parse(dgFacturas[0, posActual].Value.ToString());
                Factura.ShowDialog();
            }
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            Llenar_grid();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            FrmEditarFactura Factura = new FrmEditarFactura();
            Factura.IdFactura = 0;
            Factura.ShowDialog();
        }

        private void BtnRegistros_Click(object sender, EventArgs e)
        {
            Llenar_grid();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgFacturas.Rows.Clear();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgFacturas.Rows.Clear();
            Consultar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
