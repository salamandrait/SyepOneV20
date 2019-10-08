using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DCuenta
    {

        #region PARAMETROS
        public Object Dcod_cuenta { get; set; }
        public Object Dcod_cuentav { get; set; }
        public Object Ddesc_cuenta { get; set; }
        public Object Dcod_banco { get; set; }
        public Object Dcod_moneda { get; set; }
        public Object Dtipocuenta { get; set; }
        public Object Dnumcuenta { get; set; }
        public Object Dresponsable { get; set; }
        public Object Dagencia { get; set; }
        public Object Dejecutivo { get; set; }
        public Object Ddireccion { get; set; }
        public Object Dtelefono { get; set; }
        public Object Demail { get; set; }
        public Object Dsaldod { get; set; }
        public Object Dsaldoh { get; set; }
        public Object Dsaldo { get; set; }
        public Object Dfecha_reg { get; set; }
        public Object Dfecharegcheq { get; set; }
        public Object Dactiva { get; set; }
        public Object Dchequera { get; set; }
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


        private static SqlParameter Getcod_cuenta(DCuenta Cuenta)
        {
            SqlParameter Pcod_cuenta = new SqlParameter
            {
                ParameterName = "@cod_cuenta",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Cuenta.Dcod_cuenta,
            };
            return Pcod_cuenta;
        }

        private static SqlParameter Getcod_cuentav(DCuenta Cuenta)
        {
            SqlParameter Pcod_cuentav = new SqlParameter
            {
                ParameterName = "@cod_cuentav",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Cuenta.Dcod_cuentav,
            };
            return Pcod_cuentav;
        }

        private static SqlParameter Getdesc_cuenta(DCuenta Cuenta)
        {
            SqlParameter Pdesc_cuenta = new SqlParameter
            {
                ParameterName = "@desc_cuenta",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Value = Cuenta.Ddesc_cuenta,
            };
            return Pdesc_cuenta;
        }

        private static SqlParameter Getcod_banco(DCuenta Cuenta)
        {
            SqlParameter Pcod_banco = new SqlParameter
            {
                ParameterName = "@cod_banco",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Cuenta.Dcod_banco,
            };
            return Pcod_banco;
        }

        private static SqlParameter Getcod_moneda(DCuenta Cuenta)
        {
            SqlParameter Pcod_moneda = new SqlParameter
            {
                ParameterName = "@cod_moneda",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Cuenta.Dcod_moneda,
            };
            return Pcod_moneda;
        }

        private static SqlParameter Gettipocuenta(DCuenta Cuenta)
        {
            SqlParameter Ptipocuenta = new SqlParameter
            {
                ParameterName = "@tipocuenta",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cuenta.Dtipocuenta
            };
            return Ptipocuenta;
        }

        private static SqlParameter Getnumcuenta(DCuenta Cuenta)
        {
            SqlParameter Pnumcuenta = new SqlParameter
            {
                ParameterName = "@numcuenta",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cuenta.Dnumcuenta
            };
            return Pnumcuenta;
        }

        private static SqlParameter Getresponsable(DCuenta Cuenta)
        {
            SqlParameter Presponsable = new SqlParameter
            {
                ParameterName = "@responsable",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cuenta.Dresponsable
            };
            return Presponsable;
        }

        private static SqlParameter Getagencia(DCuenta Cuenta)
        {
            SqlParameter Pagencia = new SqlParameter
            {
                ParameterName = "@agencia",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cuenta.Dagencia
            };
            return Pagencia;
        }

        private static SqlParameter Getejecutivo(DCuenta Cuenta)
        {
            SqlParameter Pejecutivo = new SqlParameter
            {
                ParameterName = "@ejecutivo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cuenta.Dejecutivo
            };
            return Pejecutivo;
        }

        private static SqlParameter Getdireccion(DCuenta Cuenta)
        {
            SqlParameter Pdireccion = new SqlParameter
            {
                ParameterName = "@direccion",
                SqlDbType = SqlDbType.VarChar,
                Size = 250,
                Value = Cuenta.Ddireccion
            };
            return Pdireccion;
        }

        private static SqlParameter Gettelefono(DCuenta Cuenta)
        {
            SqlParameter Ptelefono = new SqlParameter
            {
                ParameterName = "@telefono",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cuenta.Dtelefono
            };
            return Ptelefono;
        }

        private static SqlParameter Getemail(DCuenta Cuenta)
        {
            SqlParameter Pemail = new SqlParameter
            {
                ParameterName = "@email",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cuenta.Demail
            };
            return Pemail;
        }

        private static SqlParameter Getsaldod(DCuenta Cuenta)
        {
            SqlParameter Psaldod = new SqlParameter
            {
                ParameterName = "@saldod",
                SqlDbType = SqlDbType.Money,
                Value = Cuenta.Dsaldod
            };
            return Psaldod;
        }

        private static SqlParameter Getsaldoh(DCuenta Cuenta)
        {
            SqlParameter Psaldoh = new SqlParameter
            {
                ParameterName = "@saldoh",
                SqlDbType = SqlDbType.Money,
                Value = Cuenta.Dsaldoh
            };
            return Psaldoh;
        }

        private static SqlParameter Getsaldo(DCuenta Cuenta)
        {
            SqlParameter Psaldo = new SqlParameter
            {
                ParameterName = "@saldo",
                SqlDbType = SqlDbType.Money,
                Value = Cuenta.Dsaldo
            };
            return Psaldo;
        }

        private static SqlParameter Getfecha_reg(DCuenta Cuenta)
        {
            SqlParameter Pfecha_reg = new SqlParameter
            {
                ParameterName = "@fecha_reg",
                SqlDbType = SqlDbType.DateTime,
                Value = Cuenta.Dfecha_reg
            };
            return Pfecha_reg;
        }

        private static SqlParameter Getfecharegcheq(DCuenta Cuenta)
        {
            SqlParameter Pfecharegcheq = new SqlParameter
            {
                ParameterName = "@fecharegcheq",
                SqlDbType = SqlDbType.DateTime,
                Value = Cuenta.Dfecharegcheq
            };
            return Pfecharegcheq;
        }

        private static SqlParameter Getactiva(DCuenta Cuenta)
        {
            SqlParameter Pactiva = new SqlParameter
            {
                ParameterName = "@activa",
                SqlDbType = SqlDbType.Bit,
                Value = Cuenta.Dactiva
            };
            return Pactiva;
        }

        private static SqlParameter Getchequera(DCuenta Cuenta)
        {
            SqlParameter Pchequera = new SqlParameter
            {
                ParameterName = "@chequera",
                SqlDbType = SqlDbType.Bit,
                Value = Cuenta.Dchequera
            };
            return Pchequera;
        }

        private static SqlParameter Getcampo1(DCuenta Cuenta)
        {
            SqlParameter Pcampo1 = new SqlParameter
            {
                ParameterName = "@campo1",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cuenta.Dcampo1,
            };
            return Pcampo1;
        }

        private static SqlParameter Getcampo2(DCuenta Cuenta)
        {
            SqlParameter Pcampo2 = new SqlParameter
            {
                ParameterName = "@campo2",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cuenta.Dcampo2,
            };
            return Pcampo2;
        }

        private static SqlParameter Getcampo3(DCuenta Cuenta)
        {
            SqlParameter Pcampo3 = new SqlParameter
            {
                ParameterName = "@campo3",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Cuenta.Dcampo3,
            };
            return Pcampo3;
        }

        private static SqlParameter Getcampo4(DCuenta Cuenta)
        {
            SqlParameter Pcampo4 = new SqlParameter
            {
                ParameterName = "@campo4",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cuenta.Dcampo4,
            };
            return Pcampo4;
        }

        private static SqlParameter Getcampo5(DCuenta Cuenta)
        {
            SqlParameter Pcampo5 = new SqlParameter
            {
                ParameterName = "@campo5",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cuenta.Dcampo5,
            };
            return Pcampo5;
        }

        private static SqlParameter Getcampo6(DCuenta Cuenta)
        {
            SqlParameter Pcampo6 = new SqlParameter
            {
                ParameterName = "@campo6",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cuenta.Dcampo6,
            };
            return Pcampo6;
        }

        private static SqlParameter Getbuscar(DCuenta Cuenta)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cuenta.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DCuenta Cuenta)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cuenta.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DCuenta Cuenta)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cuenta.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DCuenta Cuenta)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cuenta.Dbtipo,
            };
            return Pbtipo;
        }

        #endregion

        public DCuenta()
        {
            /// Constructor Vacio
        }


        /// <summary>
        /// Tabla Mostrar No Recibe parametros y Muestra un DataTable
        /// </summary>
        /// <returns> No Recibe Parametros</returns>
        public DataTable Mostrar()
        {
            DataTable DtRpta = new DataTable("TbCuenta");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "cuenta_mostrar",
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
                    CommandText = "cuenta_listar",
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
        /// Tabla Listar No Recibe parametros y Muestra un DataSet
        /// </summary>
        /// <returns> No Recibe Parametros</returns>
        public DataSet BuscarCodCuenta(DCuenta Cuenta)
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
                    CommandText = "cuenta_listar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_cuenta = Getcod_cuenta(Cuenta);
                Cmd.Parameters.Add(Parcod_cuenta);

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
        public string Insertar(DCuenta Cuenta)
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
                    CommandText = "cuenta_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                #region PARAMETROS SQL
                SqlParameter Parcod_cuenta = Getcod_cuenta(Cuenta);
                Cmd.Parameters.Add(Parcod_cuenta);

                SqlParameter Pardesc_cuenta = Getdesc_cuenta(Cuenta);
                Cmd.Parameters.Add(Pardesc_cuenta);

                SqlParameter Parcod_banco = Getcod_banco(Cuenta);
                Cmd.Parameters.Add(Parcod_banco);

                SqlParameter Parcod_moneda = Getcod_moneda(Cuenta);
                Cmd.Parameters.Add(Parcod_moneda);

                SqlParameter Partipocuenta = Gettipocuenta(Cuenta);
                Cmd.Parameters.Add(Partipocuenta);

                SqlParameter Parnumcuenta = Getnumcuenta(Cuenta);
                Cmd.Parameters.Add(Parnumcuenta);

                SqlParameter Parresponsable = Getresponsable(Cuenta);
                Cmd.Parameters.Add(Parresponsable);

                SqlParameter Paragencia = Getagencia(Cuenta);
                Cmd.Parameters.Add(Paragencia);

                SqlParameter Parejecutivo = Getejecutivo(Cuenta);
                Cmd.Parameters.Add(Parejecutivo);

                SqlParameter Pardireccion = Getdireccion(Cuenta);
                Cmd.Parameters.Add(Pardireccion);

                SqlParameter Partelefono = Gettelefono(Cuenta);
                Cmd.Parameters.Add(Partelefono);

                SqlParameter Paremail = Getemail(Cuenta);
                Cmd.Parameters.Add(Paremail);

                SqlParameter Parsaldod = Getsaldod(Cuenta);
                Cmd.Parameters.Add(Parsaldod);

                SqlParameter Parsaldoh = Getsaldoh(Cuenta);
                Cmd.Parameters.Add(Parsaldoh);

                SqlParameter Parsaldo = Getsaldo(Cuenta);
                Cmd.Parameters.Add(Parsaldo);

                SqlParameter Parfecha_reg = Getfecha_reg(Cuenta);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parfecharegcheq = Getfecharegcheq(Cuenta);
                Cmd.Parameters.Add(Parfecharegcheq);

                SqlParameter Paractiva = Getactiva(Cuenta);
                Cmd.Parameters.Add(Paractiva);

                SqlParameter Parchequera = Getchequera(Cuenta);
                Cmd.Parameters.Add(Parchequera);

                SqlParameter Parcampo1 = Getcampo1(Cuenta);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Cuenta);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Cuenta);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Cuenta);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Cuenta);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Cuenta);
                Cmd.Parameters.Add(Parcampo6); 
                #endregion

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
        public string Editar(DCuenta Cuenta)
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
                    CommandText = "cuenta_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                #region PARAMETROS SQL
                SqlParameter Parcod_cuenta = Getcod_cuenta(Cuenta);
                Cmd.Parameters.Add(Parcod_cuenta);

                SqlParameter Parcod_cuentav = Getcod_cuentav(Cuenta);
                Cmd.Parameters.Add(Parcod_cuentav);

                SqlParameter Pardesc_cuenta = Getdesc_cuenta(Cuenta);
                Cmd.Parameters.Add(Pardesc_cuenta);

                SqlParameter Parcod_banco = Getcod_banco(Cuenta);
                Cmd.Parameters.Add(Parcod_banco);

                SqlParameter Parcod_moneda = Getcod_moneda(Cuenta);
                Cmd.Parameters.Add(Parcod_moneda);

                SqlParameter Partipocuenta = Gettipocuenta(Cuenta);
                Cmd.Parameters.Add(Partipocuenta);

                SqlParameter Parnumcuenta = Getnumcuenta(Cuenta);
                Cmd.Parameters.Add(Parnumcuenta);

                SqlParameter Parresponsable = Getresponsable(Cuenta);
                Cmd.Parameters.Add(Parresponsable);

                SqlParameter Paragencia = Getagencia(Cuenta);
                Cmd.Parameters.Add(Paragencia);

                SqlParameter Parejecutivo = Getejecutivo(Cuenta);
                Cmd.Parameters.Add(Parejecutivo);

                SqlParameter Pardireccion = Getdireccion(Cuenta);
                Cmd.Parameters.Add(Pardireccion);

                SqlParameter Partelefono = Gettelefono(Cuenta);
                Cmd.Parameters.Add(Partelefono);

                SqlParameter Paremail = Getemail(Cuenta);
                Cmd.Parameters.Add(Paremail);

                SqlParameter Parsaldod = Getsaldod(Cuenta);
                Cmd.Parameters.Add(Parsaldod);

                SqlParameter Parsaldoh = Getsaldoh(Cuenta);
                Cmd.Parameters.Add(Parsaldoh);

                SqlParameter Parsaldo = Getsaldo(Cuenta);
                Cmd.Parameters.Add(Parsaldo);

                SqlParameter Parfecha_reg = Getfecha_reg(Cuenta);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parfecharegcheq = Getfecharegcheq(Cuenta);
                Cmd.Parameters.Add(Parfecharegcheq);

                SqlParameter Paractiva = Getactiva(Cuenta);
                Cmd.Parameters.Add(Paractiva);

                SqlParameter Parchequera = Getchequera(Cuenta);
                Cmd.Parameters.Add(Parchequera);

                SqlParameter Parcampo1 = Getcampo1(Cuenta);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Cuenta);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Cuenta);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Cuenta);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Cuenta);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Cuenta);
                Cmd.Parameters.Add(Parcampo6);
                #endregion

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
        public string Eliminar(DCuenta Cuenta)
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
                    CommandText = "cuenta_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_cuenta = Getcod_cuenta(Cuenta);
                Cmd.Parameters.Add(Parcod_cuenta);

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
        public DataTable Buscar(DCuenta Cuenta)
        {
            DataTable DtRpta = new DataTable("TbCuenta");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "cuenta_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(Cuenta);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(Cuenta);
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
        public DataTable RepBuscar(DCuenta Cuenta)
        {
            DataTable DtRpta = new DataTable("TbCuenta");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "cuenta_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(Cuenta);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(Cuenta);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(Cuenta);
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
                    CommandText = "cuenta_primero",
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
                    CommandText = "cuenta_ultimo",
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
        /// <param name="Listar Anterior Cuenta"></param>
        public DataSet Anterior(DCuenta Cuenta)
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
                    CommandText = "cuenta_anterior",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_cuenta = Getcod_cuenta(Cuenta);
                Cmd.Parameters.Add(Parcod_cuenta);

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
        /// <param name="Listar Siguiente Cuenta"></param>
        public DataSet Siguiente(DCuenta Cuenta)
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
                    CommandText = "cuenta_siguiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_cuenta = Getcod_cuenta(Cuenta);
                Cmd.Parameters.Add(Parcod_cuenta);

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
        public string GenerarCod(DCuenta Cuenta)
        {
            SqlConnection SqlConn = new SqlConnection
            {
                ConnectionString = DConexion.Cn
            };

            SqlConn.Open();
            SqlCommand Cmd = new SqlCommand
            {
                Connection = SqlConn,
                CommandText = "cuenta_generar_cod",
                CommandType = CommandType.StoredProcedure,
            };

            try
            {
                SqlParameter ParCod_cuenta = new SqlParameter("@cod_cuenta", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                    Value = Cuenta.Dcod_cuenta
                };
                Cmd.Parameters.Add(ParCod_cuenta);

                if (Cmd.ExecuteNonQuery() == 0)
                {
                    return Cmd.Parameters[ParCod_cuenta.ToString()].Value.ToString();
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
            return Cmd.Parameters["@cod_cuenta"].Value.ToString();
        }
    }
}
