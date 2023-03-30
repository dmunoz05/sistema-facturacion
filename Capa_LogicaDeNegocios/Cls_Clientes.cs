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
    public class Cls_Clientes
    {
        public int C_IdCliente { get; set; }
        public string C_StrNombre { get; set; }
        public int C_NumDocumento { get; set; }
        public string C_StrDireccion { get; set; }
        public int C_StrTelefono { get; set; }
        public string C_StrEmail { get; set; }
        public DateTime C_DtmFechaModifica { get; set; }
        public string C_StrUsuarioModifico = "javier";

        Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();
        DataTable dt = new DataTable();


        public DataTable Consulta_Clientes()
        {
            string sentencia;
            try
            {
                sentencia = "SELECT * FROM TBLCLIENTES";
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable ConsultaCliente(int IdCliente)
        {
            string sentencia;
            try
            {
                sentencia = $"SELECT * FROM TBLCLIENTES WHERE IdCliente = {IdCliente}";
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable FiltrarCliente(string filtro)
        {
            string sentencia = "";
            try
            {
                sentencia = $"SELECT * FROM TBLCLIENTES WHERE StrNombre LIKE '%{filtro}%'";
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string Elimina_Cliente()
        {
            string mensaje = "";

            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();

                lst.Add(new Cls_parametros("@IdCliente", C_IdCliente));

                mensaje = AccesoDatos.Ejecutar_Procedimiento("Eliminar_Cliente", lst);  
            }
            catch (Exception ex)
            {
                mensaje = "FALLÓ BORRADO EN CLIENTE" + ex.Message;
            }
            return mensaje;
        }


        public string ActualizarCliente()
        {
            string mensaje = "";

            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();

                lst.Add(new Cls_parametros("@IdCliente", C_IdCliente));
                lst.Add(new Cls_parametros("@StrNombre", C_StrNombre));
                lst.Add(new Cls_parametros("@NumDocumento", C_NumDocumento));
                lst.Add(new Cls_parametros("@StrDireccion", C_StrDireccion));
                lst.Add(new Cls_parametros("@StrTelefono", C_StrTelefono));
                lst.Add(new Cls_parametros("@StrEmail", C_StrEmail));
                lst.Add(new Cls_parametros("@DtmFechaModifica", C_DtmFechaModifica));
                lst.Add(new Cls_parametros("@StrUsuarioModifica", C_StrUsuarioModifico));

                mensaje = AccesoDatos.Ejecutar_Procedimiento("actualizar_Cliente", lst);
            }
            catch (Exception ex)
            {
                mensaje = "FALLÓ LA ACTUALIZACION EMPLEADO" + ex.Message;
            }
            return mensaje;
        }
    }
}
