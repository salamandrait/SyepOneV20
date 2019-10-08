using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DPago
    {
        #region PARAMETROS
        public Object Dcod_pago { get; set; }
        public Object Dcod_pagov { get; set; }
        public Object Dcod_proveedor { get; set; }
        public Object Ddesc_pago { get; set; }
        public Object Destatus { get; set; }
        public Object Danulado { get; set; }
        public Object Dmonto { get; set; }
        public Object Dfecha_reg { get; set; }
        public Object Dcampo1 { get; set; }
        public Object Dcampo2 { get; set; }
        public Object Dcampo3 { get; set; }
        public Object Dcampo4 { get; set; }
        public Object Dcampo5 { get; set; }
        public Object Dcampo6 { get; set; }
        public Object Dcod_usuario { get; set; }
        public Object Dbuscar { get; set; }
        public Object Dbuscard { get; set; }
        public Object Dbuscarh { get; set; }
        public Object Dbtipo { get; set; }

        private static SqlParameter Getcod_pago(DPago Pago)
        {
            SqlParameter Pcod_pago = new SqlParameter
            {
                ParameterName = "@cod_pago",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Pago.Dcod_pago,
            };
            return Pcod_pago;
        }

        private static SqlParameter Getcod_pagov(DPago Pago)
        {
            SqlParameter Pcod_pagov = new SqlParameter
            {
                ParameterName = "@cod_pagov",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Pago.Dcod_pagov,
            };
            return Pcod_pagov;
        }

        private static SqlParameter Getcod_proveedor(DPago Pago)
        {
            SqlParameter Pcod_proveedor = new SqlParameter
            {
                ParameterName = "@cod_proveedor",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Pago.Dcod_proveedor,
            };
            return Pcod_proveedor;
        }

        private static SqlParameter Getdesc_pago(DPago Pago)
        {
            SqlParameter Pdesc_pago = new SqlParameter
            {
                ParameterName = "@desc_pago",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Value = Pago.Ddesc_pago,
            };
            return Pdesc_pago;
        }

        private static SqlParameter Getestatus(DPago Pago)
        {
            SqlParameter Pestatus = new SqlParameter
            {
                ParameterName = "@estatus",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Pago.Destatus,
            };
            return Pestatus;
        }

        private static SqlParameter Getanulado(DPago Pago)
        {
            SqlParameter Panulado = new SqlParameter
            {
                ParameterName = "@anulado",
                SqlDbType = SqlDbType.Bit,
                Value = Pago.Danulado,
            };
            return Panulado;
        }

        private static SqlParameter Getmonto(DPago Pago)
        {
            SqlParameter Pmonto = new SqlParameter
            {
                ParameterName = "@monto",
                SqlDbType = SqlDbType.Money,
                Value = Pago.Dmonto,
            };
            return Pmonto;
        }

        private static SqlParameter Getfecha_reg(DPago Pago)
        {
            SqlParameter Pfecha_reg = new SqlParameter
            {
                ParameterName = "@fecha_reg",
                SqlDbType = SqlDbType.DateTime,
                Value = Pago.Dfecha_reg,
            };
            return Pfecha_reg;
        }

        private static SqlParameter Getcampo1(DPago Pago)
        {
            SqlParameter Pcampo1 = new SqlParameter
            {
                ParameterName = "@campo1",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Pago.Dcampo1,
            };
            return Pcampo1;
        }

        private static SqlParameter Getcampo2(DPago Pago)
        {
            SqlParameter Pcampo2 = new SqlParameter
            {
                ParameterName = "@campo2",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Pago.Dcampo2,
            };
            return Pcampo2;
        }

        private static SqlParameter Getcampo3(DPago Pago)
        {
            SqlParameter Pcampo3 = new SqlParameter
            {
                ParameterName = "@campo3",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Pago.Dcampo3,
            };
            return Pcampo3;
        }

        private static SqlParameter Getcampo4(DPago Pago)
        {
            SqlParameter Pcampo4 = new SqlParameter
            {
                ParameterName = "@campo4",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Pago.Dcampo4,
            };
            return Pcampo4;
        }

        private static SqlParameter Getcampo5(DPago Pago)
        {
            SqlParameter Pcampo5 = new SqlParameter
            {
                ParameterName = "@campo5",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Pago.Dcampo5,
            };
            return Pcampo5;
        }

        private static SqlParameter Getcampo6(DPago Pago)
        {
            SqlParameter Pcampo6 = new SqlParameter
            {
                ParameterName = "@campo6",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Pago.Dcampo6,
            };
            return Pcampo6;
        }

        private static SqlParameter Getcod_usuario(DPago Pago)
        {
            SqlParameter Pcod_usuario = new SqlParameter
            {
                ParameterName = "@cod_usuario",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Pago.Dcod_usuario,
            };
            return Pcod_usuario;
        }

        private static SqlParameter Getbuscar(DPago Pago)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Pago.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DPago Pago)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Pago.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DPago Pago)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Pago.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DPago Pago)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Pago.Dbtipo,
            };
            return Pbtipo;
        }
        #endregion

        public DPago()
        {
        }

        /// <summary>
        /// Tabla Mostrar No Recibe parametros
        /// </summary>
        /// <returns> 0 Parametros</returns>
        public DataTable Mostrar()
        {
            DataTable DtRpta = new DataTable("TbPago");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlCon,
                    CommandText = "pago_mostrar",
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
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return DtRpta;
        }

        /// <summary>
        /// Tabla Mostrar No Recibe parametros
        /// </summary>
        /// <returns> 0 Parametros</returns>
        public DataTable MostrarSaldoTodos()
        {
            DataTable DtRpta = new DataTable("TbPago");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlCon,
                    CommandText = "pago_mostrarpendientet",
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
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return DtRpta;
        }

        /// <summary>
        /// Tabla Mostrar No Recibe parametros
        /// </summary>
        /// <returns> 0 Parametros</returns>
        public DataTable MostrarSaldo(DPago Pago)
        {
            DataTable DtRpta = new DataTable("TbPago");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlCon,
                    CommandText = "pago_mostrarpendiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_proveedor= Getcod_proveedor(Pago);
                Cmd.Parameters.Add(Parcod_proveedor);

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
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
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
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand Cmd = new SqlCommand()
                {
                    Connection = SqlCon,
                    CommandText = "pago_listar",
                    CommandType = CommandType.StoredProcedure,
                };

                Cmd.ExecuteNonQuery();
                SqlDataAdapter Dat = new SqlDataAdapter(Cmd);
                Dat.Fill(DsRpta, "TbPago");

            }
            catch (Exception Exc)
            {
                DsRpta = null;
                throw new Exception("Error al Ejecutar el procedimiento almacenado" + Exc.Message);
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return DsRpta;
        }

        /// <summary>
        /// Metodo Insertar Datos Recibe 8 Parametros
        /// </summary>
        /// <returns> 8 Parametros</returns>
        public string Insertar(DPago Pago)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand Cmd = new SqlCommand()
                {
                    Connection = SqlCon,
                    CommandText = "pago_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_pago = Getcod_pago(Pago);
                Cmd.Parameters.Add(Parcod_pago);

                SqlParameter Pardesc_pago = Getdesc_pago(Pago);
                Cmd.Parameters.Add(Pardesc_pago);

                SqlParameter Parcod_proveedor = Getcod_proveedor(Pago);
                Cmd.Parameters.Add(Parcod_proveedor);

                SqlParameter Parestatus = Getestatus(Pago);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Paranulado = Getanulado(Pago);
                Cmd.Parameters.Add(Paranulado);

                SqlParameter Parmonto = Getmonto(Pago);
                Cmd.Parameters.Add(Parmonto);

                SqlParameter Parfecha_reg = Getfecha_reg(Pago);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parcampo1 = Getcampo1(Pago);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Pago);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Pago);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Pago);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Pago);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Pago);
                Cmd.Parameters.Add(Parcampo6);

                SqlParameter Parcod_usuario = Getcod_usuario(Pago);
                Cmd.Parameters.Add(Parcod_usuario);

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
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        /// <summary>
        /// Metodo Editar Datos Recibe 8 Parametros
        /// </summary>
        /// <returns> 8 Parametros</returns>
        public string Editar(DPago Pago)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand Cmd = new SqlCommand()
                {
                    Connection = SqlCon,
                    CommandText = "pago_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_pago = Getcod_pago(Pago);
                Cmd.Parameters.Add(Parcod_pago);

                SqlParameter Parcod_pagov = Getcod_pagov(Pago);
                Cmd.Parameters.Add(Parcod_pagov);

                SqlParameter Pardesc_pago = Getdesc_pago(Pago);
                Cmd.Parameters.Add(Pardesc_pago);

                SqlParameter Parcod_proveedor = Getcod_proveedor(Pago);
                Cmd.Parameters.Add(Parcod_proveedor);

                SqlParameter Parestatus = Getestatus(Pago);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Paranulado = Getanulado(Pago);
                Cmd.Parameters.Add(Paranulado);

                SqlParameter Parmonto = Getmonto(Pago);
                Cmd.Parameters.Add(Parmonto);

                SqlParameter Parfecha_reg = Getfecha_reg(Pago);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parcampo1 = Getcampo1(Pago);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Pago);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Pago);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Pago);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Pago);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Pago);
                Cmd.Parameters.Add(Parcampo6);

                SqlParameter Parcod_usuario = Getcod_usuario(Pago);
                Cmd.Parameters.Add(Parcod_usuario);

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
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        /// <summary>
        /// Metodo Eliminar Datos Recibe 1 Parametro
        /// </summary>
        /// <returns> 1 Parametro</returns>
        public string Eliminar(DPago Pago)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand Cmd = new SqlCommand()
                {
                    Connection = SqlCon,
                    CommandText = "pago_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_pago = Getcod_pago(Pago);
                Cmd.Parameters.Add(Parcod_pago);

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
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        /// <summary>
        /// Metodo Anular Datos Recibe 1 Parametro
        /// </summary>
        /// <returns> 1 Parametro</returns>
        public string Anular(DPago Pago)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand Cmd = new SqlCommand()
                {
                    Connection = SqlCon,
                    CommandText = "pago_anular",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_pago = Getcod_pago(Pago);
                Cmd.Parameters.Add(Parcod_pago);

                SqlParameter Parestatus = Getestatus(Pago);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Paranulado = Getanulado(Pago);
                Cmd.Parameters.Add(Paranulado);

                SqlParameter Parcod_usuario = Getcod_usuario(Pago);
                Cmd.Parameters.Add(Parcod_usuario);

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
                    Rpta = "No se pueden Anular Registros Relacionados   " + Exc.Message;
                }
                else
                {
                    Rpta = "Error al intentar ejecutar el procedimiento almacenado " + Exc.Message;
                }
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        /// <summary>
        /// Metodo Buscar Datos Recibe 2 Parametros
        /// </summary>
        public DataTable Buscar(DPago Pago)
        {
            DataTable DtRpta = new DataTable("TbPago");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlCon,
                    CommandText = "pago_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(Pago);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(Pago);
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
                SqlCon.Close();
            }
            return DtRpta;
        }

        /// <summary>
        /// Procedimiento Buscar Datos Recibe 3 Parametros
        /// </summary>
        public DataTable RepBuscar(DPago Pago)
        {
            DataTable DtRpta = new DataTable("TbPago");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlCon,
                    CommandText = "pago_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(Pago);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(Pago);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(Pago);
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
                SqlCon.Close();
            }
            return DtRpta;
        }

        /// <summary>
        /// Procedimiento Listar Primero Datos
        /// </summary>
        public DataSet Primero()
        {
            DataSet DsRpta = new DataSet();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlCon,
                    CommandText = "pago_primero",
                    CommandType = CommandType.StoredProcedure,
                };

                Cmd.ExecuteNonQuery();
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DsRpta, "TbPago");

            }
            catch (Exception Ex)
            {
                DsRpta = null;
                throw new Exception("Error al Ejecutar el procedimiento almacenado" + Ex.Message, Ex);
            }
            finally
            {
                SqlCon.Close();
            }
            return DsRpta;
        }

        /// <summary>
        /// Procedimiento Listar Ultimo Datos
        /// </summary>
        public DataSet Ultimo()
        {
            DataSet DsRpta = new DataSet();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlCon,
                    CommandText = "pago_ultimo",
                    CommandType = CommandType.StoredProcedure,
                };

                Cmd.ExecuteNonQuery();
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DsRpta, "TbPago");

            }
            catch (Exception Ex)
            {
                DsRpta = null;
                throw new Exception("Error al Ejecutar el procedimiento almacenado" + Ex.Message, Ex);
            }
            finally
            {
                SqlCon.Close();
            }
            return DsRpta;
        }

        /// <summary>
        /// Procedimiento Listar Anterior Datos
        /// </summary>
        /// <param name="Listar Anterior Pago"></param>
        public DataSet Anterior(DPago Pago)
        {
            DataSet DsRpta = new DataSet();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlCon,
                    CommandText = "pago_anterior",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_pago = Getcod_pago(Pago);
                Cmd.Parameters.Add(Parcod_pago);

                Cmd.ExecuteNonQuery();
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DsRpta, "TbPago");

            }
            catch (Exception Ex)
            {
                DsRpta = null;
                throw new Exception("Error al Ejecutar el procedimiento almacenado" + Ex.Message, Ex);
            }
            finally
            {
                SqlCon.Close();
            }
            return DsRpta;
        }

        /// <summary>
        /// Procedimiento Listar Siguiente Datos
        /// </summary>
        /// <param name="Listar Siguiente Pago"></param>
        public DataSet Siguiente(DPago Pago)
        {
            DataSet DsRpta = new DataSet();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlCon,
                    CommandText = "pago_siguiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_pago = Getcod_pago(Pago);
                Cmd.Parameters.Add(Parcod_pago);

                Cmd.ExecuteNonQuery();
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DsRpta, "TbPago");

            }
            catch (Exception Ex)
            {
                DsRpta = null;
                throw new Exception("Error al Ejecutar el procedimiento almacenado" + Ex.Message, Ex);
            }
            finally
            {
                SqlCon.Close();
            }
            return DsRpta;
        }

        /// <summary>
        /// Procedimiento Generar Codigo
        /// </summary>
        /// <param name="Generar Codigo"></param>
        /// <return>Retorna el Codigo</return>
        public string GenerarCod(DPago Pago)
        {
            SqlConnection SqlCon = new SqlConnection
            {
                ConnectionString = DConexion.Cn
            };

            SqlCon.Open();
            SqlCommand Cmd = new SqlCommand
            {
                Connection = SqlCon,
                CommandText = "pago_generarcod",
                CommandType = CommandType.StoredProcedure,
            };

            try
            {
                SqlParameter ParCod_pago = new SqlParameter("@cod_pago", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                    Value = Pago.Dcod_pago
                };
                Cmd.Parameters.Add(ParCod_pago);

                if (Cmd.ExecuteNonQuery() == 0)
                {
                    return Cmd.Parameters[ParCod_pago.ToString()].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                string Resp = ex.Message;
            }
            finally
            {
                SqlCon.Close();
            }
            return Cmd.Parameters["@cod_pago"].Value.ToString();
        }
    }
}
