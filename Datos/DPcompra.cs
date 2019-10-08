using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DPCompra
    {

        #region PARAMETROS
        public Object Dcod_pcompra { get; set; }
        public Object Dcod_pcomprav { get; set; }
        public Object Dcod_proveedor { get; set; }
        public Object Dcod_condicionpago { get; set; }
        public Object Ddesc_pcompra { get; set; }
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


        private static SqlParameter Getcod_pcompra(DPCompra PCompra)
        {
            SqlParameter Pcod_pcompra = new SqlParameter
            {
                ParameterName = "@cod_pcompra",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = PCompra.Dcod_pcompra,
            };
            return Pcod_pcompra;
        }

        private static SqlParameter Getcod_pcomprav(DPCompra PCompra)
        {
            SqlParameter Pcod_pcomprav = new SqlParameter
            {
                ParameterName = "@cod_pcomprav",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = PCompra.Dcod_pcomprav,
            };
            return Pcod_pcomprav;
        }

        private static SqlParameter Getcod_proveedor(DPCompra PCompra)
        {
            SqlParameter Pcod_proveedor = new SqlParameter
            {
                ParameterName = "@cod_proveedor",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = PCompra.Dcod_proveedor,
            };
            return Pcod_proveedor;
        }

        private static SqlParameter Getcod_condicionpago(DPCompra PCompra)
        {
            SqlParameter Pcod_condicionpago = new SqlParameter
            {
                ParameterName = "@cod_condicionpago",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = PCompra.Dcod_condicionpago,
            };
            return Pcod_condicionpago;
        }

        private static SqlParameter Getdesc_pcompra(DPCompra PCompra)
        {
            SqlParameter Pdesc_pcompra = new SqlParameter
            {
                ParameterName = "@desc_pcompra",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = PCompra.Ddesc_pcompra,
            };
            return Pdesc_pcompra;
        }

        private static SqlParameter Getoptipo(DPCompra PCompra)
        {
            SqlParameter Poptipo = new SqlParameter
            {
                ParameterName = "@optipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = PCompra.Doptipo,
            };
            return Poptipo;
        }

        private static SqlParameter Getnumdocumento(DPCompra PCompra)
        {
            SqlParameter Pnumdocumento = new SqlParameter
            {
                ParameterName = "@numdocumento",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = PCompra.Dnumdocumento
            };
            return Pnumdocumento;
        }

        private static SqlParameter Getnumcontrol(DPCompra PCompra)
        {
            SqlParameter Pnumcontrol = new SqlParameter
            {
                ParameterName = "@numcontrol",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = PCompra.Dnumcontrol
            };
            return Pnumcontrol;
        }

        private static SqlParameter Getdoc_asociado(DPCompra PCompra)
        {
            SqlParameter Pdoc_asociado = new SqlParameter
            {
                ParameterName = "@doc_asociado",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = PCompra.Ddoc_asociado
            };
            return Pdoc_asociado;
        }

        private static SqlParameter Getorigen(DPCompra PCompra)
        {
            SqlParameter Porigen = new SqlParameter
            {
                ParameterName = "@origen",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = PCompra.Dorigen
            };
            return Porigen;
        }

        private static SqlParameter Getestatus(DPCompra PCompra)
        {
            SqlParameter Pestatus = new SqlParameter
            {
                ParameterName = "@estatus",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = PCompra.Destatus
            };
            return Pestatus;
        }

        private static SqlParameter Getanulado(DPCompra PCompra)
        {
            SqlParameter Panulado = new SqlParameter
            {
                ParameterName = "@anulado",
                SqlDbType = SqlDbType.Bit,
                Value = PCompra.Danulado
            };
            return Panulado;
        }

        private static SqlParameter Getmonto_base(DPCompra PCompra)
        {
            SqlParameter Pmonto_base = new SqlParameter
            {
                ParameterName = "@monto_base",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = PCompra.Dmonto_base
            };
            return Pmonto_base;
        }

        private static SqlParameter Getmonto_r(DPCompra PCompra)
        {
            SqlParameter Pmonto_r = new SqlParameter
            {
                ParameterName = "@monto_r",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = PCompra.Dmonto_r
            };
            return Pmonto_r;
        }

        private static SqlParameter Getmonto_d(DPCompra PCompra)
        {
            SqlParameter Pmonto_d = new SqlParameter
            {
                ParameterName = "@monto_d",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = PCompra.Dmonto_d
            };
            return Pmonto_d;
        }

        private static SqlParameter Getmonto_o(DPCompra PCompra)
        {
            SqlParameter Pmonto_o = new SqlParameter
            {
                ParameterName = "@monto_o",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = PCompra.Dmonto_o
            };
            return Pmonto_o;
        }

        private static SqlParameter Getmonto_imp(DPCompra PCompra)
        {
            SqlParameter Pmonto_imp = new SqlParameter
            {
                ParameterName = "@monto_imp",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = PCompra.Dmonto_imp
            };
            return Pmonto_imp;
        }

        private static SqlParameter Getsubtotal(DPCompra PCompra)
        {
            SqlParameter Psubtotal = new SqlParameter
            {
                ParameterName = "@subtotal",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = PCompra.Dsubtotal
            };
            return Psubtotal;
        }

        private static SqlParameter Gettotal(DPCompra PCompra)
        {
            SqlParameter Ptotal = new SqlParameter
            {
                ParameterName = "@total",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = PCompra.Dtotal
            };
            return Ptotal;
        }

        private static SqlParameter Getfecha_doc(DPCompra PCompra)
        {
            SqlParameter Pfecha_doc = new SqlParameter
            {
                ParameterName = "@fecha_doc",
                SqlDbType = SqlDbType.DateTime,
                Value = PCompra.Dfecha_doc
            };
            return Pfecha_doc;
        }

        private static SqlParameter Getfecha_reg(DPCompra PCompra)
        {
            SqlParameter Pfecha_reg = new SqlParameter
            {
                ParameterName = "@fecha_reg",
                SqlDbType = SqlDbType.DateTime,
                Value = PCompra.Dfecha_reg
            };
            return Pfecha_reg;
        }

        private static SqlParameter Getfecha_ven(DPCompra PCompra)
        {
            SqlParameter Pfecha_ven = new SqlParameter
            {
                ParameterName = "@fecha_ven",
                SqlDbType = SqlDbType.DateTime,
                Value = PCompra.Dfecha_ven
            };
            return Pfecha_ven;
        }

        private static SqlParameter Getcampo1(DPCompra PCompra)
        {
            SqlParameter Pcampo1 = new SqlParameter
            {
                ParameterName = "@campo1",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = PCompra.Dcampo1
            };
            return Pcampo1;
        }

        private static SqlParameter Getcampo2(DPCompra PCompra)
        {
            SqlParameter Pcampo2 = new SqlParameter
            {
                ParameterName = "@campo2",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = PCompra.Dcampo2
            };
            return Pcampo2;
        }

        private static SqlParameter Getcampo3(DPCompra PCompra)
        {
            SqlParameter Pcampo3 = new SqlParameter
            {
                ParameterName = "@campo3",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = PCompra.Dcampo3
            };
            return Pcampo3;
        }

        private static SqlParameter Getcampo4(DPCompra PCompra)
        {
            SqlParameter Pcampo4 = new SqlParameter
            {
                ParameterName = "@campo4",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = PCompra.Dcampo4
            };
            return Pcampo4;
        }

        private static SqlParameter Getcampo5(DPCompra PCompra)
        {
            SqlParameter Pcampo5 = new SqlParameter
            {
                ParameterName = "@campo5",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = PCompra.Dcampo5
            };
            return Pcampo5;
        }

        private static SqlParameter Getcampo6(DPCompra PCompra)
        {
            SqlParameter Pcampo6 = new SqlParameter
            {
                ParameterName = "@campo6",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = PCompra.Dcampo6
            };
            return Pcampo6;
        }

        private static SqlParameter Getcod_usuario(DPCompra PCompra)
        {
            SqlParameter Pcod_usuario = new SqlParameter
            {
                ParameterName = "@cod_usuario",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = PCompra.Dcod_usuario,
            };
            return Pcod_usuario;
        }

        private static SqlParameter Getbuscar(DPCompra PCompra)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = PCompra.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DPCompra PCompra)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = PCompra.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DPCompra PCompra)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = PCompra.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DPCompra PCompra)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = PCompra.Dbtipo,
            };
            return Pbtipo;
        }

        #endregion

        public DPCompra()
        {
            /// Constructor Vacio
        }


        /// <summary>
        /// Tabla Mostrar No Recibe parametros y Muestra un DataTable
        /// </summary>
        /// <returns> No Recibe Parametros</returns>
        public DataTable Mostrar()
        {
            DataTable DtRpta = new DataTable("TbPCompra");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "pcompra_mostrar",
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
        /// Tabla Mostrar No Recibe parametros
        /// </summary>
        /// <returns> 0 Parametros</returns>
        public DataTable MostrarImp(DPCompra PCompra)
        {
            DataTable DtRpta = new DataTable("TbPCompra");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "pcompra_mostrarimp",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_proveedor = Getcod_proveedor(PCompra);
                Cmd.Parameters.Add(Parcod_proveedor);

                SqlParameter Parestatus = Getestatus(PCompra);
                Cmd.Parameters.Add(Parestatus);

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
                    CommandText = "pcompra_listar",
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
        public string Insertar(DPCompra PCompra)
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
                    CommandText = "pcompra_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_pcompra = Getcod_pcompra(PCompra);
                Cmd.Parameters.Add(Parcod_pcompra);

                SqlParameter Parcod_proveedor = Getcod_proveedor(PCompra);
                Cmd.Parameters.Add(Parcod_proveedor);

                SqlParameter Parcod_condicionpago = Getcod_condicionpago(PCompra);
                Cmd.Parameters.Add(Parcod_condicionpago);

                SqlParameter Pardesc_pcompra = Getdesc_pcompra(PCompra);
                Cmd.Parameters.Add(Pardesc_pcompra);

                SqlParameter Paroptipo = Getoptipo(PCompra);
                Cmd.Parameters.Add(Paroptipo);

                SqlParameter Parnumdocumento = Getnumdocumento(PCompra);
                Cmd.Parameters.Add(Parnumdocumento);

                SqlParameter Parnumcontrol = Getnumcontrol(PCompra);
                Cmd.Parameters.Add(Parnumcontrol);

                SqlParameter Pardoc_asociado = Getdoc_asociado(PCompra);
                Cmd.Parameters.Add(Pardoc_asociado);

                SqlParameter Parorigen = Getorigen(PCompra);
                Cmd.Parameters.Add(Parorigen);

                SqlParameter Parestatus = Getestatus(PCompra);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Paranulado = Getanulado(PCompra);
                Cmd.Parameters.Add(Paranulado);

                SqlParameter Parmonto_base = Getmonto_base(PCompra);
                Cmd.Parameters.Add(Parmonto_base);

                SqlParameter Parmonto_r = Getmonto_r(PCompra);
                Cmd.Parameters.Add(Parmonto_r);

                SqlParameter Parmonto_d = Getmonto_d(PCompra);
                Cmd.Parameters.Add(Parmonto_d);

                SqlParameter Parmonto_o = Getmonto_o(PCompra);
                Cmd.Parameters.Add(Parmonto_o);

                SqlParameter Parmonto_imp = Getmonto_imp(PCompra);
                Cmd.Parameters.Add(Parmonto_imp);

                SqlParameter Parsubtotal = Getsubtotal(PCompra);
                Cmd.Parameters.Add(Parsubtotal);

                SqlParameter Partotal = Gettotal(PCompra);
                Cmd.Parameters.Add(Partotal);

                SqlParameter Parfecha_doc = Getfecha_doc(PCompra);
                Cmd.Parameters.Add(Parfecha_doc);

                SqlParameter Parfecha_reg = Getfecha_reg(PCompra);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parfecha_ven = Getfecha_ven(PCompra);
                Cmd.Parameters.Add(Parfecha_ven);

                SqlParameter Parcampo1 = Getcampo1(PCompra);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(PCompra);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(PCompra);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(PCompra);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(PCompra);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(PCompra);
                Cmd.Parameters.Add(Parcampo6);

                SqlParameter Parcod_usuario = Getcod_usuario(PCompra);
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
        public string Editar(DPCompra PCompra)
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
                    CommandText = "pcompra_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_pcompra = Getcod_pcompra(PCompra);
                Cmd.Parameters.Add(Parcod_pcompra);

                SqlParameter Parcod_pcomprav = Getcod_pcomprav(PCompra);
                Cmd.Parameters.Add(Parcod_pcomprav);

                SqlParameter Parcod_proveedor = Getcod_proveedor(PCompra);
                Cmd.Parameters.Add(Parcod_proveedor);

                SqlParameter Parcod_condicionpago = Getcod_condicionpago(PCompra);
                Cmd.Parameters.Add(Parcod_condicionpago);

                SqlParameter Pardesc_pcompra = Getdesc_pcompra(PCompra);
                Cmd.Parameters.Add(Pardesc_pcompra);

                SqlParameter Paroptipo = Getoptipo(PCompra);
                Cmd.Parameters.Add(Paroptipo);

                SqlParameter Parnumdocumento = Getnumdocumento(PCompra);
                Cmd.Parameters.Add(Parnumdocumento);

                SqlParameter Parnumcontrol = Getnumcontrol(PCompra);
                Cmd.Parameters.Add(Parnumcontrol);

                SqlParameter Pardoc_asociado = Getdoc_asociado(PCompra);
                Cmd.Parameters.Add(Pardoc_asociado);

                SqlParameter Parorigen = Getorigen(PCompra);
                Cmd.Parameters.Add(Parorigen);

                SqlParameter Parestatus = Getestatus(PCompra);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Paranulado = Getanulado(PCompra);
                Cmd.Parameters.Add(Paranulado);

                SqlParameter Parmonto_base = Getmonto_base(PCompra);
                Cmd.Parameters.Add(Parmonto_base);

                SqlParameter Parmonto_r = Getmonto_r(PCompra);
                Cmd.Parameters.Add(Parmonto_r);

                SqlParameter Parmonto_d = Getmonto_d(PCompra);
                Cmd.Parameters.Add(Parmonto_d);

                SqlParameter Parmonto_o = Getmonto_o(PCompra);
                Cmd.Parameters.Add(Parmonto_o);

                SqlParameter Parmonto_imp = Getmonto_imp(PCompra);
                Cmd.Parameters.Add(Parmonto_imp);

                SqlParameter Parsubtotal = Getsubtotal(PCompra);
                Cmd.Parameters.Add(Parsubtotal);

                SqlParameter Partotal = Gettotal(PCompra);
                Cmd.Parameters.Add(Partotal);

                SqlParameter Parfecha_doc = Getfecha_doc(PCompra);
                Cmd.Parameters.Add(Parfecha_doc);

                SqlParameter Parfecha_reg = Getfecha_reg(PCompra);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parfecha_ven = Getfecha_ven(PCompra);
                Cmd.Parameters.Add(Parfecha_ven);

                SqlParameter Parcampo1 = Getcampo1(PCompra);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(PCompra);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(PCompra);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(PCompra);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(PCompra);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(PCompra);
                Cmd.Parameters.Add(Parcampo6);

                SqlParameter Parcod_usuario = Getcod_usuario(PCompra);
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
        public string Eliminar(DPCompra PCompra)
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
                    CommandText = "pcompra_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_pcompra = Getcod_pcompra(PCompra);
                Cmd.Parameters.Add(Parcod_pcompra);

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
        public string Anular(DPCompra PCompra)
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
                    CommandText = "pcompra_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_pcompra = Getcod_pcompra(PCompra);
                Cmd.Parameters.Add(Parcod_pcompra);

                SqlParameter Parestatus = Getestatus(PCompra);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Paranulado = Getanulado(PCompra);
                Cmd.Parameters.Add(Paranulado);

                SqlParameter Parcod_usuario = Getcod_usuario(PCompra);
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
        /// <param name="Procesar PCompra"></param>
        public string Procesar(DPCompra PCompra)
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
                    CommandText = "pcompra_procesar",
                    CommandType = CommandType.StoredProcedure
                };
                #region ParametrosInsertar

                SqlParameter Parcod_pcompra = Getcod_pcompra(PCompra);
                Cmd.Parameters.Add(Parcod_pcompra);

                SqlParameter Parestatus = Getestatus(PCompra);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Parcod_usuario = Getcod_usuario(PCompra);
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
        public DataTable Buscar(DPCompra PCompra)
        {
            string Rpta = "";
            DataTable DtRpta = new DataTable("TbPCompra");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "pcompra_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(PCompra);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(PCompra);
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
        public DataTable RepBuscar(DPCompra PCompra)
        {
            DataTable DtRpta = new DataTable("TbPCompra");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "pcompra_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(PCompra);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(PCompra);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(PCompra);
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
                    CommandText = "pcompra_primero",
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
                    CommandText = "pcompra_ultimo",
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
        /// <param name="Listar Anterior PCompra"></param>
        public DataSet Anterior(DPCompra PCompra)
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
                    CommandText = "pcompra_anterior",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_pcompra = Getcod_pcompra(PCompra);
                Cmd.Parameters.Add(Parcod_pcompra);

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
        /// <param name="Listar Siguiente PCompra"></param>
        public DataSet Siguiente(DPCompra PCompra)
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
                    CommandText = "pcompra_siguiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_pcompra = Getcod_pcompra(PCompra);
                Cmd.Parameters.Add(Parcod_pcompra);

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
        public string GenerarCod(DPCompra PCompra)
        {
            SqlConnection SqlConn = new SqlConnection
            {
                ConnectionString = DConexion.Cn
            };

            SqlConn.Open();
            SqlCommand Cmd = new SqlCommand
            {
                Connection = SqlConn,
                CommandText = "pcompra_generarcod",
                CommandType = CommandType.StoredProcedure,
            };

            try
            {
                SqlParameter ParCod_pcompra = new SqlParameter("@cod_pcompra", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                    Value = PCompra.Dcod_pcompra
                };
                Cmd.Parameters.Add(ParCod_pcompra);

                if (Cmd.ExecuteNonQuery() == 0)
                {
                    return Cmd.Parameters[ParCod_pcompra.ToString()].Value.ToString();
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
            return Cmd.Parameters["@cod_pcompra"].Value.ToString();
        }
    }
}
