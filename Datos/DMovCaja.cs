using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DMovCaja
    {
        #region PARAMETROS
        public Object Dcod_movcaja { get; set; }
        public Object Dcod_movcajav { get; set; }
        public Object Dcod_caja { get; set; }
        public Object Dcod_banco { get; set; }
        public Object Dcod_tarjeta { get; set; }
        public Object Dcod_cuentasie { get; set; }
        public Object Ddesc_movcaja { get; set; }
        public Object Dtipomov { get; set; }
        public Object Doptipo { get; set; }
        public Object Dforma { get; set; }
        public Object Dnumdoc { get; set; }
        public Object Dnumop { get; set; }
        public Object Dorigen { get; set; }
        public Object Destatus { get; set; }
        public Object Dmontod { get; set; }
        public Object Dmontoh { get; set; }
        public Object Dfecha_reg { get; set; }
        public Object Dsaldoinicial { get; set; }
        public Object Danulado { get; set; }
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

        private static SqlParameter Getcod_movcaja(DMovCaja MovCaja)
        {
            SqlParameter Pcod_movcaja = new SqlParameter
            {
                ParameterName = "@cod_movcaja",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = MovCaja.Dcod_movcaja,
            };
            return Pcod_movcaja;
        }

        private static SqlParameter Getcod_movcajav(DMovCaja MovCaja)
        {
            SqlParameter Pcod_movcajav = new SqlParameter
            {
                ParameterName = "@cod_movcajav",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = MovCaja.Dcod_movcajav,
            };
            return Pcod_movcajav;
        }

        private static SqlParameter Getcod_caja(DMovCaja MovCaja)
        {
            SqlParameter Pcod_caja = new SqlParameter
            {
                ParameterName = "@cod_caja",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = MovCaja.Dcod_caja,
            };
            return Pcod_caja;
        }

        private static SqlParameter Getcod_banco(DMovCaja MovCaja)
        {
            SqlParameter Pcod_banco = new SqlParameter
            {
                ParameterName = "@cod_banco",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = MovCaja.Dcod_banco,
            };
            return Pcod_banco;
        }

        private static SqlParameter Getcod_tarjeta(DMovCaja MovCaja)
        {
            SqlParameter Pcod_tarjeta = new SqlParameter
            {
                ParameterName = "@cod_tarjeta",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = MovCaja.Dcod_tarjeta,
            };
            return Pcod_tarjeta;
        }

        private static SqlParameter Getcod_cuentasie(DMovCaja MovCaja)
        {
            SqlParameter Pcod_cuentasie = new SqlParameter
            {
                ParameterName = "@cod_cuentasie",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = MovCaja.Dcod_cuentasie,
            };
            return Pcod_cuentasie;
        }

        private static SqlParameter Getdesc_movcaja(DMovCaja MovCaja)
        {
            SqlParameter Pdesc_movcaja = new SqlParameter
            {
                ParameterName = "@desc_movcaja",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Value = MovCaja.Ddesc_movcaja,
            };
            return Pdesc_movcaja;
        }

        private static SqlParameter Gettipomov(DMovCaja MovCaja)
        {
            SqlParameter Ptipomov = new SqlParameter
            {
                ParameterName = "@tipomov",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovCaja.Dtipomov,
            };
            return Ptipomov;
        }

        private static SqlParameter Getoptipo(DMovCaja MovCaja)
        {
            SqlParameter Poptipo = new SqlParameter
            {
                ParameterName = "@optipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovCaja.Doptipo,
            };
            return Poptipo;
        }

        private static SqlParameter Getforma(DMovCaja MovCaja)
        {
            SqlParameter Pforma = new SqlParameter
            {
                ParameterName = "@forma",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovCaja.Dforma,
            };
            return Pforma;
        }

        private static SqlParameter Getnumdoc(DMovCaja MovCaja)
        {
            SqlParameter Pnumdoc = new SqlParameter
            {
                ParameterName = "@numdoc",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovCaja.Dnumdoc,
            };
            return Pnumdoc;
        }

        private static SqlParameter Getnumop(DMovCaja MovCaja)
        {
            SqlParameter Pnumop = new SqlParameter
            {
                ParameterName = "@numop",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovCaja.Dnumop,
            };
            return Pnumop;
        }

        private static SqlParameter Getorigen(DMovCaja MovCaja)
        {
            SqlParameter Porigen = new SqlParameter
            {
                ParameterName = "@origen",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovCaja.Dorigen,
            };
            return Porigen;
        }

        private static SqlParameter Getestatus(DMovCaja MovCaja)
        {
            SqlParameter Pestatus = new SqlParameter
            {
                ParameterName = "@estatus",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovCaja.Destatus,
            };
            return Pestatus;
        }

        private static SqlParameter Getmontod(DMovCaja MovCaja)
        {
            SqlParameter Pmontod = new SqlParameter
            {
                ParameterName = "@montod",
                SqlDbType = SqlDbType.Money,
                Value = MovCaja.Dmontod,
            };
            return Pmontod;
        }

        private static SqlParameter Getmontoh(DMovCaja MovCaja)
        {
            SqlParameter Pmontoh = new SqlParameter
            {
                ParameterName = "@montoh",
                SqlDbType = SqlDbType.Money,
                Value = MovCaja.Dmontoh,
            };
            return Pmontoh;
        }

        private static SqlParameter Getfecha_reg(DMovCaja MovCaja)
        {
            SqlParameter Pfecha_reg = new SqlParameter
            {
                ParameterName = "@fecha_reg",
                SqlDbType = SqlDbType.DateTime,
                Value = MovCaja.Dfecha_reg,
            };
            return Pfecha_reg;
        }

        private static SqlParameter Getsaldoinicial(DMovCaja MovCaja)
        {
            SqlParameter Psaldoinicial = new SqlParameter
            {
                ParameterName = "@saldoinicial",
                SqlDbType = SqlDbType.Bit,
                Value = MovCaja.Dsaldoinicial,
            };
            return Psaldoinicial;
        }

        private static SqlParameter Getanulado(DMovCaja MovCaja)
        {
            SqlParameter Panulado = new SqlParameter
            {
                ParameterName = "@anulado",
                SqlDbType = SqlDbType.Bit,
                Value = MovCaja.Danulado,
            };
            return Panulado;
        }

        private static SqlParameter Getcampo1(DMovCaja MovCaja)
        {
            SqlParameter Pcampo1 = new SqlParameter
            {
                ParameterName = "@campo1",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovCaja.Dcampo1,
            };
            return Pcampo1;
        }

        private static SqlParameter Getcampo2(DMovCaja MovCaja)
        {
            SqlParameter Pcampo2 = new SqlParameter
            {
                ParameterName = "@campo2",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovCaja.Dcampo2,
            };
            return Pcampo2;
        }

        private static SqlParameter Getcampo3(DMovCaja MovCaja)
        {
            SqlParameter Pcampo3 = new SqlParameter
            {
                ParameterName = "@campo3",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovCaja.Dcampo3,
            };
            return Pcampo3;
        }

        private static SqlParameter Getcampo4(DMovCaja MovCaja)
        {
            SqlParameter Pcampo4 = new SqlParameter
            {
                ParameterName = "@campo4",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovCaja.Dcampo4,
            };
            return Pcampo4;
        }

        private static SqlParameter Getcampo5(DMovCaja MovCaja)
        {
            SqlParameter Pcampo5 = new SqlParameter
            {
                ParameterName = "@campo5",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovCaja.Dcampo5,
            };
            return Pcampo5;
        }

        private static SqlParameter Getcampo6(DMovCaja MovCaja)
        {
            SqlParameter Pcampo6 = new SqlParameter
            {
                ParameterName = "@campo6",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovCaja.Dcampo6,
            };
            return Pcampo6;
        }

        private static SqlParameter Getcod_usuario(DMovCaja MovCaja)
        {
            SqlParameter Pcod_usuario = new SqlParameter
            {
                ParameterName = "@cod_usuario",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = MovCaja.Dcod_usuario,
            };
            return Pcod_usuario;
        }

        private static SqlParameter Getbuscard(DMovCaja MovCaja)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovCaja.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DMovCaja MovCaja)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovCaja.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbuscar(DMovCaja MovCaja)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovCaja.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbtipo(DMovCaja MovCaja)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovCaja.Dbtipo,
            };
            return Pbtipo;
        }
        #endregion

        public DMovCaja()
        {
        }


        /// <summary>
        /// Tabla Mostrar No Recibe parametros y Muestra un DataTable
        /// </summary>
        /// <returns> No Recibe Parametros</returns>
        public DataTable Mostrar()
        {
            DataTable DtRpta = new DataTable("TbMovCaja");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "movcaja_mostrar",
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
                    CommandText = "movcaja_listar",
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
        public string Insertar(DMovCaja MovCaja)
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
                    CommandText = "movcaja_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_movcaja = Getcod_movcaja(MovCaja);
                Cmd.Parameters.Add(Parcod_movcaja);

                SqlParameter Parcod_caja = Getcod_caja(MovCaja);
                Cmd.Parameters.Add(Parcod_caja);

                SqlParameter Parcod_banco = Getcod_banco(MovCaja);
                Cmd.Parameters.Add(Parcod_banco);

                SqlParameter Parcod_tarjeta = Getcod_tarjeta(MovCaja);
                Cmd.Parameters.Add(Parcod_tarjeta);

                SqlParameter Parcod_cuentasie = Getcod_cuentasie(MovCaja);
                Cmd.Parameters.Add(Parcod_cuentasie);

                SqlParameter Pardesc_movcaja = Getdesc_movcaja(MovCaja);
                Cmd.Parameters.Add(Pardesc_movcaja);

                SqlParameter Partipomov = Gettipomov(MovCaja);
                Cmd.Parameters.Add(Partipomov);

                SqlParameter Paroptipo = Getoptipo(MovCaja);
                Cmd.Parameters.Add(Paroptipo);

                SqlParameter Parforma = Getforma(MovCaja);
                Cmd.Parameters.Add(Parforma);

                SqlParameter Parnumdoc = Getnumdoc(MovCaja);
                Cmd.Parameters.Add(Parnumdoc);

                SqlParameter Parnumop = Getnumop(MovCaja);
                Cmd.Parameters.Add(Parnumop);

                SqlParameter Parorigen = Getorigen(MovCaja);
                Cmd.Parameters.Add(Parorigen);

                SqlParameter Parestatus = Getestatus(MovCaja);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Parmontod = Getmontod(MovCaja);
                Cmd.Parameters.Add(Parmontod);

                SqlParameter Parmontoh = Getmontoh(MovCaja);
                Cmd.Parameters.Add(Parmontoh);

                SqlParameter Parfecha_reg = Getfecha_reg(MovCaja);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parsaldoinicial = Getsaldoinicial(MovCaja);
                Cmd.Parameters.Add(Parsaldoinicial);

                SqlParameter Paranulado = Getanulado(MovCaja);
                Cmd.Parameters.Add(Paranulado);

                SqlParameter Parcampo1 = Getcampo1(MovCaja);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(MovCaja);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(MovCaja);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(MovCaja);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(MovCaja);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(MovCaja);
                Cmd.Parameters.Add(Parcampo6);

                SqlParameter Parcod_usuario = Getcod_usuario(MovCaja);
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
        public string Editar(DMovCaja MovCaja)
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
                    CommandText = "movcaja_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_movcaja = Getcod_movcaja(MovCaja);
                Cmd.Parameters.Add(Parcod_movcaja);

                SqlParameter Parcod_movcajav = Getcod_movcajav(MovCaja);
                Cmd.Parameters.Add(Parcod_movcajav);

                SqlParameter Parcod_caja = Getcod_caja(MovCaja);
                Cmd.Parameters.Add(Parcod_caja);

                SqlParameter Parcod_banco = Getcod_banco(MovCaja);
                Cmd.Parameters.Add(Parcod_banco);

                SqlParameter Parcod_tarjeta = Getcod_tarjeta(MovCaja);
                Cmd.Parameters.Add(Parcod_tarjeta);

                SqlParameter Parcod_cuentasie = Getcod_cuentasie(MovCaja);
                Cmd.Parameters.Add(Parcod_cuentasie);

                SqlParameter Pardesc_movcaja = Getdesc_movcaja(MovCaja);
                Cmd.Parameters.Add(Pardesc_movcaja);

                SqlParameter Partipomov = Gettipomov(MovCaja);
                Cmd.Parameters.Add(Partipomov);

                SqlParameter Paroptipo = Getoptipo(MovCaja);
                Cmd.Parameters.Add(Paroptipo);

                SqlParameter Parforma = Getforma(MovCaja);
                Cmd.Parameters.Add(Parforma);

                SqlParameter Parnumdoc = Getnumdoc(MovCaja);
                Cmd.Parameters.Add(Parnumdoc);

                SqlParameter Parnumop = Getnumop(MovCaja);
                Cmd.Parameters.Add(Parnumop);

                SqlParameter Parorigen = Getorigen(MovCaja);
                Cmd.Parameters.Add(Parorigen);

                SqlParameter Parestatus = Getestatus(MovCaja);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Parmontod = Getmontod(MovCaja);
                Cmd.Parameters.Add(Parmontod);

                SqlParameter Parmontoh = Getmontoh(MovCaja);
                Cmd.Parameters.Add(Parmontoh);

                SqlParameter Parfecha_reg = Getfecha_reg(MovCaja);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parsaldoinicial = Getsaldoinicial(MovCaja);
                Cmd.Parameters.Add(Parsaldoinicial);

                SqlParameter Paranulado = Getanulado(MovCaja);
                Cmd.Parameters.Add(Paranulado);

                SqlParameter Parcampo1 = Getcampo1(MovCaja);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(MovCaja);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(MovCaja);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(MovCaja);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(MovCaja);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(MovCaja);
                Cmd.Parameters.Add(Parcampo6);

                SqlParameter Parcod_usuario = Getcod_usuario(MovCaja);
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
        public string Eliminar(DMovCaja MovCaja)
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
                    CommandText = "movcaja_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_movcaja = Getcod_movcaja(MovCaja);
                Cmd.Parameters.Add(Parcod_movcaja);

                SqlParameter Parcod_caja = Getcod_caja(MovCaja);
                Cmd.Parameters.Add(Parcod_caja);

                SqlParameter Paroptipo = Getoptipo(MovCaja);
                Cmd.Parameters.Add(Paroptipo);

                SqlParameter Parforma = Getforma(MovCaja);
                Cmd.Parameters.Add(Parforma);

                SqlParameter Parmontod = Getmontod(MovCaja);
                Cmd.Parameters.Add(Parmontod);

                SqlParameter Parmontoh = Getmontoh(MovCaja);
                Cmd.Parameters.Add(Parmontoh);


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
        /// Metodo Eliminar Datos Recibe 1 Parametro
        /// </summary>
        /// <returns> Recibe Parametros</returns>
        public string Anular(DMovCaja MovCaja)
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
                    CommandText = "movcaja_anular",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_movcaja = Getcod_movcaja(MovCaja);
                Cmd.Parameters.Add(Parcod_movcaja);

                SqlParameter Parcod_caja = Getcod_caja(MovCaja);
                Cmd.Parameters.Add(Parcod_caja);

                SqlParameter Paroptipo = Getoptipo(MovCaja);
                Cmd.Parameters.Add(Paroptipo);

                SqlParameter Parforma = Getforma(MovCaja);
                Cmd.Parameters.Add(Parforma);

                SqlParameter Parestatus = Getestatus(MovCaja);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Parmontod = Getmontod(MovCaja);
                Cmd.Parameters.Add(Parmontod);

                SqlParameter Parmontoh = Getmontoh(MovCaja);
                Cmd.Parameters.Add(Parmontoh);

                SqlParameter Paranulado = Getanulado(MovCaja);
                Cmd.Parameters.Add(Paranulado);

                SqlParameter Parcod_usuario = Getcod_usuario(MovCaja);
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
        public DataTable Buscar(DMovCaja MovCaja)
        {
            DataTable DtRpta = new DataTable("TbMovCaja");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "movcaja_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(MovCaja);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(MovCaja);
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
        public DataTable RepBuscar(DMovCaja MovCaja)
        {
            DataTable DtRpta = new DataTable("TbMovCaja");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "movcaja_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(MovCaja);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(MovCaja);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(MovCaja);
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
                    CommandText = "movcaja_primero",
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
                    CommandText = "movcaja_ultimo",
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
        /// <param name="Listar Anterior MovCaja"></param>
        public DataSet Anterior(DMovCaja MovCaja)
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
                    CommandText = "movcaja_anterior",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_movcaja = Getcod_movcaja(MovCaja);
                Cmd.Parameters.Add(Parcod_movcaja);

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
        /// <param name="Listar Siguiente MovCaja"></param>
        public DataSet Siguiente(DMovCaja MovCaja)
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
                    CommandText = "movcaja_siguiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_movcaja = Getcod_movcaja(MovCaja);
                Cmd.Parameters.Add(Parcod_movcaja);

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
        public string GenerarCod(DMovCaja MovCaja)
        {
            SqlConnection SqlConn = new SqlConnection
            {
                ConnectionString = DConexion.Cn
            };

            SqlConn.Open();
            SqlCommand Cmd = new SqlCommand
            {
                Connection = SqlConn,
                CommandText = "movcaja_generar_cod",
                CommandType = CommandType.StoredProcedure,
            };

            try
            {
                SqlParameter ParCod_movcaja = new SqlParameter("@cod_movcaja", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                    Value = MovCaja.Dcod_movcaja
                };
                Cmd.Parameters.Add(ParCod_movcaja);

                if (Cmd.ExecuteNonQuery() == 0)
                {
                    return Cmd.Parameters[ParCod_movcaja.ToString()].Value.ToString();
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
            return Cmd.Parameters["@cod_movcaja"].Value.ToString();
        }
    }
}
