using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DFCompraDetalle
    {
        #region PARAMETROS
        public Object Dreng { get; set; }
        public Object Dcod_fcompra { get; set; }
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
        public Object Destatus { get; set; }
        public Object Drorigen { get; set; }

        private static SqlParameter Detreng(DFCompraDetalle FCompraDetalle)
        {
            SqlParameter Preng = new SqlParameter
            {
                ParameterName = "@reng",
                SqlDbType = SqlDbType.Int,
                Value = FCompraDetalle.Dreng
            };
            return Preng;
        }

        private static SqlParameter Detrorigen(DFCompraDetalle FCompraDetalle)
        {
            SqlParameter Prorigen = new SqlParameter
            {
                ParameterName = "@rorigen",
                SqlDbType = SqlDbType.Int,
                Value = FCompraDetalle.Drorigen
            };
            return Prorigen;
        }

        private static SqlParameter Detcod_fcompra(DFCompraDetalle FCompraDetalle)
        {
            SqlParameter Pcod_fcompra = new SqlParameter
            {
                ParameterName = "@cod_fcompra",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = FCompraDetalle.Dcod_fcompra
            };
            return Pcod_fcompra;
        }

        private static SqlParameter Detcod_deposito(DFCompraDetalle FCompraDetalle)
        {
            SqlParameter Pcod_deposito = new SqlParameter
            {
                ParameterName = "@cod_deposito",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = FCompraDetalle.Dcod_deposito
            };
            return Pcod_deposito;
        }

        private static SqlParameter Detcod_articulo(DFCompraDetalle FCompraDetalle)
        {
            SqlParameter Pcod_articulo = new SqlParameter
            {
                ParameterName = "@cod_articulo",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = FCompraDetalle.Dcod_articulo
            };
            return Pcod_articulo;
        }

        private static SqlParameter Detcod_unidad(DFCompraDetalle FCompraDetalle)
        {
            SqlParameter Pcod_unidad = new SqlParameter
            {
                ParameterName = "@cod_unidad",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = FCompraDetalle.Dcod_unidad
            };
            return Pcod_unidad;
        }

        private static SqlParameter Detcod_impuesto(DFCompraDetalle FCompraDetalle)
        {
            SqlParameter Pcod_impuesto = new SqlParameter
            {
                ParameterName = "@cod_impuesto",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = FCompraDetalle.Dcod_impuesto
            };
            return Pcod_impuesto;
        }

        private static SqlParameter Detoptipo(DFCompraDetalle FCompraDetalle)
        {
            SqlParameter Poptipo = new SqlParameter
            {
                ParameterName = "@optipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = FCompraDetalle.Doptipo
            };
            return Poptipo;
        }

        private static SqlParameter Detcantidad(DFCompraDetalle FCompraDetalle)
        {
            SqlParameter Pcantidad = new SqlParameter
            {
                ParameterName = "@cantidad",
                SqlDbType = SqlDbType.Decimal,
                Precision = 18,
                Scale = 3,
                Value = FCompraDetalle.Dcantidad
            };
            return Pcantidad;
        }

        private static SqlParameter Detequivalencia(DFCompraDetalle FCompraDetalle)
        {
            SqlParameter Pequivalencia = new SqlParameter
            {
                ParameterName = "@equivalencia",
                SqlDbType = SqlDbType.Decimal,
                Precision = 18,
                Scale = 3,
                Value = FCompraDetalle.Dequivalencia
            };
            return Pequivalencia;
        }

        private static SqlParameter Detmontound(DFCompraDetalle FCompraDetalle)
        {
            SqlParameter Pmontound = new SqlParameter
            {
                ParameterName = "@montound",
                SqlDbType = SqlDbType.Money,
                Value = FCompraDetalle.Dmontound
            };
            return Pmontound;
        }

        private static SqlParameter Detdescuento(DFCompraDetalle FCompraDetalle)
        {
            SqlParameter Pdescuento = new SqlParameter
            {
                ParameterName = "@descuento",
                SqlDbType = SqlDbType.Money,
                Value = FCompraDetalle.Ddescuento
            };
            return Pdescuento;
        }

        private static SqlParameter Detdescuentop(DFCompraDetalle FCompraDetalle)
        {
            SqlParameter Pdescuentop = new SqlParameter
            {
                ParameterName = "@descuentop",
                SqlDbType = SqlDbType.Money,
                Value = FCompraDetalle.Ddescuentop
            };
            return Pdescuentop;
        }

        private static SqlParameter Detsubtotalund(DFCompraDetalle FCompraDetalle)
        {
            SqlParameter Psubtotalund = new SqlParameter
            {
                ParameterName = "@subtotalund",
                SqlDbType = SqlDbType.Money,
                Value = FCompraDetalle.Dsubtotalund
            };
            return Psubtotalund;
        }

        private static SqlParameter Detmontoimp(DFCompraDetalle FCompraDetalle)
        {
            SqlParameter Pmontoimp = new SqlParameter
            {
                ParameterName = "@montoimp",
                SqlDbType = SqlDbType.Money,
                Value = FCompraDetalle.Dmontoimp
            };
            return Pmontoimp;
        }

        private static SqlParameter Detotalund(DFCompraDetalle FCompraDetalle)
        {
            SqlParameter Ptotalund = new SqlParameter
            {
                ParameterName = "@totalund",
                SqlDbType = SqlDbType.Money,
                Value = FCompraDetalle.Dtotalund
            };
            return Ptotalund;
        }

        private static SqlParameter Detestatus(DFCompraDetalle FCompraDetalle)
        {
            SqlParameter Pestatus = new SqlParameter
            {
                ParameterName = "@estatus",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = FCompraDetalle.Destatus
            };
            return Pestatus;
        }
        #endregion

        public DFCompraDetalle()
        {

        }
        /// <summary>
        /// Metodo Mostrar
        /// </summary>
        public DataTable Mostrar(DFCompraDetalle FCompraDetalle)
        {
            DataTable DtRpta = new DataTable("TbFCompraDetalle");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlCon,
                    CommandText = "fcompradetalle_mostrar",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter Parcod_fcompra = Detcod_fcompra(FCompraDetalle);
                Cmd.Parameters.Add(Parcod_fcompra);

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

        public string Insertar(DFCompraDetalle FCompraDetalle)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand
                {
                    Connection = SqlCon,
                    CommandText = "fcompradetalle_insertar",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter Parcod_fcompra = Detcod_fcompra(FCompraDetalle);
                SqlCmd.Parameters.Add(Parcod_fcompra);

                SqlParameter Parcod_deposito = Detcod_deposito(FCompraDetalle);
                SqlCmd.Parameters.Add(Parcod_deposito);

                SqlParameter Parcod_articulo = Detcod_articulo(FCompraDetalle);
                SqlCmd.Parameters.Add(Parcod_articulo);

                SqlParameter Parcod_unidad = Detcod_unidad(FCompraDetalle);
                SqlCmd.Parameters.Add(Parcod_unidad);

                SqlParameter Parcod_impuesto = Detcod_impuesto(FCompraDetalle);
                SqlCmd.Parameters.Add(Parcod_impuesto);

                SqlParameter Paroptipo = Detoptipo(FCompraDetalle);
                SqlCmd.Parameters.Add(Paroptipo);

                SqlParameter Parcantidad = Detcantidad(FCompraDetalle);
                SqlCmd.Parameters.Add(Parcantidad);

                SqlParameter Parequivalencia = Detequivalencia(FCompraDetalle);
                SqlCmd.Parameters.Add(Parequivalencia);

                SqlParameter Parmontound = Detmontound(FCompraDetalle);
                SqlCmd.Parameters.Add(Parmontound);

                SqlParameter Pardescuento = Detdescuento(FCompraDetalle);
                SqlCmd.Parameters.Add(Pardescuento);

                SqlParameter Pardescuentop = Detdescuentop(FCompraDetalle);
                SqlCmd.Parameters.Add(Pardescuentop);

                SqlParameter Parsubtotalund = Detsubtotalund(FCompraDetalle);
                SqlCmd.Parameters.Add(Parsubtotalund);

                SqlParameter Parmontoimp = Detmontoimp(FCompraDetalle);
                SqlCmd.Parameters.Add(Parmontoimp);

                SqlParameter Partotalund = Detotalund(FCompraDetalle);
                SqlCmd.Parameters.Add(Partotalund);

                SqlParameter Parestatus = Detestatus(FCompraDetalle);
                SqlCmd.Parameters.Add(Parestatus);

                SqlParameter Parrorigen = Detrorigen(FCompraDetalle);
                SqlCmd.Parameters.Add(Parrorigen);

                SqlCmd.ExecuteNonQuery();
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

        public string Eliminar(DFCompraDetalle FCompraDetalle)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand
                {
                    Connection = SqlCon,
                    CommandText = "fcompradetalle_eliminar",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter Parreng = Detreng(FCompraDetalle);
                SqlCmd.Parameters.Add(Parreng);

                SqlCmd.ExecuteNonQuery();
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

        public string Anular(DFCompraDetalle FCompraDetalle)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand
                {
                    Connection = SqlCon,
                    CommandText = "fcompradetalle_anular",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter Parcod_pcompra = Detcod_fcompra(FCompraDetalle);
                SqlCmd.Parameters.Add(Parcod_pcompra);

                SqlCmd.ExecuteNonQuery();
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

        public string ProcesarDetalle(DFCompraDetalle FCompraDetalle)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand
                {
                    Connection = SqlCon,
                    CommandText = "fcompradetalle_procesar",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter Parreng = Detreng(FCompraDetalle);
                SqlCmd.Parameters.Add(Parreng);

                SqlParameter Parcod_deposito = Detcod_deposito(FCompraDetalle);
                SqlCmd.Parameters.Add(Parcod_deposito);

                SqlParameter Parcod_articulo = Detcod_articulo(FCompraDetalle);
                SqlCmd.Parameters.Add(Parcod_articulo);

                SqlParameter Parequivalencia = Detequivalencia(FCompraDetalle);
                SqlCmd.Parameters.Add(Parequivalencia);

                SqlCmd.ExecuteNonQuery();
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
    }
}
