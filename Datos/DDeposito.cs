using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DDeposito
    {

        #region PARAMETROS
        public Object Dcod_deposito { get; set; }
        public Object Dcod_depositov { get; set; }
        public Object Ddesc_deposito { get; set; }
        public Object Dresp_deposito { get; set; }
        public Object Dubicacion { get; set; }
        public Object Dfecha_reg { get; set; }
        public Object Ddireccion_adm { get; set; }
        public Object Dscompras { get; set; }
        public Object Dsventas { get; set; }
        public Object Dactivo { get; set; }
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


        private static SqlParameter Getcod_deposito(DDeposito Deposito)
        {
            SqlParameter Pcod_deposito = new SqlParameter
            {
                ParameterName = "@cod_deposito",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Deposito.Dcod_deposito,
            };
            return Pcod_deposito;
        }

        private static SqlParameter Getcod_depositov(DDeposito Deposito)
        {
            SqlParameter Pcod_depositov = new SqlParameter
            {
                ParameterName = "@cod_depositov",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Deposito.Dcod_depositov,
            };
            return Pcod_depositov;
        }

        private static SqlParameter Getdesc_deposito(DDeposito Deposito)
        {
            SqlParameter Pdesc_deposito = new SqlParameter
            {
                ParameterName = "@desc_deposito",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Value = Deposito.Ddesc_deposito,
            };
            return Pdesc_deposito;
        }

        private static SqlParameter Getresp_deposito(DDeposito Deposito)
        {
            SqlParameter Presp_deposito = new SqlParameter
            {
                ParameterName = "@resp_deposito",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Deposito.Dresp_deposito,
            };
            return Presp_deposito;
        }

        private static SqlParameter Getubicacion(DDeposito Deposito)
        {
            SqlParameter Pubicacion = new SqlParameter
            {
                ParameterName = "@ubicacion_deposito",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Deposito.Dubicacion,
            };
            return Pubicacion;
        }

        private static SqlParameter Getfecha_reg(DDeposito Deposito)
        {
            SqlParameter Pfecha_reg = new SqlParameter
            {
                ParameterName = "@fecha_reg",
                SqlDbType = SqlDbType.DateTime,
                Size = 50,
                Value = Deposito.Dfecha_reg,
            };
            return Pfecha_reg;
        }

        private static SqlParameter Getdireccion_adm(DDeposito Deposito)
        {
            SqlParameter Pdireccion_adm = new SqlParameter
            {
                ParameterName = "@direccion_adm",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Deposito.Ddireccion_adm,
            };
            return Pdireccion_adm;
        }

        private static SqlParameter Getscompras(DDeposito Deposito)
        {
            SqlParameter Pscompras = new SqlParameter
            {
                ParameterName = "@scompras",
                SqlDbType = SqlDbType.Bit,
                Size = 50,
                Value = Deposito.Dscompras,
            };
            return Pscompras;
        }

        private static SqlParameter Getsventas(DDeposito Deposito)
        {
            SqlParameter Psventas = new SqlParameter
            {
                ParameterName = "@sventas",
                SqlDbType = SqlDbType.Bit,
                Size = 50,
                Value = Deposito.Dsventas,
            };
            return Psventas;
        }

        private static SqlParameter Getactivo(DDeposito Deposito)
        {
            SqlParameter Pactivo = new SqlParameter
            {
                ParameterName = "@activo",
                SqlDbType = SqlDbType.Bit,
                Size = 50,
                Value = Deposito.Dactivo,
            };
            return Pactivo;
        }

        private static SqlParameter Getcampo1(DDeposito Deposito)
        {
            SqlParameter Pcampo1 = new SqlParameter
            {
                ParameterName = "@campo1",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Deposito.Dcampo1,
            };
            return Pcampo1;
        }

        private static SqlParameter Getcampo2(DDeposito Deposito)
        {
            SqlParameter Pcampo2 = new SqlParameter
            {
                ParameterName = "@campo2",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Deposito.Dcampo2,
            };
            return Pcampo2;
        }

        private static SqlParameter Getcampo3(DDeposito Deposito)
        {
            SqlParameter Pcampo3 = new SqlParameter
            {
                ParameterName = "@campo3",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Deposito.Dcampo3,
            };
            return Pcampo3;
        }

        private static SqlParameter Getcampo4(DDeposito Deposito)
        {
            SqlParameter Pcampo4 = new SqlParameter
            {
                ParameterName = "@campo4",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Deposito.Dcampo4,
            };
            return Pcampo4;
        }

        private static SqlParameter Getcampo5(DDeposito Deposito)
        {
            SqlParameter Pcampo5 = new SqlParameter
            {
                ParameterName = "@campo5",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Deposito.Dcampo5,
            };
            return Pcampo5;
        }

        private static SqlParameter Getcampo6(DDeposito Deposito)
        {
            SqlParameter Pcampo6 = new SqlParameter
            {
                ParameterName = "@campo6",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Deposito.Dcampo6,
            };
            return Pcampo6;
        }

        private static SqlParameter Getbuscar(DDeposito Deposito)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Deposito.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DDeposito Deposito)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Deposito.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DDeposito Deposito)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Deposito.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DDeposito Deposito)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Deposito.Dbtipo,
            };
            return Pbtipo;
        }

        #endregion

        public DDeposito()
        {
            /// Constructor Vacio
        }


        /// <summary>
        /// Tabla Mostrar No Recibe parametros y Muestra un DataTable
        /// </summary>
        /// <returns> No Recibe Parametros</returns>
        public DataTable Mostrar()
        {
            DataTable DtRpta = new DataTable("TbDeposito");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "deposito_mostrar",
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
                    CommandText = "deposito_listar",
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
        /// Procedimiento Listar Datos
        /// </summary>
        /// <param name=""></param>
        public DataSet ListarOp(DDeposito Deposito)
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
                    CommandText = "deposito_listar_op",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Pardesc_deposito = Getdesc_deposito(Deposito);
                Cmd.Parameters.Add(Pardesc_deposito);

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
        /// Metodo Insertar Datos Recibe 8 Parametros
        /// </summary>
        /// <returns> Recibe Parametros</returns>
        public string Insertar(DDeposito Deposito)
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
                    CommandText = "deposito_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_deposito = Getcod_deposito(Deposito);
                Cmd.Parameters.Add(Parcod_deposito);

                SqlParameter Pardesc_deposito = Getdesc_deposito(Deposito);
                Cmd.Parameters.Add(Pardesc_deposito);

                SqlParameter Parresp_deposito = Getresp_deposito(Deposito);
                Cmd.Parameters.Add(Parresp_deposito);

                SqlParameter Parubicacion = Getubicacion(Deposito);
                Cmd.Parameters.Add(Parubicacion);

                SqlParameter Parfecha_reg = Getfecha_reg(Deposito);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Pardireccion_adm = Getdireccion_adm(Deposito);
                Cmd.Parameters.Add(Pardireccion_adm);

                SqlParameter Parscompras = Getscompras(Deposito);
                Cmd.Parameters.Add(Parscompras);

                SqlParameter Parsventas = Getsventas(Deposito);
                Cmd.Parameters.Add(Parsventas);

                SqlParameter Paractivo = Getactivo(Deposito);
                Cmd.Parameters.Add(Paractivo);

                SqlParameter Parcampo1 = Getcampo1(Deposito);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Deposito);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Deposito);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Deposito);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Deposito);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Deposito);
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
        public string Editar(DDeposito Deposito)
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
                    CommandText = "deposito_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_deposito = Getcod_deposito(Deposito);
                Cmd.Parameters.Add(Parcod_deposito);

                SqlParameter Parcod_depositov = Getcod_depositov(Deposito);
                Cmd.Parameters.Add(Parcod_depositov);

                SqlParameter Pardesc_deposito = Getdesc_deposito(Deposito);
                Cmd.Parameters.Add(Pardesc_deposito);

                SqlParameter Parresp_deposito = Getresp_deposito(Deposito);
                Cmd.Parameters.Add(Parresp_deposito);

                SqlParameter Parubicacion = Getubicacion(Deposito);
                Cmd.Parameters.Add(Parubicacion);

                SqlParameter Parfecha_reg = Getfecha_reg(Deposito);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Pardireccion_adm = Getdireccion_adm(Deposito);
                Cmd.Parameters.Add(Pardireccion_adm);

                SqlParameter Parscompras = Getscompras(Deposito);
                Cmd.Parameters.Add(Parscompras);

                SqlParameter Parsventas = Getsventas(Deposito);
                Cmd.Parameters.Add(Parsventas);

                SqlParameter Paractivo = Getactivo(Deposito);
                Cmd.Parameters.Add(Paractivo);

                SqlParameter Parcampo1 = Getcampo1(Deposito);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Deposito);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Deposito);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Deposito);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Deposito);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Deposito);
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
        public string Eliminar(DDeposito Deposito)
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
                    CommandText = "deposito_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_deposito = Getcod_deposito(Deposito);
                Cmd.Parameters.Add(Parcod_deposito);

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
        public DataTable Buscar(DDeposito Deposito)
        {
            DataTable DtRpta = new DataTable("TbDeposito");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "deposito_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(Deposito);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(Deposito);
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
        public DataTable RepBuscar(DDeposito Deposito)
        {
            DataTable DtRpta = new DataTable("TbDeposito");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "deposito_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(Deposito);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(Deposito);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(Deposito);
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
                    CommandText = "deposito_primero",
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
                    CommandText = "deposito_ultimo",
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
        /// <param name="Listar Anterior Deposito"></param>
        public DataSet Anterior(DDeposito Deposito)
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
                    CommandText = "deposito_anterior",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_deposito = Getcod_deposito(Deposito);
                Cmd.Parameters.Add(Parcod_deposito);

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
        /// <param name="Listar Siguiente Deposito"></param>
        public DataSet Siguiente(DDeposito Deposito)
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
                    CommandText = "deposito_siguiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_deposito = Getcod_deposito(Deposito);
                Cmd.Parameters.Add(Parcod_deposito);

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
        public string GenerarCod(DDeposito Deposito)
        {
            SqlConnection SqlConn = new SqlConnection
            {
                ConnectionString = DConexion.Cn
            };

            SqlConn.Open();
            SqlCommand Cmd = new SqlCommand
            {
                Connection = SqlConn,
                CommandText = "deposito_generar_cod",
                CommandType = CommandType.StoredProcedure,
            };

            try
            {
                SqlParameter ParCod_deposito = new SqlParameter("@cod_deposito", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                    Value = Deposito.Dcod_deposito
                };
                Cmd.Parameters.Add(ParCod_deposito);

                if (Cmd.ExecuteNonQuery() == 0)
                {
                    return Cmd.Parameters[ParCod_deposito.ToString()].Value.ToString();
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
            return Cmd.Parameters["@cod_deposito"].Value.ToString();
        }
    }
}
