using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DPagoDetalle
    {
        #region PARAMETROS
        public Object Dreng { get; set; }
        public Object Dcod_pago { get; set; }
        public Object Dcod_pagov { get; set; }
        public Object Dcod_compra { get; set; }
        public Object Dcod_movcaja { get; set; }
        public Object Dcod_movbanco { get; set; }
        public Object Doptipo { get; set; }
        public Object Dnumdocpago { get; set; }
        public Object Dforma { get; set; }
        public Object Dmonto { get; set; }
        public Object Desretenislr { get; set; }
        public Object Desreteniva { get; set; }
        public Object Dfecha_reg { get; set; }
        public Object Dbuscar { get; set; }
        public Object Dbuscard { get; set; }
        public Object Dbuscarh { get; set; }
        public Object Dbtipo { get; set; }


        private static SqlParameter Getcod_pago(DPagoDetalle PagoDetalle)
        {
            SqlParameter Pcod_pago = new SqlParameter
            {
                ParameterName = "@cod_pago",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = PagoDetalle.Dcod_pago,
            };
            return Pcod_pago;
        }

        private static SqlParameter Getreng(DPagoDetalle PagoDetalle)
        {
            SqlParameter Preng = new SqlParameter
            {
                ParameterName = "@reng",
                SqlDbType = SqlDbType.Int,
                Value = PagoDetalle.Dreng,
            };
            return Preng;
        }

        private static SqlParameter Getcod_compra(DPagoDetalle PagoDetalle)
        {
            SqlParameter Pcod_compra = new SqlParameter
            {
                ParameterName = "@cod_compra",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = PagoDetalle.Dcod_compra,
            };
            return Pcod_compra;
        }

        private static SqlParameter Getmonto(DPagoDetalle PagoDetalle)
        {
            SqlParameter Pmonto = new SqlParameter
            {
                ParameterName = "@monto",
                SqlDbType = SqlDbType.Money,
                Scale = 18,
                Precision = 3,
                Value = PagoDetalle.Dmonto,
            };
            return Pmonto;
        }

        private static SqlParameter Getfecha_reg(DPagoDetalle PagoDetalle)
        {
            SqlParameter Pfecha_reg = new SqlParameter
            {
                ParameterName = "@fecha_reg",
                SqlDbType = SqlDbType.DateTime,
                Value = PagoDetalle.Dfecha_reg,
            };
            return Pfecha_reg;
        }

        private static SqlParameter Getnumdocpago(DPagoDetalle PagoDetalle)
        {
            SqlParameter Pnumdocpago = new SqlParameter
            {
                ParameterName = "@numdocpago",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = PagoDetalle.Dnumdocpago,
            };
            return Pnumdocpago;
        }

        private static SqlParameter Getoptipo(DPagoDetalle PagoDetalle)
        {
            SqlParameter Poptipo = new SqlParameter
            {
                ParameterName = "@optipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = PagoDetalle.Doptipo,
            };
            return Poptipo;
        }

        private static SqlParameter Getforma(DPagoDetalle PagoDetalle)
        {
            SqlParameter Pforma = new SqlParameter
            {
                ParameterName = "@forma",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = PagoDetalle.Dforma,
            };
            return Pforma;
        }

        private static SqlParameter Getcod_movcaja(DPagoDetalle PagoDetalle)
        {
            SqlParameter Pcod_movcaja = new SqlParameter
            {
                ParameterName = "@cod_movcaja",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = PagoDetalle.Dcod_movcaja,
            };
            return Pcod_movcaja;
        }

        private static SqlParameter Getcod_movbanco(DPagoDetalle PagoDetalle)
        {
            SqlParameter Dcod_movbanco = new SqlParameter
            {
                ParameterName = "@cod_movbanco",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = PagoDetalle.Dcod_movbanco,
            };
            return Dcod_movbanco;
        }

        private static SqlParameter Getesreteniva(DPagoDetalle PagoDetalle)
        {
            SqlParameter Pesreteniva = new SqlParameter
            {
                ParameterName = "@esreteniva",
                SqlDbType = SqlDbType.Bit,
                Value = PagoDetalle.Desreteniva,
            };
            return Pesreteniva;
        }

        private static SqlParameter Getesretenislr(DPagoDetalle PagoDetalle)
        {
            SqlParameter Pesretenislr = new SqlParameter
            {
                ParameterName = "@esretenislr",
                SqlDbType = SqlDbType.Bit,
                Value = PagoDetalle.Desretenislr,
            };
            return Pesretenislr;
        }

        private static SqlParameter Getbuscar(DPagoDetalle PagoDetalle)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = PagoDetalle.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DPagoDetalle PagoDetalle)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = PagoDetalle.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DPagoDetalle PagoDetalle)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = PagoDetalle.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DPagoDetalle PagoDetalle)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = PagoDetalle.Dbtipo,
            };
            return Pbtipo;
        }
        #endregion

        public DPagoDetalle()
        {
        }

        /// <summary>
        /// Tabla Mostrar No Recibe parametros
        /// </summary>
        /// <returns> 0 Parametros</returns>
        public DataTable Mostrar(DPagoDetalle PagoDetalle)
        {
            DataTable DtRpta = new DataTable("TbPagoDetalle");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlCon,
                    CommandText = "pagodetalle_mostrar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_pago = Getcod_pago(PagoDetalle);
                Cmd.Parameters.Add(Parcod_pago);

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
        public DataTable MostrarP(DPagoDetalle PagoDetalle)
        {
            DataTable DtRpta = new DataTable("TbPagoDetalle");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlCon,
                    CommandText = "pagodetalle_mostrar_p",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_pago = Getcod_pago(PagoDetalle);
                Cmd.Parameters.Add(Parcod_pago);

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
                    CommandText = "pagodetalle_listar",
                    CommandType = CommandType.StoredProcedure,
                };

                Cmd.ExecuteNonQuery();
                SqlDataAdapter Dat = new SqlDataAdapter(Cmd);
                Dat.Fill(DsRpta, "TbPagoDetalle");

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
        public string Insertar(DPagoDetalle PagoDetalle)
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
                    CommandText = "pagodetalle_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_pago = Getcod_pago(PagoDetalle);
                Cmd.Parameters.Add(Parcod_pago);

                SqlParameter cod_compra = Getcod_compra(PagoDetalle);
                Cmd.Parameters.Add(cod_compra);

                SqlParameter Parmonto = Getmonto(PagoDetalle);
                Cmd.Parameters.Add(Parmonto);

                SqlParameter Paresreteniva = Getesreteniva(PagoDetalle);
                Cmd.Parameters.Add(Paresreteniva);

                SqlParameter Paresretenislr = Getesretenislr(PagoDetalle);
                Cmd.Parameters.Add(Paresretenislr);

                SqlParameter Parnumdocpago = Getnumdocpago(PagoDetalle);
                Cmd.Parameters.Add(Parnumdocpago);

                SqlParameter Paroptipo = Getoptipo(PagoDetalle);
                Cmd.Parameters.Add(Paroptipo);

                SqlParameter Parforma = Getforma(PagoDetalle);
                Cmd.Parameters.Add(Parforma);

                SqlParameter Parcod_movcaja = Getcod_movcaja(PagoDetalle);
                Cmd.Parameters.Add(Parcod_movcaja);

                SqlParameter Parcod_movbanco = Getcod_movbanco(PagoDetalle);
                Cmd.Parameters.Add(Parcod_movbanco);

                SqlParameter Parfecha_reg = Getfecha_reg(PagoDetalle);
                Cmd.Parameters.Add(Parfecha_reg);

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
                    Rpta = "El Codigo Ya Existe. No se Permiten Registros Duplicados fdfdfdfdfdfdf.";
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
        public string Editar(DPagoDetalle PagoDetalle)
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
                    CommandText = "pagodetalle_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter reng = Getreng(PagoDetalle);
                Cmd.Parameters.Add(reng);

                SqlParameter Parcod_pago = Getcod_pago(PagoDetalle);
                Cmd.Parameters.Add(Parcod_pago);

                SqlParameter cod_compra = Getcod_compra(PagoDetalle);
                Cmd.Parameters.Add(cod_compra);

                SqlParameter Parmonto = Getmonto(PagoDetalle);
                Cmd.Parameters.Add(Parmonto);

                SqlParameter Paresreteniva = Getesreteniva(PagoDetalle);
                Cmd.Parameters.Add(Paresreteniva);

                SqlParameter Paresretenislr = Getesretenislr(PagoDetalle);
                Cmd.Parameters.Add(Paresretenislr);

                SqlParameter Parnumdocpago = Getnumdocpago(PagoDetalle);
                Cmd.Parameters.Add(Parnumdocpago);

                SqlParameter Paroptipo = Getoptipo(PagoDetalle);
                Cmd.Parameters.Add(Paroptipo);

                SqlParameter Parforma = Getforma(PagoDetalle);
                Cmd.Parameters.Add(Parforma);

                SqlParameter Parcod_movcaja = Getcod_movcaja(PagoDetalle);
                Cmd.Parameters.Add(Parcod_movcaja);

                SqlParameter Parcod_movbanco = Getcod_movbanco(PagoDetalle);
                Cmd.Parameters.Add(Parcod_movbanco);

                SqlParameter Parfecha_reg = Getfecha_reg(PagoDetalle);
                Cmd.Parameters.Add(Parfecha_reg);

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
        public string Eliminar(DPagoDetalle PagoDetalle)
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
                    CommandText = "pagodetalle_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_pago = Getcod_pago(PagoDetalle);
                Cmd.Parameters.Add(Parcod_pago);

                SqlParameter Parcod_compra = Getcod_compra(PagoDetalle);
                Cmd.Parameters.Add(Parcod_compra);

                SqlParameter Paroptipo = Getoptipo(PagoDetalle);
                Cmd.Parameters.Add(Paroptipo);

                SqlParameter Parmonto = Getmonto(PagoDetalle);
                Cmd.Parameters.Add(Parmonto);

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
        /// Metodo Buscar Datos Recibe 2 Parametros
        /// </summary>
        public DataTable Buscar(DPagoDetalle PagoDetalle)
        {
            DataTable DtRpta = new DataTable("TbPagoDetalle");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlCon,
                    CommandText = "pagodetalle_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(PagoDetalle);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(PagoDetalle);
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
        public DataTable RepBuscar(DPagoDetalle PagoDetalle)
        {
            DataTable DtRpta = new DataTable("TbPagoDetalle");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlCon,
                    CommandText = "pagodetalle_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(PagoDetalle);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(PagoDetalle);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(PagoDetalle);
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

    }
}
