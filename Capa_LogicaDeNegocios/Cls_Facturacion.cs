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
    public class Cls_Facturacion
    {
        public int IdFactura { get; set; }
        public DateTime DtmFecha { get; set; }
        public int IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public int NumDescuento { get; set; }
        public int NumImpuesto { get; set; }
        public int NumValorTotal { get; set; }
        public int IdEstado { get; set; }
        public DateTime DtmFechaModifica { get; set; }
        public string StrUsuarioModifica = "Javier";

        Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();
        DataTable dt = new DataTable();


        public DataTable Consultar_Facturas()
        {
            string sentencia;
            try
            {
                sentencia = "Exec SpConsultaFactura";
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
        }


        public string Actualizar_Factura()
        {
            string mensaje = "";

            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();

                lst.Add(new Cls_parametros("@IdFactura", IdFactura));
                lst.Add(new Cls_parametros("@DtmFecha", DtmFecha));
                lst.Add(new Cls_parametros("@IdCliente", IdCliente));
                lst.Add(new Cls_parametros("@IdEmpleado", IdEmpleado));
                lst.Add(new Cls_parametros("@IdEstado", IdEstado));
                lst.Add(new Cls_parametros("@NumDescuento", NumDescuento));
                lst.Add(new Cls_parametros("@NumImpuesto", NumImpuesto));
                lst.Add(new Cls_parametros("@NumValorTotal", NumValorTotal));
                lst.Add(new Cls_parametros("@DtmFechaModifica", DtmFechaModifica));
                lst.Add(new Cls_parametros("@StrUsuarioModifica", StrUsuarioModifica));
              
                mensaje = AccesoDatos.Ejecutar_Procedimiento("actualizar_Factura", lst);
            }
            catch (Exception ex)
            {
                mensaje = "FALLÓ LA ACTUALIZACION DE FACTURA" + ex.Message;
            }
            return mensaje;
        }

        public DataTable ConsultarEstado()
        {
            string sentencia;
            try
            {
                sentencia = $"SELECT * FROM TBLESTADO_FACTURA";
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public DataTable Consultar_Estado_Factura(int Id_Factura)
        {
            string sentencia;
            try
            {
                sentencia = $"SELECT * FROM TBLESTADO_FACTURA WHERE IdEstadoFactura = {Id_Factura}";
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public DataTable Filtrar_Factura(int Id_factura)
        {
            string sentencia = "";
            try
            {
                sentencia = $"SELECT * FROM TBLFACTURA WHERE IdFactura LIKE '%{Id_factura}%'";
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
