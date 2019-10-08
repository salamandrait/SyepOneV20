using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DArtUnidad
    {
        #region Parametros
        public Object Dcod_articulo { get; set; }
        public Object Dcod_articulov { get; set; }
        public Object Dcod_unidad { get; set; }
        public Object Dcod_unidadv { get; set; }
        public Object Ddesc_unidad { get; set; }
        public Object Dequivalencia { get; set; }
        public Object Desprincipal { get; set; }
        public Object Dfecha_reg { get; set; }


        private static SqlParameter Getcod_articulo(DArtUnidad ArtUnidad)
        {
            SqlParameter Pcod_articulo = new SqlParameter
            {
                ParameterName = "@cod_articulo",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = ArtUnidad.Dcod_articulo,
            };
            return Pcod_articulo;
        }

        private static SqlParameter Getcod_articulov(DArtUnidad ArtUnidad)
        {
            SqlParameter Pcod_articulov = new SqlParameter
            {
                ParameterName = "@cod_articulov",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = ArtUnidad.Dcod_articulov,
            };
            return Pcod_articulov;
        }

        private static SqlParameter Getcod_unidad(DArtUnidad ArtUnidad)
        {
            SqlParameter Pcod_unidad = new SqlParameter
            {
                ParameterName = "@cod_unidad",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = ArtUnidad.Dcod_unidad,
            };
            return Pcod_unidad;
        }

        private static SqlParameter Getcod_unidadv(DArtUnidad ArtUnidad)
        {
            SqlParameter Pcod_unidadv = new SqlParameter
            {
                ParameterName = "@cod_unidadv",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = ArtUnidad.Dcod_unidadv,
            };
            return Pcod_unidadv;
        }

        private static SqlParameter Getdesc_unidad(DArtUnidad ArtUnidad)
        {
            SqlParameter Pdesc_unidad = new SqlParameter
            {
                ParameterName = "@desc_unidad",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = ArtUnidad.Ddesc_unidad,
            };
            return Pdesc_unidad;
        }

        private static SqlParameter Getequivalencia(DArtUnidad ArtUnidad)
        {
            SqlParameter Pequivalencia = new SqlParameter
            {
                ParameterName = "@equivalencia",
                SqlDbType = SqlDbType.Decimal,
                Precision = 18,
                Scale = 3,
                Value = ArtUnidad.Dequivalencia,
            };
            return Pequivalencia;
        }

        private static SqlParameter Getesprincipal(DArtUnidad ArtUnidad)
        {
            SqlParameter Pesprincipal = new SqlParameter
            {
                ParameterName = "@esprincipal",
                SqlDbType = SqlDbType.Bit,
                Value = ArtUnidad.Desprincipal,
            };
            return Pesprincipal;
        }

        private static SqlParameter Getfecha_reg(DArtUnidad ArtUnidad)
        {
            SqlParameter Pfecha_reg = new SqlParameter
            {
                ParameterName = "@fecha_reg",
                SqlDbType = SqlDbType.DateTime,
                Value = ArtUnidad.Dfecha_reg,
            };
            return Pfecha_reg;
        }
 
        #endregion

        public DArtUnidad()
        {
        }

        /// <summary>
        /// Procedimiento Mostrar Datos
        /// </summary>
        /// <param name="Mostrar ArtUnidad"></param>
        public DataTable Mostrar(DArtUnidad ArtUnidad)
        {
            DataTable DtRpta = new DataTable("TbArtUnidad");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection=SqlConn,
                    CommandText= "artunidad_mostrar",
                    CommandType= CommandType.StoredProcedure,
                };

                SqlParameter Parcod_articulo = Getcod_articulo(ArtUnidad);
                Cmd.Parameters.Add(Parcod_articulo);

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
        /// Procedimiento Listar Datos
        /// </summary>
        /// <param name="Listar ArtUnidad"></param>
        public DataTable Listar()
        {
            DataTable DtRpta = new DataTable("TbArtUnidad");
            SqlConnection SqlConn = new SqlConnection();
            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "artunidad_listar",
                    CommandType = CommandType.StoredProcedure,
                };

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
        /// Procedimiento Listar Datos
        /// </summary>
        /// <param name="Listar ArtUnidad"></param>
        public DataSet SeleccionarUnidad(DArtUnidad ArtUnidad)
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
                    CommandText = "artunidad_seleccionar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_articulo = Getcod_articulo(ArtUnidad);
                Cmd.Parameters.Add(Parcod_articulo);

                SqlParameter Pardesc_unidad = Getdesc_unidad(ArtUnidad);
                Cmd.Parameters.Add(Pardesc_unidad);



                Cmd.ExecuteNonQuery();
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DsRpta, "TbArtUnidad");

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
        /// Procedimiento Insertar Datos
        /// </summary>
        /// <param name="Insertar ArtUnidad"></param>
        public string Insertar(DArtUnidad ArtUnidad)
        {
            string Rpta = "";
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection= SqlConn,
                    CommandText="artunidad_insertar",
                    CommandType=CommandType.StoredProcedure,
                };

                SqlParameter Parcod_articulo = Getcod_articulo(ArtUnidad);
                Cmd.Parameters.Add(Parcod_articulo);

                SqlParameter Parcod_unidad = Getcod_unidad(ArtUnidad);
                Cmd.Parameters.Add(Parcod_unidad);

                SqlParameter Parequivalencia = Getequivalencia(ArtUnidad);
                Cmd.Parameters.Add(Parequivalencia);

                SqlParameter Parprincipal = Getesprincipal(ArtUnidad);
                Cmd.Parameters.Add(Parprincipal);

                SqlParameter Parfecha_reg = Getfecha_reg(ArtUnidad);
                Cmd.Parameters.Add(Parfecha_reg);

                Cmd.ExecuteNonQuery();
                Rpta = "Y";
            }
            catch (SqlException Ex)
            {
                if (Ex.Number == 8152)
                {
                    Rpta = "Ha introduccod_o demasiados caracteres en uno de los campos.";
                }
                else if (Ex.Number == 2627)
                {
                    Rpta = "El Codigo Ya Existe. No se Permiten Registros Duplicados.";
                }
                else if (Ex.Number == 2812)
                {
                    Rpta = "No Existe el Procedimiento Almacenado";
                }
                else
                {
                    Rpta = "Error al intentar ejecutar el procedimiento almacenado " + Ex.Message;
                }
            }
            finally
            {
                SqlConn.Close();
            }
            return Rpta;
        }

        /// <summary>
        /// Procedimiento Editar Datos
        /// </summary>
        /// <param name="Editar ArtUnidad"></param>
        public string Editar(DArtUnidad ArtUnidad)
        {
            string Rpta = "";
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "artunidad_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_articulo = Getcod_articulo(ArtUnidad);
                Cmd.Parameters.Add(Parcod_articulo);

                SqlParameter Parcod_articulov = Getcod_articulov(ArtUnidad);
                Cmd.Parameters.Add(Parcod_articulov);

                SqlParameter Parcod_unidad = Getcod_unidad(ArtUnidad);
                Cmd.Parameters.Add(Parcod_unidad);

                SqlParameter Parcod_unidadv = Getcod_unidadv(ArtUnidad);
                Cmd.Parameters.Add(Parcod_unidadv);

                SqlParameter Parequivalencia = Getequivalencia(ArtUnidad);
                Cmd.Parameters.Add(Parequivalencia);

                SqlParameter Parprincipal = Getesprincipal(ArtUnidad);
                Cmd.Parameters.Add(Parprincipal);

                SqlParameter Parfecha_reg = Getfecha_reg(ArtUnidad);
                Cmd.Parameters.Add(Parfecha_reg);

                Cmd.ExecuteNonQuery();
                Rpta = "Y";
            }
            catch (SqlException Ex)
            {
                if (Ex.Number == 8152)
                {
                    Rpta = "Ha introduccod_o demasiados caracteres en uno de los campos.";
                }
                else if (Ex.Number == 2627)
                {
                    Rpta = "El Codigo Ya Existe. No se Permiten Registros Duplicados.";
                }
                else if (Ex.Number == 2812)
                {
                    Rpta = "No Existe el Procedimiento Almacenado";
                }
                else
                {
                    Rpta = "Error al intentar ejecutar el procedimiento almacenado " + Ex.Message;
                }
            }
            finally
            {
                SqlConn.Close();
            }
            return Rpta;
        }

        /// <summary>
        /// Procedimiento Eliminar Datos
        /// </summary>
        /// <param name="Eliminar ArtUnidad"></param>
        public string Eliminar(DArtUnidad ArtUnidad)
        {
            string Rpta = "";
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "artunidad_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_articulo = Getcod_articulo(ArtUnidad);
                Cmd.Parameters.Add(Parcod_articulo);

                SqlParameter Parcod_unidad = Getcod_unidad(ArtUnidad);
                Cmd.Parameters.Add(Parcod_unidad);

                Cmd.ExecuteNonQuery();
                Rpta = "Y";
            }
            catch (SqlException Ex)
            {
                if (Ex.Number == 2812)
                {
                    Rpta = "No Existe el Procedimiento Almacenado";
                }
                else
                {
                    Rpta = "Error al intentar ejecutar el procedimiento almacenado " + Ex.Message;
                }
            }
            finally
            {
                SqlConn.Close();
            }
            return Rpta;
        }

    }
}
