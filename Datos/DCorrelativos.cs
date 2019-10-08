using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DCorrelativos
    {

        #region PARAMETROS
        public Object Dcod_correlativos { get; set; }
        public Object Dcod_correlativosv { get; set; }
        public Object Ddesc_correlativos { get; set; }
        public Object Dtabla { get; set; }
        public Object Dprecadena { get; set; }
        public Object Dcadena { get; set; }
        public Object Dcod_num { get; set; }
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


        private static SqlParameter Getcod_correlativos(DCorrelativos Correlativos)
        {
            SqlParameter Pcod_correlativos = new SqlParameter
            {
                ParameterName = "@cod_correlativos",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Correlativos.Dcod_correlativos,
            };
            return Pcod_correlativos;
        }

        private static SqlParameter Getcod_correlativosv(DCorrelativos Correlativos)
        {
            SqlParameter Pcod_correlativosv = new SqlParameter
            {
                ParameterName = "@cod_correlativosv",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Correlativos.Dcod_correlativosv,
            };
            return Pcod_correlativosv;
        }

        private static SqlParameter Getdesc_correlativos(DCorrelativos Correlativos)
        {
            SqlParameter Pdesc_correlativos = new SqlParameter
            {
                ParameterName = "@desc_correlativos",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Value = Correlativos.Ddesc_correlativos,
            };
            return Pdesc_correlativos;
        }

        private static SqlParameter Gettabla(DCorrelativos Correlativos)
        {
            SqlParameter Ptabla = new SqlParameter
            {
                ParameterName = "@tabla",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Correlativos.Dtabla,
            };
            return Ptabla;
        }

        private static SqlParameter Getprecadena(DCorrelativos Correlativos)
        {
            SqlParameter Pprecadena = new SqlParameter
            {
                ParameterName = "@precadena",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Correlativos.Dprecadena,
            };
            return Pprecadena;
        }

        private static SqlParameter Getcadena(DCorrelativos Correlativos)
        {
            SqlParameter Pcadena = new SqlParameter
            {
                ParameterName = "@cadena",
                SqlDbType = SqlDbType.Int,
                Value = Correlativos.Dcadena,
            };
            return Pcadena;
        }

        private static SqlParameter Getcod_num(DCorrelativos Correlativos)
        {
            SqlParameter Pcod_num = new SqlParameter
            {
                ParameterName = "@cod_num",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Correlativos.Dcod_num,
            };
            return Pcod_num;
        }

        private static SqlParameter Getcampo1(DCorrelativos Correlativos)
        {
            SqlParameter Pcampo1 = new SqlParameter
            {
                ParameterName = "@campo1",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Correlativos.Dcampo1,
            };
            return Pcampo1;
        }

        private static SqlParameter Getcampo2(DCorrelativos Correlativos)
        {
            SqlParameter Pcampo2 = new SqlParameter
            {
                ParameterName = "@campo2",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Correlativos.Dcampo2,
            };
            return Pcampo2;
        }

        private static SqlParameter Getcampo3(DCorrelativos Correlativos)
        {
            SqlParameter Pcampo3 = new SqlParameter
            {
                ParameterName = "@campo3",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Correlativos.Dcampo3,
            };
            return Pcampo3;
        }

        private static SqlParameter Getcampo4(DCorrelativos Correlativos)
        {
            SqlParameter Pcampo4 = new SqlParameter
            {
                ParameterName = "@campo4",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Correlativos.Dcampo4,
            };
            return Pcampo4;
        }

        private static SqlParameter Getcampo5(DCorrelativos Correlativos)
        {
            SqlParameter Pcampo5 = new SqlParameter
            {
                ParameterName = "@campo5",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Correlativos.Dcampo5,
            };
            return Pcampo5;
        }

        private static SqlParameter Getcampo6(DCorrelativos Correlativos)
        {
            SqlParameter Pcampo6 = new SqlParameter
            {
                ParameterName = "@campo6",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Correlativos.Dcampo6,
            };
            return Pcampo6;
        }

        private static SqlParameter Getbuscar(DCorrelativos Correlativos)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Correlativos.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DCorrelativos Correlativos)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Correlativos.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DCorrelativos Correlativos)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Correlativos.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DCorrelativos Correlativos)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Correlativos.Dbtipo,
            };
            return Pbtipo;
        }

        #endregion

        public DCorrelativos()
        {
            /// Constructor Vacio
        }

        public DataSet Top_Serie(DCorrelativos DCorrelativos)
        {
            DataSet DsRpta = new DataSet();
            SqlConnection Conn = new SqlConnection();
            try
            {
                Conn.ConnectionString = DConexion.Cn;
                SqlCommand Cmd = new SqlCommand
                {
                    Connection = Conn,
                    CommandText = "correlativo_tablas_generar",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter Partabla = Gettabla(DCorrelativos);
                Cmd.Parameters.Add(Partabla);

                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DsRpta, "TbCorrelativos");

            }
            catch (Exception ex)
            {
                DsRpta = null;
                string rpta = "";
                rpta = ex.Message;
            }
            return DsRpta;
        }

        public DataSet Muestra(DCorrelativos DCorrelativos)
        {
            DataSet DsRpta = new DataSet();
            SqlConnection Conn = new SqlConnection();
            try
            {
                Conn.ConnectionString = DConexion.Cn;
                SqlCommand Cmd = new SqlCommand
                {
                    Connection = Conn,
                    CommandText = "correlativo_tablas_muestra",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter Partabla = Gettabla(DCorrelativos);
                Cmd.Parameters.Add(Partabla);

                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DsRpta, "TbCorrelativos");

            }
            catch (Exception ex)
            {
                DsRpta = null;
                string rpta = "";
                rpta = ex.Message;
            }
            return DsRpta;
        }

        /// <summary>
        /// Tabla Mostrar No Recibe parametros y Muestra un DataTable
        /// </summary>
        /// <returns> No Recibe Parametros</returns>
        public DataTable Mostrar()
        {
            DataTable DtRpta = new DataTable("TbCorrelativos");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "correlativos_mostrar",
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
                    CommandText = "correlativos_listar",
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
        public string Insertar(DCorrelativos Correlativos)
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
                    CommandText = "correlativos_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_correlativos = Getcod_correlativos(Correlativos);
                Cmd.Parameters.Add(Parcod_correlativos);

                SqlParameter Pardesc_correlativos = Getdesc_correlativos(Correlativos);
                Cmd.Parameters.Add(Pardesc_correlativos);

                SqlParameter Partabla = Gettabla(Correlativos);
                Cmd.Parameters.Add(Partabla);

                SqlParameter Parcadena = Getcadena(Correlativos);
                Cmd.Parameters.Add(Parcadena);

                SqlParameter Parprecadena = Getprecadena(Correlativos);
                Cmd.Parameters.Add(Parprecadena);

                SqlParameter Parcampo1 = Getcampo1(Correlativos);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Correlativos);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Correlativos);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Correlativos);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Correlativos);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Correlativos);
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
        public string Editar(DCorrelativos Correlativos)
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
                    CommandText = "correlativos_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_correlativos = Getcod_correlativos(Correlativos);
                Cmd.Parameters.Add(Parcod_correlativos);

                SqlParameter Parcod_correlativosv = Getcod_correlativosv(Correlativos);
                Cmd.Parameters.Add(Parcod_correlativosv);

                SqlParameter Pardesc_correlativos = Getdesc_correlativos(Correlativos);
                Cmd.Parameters.Add(Pardesc_correlativos);

                SqlParameter Partabla = Gettabla(Correlativos);
                Cmd.Parameters.Add(Partabla);

                SqlParameter Parcadena = Getcadena(Correlativos);
                Cmd.Parameters.Add(Parcadena);

                SqlParameter Parprecadena = Getprecadena(Correlativos);
                Cmd.Parameters.Add(Parprecadena);

                SqlParameter Parcod_num = Getcod_num(Correlativos);
                Cmd.Parameters.Add(Parcod_num);

                SqlParameter Parcampo1 = Getcampo1(Correlativos);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Correlativos);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Correlativos);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Correlativos);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Correlativos);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Correlativos);
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
        public string Eliminar(DCorrelativos Correlativos)
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
                    CommandText = "correlativos_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_correlativos = Getcod_correlativos(Correlativos);
                Cmd.Parameters.Add(Parcod_correlativos);

                Cmd.ExecuteNonQuery();
                Rpta = "Y";
            }
            catch (SqlException Exc)
            {
                if (Exc.Number == 2812)
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
        /// Metodo Buscar Datos Recibe 2 Parametros
        /// </summary>
        public DataTable Buscar(DCorrelativos Correlativos)
        {
            DataTable DtRpta = new DataTable("TbCorrelativos");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "correlativos_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(Correlativos);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(Correlativos);
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
        public DataTable RepBuscar(DCorrelativos Correlativos)
        {
            DataTable DtRpta = new DataTable("TbCorrelativos");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "correlativos_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(Correlativos);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(Correlativos);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(Correlativos);
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
                    CommandText = "correlativos_primero",
                    CommandType = CommandType.StoredProcedure,
                };

                Cmd.ExecuteNonQuery();
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DsRpta, "TbCorrelativos");

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
                    CommandText = "correlativos_ultimo",
                    CommandType = CommandType.StoredProcedure,
                };

                Cmd.ExecuteNonQuery();
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DsRpta, "TbCorrelativos");

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
        /// <param name="Listar Anterior Correlativos"></param>
        public DataSet Anterior(DCorrelativos Correlativos)
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
                    CommandText = "correlativos_anterior",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Pardesc_correlativos = Getdesc_correlativos(Correlativos);
                Cmd.Parameters.Add(Pardesc_correlativos);

                Cmd.ExecuteNonQuery();
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DsRpta, "TbCorrelativos");

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
        /// <param name="Listar Siguiente Correlativos"></param>
        public DataSet Siguiente(DCorrelativos Correlativos)
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
                    CommandText = "correlativos_siguiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Pardesc_correlativos = Getdesc_correlativos(Correlativos);
                Cmd.Parameters.Add(Pardesc_correlativos);

                Cmd.ExecuteNonQuery();
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DsRpta, "TbCorrelativos");

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
        public string GenerarCod(DCorrelativos Correlativos)
        {
            SqlConnection SqlConn = new SqlConnection
            {
                ConnectionString = DConexion.Cn
            };

            SqlConn.Open();
            SqlCommand Cmd = new SqlCommand
            {
                Connection = SqlConn,
                CommandText = "correlativos_generar_cod",
                CommandType = CommandType.StoredProcedure,
            };

            try
            {
                SqlParameter ParCod_correlativos = new SqlParameter("@cod_correlativos", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                    Value = Correlativos.Dcod_correlativos
                };
                Cmd.Parameters.Add(ParCod_correlativos);

                if (Cmd.ExecuteNonQuery() == 0)
                {
                    return Cmd.Parameters[ParCod_correlativos.ToString()].Value.ToString();
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
            return Cmd.Parameters["@cod_correlativos"].Value.ToString();
        }

        public string GenerarCod_Muestra(DCorrelativos Correlativos)
        {
            SqlConnection SqlConn = new SqlConnection
            {
                ConnectionString = DConexion.Cn
            };

            SqlConn.Open();
            SqlCommand Cmd = new SqlCommand
            {
                Connection = SqlConn,
                CommandText = "correlativos_generar_muestra",
                CommandType = CommandType.StoredProcedure,
            };

            try
            {
                SqlParameter ParCod_correlativos = new SqlParameter("@codigo", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                    Value = Correlativos.Dcod_correlativos
                };
                Cmd.Parameters.Add(ParCod_correlativos);

                SqlParameter ParTabla = new SqlParameter("@tabla", SqlDbType.VarChar)
                {
                    Direction = ParameterDirection.Input,
                    Size = 50,
                    Value = Correlativos.Dtabla,
                };
                Cmd.Parameters.Add(ParTabla);

                if (Cmd.ExecuteNonQuery() == 0)
                {
                    return Cmd.Parameters[ParCod_correlativos.ToString()].Value.ToString();
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
            return Cmd.Parameters["@codigo"].Value.ToString();
        }
    }
}
