using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DTarjeta
    {

        #region PARAMETROS
        public Object Dcod_tarjeta { get; set; }
        public Object Dcod_tarjetav { get; set; }
        public Object Ddesc_tarjeta { get; set; }
        public Object Dcomision { get; set; }
        public Object Drecargo { get; set; }
        public Object Dimpuesto { get; set; }
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


        private static SqlParameter Getcod_tarjeta(DTarjeta Tarjeta)
        {
            SqlParameter Pcod_tarjeta = new SqlParameter
            {
                ParameterName = "@cod_tarjeta",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Tarjeta.Dcod_tarjeta,
            };
            return Pcod_tarjeta;
        }

        private static SqlParameter Getcod_tarjetav(DTarjeta Tarjeta)
        {
            SqlParameter Pcod_tarjetav = new SqlParameter
            {
                ParameterName = "@cod_tarjetav",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Tarjeta.Dcod_tarjetav,
            };
            return Pcod_tarjetav;
        }

        private static SqlParameter Getdesc_tarjeta(DTarjeta Tarjeta)
        {
            SqlParameter Pdesc_tarjeta = new SqlParameter
            {
                ParameterName = "@desc_tarjeta",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Value = Tarjeta.Ddesc_tarjeta,
            };
            return Pdesc_tarjeta;
        }

        private static SqlParameter Getcomision(DTarjeta Tarjeta)
        {
            SqlParameter Pcomision = new SqlParameter
            {
                ParameterName = "@comision",
                SqlDbType = SqlDbType.Money,
                Value = Tarjeta.Dcomision,
            };
            return Pcomision;
        }

        private static SqlParameter Getrecargo(DTarjeta Tarjeta)
        {
            SqlParameter Precargo = new SqlParameter
            {
                ParameterName = "@recargo",
                SqlDbType = SqlDbType.Money,
                Value = Tarjeta.Drecargo,
            };
            return Precargo;
        }

        private static SqlParameter Getimpuesto(DTarjeta Tarjeta)
        {
            SqlParameter Pimpuesto = new SqlParameter
            {
                ParameterName = "@impuesto",
                SqlDbType = SqlDbType.Money,
                Value = Tarjeta.Dimpuesto,
            };
            return Pimpuesto;
        }

        private static SqlParameter Getcampo1(DTarjeta Tarjeta)
        {
            SqlParameter Pcampo1 = new SqlParameter
            {
                ParameterName = "@campo1",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Tarjeta.Dcampo1,
            };
            return Pcampo1;
        }

        private static SqlParameter Getcampo2(DTarjeta Tarjeta)
        {
            SqlParameter Pcampo2 = new SqlParameter
            {
                ParameterName = "@campo2",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Tarjeta.Dcampo2,
            };
            return Pcampo2;
        }

        private static SqlParameter Getcampo3(DTarjeta Tarjeta)
        {
            SqlParameter Pcampo3 = new SqlParameter
            {
                ParameterName = "@campo3",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Tarjeta.Dcampo3,
            };
            return Pcampo3;
        }

        private static SqlParameter Getcampo4(DTarjeta Tarjeta)
        {
            SqlParameter Pcampo4 = new SqlParameter
            {
                ParameterName = "@campo4",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Tarjeta.Dcampo4,
            };
            return Pcampo4;
        }

        private static SqlParameter Getcampo5(DTarjeta Tarjeta)
        {
            SqlParameter Pcampo5 = new SqlParameter
            {
                ParameterName = "@campo5",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Tarjeta.Dcampo5,
            };
            return Pcampo5;
        }

        private static SqlParameter Getcampo6(DTarjeta Tarjeta)
        {
            SqlParameter Pcampo6 = new SqlParameter
            {
                ParameterName = "@campo6",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Tarjeta.Dcampo6,
            };
            return Pcampo6;
        }

        private static SqlParameter Getbuscar(DTarjeta Tarjeta)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Tarjeta.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DTarjeta Tarjeta)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Tarjeta.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DTarjeta Tarjeta)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Tarjeta.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DTarjeta Tarjeta)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Tarjeta.Dbtipo,
            };
            return Pbtipo;
        }

        #endregion

        public DTarjeta()
        {
            /// Constructor Vacio
        }


        /// <summary>
        /// Tabla Mostrar No Recibe parametros y Muestra un DataTable
        /// </summary>
        /// <returns> No Recibe Parametros</returns>
        public DataTable Mostrar()
        {
            DataTable DtRpta = new DataTable("TbTarjeta");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "tarjeta_mostrar",
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
                    CommandText = "tarjeta_listar",
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
        public string Insertar(DTarjeta Tarjeta)
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
                    CommandText = "tarjeta_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_tarjeta = Getcod_tarjeta(Tarjeta);
                Cmd.Parameters.Add(Parcod_tarjeta);

                SqlParameter Pardesc_tarjeta = Getdesc_tarjeta(Tarjeta);
                Cmd.Parameters.Add(Pardesc_tarjeta);

                SqlParameter Parcomision = Getcomision(Tarjeta);
                Cmd.Parameters.Add(Parcomision);

                SqlParameter Parrecargo = Getrecargo(Tarjeta);
                Cmd.Parameters.Add(Parrecargo);

                SqlParameter Parimpuesto = Getimpuesto(Tarjeta);
                Cmd.Parameters.Add(Parimpuesto);

                SqlParameter Parcampo1 = Getcampo1(Tarjeta);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Tarjeta);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Tarjeta);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Tarjeta);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Tarjeta);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Tarjeta);
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
        public string Editar(DTarjeta Tarjeta)
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
                    CommandText = "tarjeta_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_tarjeta = Getcod_tarjeta(Tarjeta);
                Cmd.Parameters.Add(Parcod_tarjeta);

                SqlParameter Parcod_tarjetav = Getcod_tarjetav(Tarjeta);
                Cmd.Parameters.Add(Parcod_tarjetav);

                SqlParameter Pardesc_tarjeta = Getdesc_tarjeta(Tarjeta);
                Cmd.Parameters.Add(Pardesc_tarjeta);

                SqlParameter Parcomision = Getcomision(Tarjeta);
                Cmd.Parameters.Add(Parcomision);

                SqlParameter Parrecargo = Getrecargo(Tarjeta);
                Cmd.Parameters.Add(Parrecargo);

                SqlParameter Parimpuesto = Getimpuesto(Tarjeta);
                Cmd.Parameters.Add(Parimpuesto);

                SqlParameter Parcampo1 = Getcampo1(Tarjeta);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Tarjeta);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Tarjeta);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Tarjeta);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Tarjeta);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Tarjeta);
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
        public string Eliminar(DTarjeta Tarjeta)
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
                    CommandText = "tarjeta_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_tarjeta = Getcod_tarjeta(Tarjeta);
                Cmd.Parameters.Add(Parcod_tarjeta);

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
        public DataTable Buscar(DTarjeta Tarjeta)
        {
            DataTable DtRpta = new DataTable("TbTarjeta");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "tarjeta_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(Tarjeta);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(Tarjeta);
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
        public DataTable RepBuscar(DTarjeta Tarjeta)
        {
            DataTable DtRpta = new DataTable("TbTarjeta");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "tarjeta_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(Tarjeta);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(Tarjeta);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(Tarjeta);
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
                    CommandText = "tarjeta_primero",
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
                    CommandText = "tarjeta_ultimo",
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
        /// <param name="Listar Anterior Tarjeta"></param>
        public DataSet Anterior(DTarjeta Tarjeta)
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
                    CommandText = "tarjeta_anterior",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_tarjeta = Getcod_tarjeta(Tarjeta);
                Cmd.Parameters.Add(Parcod_tarjeta);

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
        /// <param name="Listar Siguiente Tarjeta"></param>
        public DataSet Siguiente(DTarjeta Tarjeta)
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
                    CommandText = "tarjeta_siguiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_tarjeta = Getcod_tarjeta(Tarjeta);
                Cmd.Parameters.Add(Parcod_tarjeta);

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
        public string GenerarCod(DTarjeta Tarjeta)
        {
            SqlConnection SqlConn = new SqlConnection
            {
                ConnectionString = DConexion.Cn
            };

            SqlConn.Open();
            SqlCommand Cmd = new SqlCommand
            {
                Connection = SqlConn,
                CommandText = "tarjeta_generar_cod",
                CommandType = CommandType.StoredProcedure,
            };

            try
            {
                SqlParameter ParCod_tarjeta = new SqlParameter("@cod_tarjeta", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                    Value = Tarjeta.Dcod_tarjeta
                };
                Cmd.Parameters.Add(ParCod_tarjeta);

                if (Cmd.ExecuteNonQuery() == 0)
                {
                    return Cmd.Parameters[ParCod_tarjeta.ToString()].Value.ToString();
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
            return Cmd.Parameters["@cod_tarjeta"].Value.ToString();
        }
    }
}
