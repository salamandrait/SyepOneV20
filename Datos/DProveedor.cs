using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DProveedor
    {

        #region PARAMETROS
        public Object Dcod_proveedor { get; set; }
        public Object Dcod_proveedorv { get; set; }
        public Object Ddesc_proveedor { get; set; }
        public Object Dclasificacion { get; set; }
        public Object Drif { get; set; }
        public Object Dcontacto { get; set; }
        public Object Ddireccion { get; set; }
        public Object Ddireccion_alterna { get; set; }
        public Object Dciudad { get; set; }
        public Object Dtelefono { get; set; }
        public Object Dmovil { get; set; }
        public Object Dcod_postal { get; set; }
        public Object Dweb { get; set; }
        public Object Demail { get; set; }
        public Object Dmontofiscal { get; set; }
        public Object Ddescuentopp { get; set; }
        public Object Ddescuentogb { get; set; }
        public Object Dlimite_cred { get; set; }
        public Object Dactivo { get; set; }
        public Object Dnacional { get; set; }
        public Object Dfiscal { get; set; }
        public Object Daplica_credito { get; set; }
        public Object Dfecha_reg { get; set; }
        public Object Dcampo1 { get; set; }
        public Object Dcampo2 { get; set; }
        public Object Dcampo3 { get; set; }
        public Object Dcampo4 { get; set; }
        public Object Dcampo5 { get; set; }
        public Object Dcampo6 { get; set; }
        public Object Dcod_tipoproveedor { get; set; }
        public Object Dcod_segmento { get; set; }
        public Object Dcod_condicionpago { get; set; }
        public Object Dcod_cuentasie { get; set; }
        public Object Dcod_islr { get; set; }
        public Object Dcod_pais { get; set; }
        public Object Dcod_zona { get; set; }
        public Object Dbuscar { get; set; }
        public Object Dbuscard { get; set; }
        public Object Dbuscarh { get; set; }
        public Object Dbtipo { get; set; }

        private static SqlParameter Getcod_proveedor(DProveedor Proveedor)
        {
            SqlParameter Pcod_proveedor = new SqlParameter
            {
                ParameterName = "@cod_proveedor",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Proveedor.Dcod_proveedor
            };
            return Pcod_proveedor;
        }

        private static SqlParameter Getcod_proveedorv(DProveedor Proveedor)
        {
            SqlParameter Pcod_proveedorv = new SqlParameter
            {
                ParameterName = "@cod_proveedorv",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Proveedor.Dcod_proveedorv
            };
            return Pcod_proveedorv;
        }

        private static SqlParameter Getdesc_proveedor(DProveedor Proveedor)
        {
            SqlParameter Pdesc_proveedor = new SqlParameter
            {
                ParameterName = "@desc_proveedor",
                SqlDbType = SqlDbType.VarChar,
                Size = 250,
                Value = Proveedor.Ddesc_proveedor
            };
            return Pdesc_proveedor;
        }

        private static SqlParameter Getclasificacion(DProveedor Proveedor)
        {
            SqlParameter Pclasificacion = new SqlParameter
            {
                ParameterName = "@clasificacion",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Proveedor.Dclasificacion
            };
            return Pclasificacion;
        }

        private static SqlParameter Getrif(DProveedor Proveedor)
        {
            SqlParameter Prif = new SqlParameter
            {
                ParameterName = "@rif",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Proveedor.Drif
            };
            return Prif;
        }

        private static SqlParameter Getcontacto(DProveedor Proveedor)
        {
            SqlParameter Pcontacto = new SqlParameter
            {
                ParameterName = "@contacto",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Proveedor.Dcontacto
            };
            return Pcontacto;
        }

        private static SqlParameter Getdireccion(DProveedor Proveedor)
        {
            SqlParameter Pdireccion = new SqlParameter
            {
                ParameterName = "@direccion",
                SqlDbType = SqlDbType.VarChar,
                Size = 500,
                Value = Proveedor.Ddireccion
            };
            return Pdireccion;
        }

        private static SqlParameter Getdireccion_alterna(DProveedor Proveedor)
        {
            SqlParameter Pdireccion_alterna = new SqlParameter
            {
                ParameterName = "@direccion_alterna",
                SqlDbType = SqlDbType.VarChar,
                Size = 500,
                Value = Proveedor.Ddireccion_alterna
            };
            return Pdireccion_alterna;
        }

        private static SqlParameter Getciudad(DProveedor Proveedor)
        {
            SqlParameter Pciudad = new SqlParameter
            {
                ParameterName = "@ciudad",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Proveedor.Dciudad
            };
            return Pciudad;
        }

        private static SqlParameter Gettelefono(DProveedor Proveedor)
        {
            SqlParameter Ptelefono = new SqlParameter
            {
                ParameterName = "@telefono",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Proveedor.Dtelefono
            };
            return Ptelefono;
        }

        private static SqlParameter Getmovil(DProveedor Proveedor)
        {
            SqlParameter Pmovil = new SqlParameter
            {
                ParameterName = "@movil",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Proveedor.Dmovil
            };
            return Pmovil;
        }

        private static SqlParameter Getcod_postal(DProveedor Proveedor)
        {
            SqlParameter Pcod_postal = new SqlParameter
            {
                ParameterName = "@cod_postal",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Proveedor.Dcod_postal
            };
            return Pcod_postal;
        }

        private static SqlParameter Getweb(DProveedor Proveedor)
        {
            SqlParameter Pweb = new SqlParameter
            {
                ParameterName = "@web",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Proveedor.Dweb
            };
            return Pweb;
        }

        private static SqlParameter Getemail(DProveedor Proveedor)
        {
            SqlParameter Pemail = new SqlParameter
            {
                ParameterName = "@email",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Proveedor.Demail
            };
            return Pemail;
        }

        private static SqlParameter Getmontofiscal(DProveedor Proveedor)
        {
            SqlParameter Pmontofiscal = new SqlParameter
            {
                ParameterName = "@montofiscal",
                SqlDbType = SqlDbType.Decimal,
                Precision = 18,
                Scale = 3,
                Value = Proveedor.Dmontofiscal
            };
            return Pmontofiscal;
        }

        private static SqlParameter Getdescuentopp(DProveedor Proveedor)
        {
            SqlParameter Pdescuentopp = new SqlParameter
            {
                ParameterName = "@descuentopp",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = Proveedor.Ddescuentopp
            };
            return Pdescuentopp;
        }

        private static SqlParameter Getdescuentogb(DProveedor Proveedor)
        {
            SqlParameter Pdescuentogb = new SqlParameter
            {
                ParameterName = "@descuentogb",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = Proveedor.Ddescuentogb
            };
            return Pdescuentogb;
        }

        private static SqlParameter Getlimite_cred(DProveedor Proveedor)
        {
            SqlParameter Plimite_cred = new SqlParameter
            {
                ParameterName = "@limite_cred",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = Proveedor.Dlimite_cred
            };
            return Plimite_cred;
        }

        private static SqlParameter Getactivo(DProveedor Proveedor)
        {
            SqlParameter Pactivo = new SqlParameter
            {
                ParameterName = "@activo",
                SqlDbType = SqlDbType.Bit,
                Value = Proveedor.Dactivo
            };
            return Pactivo;
        }

        private static SqlParameter Getnacional(DProveedor Proveedor)
        {
            SqlParameter Pnacional = new SqlParameter
            {
                ParameterName = "@nacional",
                SqlDbType = SqlDbType.Bit,
                Value = Proveedor.Dnacional
            };
            return Pnacional;
        }

        private static SqlParameter Getfiscal(DProveedor Proveedor)
        {
            SqlParameter Pfiscal = new SqlParameter
            {
                ParameterName = "@fiscal",
                SqlDbType = SqlDbType.Bit,
                Value = Proveedor.Dfiscal
            };
            return Pfiscal;
        }

        private static SqlParameter Getaplica_credito(DProveedor Proveedor)
        {
            SqlParameter Paplica_credito = new SqlParameter
            {
                ParameterName = "@aplica_credito",
                SqlDbType = SqlDbType.Bit,
                Value = Proveedor.Daplica_credito
            };
            return Paplica_credito;
        }

        private static SqlParameter Getfecha_reg(DProveedor Proveedor)
        {
            SqlParameter Parfecha_reg = new SqlParameter
            {
                ParameterName = "@fecha_reg",
                SqlDbType = SqlDbType.DateTime,
                Value = Proveedor.Dfecha_reg
            };
            return Parfecha_reg;
        }

        private static SqlParameter Getcampo1(DProveedor Proveedor)
        {
            SqlParameter Pcampo1 = new SqlParameter
            {
                ParameterName = "@campo1",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Proveedor.Dcampo1,
            };
            return Pcampo1;
        }

        private static SqlParameter Getcampo2(DProveedor Proveedor)
        {
            SqlParameter Pcampo2 = new SqlParameter
            {
                ParameterName = "@campo2",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Proveedor.Dcampo2,
            };
            return Pcampo2;
        }

        private static SqlParameter Getcampo3(DProveedor Proveedor)
        {
            SqlParameter Pcampo3 = new SqlParameter
            {
                ParameterName = "@campo3",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Proveedor.Dcampo3,
            };
            return Pcampo3;
        }

        private static SqlParameter Getcampo4(DProveedor Proveedor)
        {
            SqlParameter Pcampo4 = new SqlParameter
            {
                ParameterName = "@campo4",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Proveedor.Dcampo4,
            };
            return Pcampo4;
        }

        private static SqlParameter Getcampo5(DProveedor Proveedor)
        {
            SqlParameter Pcampo5 = new SqlParameter
            {
                ParameterName = "@campo5",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Proveedor.Dcampo5,
            };
            return Pcampo5;
        }

        private static SqlParameter Getcampo6(DProveedor Proveedor)
        {
            SqlParameter Pcampo6 = new SqlParameter
            {
                ParameterName = "@campo6",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Proveedor.Dcampo6,
            };
            return Pcampo6;
        }

        private static SqlParameter Getcod_tipoproveedor(DProveedor Proveedor)
        {
            SqlParameter Pcod_tipoproveedor = new SqlParameter
            {
                ParameterName = "@cod_tipoproveedor",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Proveedor.Dcod_tipoproveedor
            };
            return Pcod_tipoproveedor;
        }

        private static SqlParameter Getcod_segmento(DProveedor Proveedor)
        {
            SqlParameter Pcod_segmento = new SqlParameter
            {
                ParameterName = "@cod_segmento",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Proveedor.Dcod_segmento
            };
            return Pcod_segmento;
        }

        private static SqlParameter Getcod_condicionpago(DProveedor Proveedor)
        {
            SqlParameter Pcod_condicionpago = new SqlParameter
            {
                ParameterName = "@cod_condicionpago",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Proveedor.Dcod_condicionpago
            };
            return Pcod_condicionpago;
        }

        private static SqlParameter Getcod_cuentasie(DProveedor Proveedor)
        {
            SqlParameter Pcod_cuentasie = new SqlParameter
            {
                ParameterName = "@cod_cuentasie",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Proveedor.Dcod_cuentasie
            };
            return Pcod_cuentasie;
        }

        private static SqlParameter Getcod_islr(DProveedor Proveedor)
        {
            SqlParameter Pcod_islr = new SqlParameter
            {
                ParameterName = "@cod_islr",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Proveedor.Dcod_islr
            };
            return Pcod_islr;
        }

        private static SqlParameter Getcod_pais(DProveedor Proveedor)
        {
            SqlParameter Pcod_pais = new SqlParameter
            {
                ParameterName = "@cod_pais",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Proveedor.Dcod_pais
            };
            return Pcod_pais;
        }

        private static SqlParameter Getcod_zona(DProveedor Proveedor)
        {
            SqlParameter Pcod_zona = new SqlParameter
            {
                ParameterName = "@cod_zona",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Proveedor.Dcod_zona
            };
            return Pcod_zona;
        }

        private static SqlParameter Getbuscar(DProveedor Proveedor)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Proveedor.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DProveedor Proveedor)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Proveedor.Dbuscar,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DProveedor Proveedor)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Proveedor.Dbuscar,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DProveedor Proveedor)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Proveedor.Dbtipo,
            };
            return Pbtipo;
        }

        #endregion

        public DProveedor()
        {
            /// Constructor Vacio
        }


        /// <summary>
        /// Tabla Mostrar No Recibe parametros y Muestra un DataTable
        /// </summary>
        /// <returns> No Recibe Parametros</returns>
        public DataTable Mostrar()
        {
            DataTable DtRpta = new DataTable("TbProveedor");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "proveedor_mostrar",
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
                    CommandText = "proveedor_listar",
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
        public string Insertar(DProveedor Proveedor)
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
                    CommandText = "proveedor_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                #region PARAMETROS
                SqlParameter Parcod_proveedor = Getcod_proveedor(Proveedor);
                Cmd.Parameters.Add(Parcod_proveedor);

                SqlParameter Pardesc_proveedor = Getdesc_proveedor(Proveedor);
                Cmd.Parameters.Add(Pardesc_proveedor);

                SqlParameter Parclasificacion = Getclasificacion(Proveedor);
                Cmd.Parameters.Add(Parclasificacion);

                SqlParameter Parrif = Getrif(Proveedor);
                Cmd.Parameters.Add(Parrif);

                SqlParameter Parcontacto = Getcontacto(Proveedor);
                Cmd.Parameters.Add(Parcontacto);

                SqlParameter Pardireccion = Getdireccion(Proveedor);
                Cmd.Parameters.Add(Pardireccion);

                SqlParameter Pardireccion_alterna = Getdireccion_alterna(Proveedor);
                Cmd.Parameters.Add(Pardireccion_alterna);

                SqlParameter Parciudad = Getciudad(Proveedor);
                Cmd.Parameters.Add(Parciudad);

                SqlParameter Partelefono = Gettelefono(Proveedor);
                Cmd.Parameters.Add(Partelefono);

                SqlParameter Parmovil = Getmovil(Proveedor);
                Cmd.Parameters.Add(Parmovil);

                SqlParameter Parcod_postal = Getcod_postal(Proveedor);
                Cmd.Parameters.Add(Parcod_postal);

                SqlParameter Parweb = Getweb(Proveedor);
                Cmd.Parameters.Add(Parweb);

                SqlParameter Paremail = Getemail(Proveedor);
                Cmd.Parameters.Add(Paremail);

                SqlParameter Parmontofiscal = Getmontofiscal(Proveedor);
                Cmd.Parameters.Add(Parmontofiscal);

                SqlParameter Pardescuentopp = Getdescuentopp(Proveedor);
                Cmd.Parameters.Add(Pardescuentopp);

                SqlParameter Pardescuentogb = Getdescuentogb(Proveedor);
                Cmd.Parameters.Add(Pardescuentogb);

                SqlParameter Parlimite_cred = Getlimite_cred(Proveedor);
                Cmd.Parameters.Add(Parlimite_cred);

                SqlParameter Paractivo = Getactivo(Proveedor);
                Cmd.Parameters.Add(Paractivo);

                SqlParameter Parnacional = Getnacional(Proveedor);
                Cmd.Parameters.Add(Parnacional);

                SqlParameter Parfiscal = Getfiscal(Proveedor);
                Cmd.Parameters.Add(Parfiscal);

                SqlParameter Paraplica_credito = Getaplica_credito(Proveedor);
                Cmd.Parameters.Add(Paraplica_credito);

                SqlParameter Parfecha_reg = Getfecha_reg(Proveedor);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parcampo1 = Getcampo1(Proveedor);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Proveedor);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Proveedor);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Proveedor);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Proveedor);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Proveedor);
                Cmd.Parameters.Add(Parcampo6);

                SqlParameter Parcod_tipoproveedor = Getcod_tipoproveedor(Proveedor);
                Cmd.Parameters.Add(Parcod_tipoproveedor);

                SqlParameter Parcod_segmento = Getcod_segmento(Proveedor);
                Cmd.Parameters.Add(Parcod_segmento);

                SqlParameter Parcod_condicionpago = Getcod_condicionpago(Proveedor);
                Cmd.Parameters.Add(Parcod_condicionpago);

                SqlParameter Parcod_cuentasie = Getcod_cuentasie(Proveedor);
                Cmd.Parameters.Add(Parcod_cuentasie);

                SqlParameter Parcod_islr = Getcod_islr(Proveedor);
                Cmd.Parameters.Add(Parcod_islr);

                SqlParameter Parcod_pais = Getcod_pais(Proveedor);
                Cmd.Parameters.Add(Parcod_pais);

                SqlParameter Parcod_zona = Getcod_zona(Proveedor);
                Cmd.Parameters.Add(Parcod_zona); 
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
        public string Editar(DProveedor Proveedor)
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
                    CommandText = "proveedor_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                #region PARAMETROS
                SqlParameter Parcod_proveedor = Getcod_proveedor(Proveedor);
                Cmd.Parameters.Add(Parcod_proveedor);

                SqlParameter Parcod_proveedorv = Getcod_proveedorv(Proveedor);
                Cmd.Parameters.Add(Parcod_proveedorv);

                SqlParameter Pardesc_proveedor = Getdesc_proveedor(Proveedor);
                Cmd.Parameters.Add(Pardesc_proveedor);

                SqlParameter Parclasificacion = Getclasificacion(Proveedor);
                Cmd.Parameters.Add(Parclasificacion);

                SqlParameter Parrif = Getrif(Proveedor);
                Cmd.Parameters.Add(Parrif);

                SqlParameter Parcontacto = Getcontacto(Proveedor);
                Cmd.Parameters.Add(Parcontacto);

                SqlParameter Pardireccion = Getdireccion(Proveedor);
                Cmd.Parameters.Add(Pardireccion);

                SqlParameter Pardireccion_alterna = Getdireccion_alterna(Proveedor);
                Cmd.Parameters.Add(Pardireccion_alterna);

                SqlParameter Parciudad = Getciudad(Proveedor);
                Cmd.Parameters.Add(Parciudad);

                SqlParameter Partelefono = Gettelefono(Proveedor);
                Cmd.Parameters.Add(Partelefono);

                SqlParameter Parmovil = Getmovil(Proveedor);
                Cmd.Parameters.Add(Parmovil);

                SqlParameter Parcod_postal = Getcod_postal(Proveedor);
                Cmd.Parameters.Add(Parcod_postal);

                SqlParameter Parweb = Getweb(Proveedor);
                Cmd.Parameters.Add(Parweb);

                SqlParameter Paremail = Getemail(Proveedor);
                Cmd.Parameters.Add(Paremail);

                SqlParameter Parmontofiscal = Getmontofiscal(Proveedor);
                Cmd.Parameters.Add(Parmontofiscal);

                SqlParameter Pardescuentopp = Getdescuentopp(Proveedor);
                Cmd.Parameters.Add(Pardescuentopp);

                SqlParameter Pardescuentogb = Getdescuentogb(Proveedor);
                Cmd.Parameters.Add(Pardescuentogb);

                SqlParameter Parlimite_cred = Getlimite_cred(Proveedor);
                Cmd.Parameters.Add(Parlimite_cred);

                SqlParameter Paractivo = Getactivo(Proveedor);
                Cmd.Parameters.Add(Paractivo);

                SqlParameter Parnacional = Getnacional(Proveedor);
                Cmd.Parameters.Add(Parnacional);

                SqlParameter Parfiscal = Getfiscal(Proveedor);
                Cmd.Parameters.Add(Parfiscal);

                SqlParameter Paraplica_credito = Getaplica_credito(Proveedor);
                Cmd.Parameters.Add(Paraplica_credito);

                SqlParameter Parfecha_reg = Getfecha_reg(Proveedor);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parcampo1 = Getcampo1(Proveedor);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Proveedor);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Proveedor);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Proveedor);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Proveedor);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Proveedor);
                Cmd.Parameters.Add(Parcampo6);

                SqlParameter Parcod_tipoproveedor = Getcod_tipoproveedor(Proveedor);
                Cmd.Parameters.Add(Parcod_tipoproveedor);

                SqlParameter Parcod_segmento = Getcod_segmento(Proveedor);
                Cmd.Parameters.Add(Parcod_segmento);

                SqlParameter Parcod_condicionpago = Getcod_condicionpago(Proveedor);
                Cmd.Parameters.Add(Parcod_condicionpago);

                SqlParameter Parcod_cuentasie = Getcod_cuentasie(Proveedor);
                Cmd.Parameters.Add(Parcod_cuentasie);

                SqlParameter Parcod_islr = Getcod_islr(Proveedor);
                Cmd.Parameters.Add(Parcod_islr);

                SqlParameter Parcod_pais = Getcod_pais(Proveedor);
                Cmd.Parameters.Add(Parcod_pais);

                SqlParameter Parcod_zona = Getcod_zona(Proveedor);
                Cmd.Parameters.Add(Parcod_zona);
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
        public string Eliminar(DProveedor Proveedor)
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
                    CommandText = "proveedor_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_proveedor = Getcod_proveedor(Proveedor);
                Cmd.Parameters.Add(Parcod_proveedor);

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
        public DataTable Buscar(DProveedor Proveedor)
        {
            DataTable DtRpta = new DataTable("TbProveedor");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "proveedor_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(Proveedor);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(Proveedor);
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
        public DataTable RepBuscar(DProveedor Proveedor)
        {
            DataTable DtRpta = new DataTable("TbProveedor");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "proveedor_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(Proveedor);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(Proveedor);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(Proveedor);
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
                    CommandText = "proveedor_primero",
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
                    CommandText = "proveedor_ultimo",
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
        /// <param name="Listar Anterior Proveedor"></param>
        public DataSet Anterior(DProveedor Proveedor)
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
                    CommandText = "proveedor_anterior",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_proveedor = Getcod_proveedor(Proveedor);
                Cmd.Parameters.Add(Parcod_proveedor);

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
        /// <param name="Listar Siguiente Proveedor"></param>
        public DataSet Siguiente(DProveedor Proveedor)
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
                    CommandText = "proveedor_siguiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_proveedor = Getcod_proveedor(Proveedor);
                Cmd.Parameters.Add(Parcod_proveedor);

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
        public string GenerarCod(DProveedor Proveedor)
        {
            SqlConnection SqlConn = new SqlConnection
            {
                ConnectionString = DConexion.Cn
            };

            SqlConn.Open();
            SqlCommand Cmd = new SqlCommand
            {
                Connection = SqlConn,
                CommandText = "proveedor_generar_cod",
                CommandType = CommandType.StoredProcedure,
            };

            try
            {
                SqlParameter ParCod_proveedor = new SqlParameter("@cod_proveedor", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                    Value = Proveedor.Dcod_proveedor
                };
                Cmd.Parameters.Add(ParCod_proveedor);

                if (Cmd.ExecuteNonQuery() == 0)
                {
                    return Cmd.Parameters[ParCod_proveedor.ToString()].Value.ToString();
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
            return Cmd.Parameters["@cod_proveedor"].Value.ToString();
        }
    }
}
