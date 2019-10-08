using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DSegmento
    {

        #region PARAMETROS
        public Object Dcod_segmento { get; set; }
        public Object Dcod_segmentov { get; set; }
        public Object Ddesc_segmento { get; set; }
        public Object Dtiposeg { get; set; }
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


        private static SqlParameter Getcod_segmento(DSegmento Segmento)
        {
            SqlParameter Pcod_segmento = new SqlParameter
            {
                ParameterName = "@cod_segmento",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Segmento.Dcod_segmento,
            };
            return Pcod_segmento;
        }

        private static SqlParameter Getcod_segmentov(DSegmento Segmento)
        {
            SqlParameter Pcod_segmentov = new SqlParameter
            {
                ParameterName = "@cod_segmentov",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Segmento.Dcod_segmentov,
            };
            return Pcod_segmentov;
        }

        private static SqlParameter Getdesc_segmento(DSegmento Segmento)
        {
            SqlParameter Pdesc_segmento = new SqlParameter
            {
                ParameterName = "@desc_segmento",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Value = Segmento.Ddesc_segmento,
            };
            return Pdesc_segmento;
        }

        private static SqlParameter Gettiposeg(DSegmento Segmento)
        {
            SqlParameter Ptiposeg = new SqlParameter
            {
                ParameterName = "@tiposeg",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Segmento.Dtiposeg,
            };
            return Ptiposeg;
        }

        private static SqlParameter Getcampo1(DSegmento Segmento)
        {
            SqlParameter Pcampo1 = new SqlParameter
            {
                ParameterName = "@campo1",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Segmento.Dcampo1,
            };
            return Pcampo1;
        }

        private static SqlParameter Getcampo2(DSegmento Segmento)
        {
            SqlParameter Pcampo2 = new SqlParameter
            {
                ParameterName = "@campo2",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Segmento.Dcampo2,
            };
            return Pcampo2;
        }

        private static SqlParameter Getcampo3(DSegmento Segmento)
        {
            SqlParameter Pcampo3 = new SqlParameter
            {
                ParameterName = "@campo3",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Segmento.Dcampo3,
            };
            return Pcampo3;
        }

        private static SqlParameter Getcampo4(DSegmento Segmento)
        {
            SqlParameter Pcampo4 = new SqlParameter
            {
                ParameterName = "@campo4",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Segmento.Dcampo4,
            };
            return Pcampo4;
        }

        private static SqlParameter Getcampo5(DSegmento Segmento)
        {
            SqlParameter Pcampo5 = new SqlParameter
            {
                ParameterName = "@campo5",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Segmento.Dcampo5,
            };
            return Pcampo5;
        }

        private static SqlParameter Getcampo6(DSegmento Segmento)
        {
            SqlParameter Pcampo6 = new SqlParameter
            {
                ParameterName = "@campo6",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Segmento.Dcampo6,
            };
            return Pcampo6;
        }

        private static SqlParameter Getbuscar(DSegmento Segmento)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Segmento.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DSegmento Segmento)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Segmento.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DSegmento Segmento)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Segmento.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DSegmento Segmento)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Segmento.Dbtipo,
            };
            return Pbtipo;
        }

        #endregion

        public DSegmento()
        {
            /// Constructor Vacio
        }


        /// <summary>
        /// Tabla Mostrar No Recibe parametros y Muestra un DataTable
        /// </summary>
        /// <returns> No Recibe Parametros</returns>
        public DataTable Mostrar(DSegmento Segmento)
        {
            DataTable DtRpta = new DataTable("TbSegmento");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "segmento_mostrar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Partiposeg = Gettiposeg(Segmento);
                Cmd.Parameters.Add(Partiposeg);

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
        public DataSet Listar(DSegmento Segmento)
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
                    CommandText = "segmento_listar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Partiposeg = Gettiposeg(Segmento);
                Cmd.Parameters.Add(Partiposeg);

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
        public string Insertar(DSegmento Segmento)
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
                    CommandText = "segmento_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_segmento = Getcod_segmento(Segmento);
                Cmd.Parameters.Add(Parcod_segmento);

                SqlParameter Pardesc_segmento = Getdesc_segmento(Segmento);
                Cmd.Parameters.Add(Pardesc_segmento);

                SqlParameter Partiposeg = Gettiposeg(Segmento);
                Cmd.Parameters.Add(Partiposeg);

                SqlParameter Parcampo1 = Getcampo1(Segmento);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Segmento);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Segmento);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Segmento);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Segmento);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Segmento);
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
        public string Editar(DSegmento Segmento)
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
                    CommandText = "segmento_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_segmento = Getcod_segmento(Segmento);
                Cmd.Parameters.Add(Parcod_segmento);

                SqlParameter Parcod_segmentov = Getcod_segmentov(Segmento);
                Cmd.Parameters.Add(Parcod_segmentov);

                SqlParameter Pardesc_segmento = Getdesc_segmento(Segmento);
                Cmd.Parameters.Add(Pardesc_segmento);

                SqlParameter Partiposeg = Gettiposeg(Segmento);
                Cmd.Parameters.Add(Partiposeg);

                SqlParameter Parcampo1 = Getcampo1(Segmento);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Segmento);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Segmento);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Segmento);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Segmento);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Segmento);
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
        public string Eliminar(DSegmento Segmento)
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
                    CommandText = "segmento_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_segmento = Getcod_segmento(Segmento);
                Cmd.Parameters.Add(Parcod_segmento);

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
        public DataTable Buscar(DSegmento Segmento)
        {
            DataTable DtRpta = new DataTable("TbSegmento");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "segmento_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(Segmento);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(Segmento);
                Cmd.Parameters.Add(Parbtipo);

                SqlParameter Partiposeg = Gettiposeg(Segmento);
                Cmd.Parameters.Add(Partiposeg);

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
        public DataTable RepBuscar(DSegmento Segmento)
        {
            DataTable DtRpta = new DataTable("TbSegmento");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "segmento_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(Segmento);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(Segmento);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(Segmento);
                Cmd.Parameters.Add(Parbtipo);

                SqlParameter Partiposeg = Gettiposeg(Segmento);
                Cmd.Parameters.Add(Partiposeg);

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
        public DataSet Primero(DSegmento Segmento)
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
                    CommandText = "segmento_primero",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Partiposeg = Gettiposeg(Segmento);
                Cmd.Parameters.Add(Partiposeg);

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
        public DataSet Ultimo(DSegmento Segmento)
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
                    CommandText = "segmento_ultimo",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Partiposeg = Gettiposeg(Segmento);
                Cmd.Parameters.Add(Partiposeg);

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
        /// <param name="Listar Anterior Segmento"></param>
        public DataSet Anterior(DSegmento Segmento)
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
                    CommandText = "segmento_anterior",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_segmento = Getcod_segmento(Segmento);
                Cmd.Parameters.Add(Parcod_segmento);

                SqlParameter Partiposeg = Gettiposeg(Segmento);
                Cmd.Parameters.Add(Partiposeg);

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
        /// <param name="Listar Siguiente Segmento"></param>
        public DataSet Siguiente(DSegmento Segmento)
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
                    CommandText = "segmento_siguiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_segmento = Getcod_segmento(Segmento);
                Cmd.Parameters.Add(Parcod_segmento);

                SqlParameter Partiposeg = Gettiposeg(Segmento);
                Cmd.Parameters.Add(Partiposeg);

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
        public string GenerarCod(DSegmento Segmento)
        {
            SqlConnection SqlConn = new SqlConnection
            {
                ConnectionString = DConexion.Cn
            };

            SqlConn.Open();
            SqlCommand Cmd = new SqlCommand
            {
                Connection = SqlConn,
                CommandText = "segmento_generar_cod",
                CommandType = CommandType.StoredProcedure,
            };

            try
            {
                SqlParameter ParCod_segmento = new SqlParameter("@cod_segmento", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                    Value = Segmento.Dcod_segmento
                };
                Cmd.Parameters.Add(ParCod_segmento);

                if (Cmd.ExecuteNonQuery() == 0)
                {
                    return Cmd.Parameters[ParCod_segmento.ToString()].Value.ToString();
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
            return Cmd.Parameters["@cod_segmento"].Value.ToString();
        }
    }
}
