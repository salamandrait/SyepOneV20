using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DCCompra
    {

        #region PARAMETROS
        public Object Dcod_ccompra { get; set; }
        public Object Dcod_ccomprav { get; set; }
        public Object Dcod_proveedor { get; set; }
        public Object Dcod_condicionpago { get; set; }
        public Object Ddesc_ccompra { get; set; }
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


        private static SqlParameter Getcod_ccompra(DCCompra CCompra)
        {
            SqlParameter Pcod_ccompra = new SqlParameter
            {
                ParameterName = "@cod_ccompra",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = CCompra.Dcod_ccompra,
            };
            return Pcod_ccompra;
        }

        private static SqlParameter Getcod_ccomprav(DCCompra CCompra)
        {
            SqlParameter Pcod_ccomprav = new SqlParameter
            {
                ParameterName = "@cod_ccomprav",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = CCompra.Dcod_ccomprav,
            };
            return Pcod_ccomprav;
        }

        private static SqlParameter Getcod_proveedor(DCCompra CCompra)
        {
            SqlParameter Pcod_proveedor = new SqlParameter
            {
                ParameterName = "@cod_proveedor",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = CCompra.Dcod_proveedor,
            };
            return Pcod_proveedor;
        }

        private static SqlParameter Getcod_condicionpago(DCCompra CCompra)
        {
            SqlParameter Pcod_condicionpago = new SqlParameter
            {
                ParameterName = "@cod_condicionpago",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = CCompra.Dcod_condicionpago,
            };
            return Pcod_condicionpago;
        }

        private static SqlParameter Getdesc_ccompra(DCCompra CCompra)
        {
            SqlParameter Pdesc_ccompra = new SqlParameter
            {
                ParameterName = "@desc_ccompra",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = CCompra.Ddesc_ccompra,
            };
            return Pdesc_ccompra;
        }

        private static SqlParameter Getoptipo(DCCompra CCompra)
        {
            SqlParameter Poptipo = new SqlParameter
            {
                ParameterName = "@optipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = CCompra.Doptipo,
            };
            return Poptipo;
        }

        private static SqlParameter Getnumdocumento(DCCompra CCompra)
        {
            SqlParameter Pnumdocumento = new SqlParameter
            {
                ParameterName = "@numdocumento",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = CCompra.Dnumdocumento
            };
            return Pnumdocumento;
        }

        private static SqlParameter Getnumcontrol(DCCompra CCompra)
        {
            SqlParameter Pnumcontrol = new SqlParameter
            {
                ParameterName = "@numcontrol",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = CCompra.Dnumcontrol
            };
            return Pnumcontrol;
        }

        private static SqlParameter Getdoc_asociado(DCCompra CCompra)
        {
            SqlParameter Pdoc_asociado = new SqlParameter
            {
                ParameterName = "@doc_asociado",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = CCompra.Ddoc_asociado
            };
            return Pdoc_asociado;
        }

        private static SqlParameter Getorigen(DCCompra CCompra)
        {
            SqlParameter Porigen = new SqlParameter
            {
                ParameterName = "@origen",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = CCompra.Dorigen
            };
            return Porigen;
        }

        private static SqlParameter Getestatus(DCCompra CCompra)
        {
            SqlParameter Pestatus = new SqlParameter
            {
                ParameterName = "@estatus",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = CCompra.Destatus
            };
            return Pestatus;
        }

        private static SqlParameter Getanulado(DCCompra CCompra)
        {
            SqlParameter Panulado = new SqlParameter
            {
                ParameterName = "@anulado",
                SqlDbType = SqlDbType.Bit,
                Value = CCompra.Danulado
            };
            return Panulado;
        }

        private static SqlParameter Getmonto_base(DCCompra CCompra)
        {
            SqlParameter Pmonto_base = new SqlParameter
            {
                ParameterName = "@monto_base",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = CCompra.Dmonto_base
            };
            return Pmonto_base;
        }

        private static SqlParameter Getmonto_r(DCCompra CCompra)
        {
            SqlParameter Pmonto_r = new SqlParameter
            {
                ParameterName = "@monto_r",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = CCompra.Dmonto_r
            };
            return Pmonto_r;
        }

        private static SqlParameter Getmonto_d(DCCompra CCompra)
        {
            SqlParameter Pmonto_d = new SqlParameter
            {
                ParameterName = "@monto_d",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = CCompra.Dmonto_d
            };
            return Pmonto_d;
        }

        private static SqlParameter Getmonto_o(DCCompra CCompra)
        {
            SqlParameter Pmonto_o = new SqlParameter
            {
                ParameterName = "@monto_o",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = CCompra.Dmonto_o
            };
            return Pmonto_o;
        }

        private static SqlParameter Getmonto_imp(DCCompra CCompra)
        {
            SqlParameter Pmonto_imp = new SqlParameter
            {
                ParameterName = "@monto_imp",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = CCompra.Dmonto_imp
            };
            return Pmonto_imp;
        }

        private static SqlParameter Getsubtotal(DCCompra CCompra)
        {
            SqlParameter Psubtotal = new SqlParameter
            {
                ParameterName = "@subtotal",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = CCompra.Dsubtotal
            };
            return Psubtotal;
        }

        private static SqlParameter Gettotal(DCCompra CCompra)
        {
            SqlParameter Ptotal = new SqlParameter
            {
                ParameterName = "@total",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = CCompra.Dtotal
            };
            return Ptotal;
        }

        private static SqlParameter Getfecha_doc(DCCompra CCompra)
        {
            SqlParameter Pfecha_doc = new SqlParameter
            {
                ParameterName = "@fecha_doc",
                SqlDbType = SqlDbType.DateTime,
                Value = CCompra.Dfecha_doc
            };
            return Pfecha_doc;
        }

        private static SqlParameter Getfecha_reg(DCCompra CCompra)
        {
            SqlParameter Pfecha_reg = new SqlParameter
            {
                ParameterName = "@fecha_reg",
                SqlDbType = SqlDbType.DateTime,
                Value = CCompra.Dfecha_reg
            };
            return Pfecha_reg;
        }

        private static SqlParameter Getfecha_ven(DCCompra CCompra)
        {
            SqlParameter Pfecha_ven = new SqlParameter
            {
                ParameterName = "@fecha_ven",
                SqlDbType = SqlDbType.DateTime,
                Value = CCompra.Dfecha_ven
            };
            return Pfecha_ven;
        }

        private static SqlParameter Getcampo1(DCCompra CCompra)
        {
            SqlParameter Pcampo1 = new SqlParameter
            {
                ParameterName = "@campo1",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = CCompra.Dcampo1
            };
            return Pcampo1;
        }

        private static SqlParameter Getcampo2(DCCompra CCompra)
        {
            SqlParameter Pcampo2 = new SqlParameter
            {
                ParameterName = "@campo2",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = CCompra.Dcampo2
            };
            return Pcampo2;
        }

        private static SqlParameter Getcampo3(DCCompra CCompra)
        {
            SqlParameter Pcampo3 = new SqlParameter
            {
                ParameterName = "@campo3",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = CCompra.Dcampo3
            };
            return Pcampo3;
        }

        private static SqlParameter Getcampo4(DCCompra CCompra)
        {
            SqlParameter Pcampo4 = new SqlParameter
            {
                ParameterName = "@campo4",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = CCompra.Dcampo4
            };
            return Pcampo4;
        }

        private static SqlParameter Getcampo5(DCCompra CCompra)
        {
            SqlParameter Pcampo5 = new SqlParameter
            {
                ParameterName = "@campo5",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = CCompra.Dcampo5
            };
            return Pcampo5;
        }

        private static SqlParameter Getcampo6(DCCompra CCompra)
        {
            SqlParameter Pcampo6 = new SqlParameter
            {
                ParameterName = "@campo6",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = CCompra.Dcampo6
            };
            return Pcampo6;
        }

        private static SqlParameter Getcod_usuario(DCCompra CCompra)
        {
            SqlParameter Pcod_usuario = new SqlParameter
            {
                ParameterName = "@cod_usuario",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = CCompra.Dcod_usuario,
            };
            return Pcod_usuario;
        }

        private static SqlParameter Getbuscar(DCCompra CCompra)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = CCompra.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DCCompra CCompra)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = CCompra.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DCCompra CCompra)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = CCompra.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DCCompra CCompra)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = CCompra.Dbtipo,
            };
            return Pbtipo;
        }

        #endregion

        public DCCompra()
        {
            /// Constructor Vacio
        }


        /// <summary>
        /// Tabla Mostrar No Recibe parametros y Muestra un DataTable
        /// </summary>
        /// <returns> No Recibe Parametros</returns>
        public DataTable Mostrar()
        {
            DataTable DtRpta = new DataTable("TbCCompra");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "ccompra_mostrar",
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
                    CommandText = "ccompra_listar",
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
        public string Insertar(DCCompra CCompra)
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
                    CommandText = "ccompra_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_ccompra = Getcod_ccompra(CCompra);
                Cmd.Parameters.Add(Parcod_ccompra);

                SqlParameter Parcod_proveedor = Getcod_proveedor(CCompra);
                Cmd.Parameters.Add(Parcod_proveedor);

                SqlParameter Parcod_condicionpago = Getcod_condicionpago(CCompra);
                Cmd.Parameters.Add(Parcod_condicionpago);

                SqlParameter Pardesc_ccompra = Getdesc_ccompra(CCompra);
                Cmd.Parameters.Add(Pardesc_ccompra);

                SqlParameter Paroptipo = Getoptipo(CCompra);
                Cmd.Parameters.Add(Paroptipo);

                SqlParameter Parnumdocumento = Getnumdocumento(CCompra);
                Cmd.Parameters.Add(Parnumdocumento);

                SqlParameter Parnumcontrol = Getnumcontrol(CCompra);
                Cmd.Parameters.Add(Parnumcontrol);

                SqlParameter Pardoc_asociado = Getdoc_asociado(CCompra);
                Cmd.Parameters.Add(Pardoc_asociado);

                SqlParameter Parorigen = Getorigen(CCompra);
                Cmd.Parameters.Add(Parorigen);

                SqlParameter Parestatus = Getestatus(CCompra);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Paranulado = Getanulado(CCompra);
                Cmd.Parameters.Add(Paranulado);

                SqlParameter Parmonto_base = Getmonto_base(CCompra);
                Cmd.Parameters.Add(Parmonto_base);

                SqlParameter Parmonto_r = Getmonto_r(CCompra);
                Cmd.Parameters.Add(Parmonto_r);

                SqlParameter Parmonto_d = Getmonto_d(CCompra);
                Cmd.Parameters.Add(Parmonto_d);

                SqlParameter Parmonto_o = Getmonto_o(CCompra);
                Cmd.Parameters.Add(Parmonto_o);

                SqlParameter Parmonto_imp = Getmonto_imp(CCompra);
                Cmd.Parameters.Add(Parmonto_imp);

                SqlParameter Parsubtotal = Getsubtotal(CCompra);
                Cmd.Parameters.Add(Parsubtotal);

                SqlParameter Partotal = Gettotal(CCompra);
                Cmd.Parameters.Add(Partotal);

                SqlParameter Parfecha_doc = Getfecha_doc(CCompra);
                Cmd.Parameters.Add(Parfecha_doc);

                SqlParameter Parfecha_reg = Getfecha_reg(CCompra);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parfecha_ven = Getfecha_ven(CCompra);
                Cmd.Parameters.Add(Parfecha_ven);

                SqlParameter Parcampo1 = Getcampo1(CCompra);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(CCompra);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(CCompra);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(CCompra);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(CCompra);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(CCompra);
                Cmd.Parameters.Add(Parcampo6);

                SqlParameter Parcod_usuario = Getcod_usuario(CCompra);
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
        public string Editar(DCCompra CCompra)
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
                    CommandText = "ccompra_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_ccompra = Getcod_ccompra(CCompra);
                Cmd.Parameters.Add(Parcod_ccompra);

                SqlParameter Parcod_ccomprav = Getcod_ccomprav(CCompra);
                Cmd.Parameters.Add(Parcod_ccomprav);

                SqlParameter Parcod_proveedor = Getcod_proveedor(CCompra);
                Cmd.Parameters.Add(Parcod_proveedor);

                SqlParameter Parcod_condicionpago = Getcod_condicionpago(CCompra);
                Cmd.Parameters.Add(Parcod_condicionpago);

                SqlParameter Pardesc_ccompra = Getdesc_ccompra(CCompra);
                Cmd.Parameters.Add(Pardesc_ccompra);

                SqlParameter Paroptipo = Getoptipo(CCompra);
                Cmd.Parameters.Add(Paroptipo);

                SqlParameter Parnumdocumento = Getnumdocumento(CCompra);
                Cmd.Parameters.Add(Parnumdocumento);

                SqlParameter Parnumcontrol = Getnumcontrol(CCompra);
                Cmd.Parameters.Add(Parnumcontrol);

                SqlParameter Pardoc_asociado = Getdoc_asociado(CCompra);
                Cmd.Parameters.Add(Pardoc_asociado);

                SqlParameter Parorigen = Getorigen(CCompra);
                Cmd.Parameters.Add(Parorigen);

                SqlParameter Parestatus = Getestatus(CCompra);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Paranulado = Getanulado(CCompra);
                Cmd.Parameters.Add(Paranulado);

                SqlParameter Parmonto_base = Getmonto_base(CCompra);
                Cmd.Parameters.Add(Parmonto_base);

                SqlParameter Parmonto_r = Getmonto_r(CCompra);
                Cmd.Parameters.Add(Parmonto_r);

                SqlParameter Parmonto_d = Getmonto_d(CCompra);
                Cmd.Parameters.Add(Parmonto_d);

                SqlParameter Parmonto_o = Getmonto_o(CCompra);
                Cmd.Parameters.Add(Parmonto_o);

                SqlParameter Parmonto_imp = Getmonto_imp(CCompra);
                Cmd.Parameters.Add(Parmonto_imp);

                SqlParameter Parsubtotal = Getsubtotal(CCompra);
                Cmd.Parameters.Add(Parsubtotal);

                SqlParameter Partotal = Gettotal(CCompra);
                Cmd.Parameters.Add(Partotal);

                SqlParameter Parfecha_doc = Getfecha_doc(CCompra);
                Cmd.Parameters.Add(Parfecha_doc);

                SqlParameter Parfecha_reg = Getfecha_reg(CCompra);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parfecha_ven = Getfecha_ven(CCompra);
                Cmd.Parameters.Add(Parfecha_ven);

                SqlParameter Parcampo1 = Getcampo1(CCompra);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(CCompra);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(CCompra);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(CCompra);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(CCompra);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(CCompra);
                Cmd.Parameters.Add(Parcampo6);

                SqlParameter Parcod_usuario = Getcod_usuario(CCompra);
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
        public string Eliminar(DCCompra CCompra)
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
                    CommandText = "ccompra_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_ccompra = Getcod_ccompra(CCompra);
                Cmd.Parameters.Add(Parcod_ccompra);

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
        public string Anular(DCCompra CCompra)
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
                    CommandText = "ccompra_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_pcompra = Getcod_ccompra(CCompra);
                Cmd.Parameters.Add(Parcod_pcompra);

                SqlParameter Parestatus = Getestatus(CCompra);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Paranulado = Getanulado(CCompra);
                Cmd.Parameters.Add(Paranulado);

                SqlParameter Parcod_usuario = Getcod_usuario(CCompra);
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
        /// <param name="Procesar CCompra"></param>
        public string Procesar(DCCompra CCompra)
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
                    CommandText = "ccompra_procesar",
                    CommandType = CommandType.StoredProcedure
                };
                #region ParametrosInsertar

                SqlParameter Parcod_ccompra = Getcod_ccompra(CCompra);
                Cmd.Parameters.Add(Parcod_ccompra);

                SqlParameter Parestatus = Getestatus(CCompra);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Parcod_usuario = Getcod_usuario(CCompra);
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
        public DataTable Buscar(DCCompra CCompra)
        {
            string Rpta = "";
            DataTable DtRpta = new DataTable("TbCCompra");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "ccompra_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(CCompra);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(CCompra);
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
        public DataTable RepBuscar(DCCompra CCompra)
        {
            DataTable DtRpta = new DataTable("TbCCompra");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "ccompra_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(CCompra);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(CCompra);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(CCompra);
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
                    CommandText = "ccompra_primero",
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
                    CommandText = "ccompra_ultimo",
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
        /// <param name="Listar Anterior CCompra"></param>
        public DataSet Anterior(DCCompra CCompra)
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
                    CommandText = "ccompra_anterior",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_ccompra = Getcod_ccompra(CCompra);
                Cmd.Parameters.Add(Parcod_ccompra);

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
        /// <param name="Listar Siguiente CCompra"></param>
        public DataSet Siguiente(DCCompra CCompra)
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
                    CommandText = "ccompra_siguiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_ccompra = Getcod_ccompra(CCompra);
                Cmd.Parameters.Add(Parcod_ccompra);

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
        public string GenerarCod(DCCompra CCompra)
        {
            SqlConnection SqlConn = new SqlConnection
            {
                ConnectionString = DConexion.Cn
            };

            SqlConn.Open();
            SqlCommand Cmd = new SqlCommand
            {
                Connection = SqlConn,
                CommandText = "ccompra_generarcod",
                CommandType = CommandType.StoredProcedure,
            };

            try
            {
                SqlParameter ParCod_ccompra = new SqlParameter("@cod_ccompra", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                    Value = CCompra.Dcod_ccompra
                };
                Cmd.Parameters.Add(ParCod_ccompra);

                if (Cmd.ExecuteNonQuery() == 0)
                {
                    return Cmd.Parameters[ParCod_ccompra.ToString()].Value.ToString();
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
            return Cmd.Parameters["@cod_ccompra"].Value.ToString();
        }
    }
}
