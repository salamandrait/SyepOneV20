using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DSubLinea
    {

        #region PARAMETROS
        public Object Dcod_sublinea { get; set; }
        public Object Dcod_linea { get; set; }
        public Object Dcod_sublineav { get; set; }
        public Object Ddesc_sublinea { get; set; }
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


        private static SqlParameter Getcod_sublinea(DSubLinea SubLinea)
        {
            SqlParameter Pcod_sublinea = new SqlParameter
            {
                ParameterName = "@cod_sublinea",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = SubLinea.Dcod_sublinea,
            };
            return Pcod_sublinea;
        }

        private static SqlParameter Getcod_linea(DSubLinea SubLinea)
        {
            SqlParameter Pcod_linea = new SqlParameter
            {
                ParameterName = "@cod_linea",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = SubLinea.Dcod_linea,
            };
            return Pcod_linea;
        }

        private static SqlParameter Getcod_sublineav(DSubLinea SubLinea)
        {
            SqlParameter Pcod_sublineav = new SqlParameter
            {
                ParameterName = "@cod_sublineav",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = SubLinea.Dcod_sublineav,
            };
            return Pcod_sublineav;
        }

        private static SqlParameter Getdesc_sublinea(DSubLinea SubLinea)
        {
            SqlParameter Pdesc_sublinea = new SqlParameter
            {
                ParameterName = "@desc_sublinea",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Value = SubLinea.Ddesc_sublinea,
            };
            return Pdesc_sublinea;
        }

        private static SqlParameter Getcampo1(DSubLinea SubLinea)
        {
            SqlParameter Pcampo1 = new SqlParameter
            {
                ParameterName = "@campo1",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = SubLinea.Dcampo1,
            };
            return Pcampo1;
        }

        private static SqlParameter Getcampo2(DSubLinea SubLinea)
        {
            SqlParameter Pcampo2 = new SqlParameter
            {
                ParameterName = "@campo2",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = SubLinea.Dcampo2,
            };
            return Pcampo2;
        }

        private static SqlParameter Getcampo3(DSubLinea SubLinea)
        {
            SqlParameter Pcampo3 = new SqlParameter
            {
                ParameterName = "@campo3",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = SubLinea.Dcampo3,
            };
            return Pcampo3;
        }

        private static SqlParameter Getcampo4(DSubLinea SubLinea)
        {
            SqlParameter Pcampo4 = new SqlParameter
            {
                ParameterName = "@campo4",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = SubLinea.Dcampo4,
            };
            return Pcampo4;
        }

        private static SqlParameter Getcampo5(DSubLinea SubLinea)
        {
            SqlParameter Pcampo5 = new SqlParameter
            {
                ParameterName = "@campo5",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = SubLinea.Dcampo5,
            };
            return Pcampo5;
        }

        private static SqlParameter Getcampo6(DSubLinea SubLinea)
        {
            SqlParameter Pcampo6 = new SqlParameter
            {
                ParameterName = "@campo6",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = SubLinea.Dcampo6,
            };
            return Pcampo6;
        }

        private static SqlParameter Getbuscar(DSubLinea SubLinea)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = SubLinea.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DSubLinea SubLinea)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = SubLinea.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DSubLinea SubLinea)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = SubLinea.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DSubLinea SubLinea)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = SubLinea.Dbtipo,
            };
            return Pbtipo;
        }

        #endregion

        public DSubLinea()
        {
            /// Constructor Vacio
        }


        /// <summary>
        /// Tabla Mostrar No Recibe parametros y Muestra un DataTable
        /// </summary>
        /// <returns> No Recibe Parametros</returns>
        public DataTable Mostrar()
        {
            DataTable DtRpta = new DataTable("TbSubLinea");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "sublinea_mostrar",
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

        public DataTable MostrarOpc(DSubLinea SubLinea)
        {
            DataTable DtRpta = new DataTable("TbSubLinea");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "sublinea_mostrar_opc",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_linea = Getcod_linea(SubLinea);
                Cmd.Parameters.Add(Parcod_linea);

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
                    CommandText = "sublinea_listar",
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
        public string Insertar(DSubLinea SubLinea)
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
                    CommandText = "sublinea_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_sublinea = Getcod_sublinea(SubLinea);
                Cmd.Parameters.Add(Parcod_sublinea);

                SqlParameter Parcod_linea = Getcod_linea(SubLinea);
                Cmd.Parameters.Add(Parcod_linea);

                SqlParameter Pardesc_sublinea = Getdesc_sublinea(SubLinea);
                Cmd.Parameters.Add(Pardesc_sublinea);

                SqlParameter Parcampo1 = Getcampo1(SubLinea);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(SubLinea);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(SubLinea);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(SubLinea);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(SubLinea);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(SubLinea);
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
        public string Editar(DSubLinea SubLinea)
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
                    CommandText = "sublinea_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_sublinea = Getcod_sublinea(SubLinea);
                Cmd.Parameters.Add(Parcod_sublinea);

                SqlParameter Parcod_linea = Getcod_linea(SubLinea);
                Cmd.Parameters.Add(Parcod_linea);

                SqlParameter Parcod_sublineav = Getcod_sublineav(SubLinea);
                Cmd.Parameters.Add(Parcod_sublineav);

                SqlParameter Pardesc_sublinea = Getdesc_sublinea(SubLinea);
                Cmd.Parameters.Add(Pardesc_sublinea);

                SqlParameter Parcampo1 = Getcampo1(SubLinea);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(SubLinea);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(SubLinea);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(SubLinea);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(SubLinea);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(SubLinea);
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
        public string Eliminar(DSubLinea SubLinea)
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
                    CommandText = "sublinea_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_sublinea = Getcod_sublinea(SubLinea);
                Cmd.Parameters.Add(Parcod_sublinea);

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
        public DataTable Buscar(DSubLinea SubLinea)
        {
            DataTable DtRpta = new DataTable("TbSubLinea");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "sublinea_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(SubLinea);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(SubLinea);
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
        public DataTable RepBuscar(DSubLinea SubLinea)
        {
            DataTable DtRpta = new DataTable("TbSubLinea");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "sublinea_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(SubLinea);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(SubLinea);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(SubLinea);
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
                    CommandText = "sublinea_primero",
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
                    CommandText = "sublinea_ultimo",
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
        /// <param name="Listar Anterior SubLinea"></param>
        public DataSet Anterior(DSubLinea SubLinea)
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
                    CommandText = "sublinea_anterior",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_sublinea = Getcod_sublinea(SubLinea);
                Cmd.Parameters.Add(Parcod_sublinea);

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
        /// <param name="Listar Siguiente SubLinea"></param>
        public DataSet Siguiente(DSubLinea SubLinea)
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
                    CommandText = "sublinea_siguiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_sublinea = Getcod_sublinea(SubLinea);
                Cmd.Parameters.Add(Parcod_sublinea);

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
        public string GenerarCod(DSubLinea SubLinea)
        {
            SqlConnection SqlConn = new SqlConnection
            {
                ConnectionString = DConexion.Cn
            };

            SqlConn.Open();
            SqlCommand Cmd = new SqlCommand
            {
                Connection = SqlConn,
                CommandText = "sublinea_generar_cod",
                CommandType = CommandType.StoredProcedure,
            };

            try
            {
                SqlParameter ParCod_sublinea = new SqlParameter("@cod_sublinea", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                    Value = SubLinea.Dcod_sublinea
                };
                Cmd.Parameters.Add(ParCod_sublinea);

                if (Cmd.ExecuteNonQuery() == 0)
                {
                    return Cmd.Parameters[ParCod_sublinea.ToString()].Value.ToString();
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
            return Cmd.Parameters["@cod_sublinea"].Value.ToString();
        }
    }
}
