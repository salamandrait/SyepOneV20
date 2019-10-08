using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DUnidad
    {

        #region PARAMETROS
        public Object Dcod_unidad { get; set; }
        public Object Dcod_unidadv { get; set; }
        public Object Ddesc_unidad { get; set; }
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


        private static SqlParameter Getcod_unidad(DUnidad Unidad)
        {
            SqlParameter Pcod_unidad = new SqlParameter
            {
                ParameterName = "@cod_unidad",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Unidad.Dcod_unidad,
            };
            return Pcod_unidad;
        }

        private static SqlParameter Getcod_unidadv(DUnidad Unidad)
        {
            SqlParameter Pcod_unidadv = new SqlParameter
            {
                ParameterName = "@cod_unidadv",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Unidad.Dcod_unidadv,
            };
            return Pcod_unidadv;
        }

        private static SqlParameter Getdesc_unidad(DUnidad Unidad)
        {
            SqlParameter Pdesc_unidad = new SqlParameter
            {
                ParameterName = "@desc_unidad",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Value = Unidad.Ddesc_unidad,
            };
            return Pdesc_unidad;
        }

        private static SqlParameter Getcampo1(DUnidad Unidad)
        {
            SqlParameter Pcampo1 = new SqlParameter
            {
                ParameterName = "@campo1",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Unidad.Dcampo1,
            };
            return Pcampo1;
        }

        private static SqlParameter Getcampo2(DUnidad Unidad)
        {
            SqlParameter Pcampo2 = new SqlParameter
            {
                ParameterName = "@campo2",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Unidad.Dcampo2,
            };
            return Pcampo2;
        }

        private static SqlParameter Getcampo3(DUnidad Unidad)
        {
            SqlParameter Pcampo3 = new SqlParameter
            {
                ParameterName = "@campo3",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Unidad.Dcampo3,
            };
            return Pcampo3;
        }

        private static SqlParameter Getcampo4(DUnidad Unidad)
        {
            SqlParameter Pcampo4 = new SqlParameter
            {
                ParameterName = "@campo4",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Unidad.Dcampo4,
            };
            return Pcampo4;
        }

        private static SqlParameter Getcampo5(DUnidad Unidad)
        {
            SqlParameter Pcampo5 = new SqlParameter
            {
                ParameterName = "@campo5",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Unidad.Dcampo5,
            };
            return Pcampo5;
        }

        private static SqlParameter Getcampo6(DUnidad Unidad)
        {
            SqlParameter Pcampo6 = new SqlParameter
            {
                ParameterName = "@campo6",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Unidad.Dcampo6,
            };
            return Pcampo6;
        }

        private static SqlParameter Getbuscar(DUnidad Unidad)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Unidad.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DUnidad Unidad)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Unidad.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DUnidad Unidad)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Unidad.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DUnidad Unidad)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Unidad.Dbtipo,
            };
            return Pbtipo;
        }

        #endregion

        public DUnidad()
        {
            /// Constructor Vacio
        }


        /// <summary>
        /// Tabla Mostrar No Recibe parametros y Muestra un DataTable
        /// </summary>
        /// <returns> No Recibe Parametros</returns>
        public DataTable Mostrar()
        {
            DataTable DtRpta = new DataTable("TbUnidad");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "unidad_mostrar",
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
                    CommandText = "unidad_listar",
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
        public string Insertar(DUnidad Unidad)
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
                    CommandText = "unidad_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_unidad = Getcod_unidad(Unidad);
                Cmd.Parameters.Add(Parcod_unidad);

                SqlParameter Pardesc_unidad = Getdesc_unidad(Unidad);
                Cmd.Parameters.Add(Pardesc_unidad);

                SqlParameter Parcampo1 = Getcampo1(Unidad);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Unidad);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Unidad);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Unidad);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Unidad);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Unidad);
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
        public string Editar(DUnidad Unidad)
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
                    CommandText = "unidad_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_unidad = Getcod_unidad(Unidad);
                Cmd.Parameters.Add(Parcod_unidad);

                SqlParameter Parcod_unidadv = Getcod_unidadv(Unidad);
                Cmd.Parameters.Add(Parcod_unidadv);

                SqlParameter Pardesc_unidad = Getdesc_unidad(Unidad);
                Cmd.Parameters.Add(Pardesc_unidad);

                SqlParameter Parcampo1 = Getcampo1(Unidad);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Unidad);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Unidad);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Unidad);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Unidad);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Unidad);
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
        public string Eliminar(DUnidad Unidad)
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
                    CommandText = "unidad_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_unidad = Getcod_unidad(Unidad);
                Cmd.Parameters.Add(Parcod_unidad);

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
        public DataTable Buscar(DUnidad Unidad)
        {
            DataTable DtRpta = new DataTable("TbUnidad");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "unidad_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(Unidad);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(Unidad);
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
        public DataTable RepBuscar(DUnidad Unidad)
        {
            DataTable DtRpta = new DataTable("TbUnidad");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "unidad_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(Unidad);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(Unidad);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(Unidad);
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
                    CommandText = "unidad_primero",
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
                    CommandText = "unidad_ultimo",
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
        /// <param name="Listar Anterior Unidad"></param>
        public DataSet Anterior(DUnidad Unidad)
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
                    CommandText = "unidad_anterior",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_unidad = Getcod_unidad(Unidad);
                Cmd.Parameters.Add(Parcod_unidad);

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
        /// <param name="Listar Siguiente Unidad"></param>
        public DataSet Siguiente(DUnidad Unidad)
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
                    CommandText = "unidad_siguiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_unidad = Getcod_unidad(Unidad);
                Cmd.Parameters.Add(Parcod_unidad);

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
        public string GenerarCod(DUnidad Unidad)
        {
            SqlConnection SqlConn = new SqlConnection
            {
                ConnectionString = DConexion.Cn
            };

            SqlConn.Open();
            SqlCommand Cmd = new SqlCommand
            {
                Connection = SqlConn,
                CommandText = "unidad_generar_cod",
                CommandType = CommandType.StoredProcedure,
            };

            try
            {
                SqlParameter ParCod_unidad = new SqlParameter("@cod_unidad", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                    Value = Unidad.Dcod_unidad
                };
                Cmd.Parameters.Add(ParCod_unidad);

                if (Cmd.ExecuteNonQuery() == 0)
                {
                    return Cmd.Parameters[ParCod_unidad.ToString()].Value.ToString();
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
            return Cmd.Parameters["@cod_unidad"].Value.ToString();
        }
    }
}
