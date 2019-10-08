using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DBeneficiario
    {

        #region PARAMETROS
        public Object Dcod_beneficiario { get; set; }
        public Object Dcod_beneficiariov { get; set; }
        public Object Dcod_islr { get; set; }
        public Object Ddesc_beneficiario { get; set; }
        public Object Drif { get; set; }
        public Object Ddireccion { get; set; }
        public Object Dtelefono { get; set; }
        public Object Dactivo { get; set; }
        public Object Dfecha_reg { get; set; }
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


        private static SqlParameter Getcod_beneficiario(DBeneficiario Beneficiario)
        {
            SqlParameter Pcod_beneficiario = new SqlParameter
            {
                ParameterName = "@cod_beneficiario",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Beneficiario.Dcod_beneficiario,
            };
            return Pcod_beneficiario;
        }

        private static SqlParameter Getcod_beneficiariov(DBeneficiario Beneficiario)
        {
            SqlParameter Pcod_beneficiariov = new SqlParameter
            {
                ParameterName = "@cod_beneficiariov",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Beneficiario.Dcod_beneficiariov,
            };
            return Pcod_beneficiariov;
        }

        private static SqlParameter Getcod_islr(DBeneficiario Beneficiario)
        {
            SqlParameter Pcod_islr = new SqlParameter
            {
                ParameterName = "@cod_islr",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Beneficiario.Dcod_islr
            };
            return Pcod_islr;
        }

        private static SqlParameter Getdesc_beneficiario(DBeneficiario Beneficiario)
        {
            SqlParameter Pdesc_beneficiario = new SqlParameter
            {
                ParameterName = "@desc_beneficiario",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Value = Beneficiario.Ddesc_beneficiario,
            };
            return Pdesc_beneficiario;
        }

        private static SqlParameter Getrif(DBeneficiario Beneficiario)
        {
            SqlParameter Prif = new SqlParameter
            {
                ParameterName = "@rif",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Beneficiario.Drif
            };
            return Prif;
        }

        private static SqlParameter Getdireccion(DBeneficiario Beneficiario)
        {
            SqlParameter Pdireccion = new SqlParameter
            {
                ParameterName = "@direccion",
                SqlDbType = SqlDbType.VarChar,
                Size = 250,
                Value = Beneficiario.Ddireccion
            };
            return Pdireccion;
        }

        private static SqlParameter Gettelefono(DBeneficiario Beneficiario)
        {
            SqlParameter Ptelefono = new SqlParameter
            {
                ParameterName = "@telefono",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Beneficiario.Dtelefono
            };
            return Ptelefono;
        }

        private static SqlParameter Getactivo(DBeneficiario Beneficiario)
        {
            SqlParameter Pactivo = new SqlParameter
            {
                ParameterName = "@activo",
                SqlDbType = SqlDbType.Bit,
                Value = Beneficiario.Dactivo
            };
            return Pactivo;
        }

        private static SqlParameter Getfecha_reg(DBeneficiario Beneficiario)
        {
            SqlParameter Pfecha_reg = new SqlParameter
            {
                ParameterName = "@fecha_reg",
                SqlDbType = SqlDbType.DateTime,
                Size = 50,
                Value = Beneficiario.Dfecha_reg,
            };
            return Pfecha_reg;
        }

        private static SqlParameter Getcampo1(DBeneficiario Beneficiario)
        {
            SqlParameter Pcampo1 = new SqlParameter
            {
                ParameterName = "@campo1",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Beneficiario.Dcampo1,
            };
            return Pcampo1;
        }

        private static SqlParameter Getcampo2(DBeneficiario Beneficiario)
        {
            SqlParameter Pcampo2 = new SqlParameter
            {
                ParameterName = "@campo2",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Beneficiario.Dcampo2,
            };
            return Pcampo2;
        }

        private static SqlParameter Getcampo3(DBeneficiario Beneficiario)
        {
            SqlParameter Pcampo3 = new SqlParameter
            {
                ParameterName = "@campo3",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Beneficiario.Dcampo3,
            };
            return Pcampo3;
        }

        private static SqlParameter Getcampo4(DBeneficiario Beneficiario)
        {
            SqlParameter Pcampo4 = new SqlParameter
            {
                ParameterName = "@campo4",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Beneficiario.Dcampo4,
            };
            return Pcampo4;
        }

        private static SqlParameter Getcampo5(DBeneficiario Beneficiario)
        {
            SqlParameter Pcampo5 = new SqlParameter
            {
                ParameterName = "@campo5",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Beneficiario.Dcampo5,
            };
            return Pcampo5;
        }

        private static SqlParameter Getcampo6(DBeneficiario Beneficiario)
        {
            SqlParameter Pcampo6 = new SqlParameter
            {
                ParameterName = "@campo6",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Beneficiario.Dcampo6,
            };
            return Pcampo6;
        }

        private static SqlParameter Getbuscar(DBeneficiario Beneficiario)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Beneficiario.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DBeneficiario Beneficiario)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Beneficiario.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DBeneficiario Beneficiario)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Beneficiario.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DBeneficiario Beneficiario)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Beneficiario.Dbtipo,
            };
            return Pbtipo;
        }

        #endregion

        public DBeneficiario()
        {
            /// Constructor Vacio
        }

        /// <summary>
        /// Tabla Mostrar No Recibe parametros y Muestra un DataTable
        /// </summary>
        /// <returns> No Recibe Parametros</returns>
        public DataTable Mostrar()
        {
            DataTable DtRpta = new DataTable("TbBeneficiario");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "beneficiario_mostrar",
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
                    CommandText = "beneficiario_listar",
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
        public string Insertar(DBeneficiario Beneficiario)
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
                    CommandText = "beneficiario_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_beneficiario = Getcod_beneficiario(Beneficiario);
                Cmd.Parameters.Add(Parcod_beneficiario);

                SqlParameter Pardesc_beneficiario = Getdesc_beneficiario(Beneficiario);
                Cmd.Parameters.Add(Pardesc_beneficiario);

                SqlParameter Parcod_islr = Getcod_islr(Beneficiario);
                Cmd.Parameters.Add(Parcod_islr);

                SqlParameter Parrif = Getrif(Beneficiario);
                Cmd.Parameters.Add(Parrif);

                SqlParameter Pardireccion = Getdireccion(Beneficiario);
                Cmd.Parameters.Add(Pardireccion);

                SqlParameter Partelefono = Gettelefono(Beneficiario);
                Cmd.Parameters.Add(Partelefono);

                SqlParameter Paractivo = Getactivo(Beneficiario);
                Cmd.Parameters.Add(Paractivo);

                SqlParameter Parfecha_reg = Getfecha_reg(Beneficiario);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parcampo1 = Getcampo1(Beneficiario);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Beneficiario);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Beneficiario);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Beneficiario);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Beneficiario);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Beneficiario);
                Cmd.Parameters.Add(Parcampo6);


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
        public string Editar(DBeneficiario Beneficiario)
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
                    CommandText = "beneficiario_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_beneficiario = Getcod_beneficiario(Beneficiario);
                Cmd.Parameters.Add(Parcod_beneficiario);

                SqlParameter Parcod_beneficiariov = Getcod_beneficiariov(Beneficiario);
                Cmd.Parameters.Add(Parcod_beneficiariov);

                SqlParameter Pardesc_beneficiario = Getdesc_beneficiario(Beneficiario);
                Cmd.Parameters.Add(Pardesc_beneficiario);

                SqlParameter Parcod_islr = Getcod_islr(Beneficiario);
                Cmd.Parameters.Add(Parcod_islr);

                SqlParameter Parrif = Getrif(Beneficiario);
                Cmd.Parameters.Add(Parrif);

                SqlParameter Pardireccion = Getdireccion(Beneficiario);
                Cmd.Parameters.Add(Pardireccion);

                SqlParameter Partelefono = Gettelefono(Beneficiario);
                Cmd.Parameters.Add(Partelefono);

                SqlParameter Paractivo = Getactivo(Beneficiario);
                Cmd.Parameters.Add(Paractivo);

                SqlParameter Parfecha_reg = Getfecha_reg(Beneficiario);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parcampo1 = Getcampo1(Beneficiario);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Beneficiario);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Beneficiario);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Beneficiario);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Beneficiario);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Beneficiario);
                Cmd.Parameters.Add(Parcampo6);

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
        public string Eliminar(DBeneficiario Beneficiario)
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
                    CommandText = "beneficiario_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_beneficiario = Getcod_beneficiario(Beneficiario);
                Cmd.Parameters.Add(Parcod_beneficiario);

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
        public DataTable Buscar(DBeneficiario Beneficiario)
        {
            DataTable DtRpta = new DataTable("TbBeneficiario");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "beneficiario_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(Beneficiario);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(Beneficiario);
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
        public DataTable RepBuscar(DBeneficiario Beneficiario)
        {
            DataTable DtRpta = new DataTable("TbBeneficiario");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "beneficiario_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(Beneficiario);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(Beneficiario);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(Beneficiario);
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
                    CommandText = "beneficiario_primero",
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
                    CommandText = "beneficiario_ultimo",
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
        /// <param name="Listar Anterior Beneficiario"></param>
        public DataSet Anterior(DBeneficiario Beneficiario)
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
                    CommandText = "beneficiario_anterior",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_beneficiario = Getcod_beneficiario(Beneficiario);
                Cmd.Parameters.Add(Parcod_beneficiario);

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
        /// <param name="Listar Siguiente Beneficiario"></param>
        public DataSet Siguiente(DBeneficiario Beneficiario)
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
                    CommandText = "beneficiario_siguiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_beneficiario = Getcod_beneficiario(Beneficiario);
                Cmd.Parameters.Add(Parcod_beneficiario);

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
        public string GenerarCod(DBeneficiario Beneficiario)
        {
            SqlConnection SqlConn = new SqlConnection
            {
                ConnectionString = DConexion.Cn
            };

            SqlConn.Open();
            SqlCommand Cmd = new SqlCommand
            {
                Connection = SqlConn,
                CommandText = "beneficiario_generar_cod",
                CommandType = CommandType.StoredProcedure,
            };

            try
            {
                SqlParameter ParCod_beneficiario = new SqlParameter("@cod_beneficiario", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                    Value = Beneficiario.Dcod_beneficiario
                };
                Cmd.Parameters.Add(ParCod_beneficiario);

                if (Cmd.ExecuteNonQuery() == 0)
                {
                    return Cmd.Parameters[ParCod_beneficiario.ToString()].Value.ToString();
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
            return Cmd.Parameters["@cod_beneficiario"].Value.ToString();
        }
    }
}
