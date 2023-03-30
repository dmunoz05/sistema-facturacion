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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        public int IdProducto { get; set; }

        DataTable dt = new DataTable();
        Cls_Productos Productos = new Cls_Productos();

        public void Llenar_grid()
        {
            dgProductos.Rows.Clear();

            dt = Productos.ConsultaProducto();

            foreach (DataRow row in dt.Rows)
            {
                dgProductos.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.Text != "")
                {
                    dgProductos.Rows.Clear();

                    dt = Productos.FiltrarProducto(txtBuscar.Text);

                    foreach (DataRow row in dt.Rows)
                    {
                        dgProductos.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
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
                txtBuscar.Text = string.Empty;
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            FrmEditarProducto Producto = new FrmEditarProducto();            
            Producto.IdProducto = 0;
            Producto.ShowDialog();
            Llenar_grid();
        }

        private void dgClientes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgProductos.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgProductos.CurrentRow.Index;

                if (MessageBox.Show("Seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int Id_Producto = Convert.ToInt32(dgProductos[0, posActual].Value.ToString());
                    Productos.C_IdProducto = Id_Producto;
                    string Mensaje = Productos.EliminarProducto();
                    MessageBox.Show(Mensaje);
                }
            }

            if (dgProductos.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgProductos.CurrentRow.Index;
                FrmEditarProducto Producto = new FrmEditarProducto();

                Producto.IdProducto = int.Parse(dgProductos[0, posActual].Value.ToString());
                Producto.ShowDialog();

            }
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            Llenar_grid();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            dgProductos.Rows.Clear();
        }

        private void BtnRegistros_Click(object sender, EventArgs e)
        {
            Llenar_grid();
        }

        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
