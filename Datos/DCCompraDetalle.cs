using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DCCompraDetalle
    {
        #region PARAMETROS
        public Object Dreng { get; set; }
        public Object Dcod_ccompra { get; set; }
        public Object Dcod_deposito { get; set; }
        public Object Dcod_articulo { get; set; }
        public Object Dcod_unidad { get; set; }
        public Object Dcod_impuesto { get; set; }
        public Object Doptipo { get; set; }
        public Object Dcantidad { get; set; }
        public Object Dequivalencia { get; set; }
        public Object Dmontound { get; set; }
        public Object Ddescuento { get; set; }
        public Object Ddescuentop { get; set; }
        public Object Dsubtotalund { get; set; }
        public Object Dmontoimp { get; set; }
        public Object Dtotalund { get; set; }
        public Object Drorigen { get; set; }

        private static SqlParameter Detreng(DCCompraDetalle CCompraDetalle)
        {
            SqlParameter Preng = new SqlParameter
            {
                ParameterName = "@reng",
                SqlDbType = SqlDbType.Int,
                Value = CCompraDetalle.Dreng
            };
            return Preng;
        }

        private static SqlParameter Detrorigen(DCCompraDetalle CCompraDetalle)
        {
            SqlParameter Prorigen = new SqlParameter
            {
                ParameterName = "@rorigen",
                SqlDbType = SqlDbType.Int,
                Value = CCompraDetalle.Drorigen
            };
            return Prorigen;
        }

        private static SqlParameter Detcod_ccompra(DCCompraDetalle CCompraDetalle)
        {
            SqlParameter Pcod_ccompra = new SqlParameter
            {
                ParameterName = "@cod_ccompra",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = CCompraDetalle.Dcod_ccompra
            };
            return Pcod_ccompra;
        }

        private static SqlParameter Detcod_deposito(DCCompraDetalle CCompraDetalle)
        {
            SqlParameter Pcod_deposito = new SqlParameter
            {
                ParameterName = "@cod_deposito",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = CCompraDetalle.Dcod_deposito
            };
            return Pcod_deposito;
        }

        private static SqlParameter Detcod_articulo(DCCompraDetalle CCompraDetalle)
        {
            SqlParameter Pcod_articulo = new SqlParameter
            {
                ParameterName = "@cod_articulo",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = CCompraDetalle.Dcod_articulo
            };
            return Pcod_articulo;
        }

        private static SqlParameter Detcod_unidad(DCCompraDetalle CCompraDetalle)
        {
            SqlParameter Pcod_unidad = new SqlParameter
            {
                ParameterName = "@cod_unidad",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = CCompraDetalle.Dcod_unidad
            };
            return Pcod_unidad;
        }

        private static SqlParameter Detcod_impuesto(DCCompraDetalle CCompraDetalle)
        {
            SqlParameter Pcod_impuesto = new SqlParameter
            {
                ParameterName = "@cod_impuesto",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = CCompraDetalle.Dcod_impuesto
            };
            return Pcod_impuesto;
        }

        private static SqlParameter Detoptipo(DCCompraDetalle CCompraDetalle)
        {
            SqlParameter Poptipo = new SqlParameter
            {
                ParameterName = "@optipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = CCompraDetalle.Doptipo
            };
            return Poptipo;
        }

        private static SqlParameter Detcantidad(DCCompraDetalle CCompraDetalle)
        {
            SqlParameter Pcantidad = new SqlParameter
            {
                ParameterName = "@cantidad",
                SqlDbType = SqlDbType.Decimal,
                Precision = 18,
                Scale = 3,
                Value = CCompraDetalle.Dcantidad
            };
            return Pcantidad;
        }

        private static SqlParameter Detequivalencia(DCCompraDetalle CCompraDetalle)
        {
            SqlParameter Pequivalencia = new SqlParameter
            {
                ParameterName = "@equivalencia",
                SqlDbType = SqlDbType.Decimal,
                Precision = 18,
                Scale = 3,
                Value = CCompraDetalle.Dequivalencia
            };
            return Pequivalencia;
        }

        private static SqlParameter Detmontound(DCCompraDetalle CCompraDetalle)
        {
            SqlParameter Pmontound = new SqlParameter
            {
                ParameterName = "@montound",
                SqlDbType = SqlDbType.Money,
                Value = CCompraDetalle.Dmontound
            };
            return Pmontound;
        }

        private static SqlParameter Detdescuento(DCCompraDetalle CCompraDetalle)
        {
            SqlParameter Pdescuento = new SqlParameter
            {
                ParameterName = "@descuento",
                SqlDbType = SqlDbType.Money,
                Value = CCompraDetalle.Ddescuento
            };
            return Pdescuento;
        }

        private static SqlParameter Detdescuentop(DCCompraDetalle CCompraDetalle)
        {
            SqlParameter Pdescuentop = new SqlParameter
            {
                ParameterName = "@descuentop",
                SqlDbType = SqlDbType.Money,
                Value = CCompraDetalle.Ddescuentop
            };
            return Pdescuentop;
        }

        private static SqlParameter Detsubtotalund(DCCompraDetalle CCompraDetalle)
        {
            SqlParameter Psubtotalund = new SqlParameter
            {
                ParameterName = "@subtotalund",
                SqlDbType = SqlDbType.Money,
                Value = CCompraDetalle.Dsubtotalund
            };
            return Psubtotalund;
        }

        private static SqlParameter Detmontoimp(DCCompraDetalle CCompraDetalle)
        {
            SqlParameter Pmontoimp = new SqlParameter
            {
                ParameterName = "@montoimp",
                SqlDbType = SqlDbType.Money,
                Value = CCompraDetalle.Dmontoimp
            };
            return Pmontoimp;
        }

        private static SqlParameter Detotalund(DCCompraDetalle CCompraDetalle)
        {
            SqlParameter Ptotalund = new SqlParameter
            {
                ParameterName = "@totalund",
                SqlDbType = SqlDbType.Money,
                Value = CCompraDetalle.Dtotalund
            };
            return Ptotalund;
        }
        #endregion

        public DCCompraDetalle()
        {

        }

        /// <summary>
        /// Metodo Mostrar
        /// </summary>
        public DataTable Mostrar(DCCompraDetalle CCompraDetalle)
        {
            DataTable DtRpta = new DataTable("TbCCompraDetalle");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlCon,
                    CommandText = "ccompradetalle_mostrar",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter Parcod_ccompra = Detcod_ccompra(CCompraDetalle);
                Cmd.Parameters.Add(Parcod_ccompra);

                Cmd.ExecuteNonQuery();

                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DtRpta);

            }

            catch (Exception ex)
            {
                DtRpta = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado " + ex.Message, ex);
            }

            finally
            {
                SqlCon.Close();
            }

            return DtRpta;
        }

        public string Insertar(DCCompraDetalle CCompraDetalle)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlCon,
                    CommandText = "ccompradetalle_insertar",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter Parcod_ccompra = Detcod_ccompra(CCompraDetalle);
                Cmd.Parameters.Add(Parcod_ccompra);

                SqlParameter Parcod_deposito = Detcod_deposito(CCompraDetalle);
                Cmd.Parameters.Add(Parcod_deposito);

                SqlParameter Parcod_articulo = Detcod_articulo(CCompraDetalle);
                Cmd.Parameters.Add(Parcod_articulo);

                SqlParameter Parcod_unidad = Detcod_unidad(CCompraDetalle);
                Cmd.Parameters.Add(Parcod_unidad);

                SqlParameter Parcod_impuesto = Detcod_impuesto(CCompraDetalle);
                Cmd.Parameters.Add(Parcod_impuesto);

                SqlParameter Paroptipo = Detoptipo(CCompraDetalle);
                Cmd.Parameters.Add(Paroptipo);

                SqlParameter Parcantidad = Detcantidad(CCompraDetalle);
                Cmd.Parameters.Add(Parcantidad);

                SqlParameter Parequivalencia = Detequivalencia(CCompraDetalle);
                Cmd.Parameters.Add(Parequivalencia);

                SqlParameter Parmontound = Detmontound(CCompraDetalle);
                Cmd.Parameters.Add(Parmontound);

                SqlParameter Pardescuento = Detdescuento(CCompraDetalle);
                Cmd.Parameters.Add(Pardescuento);

                SqlParameter Pardescuentop = Detdescuentop(CCompraDetalle);
                Cmd.Parameters.Add(Pardescuentop);

                SqlParameter Parsubtotalund = Detsubtotalund(CCompraDetalle);
                Cmd.Parameters.Add(Parsubtotalund);

                SqlParameter Parmontoimp = Detmontoimp(CCompraDetalle);
                Cmd.Parameters.Add(Parmontoimp);

                SqlParameter Partotalund = Detotalund(CCompraDetalle);
                Cmd.Parameters.Add(Partotalund);

                SqlParameter Parrorigen = Detrorigen(CCompraDetalle);
                Cmd.Parameters.Add(Parrorigen);

                Cmd.ExecuteNonQuery();
                Rpta = "Y";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 8152)
                {
                    Rpta = "Has introducido demasiados caracteres en uno de los campos.";
                }
                else if (ex.Number == 2627)
                {
                    Rpta = "No se Permiten Registros Duplicados";
                }
                else if (ex.Number == 2812)
                {
                    Rpta = "No Existe el Procedimiento Almacenado";
                }
                else
                {
                    Rpta = "Error al intentar ejecutar el procedimiento almacenado " + ex.Message;
                }
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return Rpta;
        }

        public string Eliminar(DCCompraDetalle CCompraDetalle)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlCon,
                    CommandText = "ccompradetalle_eliminar",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter Parreng = Detreng(CCompraDetalle);
                Cmd.Parameters.Add(Parreng);

                Cmd.ExecuteNonQuery();
                Rpta = "Y";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2812)
                {
                    Rpta = "No Existe el Procedimiento Almacenado";
                }
                else
                {
                    Rpta = "Error al intentar ejecutar el procedimiento almacenado " + ex.Message;
                }
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return Rpta;
        }

        public string Anular(DCCompraDetalle CCompraDetalle)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlCon,
                    CommandText = "ccompradetalle_anular",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter Parcod_ccompra = Detcod_ccompra(CCompraDetalle);
                Cmd.Parameters.Add(Parcod_ccompra);

                Cmd.ExecuteNonQuery();
                Rpta = "Y";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 8152)
                {
                    Rpta = "Has introducido demasiados caracteres en uno de los campos.";
                }
                else if (ex.Number == 2627)
                {
                    Rpta = "No se Permiten Registros Duplicados";
                }
                else if (ex.Number == 2812)
                {
                    Rpta = "No Existe el Procedimiento Almacenado";
                }
                else
                {
                    Rpta = "Error al intentar ejecutar el procedimiento almacenado " + ex.Message;
                }
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return Rpta;
        
        }

        public string Importar(DCCompraDetalle CCompraDetalle)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlCon,
                    CommandText = "ccompradetalle_importar",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter Parreng = Detreng(CCompraDetalle);
                Cmd.Parameters.Add(Parreng);

                Cmd.ExecuteNonQuery();
                Rpta = "Y";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 8152)
                {
                    Rpta = "Has introducido demasiados caracteres en uno de los campos.";
                }
                else if (ex.Number == 2627)
                {
                    Rpta = "No se Permiten Registros Duplicados";
                }
                else if (ex.Number == 2812)
                {
                    Rpta = "No Existe el Procedimiento Almacenado";
                }
                else
                {
                    Rpta = "Error al intentar ejecutar el procedimiento almacenado " + ex.Message;
                }
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return Rpta;
        }

        public string EliminarImportar(DCCompraDetalle CCompraDetalle)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlCon,
                    CommandText = "ccompradetalle_eliminarimportar",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter Parreng = Detreng(CCompraDetalle);
                Cmd.Parameters.Add(Parreng);

                Cmd.ExecuteNonQuery();
                Rpta = "Y";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2812)
                {
                    Rpta = "No Existe el Procedimiento Almacenado";
                }
                else
                {
                    Rpta = "Error al intentar ejecutar el procedimiento almacenado " + ex.Message;
                }
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return Rpta;
        }
    }
}
