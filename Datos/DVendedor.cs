using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DVendedor
    {

        #region PARAMETROS
        public Object Dcod_vendedor { get; set; }
        public Object Dcod_vendedorv { get; set; }
        public Object Ddesc_vendedor { get; set; }
        public Object Drif { get; set; }
        public Object Dtelefono { get; set; }
        public Object Ddireccion { get; set; }
        public Object Dnivel { get; set; }
        public Object Dcomisionventa { get; set; }
        public Object Dcomisioncobro { get; set; }
        public Object Dtventas_item { get; set; }
        public Object Dtventas_monto { get; set; }
        public Object Dfecha_reg { get; set; }
        public Object Dcobra { get; set; }
        public Object Dventa { get; set; }
        public Object Dactivo { get; set; }
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

        private static SqlParameter Getcod_vendedor(DVendedor Vendedor)
        {
            SqlParameter Pcod_vendedor = new SqlParameter
            {
                ParameterName = "@cod_vendedor",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Vendedor.Dcod_vendedor,
            };
            return Pcod_vendedor;
        }

        private static SqlParameter Getcod_vendedorv(DVendedor Vendedor)
        {
            SqlParameter Pcod_vendedorv = new SqlParameter
            {
                ParameterName = "@cod_vendedorv",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Vendedor.Dcod_vendedorv,
            };
            return Pcod_vendedorv;
        }

        private static SqlParameter Getdesc_vendedor(DVendedor Vendedor)
        {
            SqlParameter Pdesc_vendedor = new SqlParameter
            {
                ParameterName = "@desc_vendedor",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Value = Vendedor.Ddesc_vendedor,
            };
            return Pdesc_vendedor;
        }

        private static SqlParameter Getrif(DVendedor Vendedor)
        {
            SqlParameter Prif = new SqlParameter
            {
                ParameterName = "@rif",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Vendedor.Drif
            };
            return Prif;
        }

        private static SqlParameter Gettelefono(DVendedor Vendedor)
        {
            SqlParameter Ptelefono = new SqlParameter
            {
                ParameterName = "@telefono",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Vendedor.Dtelefono
            };
            return Ptelefono;
        }

        private static SqlParameter Getdireccion(DVendedor Vendedor)
        {
            SqlParameter Pdireccion = new SqlParameter
            {
                ParameterName = "@direccion",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Value = Vendedor.Ddireccion
            };
            return Pdireccion;
        }

        private static SqlParameter Getnivel(DVendedor Vendedor)
        {
            SqlParameter Pnivel = new SqlParameter
            {
                ParameterName = "@nivel",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Vendedor.Dnivel
            };
            return Pnivel;
        }

        private static SqlParameter Getcomisionventa(DVendedor Vendedor)
        {
            SqlParameter Pcomisionventa = new SqlParameter
            {
                ParameterName = "@comisionventa",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = Vendedor.Dcomisionventa
            };
            return Pcomisionventa;
        }

        private static SqlParameter Getcomisioncobro(DVendedor Vendedor)
        {
            SqlParameter Pcomisioncobro = new SqlParameter
            {
                ParameterName = "@comisioncobro",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = Vendedor.Dcomisioncobro
            };
            return Pcomisioncobro;
        }

        private static SqlParameter Gettventas_item(DVendedor Vendedor)
        {
            SqlParameter Ptventas_item = new SqlParameter
            {
                ParameterName = "@tventas_item",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = Vendedor.Dtventas_item
            };
            return Ptventas_item;
        }

        private static SqlParameter Gettventas_monto(DVendedor Vendedor)
        {
            SqlParameter Ptventas_monto = new SqlParameter
            {
                ParameterName = "@tventas_monto",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = Vendedor.Dtventas_monto
            };
            return Ptventas_monto;
        }

        private static SqlParameter Getfecha_reg(DVendedor Vendedor)
        {
            SqlParameter Pfecha_reg = new SqlParameter
            {
                ParameterName = "@fecha_reg",
                SqlDbType = SqlDbType.DateTime,
                Value = Vendedor.Dfecha_reg
            };
            return Pfecha_reg;
        }

        private static SqlParameter Getcobra(DVendedor Vendedor)
        {
            SqlParameter Pcobra = new SqlParameter
            {
                ParameterName = "@cobra",
                SqlDbType = SqlDbType.Bit,
                Value = Vendedor.Dcobra
            };
            return Pcobra;
        }

        private static SqlParameter Getventa(DVendedor Vendedor)
        {
            SqlParameter Pventa = new SqlParameter
            {
                ParameterName = "@venta",
                SqlDbType = SqlDbType.Bit,

                Value = Vendedor.Dventa
            };
            return Pventa;
        }

        private static SqlParameter Getactivo(DVendedor Vendedor)
        {
            SqlParameter Pactivo = new SqlParameter
            {
                ParameterName = "@activo",
                SqlDbType = SqlDbType.Bit,

                Value = Vendedor.Dactivo
            };
            return Pactivo;
        }

        private static SqlParameter Getcampo1(DVendedor Vendedor)
        {
            SqlParameter Pcampo1 = new SqlParameter
            {
                ParameterName = "@campo1",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Vendedor.Dcampo1,
            };
            return Pcampo1;
        }

        private static SqlParameter Getcampo2(DVendedor Vendedor)
        {
            SqlParameter Pcampo2 = new SqlParameter
            {
                ParameterName = "@campo2",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Vendedor.Dcampo2,
            };
            return Pcampo2;
        }

        private static SqlParameter Getcampo3(DVendedor Vendedor)
        {
            SqlParameter Pcampo3 = new SqlParameter
            {
                ParameterName = "@campo3",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Vendedor.Dcampo3,
            };
            return Pcampo3;
        }

        private static SqlParameter Getcampo4(DVendedor Vendedor)
        {
            SqlParameter Pcampo4 = new SqlParameter
            {
                ParameterName = "@campo4",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Vendedor.Dcampo4,
            };
            return Pcampo4;
        }

        private static SqlParameter Getcampo5(DVendedor Vendedor)
        {
            SqlParameter Pcampo5 = new SqlParameter
            {
                ParameterName = "@campo5",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Vendedor.Dcampo5,
            };
            return Pcampo5;
        }

        private static SqlParameter Getcampo6(DVendedor Vendedor)
        {
            SqlParameter Pcampo6 = new SqlParameter
            {
                ParameterName = "@campo6",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Vendedor.Dcampo6,
            };
            return Pcampo6;
        }

        private static SqlParameter Getbuscar(DVendedor Vendedor)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Vendedor.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DVendedor Vendedor)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Vendedor.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DVendedor Vendedor)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Vendedor.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DVendedor Vendedor)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Vendedor.Dbtipo,
            };
            return Pbtipo;
        }

        #endregion

        public DVendedor()
        {
            /// Constructor Vacio
        }


        /// <summary>
        /// Tabla Mostrar No Recibe parametros y Muestra un DataTable
        /// </summary>
        /// <returns> No Recibe Parametros</returns>
        public DataTable Mostrar()
        {
            DataTable DtRpta = new DataTable("TbVendedor");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "vendedor_mostrar",
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
                    CommandText = "vendedor_listar",
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
        public string Insertar(DVendedor Vendedor)
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
                    CommandText = "vendedor_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_vendedor = Getcod_vendedor(Vendedor);
                Cmd.Parameters.Add(Parcod_vendedor);

                SqlParameter Pardesc_vendedor = Getdesc_vendedor(Vendedor);
                Cmd.Parameters.Add(Pardesc_vendedor);

                SqlParameter Parrif = Getrif(Vendedor);
                Cmd.Parameters.Add(Parrif);

                SqlParameter Partelefono = Gettelefono(Vendedor);
                Cmd.Parameters.Add(Partelefono);

                SqlParameter Pardireccion = Getdireccion(Vendedor);
                Cmd.Parameters.Add(Pardireccion);

                SqlParameter Parnivel = Getnivel(Vendedor);
                Cmd.Parameters.Add(Parnivel);

                SqlParameter Parcomisionventa = Getcomisionventa(Vendedor);
                Cmd.Parameters.Add(Parcomisionventa);

                SqlParameter Parcomisioncobro = Getcomisioncobro(Vendedor);
                Cmd.Parameters.Add(Parcomisioncobro);

                SqlParameter Partventas_item = Gettventas_item(Vendedor);
                Cmd.Parameters.Add(Partventas_item);

                SqlParameter Partventas_monto = Gettventas_monto(Vendedor);
                Cmd.Parameters.Add(Partventas_monto);

                SqlParameter Parfecha_reg = Getfecha_reg(Vendedor);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parcobra = Getcobra(Vendedor);
                Cmd.Parameters.Add(Parcobra);

                SqlParameter Parventa = Getventa(Vendedor);
                Cmd.Parameters.Add(Parventa);

                SqlParameter Paractivo = Getactivo(Vendedor);
                Cmd.Parameters.Add(Paractivo);

                SqlParameter Parcampo1 = Getcampo1(Vendedor);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Vendedor);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Vendedor);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Vendedor);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Vendedor);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Vendedor);
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
        public string Editar(DVendedor Vendedor)
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
                    CommandText = "vendedor_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_vendedor = Getcod_vendedor(Vendedor);
                Cmd.Parameters.Add(Parcod_vendedor);

                SqlParameter Parcod_vendedorv = Getcod_vendedorv(Vendedor);
                Cmd.Parameters.Add(Parcod_vendedorv);

                SqlParameter Pardesc_vendedor = Getdesc_vendedor(Vendedor);
                Cmd.Parameters.Add(Pardesc_vendedor);

                SqlParameter Parrif = Getrif(Vendedor);
                Cmd.Parameters.Add(Parrif);

                SqlParameter Partelefono = Gettelefono(Vendedor);
                Cmd.Parameters.Add(Partelefono);

                SqlParameter Pardireccion = Getdireccion(Vendedor);
                Cmd.Parameters.Add(Pardireccion);

                SqlParameter Parnivel = Getnivel(Vendedor);
                Cmd.Parameters.Add(Parnivel);

                SqlParameter Parcomisionventa = Getcomisionventa(Vendedor);
                Cmd.Parameters.Add(Parcomisionventa);

                SqlParameter Parcomisioncobro = Getcomisioncobro(Vendedor);
                Cmd.Parameters.Add(Parcomisioncobro);

                SqlParameter Partventas_item = Gettventas_item(Vendedor);
                Cmd.Parameters.Add(Partventas_item);

                SqlParameter Partventas_monto = Gettventas_monto(Vendedor);
                Cmd.Parameters.Add(Partventas_monto);

                SqlParameter Parfecha_reg = Getfecha_reg(Vendedor);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parcobra = Getcobra(Vendedor);
                Cmd.Parameters.Add(Parcobra);

                SqlParameter Parventa = Getventa(Vendedor);
                Cmd.Parameters.Add(Parventa);

                SqlParameter Paractivo = Getactivo(Vendedor);
                Cmd.Parameters.Add(Paractivo);

                SqlParameter Parcampo1 = Getcampo1(Vendedor);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Vendedor);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Vendedor);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Vendedor);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Vendedor);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Vendedor);
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
        public string Eliminar(DVendedor Vendedor)
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
                    CommandText = "vendedor_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_vendedor = Getcod_vendedor(Vendedor);
                Cmd.Parameters.Add(Parcod_vendedor);

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
        public DataTable Buscar(DVendedor Vendedor)
        {
            DataTable DtRpta = new DataTable("TbVendedor");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "vendedor_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(Vendedor);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(Vendedor);
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
        public DataTable RepBuscar(DVendedor Vendedor)
        {
            DataTable DtRpta = new DataTable("TbVendedor");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "vendedor_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(Vendedor);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(Vendedor);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(Vendedor);
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
                    CommandText = "vendedor_primero",
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
                    CommandText = "vendedor_ultimo",
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
        /// <param name="Listar Anterior Vendedor"></param>
        public DataSet Anterior(DVendedor Vendedor)
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
                    CommandText = "vendedor_anterior",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_vendedor = Getcod_vendedor(Vendedor);
                Cmd.Parameters.Add(Parcod_vendedor);

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
        /// <param name="Listar Siguiente Vendedor"></param>
        public DataSet Siguiente(DVendedor Vendedor)
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
                    CommandText = "vendedor_siguiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_vendedor = Getcod_vendedor(Vendedor);
                Cmd.Parameters.Add(Parcod_vendedor);

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
        public string GenerarCod(DVendedor Vendedor)
        {
            SqlConnection SqlConn = new SqlConnection
            {
                ConnectionString = DConexion.Cn
            };

            SqlConn.Open();
            SqlCommand Cmd = new SqlCommand
            {
                Connection = SqlConn,
                CommandText = "vendedor_generar_cod",
                CommandType = CommandType.StoredProcedure,
            };

            try
            {
                SqlParameter ParCod_vendedor = new SqlParameter("@cod_vendedor", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                    Value = Vendedor.Dcod_vendedor
                };
                Cmd.Parameters.Add(ParCod_vendedor);

                if (Cmd.ExecuteNonQuery() == 0)
                {
                    return Cmd.Parameters[ParCod_vendedor.ToString()].Value.ToString();
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
            return Cmd.Parameters["@cod_vendedor"].Value.ToString();
        }
    }
}
