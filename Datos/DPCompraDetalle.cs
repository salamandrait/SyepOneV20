using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DPCompraDetalle
    {
        #region PARAMETROS
        public Object Dreng { get; set; }
        public Object Dcod_pcompra { get; set; }
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

        private static SqlParameter Detreng(DPCompraDetalle PCompraDetalle)
        {
            SqlParameter Preng = new SqlParameter
            {
                ParameterName = "@reng",
                SqlDbType = SqlDbType.Int,
                Value = PCompraDetalle.Dreng
            };
            return Preng;
        }

        private static SqlParameter Detrorigen(DPCompraDetalle PCompraDetalle)
        {
            SqlParameter Prorigen = new SqlParameter
            {
                ParameterName = "@rorigen",
                SqlDbType = SqlDbType.Int,
                Value = PCompraDetalle.Drorigen
            };
            return Prorigen;
        }

        private static SqlParameter Detcod_pcompra(DPCompraDetalle PCompraDetalle)
        {
            SqlParameter Pcod_pcompra = new SqlParameter
            {
                ParameterName = "@cod_pcompra",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = PCompraDetalle.Dcod_pcompra
            };
            return Pcod_pcompra;
        }

        private static SqlParameter Detcod_deposito(DPCompraDetalle PCompraDetalle)
        {
            SqlParameter Pcod_deposito = new SqlParameter
            {
                ParameterName = "@cod_deposito",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = PCompraDetalle.Dcod_deposito
            };
            return Pcod_deposito;
        }

        private static SqlParameter Detcod_articulo(DPCompraDetalle PCompraDetalle)
        {
            SqlParameter Pcod_articulo = new SqlParameter
            {
                ParameterName = "@cod_articulo",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = PCompraDetalle.Dcod_articulo
            };
            return Pcod_articulo;
        }

        private static SqlParameter Detcod_unidad(DPCompraDetalle PCompraDetalle)
        {
            SqlParameter Pcod_unidad = new SqlParameter
            {
                ParameterName = "@cod_unidad",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = PCompraDetalle.Dcod_unidad
            };
            return Pcod_unidad;
        }

        private static SqlParameter Detcod_impuesto(DPCompraDetalle PCompraDetalle)
        {
            SqlParameter Pcod_impuesto = new SqlParameter
            {
                ParameterName = "@cod_impuesto",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = PCompraDetalle.Dcod_impuesto
            };
            return Pcod_impuesto;
        }

        private static SqlParameter Detoptipo(DPCompraDetalle PCompraDetalle)
        {
            SqlParameter Poptipo = new SqlParameter
            {
                ParameterName = "@optipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = PCompraDetalle.Doptipo
            };
            return Poptipo;
        }

        private static SqlParameter Detcantidad(DPCompraDetalle PCompraDetalle)
        {
            SqlParameter Pcantidad = new SqlParameter
            {
                ParameterName = "@cantidad",
                SqlDbType = SqlDbType.Decimal,
                Precision = 18,
                Scale = 3,
                Value = PCompraDetalle.Dcantidad
            };
            return Pcantidad;
        }

        private static SqlParameter Detequivalencia(DPCompraDetalle PCompraDetalle)
        {
            SqlParameter Pequivalencia = new SqlParameter
            {
                ParameterName = "@equivalencia",
                SqlDbType = SqlDbType.Decimal,
                Precision = 18,
                Scale = 3,
                Value = PCompraDetalle.Dequivalencia
            };
            return Pequivalencia;
        }

        private static SqlParameter Detmontound(DPCompraDetalle PCompraDetalle)
        {
            SqlParameter Pmontound = new SqlParameter
            {
                ParameterName = "@montound",
                SqlDbType = SqlDbType.Money,
                Value = PCompraDetalle.Dmontound
            };
            return Pmontound;
        }

        private static SqlParameter Detdescuento(DPCompraDetalle PCompraDetalle)
        {
            SqlParameter Pdescuento = new SqlParameter
            {
                ParameterName = "@descuento",
                SqlDbType = SqlDbType.Money,
                Value = PCompraDetalle.Ddescuento
            };
            return Pdescuento;
        }

        private static SqlParameter Detdescuentop(DPCompraDetalle PCompraDetalle)
        {
            SqlParameter Pdescuentop = new SqlParameter
            {
                ParameterName = "@descuentop",
                SqlDbType = SqlDbType.Money,
                Value = PCompraDetalle.Ddescuentop
            };
            return Pdescuentop;
        }

        private static SqlParameter Detsubtotalund(DPCompraDetalle PCompraDetalle)
        {
            SqlParameter Psubtotalund = new SqlParameter
            {
                ParameterName = "@subtotalund",
                SqlDbType = SqlDbType.Money,
                Value = PCompraDetalle.Dsubtotalund
            };
            return Psubtotalund;
        }

        private static SqlParameter Detmontoimp(DPCompraDetalle PCompraDetalle)
        {
            SqlParameter Pmontoimp = new SqlParameter
            {
                ParameterName = "@montoimp",
                SqlDbType = SqlDbType.Money,
                Value = PCompraDetalle.Dmontoimp
            };
            return Pmontoimp;
        }

        private static SqlParameter Dettotalund(DPCompraDetalle PCompraDetalle)
        {
            SqlParameter Ptotalund = new SqlParameter
            {
                ParameterName = "@totalund",
                SqlDbType = SqlDbType.Money,
                Value = PCompraDetalle.Dtotalund
            };
            return Ptotalund;
        }

        private static SqlParameter Detestatus(DPCompraDetalle PCompraDetalle)
        {
            SqlParameter Pestatus = new SqlParameter
            {
                ParameterName = "@estatus",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = PCompraDetalle.Destatus
            };
            return Pestatus;
        }
        #endregion

        public DPCompraDetalle()
        {

        }

        /// <summary>
        /// Metodo Mostrar
        /// </summary>
        public DataTable Mostrar(DPCompraDetalle PCompraDetalle)
        {
            DataTable DtRpta = new DataTable("TbPCompraDetalle");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlCon,
                    CommandText = "pcompradetalle_mostrar",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter Parcod_pcompra = Detcod_pcompra(PCompraDetalle);
                Cmd.Parameters.Add(Parcod_pcompra);

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

        public string Insertar(DPCompraDetalle PCompraDetalle)
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
                    CommandText = "pcompradetalle_insertar",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter Parcod_pcompra = Detcod_pcompra(PCompraDetalle);
                SqlCmd.Parameters.Add(Parcod_pcompra);

                SqlParameter Parcod_deposito = Detcod_deposito(PCompraDetalle);
                SqlCmd.Parameters.Add(Parcod_deposito);

                SqlParameter Parcod_articulo = Detcod_articulo(PCompraDetalle);
                SqlCmd.Parameters.Add(Parcod_articulo);

                SqlParameter Parcod_unidad = Detcod_unidad(PCompraDetalle);
                SqlCmd.Parameters.Add(Parcod_unidad);

                SqlParameter Parcod_impuesto = Detcod_impuesto(PCompraDetalle);
                SqlCmd.Parameters.Add(Parcod_impuesto);

                SqlParameter Paroptipo = Detoptipo(PCompraDetalle);
                SqlCmd.Parameters.Add(Paroptipo);

                SqlParameter Parcantidad = Detcantidad(PCompraDetalle);
                SqlCmd.Parameters.Add(Parcantidad);

                SqlParameter Parequivalencia = Detequivalencia(PCompraDetalle);
                SqlCmd.Parameters.Add(Parequivalencia);

                SqlParameter Parmontound = Detmontound(PCompraDetalle);
                SqlCmd.Parameters.Add(Parmontound);

                SqlParameter Pardescuento = Detdescuento(PCompraDetalle);
                SqlCmd.Parameters.Add(Pardescuento);

                SqlParameter Pardescuentop = Detdescuentop(PCompraDetalle);
                SqlCmd.Parameters.Add(Pardescuentop);

                SqlParameter Parsubtotalund = Detsubtotalund(PCompraDetalle);
                SqlCmd.Parameters.Add(Parsubtotalund);

                SqlParameter Parmontoimp = Detmontoimp(PCompraDetalle);
                SqlCmd.Parameters.Add(Parmontoimp);

                SqlParameter Partotalund = Dettotalund(PCompraDetalle);
                SqlCmd.Parameters.Add(Partotalund);

                SqlParameter Parrorigen = Detrorigen(PCompraDetalle);
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

        public string Eliminar(DPCompraDetalle PCompraDetalle)
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
                    CommandText = "pcompradetalle_eliminar",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter Parreng = Detreng(PCompraDetalle);
                SqlCmd.Parameters.Add(Parreng);

                SqlParameter Parcod_deposito = Detcod_deposito(PCompraDetalle);
                SqlCmd.Parameters.Add(Parcod_deposito);

                SqlParameter Parcod_articulo = Detcod_articulo(PCompraDetalle);
                SqlCmd.Parameters.Add(Parcod_articulo);

                SqlParameter Parequivalencia = Detequivalencia(PCompraDetalle);
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

        public string Anular(DPCompraDetalle PCompraDetalle)
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
                    CommandText = "pcompradetalle_anular",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter Parcod_pcompra = Detcod_pcompra(PCompraDetalle);
                SqlCmd.Parameters.Add(Parcod_pcompra);

                SqlParameter Parcod_deposito = Detcod_deposito(PCompraDetalle);
                SqlCmd.Parameters.Add(Parcod_deposito);

                SqlParameter Parcod_articulo = Detcod_articulo(PCompraDetalle);
                SqlCmd.Parameters.Add(Parcod_articulo);

                SqlParameter Parequivalencia = Detequivalencia(PCompraDetalle);
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

        public string Importar(DPCompraDetalle PCompraDetalle)
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
                    CommandText = "pcompradetalle_importar",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter Parreng = Detreng(PCompraDetalle);
                SqlCmd.Parameters.Add(Parreng);

                SqlParameter Parcod_deposito = Detcod_deposito(PCompraDetalle);
                SqlCmd.Parameters.Add(Parcod_deposito);

                SqlParameter Parcod_articulo = Detcod_articulo(PCompraDetalle);
                SqlCmd.Parameters.Add(Parcod_articulo);

                SqlParameter Parequivalencia = Detequivalencia(PCompraDetalle);
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

        public string EliminarImportar(DPCompraDetalle PCompraDetalle)
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
                    CommandText = "pcompradetalle_eliminarimportar",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter Parreng = Detreng(PCompraDetalle);
                SqlCmd.Parameters.Add(Parreng);

                SqlParameter Parcod_deposito = Detcod_deposito(PCompraDetalle);
                SqlCmd.Parameters.Add(Parcod_deposito);

                SqlParameter Parcod_articulo = Detcod_articulo(PCompraDetalle);
                SqlCmd.Parameters.Add(Parcod_articulo);

                SqlParameter Parequivalencia = Detequivalencia(PCompraDetalle);
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
