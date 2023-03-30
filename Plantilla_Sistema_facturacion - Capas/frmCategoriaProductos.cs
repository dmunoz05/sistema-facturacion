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
    public partial class frmCategoriaProductos : Form
    {
        public frmCategoriaProductos()
        {
            InitializeComponent();
        }

        public int IdCategoria { get; set; }

        DataTable dt = new DataTable();
        Cls_Categorias Categorias = new Cls_Categorias();

        public void Llenar_grid()
        {
            dgCategoria.Rows.Clear();

            dt = Categorias.Consulta_Categorias();

            foreach (DataRow row in dt.Rows)
            {
                dgCategoria.Rows.Add(row[0], row[1]);
            }
        }


        public void Consultar()
        {
            try
            {
                if (txtBuscarNombre.Text != string.Empty)
                {
                    dt = Categorias.FiltrarCategoria(txtBuscarNombre.Text);

                    foreach (DataRow row in dt.Rows)
                    {
                        dgCategoria.Rows.Add(row[0], row[1]);
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

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            frmEditarCategoria Categoria = new frmEditarCategoria();
            Categoria.IdCategoria = 0;
            Categoria.ShowDialog();
            Llenar_grid();
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCategoria.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgCategoria.CurrentRow.Index;

                if (MessageBox.Show("Seguro de borrar", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int IdCategoria = Convert.ToInt32(dgCategoria[0, posActual].Value.ToString());
                    Categorias.C_IdCategoria = IdCategoria;
                    string Mensaje = Categorias.Elimina_Categoria();

                    MessageBox.Show(Mensaje);
                }
            }

            if (dgCategoria.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgCategoria.CurrentRow.Index;
                frmEditarCategoria Categoria = new frmEditarCategoria();

                Categoria.IdCategoria = int.Parse(dgCategoria[0, posActual].Value.ToString());
                Categoria.ShowDialog();

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarCategoria Categoria = new frmEditarCategoria();
            Categoria.IdCategoria = 0;
            Categoria.ShowDialog();
            Llenar_grid();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgCategoria.Rows.Clear();
            txtBuscarNombre.Text = string.Empty;
        }

        private void frmCategoriaProductos_Load(object sender, EventArgs e)
        {
            Llenar_grid();
        }

        private void BtnRegistros_Click(object sender, EventArgs e)
        {
            Llenar_grid();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
