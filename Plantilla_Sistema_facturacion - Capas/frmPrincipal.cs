using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data;
using System.Data.SqlClient;

namespace Plantilla_Sistema_facturacion
{
    public partial class frmPrincipal : MaterialForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void AbrirForm(Form formHijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmListaClientes ListaCliente = new frmListaClientes();
            AbrirForm(ListaCliente);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos ProductosCliente = new frmProductos();
            AbrirForm(ProductosCliente);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategoriaProductos Categoria = new frmCategoriaProductos();
            AbrirForm(Categoria);
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            frmFacturas Facturas = new frmFacturas();
            AbrirForm(Facturas);
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            frmInformes Informe = new frmInformes();
            AbrirForm(Informe);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleados Empleado = new frmEmpleados();
            AbrirForm(Empleado);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            frmRolEmpleados Roles = new frmRolEmpleados();
            AbrirForm(Roles);
        }

        private void btnSegurida_Click(object sender, EventArgs e)
        {
            frmAdminSeguridad Seguridad = new frmAdminSeguridad();
            AbrirForm(Seguridad);
        }

        private void btnAcercade_Click(object sender, EventArgs e)
        {
            frmImagen Imagen = new frmImagen();
            AbrirForm(Imagen);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {            
            frmPaginaWeb Pagina = new frmPaginaWeb();
            AbrirForm(Pagina);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ImagenPrincipal Imagen = new ImagenPrincipal();
            AbrirForm(Imagen);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ImagenPrincipal Imagen = new ImagenPrincipal();
            AbrirForm(Imagen);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ImagenPrincipal Imagen = new ImagenPrincipal();
            AbrirForm(Imagen);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            ImagenPrincipal Imagen = new ImagenPrincipal();
            AbrirForm(Imagen);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            ImagenPrincipal Imagen = new ImagenPrincipal();
            AbrirForm(Imagen);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            ImagenPrincipal Imagen = new ImagenPrincipal();
            AbrirForm(Imagen);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }

    class Acceso_datos
    {
        SqlConnection conexion; // se define la variable para la conexión de tipo SqlConnection
        SqlCommand cmd; // se defie la variable para realizar comandos en la BD
        SqlDataReader LectorDatos = null;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        public void AbrirBd() // método para abrir la base de datos
        {
            try // permite captura de un error en caso que se presente
            {
                // creamos un objeto de tipo conexión a la base de datos y se pasa como parámetro la cadena de conexión
                conexion = new SqlConnection("Data Source=LAPTOP-RLT0746T;Initial Catalog= [DBFACTURAS];Integrated Security=True");

                conexion.Open(); // invocamos método para abrir la base de datos
            }
            catch (Exception ex)// si hay error presenta el siguiente mensaje
            {
                MessageBox.Show("falló conexión " + ex);
            }
        }

        public void CerrarrBd() // método para cerrar la base de datos
        {
            try // permite captura de un error en caso que se presente
            {
                conexion.Close(); // invocamos método para cerrar la base de datos
            }
            catch (Exception ex)// si hay error presenta el siguiente mensaje
            {
                MessageBox.Show("falló cerrar conexión " + ex);

            }

        }

        public string ValidarUsuario(string StrUsuario, string StrClave)
        {
            try
            {
                string strEmpleado = "";
                string sentencia = ($"select e.strNombre, e.IdRolEmpleado from TBLSEGURIDAD s JOIN TBLEMPLEADO e ON s.IdEmpleado = e.IdEmpleado where StrUsuario = '{StrUsuario}' and StrClave = '{StrClave}'");

                AbrirBd();

                cmd = new SqlCommand();

                cmd.Connection = conexion;
                cmd.CommandText = sentencia;
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 10;
                LectorDatos = cmd.ExecuteReader();

                while (LectorDatos.Read())
                {
                    strEmpleado = Convert.ToString(LectorDatos.GetValue(0));
                }

                if (LectorDatos != null)
                {
                    LectorDatos.Close();
                }
                return strEmpleado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("FALLA LECTURA: " + ex.Message);
                return "";
            }
        }

        public string EjecutarComando(string sentencia)
        {
            string salida = "LOS DATOS SE ACTUALIZARON SATISFACTORIAMENTE";

            try
            {
                int retornado;
                AbrirBd();
                cmd = new SqlCommand(sentencia, conexion);
                retornado = cmd.ExecuteNonQuery();

                CerrarrBd();
                if (retornado > 0)
                {
                    salida = "LOS DATOS FUERON ACTUALIZADOS";
                }
                else
                {
                    salida = "LOS DATOS NO FUERON ACTUALIZADOS";
                }
            }
            catch (Exception ex)
            {
                salida = "FALLO INSERCCION: " + ex;
            }
            return salida;
        }

        public DataTable CargarTabla(string tabla, string strCondicion)
        {
            try
            {
                AbrirBd();
                string Sql = "SELECT * FROM " + tabla + " " + strCondicion;
                da = new SqlDataAdapter(Sql,conexion);
                ds = new DataSet();
                da.Fill(ds, tabla);
                DataTable dt = new DataTable();
                dt = ds.Tables[tabla];
                CerrarrBd();
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR EN LA CONSULTA" + ex.ToString());
                return null;
            }
        }

        public DataTable EjecutarComandoDatos(string cmd)
        {
            try
            {
                AbrirBd();
                da = new SqlDataAdapter(cmd, conexion);
                dt = new DataTable();
                da.Fill(dt);
                CerrarrBd();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("FALLÓ OPERACIÓN: " + ex);
                return null;
            }
        }
    }    
}
