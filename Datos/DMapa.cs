using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DMapa
    {

        #region PARAMETROS
        public Object Dcod_mapa { get; set; }
        public Object Ddesc_mapa { get; set; }
        public Object Dainventario { get; set; }
        public Object Dacompras { get; set; }
        public Object Daventas { get; set; }
        public Object Dabanco { get; set; }
        public Object Daconfig { get; set; }

        public Object Dtsioperaciones { get; set; }
        public Object Dtsitablas { get; set; }
        public Object Dtsireportes { get; set; }
        public Object Dtscoperaciones { get; set; }
        public Object Dtsctablas { get; set; }
        public Object Dtscreportes { get; set; }
        public Object Dtsvoperaciones { get; set; }
        public Object Dtsvtablas { get; set; }
        public Object Dtsvreportes { get; set; }
        public Object Dtsboperaciones { get; set; }
        public Object Dtsbtablas { get; set; }
        public Object Dtsbreportes { get; set; }
        public Object Dtscfoperaciones { get; set; }
        public Object Dtscftablas { get; set; }
        public Object Dtscfreportes { get; set; }

        public Object Dbuscar { get; set; }
        public Object Dbuscard { get; set; }
        public Object Dbuscarh { get; set; }
        public Object Dbtipo { get; set; }


        private static SqlParameter Getcod_mapa(DMapa Mapa)
        {
            SqlParameter Pcod_mapa = new SqlParameter
            {
                ParameterName = "@cod_mapa",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Mapa.Dcod_mapa,
            };
            return Pcod_mapa;
        }

        private static SqlParameter Getdesc_mapa(DMapa Mapa)
        {
            SqlParameter Pdesc_mapa = new SqlParameter
            {
                ParameterName = "@desc_mapa",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Value = Mapa.Ddesc_mapa,
            };
            return Pdesc_mapa;
        }

        private static SqlParameter Getainventario(DMapa Mapa)
        {
            SqlParameter Painventario = new SqlParameter
            {
                ParameterName = "@ainventario",
                SqlDbType = SqlDbType.Bit,
                Value = Mapa.Dainventario,
            };
            return Painventario;
        }

        private static SqlParameter Getacompras(DMapa Mapa)
        {
            SqlParameter Pacompras = new SqlParameter
            {
                ParameterName = "@acompras",
                SqlDbType = SqlDbType.Bit,
                Value = Mapa.Dacompras,
            };
            return Pacompras;
        }

        private static SqlParameter Getaventas(DMapa Mapa)
        {
            SqlParameter Paventas = new SqlParameter
            {
                ParameterName = "@aventas",
                SqlDbType = SqlDbType.Bit,
                Value = Mapa.Daventas,
            };
            return Paventas;
        }

        private static SqlParameter Getabanco(DMapa Mapa)
        {
            SqlParameter Pabanco = new SqlParameter
            {
                ParameterName = "@abanco",
                SqlDbType = SqlDbType.Bit,
                Value = Mapa.Dabanco,
            };
            return Pabanco;
        }

        private static SqlParameter Getaconfig(DMapa Mapa)
        {
            SqlParameter Paconfig = new SqlParameter
            {
                ParameterName = "@aconfig",
                SqlDbType = SqlDbType.Bit,
                Value = Mapa.Daconfig,
            };
            return Paconfig;
        }

        private static SqlParameter Gettsioperaciones(DMapa Mapa)
        {
            SqlParameter Ptsioperaciones = new SqlParameter
            {
                ParameterName = "@tsioperaciones",
                SqlDbType = SqlDbType.Bit,
                Value = Mapa.Dtsioperaciones,
            };
            return Ptsioperaciones;
        }

        private static SqlParameter Gettsitablas(DMapa Mapa)
        {
            SqlParameter Ptsitablas = new SqlParameter
            {
                ParameterName = "@tsitablas",
                SqlDbType = SqlDbType.Bit,
                Value = Mapa.Dtsitablas,
            };
            return Ptsitablas;
        }

        private static SqlParameter Gettsireportes(DMapa Mapa)
        {
            SqlParameter Ptsireportes = new SqlParameter
            {
                ParameterName = "@tsireportes",
                SqlDbType = SqlDbType.Bit,
                Value = Mapa.Dtsireportes,
            };
            return Ptsireportes;
        }

        private static SqlParameter Gettscoperaciones(DMapa Mapa)
        {
            SqlParameter Ptscoperaciones = new SqlParameter
            {
                ParameterName = "@tscoperaciones",
                SqlDbType = SqlDbType.Bit,
                Value = Mapa.Dtscoperaciones,
            };
            return Ptscoperaciones;
        }

        private static SqlParameter Gettsctablas(DMapa Mapa)
        {
            SqlParameter Ptsctablas = new SqlParameter
            {
                ParameterName = "@tsctablas",
                SqlDbType = SqlDbType.Bit,
                Value = Mapa.Dtsctablas,
            };
            return Ptsctablas;
        }

        private static SqlParameter Gettscreportes(DMapa Mapa)
        {
            SqlParameter Ptscreportes = new SqlParameter
            {
                ParameterName = "@tscreportes",
                SqlDbType = SqlDbType.Bit,
                Value = Mapa.Dtscreportes,
            };
            return Ptscreportes;
        }

        private static SqlParameter Gettsvoperaciones(DMapa Mapa)
        {
            SqlParameter Ptsvoperaciones = new SqlParameter
            {
                ParameterName = "@tsvoperaciones",
                SqlDbType = SqlDbType.Bit,
                Value = Mapa.Dtsvoperaciones,
            };
            return Ptsvoperaciones;
        }

        private static SqlParameter Gettsvtablas(DMapa Mapa)
        {
            SqlParameter Ptsvtablas = new SqlParameter
            {
                ParameterName = "@tsvtablas",
                SqlDbType = SqlDbType.Bit,
                Value = Mapa.Dtsvtablas,
            };
            return Ptsvtablas;
        }

        private static SqlParameter Gettsvreportes(DMapa Mapa)
        {
            SqlParameter Ptsvreportes = new SqlParameter
            {
                ParameterName = "@tsvreportes",
                SqlDbType = SqlDbType.Bit,
                Value = Mapa.Dtsvreportes,
            };
            return Ptsvreportes;
        }

        private static SqlParameter Gettsboperaciones(DMapa Mapa)
        {
            SqlParameter Ptsboperaciones = new SqlParameter
            {
                ParameterName = "@tsboperaciones",
                SqlDbType = SqlDbType.Bit,
                Value = Mapa.Dtsboperaciones,
            };
            return Ptsboperaciones;
        }

        private static SqlParameter Gettsbtablas(DMapa Mapa)
        {
            SqlParameter Ptsbtablas = new SqlParameter
            {
                ParameterName = "@tsbtablas",
                SqlDbType = SqlDbType.Bit,
                Value = Mapa.Dtsbtablas,
            };
            return Ptsbtablas;
        }

        private static SqlParameter Gettsbreportes(DMapa Mapa)
        {
            SqlParameter Ptsbreportes = new SqlParameter
            {
                ParameterName = "@tsbreportes",
                SqlDbType = SqlDbType.Bit,
                Value = Mapa.Dtsbreportes,
            };
            return Ptsbreportes;
        }

        private static SqlParameter Gettscfoperaciones(DMapa Mapa)
        {
            SqlParameter Ptscfoperaciones = new SqlParameter
            {
                ParameterName = "@tscfoperaciones",
                SqlDbType = SqlDbType.Bit,
                Value = Mapa.Dtscfoperaciones,
            };
            return Ptscfoperaciones;
        }

        private static SqlParameter Gettscftablas(DMapa Mapa)
        {
            SqlParameter Ptscftablas = new SqlParameter
            {
                ParameterName = "@tscftablas",
                SqlDbType = SqlDbType.Bit,
                Value = Mapa.Dtscftablas,
            };
            return Ptscftablas;
        }

        private static SqlParameter Gettscfreportes(DMapa Mapa)
        {
            SqlParameter Ptscfreportes = new SqlParameter
            {
                ParameterName = "@tscfreportes",
                SqlDbType = SqlDbType.Bit,
                Value = Mapa.Dtscfreportes,
            };
            return Ptscfreportes;
        }

        private static SqlParameter Getbuscar(DMapa Mapa)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Mapa.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DMapa Mapa)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Mapa.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DMapa Mapa)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Mapa.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DMapa Mapa)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Mapa.Dbtipo,
            };
            return Pbtipo;
        }

        #endregion

        public DMapa()
        {
            /// Constructor Vacio
        }


        /// <summary>
        /// Tabla Mostrar No Recibe parametros y Muestra un DataTable
        /// </summary>
        /// <returns> No Recibe Parametros</returns>
        public DataTable Mostrar()
        {
            DataTable DtRpta = new DataTable("TbMapa");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "mapa_mostrar",
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
                    CommandText = "mapa_listar",
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
        public string Insertar(DMapa Mapa)
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
                    CommandText = "mapa_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_mapa = Getcod_mapa(Mapa);
                Cmd.Parameters.Add(Parcod_mapa);

                SqlParameter ParDesc_mapa = Getdesc_mapa(Mapa);
                Cmd.Parameters.Add(ParDesc_mapa);

                SqlParameter Parainventario = Getainventario(Mapa);
                Cmd.Parameters.Add(Parainventario);

                SqlParameter Paracompras = Getacompras(Mapa);
                Cmd.Parameters.Add(Paracompras);

                SqlParameter Paraventas = Getaventas(Mapa);
                Cmd.Parameters.Add(Paraventas);

                SqlParameter Parabanco = Getabanco(Mapa);
                Cmd.Parameters.Add(Parabanco);

                SqlParameter Paraconfig = Getaconfig(Mapa);
                Cmd.Parameters.Add(Paraconfig);

                SqlParameter Partsioperaciones = Gettsioperaciones(Mapa);
                Cmd.Parameters.Add(Partsioperaciones);

                SqlParameter Partsitablas = Gettsitablas(Mapa);
                Cmd.Parameters.Add(Partsitablas);

                SqlParameter Partsireportes = Gettsireportes(Mapa);
                Cmd.Parameters.Add(Partsireportes);

                SqlParameter Partscoperaciones = Gettscoperaciones(Mapa);
                Cmd.Parameters.Add(Partscoperaciones);

                SqlParameter Partsctablas = Gettsctablas(Mapa);
                Cmd.Parameters.Add(Partsctablas);

                SqlParameter Partscreportes = Gettscreportes(Mapa);
                Cmd.Parameters.Add(Partscreportes);

                SqlParameter Partsvoperaciones = Gettsvoperaciones(Mapa);
                Cmd.Parameters.Add(Partsvoperaciones);

                SqlParameter Partsvtablas = Gettsvtablas(Mapa);
                Cmd.Parameters.Add(Partsvtablas);

                SqlParameter Partsvreportes = Gettsvreportes(Mapa);
                Cmd.Parameters.Add(Partsvreportes);

                SqlParameter Partsboperaciones = Gettsboperaciones(Mapa);
                Cmd.Parameters.Add(Partsboperaciones);

                SqlParameter Partsbtablas = Gettsbtablas(Mapa);
                Cmd.Parameters.Add(Partsbtablas);

                SqlParameter Partsbreportes = Gettsbreportes(Mapa);
                Cmd.Parameters.Add(Partsbreportes);

                SqlParameter Partscfoperaciones = Gettscfoperaciones(Mapa);
                Cmd.Parameters.Add(Partscfoperaciones);

                SqlParameter Partscftablas = Gettscftablas(Mapa);
                Cmd.Parameters.Add(Partscftablas);

                SqlParameter Partscfreportes = Gettscfreportes(Mapa);
                Cmd.Parameters.Add(Partscfreportes);

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
        public string Editar(DMapa Mapa)
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
                    CommandText = "mapa_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_mapa = Getcod_mapa(Mapa);
                Cmd.Parameters.Add(Parcod_mapa);

                SqlParameter ParDesc_mapa = Getdesc_mapa(Mapa);
                Cmd.Parameters.Add(ParDesc_mapa);

                SqlParameter Parainventario = Getainventario(Mapa);
                Cmd.Parameters.Add(Parainventario);

                SqlParameter Paracompras = Getacompras(Mapa);
                Cmd.Parameters.Add(Paracompras);

                SqlParameter Paraventas = Getaventas(Mapa);
                Cmd.Parameters.Add(Paraventas);

                SqlParameter Parabanco = Getabanco(Mapa);
                Cmd.Parameters.Add(Parabanco);

                SqlParameter Paraconfig = Getaconfig(Mapa);
                Cmd.Parameters.Add(Paraconfig);

                SqlParameter Partsioperaciones = Gettsioperaciones(Mapa);
                Cmd.Parameters.Add(Partsioperaciones);

                SqlParameter Partsitablas = Gettsitablas(Mapa);
                Cmd.Parameters.Add(Partsitablas);

                SqlParameter Partsireportes = Gettsireportes(Mapa);
                Cmd.Parameters.Add(Partsireportes);

                SqlParameter Partscoperaciones = Gettscoperaciones(Mapa);
                Cmd.Parameters.Add(Partscoperaciones);

                SqlParameter Partsctablas = Gettsctablas(Mapa);
                Cmd.Parameters.Add(Partsctablas);

                SqlParameter Partscreportes = Gettscreportes(Mapa);
                Cmd.Parameters.Add(Partscreportes);

                SqlParameter Partsvoperaciones = Gettsvoperaciones(Mapa);
                Cmd.Parameters.Add(Partsvoperaciones);

                SqlParameter Partsvtablas = Gettsvtablas(Mapa);
                Cmd.Parameters.Add(Partsvtablas);

                SqlParameter Partsvreportes = Gettsvreportes(Mapa);
                Cmd.Parameters.Add(Partsvreportes);

                SqlParameter Partsboperaciones = Gettsboperaciones(Mapa);
                Cmd.Parameters.Add(Partsboperaciones);

                SqlParameter Partsbtablas = Gettsbtablas(Mapa);
                Cmd.Parameters.Add(Partsbtablas);

                SqlParameter Partsbreportes = Gettsbreportes(Mapa);
                Cmd.Parameters.Add(Partsbreportes);

                SqlParameter Partscfoperaciones = Gettscfoperaciones(Mapa);
                Cmd.Parameters.Add(Partscfoperaciones);

                SqlParameter Partscftablas = Gettscftablas(Mapa);
                Cmd.Parameters.Add(Partscftablas);

                SqlParameter Partscfreportes = Gettscfreportes(Mapa);
                Cmd.Parameters.Add(Partscfreportes);

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
        public string Eliminar(DMapa Mapa)
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
                    CommandText = "mapa_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_mapa = Getcod_mapa(Mapa);
                Cmd.Parameters.Add(Parcod_mapa);

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
        public DataTable Buscar(DMapa Mapa)
        {
            DataTable DtRpta = new DataTable("TbMapa");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "mapa_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(Mapa);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(Mapa);
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
        public DataTable RepBuscar(DMapa Mapa)
        {
            DataTable DtRpta = new DataTable("TbMapa");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "mapa_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(Mapa);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(Mapa);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(Mapa);
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
                    CommandText = "mapa_primero",
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
                    CommandText = "mapa_ultimo",
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
        /// <param name="Listar Anterior Mapa"></param>
        public DataSet Anterior(DMapa Mapa)
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
                    CommandText = "mapa_anterior",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_mapa = Getcod_mapa(Mapa);
                Cmd.Parameters.Add(Parcod_mapa);

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
        /// <param name="Listar Siguiente Mapa"></param>
        public DataSet Siguiente(DMapa Mapa)
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
                    CommandText = "mapa_siguiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_mapa = Getcod_mapa(Mapa);
                Cmd.Parameters.Add(Parcod_mapa);

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
        public string GenerarCod(DMapa Mapa)
        {
            SqlConnection SqlConn = new SqlConnection
            {
                ConnectionString = DConexion.Cn
            };

            SqlConn.Open();
            SqlCommand Cmd = new SqlCommand
            {
                Connection = SqlConn,
                CommandText = "mapa_generar_cod",
                CommandType = CommandType.StoredProcedure,
            };

            try
            {
                SqlParameter ParCod_mapa = new SqlParameter("@cod_mapa", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                    Value = Mapa.Dcod_mapa
                };
                Cmd.Parameters.Add(ParCod_mapa);

                if (Cmd.ExecuteNonQuery() == 0)
                {
                    return Cmd.Parameters[ParCod_mapa.ToString()].Value.ToString();
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
            return Cmd.Parameters["@cod_mapa"].Value.ToString();
        }
    }
}
