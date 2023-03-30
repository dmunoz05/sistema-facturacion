using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Capa_AccesoDatos;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Empleados
    {
        public int C_IdEmpleado { get; set; }
        public string C_strNombre { get; set; }
        public double C_NumDocumento { get; set; }
        public string C_strDireccion { get; set; }
        public string C_strTelefono { get; set; }
        public string C_strEmail { get; set; }
        public int C_IdRolEmpleado { get; set; }
        public DateTime C_DtmIngreso { get; set; }
        public DateTime C_DtmRetiro { get; set; }
        public string C_strDatosAdicionales { get; set; }
        public DateTime C_DtmFechaModifica { get; set; }
        public string C_strUsuarioModifico = "javier";

        Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();
        DataTable dt = new DataTable();

        public DataTable ConsultaEmpleado()
        {
            string sentencia;
            try
            {
                sentencia = "SELECT * FROM TBLEMPLEADO";
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable Consulta_Empleado(int IdEmpleado)
        {
            string sentencia = "";
            try
            {
                sentencia = $"SELECT * FROM TBLEMPLEADO WHERE IdEmpleado = {IdEmpleado}"; 
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable ConsultarRol()
        {
            string sentencia;
            try
            {
                sentencia = $"SELECT * FROM TBLROLES";
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public DataTable ConsultarRolEmpleado(int IdRolEmpleado)
        {
            string sentencia;
            try
            {
                sentencia = $"SELECT * FROM TBLROLES WHERE IdRolEmpleado = {IdRolEmpleado}";
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public DataTable FiltrarEmpleado(string filtro)
        {
            string sentencia;

            try
            {
                sentencia = $"SELECT * FROM TBLEMPLEADO WHERE strNombre LIKE '%{filtro}%'";
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }        

        public string EliminaEmpleado()
        {
            string mensaje = "";

            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();

                lst.Add(new Cls_parametros("@IdEmpleado", C_IdEmpleado));

                mensaje = AccesoDatos.Ejecutar_Procedimiento("Eliminar_Empleado", lst);
            }
            catch (Exception ex)
            {
                mensaje = "FALLÓ BORRADO EN EMPLEADO" + ex.Message;
            }
            return mensaje;
        }


        public string ActualizarEmpleado()
        {
            string mensaje = "";

            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();

                lst.Add(new Cls_parametros("@IdEmpleado", C_IdEmpleado));
                lst.Add(new Cls_parametros("@strNombre", C_strNombre));
                lst.Add(new Cls_parametros("@NumDocumento", C_NumDocumento));
                lst.Add(new Cls_parametros("@StrDireccion", C_strDireccion));
                lst.Add(new Cls_parametros("@StrTelefono", C_strTelefono));
                lst.Add(new Cls_parametros("@StrEmail",C_strEmail));
                lst.Add(new Cls_parametros("@IdRolEmpleado", C_IdRolEmpleado));
                lst.Add(new Cls_parametros("@DtmIngreso", C_DtmIngreso));
                lst.Add(new Cls_parametros("@DtmRetiro", C_DtmRetiro));
                lst.Add(new Cls_parametros("@strDatosAdicionales", C_strDatosAdicionales));
                lst.Add(new Cls_parametros("@DtmFechaModifica", C_DtmFechaModifica));
                lst.Add(new Cls_parametros("@StrUsuarioModifico", C_strUsuarioModifico));

                mensaje = AccesoDatos.Ejecutar_Procedimiento("actualizar_Empleado", lst);
            }
            catch (Exception ex)
            {
                mensaje = "FALLÓ LA ACTUALIZACION EMPLEADO" + ex.Message;
            }
            return mensaje;
        }
    }
}
