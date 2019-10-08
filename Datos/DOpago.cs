using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DOPago
    {

        #region PARAMETROS

        public Object Dcod_opago { get; set; }
        public Object Dcod_opagov { get; set; }
        public Object Dcod_beneficiario { get; set; }
        public Object Dcod_cuentasie { get; set; }
        public Object Dcod_caja { get; set; }
        public Object Dcod_cuenta { get; set; }
        public Object Dcod_impuesto { get; set; }
        public Object Dcod_moneda { get; set; }
        public Object Ddesc_opago { get; set; }
        public Object Destatus { get; set; }
        public Object Dnumdocumento { get; set; }
        public Object Dforma { get; set; }
        public Object Danulado { get; set; }
        public Object Dmontobase { get; set; }
        public Object Dmontoimp { get; set; }
        public Object Dmontototal { get; set; }
        public Object Dfecha_reg { get; set; }
        public Object Dfecha_pag { get; set; }
        public Object Dcampo1 { get; set; }
        public Object Dcampo2 { get; set; }
        public Object Dcampo3 { get; set; }
        public Object Dcampo4 { get; set; }
        public Object Dcampo5 { get; set; }
        public Object Dcampo6 { get; set; }
        public Object Dbuscar { get; set; }
        public Object Dbuscard { get; set; }
        public Object Dbuscarh { get; set; }
        public Object Dbtipo { get; set; }
        public Object Dcod_usuario { get; set; }


        private static SqlParameter Getcod_opago(DOPago OPago)
        {
            SqlParameter Pcod_opago = new SqlParameter
            {
                ParameterName = "@cod_opago",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = OPago.Dcod_opago,
            };
            return Pcod_opago;
        }

        private static SqlParameter Getcod_opagov(DOPago OPago)
        {
            SqlParameter Pcod_opagov = new SqlParameter
            {
                ParameterName = "@cod_opagov",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = OPago.Dcod_opagov,
            };
            return Pcod_opagov;
        }

        private static SqlParameter Getcod_beneficiario(DOPago OPago)
        {
            SqlParameter Pcod_beneficiario = new SqlParameter
            {
                ParameterName = "@cod_beneficiario",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = OPago.Dcod_beneficiario,
            };
            return Pcod_beneficiario;
        }

        private static SqlParameter Getcod_cuenta(DOPago OPago)
        {
            SqlParameter Pcod_cuenta = new SqlParameter
            {
                ParameterName = "@cod_cuenta",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = OPago.Dcod_cuenta,
            };
            return Pcod_cuenta;
        }

        private static SqlParameter Getcod_caja(DOPago OPago)
        {
            SqlParameter Pcod_caja = new SqlParameter
            {
                ParameterName = "@cod_caja",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = OPago.Dcod_caja,
            };
            return Pcod_caja;
        }

        private static SqlParameter Getcod_moneda(DOPago OPago)
        {
            SqlParameter Pcod_moneda = new SqlParameter
            {
                ParameterName = "@cod_moneda",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = OPago.Dcod_moneda,
            };
            return Pcod_moneda;
        }

        private static SqlParameter Getcod_cuentasie(DOPago OPago)
        {
            SqlParameter Pcod_cuentasie = new SqlParameter
            {
                ParameterName = "@cod_cuentasie",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = OPago.Dcod_cuentasie,
            };
            return Pcod_cuentasie;
        }

        private static SqlParameter Getcod_impuesto(DOPago OPago)
        {
            SqlParameter Pcod_impuesto = new SqlParameter
            {
                ParameterName = "@cod_impuesto",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = OPago.Dcod_impuesto,
            };
            return Pcod_impuesto;
        }

        private static SqlParameter Getdesc_opago(DOPago OPago)
        {
            SqlParameter Pdesc_opago = new SqlParameter
            {
                ParameterName = "@desc_opago",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Value = OPago.Ddesc_opago,
            };
            return Pdesc_opago;
        }

        private static SqlParameter Getestatus(DOPago OPago)
        {
            SqlParameter Pestatus = new SqlParameter
            {
                ParameterName = "@estatus",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = OPago.Destatus,
            };
            return Pestatus;
        }

        private static SqlParameter Getnumdocumento(DOPago OPago)
        {
            SqlParameter Pnumdocumento = new SqlParameter
            {
                ParameterName = "@numdocumento",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = OPago.Dnumdocumento,
            };
            return Pnumdocumento;
        }

        private static SqlParameter Getforma(DOPago OPago)
        {
            SqlParameter Pforma = new SqlParameter
            {
                ParameterName = "@forma",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = OPago.Dforma,
            };
            return Pforma;
        }

        private static SqlParameter Getanulado(DOPago OPago)
        {
            SqlParameter Panulado = new SqlParameter
            {
                ParameterName = "@anulado",
                SqlDbType = SqlDbType.Bit,
                Value = OPago.Danulado,
            };
            return Panulado;
        }

        private static SqlParameter Getmontobase(DOPago OPago)
        {
            SqlParameter Pmontobase = new SqlParameter
            {
                ParameterName = "@montobase",
                SqlDbType = SqlDbType.Money,
                Value = OPago.Dmontobase,
            };
            return Pmontobase;
        }

        private static SqlParameter Getmontoimp(DOPago OPago)
        {
            SqlParameter Pmontoimp = new SqlParameter
            {
                ParameterName = "@montoimp",
                SqlDbType = SqlDbType.Money,
                Value = OPago.Dmontoimp,
            };
            return Pmontoimp;
        }

        private static SqlParameter Getmontototal(DOPago OPago)
        {
            SqlParameter Pmontototal = new SqlParameter
            {
                ParameterName = "@montototal",
                SqlDbType = SqlDbType.Money,
                Value = OPago.Dmontototal,
            };
            return Pmontototal;
        }

        private static SqlParameter Getfecha_reg(DOPago OPago)
        {
            SqlParameter Pfecha_reg = new SqlParameter
            {
                ParameterName = "@fecha_reg",
                SqlDbType = SqlDbType.DateTime,
                Value = OPago.Dfecha_reg,
            };
            return Pfecha_reg;
        }

        private static SqlParameter Getfecha_pag(DOPago OPago)
        {
            SqlParameter Pfecha_pag = new SqlParameter
            {
                ParameterName = "@fecha_pag",
                SqlDbType = SqlDbType.DateTime,
                Value = OPago.Dfecha_pag,
            };
            return Pfecha_pag;
        }

        private static SqlParameter Getcampo1(DOPago OPago)
        {
            SqlParameter Pcampo1 = new SqlParameter
            {
                ParameterName = "@campo1",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = OPago.Dcampo1,
            };
            return Pcampo1;
        }

        private static SqlParameter Getcampo2(DOPago OPago)
        {
            SqlParameter Pcampo2 = new SqlParameter
            {
                ParameterName = "@campo2",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = OPago.Dcampo2,
            };
            return Pcampo2;
        }

        private static SqlParameter Getcampo3(DOPago OPago)
        {
            SqlParameter Pcampo3 = new SqlParameter
            {
                ParameterName = "@campo3",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = OPago.Dcampo3,
            };
            return Pcampo3;
        }

        private static SqlParameter Getcampo4(DOPago OPago)
        {
            SqlParameter Pcampo4 = new SqlParameter
            {
                ParameterName = "@campo4",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = OPago.Dcampo4,
            };
            return Pcampo4;
        }

        private static SqlParameter Getcampo5(DOPago OPago)
        {
            SqlParameter Pcampo5 = new SqlParameter
            {
                ParameterName = "@campo5",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = OPago.Dcampo5,
            };
            return Pcampo5;
        }

        private static SqlParameter Getcampo6(DOPago OPago)
        {
            SqlParameter Pcampo6 = new SqlParameter
            {
                ParameterName = "@campo6",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = OPago.Dcampo6,
            };
            return Pcampo6;
        }

        private static SqlParameter Getbuscar(DOPago OPago)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = OPago.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DOPago OPago)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = OPago.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DOPago OPago)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = OPago.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DOPago OPago)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = OPago.Dbtipo,
            };
            return Pbtipo;
        }

        private static SqlParameter Getcod_usuario(DOPago OPago)
        {
            SqlParameter Pcod_usuario = new SqlParameter
            {
                ParameterName = "@cod_usuario",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = OPago.Dcod_usuario,
            };
            return Pcod_usuario;
        }

        #endregion

        public DOPago()
        {
            /// Constructor Vacio
        }

        /// <summary>
        /// Tabla Mostrar No Recibe parametros y Muestra un DataTable
        /// </summary>
        /// <returns> No Recibe Parametros</returns>
        public DataTable Mostrar()
        {
            DataTable DtRpta = new DataTable("TbOPago");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "opago_mostrar",
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
                    CommandText = "opago_listar",
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
        public string Insertar(DOPago OPago)
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
                    CommandText = "opago_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_opago = Getcod_opago(OPago);
                Cmd.Parameters.Add(Parcod_opago);

                SqlParameter Parcod_beneficiario = Getcod_beneficiario(OPago);
                Cmd.Parameters.Add(Parcod_beneficiario);

                SqlParameter Parcod_cuentasie = Getcod_cuentasie(OPago);
                Cmd.Parameters.Add(Parcod_cuentasie);

                SqlParameter Parcod_caja = Getcod_caja(OPago);
                Cmd.Parameters.Add(Parcod_caja);

                SqlParameter Parcod_cuenta = Getcod_cuenta(OPago);
                Cmd.Parameters.Add(Parcod_cuenta);

                SqlParameter Parcod_moneda = Getcod_moneda(OPago);
                Cmd.Parameters.Add(Parcod_moneda);

                SqlParameter Parcod_impuesto = Getcod_impuesto(OPago);
                Cmd.Parameters.Add(Parcod_impuesto);

                SqlParameter Pardesc_opago = Getdesc_opago(OPago);
                Cmd.Parameters.Add(Pardesc_opago);

                SqlParameter Parestatus = Getestatus(OPago);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Parnumdocumento = Getnumdocumento(OPago);
                Cmd.Parameters.Add(Parnumdocumento);

                SqlParameter Parforma = Getforma(OPago);
                Cmd.Parameters.Add(Parforma);

                SqlParameter Paranulado = Getanulado(OPago);
                Cmd.Parameters.Add(Paranulado);

                SqlParameter Parmontobase = Getmontobase(OPago);
                Cmd.Parameters.Add(Parmontobase);

                SqlParameter Parmontoimp = Getmontoimp(OPago);
                Cmd.Parameters.Add(Parmontoimp);

                SqlParameter Parmontototal = Getmontototal(OPago);
                Cmd.Parameters.Add(Parmontototal);

                SqlParameter Parfecha_reg = Getfecha_reg(OPago);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parfecha_pag = Getfecha_pag(OPago);
                Cmd.Parameters.Add(Parfecha_pag);

                SqlParameter Parcampo1 = Getcampo1(OPago);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(OPago);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(OPago);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(OPago);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(OPago);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(OPago);
                Cmd.Parameters.Add(Parcampo6);

                SqlParameter Parcod_usuario = Getcod_usuario(OPago);
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
        public string Editar(DOPago OPago)
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
                    CommandText = "opago_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_opago = Getcod_opago(OPago);
                Cmd.Parameters.Add(Parcod_opago);

                SqlParameter Parcod_opagov = Getcod_opagov(OPago);
                Cmd.Parameters.Add(Parcod_opagov);

                SqlParameter Parcod_beneficiario = Getcod_beneficiario(OPago);
                Cmd.Parameters.Add(Parcod_beneficiario);

                SqlParameter Parcod_cuentasie = Getcod_cuentasie(OPago);
                Cmd.Parameters.Add(Parcod_cuentasie);

                SqlParameter Parcod_caja = Getcod_caja(OPago);
                Cmd.Parameters.Add(Parcod_caja);

                SqlParameter Parcod_cuenta = Getcod_cuenta(OPago);
                Cmd.Parameters.Add(Parcod_cuenta);

                SqlParameter Parcod_moneda = Getcod_moneda(OPago);
                Cmd.Parameters.Add(Parcod_moneda);

                SqlParameter Parcod_impuesto = Getcod_impuesto(OPago);
                Cmd.Parameters.Add(Parcod_impuesto);

                SqlParameter Pardesc_opago = Getdesc_opago(OPago);
                Cmd.Parameters.Add(Pardesc_opago);

                SqlParameter Parestatus = Getestatus(OPago);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Parnumdocumento = Getnumdocumento(OPago);
                Cmd.Parameters.Add(Parnumdocumento);

                SqlParameter Parforma = Getforma(OPago);
                Cmd.Parameters.Add(Parforma);

                SqlParameter Paranulado = Getanulado(OPago);
                Cmd.Parameters.Add(Paranulado);

                SqlParameter Parmontobase = Getmontobase(OPago);
                Cmd.Parameters.Add(Parmontobase);

                SqlParameter Parmontoimp = Getmontoimp(OPago);
                Cmd.Parameters.Add(Parmontoimp);

                SqlParameter Parmontototal = Getmontototal(OPago);
                Cmd.Parameters.Add(Parmontototal);

                SqlParameter Parfecha_reg = Getfecha_reg(OPago);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parfecha_pag = Getfecha_pag(OPago);
                Cmd.Parameters.Add(Parfecha_pag);

                SqlParameter Parcampo1 = Getcampo1(OPago);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(OPago);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(OPago);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(OPago);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(OPago);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(OPago);
                Cmd.Parameters.Add(Parcampo6);

                SqlParameter Parcod_usuario = Getcod_usuario(OPago);
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
        public string Eliminar(DOPago OPago)
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
                    CommandText = "opago_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_opago = Getcod_opago(OPago);
                Cmd.Parameters.Add(Parcod_opago);

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
        /// Metodo Procesar Datos Recibe 8 Parametros
        /// </summary>
        /// <returns> 8 Parametros</returns>
        public string Procesar(DOPago OPago)
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
                    CommandText = "opago_procesar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_opago = Getcod_opago(OPago);
                Cmd.Parameters.Add(Parcod_opago);

                SqlParameter Parestatus = Getestatus(OPago);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Parcod_usuario = Getcod_usuario(OPago);
                Cmd.Parameters.Add(Parcod_usuario); ;

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
                else if (Exc.Number == 547)
                {
                    Rpta = "No se Pueden Editar Registros Relacionados   **" + Exc.StackTrace + " **";
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
        /// Metodo Anular Datos Recibe 1 Parametro
        /// </summary>
        /// <returns> Recibe Parametros</returns>
        public string Anular(DOPago OPago)
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
                    CommandText = "opago_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_opago = Getcod_opago(OPago);
                Cmd.Parameters.Add(Parcod_opago);

                SqlParameter Parestatus = Getestatus(OPago);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Paranulado = Getanulado(OPago);
                Cmd.Parameters.Add(Paranulado);

                SqlParameter Parcod_usuario = Getcod_usuario(OPago);
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
        /// Metodo Buscar Datos Recibe 2 Parametros
        /// </summary>
        public DataTable Buscar(DOPago OPago)
        {
            DataTable DtRpta = new DataTable("TbOPago");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "opago_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(OPago);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(OPago);
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
        public DataTable RepBuscar(DOPago OPago)
        {
            DataTable DtRpta = new DataTable("TbOPago");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "opago_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(OPago);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(OPago);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(OPago);
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
                    CommandText = "opago_primero",
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
                    CommandText = "opago_ultimo",
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
        /// <param name="Listar Anterior OPago"></param>
        public DataSet Anterior(DOPago OPago)
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
                    CommandText = "opago_anterior",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_opago = Getcod_opago(OPago);
                Cmd.Parameters.Add(Parcod_opago);

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
        /// <param name="Listar Siguiente OPago"></param>
        public DataSet Siguiente(DOPago OPago)
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
                    CommandText = "opago_siguiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_opago = Getcod_opago(OPago);
                Cmd.Parameters.Add(Parcod_opago);

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
        public string GenerarCod(DOPago OPago)
        {
            SqlConnection SqlConn = new SqlConnection
            {
                ConnectionString = DConexion.Cn
            };

            SqlConn.Open();
            SqlCommand Cmd = new SqlCommand
            {
                Connection = SqlConn,
                CommandText = "opago_generar_cod",
                CommandType = CommandType.StoredProcedure,
            };

            try
            {
                SqlParameter ParCod_opago = new SqlParameter("@cod_opago", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                    Value = OPago.Dcod_opago
                };
                Cmd.Parameters.Add(ParCod_opago);

                if (Cmd.ExecuteNonQuery() == 0)
                {
                    return Cmd.Parameters[ParCod_opago.ToString()].Value.ToString();
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
            return Cmd.Parameters["@cod_opago"].Value.ToString();
        }
    }
}
