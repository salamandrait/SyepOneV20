using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DFCompra
    {

        #region PARAMETROS
        public Object Dcod_fcompra { get; set; }
        public Object Dcod_fcomprav { get; set; }
        public Object Dcod_proveedor { get; set; }
        public Object Dcod_condicionpago { get; set; }
        public Object Ddesc_fcompra { get; set; }
        public Object Doptipo { get; set; }
        public Object Dnumdocumento { get; set; }
        public Object Dnumcontrol { get; set; }
        public Object Ddoc_asociado { get; set; }
        public Object Dorigen { get; set; }
        public Object Destatus { get; set; }
        public Object Danulado { get; set; }
        public Object Dmonto_base { get; set; }
        public Object Dmonto_r { get; set; }
        public Object Dmonto_d { get; set; }
        public Object Dmonto_o { get; set; }
        public Object Dmonto_imp { get; set; }
        public Object Dsubtotal { get; set; }
        public Object Dtotal { get; set; }
        public Object Dfecha_doc { get; set; }
        public Object Dfecha_reg { get; set; }
        public Object Dfecha_ven { get; set; }
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


        private static SqlParameter Getcod_fcompra(DFCompra FCompra)
        {
            SqlParameter Pcod_fcompra = new SqlParameter
            {
                ParameterName = "@cod_fcompra",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = FCompra.Dcod_fcompra,
            };
            return Pcod_fcompra;
        }

        private static SqlParameter Getcod_fcomprav(DFCompra FCompra)
        {
            SqlParameter Pcod_fcomprav = new SqlParameter
            {
                ParameterName = "@cod_fcomprav",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = FCompra.Dcod_fcomprav,
            };
            return Pcod_fcomprav;
        }

        private static SqlParameter Getcod_proveedor(DFCompra FCompra)
        {
            SqlParameter Pcod_proveedor = new SqlParameter
            {
                ParameterName = "@cod_proveedor",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = FCompra.Dcod_proveedor,
            };
            return Pcod_proveedor;
        }

        private static SqlParameter Getcod_condicionpago(DFCompra FCompra)
        {
            SqlParameter Pcod_condicionpago = new SqlParameter
            {
                ParameterName = "@cod_condicionpago",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = FCompra.Dcod_condicionpago,
            };
            return Pcod_condicionpago;
        }

        private static SqlParameter Getdesc_fcompra(DFCompra FCompra)
        {
            SqlParameter Pdesc_fcompra = new SqlParameter
            {
                ParameterName = "@desc_fcompra",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = FCompra.Ddesc_fcompra,
            };
            return Pdesc_fcompra;
        }

        private static SqlParameter Getoptipo(DFCompra FCompra)
        {
            SqlParameter Poptipo = new SqlParameter
            {
                ParameterName = "@optipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = FCompra.Doptipo,
            };
            return Poptipo;
        }

        private static SqlParameter Getnumdocumento(DFCompra FCompra)
        {
            SqlParameter Pnumdocumento = new SqlParameter
            {
                ParameterName = "@numdocumento",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = FCompra.Dnumdocumento
            };
            return Pnumdocumento;
        }

        private static SqlParameter Getnumcontrol(DFCompra FCompra)
        {
            SqlParameter Pnumcontrol = new SqlParameter
            {
                ParameterName = "@numcontrol",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = FCompra.Dnumcontrol
            };
            return Pnumcontrol;
        }

        private static SqlParameter Getdoc_asociado(DFCompra FCompra)
        {
            SqlParameter Pdoc_asociado = new SqlParameter
            {
                ParameterName = "@doc_asociado",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = FCompra.Ddoc_asociado
            };
            return Pdoc_asociado;
        }

        private static SqlParameter Getorigen(DFCompra FCompra)
        {
            SqlParameter Porigen = new SqlParameter
            {
                ParameterName = "@origen",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = FCompra.Dorigen
            };
            return Porigen;
        }

        private static SqlParameter Getestatus(DFCompra FCompra)
        {
            SqlParameter Pestatus = new SqlParameter
            {
                ParameterName = "@estatus",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = FCompra.Destatus
            };
            return Pestatus;
        }

        private static SqlParameter Getanulado(DFCompra FCompra)
        {
            SqlParameter Panulado = new SqlParameter
            {
                ParameterName = "@anulado",
                SqlDbType = SqlDbType.Bit,
                Value = FCompra.Danulado
            };
            return Panulado;
        }

        private static SqlParameter Getmonto_base(DFCompra FCompra)
        {
            SqlParameter Pmonto_base = new SqlParameter
            {
                ParameterName = "@monto_base",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = FCompra.Dmonto_base
            };
            return Pmonto_base;
        }

        private static SqlParameter Getmonto_r(DFCompra FCompra)
        {
            SqlParameter Pmonto_r = new SqlParameter
            {
                ParameterName = "@monto_r",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = FCompra.Dmonto_r
            };
            return Pmonto_r;
        }

        private static SqlParameter Getmonto_d(DFCompra FCompra)
        {
            SqlParameter Pmonto_d = new SqlParameter
            {
                ParameterName = "@monto_d",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = FCompra.Dmonto_d
            };
            return Pmonto_d;
        }

        private static SqlParameter Getmonto_o(DFCompra FCompra)
        {
            SqlParameter Pmonto_o = new SqlParameter
            {
                ParameterName = "@monto_o",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = FCompra.Dmonto_o
            };
            return Pmonto_o;
        }

        private static SqlParameter Getmonto_imp(DFCompra FCompra)
        {
            SqlParameter Pmonto_imp = new SqlParameter
            {
                ParameterName = "@monto_imp",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = FCompra.Dmonto_imp
            };
            return Pmonto_imp;
        }

        private static SqlParameter Getsubtotal(DFCompra FCompra)
        {
            SqlParameter Psubtotal = new SqlParameter
            {
                ParameterName = "@subtotal",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = FCompra.Dsubtotal
            };
            return Psubtotal;
        }

        private static SqlParameter Gettotal(DFCompra FCompra)
        {
            SqlParameter Ptotal = new SqlParameter
            {
                ParameterName = "@total",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = FCompra.Dtotal
            };
            return Ptotal;
        }

        private static SqlParameter Getfecha_doc(DFCompra FCompra)
        {
            SqlParameter Pfecha_doc = new SqlParameter
            {
                ParameterName = "@fecha_doc",
                SqlDbType = SqlDbType.DateTime,
                Value = FCompra.Dfecha_doc
            };
            return Pfecha_doc;
        }

        private static SqlParameter Getfecha_reg(DFCompra FCompra)
        {
            SqlParameter Pfecha_reg = new SqlParameter
            {
                ParameterName = "@fecha_reg",
                SqlDbType = SqlDbType.DateTime,
                Value = FCompra.Dfecha_reg
            };
            return Pfecha_reg;
        }

        private static SqlParameter Getfecha_ven(DFCompra FCompra)
        {
            SqlParameter Pfecha_ven = new SqlParameter
            {
                ParameterName = "@fecha_ven",
                SqlDbType = SqlDbType.DateTime,
                Value = FCompra.Dfecha_ven
            };
            return Pfecha_ven;
        }

        private static SqlParameter Getcampo1(DFCompra FCompra)
        {
            SqlParameter Pcampo1 = new SqlParameter
            {
                ParameterName = "@campo1",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = FCompra.Dcampo1
            };
            return Pcampo1;
        }

        private static SqlParameter Getcampo2(DFCompra FCompra)
        {
            SqlParameter Pcampo2 = new SqlParameter
            {
                ParameterName = "@campo2",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = FCompra.Dcampo2
            };
            return Pcampo2;
        }

        private static SqlParameter Getcampo3(DFCompra FCompra)
        {
            SqlParameter Pcampo3 = new SqlParameter
            {
                ParameterName = "@campo3",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = FCompra.Dcampo3
            };
            return Pcampo3;
        }

        private static SqlParameter Getcampo4(DFCompra FCompra)
        {
            SqlParameter Pcampo4 = new SqlParameter
            {
                ParameterName = "@campo4",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = FCompra.Dcampo4
            };
            return Pcampo4;
        }

        private static SqlParameter Getcampo5(DFCompra FCompra)
        {
            SqlParameter Pcampo5 = new SqlParameter
            {
                ParameterName = "@campo5",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = FCompra.Dcampo5
            };
            return Pcampo5;
        }

        private static SqlParameter Getcampo6(DFCompra FCompra)
        {
            SqlParameter Pcampo6 = new SqlParameter
            {
                ParameterName = "@campo6",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = FCompra.Dcampo6
            };
            return Pcampo6;
        }

        private static SqlParameter Getcod_usuario(DFCompra FCompra)
        {
            SqlParameter Pcod_usuario = new SqlParameter
            {
                ParameterName = "@cod_usuario",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = FCompra.Dcod_usuario,
            };
            return Pcod_usuario;
        }

        private static SqlParameter Getbuscar(DFCompra FCompra)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = FCompra.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DFCompra FCompra)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = FCompra.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DFCompra FCompra)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = FCompra.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DFCompra FCompra)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = FCompra.Dbtipo,
            };
            return Pbtipo;
        }

        #endregion

        public DFCompra()
        {
            /// Constructor Vacio
        }

        /// <summary>
        /// Tabla Mostrar No Recibe parametros y Muestra un DataTable
        /// </summary>
        /// <returns> No Recibe Parametros</returns>
        public DataTable Mostrar()
        {
            DataTable DtRpta = new DataTable("TbFCompra");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "fcompra_mostrar",
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
                    CommandText = "fcompra_listar",
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
        public string Insertar(DFCompra FCompra)
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
                    CommandText = "fcompra_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_fcompra = Getcod_fcompra(FCompra);
                Cmd.Parameters.Add(Parcod_fcompra);

                SqlParameter Parcod_proveedor = Getcod_proveedor(FCompra);
                Cmd.Parameters.Add(Parcod_proveedor);

                SqlParameter Parcod_condicionpago = Getcod_condicionpago(FCompra);
                Cmd.Parameters.Add(Parcod_condicionpago);

                SqlParameter Pardesc_fcompra = Getdesc_fcompra(FCompra);
                Cmd.Parameters.Add(Pardesc_fcompra);

                SqlParameter Paroptipo = Getoptipo(FCompra);
                Cmd.Parameters.Add(Paroptipo);

                SqlParameter Parnumdocumento = Getnumdocumento(FCompra);
                Cmd.Parameters.Add(Parnumdocumento);

                SqlParameter Parnumcontrol = Getnumcontrol(FCompra);
                Cmd.Parameters.Add(Parnumcontrol);

                SqlParameter Pardoc_asociado = Getdoc_asociado(FCompra);
                Cmd.Parameters.Add(Pardoc_asociado);

                SqlParameter Parorigen = Getorigen(FCompra);
                Cmd.Parameters.Add(Parorigen);

                SqlParameter Parestatus = Getestatus(FCompra);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Paranulado = Getanulado(FCompra);
                Cmd.Parameters.Add(Paranulado);

                SqlParameter Parmonto_base = Getmonto_base(FCompra);
                Cmd.Parameters.Add(Parmonto_base);

                SqlParameter Parmonto_r = Getmonto_r(FCompra);
                Cmd.Parameters.Add(Parmonto_r);

                SqlParameter Parmonto_d = Getmonto_d(FCompra);
                Cmd.Parameters.Add(Parmonto_d);

                SqlParameter Parmonto_o = Getmonto_o(FCompra);
                Cmd.Parameters.Add(Parmonto_o);

                SqlParameter Parmonto_imp = Getmonto_imp(FCompra);
                Cmd.Parameters.Add(Parmonto_imp);

                SqlParameter Parsubtotal = Getsubtotal(FCompra);
                Cmd.Parameters.Add(Parsubtotal);

                SqlParameter Partotal = Gettotal(FCompra);
                Cmd.Parameters.Add(Partotal);

                SqlParameter Parfecha_doc = Getfecha_doc(FCompra);
                Cmd.Parameters.Add(Parfecha_doc);

                SqlParameter Parfecha_reg = Getfecha_reg(FCompra);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parfecha_ven = Getfecha_ven(FCompra);
                Cmd.Parameters.Add(Parfecha_ven);

                SqlParameter Parcampo1 = Getcampo1(FCompra);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(FCompra);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(FCompra);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(FCompra);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(FCompra);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(FCompra);
                Cmd.Parameters.Add(Parcampo6);

                SqlParameter Parcod_usuario = Getcod_usuario(FCompra);
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
                if (SqlConn.State == ConnectionState.Open) SqlConn.Close();
            }
            return Rpta;
        }

        /// <summary>
        /// Metodo Editar Datos Recibe 9 Parametros
        /// </summary>
        /// <returns> Recibe Parametros</returns>
        public string Editar(DFCompra FCompra)
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
                    CommandText = "fcompra_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_fcompra = Getcod_fcompra(FCompra);
                Cmd.Parameters.Add(Parcod_fcompra);

                SqlParameter Parcod_fcomprav = Getcod_fcomprav(FCompra);
                Cmd.Parameters.Add(Parcod_fcomprav);

                SqlParameter Parcod_proveedor = Getcod_proveedor(FCompra);
                Cmd.Parameters.Add(Parcod_proveedor);

                SqlParameter Parcod_condicionpago = Getcod_condicionpago(FCompra);
                Cmd.Parameters.Add(Parcod_condicionpago);

                SqlParameter Pardesc_fcompra = Getdesc_fcompra(FCompra);
                Cmd.Parameters.Add(Pardesc_fcompra);

                SqlParameter Paroptipo = Getoptipo(FCompra);
                Cmd.Parameters.Add(Paroptipo);

                SqlParameter Parnumdocumento = Getnumdocumento(FCompra);
                Cmd.Parameters.Add(Parnumdocumento);

                SqlParameter Parnumcontrol = Getnumcontrol(FCompra);
                Cmd.Parameters.Add(Parnumcontrol);

                SqlParameter Pardoc_asociado = Getdoc_asociado(FCompra);
                Cmd.Parameters.Add(Pardoc_asociado);

                SqlParameter Parorigen = Getorigen(FCompra);
                Cmd.Parameters.Add(Parorigen);

                SqlParameter Parestatus = Getestatus(FCompra);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Paranulado = Getanulado(FCompra);
                Cmd.Parameters.Add(Paranulado);

                SqlParameter Parmonto_base = Getmonto_base(FCompra);
                Cmd.Parameters.Add(Parmonto_base);

                SqlParameter Parmonto_r = Getmonto_r(FCompra);
                Cmd.Parameters.Add(Parmonto_r);

                SqlParameter Parmonto_d = Getmonto_d(FCompra);
                Cmd.Parameters.Add(Parmonto_d);

                SqlParameter Parmonto_o = Getmonto_o(FCompra);
                Cmd.Parameters.Add(Parmonto_o);

                SqlParameter Parmonto_imp = Getmonto_imp(FCompra);
                Cmd.Parameters.Add(Parmonto_imp);

                SqlParameter Parsubtotal = Getsubtotal(FCompra);
                Cmd.Parameters.Add(Parsubtotal);

                SqlParameter Partotal = Gettotal(FCompra);
                Cmd.Parameters.Add(Partotal);

                SqlParameter Parfecha_doc = Getfecha_doc(FCompra);
                Cmd.Parameters.Add(Parfecha_doc);

                SqlParameter Parfecha_reg = Getfecha_reg(FCompra);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parfecha_ven = Getfecha_ven(FCompra);
                Cmd.Parameters.Add(Parfecha_ven);

                SqlParameter Parcampo1 = Getcampo1(FCompra);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(FCompra);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(FCompra);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(FCompra);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(FCompra);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(FCompra);
                Cmd.Parameters.Add(Parcampo6);

                SqlParameter Parcod_usuario = Getcod_usuario(FCompra);
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
                if (SqlConn.State == ConnectionState.Open) SqlConn.Close();
            }
            return Rpta;
        }

        /// <summary>
        /// Metodo Eliminar Datos Recibe 1 Parametro
        /// </summary>
        /// <returns> Recibe Parametros</returns>
        public string Eliminar(DFCompra FCompra)
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
                    CommandText = "fcompra_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_fcompra = Getcod_fcompra(FCompra);
                Cmd.Parameters.Add(Parcod_fcompra);

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
        /// Metodo Anular Datos Recibe 4 Parametros
        /// </summary>
        /// <returns> Recibe 4 Parametros</returns>
        public string Anular(DFCompra FCompra)
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
                    CommandText = "fcompra_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_fcompra = Getcod_fcompra(FCompra);
                Cmd.Parameters.Add(Parcod_fcompra);

                SqlParameter Parestatus = Getestatus(FCompra);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Paranulado = Getanulado(FCompra);
                Cmd.Parameters.Add(Paranulado);

                SqlParameter Parcod_usuario = Getcod_usuario(FCompra);
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
                    Rpta = "No se Pueden Eliminar Registros Relacionados!  " + Exc.Message;
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
        /// Procedimiento Procesar
        /// </summary>
        /// <param name="Procesar FCompra"></param>
        public string Procesar(DFCompra FCompra)
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
                    CommandText = "fcompra_procesar",
                    CommandType = CommandType.StoredProcedure
                };
                #region ParametrosInsertar

                SqlParameter Parcod_fcompra = Getcod_fcompra(FCompra);
                Cmd.Parameters.Add(Parcod_fcompra);

                SqlParameter Parestatus = Getestatus(FCompra);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Parcod_usuario = Getcod_usuario(FCompra);
                Cmd.Parameters.Add(Parcod_usuario);
                #endregion

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

        /// <summary>
        /// Metodo Buscar Datos Recibe 2 Parametros
        /// </summary>
        public DataTable Buscar(DFCompra FCompra)
        {
            string Rpta = "";
            DataTable DtRpta = new DataTable("TbFCompra");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "fcompra_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(FCompra);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(FCompra);
                Cmd.Parameters.Add(Parbtipo);

                Cmd.ExecuteNonQuery();
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DtRpta);

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
                SqlConn.Close();
            }
            return DtRpta;
        }

        /// <summary>
        /// Procedimiento Buscar Datos Recibe 3 Parametros
        /// </summary>
        public DataTable RepBuscar(DFCompra FCompra)
        {
            DataTable DtRpta = new DataTable("TbFCompra");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "fcompra_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(FCompra);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(FCompra);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(FCompra);
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
                    CommandText = "fcompra_primero",
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
                    CommandText = "fcompra_ultimo",
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
        /// <param name="Listar Anterior FCompra"></param>
        public DataSet Anterior(DFCompra FCompra)
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
                    CommandText = "fcompra_anterior",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_fcompra = Getcod_fcompra(FCompra);
                Cmd.Parameters.Add(Parcod_fcompra);

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
        /// <param name="Listar Siguiente FCompra"></param>
        public DataSet Siguiente(DFCompra FCompra)
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
                    CommandText = "fcompra_siguiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_fcompra = Getcod_fcompra(FCompra);
                Cmd.Parameters.Add(Parcod_fcompra);

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
        public string GenerarCod(DFCompra FCompra)
        {
            SqlConnection SqlConn = new SqlConnection
            {
                ConnectionString = DConexion.Cn
            };

            SqlConn.Open();
            SqlCommand Cmd = new SqlCommand
            {
                Connection = SqlConn,
                CommandText = "fcompra_generarcod",
                CommandType = CommandType.StoredProcedure,
            };

            try
            {
                SqlParameter ParCod_fcompra = new SqlParameter("@cod_fcompra", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                    Value = FCompra.Dcod_fcompra
                };
                Cmd.Parameters.Add(ParCod_fcompra);

                if (Cmd.ExecuteNonQuery() == 0)
                {
                    return Cmd.Parameters[ParCod_fcompra.ToString()].Value.ToString();
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
            return Cmd.Parameters["@cod_fcompra"].Value.ToString();
        }
    }
}
