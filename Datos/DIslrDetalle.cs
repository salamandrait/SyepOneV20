using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DIslrDetalle
    {

        #region PARAMETROS


        public Object Dreng { get; set; }
        public Object Drengv { get; set; }
        public Object Dcod_islr { get; set; }
        public Object Dconcepto { get; set; }
        public Object Ddesc_concepto { get; set; }
        public Object Dbasep { get; set; }
        public Object Dretencion { get; set; }
        public Object Dsustraendo { get; set; }
        public Object Dbuscar { get; set; }
        public Object Dbuscard { get; set; }
        public Object Dbuscarh { get; set; }
        public Object Dbtipo { get; set; }


        private static SqlParameter Getreng(DIslrDetalle IslrDetalle)
        {
            SqlParameter Preng = new SqlParameter
            {
                ParameterName = "@reng",
                SqlDbType = SqlDbType.Int,
                Value = IslrDetalle.Dreng,
            };
            return Preng;
        }

        private static SqlParameter Getrengv(DIslrDetalle IslrDetalle)
        {
            SqlParameter Prengv = new SqlParameter
            {
                ParameterName = "@rengv",
                SqlDbType = SqlDbType.Int,
                Value = IslrDetalle.Drengv,
            };
            return Prengv;
        }

        private static SqlParameter Getcod_islr(DIslrDetalle IslrDetalle)
        {
            SqlParameter Pcod_islr = new SqlParameter
            {
                ParameterName = "@cod_islr",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = IslrDetalle.Dcod_islr,
            };
            return Pcod_islr;
        }

        private static SqlParameter Getconcepto(DIslrDetalle IslrDetalle)
        {
            SqlParameter Pconcepto = new SqlParameter
            {
                ParameterName = "@concepto",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = IslrDetalle.Dconcepto,
            };
            return Pconcepto;
        }

        private static SqlParameter Getdesc_concepto(DIslrDetalle IslrDetalle)
        {
            SqlParameter Pdesc_concepto = new SqlParameter
            {
                ParameterName = "@desc_concepto",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = IslrDetalle.Ddesc_concepto,
            };
            return Pdesc_concepto;
        }

        private static SqlParameter Getbasep(DIslrDetalle IslrDetalle)
        {
            SqlParameter Pbasep = new SqlParameter
            {
                ParameterName = "@basep",
                SqlDbType = SqlDbType.Decimal,
                Precision = 18,
                Scale = 3,
                Value = IslrDetalle.Dbasep,
            };
            return Pbasep;
        }

        private static SqlParameter Getretencion(DIslrDetalle IslrDetalle)
        {
            SqlParameter Pretencion = new SqlParameter
            {
                ParameterName = "@retencion",
                SqlDbType = SqlDbType.Decimal,
                Precision = 18,
                Scale = 3,
                Value = IslrDetalle.Dretencion,
            };
            return Pretencion;
        }

        private static SqlParameter Getsustraendo(DIslrDetalle IslrDetalle)
        {
            SqlParameter Psustraendo = new SqlParameter
            {
                ParameterName = "@sustraendo",
                SqlDbType = SqlDbType.Decimal,
                Precision = 18,
                Scale = 3,
                Value = IslrDetalle.Dsustraendo,
            };
            return Psustraendo;
        }

        private static SqlParameter Getbuscar(DIslrDetalle IslrDetalle)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = IslrDetalle.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DIslrDetalle IslrDetalle)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = IslrDetalle.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DIslrDetalle IslrDetalle)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = IslrDetalle.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DIslrDetalle IslrDetalle)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = IslrDetalle.Dbtipo,
            };
            return Pbtipo;
        }

        #endregion

        public DIslrDetalle()
        {
            /// Constructor Vacio
        }


        /// <summary>
        /// Tabla Mostrar No Recibe parametros y Muestra un DataTable
        /// </summary>
        /// <returns> No Recibe Parametros</returns>
        public DataTable Mostrar(DIslrDetalle IslrDetalle)
        {
            DataTable DtRpta = new DataTable("TbIslrDetalle");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "islrdetalle_mostrar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_islr = Getcod_islr(IslrDetalle);
                Cmd.Parameters.Add(Parcod_islr);

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
        public DataSet Listar(DIslrDetalle IslrDetalle)
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
                    CommandText = "islr_listar",
                    CommandType = CommandType.StoredProcedure,
                };


                SqlParameter Parcod_islr = Getcod_islr(IslrDetalle);
                Cmd.Parameters.Add(Parcod_islr);

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
        public string Insertar(DIslrDetalle IslrDetalle)
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
                    CommandText = "islr_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_islr = Getcod_islr(IslrDetalle);
                Cmd.Parameters.Add(Parcod_islr);


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
        public string Editar(DIslrDetalle IslrDetalle)
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
                    CommandText = "islr_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_islr = Getcod_islr(IslrDetalle);
                Cmd.Parameters.Add(Parcod_islr);          

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
        public string Eliminar(DIslrDetalle IslrDetalle)
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
                    CommandText = "islr_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_islr = Getcod_islr(IslrDetalle);
                Cmd.Parameters.Add(Parcod_islr);

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
        public DataTable Buscar(DIslrDetalle IslrDetalle)
        {
            DataTable DtRpta = new DataTable("TbIslrDetalle");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "islrdetalle_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_islr = Getcod_islr(IslrDetalle);
                Cmd.Parameters.Add(Parcod_islr);

                SqlParameter Parbuscar = Getbuscar(IslrDetalle);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(IslrDetalle);
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
        public DataTable RepBuscar(DIslrDetalle IslrDetalle)
        {
            DataTable DtRpta = new DataTable("TbIslr");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "islr_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(IslrDetalle);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(IslrDetalle);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(IslrDetalle);
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
                    CommandText = "islr_primero",
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
                    CommandText = "islr_ultimo",
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
        /// <param name="Listar Anterior IslrDetalle"></param>
        public DataSet Anterior(DIslrDetalle IslrDetalle)
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
                    CommandText = "islr_anterior",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_islr = Getcod_islr(IslrDetalle);
                Cmd.Parameters.Add(Parcod_islr);

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
        /// <param name="Listar Siguiente IslrDetalle"></param>
        public DataSet Siguiente(DIslrDetalle IslrDetalle)
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
                    CommandText = "islr_siguiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_islr = Getcod_islr(IslrDetalle);
                Cmd.Parameters.Add(Parcod_islr);

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

    }
}
