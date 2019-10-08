using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DCaja
    {

        #region PARAMETROS
        public Object Dcod_caja { get; set; }
        public Object Dcod_cajav { get; set; }
        public Object Ddesc_caja { get; set; }
        public Object Dcod_moneda { get; set; }
        public Object Dresponsable { get; set; }
        public Object Dsaldoefectivo { get; set; }
        public Object Dsaldodocumento { get; set; }
        public Object Dsaldototal { get; set; }
        public Object Dfecha_reg { get; set; }
        public Object Dactiva { get; set; }
        public Object Dcampo1 { get; set; }
        public Object Dcampo2 { get; set; }
        public Object Dcampo3 { get; set; }
        public Object Dcampo4 { get; set; }
        public Object Dcampo5 { get; set; }
        public Object Dcampo6 { get; set; }
        public Object Dbuscar { get; set; }
        public Object Dbuscard { get; set; }
        public Object Dbuscarh { get; set; }
        public Object Dbtipo { get; set; }

        private static SqlParameter Getcod_caja(DCaja Caja)
        {
            SqlParameter Pcod_caja = new SqlParameter
            {
                ParameterName = "@cod_caja",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Caja.Dcod_caja,
            };
            return Pcod_caja;
        }

        private static SqlParameter Getcod_cajav(DCaja Caja)
        {
            SqlParameter Pcod_cajav = new SqlParameter
            {
                ParameterName = "@cod_cajav",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Caja.Dcod_cajav,
            };
            return Pcod_cajav;
        }

        private static SqlParameter Getdesc_caja(DCaja Caja)
        {
            SqlParameter Pdesc_caja = new SqlParameter
            {
                ParameterName = "@desc_caja",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Value = Caja.Ddesc_caja,
            };
            return Pdesc_caja;
        }
        
        private static SqlParameter Getcod_moneda(DCaja Caja)
        {
            SqlParameter Pcod_moneda = new SqlParameter
            {
                ParameterName = "@cod_moneda",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Caja.Dcod_moneda,
            };
            return Pcod_moneda;
        }

        private static SqlParameter Getresponsable(DCaja Caja)
        {
            SqlParameter Presponsable = new SqlParameter
            {
                ParameterName = "@responsable",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Caja.Dresponsable,
            };
            return Presponsable;
        }

        private static SqlParameter Getsaldoefectivo(DCaja Caja)
        {
            SqlParameter Psaldoefectivo = new SqlParameter
            {
                ParameterName = "@saldoefectivo",
                SqlDbType = SqlDbType.Money,
                Value = Caja.Dsaldoefectivo,
            };
            return Psaldoefectivo;
        }

        private static SqlParameter Getsaldodocumento(DCaja Caja)
        {
            SqlParameter Psaldodocumento = new SqlParameter
            {
                ParameterName = "@saldodocumento",
                SqlDbType = SqlDbType.Money,
                Value = Caja.Dsaldodocumento,
            };
            return Psaldodocumento;
        }

        private static SqlParameter Getsaldototal(DCaja Caja)
        {
            SqlParameter Psaldototal = new SqlParameter
            {
                ParameterName = "@saldototal",
                SqlDbType = SqlDbType.Money,
                Value = Caja.Dsaldototal,
            };
            return Psaldototal;
        }

        private static SqlParameter Getfecha_reg(DCaja Caja)
        {
            SqlParameter Pfecha_reg = new SqlParameter
            {
                ParameterName = "@fecha_reg",
                SqlDbType = SqlDbType.DateTime,
                Value = Caja.Dfecha_reg,
            };
            return Pfecha_reg;
        }

        private static SqlParameter Getactiva(DCaja Caja)
        {
            SqlParameter Pactiva = new SqlParameter
            {
                ParameterName = "@activa",
                SqlDbType = SqlDbType.Bit,
                Value = Caja.Dactiva,
            };
            return Pactiva;
        }

        private static SqlParameter Getcampo1(DCaja Caja)
        {
            SqlParameter Pcampo1 = new SqlParameter
            {
                ParameterName = "@campo1",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Caja.Dcampo1,
            };
            return Pcampo1;
        }

        private static SqlParameter Getcampo2(DCaja Caja)
        {
            SqlParameter Pcampo2 = new SqlParameter
            {
                ParameterName = "@campo2",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Caja.Dcampo2,
            };
            return Pcampo2;
        }

        private static SqlParameter Getcampo3(DCaja Caja)
        {
            SqlParameter Pcampo3 = new SqlParameter
            {
                ParameterName = "@campo3",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Caja.Dcampo3,
            };
            return Pcampo3;
        }

        private static SqlParameter Getcampo4(DCaja Caja)
        {
            SqlParameter Pcampo4 = new SqlParameter
            {
                ParameterName = "@campo4",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Caja.Dcampo4,
            };
            return Pcampo4;
        }

        private static SqlParameter Getcampo5(DCaja Caja)
        {
            SqlParameter Pcampo5 = new SqlParameter
            {
                ParameterName = "@campo5",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Caja.Dcampo5,
            };
            return Pcampo5;
        }

        private static SqlParameter Getcampo6(DCaja Caja)
        {
            SqlParameter Pcampo6 = new SqlParameter
            {
                ParameterName = "@campo6",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Caja.Dcampo6,
            };
            return Pcampo6;
        }

        private static SqlParameter Getbuscar(DCaja Caja)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Caja.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DCaja Caja)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Caja.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DCaja Caja)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Caja.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DCaja Caja)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Caja.Dbtipo,
            };
            return Pbtipo;
        }

        #endregion

        public DCaja()
        {
            /// Constructor Vacio
        }

        /// <summary>
        /// Tabla Mostrar No Recibe parametros y Muestra un DataTable
        /// </summary>
        /// <returns> No Recibe Parametros</returns>
        public DataTable Mostrar()
        {
            DataTable DtRpta = new DataTable("TbCaja");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "caja_mostrar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlDataAdapter Dat = new SqlDataAdapter(Cmd);
                Dat.Fill(DtRpta);

            }
            catch (Exception Exc)
            {

                DtRpta = null;
                throw new Exception("Error al Ejecutar el procedimiento almacenado  " + Exc.Message);
            }
            finally
            {
                if (SqlConn.State == ConnectionState.Open)
                {
                    SqlConn.Close();
                }
            }
            return DtRpta;
        }

        /// <summary>
        /// Tabla Listar No Recibe parametros y Muestra un DataSet
        /// </summary>
        /// <returns> No Recibe Parametros</returns>
        public DataSet Listar()
        {
            DataSet DsRpta = new DataSet();
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "caja_listar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlDataAdapter Dat = new SqlDataAdapter(Cmd);
                Dat.Fill(DsRpta);

            }
            catch (Exception Exc)
            {

                DsRpta = null;
                throw new Exception("Error al Ejecutar el procedimiento almacenado  " + Exc.Message);
            }
            finally
            {
                if (SqlConn.State == ConnectionState.Open)
                {
                    SqlConn.Close();
                }
            }
            return DsRpta;
        }

        /// <summary>
        /// Metodo Insertar Datos Recibe 8 Parametros
        /// </summary>
        /// <returns> Recibe Parametros</returns>
        public string Insertar(DCaja Caja)
        {
            string Rpta = "";
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand()
                {
                    Connection = SqlConn,
                    CommandText = "caja_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_caja = Getcod_caja(Caja);
                Cmd.Parameters.Add(Parcod_caja);

                SqlParameter Pardesc_caja = Getdesc_caja(Caja);
                Cmd.Parameters.Add(Pardesc_caja);

                SqlParameter Parcod_moneda = Getcod_moneda(Caja);
                Cmd.Parameters.Add(Parcod_moneda);

                SqlParameter Parresponsable = Getresponsable(Caja);
                Cmd.Parameters.Add(Parresponsable);

                SqlParameter Parsaldoefectivo = Getsaldoefectivo(Caja);
                Cmd.Parameters.Add(Parsaldoefectivo);

                SqlParameter Parsaldodocumento = Getsaldodocumento(Caja);
                Cmd.Parameters.Add(Parsaldodocumento);

                SqlParameter Parsaldototal = Getsaldototal(Caja);
                Cmd.Parameters.Add(Parsaldototal);

                SqlParameter Parfecha_reg = Getfecha_reg(Caja);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Paractiva = Getactiva(Caja);
                Cmd.Parameters.Add(Paractiva);

                SqlParameter Parcampo1 = Getcampo1(Caja);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Caja);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Caja);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Caja);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Caja);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Caja);
                Cmd.Parameters.Add(Parcampo6);

                Cmd.ExecuteNonQuery();
                Rpta = "Y";
            }
            catch (SqlException Exc)
            {
                if (Exc.Number == 8152)
                {
                    Rpta = "Ha introducido demasiados caracteres en uno de los campos.";
                }
                else if (Exc.Number == 2627)
                {
                    Rpta = "El Codigo Ya Existe. No se Permiten Registros Duplicados.";
                }
                else if (Exc.Number == 2812)
                {
                    Rpta = "No Existe el Procedimiento Almacenado";
                }
                else
                {
                    Rpta = "Error al intentar ejecutar el procedimiento almacenado " + Exc.Message;
                }
            }
            finally
            {
                if (SqlConn.State == ConnectionState.Open) SqlConn.Close();
            }
            return Rpta;
        }

        /// <summary>
        /// Metodo Editar Datos Recibe 9 Parametros
        /// </summary>
        /// <returns> Recibe Parametros</returns>
        public string Editar(DCaja Caja)
        {
            string Rpta = "";
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand()
                {
                    Connection = SqlConn,
                    CommandText = "caja_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_caja = Getcod_caja(Caja);
                Cmd.Parameters.Add(Parcod_caja);

                SqlParameter Parcod_cajav = Getcod_cajav(Caja);
                Cmd.Parameters.Add(Parcod_cajav);

                SqlParameter Pardesc_caja = Getdesc_caja(Caja);
                Cmd.Parameters.Add(Pardesc_caja);

                SqlParameter Parcod_moneda = Getcod_moneda(Caja);
                Cmd.Parameters.Add(Parcod_moneda);

                SqlParameter Parresponsable = Getresponsable(Caja);
                Cmd.Parameters.Add(Parresponsable);

                SqlParameter Parsaldoefectivo = Getsaldoefectivo(Caja);
                Cmd.Parameters.Add(Parsaldoefectivo);

                SqlParameter Parsaldodocumento = Getsaldodocumento(Caja);
                Cmd.Parameters.Add(Parsaldodocumento);

                SqlParameter Parsaldototal = Getsaldototal(Caja);
                Cmd.Parameters.Add(Parsaldototal);

                SqlParameter Parfecha_reg = Getfecha_reg(Caja);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Paractiva = Getactiva(Caja);
                Cmd.Parameters.Add(Paractiva);

                SqlParameter Parcampo1 = Getcampo1(Caja);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Caja);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Caja);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Caja);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Caja);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Caja);
                Cmd.Parameters.Add(Parcampo6);

                Cmd.ExecuteNonQuery();
                Rpta = "Y";
            }
            catch (SqlException Exc)
            {
                if (Exc.Number == 8152)
                {
                    Rpta = "Ha introducido demasiados caracteres en uno de los campos.";
                }
                else if (Exc.Number == 2627)
                {
                    Rpta = "El Codigo Ya Existe. No se Permiten Registros Duplicados.";
                }
                else if (Exc.Number == 2812)
                {
                    Rpta = "No Existe el Procedimiento Almacenado";
                }
                else
                {
                    Rpta = "Error al intentar ejecutar el procedimiento almacenado " + Exc.Message;
                }
            }
            finally
            {
                if (SqlConn.State == ConnectionState.Open) SqlConn.Close();
            }
            return Rpta;
        }

        /// <summary>
        /// Metodo Eliminar Datos Recibe 1 Parametro
        /// </summary>
        /// <returns> Recibe Parametros</returns>
        public string Eliminar(DCaja Caja)
        {
            string Rpta = "";
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand()
                {
                    Connection = SqlConn,
                    CommandText = "caja_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_caja = Getcod_caja(Caja);
                Cmd.Parameters.Add(Parcod_caja);

                Cmd.ExecuteNonQuery();
                Rpta = "Y";
            }
            catch (SqlException Exc)
            {
                if (Exc.Number == 2812)
                {
                    Rpta = "No Existe el Procedimiento Almacenado";
                }
                else if (Exc.Number == 547)
                {
                    Rpta = "No se Pueden Eliminar Registros Relacionados!  "+ Exc.Message;
                }
                else
                {
                    Rpta = "Error al intentar ejecutar el procedimiento almacenado! " + Exc.Message;
                }
            }
            finally
            {
                if (SqlConn.State == ConnectionState.Open) SqlConn.Close();
            }
            return Rpta;
        }

        /// <summary>
        /// Metodo Buscar Datos Recibe 2 Parametros
        /// </summary>
        public DataTable Buscar(DCaja Caja)
        {
            DataTable DtRpta = new DataTable("TbCaja");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "caja_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(Caja);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(Caja);
                Cmd.Parameters.Add(Parbtipo);

                Cmd.ExecuteNonQuery();
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DtRpta);

            }
            catch (Exception Ex)
            {
                DtRpta = null;
                throw new Exception("Error al Ejecutar el procedimiento almacenado" + Ex.Message, Ex);
            }
            finally
            {
                SqlConn.Close();
            }
            return DtRpta;
        }

        /// <summary>
        /// Procedimiento Buscar Datos Recibe 3 Parametros
        /// </summary>
        public DataTable RepBuscar(DCaja Caja)
        {
            DataTable DtRpta = new DataTable("TbCaja");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "caja_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(Caja);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(Caja);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(Caja);
                Cmd.Parameters.Add(Parbtipo);

                Cmd.ExecuteNonQuery();
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DtRpta);

            }
            catch (Exception Ex)
            {
                DtRpta = null;
                throw new Exception("Error al Ejecutar el procedimiento almacenado" + Ex.Message, Ex);
            }
            finally
            {
                SqlConn.Close();
            }
            return DtRpta;
        }

        /// <summary>
        /// Procedimiento Listar Primero Datos
        /// </summary>
        public DataSet Primero()
        {
            DataSet DsRpta = new DataSet();
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "caja_primero",
                    CommandType = CommandType.StoredProcedure,
                };

                Cmd.ExecuteNonQuery();
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DsRpta);

            }
            catch (Exception Ex)
            {
                DsRpta = null;
                throw new Exception("Error al Ejecutar el procedimiento almacenado" + Ex.Message, Ex);
            }
            finally
            {
                SqlConn.Close();
            }
            return DsRpta;
        }

        /// <summary>
        /// Procedimiento Listar Ultimo Datos
        /// </summary>
        public DataSet Ultimo()
        {
            DataSet DsRpta = new DataSet();
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "caja_ultimo",
                    CommandType = CommandType.StoredProcedure,
                };

                Cmd.ExecuteNonQuery();
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DsRpta);

            }
            catch (Exception Ex)
            {
                DsRpta = null;
                throw new Exception("Error al Ejecutar el procedimiento almacenado" + Ex.Message, Ex);
            }
            finally
            {
                SqlConn.Close();
            }
            return DsRpta;
        }

        /// <summary>
        /// Procedimiento Listar Anterior Datos
        /// </summary>
        /// <param name="Listar Anterior Caja"></param>
        public DataSet Anterior(DCaja Caja)
        {
            DataSet DsRpta = new DataSet();
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "caja_anterior",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_caja = Getcod_caja(Caja);
                Cmd.Parameters.Add(Parcod_caja);

                Cmd.ExecuteNonQuery();
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DsRpta);

            }
            catch (Exception Ex)
            {
                DsRpta = null;
                throw new Exception("Error al Ejecutar el procedimiento almacenado" + Ex.Message, Ex);
            }
            finally
            {
                SqlConn.Close();
            }
            return DsRpta;
        }

        /// <summary>
        /// Procedimiento Listar Siguiente Datos
        /// </summary>
        /// <param name="Listar Siguiente Caja"></param>
        public DataSet Siguiente(DCaja Caja)
        {
            DataSet DsRpta = new DataSet();
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "caja_siguiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_caja = Getcod_caja(Caja);
                Cmd.Parameters.Add(Parcod_caja);

                Cmd.ExecuteNonQuery();
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DsRpta);

            }
            catch (Exception Ex)
            {
                DsRpta = null;
                throw new Exception("Error al Ejecutar el procedimiento almacenado" + Ex.Message, Ex);
            }
            finally
            {
                SqlConn.Close();
            }
            return DsRpta;
        }

        /// <summary>
        /// Procedimiento Generar Codigo
        /// </summary>
        /// <param name="Generar Codigo"></param>
        /// <return>Retorna el Codigo</return>
        public string GenerarCod(DCaja Caja)
        {
            SqlConnection SqlConn = new SqlConnection
            {
                ConnectionString = DConexion.Cn
            };

            SqlConn.Open();
            SqlCommand Cmd = new SqlCommand
            {
                Connection = SqlConn,
                CommandText = "caja_generar_cod",
                CommandType = CommandType.StoredProcedure,
            };

            try
            {
                SqlParameter ParCod_caja = new SqlParameter("@cod_caja", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                    Value = Caja.Dcod_caja
                };
                Cmd.Parameters.Add(ParCod_caja);

                if (Cmd.ExecuteNonQuery() == 0)
                {
                    return Cmd.Parameters[ParCod_caja.ToString()].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                string Resp = ex.Message;
            }
            finally
            {
                SqlConn.Close();
            }
            return Cmd.Parameters["@cod_caja"].Value.ToString();
        }
    }
}
