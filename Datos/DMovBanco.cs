using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DMovBanco
    {

        #region PARAMETROS

        public Object Dcod_movbanco { get; set; }
        public Object Dcod_movbancov { get; set; }
        public Object Dcod_cuenta { get; set; }
        public Object Dcod_cuentasie { get; set; }
        public Object Ddesc_movbanco { get; set; }
        public Object Dtipomov { get; set; }
        public Object Doptipo { get; set; }
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

        private static SqlParameter Getcod_movbanco(DMovBanco MovBanco)
        {
            SqlParameter Pcod_movbanco = new SqlParameter
            {
                ParameterName = "@cod_movbanco",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = MovBanco.Dcod_movbanco
            };
            return Pcod_movbanco;
        }

        private static SqlParameter Getcod_movbancov(DMovBanco MovBanco)
        {
            SqlParameter Pcod_movbancov = new SqlParameter
            {
                ParameterName = "@cod_movbancov",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = MovBanco.Dcod_movbancov
            };
            return Pcod_movbancov;
        }

        private static SqlParameter Getcod_cuenta(DMovBanco MovBanco)
        {
            SqlParameter Pcod_cuenta = new SqlParameter
            {
                ParameterName = "@cod_cuenta",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = MovBanco.Dcod_cuenta
            };
            return Pcod_cuenta;
        }

        private static SqlParameter Getcod_cuentasie(DMovBanco MovBanco)
        {
            SqlParameter Pcod_cuentasie = new SqlParameter
            {
                ParameterName = "@cod_cuentasie",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = MovBanco.Dcod_cuentasie
            };
            return Pcod_cuentasie;
        }

        private static SqlParameter Getdesc_movbanco(DMovBanco MovBanco)
        {
            SqlParameter Pdesc_movbanco = new SqlParameter
            {
                ParameterName = "@desc_movbanco",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Value = MovBanco.Ddesc_movbanco
            };
            return Pdesc_movbanco;
        }

        private static SqlParameter Gettipomov(DMovBanco MovBanco)
        {
            SqlParameter Ptipomov = new SqlParameter
            {
                ParameterName = "@tipomov",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovBanco.Dtipomov
            };
            return Ptipomov;
        }

        private static SqlParameter Getoptipo(DMovBanco MovBanco)
        {
            SqlParameter Poptipo = new SqlParameter
            {
                ParameterName = "@optipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovBanco.Doptipo
            };
            return Poptipo;
        }


        private static SqlParameter Getnumdoc(DMovBanco MovBanco)
        {
            SqlParameter Pnumdoc = new SqlParameter
            {
                ParameterName = "@numdoc",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovBanco.Dnumdoc
            };
            return Pnumdoc;
        }

        private static SqlParameter Getnumop(DMovBanco MovBanco)
        {
            SqlParameter Pnumop = new SqlParameter
            {
                ParameterName = "@numop",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovBanco.Dnumop
            };
            return Pnumop;
        }

        private static SqlParameter Getorigen(DMovBanco MovBanco)
        {
            SqlParameter Porigen = new SqlParameter
            {
                ParameterName = "@origen",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovBanco.Dorigen
            };
            return Porigen;
        }

        private static SqlParameter Getestatus(DMovBanco MovBanco)
        {
            SqlParameter Pestatus = new SqlParameter
            {
                ParameterName = "@estatus",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovBanco.Destatus
            };
            return Pestatus;
        }

        private static SqlParameter Getmontod(DMovBanco MovBanco)
        {
            SqlParameter Pmontod = new SqlParameter
            {
                ParameterName = "@montod",
                SqlDbType = SqlDbType.Money,
                Value = MovBanco.Dmontod
            };
            return Pmontod;
        }

        private static SqlParameter Getmontoh(DMovBanco MovBanco)
        {
            SqlParameter Pmontoh = new SqlParameter
            {
                ParameterName = "@montoh",
                SqlDbType = SqlDbType.Money,
                Value = MovBanco.Dmontoh
            };
            return Pmontoh;
        }

        private static SqlParameter Getfecha_reg(DMovBanco MovBanco)
        {
            SqlParameter Pfecha_reg = new SqlParameter
            {
                ParameterName = "@fecha_reg",
                SqlDbType = SqlDbType.DateTime,
                Value = MovBanco.Dfecha_reg
            };
            return Pfecha_reg;
        }

        private static SqlParameter Getsaldoinicial(DMovBanco MovBanco)
        {
            SqlParameter Psaldoinicial = new SqlParameter
            {
                ParameterName = "@saldoinicial",
                SqlDbType = SqlDbType.Bit,
                Value = MovBanco.Dsaldoinicial
            };
            return Psaldoinicial;
        }

        private static SqlParameter Getanulado(DMovBanco MovBanco)
        {
            SqlParameter Panulado = new SqlParameter
            {
                ParameterName = "@anulado",
                SqlDbType = SqlDbType.Bit,
                Value = MovBanco.Danulado
            };
            return Panulado;
        }

        private static SqlParameter Getcampo1(DMovBanco MovBanco)
        {
            SqlParameter Pcampo1 = new SqlParameter
            {
                ParameterName = "@campo1",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovBanco.Dcampo1,
            };
            return Pcampo1;
        }

        private static SqlParameter Getcampo2(DMovBanco MovBanco)
        {
            SqlParameter Pcampo2 = new SqlParameter
            {
                ParameterName = "@campo2",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovBanco.Dcampo2,
            };
            return Pcampo2;
        }

        private static SqlParameter Getcampo3(DMovBanco MovBanco)
        {
            SqlParameter Pcampo3 = new SqlParameter
            {
                ParameterName = "@campo3",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovBanco.Dcampo3,
            };
            return Pcampo3;
        }

        private static SqlParameter Getcampo4(DMovBanco MovBanco)
        {
            SqlParameter Pcampo4 = new SqlParameter
            {
                ParameterName = "@campo4",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovBanco.Dcampo4,
            };
            return Pcampo4;
        }

        private static SqlParameter Getcampo5(DMovBanco MovBanco)
        {
            SqlParameter Pcampo5 = new SqlParameter
            {
                ParameterName = "@campo5",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovBanco.Dcampo5,
            };
            return Pcampo5;
        }

        private static SqlParameter Getcampo6(DMovBanco MovBanco)
        {
            SqlParameter Pcampo6 = new SqlParameter
            {
                ParameterName = "@campo6",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovBanco.Dcampo6,
            };
            return Pcampo6;
        }

        private static SqlParameter Getcod_usuario(DMovBanco MovBanco)
        {
            SqlParameter Pcod_usuario = new SqlParameter
            {
                ParameterName = "@cod_usuario",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = MovBanco.Dcod_usuario,
            };
            return Pcod_usuario;
        }

        private static SqlParameter Getbuscard(DMovBanco MovBanco)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovBanco.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DMovBanco MovBanco)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovBanco.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbuscar(DMovBanco MovBanco)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovBanco.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbtipo(DMovBanco MovBanco)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = MovBanco.Dbtipo,
            };
            return Pbtipo;
        }



        #endregion

        public DMovBanco()
        {
            /// Constructor Vacio
        }


        /// <summary>
        /// Tabla Mostrar No Recibe parametros y Muestra un DataTable
        /// </summary>
        /// <returns> No Recibe Parametros</returns>
        public DataTable Mostrar()
        {
            DataTable DtRpta = new DataTable("TbMovBanco");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "movbanco_mostrar",
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
                    CommandText = "movbanco_listar",
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
        public string Insertar(DMovBanco MovBanco)
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
                    CommandText = "movbanco_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_movbanco = Getcod_movbanco(MovBanco);
                Cmd.Parameters.Add(Parcod_movbanco);

                SqlParameter Parcod_cuenta = Getcod_cuenta(MovBanco);
                Cmd.Parameters.Add(Parcod_cuenta);

                SqlParameter Parcod_cuentasie = Getcod_cuentasie(MovBanco);
                Cmd.Parameters.Add(Parcod_cuentasie);

                SqlParameter Pardesc_movbanco = Getdesc_movbanco(MovBanco);
                Cmd.Parameters.Add(Pardesc_movbanco);

                SqlParameter Partipomov = Gettipomov(MovBanco);
                Cmd.Parameters.Add(Partipomov);

                SqlParameter Paroptipo = Getoptipo(MovBanco);
                Cmd.Parameters.Add(Paroptipo);

                SqlParameter Parnumdoc = Getnumdoc(MovBanco);
                Cmd.Parameters.Add(Parnumdoc);

                SqlParameter Parnumop = Getnumop(MovBanco);
                Cmd.Parameters.Add(Parnumop);

                SqlParameter Parorigen = Getorigen(MovBanco);
                Cmd.Parameters.Add(Parorigen);

                SqlParameter Parestatus = Getestatus(MovBanco);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Parmontod = Getmontod(MovBanco);
                Cmd.Parameters.Add(Parmontod);

                SqlParameter Parmontoh = Getmontoh(MovBanco);
                Cmd.Parameters.Add(Parmontoh);

                SqlParameter Parfecha_reg = Getfecha_reg(MovBanco);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parsaldoinicial = Getsaldoinicial(MovBanco);
                Cmd.Parameters.Add(Parsaldoinicial);

                SqlParameter Paranulado = Getanulado(MovBanco);
                Cmd.Parameters.Add(Paranulado);

                SqlParameter Parcampo1 = Getcampo1(MovBanco);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(MovBanco);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(MovBanco);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(MovBanco);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(MovBanco);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(MovBanco);
                Cmd.Parameters.Add(Parcampo6);

                SqlParameter Parcod_usuario = Getcod_usuario(MovBanco);
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
        public string Editar(DMovBanco MovBanco)
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
                    CommandText = "movbanco_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_movbanco = Getcod_movbanco(MovBanco);
                Cmd.Parameters.Add(Parcod_movbanco);

                SqlParameter Parcod_movbancov = Getcod_movbancov(MovBanco);
                Cmd.Parameters.Add(Parcod_movbancov);

                SqlParameter Parcod_cuenta = Getcod_cuenta(MovBanco);
                Cmd.Parameters.Add(Parcod_cuenta);

                SqlParameter Parcod_cuentasie = Getcod_cuentasie(MovBanco);
                Cmd.Parameters.Add(Parcod_cuentasie);

                SqlParameter Pardesc_movbanco = Getdesc_movbanco(MovBanco);
                Cmd.Parameters.Add(Pardesc_movbanco);

                SqlParameter Partipomov = Gettipomov(MovBanco);
                Cmd.Parameters.Add(Partipomov);

                SqlParameter Paroptipo = Getoptipo(MovBanco);
                Cmd.Parameters.Add(Paroptipo);

                SqlParameter Parnumdoc = Getnumdoc(MovBanco);
                Cmd.Parameters.Add(Parnumdoc);

                SqlParameter Parnumop = Getnumop(MovBanco);
                Cmd.Parameters.Add(Parnumop);

                SqlParameter Parorigen = Getorigen(MovBanco);
                Cmd.Parameters.Add(Parorigen);

                SqlParameter Parestatus = Getestatus(MovBanco);
                Cmd.Parameters.Add(Parestatus);

                SqlParameter Parmontod = Getmontod(MovBanco);
                Cmd.Parameters.Add(Parmontod);

                SqlParameter Parmontoh = Getmontoh(MovBanco);
                Cmd.Parameters.Add(Parmontoh);

                SqlParameter Parfecha_reg = Getfecha_reg(MovBanco);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parsaldoinicial = Getsaldoinicial(MovBanco);
                Cmd.Parameters.Add(Parsaldoinicial);

                SqlParameter Paranulado = Getanulado(MovBanco);
                Cmd.Parameters.Add(Paranulado);

                SqlParameter Parcampo1 = Getcampo1(MovBanco);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(MovBanco);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(MovBanco);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(MovBanco);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(MovBanco);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(MovBanco);
                Cmd.Parameters.Add(Parcampo6);

                SqlParameter Parcod_usuario = Getcod_usuario(MovBanco);
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
        public string Eliminar(DMovBanco MovBanco)
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
                    CommandText = "movbanco_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_movbanco = Getcod_movbanco(MovBanco);
                Cmd.Parameters.Add(Parcod_movbanco);

                SqlParameter Parcod_cuenta = Getcod_cuenta(MovBanco);
                Cmd.Parameters.Add(Parcod_cuenta);

                SqlParameter Paroptipo = Getoptipo(MovBanco);
                Cmd.Parameters.Add(Paroptipo);

                SqlParameter Parmontod = Getmontod(MovBanco);
                Cmd.Parameters.Add(Parmontod);

                SqlParameter Parmontoh = Getmontoh(MovBanco);
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
        public DataTable Buscar(DMovBanco MovBanco)
        {
            DataTable DtRpta = new DataTable("TbMovBanco");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "movbanco_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(MovBanco);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(MovBanco);
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
        public DataTable RepBuscar(DMovBanco MovBanco)
        {
            DataTable DtRpta = new DataTable("TbMovBanco");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "movbanco_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(MovBanco);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(MovBanco);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(MovBanco);
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
                    CommandText = "movbanco_primero",
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
                    CommandText = "movbanco_ultimo",
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
        /// <param name="Listar Anterior MovBanco"></param>
        public DataSet Anterior(DMovBanco MovBanco)
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
                    CommandText = "movbanco_anterior",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_movbanco = Getcod_movbanco(MovBanco);
                Cmd.Parameters.Add(Parcod_movbanco);

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
        /// <param name="Listar Siguiente MovBanco"></param>
        public DataSet Siguiente(DMovBanco MovBanco)
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
                    CommandText = "movbanco_siguiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_movbanco = Getcod_movbanco(MovBanco);
                Cmd.Parameters.Add(Parcod_movbanco);

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
        public string GenerarCod(DMovBanco MovBanco)
        {
            SqlConnection SqlConn = new SqlConnection
            {
                ConnectionString = DConexion.Cn
            };

            SqlConn.Open();
            SqlCommand Cmd = new SqlCommand
            {
                Connection = SqlConn,
                CommandText = "movbanco_generar_cod",
                CommandType = CommandType.StoredProcedure,
            };

            try
            {
                SqlParameter ParCod_movbanco = new SqlParameter("@cod_movbanco", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                    Value = MovBanco.Dcod_movbanco
                };
                Cmd.Parameters.Add(ParCod_movbanco);

                if (Cmd.ExecuteNonQuery() == 0)
                {
                    return Cmd.Parameters[ParCod_movbanco.ToString()].Value.ToString();
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
            return Cmd.Parameters["@cod_movbanco"].Value.ToString();
        }
    }
}
