using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_AccesoDatos;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Productos
    {
        public int C_IdProducto { get; set; }
        public string C_strNombre { get; set; }
        public int C_StrCodigo { get; set; }
        public int C_NumPrecioCompra { get; set; }
        public int C_NumPrecioVenta { get; set; }
        public int C_IdCategoria { get; set; }
        public string C_StrDetalle { get; set; }
        public string C_StrFoto = "ninguna";
        public int C_NumStock { get; set; }
        public DateTime C_DtmFechaModifica { get; set; }
        public string C_strUsuarioModifica = "Javier";

        DataTable dt = new DataTable();
        Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();


        public DataTable ConsultaProducto()
        {
            string sentencia;
            try
            {
                sentencia = $"SELECT IdProducto, StrNombre, StrCodigo, NumPrecioCompra, NumPrecioVenta, IdCategoria, StrDetalle, NumStock, DtmFechaModifica FROM TBLPRODUCTO";
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable Filtrar_Producto(int filtro)
        {
            string sentencia = "";
            try
            {
                sentencia = $"SELECT IdProducto, StrNombre, StrCodigo, NumPrecioCompra, NumPrecioVenta, IdCategoria, StrDetalle, StrDetalle, NumStock, DtmFechaModifica FROM TBLPRODUCTO WHERE IdProducto = {filtro}";
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public DataTable FiltrarProducto(string filtro)
        {
            string sentencia;

            try
            {
                sentencia = $"SELECT  IdProducto, StrNombre, StrCodigo, NumPrecioCompra, NumPrecioVenta, IdCategoria, StrDetalle, NumStock, DtmFechaModifica FROM TBLPRODUCTO WHERE StrNombre LIKE '%{filtro}%'";
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string EliminarProducto()
        {
            string mensaje = "";

            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();

                lst.Add(new Cls_parametros("@IdProducto", C_IdProducto));

                mensaje = AccesoDatos.Ejecutar_Procedimiento("Eliminar_Producto", lst);
            }
            catch (Exception ex)
            {
                mensaje = "FALLÓ BORRADO DE PRODUCTO" + ex.Message;
            }
            return mensaje;
        }


        public string ActualizarProducto()
        {
            string mensaje = "";

            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();

                lst.Add(new Cls_parametros("@IdProducto", C_IdProducto));
                lst.Add(new Cls_parametros("@StrNombre", C_strNombre));
                lst.Add(new Cls_parametros("@StrCodigo", C_StrCodigo));
                lst.Add(new Cls_parametros("@NumPrecioCompra", C_NumPrecioCompra));
                lst.Add(new Cls_parametros("@NumPrecioVenta", C_NumPrecioVenta));
                lst.Add(new Cls_parametros("@IdCategoria", C_IdCategoria));
                lst.Add(new Cls_parametros("@StrDetalle", C_StrDetalle));
                lst.Add(new Cls_parametros("@StrFoto", C_StrFoto));
                lst.Add(new Cls_parametros("@NumStock", C_NumStock));
                lst.Add(new Cls_parametros("@DtmFechaModifica", C_DtmFechaModifica));
                lst.Add(new Cls_parametros("@StrUsuarioModifica", C_strUsuarioModifica));

                mensaje = AccesoDatos.Ejecutar_Procedimiento("actualizar_Producto", lst);
            }
            catch (Exception ex)
            {
                mensaje = "FALLÓ LA ACTUALIZACION DE PRODUCTO" + ex.Message;
            }
            return mensaje;
        }
    }
}
