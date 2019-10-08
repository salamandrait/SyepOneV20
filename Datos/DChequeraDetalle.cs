using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DChequeraDetalle
    {
        #region PARAMETROS
        public Object Dcod_chequera { get; set; }
        public Object Dcod_cuenta { get; set; }
        public Object Drengchequera { get; set; }
        public Object Dnumcheque { get; set; }
        public Object Destatus { get; set; }
        public Object Dfechaemision { get; set; }
        public Object Dmonto { get; set; }
        public Object Ddescripcion { get; set; }
        public Object Dbuscar { get; set; }
        public Object Dbuscard { get; set; }
        public Object Dbuscarh { get; set; }
        public Object Dbtipo { get; set; }


        private static SqlParameter Getcod_chequera(DChequeraDetalle ChequeraDetalle)
        {
            SqlParameter Pcod_chequera = new SqlParameter
            {
                ParameterName = "@cod_chequera",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = ChequeraDetalle.Dcod_chequera,
            };
            return Pcod_chequera;
        }

        private static SqlParameter Getcod_cuenta(DChequeraDetalle ChequeraDetalle)
        {
            SqlParameter Pcod_cuenta = new SqlParameter
            {
                ParameterName = "@cod_cuenta",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = ChequeraDetalle.Dcod_cuenta,
            };
            return Pcod_cuenta;
        }

        private static SqlParameter Getrengchequera(DChequeraDetalle ChequeraDetalle)
        {
            SqlParameter Prengchequera = new SqlParameter
            {
                ParameterName = "@rengchequera",
                SqlDbType = SqlDbType.Int,
                Value = ChequeraDetalle.Drengchequera,
            };
            return Prengchequera;
        }

        private static SqlParameter Getnumcheque(DChequeraDetalle ChequeraDetalle)
        {
            SqlParameter Pnumcheque = new SqlParameter
            {
                ParameterName = "@numcheque",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = ChequeraDetalle.Dnumcheque,
            };
            return Pnumcheque;
        }

        private static SqlParameter Getestatus(DChequeraDetalle ChequeraDetalle)
        {
            SqlParameter Pestatus = new SqlParameter
            {
                ParameterName = "@estatus",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = ChequeraDetalle.Destatus,
            };
            return Pestatus;
        }

        private static SqlParameter Getfechaemision(DChequeraDetalle ChequeraDetalle)
        {
            SqlParameter Pfechaemision = new SqlParameter
            {
                ParameterName = "@fechaemision",
                SqlDbType = SqlDbType.DateTime,
                Value = ChequeraDetalle.Dfechaemision,
            };
            return Pfechaemision;
        }

        private static SqlParameter Getmonto(DChequeraDetalle ChequeraDetalle)
        {
            SqlParameter Pmonto = new SqlParameter
            {
                ParameterName = "@monto",
                SqlDbType = SqlDbType.Money,
                Value = ChequeraDetalle.Dmonto,
            };
            return Pmonto;
        }

        private static SqlParameter Getdescripcion(DChequeraDetalle ChequeraDetalle)
        {
            SqlParameter Pdescripcion = new SqlParameter
            {
                ParameterName = "@descripcion",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = ChequeraDetalle.Ddescripcion,
            };
            return Pdescripcion;
        }

        private static SqlParameter Getbuscar(DChequeraDetalle ChequeraDetalle)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = ChequeraDetalle.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DChequeraDetalle ChequeraDetalle)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = ChequeraDetalle.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DChequeraDetalle ChequeraDetalle)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = ChequeraDetalle.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DChequeraDetalle ChequeraDetalle)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = ChequeraDetalle.Dbtipo,
            };
            return Pbtipo;
        }

        #endregion

        public DChequeraDetalle()
        {
            /// Constructor Vacio
        }

        /// <summary>
        /// Tabla Mostrar No Recibe parametros
        /// </summary>
        /// <returns> 0 Parametros</returns>
        public DataTable Seleccionar(DChequeraDetalle ChequeraDetalle)
        {
            DataTable DtRpta = new DataTable("TbChequeraDetalle");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "chequeradetalle_seleccionar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_chequera = Getcod_chequera(ChequeraDetalle);
                Cmd.Parameters.Add(Parcod_chequera);

                SqlParameter Parcod_cuenta = Getcod_cuenta(ChequeraDetalle);
                Cmd.Parameters.Add(Parcod_cuenta);

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
        /// Tabla Mostrar No Recibe parametros
        /// </summary>
        /// <returns> 0 Parametros</returns>
        public DataTable MostrarCh(DChequeraDetalle ChequeraDetalle)
        {
            DataTable DtRpta = new DataTable("TbChequeraDetalle");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "chequeradetalle_mostrar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_chequera = Getcod_chequera(ChequeraDetalle);
                Cmd.Parameters.Add(Parcod_chequera);

                SqlParameter Parcod_cuenta = Getcod_cuenta(ChequeraDetalle);
                Cmd.Parameters.Add(Parcod_cuenta);

                SqlParameter Parestatus = Getestatus(ChequeraDetalle);
                Cmd.Parameters.Add(Parestatus);

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
        /// Tabla Mostrar No Recibe parametros
        /// </summary>
        /// <returns> 0 Parametros</returns>
        public DataTable MostrarSelect(DChequeraDetalle ChequeraDetalle)
        {
            DataTable DtRpta = new DataTable("TbChequeraDetalle");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "chequeradetalle_mostrar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_chequera = Getcod_chequera(ChequeraDetalle);
                Cmd.Parameters.Add(Parcod_chequera);

                SqlParameter Parcod_cuenta = Getcod_cuenta(ChequeraDetalle);
                Cmd.Parameters.Add(Parcod_cuenta);

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
        /// Tabla Mostrar No Recibe parametros
        /// </summary>
        /// <returns> 0 Parametros</returns>
        public DataTable Mostrar()
        {
            DataTable DtRpta = new DataTable("TbChequeraDetalle");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "chequeradetalle_mostrarselect",
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
                    CommandText = "chequeradetalle_listar",
                    CommandType = CommandType.StoredProcedure,
                };

                Cmd.ExecuteNonQuery();
                SqlDataAdapter Dat = new SqlDataAdapter(Cmd);
                Dat.Fill(DsRpta, "TbChequeraDetalle");

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
        public string Insertar(DChequeraDetalle ChequeraDetalle)
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
                    CommandText = "chequeradetalle_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_chequera = Getcod_chequera(ChequeraDetalle);
                Cmd.Parameters.Add(Parcod_chequera);

                SqlParameter Parrengchequera = Getrengchequera(ChequeraDetalle);
                Cmd.Parameters.Add(Parrengchequera);

                SqlParameter Parnumcheque = Getnumcheque(ChequeraDetalle);
                Cmd.Parameters.Add(Parnumcheque);

                SqlParameter Parestatus = Getestatus(ChequeraDetalle);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Parmonto = Getmonto(ChequeraDetalle);
                Cmd.Parameters.Add(Parmonto);

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
        public string Editar(DChequeraDetalle ChequeraDetalle)
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
                    CommandText = "chequeradetalle_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_chequera = Getcod_chequera(ChequeraDetalle);
                Cmd.Parameters.Add(Parcod_chequera);

                SqlParameter Parrengchequera = Getrengchequera(ChequeraDetalle);
                Cmd.Parameters.Add(Parrengchequera);

                SqlParameter Parnumcheque = Getnumcheque(ChequeraDetalle);
                Cmd.Parameters.Add(Parnumcheque);

                SqlParameter Parestatus = Getestatus(ChequeraDetalle);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Parfechaemision = Getfechaemision(ChequeraDetalle);
                Cmd.Parameters.Add(Parfechaemision);

                SqlParameter Parmonto = Getmonto(ChequeraDetalle);
                Cmd.Parameters.Add(Parmonto);

                SqlParameter Pardescripcion = Getdescripcion(ChequeraDetalle);
                Cmd.Parameters.Add(Pardescripcion);

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
        public string Eliminar(DChequeraDetalle ChequeraDetalle)
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
                    CommandText = "chequeradetalle_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_chequera = Getcod_chequera(ChequeraDetalle);
                Cmd.Parameters.Add(Parcod_chequera);

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
        /// Metodo Eliminar Datos Recibe 1 Parametro
        /// </summary>
        /// <returns> 1 Parametro</returns>
        public string EstatusCheque(DChequeraDetalle ChequeraDetalle)
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
                    CommandText = "chequeradetalle_estatus",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parnumcheque = Getnumcheque(ChequeraDetalle);
                Cmd.Parameters.Add(Parnumcheque);

                SqlParameter Parestatus = Getestatus(ChequeraDetalle);
                Cmd.Parameters.Add(Parestatus);

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
        public DataTable Buscar(DChequeraDetalle ChequeraDetalle)
        {
            DataTable DtRpta = new DataTable("TbChequeraDetalle");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "chequeradetalle_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(ChequeraDetalle);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(ChequeraDetalle);
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
        public DataTable RepBuscar(DChequeraDetalle ChequeraDetalle)
        {
            DataTable DtRpta = new DataTable("TbChequeraDetalle");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "chequeradetalle_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(ChequeraDetalle);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(ChequeraDetalle);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(ChequeraDetalle);
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
                    CommandText = "chequeradetalle_primero",
                    CommandType = CommandType.StoredProcedure,
                };

                Cmd.ExecuteNonQuery();
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DsRpta, "TbChequeraDetalle");

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
                    CommandText = "chequeradetalle_ultimo",
                    CommandType = CommandType.StoredProcedure,
                };

                Cmd.ExecuteNonQuery();
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DsRpta, "TbChequeraDetalle");

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
        /// <param name="Listar Anterior ChequeraDetalle"></param>
        public DataSet Anterior(DChequeraDetalle ChequeraDetalle)
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
                    CommandText = "chequeradetalle_anterior",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_chequera = Getcod_chequera(ChequeraDetalle);
                Cmd.Parameters.Add(Parcod_chequera);

                Cmd.ExecuteNonQuery();
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DsRpta, "TbChequeraDetalle");

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
        /// <param name="Listar Siguiente ChequeraDetalle"></param>
        public DataSet Siguiente(DChequeraDetalle ChequeraDetalle)
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
                    CommandText = "chequeradetalle_siguiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_chequera = Getcod_chequera(ChequeraDetalle);
                Cmd.Parameters.Add(Parcod_chequera);

                Cmd.ExecuteNonQuery();
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DsRpta, "TbChequeraDetalle");

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
        public string GenerarCod(DChequeraDetalle ChequeraDetalle)
        {
            SqlConnection SqlConn = new SqlConnection
            {
                ConnectionString = DConexion.Cn
            };

            SqlConn.Open();
            SqlCommand Cmd = new SqlCommand
            {
                Connection = SqlConn,
                CommandText = "chequeradetalle_generar_cod",
                CommandType = CommandType.StoredProcedure,
            };

            try
            {
                SqlParameter ParCod_chequeradetalle = new SqlParameter("@cod_chequera", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                    Value = ChequeraDetalle.Dcod_chequera
                };
                Cmd.Parameters.Add(ParCod_chequeradetalle);

                if (Cmd.ExecuteNonQuery() == 0)
                {
                    return Cmd.Parameters[ParCod_chequeradetalle.ToString()].Value.ToString();
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
            return Cmd.Parameters["@cod_chequera"].Value.ToString();
        }
    }
}

