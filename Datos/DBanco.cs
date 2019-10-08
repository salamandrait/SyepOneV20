using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DBanco
    {

        #region PARAMETROS
        public Object Dcod_banco { get; set; }
        public Object Dcod_bancov { get; set; }
        public Object Ddesc_banco { get; set; }
        public Object Dcod_moneda { get; set; }
        public Object Dtelefono { get; set; }
        public Object Dplazo1 { get; set; }
        public Object Dplazo2 { get; set; }
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


        private static SqlParameter Getcod_banco(DBanco Banco)
        {
            SqlParameter Pcod_banco = new SqlParameter
            {
                ParameterName = "@cod_banco",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Banco.Dcod_banco,
            };
            return Pcod_banco;
        }

        private static SqlParameter Getcod_bancov(DBanco Banco)
        {
            SqlParameter Pcod_bancov = new SqlParameter
            {
                ParameterName = "@cod_bancov",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Banco.Dcod_bancov,
            };
            return Pcod_bancov;
        }

        private static SqlParameter Getdesc_banco(DBanco Banco)
        {
            SqlParameter Pdesc_banco = new SqlParameter
            {
                ParameterName = "@desc_banco",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Value = Banco.Ddesc_banco,
            };
            return Pdesc_banco;
        }
        
        private static SqlParameter Getcod_moneda(DBanco Banco)
        {
            SqlParameter Pcod_moneda = new SqlParameter
            {
                ParameterName = "@cod_moneda",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Banco.Dcod_moneda,
            };
            return Pcod_moneda;
        }

        private static SqlParameter Gettelefono(DBanco Banco)
        {
            SqlParameter Ptelefono = new SqlParameter
            {
                ParameterName = "@telefono",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Banco.Dtelefono,
            };
            return Ptelefono;
        }

        private static SqlParameter Getplazo1(DBanco Banco)
        {
            SqlParameter Pplazo1 = new SqlParameter
            {
                ParameterName = "@plazo1",
                SqlDbType = SqlDbType.Int,
                Value = Banco.Dplazo1,
            };
            return Pplazo1;
        }

        private static SqlParameter Getplazo2(DBanco Banco)
        {
            SqlParameter Pplazo2 = new SqlParameter
            {
                ParameterName = "@plazo2",
                SqlDbType = SqlDbType.Int,
                Value = Banco.Dplazo2,
            };
            return Pplazo2;
        }

        private static SqlParameter Getcampo1(DBanco Banco)
        {
            SqlParameter Pcampo1 = new SqlParameter
            {
                ParameterName = "@campo1",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Banco.Dcampo1,
            };
            return Pcampo1;
        }

        private static SqlParameter Getcampo2(DBanco Banco)
        {
            SqlParameter Pcampo2 = new SqlParameter
            {
                ParameterName = "@campo2",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Banco.Dcampo2,
            };
            return Pcampo2;
        }

        private static SqlParameter Getcampo3(DBanco Banco)
        {
            SqlParameter Pcampo3 = new SqlParameter
            {
                ParameterName = "@campo3",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Banco.Dcampo3,
            };
            return Pcampo3;
        }

        private static SqlParameter Getcampo4(DBanco Banco)
        {
            SqlParameter Pcampo4 = new SqlParameter
            {
                ParameterName = "@campo4",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Banco.Dcampo4,
            };
            return Pcampo4;
        }

        private static SqlParameter Getcampo5(DBanco Banco)
        {
            SqlParameter Pcampo5 = new SqlParameter
            {
                ParameterName = "@campo5",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Banco.Dcampo5,
            };
            return Pcampo5;
        }

        private static SqlParameter Getcampo6(DBanco Banco)
        {
            SqlParameter Pcampo6 = new SqlParameter
            {
                ParameterName = "@campo6",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Banco.Dcampo6,
            };
            return Pcampo6;
        }

        private static SqlParameter Getbuscar(DBanco Banco)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Banco.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DBanco Banco)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Banco.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DBanco Banco)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Banco.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DBanco Banco)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Banco.Dbtipo,
            };
            return Pbtipo;
        }

        #endregion

        public DBanco()
        {
            /// Constructor Vacio
        }


        /// <summary>
        /// Tabla Mostrar No Recibe parametros y Muestra un DataTable
        /// </summary>
        /// <returns> No Recibe Parametros</returns>
        public DataTable Mostrar()
        {
            DataTable DtRpta = new DataTable("TbBanco");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "banco_mostrar",
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
                    CommandText = "banco_listar",
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
        public string Insertar(DBanco Banco)
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
                    CommandText = "banco_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_banco = Getcod_banco(Banco);
                Cmd.Parameters.Add(Parcod_banco);

                SqlParameter Pardesc_banco = Getdesc_banco(Banco);
                Cmd.Parameters.Add(Pardesc_banco);

                SqlParameter Parcod_moneda = Getcod_moneda(Banco);
                Cmd.Parameters.Add(Parcod_moneda);

                SqlParameter Partelefono = Gettelefono(Banco);
                Cmd.Parameters.Add(Partelefono);

                SqlParameter Parplazo1 = Getplazo1(Banco);
                Cmd.Parameters.Add(Parplazo1);

                SqlParameter Parplazo2 = Getplazo2(Banco);
                Cmd.Parameters.Add(Parplazo2);

                SqlParameter Parcampo1 = Getcampo1(Banco);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Banco);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Banco);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Banco);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Banco);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Banco);
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
        public string Editar(DBanco Banco)
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
                    CommandText = "banco_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_banco = Getcod_banco(Banco);
                Cmd.Parameters.Add(Parcod_banco);

                SqlParameter Parcod_bancov = Getcod_bancov(Banco);
                Cmd.Parameters.Add(Parcod_bancov);

                SqlParameter Pardesc_banco = Getdesc_banco(Banco);
                Cmd.Parameters.Add(Pardesc_banco);

                SqlParameter Parcod_moneda = Getcod_moneda(Banco);
                Cmd.Parameters.Add(Parcod_moneda);

                SqlParameter Partelefono = Gettelefono(Banco);
                Cmd.Parameters.Add(Partelefono);

                SqlParameter Parplazo1 = Getplazo1(Banco);
                Cmd.Parameters.Add(Parplazo1);

                SqlParameter Parplazo2 = Getplazo2(Banco);
                Cmd.Parameters.Add(Parplazo2);

                SqlParameter Parcampo1 = Getcampo1(Banco);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Banco);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Banco);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Banco);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Banco);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Banco);
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
        public string Eliminar(DBanco Banco)
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
                    CommandText = "banco_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_banco = Getcod_banco(Banco);
                Cmd.Parameters.Add(Parcod_banco);

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
        public DataTable Buscar(DBanco Banco)
        {
            DataTable DtRpta = new DataTable("TbBanco");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "banco_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(Banco);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(Banco);
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
        public DataTable RepBuscar(DBanco Banco)
        {
            DataTable DtRpta = new DataTable("TbBanco");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "banco_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(Banco);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(Banco);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(Banco);
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
                    CommandText = "banco_primero",
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
                    CommandText = "banco_ultimo",
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
        /// <param name="Listar Anterior Banco"></param>
        public DataSet Anterior(DBanco Banco)
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
                    CommandText = "banco_anterior",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_banco = Getcod_banco(Banco);
                Cmd.Parameters.Add(Parcod_banco);

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
        /// <param name="Listar Siguiente Banco"></param>
        public DataSet Siguiente(DBanco Banco)
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
                    CommandText = "banco_siguiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_banco = Getcod_banco(Banco);
                Cmd.Parameters.Add(Parcod_banco);

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
        public string GenerarCod(DBanco Banco)
        {
            SqlConnection SqlConn = new SqlConnection
            {
                ConnectionString = DConexion.Cn
            };

            SqlConn.Open();
            SqlCommand Cmd = new SqlCommand
            {
                Connection = SqlConn,
                CommandText = "banco_generar_cod",
                CommandType = CommandType.StoredProcedure,
            };

            try
            {
                SqlParameter ParCod_banco = new SqlParameter("@cod_banco", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                    Value = Banco.Dcod_banco
                };
                Cmd.Parameters.Add(ParCod_banco);

                if (Cmd.ExecuteNonQuery() == 0)
                {
                    return Cmd.Parameters[ParCod_banco.ToString()].Value.ToString();
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
            return Cmd.Parameters["@cod_banco"].Value.ToString();
        }
    }
}
