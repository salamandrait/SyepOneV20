using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DStockInventario
    {
        #region PARAMETROS
        public Object Dcod_articulo { get; set; }
        public Object Dcod_artunidad { get; set; }
        public Object Dcod_deposito { get; set; }
        public Object Dcantidad { get; set; }
        public Object Dtipostock { get; set; }
        public Object Dcod_stockinventario { get; set; }
        public Object Dcod_stockinventariov { get; set; }
        public Object Ddesc_stockinventario { get; set; }
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

        private static SqlParameter Getcod_articulo(DStockInventario StockInventario)
        {
            SqlParameter Pcod_articulo = new SqlParameter
            {
                ParameterName = "@cod_articulo",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = StockInventario.Dcod_articulo,
            };
            return Pcod_articulo;
        }

        private static SqlParameter Getcod_artunidad(DStockInventario StockInventario)
        {
            SqlParameter Pcod_artunidad = new SqlParameter
            {
                ParameterName = "@cod_artunidad",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = StockInventario.Dcod_artunidad,
            };
            return Pcod_artunidad;
        }

        private static SqlParameter Getcod_deposito(DStockInventario StockInventario)
        {
            SqlParameter Pcod_deposito = new SqlParameter
            {
                ParameterName = "@cod_deposito",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = StockInventario.Dcod_deposito,
            };
            return Pcod_deposito;
        }

        private static SqlParameter Getcantidad(DStockInventario StockInventario)
        {
            SqlParameter Pcantidad = new SqlParameter
            {
                ParameterName = "@cantidad",
                SqlDbType = SqlDbType.Decimal,
                Scale=18,
                Precision=3,
                Value = StockInventario.Dcantidad,
            };
            return Pcantidad;
        }

        private static SqlParameter Gettipostock(DStockInventario StockInventario)
        {
            SqlParameter Ptipostock = new SqlParameter
            {
                ParameterName = "@tipostock",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = StockInventario.Dtipostock,
            };
            return Ptipostock;
        }

        private static SqlParameter Getcod_stockinventario(DStockInventario StockInventario)
        {
            SqlParameter Pcod_stockinventario = new SqlParameter
            {
                ParameterName = "@cod_stockinventario",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = StockInventario.Dcod_stockinventario,
            };
            return Pcod_stockinventario;
        }

        private static SqlParameter Getcod_stockinventariov(DStockInventario StockInventario)
        {
            SqlParameter Pcod_stockinventariov = new SqlParameter
            {
                ParameterName = "@cod_stockinventariov",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = StockInventario.Dcod_stockinventariov,
            };
            return Pcod_stockinventariov;
        }

        private static SqlParameter Getdesc_stockinventario(DStockInventario StockInventario)
        {
            SqlParameter Pdesc_stockinventario = new SqlParameter
            {
                ParameterName = "@desc_stockinventario",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Value = StockInventario.Ddesc_stockinventario,
            };
            return Pdesc_stockinventario;
        }

        private static SqlParameter Getcampo1(DStockInventario StockInventario)
        {
            SqlParameter Pcampo1 = new SqlParameter
            {
                ParameterName = "@campo1",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = StockInventario.Dcampo1,
            };
            return Pcampo1;
        }

        private static SqlParameter Getcampo2(DStockInventario StockInventario)
        {
            SqlParameter Pcampo2 = new SqlParameter
            {
                ParameterName = "@campo2",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = StockInventario.Dcampo2,
            };
            return Pcampo2;
        }

        private static SqlParameter Getcampo3(DStockInventario StockInventario)
        {
            SqlParameter Pcampo3 = new SqlParameter
            {
                ParameterName = "@campo3",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = StockInventario.Dcampo3,
            };
            return Pcampo3;
        }

        private static SqlParameter Getcampo4(DStockInventario StockInventario)
        {
            SqlParameter Pcampo4 = new SqlParameter
            {
                ParameterName = "@campo4",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = StockInventario.Dcampo4,
            };
            return Pcampo4;
        }

        private static SqlParameter Getcampo5(DStockInventario StockInventario)
        {
            SqlParameter Pcampo5 = new SqlParameter
            {
                ParameterName = "@campo5",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = StockInventario.Dcampo5,
            };
            return Pcampo5;
        }

        private static SqlParameter Getcampo6(DStockInventario StockInventario)
        {
            SqlParameter Pcampo6 = new SqlParameter
            {
                ParameterName = "@campo6",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = StockInventario.Dcampo6,
            };
            return Pcampo6;
        }

        private static SqlParameter Getbuscar(DStockInventario StockInventario)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = StockInventario.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DStockInventario StockInventario)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = StockInventario.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DStockInventario StockInventario)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = StockInventario.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DStockInventario StockInventario)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = StockInventario.Dbtipo,
            };
            return Pbtipo;
        }

        #endregion

        public DStockInventario()
        {
            /// Constructor Vacio
        }


        /// <summary>
        /// Tabla Mostrar No Recibe parametros
        /// </summary>
        /// <returns> 0 Parametros</returns>
        public DataTable Mostrar()
        {
            DataTable DtRpta = new DataTable("TbStockInventario");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "stockinventario_mostrar",
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

        public DataTable VerificarStock(DStockInventario StockInventario)
        {
            DataTable DtRpta = new DataTable("TbStockInventario");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "stockinventario_verificar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_articulo = Getcod_articulo(StockInventario);
                Cmd.Parameters.Add(Parcod_articulo);

                SqlParameter Parcod_deposito = Getcod_deposito(StockInventario);
                Cmd.Parameters.Add(Parcod_deposito);

                SqlParameter Partipostock = Gettipostock(StockInventario);
                Cmd.Parameters.Add(Partipostock);

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

        ///// <summary>
        ///// Tabla Listar No Recibe parametros
        ///// </summary>
        ///// <returns> 0 Parametros</returns>
        //public DataSet Listar()
        //{
        //    DataSet DsRpta = new DataSet();
        //    SqlConnection SqlConn = new SqlConnection();

        //    try
        //    {
        //        SqlConn.ConnectionString = DConexion.Cn;
        //        SqlConn.Open();

        //        SqlCommand Cmd = new SqlCommand()
        //        {
        //            Connection = SqlConn,
        //            CommandText = "stockinventario_listar",
        //            CommandType = CommandType.StoredProcedure,
        //        };

        //        Cmd.ExecuteNonQuery();
        //        SqlDataAdapter Dat = new SqlDataAdapter(Cmd);
        //        Dat.Fill(DsRpta, "TbStockInventario");

        //    }
        //    catch (Exception Exc)
        //    {
        //        DsRpta = null;
        //        throw new Exception("Error al Ejecutar el procedimiento almacenado" + Exc.Message);
        //    }
        //    finally
        //    {
        //        if (SqlConn.State == ConnectionState.Open)
        //        {
        //            SqlConn.Close();
        //        }
        //    }
        //    return DsRpta;
        //}

        ///// <summary>
        ///// Metodo Insertar Datos Recibe 8 Parametros
        ///// </summary>
        ///// <returns> 8 Parametros</returns>
        //public string Insertar(DStockInventario StockInventario)
        //{
        //    string Rpta = "";
        //    SqlConnection SqlConn = new SqlConnection();

        //    try
        //    {
        //        SqlConn.ConnectionString = DConexion.Cn;
        //        SqlConn.Open();

        //        SqlCommand Cmd = new SqlCommand()
        //        {
        //            Connection = SqlConn,
        //            CommandText = "stockinventario_insertar",
        //            CommandType = CommandType.StoredProcedure,
        //        };

        //        SqlParameter Parcod_stockinventario = Getcod_stockinventario(StockInventario);
        //        Cmd.Parameters.Add(Parcod_stockinventario);

        //        SqlParameter Pardesc_stockinventario = Getdesc_stockinventario(StockInventario);
        //        Cmd.Parameters.Add(Pardesc_stockinventario);

        //        SqlParameter Parcampo1 = Getcampo1(StockInventario);
        //        Cmd.Parameters.Add(Parcampo1);

        //        SqlParameter Parcampo2 = Getcampo2(StockInventario);
        //        Cmd.Parameters.Add(Parcampo2);

        //        SqlParameter Parcampo3 = Getcampo3(StockInventario);
        //        Cmd.Parameters.Add(Parcampo3);

        //        SqlParameter Parcampo4 = Getcampo4(StockInventario);
        //        Cmd.Parameters.Add(Parcampo4);

        //        SqlParameter Parcampo5 = Getcampo5(StockInventario);
        //        Cmd.Parameters.Add(Parcampo5);

        //        SqlParameter Parcampo6 = Getcampo6(StockInventario);
        //        Cmd.Parameters.Add(Parcampo6);

        //        Cmd.ExecuteNonQuery();
        //        Rpta = "Y";
        //    }
        //    catch (SqlException Exc)
        //    {
        //        if (Exc.Number == 8152)
        //        {
        //            Rpta = "Ha introducido demasiados caracteres en uno de los campos.";
        //        }
        //        else if (Exc.Number == 2627)
        //        {
        //            Rpta = "El Codigo Ya Existe. No se Permiten Registros Duplicados.";
        //        }
        //        else if (Exc.Number == 2812)
        //        {
        //            Rpta = "No Existe el Procedimiento Almacenado";
        //        }
        //        else
        //        {
        //            Rpta = "Error al intentar ejecutar el procedimiento almacenado " + Exc.Message;
        //        }
        //    }
        //    finally
        //    {
        //        if (SqlConn.State == ConnectionState.Open) SqlConn.Close();
        //    }
        //    return Rpta;
        //}

        ///// <summary>
        ///// Metodo Editar Datos Recibe 8 Parametros
        ///// </summary>
        ///// <returns> 8 Parametros</returns>
        //public string Editar(DStockInventario StockInventario)
        //{
        //    string Rpta = "";
        //    SqlConnection SqlConn = new SqlConnection();

        //    try
        //    {
        //        SqlConn.ConnectionString = DConexion.Cn;
        //        SqlConn.Open();

        //        SqlCommand Cmd = new SqlCommand()
        //        {
        //            Connection = SqlConn,
        //            CommandText = "stockinventario_editar",
        //            CommandType = CommandType.StoredProcedure,
        //        };

        //        SqlParameter Parcod_stockinventario = Getcod_stockinventario(StockInventario);
        //        Cmd.Parameters.Add(Parcod_stockinventario);

        //        SqlParameter Parcod_stockinventariov = Getcod_stockinventariov(StockInventario);
        //        Cmd.Parameters.Add(Parcod_stockinventariov);

        //        SqlParameter Pardesc_stockinventario = Getdesc_stockinventario(StockInventario);
        //        Cmd.Parameters.Add(Pardesc_stockinventario);

        //        SqlParameter Parcampo1 = Getcampo1(StockInventario);
        //        Cmd.Parameters.Add(Parcampo1);

        //        SqlParameter Parcampo2 = Getcampo2(StockInventario);
        //        Cmd.Parameters.Add(Parcampo2);

        //        SqlParameter Parcampo3 = Getcampo3(StockInventario);
        //        Cmd.Parameters.Add(Parcampo3);

        //        SqlParameter Parcampo4 = Getcampo4(StockInventario);
        //        Cmd.Parameters.Add(Parcampo4);

        //        SqlParameter Parcampo5 = Getcampo5(StockInventario);
        //        Cmd.Parameters.Add(Parcampo5);

        //        SqlParameter Parcampo6 = Getcampo6(StockInventario);
        //        Cmd.Parameters.Add(Parcampo6);

        //        Cmd.ExecuteNonQuery();
        //        Rpta = "Y";
        //    }
        //    catch (SqlException Exc)
        //    {
        //        if (Exc.Number == 8152)
        //        {
        //            Rpta = "Ha introducido demasiados caracteres en uno de los campos.";
        //        }
        //        else if (Exc.Number == 2627)
        //        {
        //            Rpta = "El Codigo Ya Existe. No se Permiten Registros Duplicados.";
        //        }
        //        else if (Exc.Number == 2812)
        //        {
        //            Rpta = "No Existe el Procedimiento Almacenado";
        //        }
        //        else if (Exc.Number == 547)
        //        {
        //            Rpta = "No se Pueden Editar Registros Relacionados   **" + Exc.StackTrace + " **";
        //        }
        //        else
        //        {
        //            Rpta = "Error al intentar ejecutar el procedimiento almacenado " + Exc.Message;
        //        }
        //    }
        //    finally
        //    {
        //        if (SqlConn.State == ConnectionState.Open) SqlConn.Close();
        //    }
        //    return Rpta;
        //}

        ///// <summary>
        ///// Metodo Eliminar Datos Recibe 1 Parametro
        ///// </summary>
        ///// <returns> 1 Parametro</returns>
        //public string Eliminar(DStockInventario StockInventario)
        //{
        //    string Rpta = "";
        //    SqlConnection SqlConn = new SqlConnection();

        //    try
        //    {
        //        SqlConn.ConnectionString = DConexion.Cn;
        //        SqlConn.Open();

        //        SqlCommand Cmd = new SqlCommand()
        //        {
        //            Connection = SqlConn,
        //            CommandText = "stockinventario_eliminar",
        //            CommandType = CommandType.StoredProcedure,
        //        };

        //        SqlParameter Parcod_stockinventario = Getcod_stockinventario(StockInventario);
        //        Cmd.Parameters.Add(Parcod_stockinventario);

        //        Cmd.ExecuteNonQuery();
        //        Rpta = "Y";
        //    }
        //    catch (SqlException Exc)
        //    {
        //        if (Exc.Number == 2812)
        //        {
        //            Rpta = "No Existe el Procedimiento Almacenado";
        //        }
        //        else if (Exc.Number == 547)
        //        {
        //            Rpta = "No se pueden Eliminar Registros Relacionados   " + Exc.Message;
        //        }
        //        else
        //        {
        //            Rpta = "Error al intentar ejecutar el procedimiento almacenado " + Exc.Message;
        //        }
        //    }
        //    finally
        //    {
        //        if (SqlConn.State == ConnectionState.Open) SqlConn.Close();
        //    }
        //    return Rpta;
        //}

        ///// <summary>
        ///// Metodo Buscar Datos Recibe 2 Parametros
        ///// </summary>
        //public DataTable Buscar(DStockInventario StockInventario)
        //{
        //    DataTable DtRpta = new DataTable("TbStockInventario");
        //    SqlConnection SqlConn = new SqlConnection();

        //    try
        //    {
        //        SqlConn.ConnectionString = DConexion.Cn;
        //        SqlConn.Open();

        //        SqlCommand Cmd = new SqlCommand
        //        {
        //            Connection = SqlConn,
        //            CommandText = "stockinventario_buscar",
        //            CommandType = CommandType.StoredProcedure,
        //        };

        //        SqlParameter Parbuscar = Getbuscar(StockInventario);
        //        Cmd.Parameters.Add(Parbuscar);

        //        SqlParameter Parbtipo = Getbtipo(StockInventario);
        //        Cmd.Parameters.Add(Parbtipo);

        //        Cmd.ExecuteNonQuery();
        //        SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
        //        SqlDat.Fill(DtRpta);

        //    }
        //    catch (Exception Ex)
        //    {
        //        DtRpta = null;
        //        throw new Exception("Error al Ejecutar el procedimiento almacenado" + Ex.Message, Ex);
        //    }
        //    finally
        //    {
        //        SqlConn.Close();
        //    }
        //    return DtRpta;
        //}

        ///// <summary>
        ///// Procedimiento Buscar Datos Recibe 3 Parametros
        ///// </summary>
        //public DataTable RepBuscar(DStockInventario StockInventario)
        //{
        //    DataTable DtRpta = new DataTable("TbStockInventario");
        //    SqlConnection SqlConn = new SqlConnection();

        //    try
        //    {
        //        SqlConn.ConnectionString = DConexion.Cn;
        //        SqlConn.Open();

        //        SqlCommand Cmd = new SqlCommand
        //        {
        //            Connection = SqlConn,
        //            CommandText = "stockinventario_rptlistar",
        //            CommandType = CommandType.StoredProcedure,
        //        };

        //        SqlParameter Parbuscard = Getbuscard(StockInventario);
        //        Cmd.Parameters.Add(Parbuscard);

        //        SqlParameter Parbuscarh = Getbuscarh(StockInventario);
        //        Cmd.Parameters.Add(Parbuscarh);

        //        SqlParameter Parbtipo = Getbtipo(StockInventario);
        //        Cmd.Parameters.Add(Parbtipo);

        //        Cmd.ExecuteNonQuery();
        //        SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
        //        SqlDat.Fill(DtRpta);

        //    }
        //    catch (Exception Ex)
        //    {
        //        DtRpta = null;
        //        throw new Exception("Error al Ejecutar el procedimiento almacenado" + Ex.Message, Ex);
        //    }
        //    finally
        //    {
        //        SqlConn.Close();
        //    }
        //    return DtRpta;
        //}

        ///// <summary>
        ///// Procedimiento Listar Primero Datos
        ///// </summary>
        //public DataSet Primero()
        //{
        //    DataSet DsRpta = new DataSet();
        //    SqlConnection SqlConn = new SqlConnection();

        //    try
        //    {
        //        SqlConn.ConnectionString = DConexion.Cn;
        //        SqlConn.Open();

        //        SqlCommand Cmd = new SqlCommand
        //        {
        //            Connection = SqlConn,
        //            CommandText = "stockinventario_primero",
        //            CommandType = CommandType.StoredProcedure,
        //        };

        //        Cmd.ExecuteNonQuery();
        //        SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
        //        SqlDat.Fill(DsRpta, "TbStockInventario");

        //    }
        //    catch (Exception Ex)
        //    {
        //        DsRpta = null;
        //        throw new Exception("Error al Ejecutar el procedimiento almacenado" + Ex.Message, Ex);
        //    }
        //    finally
        //    {
        //        SqlConn.Close();
        //    }
        //    return DsRpta;
        //}

        ///// <summary>
        ///// Procedimiento Listar Ultimo Datos
        ///// </summary>
        //public DataSet Ultimo()
        //{
        //    DataSet DsRpta = new DataSet();
        //    SqlConnection SqlConn = new SqlConnection();

        //    try
        //    {
        //        SqlConn.ConnectionString = DConexion.Cn;
        //        SqlConn.Open();

        //        SqlCommand Cmd = new SqlCommand
        //        {
        //            Connection = SqlConn,
        //            CommandText = "stockinventario_ultimo",
        //            CommandType = CommandType.StoredProcedure,
        //        };

        //        Cmd.ExecuteNonQuery();
        //        SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
        //        SqlDat.Fill(DsRpta, "TbStockInventario");

        //    }
        //    catch (Exception Ex)
        //    {
        //        DsRpta = null;
        //        throw new Exception("Error al Ejecutar el procedimiento almacenado" + Ex.Message, Ex);
        //    }
        //    finally
        //    {
        //        SqlConn.Close();
        //    }
        //    return DsRpta;
        //}

        ///// <summary>
        ///// Procedimiento Listar Anterior Datos
        ///// </summary>
        ///// <param name="Listar Anterior StockInventario"></param>
        //public DataSet Anterior(DStockInventario StockInventario)
        //{
        //    DataSet DsRpta = new DataSet();
        //    SqlConnection SqlConn = new SqlConnection();

        //    try
        //    {
        //        SqlConn.ConnectionString = DConexion.Cn;
        //        SqlConn.Open();

        //        SqlCommand Cmd = new SqlCommand
        //        {
        //            Connection = SqlConn,
        //            CommandText = "stockinventario_anterior",
        //            CommandType = CommandType.StoredProcedure,
        //        };

        //        SqlParameter Parcod_stockinventario = Getcod_stockinventario(StockInventario);
        //        Cmd.Parameters.Add(Parcod_stockinventario);

        //        Cmd.ExecuteNonQuery();
        //        SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
        //        SqlDat.Fill(DsRpta, "TbStockInventario");

        //    }
        //    catch (Exception Ex)
        //    {
        //        DsRpta = null;
        //        throw new Exception("Error al Ejecutar el procedimiento almacenado" + Ex.Message, Ex);
        //    }
        //    finally
        //    {
        //        SqlConn.Close();
        //    }
        //    return DsRpta;
        //}

        ///// <summary>
        ///// Procedimiento Listar Siguiente Datos
        ///// </summary>
        ///// <param name="Listar Siguiente StockInventario"></param>
        //public DataSet Siguiente(DStockInventario StockInventario)
        //{
        //    DataSet DsRpta = new DataSet();
        //    SqlConnection SqlConn = new SqlConnection();

        //    try
        //    {
        //        SqlConn.ConnectionString = DConexion.Cn;
        //        SqlConn.Open();

        //        SqlCommand Cmd = new SqlCommand
        //        {
        //            Connection = SqlConn,
        //            CommandText = "stockinventario_siguiente",
        //            CommandType = CommandType.StoredProcedure,
        //        };

        //        SqlParameter Parcod_stockinventario = Getcod_stockinventario(StockInventario);
        //        Cmd.Parameters.Add(Parcod_stockinventario);

        //        Cmd.ExecuteNonQuery();
        //        SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
        //        SqlDat.Fill(DsRpta, "TbStockInventario");

        //    }
        //    catch (Exception Ex)
        //    {
        //        DsRpta = null;
        //        throw new Exception("Error al Ejecutar el procedimiento almacenado" + Ex.Message, Ex);
        //    }
        //    finally
        //    {
        //        SqlConn.Close();
        //    }
        //    return DsRpta;
        //}

        ///// <summary>
        ///// Procedimiento Generar Codigo
        ///// </summary>
        ///// <param name="Generar Codigo"></param>
        ///// <return>Retorna el Codigo</return>
        //public string GenerarCod(DStockInventario StockInventario)
        //{
        //    SqlConnection SqlConn = new SqlConnection
        //    {
        //        ConnectionString = DConexion.Cn
        //    };

        //    SqlConn.Open();
        //    SqlCommand Cmd = new SqlCommand
        //    {
        //        Connection = SqlConn,
        //        CommandText = "stockinventario_generar_cod",
        //        CommandType = CommandType.StoredProcedure,
        //    };

        //    try
        //    {
        //        SqlParameter ParCod_stockinventario = new SqlParameter("@cod_stockinventario", SqlDbType.Int)
        //        {
        //            Direction = ParameterDirection.Output,
        //            Value = StockInventario.Dcod_stockinventario
        //        };
        //        Cmd.Parameters.Add(ParCod_stockinventario);

        //        if (Cmd.ExecuteNonQuery() == 0)
        //        {
        //            return Cmd.Parameters[ParCod_stockinventario.ToString()].Value.ToString();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string Resp = ex.Message;
        //    }
        //    finally
        //    {
        //        SqlConn.Close();
        //    }
        //    return Cmd.Parameters["@cod_stockinventario"].Value.ToString();
        //}
    }
}

