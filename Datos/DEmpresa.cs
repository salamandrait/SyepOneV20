using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DEmpresa
    {
        #region Parametros
        public Object Dcod_empresa { get; set; }
        public Object Dcod_empresav { get; set; }
        public Object Dcod_moneda { get; set; }
        public Object Dcod_pais { get; set; }
        public Object Dcod_islr { get; set; }
        public Object Ddesc_empresa { get; set; }
        public Object Drif { get; set; }
        public Object Dreplegal { get; set; }
        public Object Ddireccion { get; set; }
        public Object Dtelefono { get; set; }
        public Object Dmovil { get; set; }
        public Object Dcodigo_postal { get; set; }
        public Object Dweb { get; set; }
        public Object Demail { get; set; }
        public Object Dfiscal { get; set; }
        public Object Dmontofiscal { get; set; }
        public Object Dcampo1 { get; set; }
        public Object Dcampo2 { get; set; }
        public Object Dcampo3 { get; set; }
        public Object Dcampo4 { get; set; }
        public Object Dcampo5 { get; set; }
        public Object Dcampo6 { get; set; }
        public Object Dlogo1 { get; set; }
        public Object Dlogo2 { get; set; }
        public Object Dlogo3 { get; set; }
        public Object Dbuscar { get; set; }
        public Object Dbuscard { get; set; }
        public Object Dbuscarh { get; set; }
        public Object Dbtipo { get; set; }


        private static SqlParameter Getcod_empresa(DEmpresa Empresa)
        {
            SqlParameter Pcod_empresa = new SqlParameter
            {
                ParameterName = "@cod_empresa",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Empresa.Dcod_empresa,
            };
            return Pcod_empresa;
        }

        private static SqlParameter Getcod_empresav(DEmpresa Empresa)
        {
            SqlParameter Pcod_empresav = new SqlParameter
            {
                ParameterName = "@cod_empresav",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Empresa.Dcod_empresav,
            };
            return Pcod_empresav;
        }

        private static SqlParameter Getcod_pais(DEmpresa Empresa)
        {
            SqlParameter Pcod_pais = new SqlParameter
            {
                ParameterName = "@cod_pais",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Empresa.Dcod_pais,
            };
            return Pcod_pais;
        }

        private static SqlParameter Getcod_moneda(DEmpresa Empresa)
        {
            SqlParameter Pcod_moneda = new SqlParameter
            {
                ParameterName = "@cod_moneda",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Empresa.Dcod_moneda,
            };
            return Pcod_moneda;
        }

        private static SqlParameter Getcod_islr(DEmpresa Empresa)
        {
            SqlParameter Pcod_islr = new SqlParameter
            {
                ParameterName = "@cod_islr",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Empresa.Dcod_islr
            };
            return Pcod_islr;
        }

        private static SqlParameter Getdesc_empresa(DEmpresa Empresa)
        {
            SqlParameter Pdesc_empresa = new SqlParameter
            {
                ParameterName = "@desc_empresa",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Value = Empresa.Ddesc_empresa,
            };
            return Pdesc_empresa;
        }

        private static SqlParameter Getrif(DEmpresa Empresa)
        {
            SqlParameter Prif = new SqlParameter
            {
                ParameterName = "@rif",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Empresa.Drif,
            };
            return Prif;
        }

        private static SqlParameter Getreplegal(DEmpresa Empresa)
        {
            SqlParameter Preplegal = new SqlParameter
            {
                ParameterName = "@replegal",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Empresa.Dreplegal,
            };
            return Preplegal;
        }

        private static SqlParameter Getdireccion(DEmpresa Empresa)
        {
            SqlParameter Pdireccion = new SqlParameter
            {
                ParameterName = "@direccion",
                SqlDbType = SqlDbType.VarChar,
                Size = 500,
                Value = Empresa.Ddireccion,
            };
            return Pdireccion;
        }

        private static SqlParameter Gettelefono(DEmpresa Empresa)
        {
            SqlParameter Ptelefono = new SqlParameter
            {
                ParameterName = "@telefono",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Empresa.Dtelefono,
            };
            return Ptelefono;
        }

        private static SqlParameter Getmovil(DEmpresa Empresa)
        {
            SqlParameter Pmovil = new SqlParameter
            {
                ParameterName = "@movil",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Empresa.Dmovil,
            };
            return Pmovil;
        }

        private static SqlParameter Getcodigo_postal(DEmpresa Empresa)
        {
            SqlParameter Pcodigo_postal = new SqlParameter
            {
                ParameterName = "@codigo_postal",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Empresa.Dcodigo_postal,
            };
            return Pcodigo_postal;
        }

        private static SqlParameter Getemail(DEmpresa Empresa)
        {
            SqlParameter Pemail = new SqlParameter
            {
                ParameterName = "@email",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Empresa.Demail,
            };
            return Pemail;
        }

        private static SqlParameter Getweb(DEmpresa Empresa)
        {
            SqlParameter Pweb = new SqlParameter
            {
                ParameterName = "@web",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Empresa.Dweb,
            };
            return Pweb;
        }

        private static SqlParameter Getfiscal(DEmpresa Empresa)
        {
            SqlParameter Pfiscal = new SqlParameter
            {
                ParameterName = "@fiscal",
                SqlDbType = SqlDbType.Bit,
                Value = Empresa.Dfiscal,
            };
            return Pfiscal;
        }

        private static SqlParameter Getmontofiscal(DEmpresa Empresa)
        {
            SqlParameter Pmontofiscal = new SqlParameter
            {
                ParameterName = "@montofiscal",
                SqlDbType = SqlDbType.Decimal,
                Precision = 18,
                Scale = 3,
                Value = Empresa.Dmontofiscal,
            };
            return Pmontofiscal;
        }

        private static SqlParameter Getcampo1(DEmpresa Empresa)
        {
            SqlParameter Pcampo1 = new SqlParameter
            {
                ParameterName = "@campo1",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Empresa.Dcampo1,
            };
            return Pcampo1;
        }

        private static SqlParameter Getcampo2(DEmpresa Empresa)
        {
            SqlParameter Pcampo2 = new SqlParameter
            {
                ParameterName = "@campo2",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Empresa.Dcampo2,
            };
            return Pcampo2;
        }

        private static SqlParameter Getcampo3(DEmpresa Empresa)
        {
            SqlParameter Pcampo3 = new SqlParameter
            {
                ParameterName = "@campo3",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Empresa.Dcampo3,
            };
            return Pcampo3;
        }

        private static SqlParameter Getcampo4(DEmpresa Empresa)
        {
            SqlParameter Pcampo4 = new SqlParameter
            {
                ParameterName = "@campo4",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Empresa.Dcampo4,
            };
            return Pcampo4;
        }

        private static SqlParameter Getcampo5(DEmpresa Empresa)
        {
            SqlParameter Pcampo5 = new SqlParameter
            {
                ParameterName = "@campo5",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Empresa.Dcampo5,
            };
            return Pcampo5;
        }

        private static SqlParameter Getcampo6(DEmpresa Empresa)
        {
            SqlParameter Pcampo6 = new SqlParameter
            {
                ParameterName = "@campo6",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Empresa.Dcampo6,
            };
            return Pcampo6;
        }

        private static SqlParameter Getlogo1(DEmpresa Empresa)
        {
            SqlParameter Plogo1 = new SqlParameter
            {
                ParameterName = "@logo1",
                SqlDbType = SqlDbType.Image,
                Value = Empresa.Dlogo1,
            };
            return Plogo1;
        }

        private static SqlParameter Getlogo2(DEmpresa Empresa)
        {
            SqlParameter Plogo2 = new SqlParameter
            {
                ParameterName = "@logo2",
                SqlDbType = SqlDbType.Image,
                Value = Empresa.Dlogo2,
            };
            return Plogo2;
        }

        private static SqlParameter Getlogo3(DEmpresa Empresa)
        {
            SqlParameter Plogo3 = new SqlParameter
            {
                ParameterName = "@logo3",
                SqlDbType = SqlDbType.Image,
                Value = Empresa.Dlogo3,
            };
            return Plogo3;
        }

        private static SqlParameter Getbuscar(DEmpresa Empresa)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Empresa.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DEmpresa Empresa)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Empresa.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DEmpresa Empresa)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Empresa.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DEmpresa Empresa)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Empresa.Dbtipo,
            };
            return Pbtipo;
        }
        #endregion

        public DEmpresa()
        {
            /// Constructor Vacio
        }


        /// <summary>
        /// Tabla Mostrar No Recibe parametros
        /// </summary>
        /// <returns> 0 Parametros</returns>
        public DataTable Mostrar()
        {
            DataTable DtRpta = new DataTable("TbEmpresa");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "empresa_mostrar",
                    CommandType = CommandType.StoredProcedure,
                };

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
        /// Tabla Listar No Recibe parametros
        /// </summary>
        /// <returns> 0 Parametros</returns>
        public DataSet Listar()
        {
            DataSet DsRpta = new DataSet();
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand()
                {
                    Connection = SqlConn,
                    CommandText = "empresa_listar",
                    CommandType = CommandType.StoredProcedure,
                };

                Cmd.ExecuteNonQuery();
                SqlDataAdapter Dat = new SqlDataAdapter(Cmd);
                Dat.Fill(DsRpta, "TbEmpresa");

            }
            catch (Exception Exc)
            {
                DsRpta = null;
                throw new Exception("Error al Ejecutar el procedimiento almacenado" + Exc.Message);
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
        /// <returns> 8 Parametros</returns>
        public string Insertar(DEmpresa Empresa)
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
                    CommandText = "empresa_insertar",
                    CommandType = CommandType.StoredProcedure,
                };


                SqlParameter Parcod_empresa = Getcod_empresa(Empresa);
                Cmd.Parameters.Add(Parcod_empresa);

                SqlParameter Parcod_pais = Getcod_pais(Empresa);
                Cmd.Parameters.Add(Parcod_pais);

                SqlParameter Parcod_moneda = Getcod_moneda(Empresa);
                Cmd.Parameters.Add(Parcod_moneda);

                SqlParameter Parcod_islr = Getcod_islr(Empresa);
                Cmd.Parameters.Add(Parcod_islr);

                SqlParameter ParDesc_empresa = Getdesc_empresa(Empresa);
                Cmd.Parameters.Add(ParDesc_empresa);

                SqlParameter Parrif = Getrif(Empresa);
                Cmd.Parameters.Add(Parrif);

                SqlParameter Parreplegal = Getreplegal(Empresa);
                Cmd.Parameters.Add(Parreplegal);

                SqlParameter Pardireccion = Getdireccion(Empresa);
                Cmd.Parameters.Add(Pardireccion);

                SqlParameter Partelefono = Gettelefono(Empresa);
                Cmd.Parameters.Add(Partelefono);

                SqlParameter Parmovil = Getmovil(Empresa);
                Cmd.Parameters.Add(Parmovil);

                SqlParameter Parcodigo_postal = Getcodigo_postal(Empresa);
                Cmd.Parameters.Add(Parcodigo_postal);

                SqlParameter Paremail = Getemail(Empresa);
                Cmd.Parameters.Add(Paremail);

                SqlParameter Parweb = Getweb(Empresa);
                Cmd.Parameters.Add(Parweb);

                SqlParameter Parfiscal = Getfiscal(Empresa);
                Cmd.Parameters.Add(Parfiscal);

                SqlParameter Parmontofiscal = Getmontofiscal(Empresa);
                Cmd.Parameters.Add(Parmontofiscal);

                SqlParameter Parcampo1 = Getcampo1(Empresa);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Empresa);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Empresa);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Empresa);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Empresa);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Empresa);
                Cmd.Parameters.Add(Parcampo6);

                SqlParameter Parlogo1 = Getlogo1(Empresa);
                Cmd.Parameters.Add(Parlogo1);

                SqlParameter Parlogo2 = Getlogo2(Empresa);
                Cmd.Parameters.Add(Parlogo2);

                SqlParameter Parlogo3 = Getlogo3(Empresa);
                Cmd.Parameters.Add(Parlogo3);

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
        /// Metodo Editar Datos Recibe 8 Parametros
        /// </summary>
        /// <returns> 8 Parametros</returns>
        public string Editar(DEmpresa Empresa)
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
                    CommandText = "empresa_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_empresa = Getcod_empresa(Empresa);
                Cmd.Parameters.Add(Parcod_empresa);

                SqlParameter Parcod_empresav = Getcod_empresav(Empresa);
                Cmd.Parameters.Add(Parcod_empresav);

                SqlParameter Parcod_pais = Getcod_pais(Empresa);
                Cmd.Parameters.Add(Parcod_pais);

                SqlParameter Parcod_moneda = Getcod_moneda(Empresa);
                Cmd.Parameters.Add(Parcod_moneda);

                SqlParameter Parcod_islr = Getcod_islr(Empresa);
                Cmd.Parameters.Add(Parcod_islr);

                SqlParameter ParDesc_empresa = Getdesc_empresa(Empresa);
                Cmd.Parameters.Add(ParDesc_empresa);

                SqlParameter Parrif = Getrif(Empresa);
                Cmd.Parameters.Add(Parrif);

                SqlParameter Parreplegal = Getreplegal(Empresa);
                Cmd.Parameters.Add(Parreplegal);

                SqlParameter Pardireccion = Getdireccion(Empresa);
                Cmd.Parameters.Add(Pardireccion);

                SqlParameter Partelefono = Gettelefono(Empresa);
                Cmd.Parameters.Add(Partelefono);

                SqlParameter Parmovil = Getmovil(Empresa);
                Cmd.Parameters.Add(Parmovil);

                SqlParameter Parcodigo_postal = Getcodigo_postal(Empresa);
                Cmd.Parameters.Add(Parcodigo_postal);

                SqlParameter Paremail = Getemail(Empresa);
                Cmd.Parameters.Add(Paremail);

                SqlParameter Parweb = Getweb(Empresa);
                Cmd.Parameters.Add(Parweb);

                SqlParameter Parfiscal = Getfiscal(Empresa);
                Cmd.Parameters.Add(Parfiscal);

                SqlParameter Parmontofiscal = Getmontofiscal(Empresa);
                Cmd.Parameters.Add(Parmontofiscal);

                SqlParameter Parcampo1 = Getcampo1(Empresa);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Empresa);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Empresa);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Empresa);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Empresa);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Empresa);
                Cmd.Parameters.Add(Parcampo6);

                SqlParameter Parlogo1 = Getlogo1(Empresa);
                Cmd.Parameters.Add(Parlogo1);

                SqlParameter Parlogo2 = Getlogo2(Empresa);
                Cmd.Parameters.Add(Parlogo2);

                SqlParameter Parlogo3 = Getlogo3(Empresa);
                Cmd.Parameters.Add(Parlogo3);

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
        /// Metodo Eliminar Datos Recibe 1 Parametro
        /// </summary>
        /// <returns> 1 Parametro</returns>
        public string Eliminar(DEmpresa Empresa)
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
                    CommandText = "empresa_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_empresa = Getcod_empresa(Empresa);
                Cmd.Parameters.Add(Parcod_empresa);

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
                    Rpta = "No se pueden Eliminar Registros Relacionados   " + Exc.Message;
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
        /// Metodo Buscar Datos Recibe 2 Parametros
        /// </summary>
        public DataTable Buscar(DEmpresa Empresa)
        {
            DataTable DtRpta = new DataTable("TbEmpresa");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "empresa_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(Empresa);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(Empresa);
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
        public DataTable RepBuscar(DEmpresa Empresa)
        {
            DataTable DtRpta = new DataTable("TbEmpresa");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "empresa_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(Empresa);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(Empresa);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(Empresa);
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
                    CommandText = "empresa_primero",
                    CommandType = CommandType.StoredProcedure,
                };

                Cmd.ExecuteNonQuery();
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DsRpta, "TbEmpresa");

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
                    CommandText = "empresa_ultimo",
                    CommandType = CommandType.StoredProcedure,
                };

                Cmd.ExecuteNonQuery();
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DsRpta, "TbEmpresa");

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
        /// <param name="Listar Anterior Empresa"></param>
        public DataSet Anterior(DEmpresa Empresa)
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
                    CommandText = "empresa_anterior",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_empresa = Getcod_empresa(Empresa);
                Cmd.Parameters.Add(Parcod_empresa);

                Cmd.ExecuteNonQuery();
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DsRpta, "TbEmpresa");

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
        /// <param name="Listar Siguiente Empresa"></param>
        public DataSet Siguiente(DEmpresa Empresa)
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
                    CommandText = "empresa_siguiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_empresa = Getcod_empresa(Empresa);
                Cmd.Parameters.Add(Parcod_empresa);

                Cmd.ExecuteNonQuery();
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(DsRpta, "TbEmpresa");

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
        public string GenerarCod(DEmpresa Empresa)
        {
            SqlConnection SqlConn = new SqlConnection
            {
                ConnectionString = DConexion.Cn
            };

            SqlConn.Open();
            SqlCommand Cmd = new SqlCommand
            {
                Connection = SqlConn,
                CommandText = "empresa_generar_cod",
                CommandType = CommandType.StoredProcedure,
            };

            try
            {
                SqlParameter ParCod_empresa = new SqlParameter("@cod_empresa", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                    Value = Empresa.Dcod_empresa
                };
                Cmd.Parameters.Add(ParCod_empresa);

                if (Cmd.ExecuteNonQuery() == 0)
                {
                    return Cmd.Parameters[ParCod_empresa.ToString()].Value.ToString();
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
            return Cmd.Parameters["@cod_empresa"].Value.ToString();
        }
    }
}

