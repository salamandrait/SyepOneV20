using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DCliente
    {

        #region PARAMETROS
        public Object Dcod_cliente { get; set; }
        public Object Dcod_clientev { get; set; }
        public Object Ddesc_cliente { get; set; }
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
        public Object Dcod_vendedor { get; set; }
        public Object Dcod_tipocliente { get; set; }
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

        private static SqlParameter Getcod_cliente(DCliente Cliente)
        {
            SqlParameter Pcod_cliente = new SqlParameter
            {
                ParameterName = "@cod_cliente",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Cliente.Dcod_cliente
            };
            return Pcod_cliente;
        }

        private static SqlParameter Getcod_clientev(DCliente Cliente)
        {
            SqlParameter Pcod_clientev = new SqlParameter
            {
                ParameterName = "@cod_clientev",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Cliente.Dcod_clientev
            };
            return Pcod_clientev;
        }

        private static SqlParameter Getdesc_cliente(DCliente Cliente)
        {
            SqlParameter Pdesc_cliente = new SqlParameter
            {
                ParameterName = "@desc_cliente",
                SqlDbType = SqlDbType.VarChar,
                Size = 250,
                Value = Cliente.Ddesc_cliente
            };
            return Pdesc_cliente;
        }

        private static SqlParameter Getclasificacion(DCliente Cliente)
        {
            SqlParameter Pclasificacion = new SqlParameter
            {
                ParameterName = "@clasificacion",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cliente.Dclasificacion
            };
            return Pclasificacion;
        }

        private static SqlParameter Getrif(DCliente Cliente)
        {
            SqlParameter Prif = new SqlParameter
            {
                ParameterName = "@rif",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cliente.Drif
            };
            return Prif;
        }

        private static SqlParameter Getcontacto(DCliente Cliente)
        {
            SqlParameter Pcontacto = new SqlParameter
            {
                ParameterName = "@contacto",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cliente.Dcontacto
            };
            return Pcontacto;
        }

        private static SqlParameter Getdireccion(DCliente Cliente)
        {
            SqlParameter Pdireccion = new SqlParameter
            {
                ParameterName = "@direccion",
                SqlDbType = SqlDbType.VarChar,
                Size = 500,
                Value = Cliente.Ddireccion
            };
            return Pdireccion;
        }

        private static SqlParameter Getdireccion_alterna(DCliente Cliente)
        {
            SqlParameter Pdireccion_alterna = new SqlParameter
            {
                ParameterName = "@direccion_alterna",
                SqlDbType = SqlDbType.VarChar,
                Size = 500,
                Value = Cliente.Ddireccion_alterna
            };
            return Pdireccion_alterna;
        }

        private static SqlParameter Getciudad(DCliente Cliente)
        {
            SqlParameter Pciudad = new SqlParameter
            {
                ParameterName = "@ciudad",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cliente.Dciudad
            };
            return Pciudad;
        }

        private static SqlParameter Gettelefono(DCliente Cliente)
        {
            SqlParameter Ptelefono = new SqlParameter
            {
                ParameterName = "@telefono",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cliente.Dtelefono
            };
            return Ptelefono;
        }

        private static SqlParameter Getmovil(DCliente Cliente)
        {
            SqlParameter Pmovil = new SqlParameter
            {
                ParameterName = "@movil",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cliente.Dmovil
            };
            return Pmovil;
        }

        private static SqlParameter Getcod_postal(DCliente Cliente)
        {
            SqlParameter Pcod_postal = new SqlParameter
            {
                ParameterName = "@cod_postal",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cliente.Dcod_postal
            };
            return Pcod_postal;
        }

        private static SqlParameter Getweb(DCliente Cliente)
        {
            SqlParameter Pweb = new SqlParameter
            {
                ParameterName = "@web",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cliente.Dweb
            };
            return Pweb;
        }

        private static SqlParameter Getemail(DCliente Cliente)
        {
            SqlParameter Pemail = new SqlParameter
            {
                ParameterName = "@email",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cliente.Demail
            };
            return Pemail;
        }

        private static SqlParameter Getmontofiscal(DCliente Cliente)
        {
            SqlParameter Pmontofiscal = new SqlParameter
            {
                ParameterName = "@montofiscal",
                SqlDbType = SqlDbType.Decimal,
                Precision = 18,
                Scale = 3,
                Value = Cliente.Dmontofiscal
            };
            return Pmontofiscal;
        }

        private static SqlParameter Getdescuentopp(DCliente Cliente)
        {
            SqlParameter Pdescuentopp = new SqlParameter
            {
                ParameterName = "@descuentopp",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = Cliente.Ddescuentopp
            };
            return Pdescuentopp;
        }

        private static SqlParameter Getdescuentogb(DCliente Cliente)
        {
            SqlParameter Pdescuentogb = new SqlParameter
            {
                ParameterName = "@descuentogb",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = Cliente.Ddescuentogb
            };
            return Pdescuentogb;
        }

        private static SqlParameter Getlimite_cred(DCliente Cliente)
        {
            SqlParameter Plimite_cred = new SqlParameter
            {
                ParameterName = "@limite_cred",
                SqlDbType = SqlDbType.Money,
                Precision = 18,
                Scale = 3,
                Value = Cliente.Dlimite_cred
            };
            return Plimite_cred;
        }

        private static SqlParameter Getactivo(DCliente Cliente)
        {
            SqlParameter Pactivo = new SqlParameter
            {
                ParameterName = "@activo",
                SqlDbType = SqlDbType.Bit,
                Value = Cliente.Dactivo
            };
            return Pactivo;
        }

        private static SqlParameter Getnacional(DCliente Cliente)
        {
            SqlParameter Pnacional = new SqlParameter
            {
                ParameterName = "@nacional",
                SqlDbType = SqlDbType.Bit,
                Value = Cliente.Dnacional
            };
            return Pnacional;
        }

        private static SqlParameter Getfiscal(DCliente Cliente)
        {
            SqlParameter Pfiscal = new SqlParameter
            {
                ParameterName = "@fiscal",
                SqlDbType = SqlDbType.Bit,
                Value = Cliente.Dfiscal
            };
            return Pfiscal;
        }

        private static SqlParameter Getaplica_credito(DCliente Cliente)
        {
            SqlParameter Paplica_credito = new SqlParameter
            {
                ParameterName = "@aplica_credito",
                SqlDbType = SqlDbType.Bit,
                Value = Cliente.Daplica_credito
            };
            return Paplica_credito;
        }

        private static SqlParameter Getfecha_reg(DCliente Cliente)
        {
            SqlParameter Parfecha_reg = new SqlParameter
            {
                ParameterName = "@fecha_reg",
                SqlDbType = SqlDbType.DateTime,
                Value = Cliente.Dfecha_reg
            };
            return Parfecha_reg;
        }

        private static SqlParameter Getcampo1(DCliente Cliente)
        {
            SqlParameter Pcampo1 = new SqlParameter
            {
                ParameterName = "@campo1",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cliente.Dcampo1,
            };
            return Pcampo1;
        }

        private static SqlParameter Getcampo2(DCliente Cliente)
        {
            SqlParameter Pcampo2 = new SqlParameter
            {
                ParameterName = "@campo2",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cliente.Dcampo2,
            };
            return Pcampo2;
        }

        private static SqlParameter Getcampo3(DCliente Cliente)
        {
            SqlParameter Pcampo3 = new SqlParameter
            {
                ParameterName = "@campo3",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cliente.Dcampo3,
            };
            return Pcampo3;
        }

        private static SqlParameter Getcampo4(DCliente Cliente)
        {
            SqlParameter Pcampo4 = new SqlParameter
            {
                ParameterName = "@campo4",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cliente.Dcampo4,
            };
            return Pcampo4;
        }

        private static SqlParameter Getcampo5(DCliente Cliente)
        {
            SqlParameter Pcampo5 = new SqlParameter
            {
                ParameterName = "@campo5",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cliente.Dcampo5,
            };
            return Pcampo5;
        }

        private static SqlParameter Getcampo6(DCliente Cliente)
        {
            SqlParameter Pcampo6 = new SqlParameter
            {
                ParameterName = "@campo6",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cliente.Dcampo6,
            };
            return Pcampo6;
        }

        private static SqlParameter Getcod_vendedor(DCliente Cliente)
        {
            SqlParameter Pcod_vendedor = new SqlParameter
            {
                ParameterName = "@cod_vendedor",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Cliente.Dcod_vendedor
            };
            return Pcod_vendedor;
        }

        private static SqlParameter Getcod_tipocliente(DCliente Cliente)
        {
            SqlParameter Pcod_tipocliente = new SqlParameter
            {
                ParameterName = "@cod_tipocliente",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Cliente.Dcod_tipocliente
            };
            return Pcod_tipocliente;
        }

        private static SqlParameter Getcod_segmento(DCliente Cliente)
        {
            SqlParameter Pcod_segmento = new SqlParameter
            {
                ParameterName = "@cod_segmento",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Cliente.Dcod_segmento
            };
            return Pcod_segmento;
        }

        private static SqlParameter Getcod_condicionpago(DCliente Cliente)
        {
            SqlParameter Pcod_condicionpago = new SqlParameter
            {
                ParameterName = "@cod_condicionpago",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Cliente.Dcod_condicionpago
            };
            return Pcod_condicionpago;
        }

        private static SqlParameter Getcod_cuentasie(DCliente Cliente)
        {
            SqlParameter Pcod_cuentasie = new SqlParameter
            {
                ParameterName = "@cod_cuentasie",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Cliente.Dcod_cuentasie
            };
            return Pcod_cuentasie;
        }

        private static SqlParameter Getcod_islr(DCliente Cliente)
        {
            SqlParameter Pcod_islr = new SqlParameter
            {
                ParameterName = "@cod_islr",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Cliente.Dcod_islr
            };
            return Pcod_islr;
        }

        private static SqlParameter Getcod_pais(DCliente Cliente)
        {
            SqlParameter Pcod_pais = new SqlParameter
            {
                ParameterName = "@cod_pais",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Cliente.Dcod_pais
            };
            return Pcod_pais;
        }

        private static SqlParameter Getcod_zona(DCliente Cliente)
        {
            SqlParameter Pcod_zona = new SqlParameter
            {
                ParameterName = "@cod_zona",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Cliente.Dcod_zona
            };
            return Pcod_zona;
        }

        private static SqlParameter Getbuscar(DCliente Cliente)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cliente.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DCliente Cliente)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cliente.Dbuscar,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DCliente Cliente)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cliente.Dbuscar,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DCliente Cliente)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Cliente.Dbtipo,
            };
            return Pbtipo;
        }

        #endregion

        public DCliente()
        {
            /// Constructor Vacio
        }


        /// <summary>
        /// Tabla Mostrar No Recibe parametros y Muestra un DataTable
        /// </summary>
        /// <returns> No Recibe Parametros</returns>
        public DataTable Mostrar()
        {
            DataTable DtRpta = new DataTable("TbCliente");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "cliente_mostrar",
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
                    CommandText = "cliente_listar",
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
        public string Insertar(DCliente Cliente)
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
                    CommandText = "cliente_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                #region PARAMETROS
                SqlParameter Parcod_cliente = Getcod_cliente(Cliente);
                Cmd.Parameters.Add(Parcod_cliente);

                SqlParameter Pardesc_cliente = Getdesc_cliente(Cliente);
                Cmd.Parameters.Add(Pardesc_cliente);

                SqlParameter Parclasificacion = Getclasificacion(Cliente);
                Cmd.Parameters.Add(Parclasificacion);

                SqlParameter Parrif = Getrif(Cliente);
                Cmd.Parameters.Add(Parrif);

                SqlParameter Parcontacto = Getcontacto(Cliente);
                Cmd.Parameters.Add(Parcontacto);

                SqlParameter Pardireccion = Getdireccion(Cliente);
                Cmd.Parameters.Add(Pardireccion);

                SqlParameter Pardireccion_alterna = Getdireccion_alterna(Cliente);
                Cmd.Parameters.Add(Pardireccion_alterna);

                SqlParameter Parciudad = Getciudad(Cliente);
                Cmd.Parameters.Add(Parciudad);

                SqlParameter Partelefono = Gettelefono(Cliente);
                Cmd.Parameters.Add(Partelefono);

                SqlParameter Parmovil = Getmovil(Cliente);
                Cmd.Parameters.Add(Parmovil);

                SqlParameter Parcod_postal = Getcod_postal(Cliente);
                Cmd.Parameters.Add(Parcod_postal);

                SqlParameter Parweb = Getweb(Cliente);
                Cmd.Parameters.Add(Parweb);

                SqlParameter Paremail = Getemail(Cliente);
                Cmd.Parameters.Add(Paremail);

                SqlParameter Parmontofiscal = Getmontofiscal(Cliente);
                Cmd.Parameters.Add(Parmontofiscal);

                SqlParameter Pardescuentopp = Getdescuentopp(Cliente);
                Cmd.Parameters.Add(Pardescuentopp);

                SqlParameter Pardescuentogb = Getdescuentogb(Cliente);
                Cmd.Parameters.Add(Pardescuentogb);

                SqlParameter Parlimite_cred = Getlimite_cred(Cliente);
                Cmd.Parameters.Add(Parlimite_cred);

                SqlParameter Paractivo = Getactivo(Cliente);
                Cmd.Parameters.Add(Paractivo);

                SqlParameter Parnacional = Getnacional(Cliente);
                Cmd.Parameters.Add(Parnacional);

                SqlParameter Parfiscal = Getfiscal(Cliente);
                Cmd.Parameters.Add(Parfiscal);

                SqlParameter Paraplica_credito = Getaplica_credito(Cliente);
                Cmd.Parameters.Add(Paraplica_credito);

                SqlParameter Parfecha_reg = Getfecha_reg(Cliente);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parcampo1 = Getcampo1(Cliente);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Cliente);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Cliente);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Cliente);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Cliente);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Cliente);
                Cmd.Parameters.Add(Parcampo6);

                SqlParameter Parcod_vendedor = Getcod_vendedor(Cliente);
                Cmd.Parameters.Add(Parcod_vendedor);

                SqlParameter Parcod_tipocliente = Getcod_tipocliente(Cliente);
                Cmd.Parameters.Add(Parcod_tipocliente);

                SqlParameter Parcod_segmento = Getcod_segmento(Cliente);
                Cmd.Parameters.Add(Parcod_segmento);

                SqlParameter Parcod_condicionpago = Getcod_condicionpago(Cliente);
                Cmd.Parameters.Add(Parcod_condicionpago);

                SqlParameter Parcod_cuentasie = Getcod_cuentasie(Cliente);
                Cmd.Parameters.Add(Parcod_cuentasie);

                SqlParameter Parcod_islr = Getcod_islr(Cliente);
                Cmd.Parameters.Add(Parcod_islr);

                SqlParameter Parcod_pais = Getcod_pais(Cliente);
                Cmd.Parameters.Add(Parcod_pais);

                SqlParameter Parcod_zona = Getcod_zona(Cliente);
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
        public string Editar(DCliente Cliente)
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
                    CommandText = "cliente_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                #region PARAMETROS
                SqlParameter Parcod_cliente = Getcod_cliente(Cliente);
                Cmd.Parameters.Add(Parcod_cliente);

                SqlParameter Parcod_clientev = Getcod_clientev(Cliente);
                Cmd.Parameters.Add(Parcod_clientev);

                SqlParameter Pardesc_cliente = Getdesc_cliente(Cliente);
                Cmd.Parameters.Add(Pardesc_cliente);

                SqlParameter Parclasificacion = Getclasificacion(Cliente);
                Cmd.Parameters.Add(Parclasificacion);

                SqlParameter Parrif = Getrif(Cliente);
                Cmd.Parameters.Add(Parrif);

                SqlParameter Parcontacto = Getcontacto(Cliente);
                Cmd.Parameters.Add(Parcontacto);

                SqlParameter Pardireccion = Getdireccion(Cliente);
                Cmd.Parameters.Add(Pardireccion);

                SqlParameter Pardireccion_alterna = Getdireccion_alterna(Cliente);
                Cmd.Parameters.Add(Pardireccion_alterna);

                SqlParameter Parciudad = Getciudad(Cliente);
                Cmd.Parameters.Add(Parciudad);

                SqlParameter Partelefono = Gettelefono(Cliente);
                Cmd.Parameters.Add(Partelefono);

                SqlParameter Parmovil = Getmovil(Cliente);
                Cmd.Parameters.Add(Parmovil);

                SqlParameter Parcod_postal = Getcod_postal(Cliente);
                Cmd.Parameters.Add(Parcod_postal);

                SqlParameter Parweb = Getweb(Cliente);
                Cmd.Parameters.Add(Parweb);

                SqlParameter Paremail = Getemail(Cliente);
                Cmd.Parameters.Add(Paremail);

                SqlParameter Parmontofiscal = Getmontofiscal(Cliente);
                Cmd.Parameters.Add(Parmontofiscal);

                SqlParameter Pardescuentopp = Getdescuentopp(Cliente);
                Cmd.Parameters.Add(Pardescuentopp);

                SqlParameter Pardescuentogb = Getdescuentogb(Cliente);
                Cmd.Parameters.Add(Pardescuentogb);

                SqlParameter Parlimite_cred = Getlimite_cred(Cliente);
                Cmd.Parameters.Add(Parlimite_cred);

                SqlParameter Paractivo = Getactivo(Cliente);
                Cmd.Parameters.Add(Paractivo);

                SqlParameter Parnacional = Getnacional(Cliente);
                Cmd.Parameters.Add(Parnacional);

                SqlParameter Parfiscal = Getfiscal(Cliente);
                Cmd.Parameters.Add(Parfiscal);

                SqlParameter Paraplica_credito = Getaplica_credito(Cliente);
                Cmd.Parameters.Add(Paraplica_credito);

                SqlParameter Parfecha_reg = Getfecha_reg(Cliente);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Parcampo1 = Getcampo1(Cliente);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Cliente);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Cliente);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Cliente);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Cliente);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Cliente);
                Cmd.Parameters.Add(Parcampo6);

                SqlParameter Parcod_vendedor = Getcod_vendedor(Cliente);
                Cmd.Parameters.Add(Parcod_vendedor);

                SqlParameter Parcod_tipocliente = Getcod_tipocliente(Cliente);
                Cmd.Parameters.Add(Parcod_tipocliente);

                SqlParameter Parcod_segmento = Getcod_segmento(Cliente);
                Cmd.Parameters.Add(Parcod_segmento);

                SqlParameter Parcod_condicionpago = Getcod_condicionpago(Cliente);
                Cmd.Parameters.Add(Parcod_condicionpago);

                SqlParameter Parcod_cuentasie = Getcod_cuentasie(Cliente);
                Cmd.Parameters.Add(Parcod_cuentasie);

                SqlParameter Parcod_islr = Getcod_islr(Cliente);
                Cmd.Parameters.Add(Parcod_islr);

                SqlParameter Parcod_pais = Getcod_pais(Cliente);
                Cmd.Parameters.Add(Parcod_pais);

                SqlParameter Parcod_zona = Getcod_zona(Cliente);
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
        public string Eliminar(DCliente Cliente)
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
                    CommandText = "cliente_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_cliente = Getcod_cliente(Cliente);
                Cmd.Parameters.Add(Parcod_cliente);

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
        public DataTable Buscar(DCliente Cliente)
        {
            DataTable DtRpta = new DataTable("TbCliente");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "cliente_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(Cliente);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(Cliente);
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
        public DataTable RepBuscar(DCliente Cliente)
        {
            DataTable DtRpta = new DataTable("TbCliente");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "cliente_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(Cliente);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(Cliente);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(Cliente);
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
                    CommandText = "cliente_primero",
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
                    CommandText = "cliente_ultimo",
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
        /// <param name="Listar Anterior Cliente"></param>
        public DataSet Anterior(DCliente Cliente)
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
                    CommandText = "cliente_anterior",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_cliente = Getcod_cliente(Cliente);
                Cmd.Parameters.Add(Parcod_cliente);

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
        /// <param name="Listar Siguiente Cliente"></param>
        public DataSet Siguiente(DCliente Cliente)
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
                    CommandText = "cliente_siguiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_cliente = Getcod_cliente(Cliente);
                Cmd.Parameters.Add(Parcod_cliente);

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
        public string GenerarCod(DCliente Cliente)
        {
            SqlConnection SqlConn = new SqlConnection
            {
                ConnectionString = DConexion.Cn
            };

            SqlConn.Open();
            SqlCommand Cmd = new SqlCommand
            {
                Connection = SqlConn,
                CommandText = "cliente_generar_cod",
                CommandType = CommandType.StoredProcedure,
            };

            try
            {
                SqlParameter ParCod_cliente = new SqlParameter("@cod_cliente", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                    Value = Cliente.Dcod_cliente
                };
                Cmd.Parameters.Add(ParCod_cliente);

                if (Cmd.ExecuteNonQuery() == 0)
                {
                    return Cmd.Parameters[ParCod_cliente.ToString()].Value.ToString();
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
            return Cmd.Parameters["@cod_cliente"].Value.ToString();
        }
    }
}
