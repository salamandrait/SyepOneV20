using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DArtPrecio
    {
        #region PARAMETROS
        public Object Dcod_articulo { get; set; }
        public Object Dcod_precio { get; set; }
        public Object Dcod_deposito { get; set; }
        public Object Dcod_articulov { get; set; }
        public Object Dcod_preciov { get; set; }
        public Object Dcod_depositov { get; set; }
        public Object Dmonto { get; set; }
        public Object Dfecha_reg { get; set; }
        public Object Dfecha_venc { get; set; }
        public Object Dvenc_precio { get; set; }
        public Object Dbuscar { get; set; }
        public Object Dbuscard { get; set; }
        public Object Dbuscarh { get; set; }
        public Object Dbtipo { get; set; }


        private static SqlParameter Getcod_articulo(DArtPrecio ArtPrecio)
        {
            SqlParameter Pcod_articulo = new SqlParameter
            {
                ParameterName = "@cod_articulo",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = ArtPrecio.Dcod_articulo,
            };
            return Pcod_articulo;
        }

        private static SqlParameter Getcod_precio(DArtPrecio ArtPrecio)
        {
            SqlParameter Pcod_precio = new SqlParameter
            {
                ParameterName = "@cod_precio",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = ArtPrecio.Dcod_precio,
            };
            return Pcod_precio;
        }

        private static SqlParameter Getcod_deposito(DArtPrecio ArtPrecio)
        {
            SqlParameter Pcod_deposito = new SqlParameter
            {
                ParameterName = "@cod_deposito",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = ArtPrecio.Dcod_deposito,
            };
            return Pcod_deposito;
        }

        private static SqlParameter Getcod_articulov(DArtPrecio ArtPrecio)
        {
            SqlParameter Pcod_articulov = new SqlParameter
            {
                ParameterName = "@cod_articulov",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = ArtPrecio.Dcod_articulov,
            };
            return Pcod_articulov;
        }

        private static SqlParameter Getcod_preciov(DArtPrecio ArtPrecio)
        {
            SqlParameter Pcod_preciov = new SqlParameter
            {
                ParameterName = "@cod_preciov",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = ArtPrecio.Dcod_preciov,
            };
            return Pcod_preciov;
        }

        private static SqlParameter Getcod_depositov(DArtPrecio ArtPrecio)
        {
            SqlParameter Pcod_depositov = new SqlParameter
            {
                ParameterName = "@cod_depositov",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = ArtPrecio.Dcod_depositov,
            };
            return Pcod_depositov;
        }

        private static SqlParameter Getmonto(DArtPrecio ArtPrecio)
        {
            SqlParameter Pmonto = new SqlParameter
            {
                ParameterName = "@monto",
                SqlDbType = SqlDbType.Decimal,
                Scale = 3,
                Precision = 18,
                Value = ArtPrecio.Dmonto,
            };
            return Pmonto;
        }

        private static SqlParameter Getfecha_reg(DArtPrecio ArtPrecio)
        {
            SqlParameter Pfecha_reg = new SqlParameter
            {
                ParameterName = "@fecha_reg",
                SqlDbType = SqlDbType.DateTime,
                Value = ArtPrecio.Dfecha_reg,
            };
            return Pfecha_reg;
        }

        private static SqlParameter Getfecha_venc(DArtPrecio ArtPrecio)
        {
            SqlParameter Pfecha_venc = new SqlParameter
            {
                ParameterName = "@fecha_venc",
                SqlDbType = SqlDbType.DateTime,
                Value = ArtPrecio.Dfecha_venc,
            };
            return Pfecha_venc;
        }

        private static SqlParameter Getvenc_precio(DArtPrecio ArtPrecio)
        {
            SqlParameter Pvenc_precio = new SqlParameter
            {
                ParameterName = "@venc_precio",
                SqlDbType = SqlDbType.Bit,
                Value = ArtPrecio.Dvenc_precio,
            };
            return Pvenc_precio;
        }

        private static SqlParameter Getbuscar(DArtPrecio ArtPrecio)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = ArtPrecio.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DArtPrecio ArtPrecio)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = ArtPrecio.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DArtPrecio ArtPrecio)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = ArtPrecio.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DArtPrecio ArtPrecio)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = ArtPrecio.Dbtipo,
            };
            return Pbtipo;
        }

        #endregion

        public DArtPrecio()
        {
            /// Constructor Vacio
        }

        /// <summary>
        /// Tabla Mostrar No Recibe parametros
        /// </summary>
        /// <returns> 0 Parametros</returns>
        public DataTable Mostrar(DArtPrecio ArtPrecio)
        {
            DataTable DtRpta = new DataTable("TbArtPrecio");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "artprecio_mostrar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_articulo = Getcod_articulo(ArtPrecio);
                Cmd.Parameters.Add(Parcod_articulo);

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
        public DataTable Mostrar_Precio_Venta(DArtPrecio ArtPrecio)
        {
            DataTable DtRpta = new DataTable("TbArtPrecio");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "artprecio_mostrar_venta",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_articulo = Getcod_articulo(ArtPrecio);
                Cmd.Parameters.Add(Parcod_articulo);

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
        public DataTable Seleccionar_Precio_Venta(DArtPrecio ArtPrecio)
        {
            DataTable DtRpta = new DataTable("TbArtPrecio");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "artprecio_seleccionar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_articulo = Getcod_articulo(ArtPrecio);
                Cmd.Parameters.Add(Parcod_articulo);

                SqlParameter Parcod_deposito = Getcod_deposito(ArtPrecio);
                Cmd.Parameters.Add(Parcod_deposito);

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
                    CommandText = "artprecio_listar",
                    CommandType = CommandType.StoredProcedure,
                };

                Cmd.ExecuteNonQuery();
                SqlDataAdapter Dat = new SqlDataAdapter(Cmd);
                Dat.Fill(DsRpta, "TbArtPrecio");

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
        public string Insertar(DArtPrecio ArtPrecio)
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
                    CommandText = "artprecio_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_articulo = Getcod_articulo(ArtPrecio);
                Cmd.Parameters.Add(Parcod_articulo);

                SqlParameter Parcod_precio = Getcod_precio(ArtPrecio);
                Cmd.Parameters.Add(Parcod_precio);

                SqlParameter Parcod_deposito = Getcod_deposito(ArtPrecio);
                Cmd.Parameters.Add(Parcod_deposito);

                SqlParameter Parmonto = Getmonto(ArtPrecio);
                Cmd.Parameters.Add(Parmonto);

                SqlParameter Parfecha_reg = Getfecha_reg(ArtPrecio);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parfecha_venc = Getfecha_venc(ArtPrecio);
                Cmd.Parameters.Add(Parfecha_venc);

                SqlParameter Parvenc_precio = Getvenc_precio(ArtPrecio);
                Cmd.Parameters.Add(Parvenc_precio);

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
        public string Editar(DArtPrecio ArtPrecio)
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
                    CommandText = "artprecio_editar",
                    CommandType = CommandType.StoredProcedure,
                };


                SqlParameter Parcod_articulo = Getcod_articulo(ArtPrecio);
                Cmd.Parameters.Add(Parcod_articulo);

                SqlParameter Parcod_precio = Getcod_precio(ArtPrecio);
                Cmd.Parameters.Add(Parcod_precio);

                SqlParameter Parcod_deposito = Getcod_deposito(ArtPrecio);
                Cmd.Parameters.Add(Parcod_deposito);

                SqlParameter Parcod_articulov = Getcod_articulov(ArtPrecio);
                Cmd.Parameters.Add(Parcod_articulov);

                SqlParameter Parcod_preciov = Getcod_preciov(ArtPrecio);
                Cmd.Parameters.Add(Parcod_preciov);

                SqlParameter Parcod_depositov = Getcod_depositov(ArtPrecio);
                Cmd.Parameters.Add(Parcod_depositov);

                SqlParameter Parmonto = Getmonto(ArtPrecio);
                Cmd.Parameters.Add(Parmonto);

                SqlParameter Parfecha_reg = Getfecha_reg(ArtPrecio);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parfecha_venc = Getfecha_venc(ArtPrecio);
                Cmd.Parameters.Add(Parfecha_venc);

                SqlParameter Parvenc_precio = Getvenc_precio(ArtPrecio);
                Cmd.Parameters.Add(Parvenc_precio);

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
        public string Eliminar(DArtPrecio ArtPrecio)
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
                    CommandText = "artprecio_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_articulo = Getcod_articulo(ArtPrecio);
                Cmd.Parameters.Add(Parcod_articulo);

                SqlParameter Parcod_precio = Getcod_precio(ArtPrecio);
                Cmd.Parameters.Add(Parcod_precio);

                SqlParameter Parcod_deposito = Getcod_deposito(ArtPrecio);
                Cmd.Parameters.Add(Parcod_deposito);

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
        public DataTable Buscar(DArtPrecio ArtPrecio)
        {
            DataTable DtRpta = new DataTable("TbArtPrecio");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "artprecio_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(ArtPrecio);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(ArtPrecio);
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
        public DataTable RepBuscar(DArtPrecio ArtPrecio)
        {
            DataTable DtRpta = new DataTable("TbArtPrecio");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "artprecio_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(ArtPrecio);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(ArtPrecio);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(ArtPrecio);
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

    }
}

