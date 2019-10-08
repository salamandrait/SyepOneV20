using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DImpuesto
    {
        #region PARAMETROS
        public Object Dcod_impuesto { get; set; }
        public Object Ddesc_impuesto { get; set; }
        public Object Dcompras { get; set; }
        public Object Dventas { get; set; }
        public Object Dtasaimp { get; set; }
        public Object Dfecha_reg { get; set; }
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


        private static SqlParameter Getcod_impuesto(DImpuesto Impuesto)
        {
            SqlParameter Pcod_impuesto = new SqlParameter
            {
                ParameterName = "@cod_impuesto",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Impuesto.Dcod_impuesto,
            };
            return Pcod_impuesto;
        }

        private static SqlParameter Getdesc_impuesto(DImpuesto Impuesto)
        {
            SqlParameter Pdesc_impuesto = new SqlParameter
            {
                ParameterName = "@desc_impuesto",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Value = Impuesto.Ddesc_impuesto,
            };
            return Pdesc_impuesto;
        }

        private static SqlParameter Getcompras(DImpuesto Impuesto)
        {
            SqlParameter Pcompras = new SqlParameter
            {
                ParameterName = "@compras",
                SqlDbType = SqlDbType.Bit,
                Value = Impuesto.Dcompras,
            };
            return Pcompras;
        }

        private static SqlParameter Getventas(DImpuesto Impuesto)
        {
            SqlParameter Pventas = new SqlParameter
            {
                ParameterName = "@ventas",
                SqlDbType = SqlDbType.Bit,
                Value = Impuesto.Dventas,
            };
            return Pventas;
        }

        private static SqlParameter Gettasaimp(DImpuesto Impuesto)
        {
            SqlParameter Ptasaimp = new SqlParameter
            {
                ParameterName = "@tasaimp",
                SqlDbType = SqlDbType.Decimal,
                Precision = 10,
                Scale = 3,
                Value = Impuesto.Dtasaimp,
            };
            return Ptasaimp;
        }

        private static SqlParameter Getfecha_reg(DImpuesto Impuesto)
        {
            SqlParameter Pfecha_reg = new SqlParameter
            {
                ParameterName = "@fecha_reg",
                SqlDbType = SqlDbType.DateTime,
                Value = Impuesto.Dfecha_reg,
            };
            return Pfecha_reg;
        }

        private static SqlParameter Getcampo1(DImpuesto Impuesto)
        {
            SqlParameter Pcampo1 = new SqlParameter
            {
                ParameterName = "@campo1",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Impuesto.Dcampo1,
            };
            return Pcampo1;
        }

        private static SqlParameter Getcampo2(DImpuesto Impuesto)
        {
            SqlParameter Pcampo2 = new SqlParameter
            {
                ParameterName = "@campo2",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Impuesto.Dcampo2,
            };
            return Pcampo2;
        }

        private static SqlParameter Getcampo3(DImpuesto Impuesto)
        {
            SqlParameter Pcampo3 = new SqlParameter
            {
                ParameterName = "@campo3",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Impuesto.Dcampo3,
            };
            return Pcampo3;
        }

        private static SqlParameter Getcampo4(DImpuesto Impuesto)
        {
            SqlParameter Pcampo4 = new SqlParameter
            {
                ParameterName = "@campo4",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Impuesto.Dcampo4,
            };
            return Pcampo4;
        }

        private static SqlParameter Getcampo5(DImpuesto Impuesto)
        {
            SqlParameter Pcampo5 = new SqlParameter
            {
                ParameterName = "@campo5",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Impuesto.Dcampo5,
            };
            return Pcampo5;
        }

        private static SqlParameter Getcampo6(DImpuesto Impuesto)
        {
            SqlParameter Pcampo6 = new SqlParameter
            {
                ParameterName = "@campo6",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Impuesto.Dcampo6,
            };
            return Pcampo6;
        }

        private static SqlParameter Getbuscar(DImpuesto Impuesto)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Impuesto.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DImpuesto Impuesto)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Impuesto.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DImpuesto Impuesto)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Impuesto.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DImpuesto Impuesto)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Impuesto.Dbtipo,
            };
            return Pbtipo;
        }

        #endregion

        public DImpuesto()
        {
            /// Constructor Vacio
        }


        /// <summary>
        /// Tabla Mostrar No Recibe parametros
        /// </summary>
        /// <returns> 0 Parametros</returns>
        public DataTable Mostrar()
        {
            DataTable DtRpta = new DataTable("TbImpuesto");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "impuesto_mostrar",
                    CommandType = CommandType.StoredProcedure,
                };

                Cmd.ExecuteNonQuery();
                SqlDataAdapter Dat = new SqlDataAdapter(Cmd);
                Dat.Fill(DtRpta);

            }
            catch (Exception Exc)
            {

                DtRpta = null;
                throw new Exception("Error al Ejecutar el procedimiento almacenado" + Exc.Message);
  
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
        /// Tabla Listar No Recibe parametros
        /// </summary>
        /// <returns> 0 Parametros</returns>
        public DataSet Listar()
        {
            DataSet DsRpta = new DataSet();
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand()
                {
                    Connection = SqlConn,
                    CommandText = "impuesto_listar",
                    CommandType = CommandType.StoredProcedure,
                };

                Cmd.ExecuteNonQuery();
                SqlDataAdapter Dat = new SqlDataAdapter(Cmd);
                Dat.Fill(DsRpta, "TbImpuesto");

            }
            catch (Exception Exc)
            {
                DsRpta = null;
                throw new Exception("Error al Ejecutar el procedimiento almacenado" + Exc.Message);
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
        /// Tabla Listar No Recibe parametros
        /// </summary>
        /// <returns> 0 Parametros</returns>
        public DataSet ListarTasa(DImpuesto Impuesto)
        {
            DataSet DsRpta = new DataSet();
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand()
                {
                    Connection = SqlConn,
                    CommandText = "impuesto_listar_art",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Pardesc_impuesto = Getdesc_impuesto(Impuesto);
                Cmd.Parameters.Add(Pardesc_impuesto);

                Cmd.ExecuteNonQuery();
                SqlDataAdapter Dat = new SqlDataAdapter(Cmd);
                Dat.Fill(DsRpta, "TbImpuesto");

            }
            catch (Exception Exc)
            {
                DsRpta = null;
                throw new Exception("Error al Ejecutar el procedimiento almacenado" + Exc.Message);
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
        /// <returns> 8 Parametros</returns>
        public string Insertar(DImpuesto Impuesto)
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
                    CommandText = "impuesto_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_impuesto = Getcod_impuesto(Impuesto);
                Cmd.Parameters.Add(Parcod_impuesto);

                SqlParameter Pardesc_impuesto = Getdesc_impuesto(Impuesto);
                Cmd.Parameters.Add(Pardesc_impuesto);

                SqlParameter Parcompras = Getcompras(Impuesto);
                Cmd.Parameters.Add(Parcompras);

                SqlParameter Parventas = Getventas(Impuesto);
                Cmd.Parameters.Add(Parventas);

                SqlParameter Partasaimp = Gettasaimp(Impuesto);
                Cmd.Parameters.Add(Partasaimp);

                SqlParameter Parfecha_reg = Getfecha_reg(Impuesto);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parcampo1 = Getcampo1(Impuesto);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Impuesto);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Impuesto);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Impuesto);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Impuesto);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Impuesto);
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
        /// Metodo Editar Datos Recibe 8 Parametros
        /// </summary>
        /// <returns> 8 Parametros</returns>
        public string Editar(DImpuesto Impuesto)
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
                    CommandText = "impuesto_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_impuesto = Getcod_impuesto(Impuesto);
                Cmd.Parameters.Add(Parcod_impuesto);

                SqlParameter Parcompras = Getcompras(Impuesto);
                Cmd.Parameters.Add(Parcompras);

                SqlParameter Parventas = Getventas(Impuesto);
                Cmd.Parameters.Add(Parventas);

                SqlParameter Partasaimp = Gettasaimp(Impuesto);
                Cmd.Parameters.Add(Partasaimp);

                SqlParameter Parfecha_reg = Getfecha_reg(Impuesto);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parcampo1 = Getcampo1(Impuesto);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Impuesto);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Impuesto);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Impuesto);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Impuesto);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Impuesto);
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
        /// <returns> 1 Parametro</returns>
        public string Eliminar(DImpuesto Impuesto)
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
                    CommandText = "impuesto_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_impuesto = Getcod_impuesto(Impuesto);
                Cmd.Parameters.Add(Parcod_impuesto);

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
                    Rpta = "No se pueden Eliminar Registros Relacionados   " + Exc.Message;
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
        public DataTable Buscar(DImpuesto Impuesto)
        {
            DataTable DtRpta = new DataTable("TbImpuesto");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "impuesto_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(Impuesto);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(Impuesto);
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
        public DataTable RepBuscar(DImpuesto Impuesto)
        {
            DataTable DtRpta = new DataTable("TbImpuesto");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "impuesto_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(Impuesto);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(Impuesto);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(Impuesto);
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
                    CommandText = "impuesto_primero",
                    CommandType = CommandType.StoredProcedure,
                };

                Cmd.ExecuteNonQuery();
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DsRpta, "TbImpuesto");

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
                    CommandText = "impuesto_ultimo",
                    CommandType = CommandType.StoredProcedure,
                };

                Cmd.ExecuteNonQuery();
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DsRpta, "TbImpuesto");

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
        /// <param name="Listar Anterior Impuesto"></param>
        public DataSet Anterior(DImpuesto Impuesto)
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
                    CommandText = "impuesto_anterior",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_impuesto = Getcod_impuesto(Impuesto);
                Cmd.Parameters.Add(Parcod_impuesto);

                Cmd.ExecuteNonQuery();
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DsRpta, "TbImpuesto");

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
        /// <param name="Listar Siguiente Impuesto"></param>
        public DataSet Siguiente(DImpuesto Impuesto)
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
                    CommandText = "impuesto_siguiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_impuesto = Getcod_impuesto(Impuesto);
                Cmd.Parameters.Add(Parcod_impuesto);

                Cmd.ExecuteNonQuery();
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DsRpta, "TbImpuesto");

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
        public string GenerarCod(DImpuesto Impuesto)
        {
            SqlConnection SqlConn = new SqlConnection
            {
                ConnectionString = DConexion.Cn
            };

            SqlConn.Open();
            SqlCommand Cmd = new SqlCommand
            {
                Connection = SqlConn,
                CommandText = "impuesto_generar_cod",
                CommandType = CommandType.StoredProcedure,
            };

            try
            {
                SqlParameter ParCod_impuesto = new SqlParameter("@cod_impuesto", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                    Value = Impuesto.Dcod_impuesto
                };
                Cmd.Parameters.Add(ParCod_impuesto);

                if (Cmd.ExecuteNonQuery() == 0)
                {
                    return Cmd.Parameters[ParCod_impuesto.ToString()].Value.ToString();
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
            return Cmd.Parameters["@cod_impuesto"].Value.ToString();
        }
    }
}

