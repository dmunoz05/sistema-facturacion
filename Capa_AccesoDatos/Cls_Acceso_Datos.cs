using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Capa_AccesoDatos
{
    public class Cls_parametros
    {
        public string Nombre { get; set; }
        public object Valor { get; set; }
        public SqlDbType TipoDato { get; set; }
        public Int32 Tamaño { get; set; }
        public ParameterDirection Direccionparametro { get; set; }

        public Cls_parametros(string Objnombre, Object ObjValor)
        {
            Nombre = Objnombre;
            Valor = ObjValor;
            Direccionparametro = ParameterDirection.Input;
        }

        public Cls_parametros(string Objnombre, SqlDbType ObjTipoDato, Int32 ObjTamaño)
        {
            Nombre = Objnombre;
            ObjTipoDato = ObjTipoDato;
            ObjTamaño = ObjTamaño;
            Direccionparametro = ParameterDirection.Output;
        }
    }

    public class Cls_Acceso_Datos
    {
        SqlConnection conexion;
        SqlCommand cmd;
        SqlDataReader LectorDatos = null;
        SqlDataAdapter da;
        DataTable dt;

        public string AbrirBd()
        {
            string resultado = "";

            try
            {
                conexion = new SqlConnection("Data Source=LAPTOP-RLT0746T; Initial Catalog=[DBFACTURAS];Integrated Security=True");
                conexion.Open();
            }


            catch (Exception ex)
            {
                resultado = "ERROR: no se establecio la conexion con la base de datos" + ex;
            }
            return resultado;

        }

        public string CerrarBd()
        {
            string resultado = "";

            try
            {
                conexion.Close();
            }
            catch (Exception ex)
            {
                resultado = "ERROR: fallo al cerrar la conexion" + ex;
            }
            return resultado;
        }

        public string Ejecutar_Procedimiento(string procedimiento, List<Cls_parametros>lst)
        {
            string salida = "";

            try
            {
                int retornado;

                AbrirBd();

                SqlCommand Comando = new SqlCommand(procedimiento, conexion);
                Comando.CommandType = CommandType.StoredProcedure;

                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (lst[i].Direccionparametro == ParameterDirection.Input)
                        {
                            Comando.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                        }

                        if (lst[i].Direccionparametro == ParameterDirection.Output)
                        {
                            Comando.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamaño).Direction = ParameterDirection.Output;
                        }
                    }
                }

                retornado = Comando.ExecuteNonQuery();
                CerrarBd();

                if (retornado > 0)
                {
                    salida = "Los datos fueron Actualizados";
                }
                else
                {
                    salida = "Los datos no fueron Actualizados";
                }

            }
            catch (Exception ex)
            {
                salida = "ERROR: Falló operación: " + ex.Message;                
            }
            return salida;
        }

        public string EjecutarComando(string sentencia)
        {
            string salida = "";

            try
            {
                int retornado;
                AbrirBd();
                cmd = new SqlCommand(sentencia, conexion);
                retornado = cmd.ExecuteNonQuery();
                CerrarBd();

                if (retornado > 0)
                {
                    salida = "Los datos fueron Actualizados";
                }

                if (retornado > 0)
                {
                    salida = "Los datos no fueron Actualizados";
                }

            }
            catch (Exception ex)
            {
                salida = "ERROR: Falló operación: " + ex;
            }
            return salida;
        }

        public DataTable EjecutarConsulta(string cmd)
        {
            try
            {
                AbrirBd();
                da = new SqlDataAdapter(cmd, conexion);
                dt = new DataTable();
                da.Fill(dt);
                CerrarBd();

                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
