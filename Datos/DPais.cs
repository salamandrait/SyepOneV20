using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DPais
    {

        #region PARAMETROS
        public Object Dcod_pais { get; set; }
        public Object Dcod_paisv { get; set; }
        public Object Ddesc_pais { get; set; }
        public Object Dcod_moneda { get; set; }
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


        private static SqlParameter Getcod_pais(DPais Pais)
        {
            SqlParameter Pcod_pais = new SqlParameter
            {
                ParameterName = "@cod_pais",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Pais.Dcod_pais,
            };
            return Pcod_pais;
        }

        private static SqlParameter Getcod_paisv(DPais Pais)
        {
            SqlParameter Pcod_paisv = new SqlParameter
            {
                ParameterName = "@cod_paisv",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Pais.Dcod_paisv,
            };
            return Pcod_paisv;
        }

        private static SqlParameter Getdesc_pais(DPais Pais)
        {
            SqlParameter Pdesc_pais = new SqlParameter
            {
                ParameterName = "@desc_pais",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Value = Pais.Ddesc_pais,
            };
            return Pdesc_pais;
        }

        private static SqlParameter Getcod_moneda(DPais Pais)
        {
            SqlParameter Pcod_moneda = new SqlParameter
            {
                ParameterName = "@cod_moneda",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Pais.Dcod_moneda,
            };
            return Pcod_moneda;
        }

        private static SqlParameter Getcampo1(DPais Pais)
        {
            SqlParameter Pcampo1 = new SqlParameter
            {
                ParameterName = "@campo1",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Pais.Dcampo1,
            };
            return Pcampo1;
        }

        private static SqlParameter Getcampo2(DPais Pais)
        {
            SqlParameter Pcampo2 = new SqlParameter
            {
                ParameterName = "@campo2",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Pais.Dcampo2,
            };
            return Pcampo2;
        }

        private static SqlParameter Getcampo3(DPais Pais)
        {
            SqlParameter Pcampo3 = new SqlParameter
            {
                ParameterName = "@campo3",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Pais.Dcampo3,
            };
            return Pcampo3;
        }

        private static SqlParameter Getcampo4(DPais Pais)
        {
            SqlParameter Pcampo4 = new SqlParameter
            {
                ParameterName = "@campo4",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Pais.Dcampo4,
            };
            return Pcampo4;
        }

        private static SqlParameter Getcampo5(DPais Pais)
        {
            SqlParameter Pcampo5 = new SqlParameter
            {
                ParameterName = "@campo5",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Pais.Dcampo5,
            };
            return Pcampo5;
        }

        private static SqlParameter Getcampo6(DPais Pais)
        {
            SqlParameter Pcampo6 = new SqlParameter
            {
                ParameterName = "@campo6",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Pais.Dcampo6,
            };
            return Pcampo6;
        }

        private static SqlParameter Getbuscar(DPais Pais)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Pais.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DPais Pais)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Pais.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DPais Pais)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Pais.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DPais Pais)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Pais.Dbtipo,
            };
            return Pbtipo;
        }

        #endregion

        public DPais()
        {
            /// Constructor Vacio
        }


        /// <summary>
        /// Tabla Mostrar No Recibe parametros y Muestra un DataTable
        /// </summary>
        /// <returns> No Recibe Parametros</returns>
        public DataTable Mostrar()
        {
            DataTable DtRpta = new DataTable("TbPais");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "pais_mostrar",
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
                    CommandText = "pais_listar",
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
        public string Insertar(DPais Pais)
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
                    CommandText = "pais_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_pais = Getcod_pais(Pais);
                Cmd.Parameters.Add(Parcod_pais);

                SqlParameter Pardesc_pais = Getdesc_pais(Pais);
                Cmd.Parameters.Add(Pardesc_pais);

                SqlParameter Parcod_moneda = Getcod_moneda(Pais);
                Cmd.Parameters.Add(Parcod_moneda);

                SqlParameter Parcampo1 = Getcampo1(Pais);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Pais);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Pais);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Pais);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Pais);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Pais);
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
        public string Editar(DPais Pais)
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
                    CommandText = "pais_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_pais = Getcod_pais(Pais);
                Cmd.Parameters.Add(Parcod_pais);

                SqlParameter Parcod_paisv = Getcod_paisv(Pais);
                Cmd.Parameters.Add(Parcod_paisv);

                SqlParameter Pardesc_pais = Getdesc_pais(Pais);
                Cmd.Parameters.Add(Pardesc_pais);

                SqlParameter Parcod_moneda = Getcod_moneda(Pais);
                Cmd.Parameters.Add(Parcod_moneda);

                SqlParameter Parcampo1 = Getcampo1(Pais);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Pais);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Pais);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Pais);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Pais);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Pais);
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
        public string Eliminar(DPais Pais)
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
                    CommandText = "pais_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_pais = Getcod_pais(Pais);
                Cmd.Parameters.Add(Parcod_pais);

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
        public DataTable Buscar(DPais Pais)
        {
            DataTable DtRpta = new DataTable("TbPais");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "pais_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(Pais);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(Pais);
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
        public DataTable RepBuscar(DPais Pais)
        {
            DataTable DtRpta = new DataTable("TbPais");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "pais_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(Pais);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(Pais);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(Pais);
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
                    CommandText = "pais_primero",
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
                    CommandText = "pais_ultimo",
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
        /// <param name="Listar Anterior Pais"></param>
        public DataSet Anterior(DPais Pais)
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
                    CommandText = "pais_anterior",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_pais = Getcod_pais(Pais);
                Cmd.Parameters.Add(Parcod_pais);

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
        /// <param name="Listar Siguiente Pais"></param>
        public DataSet Siguiente(DPais Pais)
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
                    CommandText = "pais_siguiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_pais = Getcod_pais(Pais);
                Cmd.Parameters.Add(Parcod_pais);

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
        public string GenerarCod(DPais Pais)
        {
            SqlConnection SqlConn = new SqlConnection
            {
                ConnectionString = DConexion.Cn
            };

            SqlConn.Open();
            SqlCommand Cmd = new SqlCommand
            {
                Connection = SqlConn,
                CommandText = "pais_generar_cod",
                CommandType = CommandType.StoredProcedure,
            };

            try
            {
                SqlParameter ParCod_pais = new SqlParameter("@cod_pais", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                    Value = Pais.Dcod_pais
                };
                Cmd.Parameters.Add(ParCod_pais);

                if (Cmd.ExecuteNonQuery() == 0)
                {
                    return Cmd.Parameters[ParCod_pais.ToString()].Value.ToString();
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
            return Cmd.Parameters["@cod_pais"].Value.ToString();
        }
    }
}
