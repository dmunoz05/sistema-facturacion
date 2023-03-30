using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_AccesoDatos;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Categorias
    {
        public int C_IdCategoria { get; set; }
        public string C_StrDescripcion { get; set; }
        public DateTime C_DtmFechaModifica { get; set; }
        public string C_StrUsuarioModifico = "Javier";

        Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();
        DataTable dt = new DataTable();


        public DataTable Consulta_Categorias()
        {
            string sentencia;
            try
            {
                sentencia = $"SELECT IdCategoria, StrDescripcion FROM TBLCATEGORIA_PROD";
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable ConsultaCategoria(int IdCliente)
        {
            string sentencia;
            try
            {
                sentencia = $"SELECT * FROM TBLCATEGORIA_PROD WHERE IdCategoria = {IdCliente}";
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable FiltrarCategoria(string filtro)
        {
            string sentencia = "";
            try
            {
                sentencia = $"SELECT * FROM TBLCATEGORIA_PROD WHERE StrDescripcion LIKE '%{filtro}%'";
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string Elimina_Categoria()
        {
            string mensaje = "";

            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();

                lst.Add(new Cls_parametros("@IdCategoria", C_IdCategoria));

                mensaje = AccesoDatos.Ejecutar_Procedimiento("Eliminar_CategoriaProducto", lst);
            }
            catch (Exception ex)
            {
                mensaje = "FALLÓ BORRADO EN CATEGORIA" + ex.Message;
            }
            return mensaje;
        }


        public string ActualizarCategoria()
        {
            string mensaje = "";

            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();

                lst.Add(new Cls_parametros("@IdCategoria", C_IdCategoria));
                lst.Add(new Cls_parametros("@StrDescripcion", C_StrDescripcion));
                lst.Add(new Cls_parametros("@DtmFechaModifica", C_DtmFechaModifica));
                lst.Add(new Cls_parametros("@StrUsuarioModifico", C_StrUsuarioModifico));

                mensaje = AccesoDatos.Ejecutar_Procedimiento("actualizar_CategoriaProducto", lst);
            }
            catch (Exception ex)
            {
                mensaje = "FALLÓ LA ACTUALIZACION DE CATEGORIA" + ex.Message;
            }
            return mensaje;
        }
    }
}