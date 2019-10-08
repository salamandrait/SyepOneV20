using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DDCompra
    {

        #region PARAMETROS
        public Object Dcod_dcompra { get; set; }
        public Object Dcod_dcomprav { get; set; }
        public Object Dcod_proveedor { get; set; }
        public Object Dcod_condicionpago { get; set; }
        public Object Ddesc_dcompra { get; set; }
        public Object Doptipo { get; set; }
        public Object Dnumdocumento { get; set; }
        public Object Dnumcontrol { get; set; }
        public Object Dnumserial { get; set; }
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


        private static SqlParameter Getcod_dcompra(DDCompra DCompra)
        {
            SqlParameter Pcod_dcompra = new SqlParameter
            {
                ParameterName = "@cod_dcompra",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = DCompra.Dcod_dcompra,
            };
            return Pcod_dcompra;
        }

        private static SqlParameter Getcod_dcomprav(DDCompra DCompra)
        {
            SqlParameter Pcod_dcomprav = new SqlParameter
            {
                ParameterName = "@cod_dcomprav",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = DCompra.Dcod_dcomprav,
            };
            return Pcod_dcomprav;
        }

        private static SqlParameter Getcod_proveedor(DDCompra DCompra)
        {
            SqlParameter Pcod_proveedor = new SqlParameter
            {
                ParameterName = "@cod_proveedor",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = DCompra.Dcod_proveedor,
            };
            return Pcod_proveedor;
        }

        private static SqlParameter Getcod_condicionpago(DDCompra DCompra)
        {
            SqlParameter Pcod_condicionpago = new SqlParameter
            {
                ParameterName = "@cod_condicionpago",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = DCompra.Dcod_condicionpago,
            };
            return Pcod_condicionpago;
        }

        private static SqlParameter Getdesc_dcompra(DDCompra DCompra)
        {
            SqlParameter Pdesc_dcompra = new SqlParameter
            {
                ParameterName = "@desc_dcompra",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = DCompra.Ddesc_dcompra,
            };
            return Pdesc_dcompra;
        }

        private static SqlParameter Getoptipo(DDCompra DCompra)
        {
            SqlParameter Poptipo = new SqlParameter
            {
                ParameterName = "@optipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = DCompra.Doptipo,
            };
            return Poptipo;
        }

        private static SqlParameter Getnumdocumento(DDCompra DCompra)
        {
            SqlParameter Pnumdocumento = new SqlParameter
            {
                ParameterName = "@numdocumento",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = DCompra.Dnumdocumento
            };
            return Pnumdocumento;
        }

        private static SqlParameter Getnumcontrol(DDCompra DCompra)
        {
            SqlParameter Pnumcontrol = new SqlParameter
            {
                ParameterName = "@numcontrol",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = DCompra.Dnumcontrol
            };
            return Pnumcontrol;
        }

        private static SqlParameter Getnumserial(DDCompra DCompra)
        {
            SqlParameter Pnumserial = new SqlParameter
            {
                ParameterName = "@numserial",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = DCompra.Dnumserial
            };
            return Pnumserial;
        }

        private static SqlParameter Getdoc_asociado(DDCompra DCompra)
        {
            SqlParameter Pdoc_asociado = new SqlParameter
            {
                ParameterName = "@doc_asociado",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = DCompra.Ddoc_asociado
            };
            return Pdoc_asociado;
        }

        private static SqlParameter Getorigen(DDCompra DCompra)
        {
            SqlParameter Porigen = new SqlParameter
            {
                ParameterName = "@origen",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = DCompra.Dorigen
            };
            return Porigen;
        }

        private static SqlParameter Getestatus(DDCompra DCompra)
        {
            SqlParameter Pestatus = new SqlParameter
            {
                ParameterName = "@estatus",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = DCompra.Destatus
            };
            return Pestatus;
        }

        private static SqlParameter Getanulado(DDCompra DCompra)
        {
            SqlParameter Panulado = new SqlParameter
            {
                ParameterName = "@anulado",
                SqlDbType = SqlDbType.Bit,
                Value = DCompra.Danulado
            };
            return Panulado;
        }

        private static SqlParameter Getmonto_base(DDCompra DCompra)
        {
            SqlParameter Pmonto_base = new SqlParameter
            {
                ParameterName = "@monto_base",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = DCompra.Dmonto_base
            };
            return Pmonto_base;
        }

        private static SqlParameter Getmonto_r(DDCompra DCompra)
        {
            SqlParameter Pmonto_r = new SqlParameter
            {
                ParameterName = "@monto_r",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = DCompra.Dmonto_r
            };
            return Pmonto_r;
        }

        private static SqlParameter Getmonto_d(DDCompra DCompra)
        {
            SqlParameter Pmonto_d = new SqlParameter
            {
                ParameterName = "@monto_d",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = DCompra.Dmonto_d
            };
            return Pmonto_d;
        }

        private static SqlParameter Getmonto_o(DDCompra DCompra)
        {
            SqlParameter Pmonto_o = new SqlParameter
            {
                ParameterName = "@monto_o",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = DCompra.Dmonto_o
            };
            return Pmonto_o;
        }

        private static SqlParameter Getmonto_imp(DDCompra DCompra)
        {
            SqlParameter Pmonto_imp = new SqlParameter
            {
                ParameterName = "@monto_imp",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = DCompra.Dmonto_imp
            };
            return Pmonto_imp;
        }

        private static SqlParameter Getsubtotal(DDCompra DCompra)
        {
            SqlParameter Psubtotal = new SqlParameter
            {
                ParameterName = "@subtotal",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = DCompra.Dsubtotal
            };
            return Psubtotal;
        }

        private static SqlParameter Gettotal(DDCompra DCompra)
        {
            SqlParameter Ptotal = new SqlParameter
            {
                ParameterName = "@total",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = DCompra.Dtotal
            };
            return Ptotal;
        }

        private static SqlParameter Getfecha_doc(DDCompra DCompra)
        {
            SqlParameter Pfecha_doc = new SqlParameter
            {
                ParameterName = "@fecha_doc",
                SqlDbType = SqlDbType.DateTime,
                Value = DCompra.Dfecha_doc
            };
            return Pfecha_doc;
        }

        private static SqlParameter Getfecha_reg(DDCompra DCompra)
        {
            SqlParameter Pfecha_reg = new SqlParameter
            {
                ParameterName = "@fecha_reg",
                SqlDbType = SqlDbType.DateTime,
                Value = DCompra.Dfecha_reg
            };
            return Pfecha_reg;
        }

        private static SqlParameter Getfecha_ven(DDCompra DCompra)
        {
            SqlParameter Pfecha_ven = new SqlParameter
            {
                ParameterName = "@fecha_ven",
                SqlDbType = SqlDbType.DateTime,
                Value = DCompra.Dfecha_ven
            };
            return Pfecha_ven;
        }

        private static SqlParameter Getcampo1(DDCompra DCompra)
        {
            SqlParameter Pcampo1 = new SqlParameter
            {
                ParameterName = "@campo1",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = DCompra.Dcampo1
            };
            return Pcampo1;
        }

        private static SqlParameter Getcampo2(DDCompra DCompra)
        {
            SqlParameter Pcampo2 = new SqlParameter
            {
                ParameterName = "@campo2",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = DCompra.Dcampo2
            };
            return Pcampo2;
        }

        private static SqlParameter Getcampo3(DDCompra DCompra)
        {
            SqlParameter Pcampo3 = new SqlParameter
            {
                ParameterName = "@campo3",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = DCompra.Dcampo3
            };
            return Pcampo3;
        }

        private static SqlParameter Getcampo4(DDCompra DCompra)
        {
            SqlParameter Pcampo4 = new SqlParameter
            {
                ParameterName = "@campo4",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = DCompra.Dcampo4
            };
            return Pcampo4;
        }

        private static SqlParameter Getcampo5(DDCompra DCompra)
        {
            SqlParameter Pcampo5 = new SqlParameter
            {
                ParameterName = "@campo5",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = DCompra.Dcampo5
            };
            return Pcampo5;
        }

        private static SqlParameter Getcampo6(DDCompra DCompra)
        {
            SqlParameter Pcampo6 = new SqlParameter
            {
                ParameterName = "@campo6",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = DCompra.Dcampo6
            };
            return Pcampo6;
        }

        private static SqlParameter Getcod_usuario(DDCompra DCompra)
        {
            SqlParameter Pcod_usuario = new SqlParameter
            {
                ParameterName = "@cod_usuario",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = DCompra.Dcod_usuario,
            };
            return Pcod_usuario;
        }

        private static SqlParameter Getbuscar(DDCompra DCompra)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = DCompra.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DDCompra DCompra)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = DCompra.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DDCompra DCompra)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = DCompra.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DDCompra DCompra)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = DCompra.Dbtipo,
            };
            return Pbtipo;
        }

        #endregion

        public DDCompra()
        {
            /// Constructor Vacio
        }


        /// <summary>
        /// Tabla Mostrar No Recibe parametros y Muestra un DataTable
        /// </summary>
        /// <returns> No Recibe Parametros</returns>
        public DataTable Mostrar()
        {
            DataTable DtRpta = new DataTable("TbDCompra");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "dcompra_mostrar",
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
                    CommandText = "dcompra_listar",
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
        public string Insertar(DDCompra DCompra)
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
                    CommandText = "dcompra_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_dcompra = Getcod_dcompra(DCompra);
                Cmd.Parameters.Add(Parcod_dcompra);

                SqlParameter Parcod_proveedor = Getcod_proveedor(DCompra);
                Cmd.Parameters.Add(Parcod_proveedor);

                SqlParameter Parcod_condicionpago = Getcod_condicionpago(DCompra);
                Cmd.Parameters.Add(Parcod_condicionpago);

                SqlParameter Pardesc_dcompra = Getdesc_dcompra(DCompra);
                Cmd.Parameters.Add(Pardesc_dcompra);

                SqlParameter Paroptipo = Getoptipo(DCompra);
                Cmd.Parameters.Add(Paroptipo);

                SqlParameter Parnumdocumento = Getnumdocumento(DCompra);
                Cmd.Parameters.Add(Parnumdocumento);

                SqlParameter Parnumcontrol = Getnumcontrol(DCompra);
                Cmd.Parameters.Add(Parnumcontrol);

                SqlParameter Parnumserial = Getnumserial(DCompra);
                Cmd.Parameters.Add(Parnumserial);

                SqlParameter Pardoc_asociado = Getdoc_asociado(DCompra);
                Cmd.Parameters.Add(Pardoc_asociado);

                SqlParameter Parorigen = Getorigen(DCompra);
                Cmd.Parameters.Add(Parorigen);

                SqlParameter Parestatus = Getestatus(DCompra);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Paranulado = Getanulado(DCompra);
                Cmd.Parameters.Add(Paranulado);

                SqlParameter Parmonto_base = Getmonto_base(DCompra);
                Cmd.Parameters.Add(Parmonto_base);

                SqlParameter Parmonto_r = Getmonto_r(DCompra);
                Cmd.Parameters.Add(Parmonto_r);

                SqlParameter Parmonto_d = Getmonto_d(DCompra);
                Cmd.Parameters.Add(Parmonto_d);

                SqlParameter Parmonto_o = Getmonto_o(DCompra);
                Cmd.Parameters.Add(Parmonto_o);

                SqlParameter Parmonto_imp = Getmonto_imp(DCompra);
                Cmd.Parameters.Add(Parmonto_imp);

                SqlParameter Parsubtotal = Getsubtotal(DCompra);
                Cmd.Parameters.Add(Parsubtotal);

                SqlParameter Partotal = Gettotal(DCompra);
                Cmd.Parameters.Add(Partotal);

                SqlParameter Parfecha_doc = Getfecha_doc(DCompra);
                Cmd.Parameters.Add(Parfecha_doc);

                SqlParameter Parfecha_reg = Getfecha_reg(DCompra);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parfecha_ven = Getfecha_ven(DCompra);
                Cmd.Parameters.Add(Parfecha_ven);

                SqlParameter Parcampo1 = Getcampo1(DCompra);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(DCompra);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(DCompra);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(DCompra);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(DCompra);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(DCompra);
                Cmd.Parameters.Add(Parcampo6);

                SqlParameter Parcod_usuario = Getcod_usuario(DCompra);
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
        public string Editar(DDCompra DCompra)
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
                    CommandText = "dcompra_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_dcompra = Getcod_dcompra(DCompra);
                Cmd.Parameters.Add(Parcod_dcompra);

                SqlParameter Parcod_dcomprav = Getcod_dcomprav(DCompra);
                Cmd.Parameters.Add(Parcod_dcomprav);

                SqlParameter Parcod_proveedor = Getcod_proveedor(DCompra);
                Cmd.Parameters.Add(Parcod_proveedor);

                SqlParameter Parcod_condicionpago = Getcod_condicionpago(DCompra);
                Cmd.Parameters.Add(Parcod_condicionpago);

                SqlParameter Pardesc_dcompra = Getdesc_dcompra(DCompra);
                Cmd.Parameters.Add(Pardesc_dcompra);

                SqlParameter Paroptipo = Getoptipo(DCompra);
                Cmd.Parameters.Add(Paroptipo);

                SqlParameter Parnumdocumento = Getnumdocumento(DCompra);
                Cmd.Parameters.Add(Parnumdocumento);

                SqlParameter Parnumcontrol = Getnumcontrol(DCompra);
                Cmd.Parameters.Add(Parnumcontrol);

                SqlParameter Parnumserial = Getnumserial(DCompra);
                Cmd.Parameters.Add(Parnumserial);

                SqlParameter Pardoc_asociado = Getdoc_asociado(DCompra);
                Cmd.Parameters.Add(Pardoc_asociado);

                SqlParameter Parorigen = Getorigen(DCompra);
                Cmd.Parameters.Add(Parorigen);

                SqlParameter Parestatus = Getestatus(DCompra);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Paranulado = Getanulado(DCompra);
                Cmd.Parameters.Add(Paranulado);

                SqlParameter Parmonto_base = Getmonto_base(DCompra);
                Cmd.Parameters.Add(Parmonto_base);

                SqlParameter Parmonto_r = Getmonto_r(DCompra);
                Cmd.Parameters.Add(Parmonto_r);

                SqlParameter Parmonto_d = Getmonto_d(DCompra);
                Cmd.Parameters.Add(Parmonto_d);

                SqlParameter Parmonto_o = Getmonto_o(DCompra);
                Cmd.Parameters.Add(Parmonto_o);

                SqlParameter Parmonto_imp = Getmonto_imp(DCompra);
                Cmd.Parameters.Add(Parmonto_imp);

                SqlParameter Parsubtotal = Getsubtotal(DCompra);
                Cmd.Parameters.Add(Parsubtotal);

                SqlParameter Partotal = Gettotal(DCompra);
                Cmd.Parameters.Add(Partotal);

                SqlParameter Parfecha_doc = Getfecha_doc(DCompra);
                Cmd.Parameters.Add(Parfecha_doc);

                SqlParameter Parfecha_reg = Getfecha_reg(DCompra);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parfecha_ven = Getfecha_ven(DCompra);
                Cmd.Parameters.Add(Parfecha_ven);

                SqlParameter Parcampo1 = Getcampo1(DCompra);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(DCompra);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(DCompra);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(DCompra);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(DCompra);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(DCompra);
                Cmd.Parameters.Add(Parcampo6);

                SqlParameter Parcod_usuario = Getcod_usuario(DCompra);
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
        public string Eliminar(DDCompra DCompra)
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
                    CommandText = "dcompra_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_dcompra = Getcod_dcompra(DCompra);
                Cmd.Parameters.Add(Parcod_dcompra);

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
        public string Anular(DDCompra DCompra)
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
                    CommandText = "dcompra_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_pcompra = Getcod_dcompra(DCompra);
                Cmd.Parameters.Add(Parcod_pcompra);

                SqlParameter Parestatus = Getestatus(DCompra);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Paranulado = Getanulado(DCompra);
                Cmd.Parameters.Add(Paranulado);

                SqlParameter Parcod_usuario = Getcod_usuario(DCompra);
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
        /// <param name="Procesar DCompra"></param>
        public string Procesar(DDCompra DCompra)
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
                    CommandText = "dcompra_procesar",
                    CommandType = CommandType.StoredProcedure
                };
                #region ParametrosInsertar

                SqlParameter Parcod_dcompra = Getcod_dcompra(DCompra);
                Cmd.Parameters.Add(Parcod_dcompra);

                SqlParameter Parestatus = Getestatus(DCompra);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Parcod_usuario = Getcod_usuario(DCompra);
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
        public DataTable Buscar(DDCompra DCompra)
        {
            string Rpta = "";
            DataTable DtRpta = new DataTable("TbDCompra");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "dcompra_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(DCompra);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(DCompra);
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
        public DataTable RepBuscar(DDCompra DCompra)
        {
            DataTable DtRpta = new DataTable("TbDCompra");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "dcompra_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(DCompra);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(DCompra);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(DCompra);
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
                    CommandText = "dcompra_primero",
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
                    CommandText = "dcompra_ultimo",
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
        /// <param name="Listar Anterior DCompra"></param>
        public DataSet Anterior(DDCompra DCompra)
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
                    CommandText = "dcompra_anterior",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_dcompra = Getcod_dcompra(DCompra);
                Cmd.Parameters.Add(Parcod_dcompra);

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
        /// <param name="Listar Siguiente DCompra"></param>
        public DataSet Siguiente(DDCompra DCompra)
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
                    CommandText = "dcompra_siguiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_dcompra = Getcod_dcompra(DCompra);
                Cmd.Parameters.Add(Parcod_dcompra);

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
        public string GenerarCod(DDCompra DCompra)
        {
            SqlConnection SqlConn = new SqlConnection
            {
                ConnectionString = DConexion.Cn
            };

            SqlConn.Open();
            SqlCommand Cmd = new SqlCommand
            {
                Connection = SqlConn,
                CommandText = "dcompra_generarcod",
                CommandType = CommandType.StoredProcedure,
            };

            try
            {
                SqlParameter ParCod_dcompra = new SqlParameter("@cod_dcompra", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                    Value = DCompra.Dcod_dcompra
                };
                Cmd.Parameters.Add(ParCod_dcompra);

                if (Cmd.ExecuteNonQuery() == 0)
                {
                    return Cmd.Parameters[ParCod_dcompra.ToString()].Value.ToString();
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
            return Cmd.Parameters["@cod_dcompra"].Value.ToString();
        }
    }
}
