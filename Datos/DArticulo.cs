using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DArticulo
    {

        #region PARAMETROS
        public Object Dcod_articulo { get; set; }
        public Object Dcod_articulov { get; set; }
        public Object Dcod_categoria { get; set; }
        public Object Dcod_linea { get; set; }
        public Object Dcod_sublinea { get; set; }
        public Object Dcod_color { get; set; }
        public Object Dcod_ubicacion { get; set; }
        public Object Dcod_impuesto { get; set; }
        public Object Ddesc_articulo { get; set; }
        public Object Dtipo { get; set; }
        public Object Dorigen { get; set; }
        public Object Ditem { get; set; }
        public Object Dreferencia { get; set; }
        public Object Dmodelo { get; set; }
        public Object Dgarantia { get; set; }
        public Object Dpunto_min { get; set; }
        public Object Dpunto_max { get; set; }
        public Object Dpunto_ped { get; set; }
        public Object Dpeso { get; set; }
        public Object Dvolumen { get; set; }
        public Object Dalto { get; set; }
        public Object Dancho { get; set; }
        public Object Dporcentaje { get; set; }
        public Object Dpuntos { get; set; }
        public Object Dfecha_reg { get; set; }
        public Object Dactivo { get; set; }
        public Object Desserial { get; set; }
        public Object Deslote { get; set; }
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


        private static SqlParameter Getcod_articulo(DArticulo Articulo)
        {
            SqlParameter Pcod_articulo = new SqlParameter()
            {
                ParameterName = "@cod_articulo",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Articulo.Dcod_articulo,
            };
            return Pcod_articulo;
        }

        private static SqlParameter Getcod_articulov(DArticulo Articulo)
        {
            SqlParameter Pcod_articulov = new SqlParameter()
            {
                ParameterName = "@cod_articulov",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Articulo.Dcod_articulov,
            };
            return Pcod_articulov;
        }

        private static SqlParameter Getcod_categoria(DArticulo Articulo)
        {
            SqlParameter Pcod_categoria = new SqlParameter()
            {
                ParameterName = "@cod_categoria",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Articulo.Dcod_categoria,
            };
            return Pcod_categoria;
        }

        private static SqlParameter Getcod_linea(DArticulo Articulo)
        {
            SqlParameter Pcod_linea = new SqlParameter()
            {
                ParameterName = "@cod_linea",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Articulo.Dcod_linea,
            };
            return Pcod_linea;
        }

        private static SqlParameter Getcod_sublinea(DArticulo Articulo)
        {
            SqlParameter Pcod_sublinea = new SqlParameter()
            {
                ParameterName = "@cod_sublinea",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Articulo.Dcod_sublinea,
            };
            return Pcod_sublinea;
        }

        private static SqlParameter Getcod_color(DArticulo Articulo)
        {
            SqlParameter Pcod_color = new SqlParameter()
            {
                ParameterName = "@cod_color",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Articulo.Dcod_color,
            };
            return Pcod_color;
        }

        private static SqlParameter Getcod_ubicacion(DArticulo Articulo)
        {
            SqlParameter Pcod_ubicacion = new SqlParameter()
            {
                ParameterName = "@cod_ubicacion",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Articulo.Dcod_ubicacion,
            };
            return Pcod_ubicacion;
        }

        private static SqlParameter Getcod_impuesto(DArticulo Articulo)
        {
            SqlParameter Pcod_impuesto = new SqlParameter()
            {
                ParameterName = "@cod_impuesto",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Articulo.Dcod_impuesto,
            };
            return Pcod_impuesto;
        }

        private static SqlParameter Getdesc_articulo(DArticulo Articulo)
        {
            SqlParameter Pdesc_articulo = new SqlParameter
            {
                ParameterName = "@desc_articulo",
                SqlDbType = SqlDbType.VarChar,
                Size = 350,
                Value = Articulo.Ddesc_articulo
            };
            return Pdesc_articulo;
        }

        private static SqlParameter Gettipo(DArticulo Articulo)
        {
            SqlParameter Ptipo = new SqlParameter
            {
                ParameterName = "@tipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Articulo.Dtipo
            };
            return Ptipo;
        }

        private static SqlParameter Getorigen(DArticulo Articulo)
        {
            SqlParameter Porigen = new SqlParameter
            {
                ParameterName = "@origen",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Articulo.Dorigen
            };
            return Porigen;
        }

        private static SqlParameter Getitem(DArticulo Articulo)
        {
            SqlParameter Pitem = new SqlParameter
            {
                ParameterName = "@item",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Articulo.Ditem
            };
            return Pitem;
        }

        private static SqlParameter Getreferencia(DArticulo Articulo)
        {
            SqlParameter Pref = new SqlParameter
            {
                ParameterName = "@referencia",
                SqlDbType = SqlDbType.VarChar,
                Size = 100,
                Value = Articulo.Dreferencia
            };
            return Pref;
        }

        private static SqlParameter Getmodelo(DArticulo Articulo)
        {
            SqlParameter Pref = new SqlParameter
            {
                ParameterName = "@modelo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Articulo.Dmodelo
            };
            return Pref;
        }

        private static SqlParameter Getgarantia(DArticulo Articulo)
        {
            SqlParameter Pref = new SqlParameter
            {
                ParameterName = "@garantia",
                SqlDbType = SqlDbType.VarChar,
                Size = 500,
                Value = Articulo.Dgarantia
            };
            return Pref;
        }

        private static SqlParameter Getpunto_min(DArticulo Articulo)
        {
            SqlParameter Ppunto_min = new SqlParameter
            {
                ParameterName = "@punto_min",
                SqlDbType = SqlDbType.Decimal,
                Precision = 18,
                Scale = 3,
                Value = Articulo.Dpunto_min
            };
            return Ppunto_min;
        }

        private static SqlParameter Getpunto_max(DArticulo Articulo)
        {
            SqlParameter Ppunto_max = new SqlParameter
            {
                ParameterName = "@punto_max",
                SqlDbType = SqlDbType.Decimal,
                Precision = 18,
                Scale = 3,
                Value = Articulo.Dpunto_max
            };
            return Ppunto_max;
        }

        private static SqlParameter Getpunto_ped(DArticulo Articulo)
        {
            SqlParameter Ppunto_ped = new SqlParameter
            {
                ParameterName = "@punto_ped",
                SqlDbType = SqlDbType.Decimal,
                Precision = 18,
                Scale = 3,
                Value = Articulo.Dpunto_ped
            };
            return Ppunto_ped;
        }

        private static SqlParameter Getpeso(DArticulo Articulo)
        {
            SqlParameter Ppeso = new SqlParameter
            {
                ParameterName = "@peso",
                SqlDbType = SqlDbType.Decimal,
                Precision = 18,
                Scale = 3,
                Value = Articulo.Dpeso
            };
            return Ppeso;
        }

        private static SqlParameter Getvolumen(DArticulo Articulo)
        {
            SqlParameter Pvolumen = new SqlParameter
            {
                ParameterName = "@volumen",
                SqlDbType = SqlDbType.Decimal,
                Precision = 18,
                Scale = 3,
                Value = Articulo.Dvolumen
            };
            return Pvolumen;
        }

        private static SqlParameter Getalto(DArticulo Articulo)
        {
            SqlParameter Palto = new SqlParameter
            {
                ParameterName = "@alto",
                SqlDbType = SqlDbType.Decimal,
                Precision = 18,
                Scale = 3,
                Value = Articulo.Dalto
            };
            return Palto;
        }

        private static SqlParameter Getancho(DArticulo Articulo)
        {
            SqlParameter Pancho = new SqlParameter
            {
                ParameterName = "@ancho",
                SqlDbType = SqlDbType.Decimal,
                Precision = 18,
                Scale = 3,
                Value = Articulo.Dancho
            };
            return Pancho;
        }

        private static SqlParameter Getpuntos(DArticulo Articulo)
        {
            SqlParameter Ppuntos = new SqlParameter
            {
                ParameterName = "@puntos",
                SqlDbType = SqlDbType.Decimal,
                Precision = 18,
                Scale = 3,
                Value = Articulo.Dpuntos
            };
            return Ppuntos;
        }

        private static SqlParameter Getporcentaje(DArticulo Articulo)
        {
            SqlParameter Pporcentaje = new SqlParameter
            {
                ParameterName = "@porcentaje",
                SqlDbType = SqlDbType.Decimal,
                Precision = 18,
                Scale = 3,
                Value = Articulo.Dporcentaje
            };
            return Pporcentaje;
        }

        private static SqlParameter Getfecha_reg(DArticulo Articulo)
        {
            SqlParameter Pfecha_reg = new SqlParameter
            {
                ParameterName = "@fecha_reg",
                SqlDbType = SqlDbType.DateTime,
                Value = Articulo.Dfecha_reg
            };
            return Pfecha_reg;
        }

        private static SqlParameter Getactivo(DArticulo Articulo)
        {
            SqlParameter Pactivo = new SqlParameter
            {
                ParameterName = "@activo",
                SqlDbType = SqlDbType.Bit,
                Value = Articulo.Dactivo
            };
            return Pactivo;
        }

        private static SqlParameter Getesserial(DArticulo Articulo)
        {
            SqlParameter Pesserial = new SqlParameter
            {
                ParameterName = "@esserial",
                SqlDbType = SqlDbType.Bit,
                Value = Articulo.Desserial
            };
            return Pesserial;
        }

        private static SqlParameter Geteslote(DArticulo Articulo)
        {
            SqlParameter Peslote = new SqlParameter
            {
                ParameterName = "@eslote",
                SqlDbType = SqlDbType.Bit,
                Value = Articulo.Deslote
            };
            return Peslote;
        }

        private static SqlParameter Getcampo1(DArticulo Articulo)
        {
            SqlParameter Pcampo1 = new SqlParameter
            {
                ParameterName = "@campo1",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Articulo.Dcampo1,
            };
            return Pcampo1;
        }

        private static SqlParameter Getcampo2(DArticulo Articulo)
        {
            SqlParameter Pcampo2 = new SqlParameter
            {
                ParameterName = "@campo2",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Articulo.Dcampo2,
            };
            return Pcampo2;
        }

        private static SqlParameter Getcampo3(DArticulo Articulo)
        {
            SqlParameter Pcampo3 = new SqlParameter
            {
                ParameterName = "@campo3",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Articulo.Dcampo3,
            };
            return Pcampo3;
        }

        private static SqlParameter Getcampo4(DArticulo Articulo)
        {
            SqlParameter Pcampo4 = new SqlParameter
            {
                ParameterName = "@campo4",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Articulo.Dcampo4,
            };
            return Pcampo4;
        }

        private static SqlParameter Getcampo5(DArticulo Articulo)
        {
            SqlParameter Pcampo5 = new SqlParameter
            {
                ParameterName = "@campo5",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Articulo.Dcampo5,
            };
            return Pcampo5;
        }

        private static SqlParameter Getcampo6(DArticulo Articulo)
        {
            SqlParameter Pcampo6 = new SqlParameter
            {
                ParameterName = "@campo6",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Articulo.Dcampo6,
            };
            return Pcampo6;
        }

        private static SqlParameter Getbuscar(DArticulo Articulo)
        {
            SqlParameter Pbuscar = new SqlParameter
            {
                ParameterName = "@buscar",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Articulo.Dbuscar,
            };
            return Pbuscar;
        }

        private static SqlParameter Getbuscard(DArticulo Articulo)
        {
            SqlParameter Pbuscard = new SqlParameter
            {
                ParameterName = "@buscard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Articulo.Dbuscard,
            };
            return Pbuscard;
        }

        private static SqlParameter Getbuscarh(DArticulo Articulo)
        {
            SqlParameter Pbuscarh = new SqlParameter
            {
                ParameterName = "@buscarh",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Articulo.Dbuscarh,
            };
            return Pbuscarh;
        }

        private static SqlParameter Getbtipo(DArticulo Articulo)
        {
            SqlParameter Pbtipo = new SqlParameter
            {
                ParameterName = "@btipo",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = Articulo.Dbtipo,
            };
            return Pbtipo;
        }

        #endregion

        public DArticulo()
        {
            /// Constructor Vacio
        }


        /// <summary>
        /// Tabla Mostrar No Recibe parametros y Muestra un DataTable
        /// </summary>
        /// <returns> No Recibe Parametros</returns>
        public DataTable Mostrar()
        {
            DataTable DtRpta = new DataTable("TbArticulo");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "articulo_mostrar",
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
                    CommandText = "articulo_listar",
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
        public string Insertar(DArticulo Articulo)
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
                    CommandText = "articulo_insertar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_articulo = Getcod_articulo(Articulo);
                Cmd.Parameters.Add(Parcod_articulo);

                SqlParameter Parcod_categoria = Getcod_categoria(Articulo);
                Cmd.Parameters.Add(Parcod_categoria);

                SqlParameter Parcod_linea = Getcod_linea(Articulo);
                Cmd.Parameters.Add(Parcod_linea);

                SqlParameter Parcod_sublinea = Getcod_sublinea(Articulo);
                Cmd.Parameters.Add(Parcod_sublinea);

                SqlParameter Parcod_color = Getcod_color(Articulo);
                Cmd.Parameters.Add(Parcod_color);

                SqlParameter Parcod_ubicacion = Getcod_ubicacion(Articulo);
                Cmd.Parameters.Add(Parcod_ubicacion);

                SqlParameter Parcod_impuesto = Getcod_impuesto(Articulo);
                Cmd.Parameters.Add(Parcod_impuesto);

                SqlParameter Pardesc_articulo = Getdesc_articulo(Articulo);
                Cmd.Parameters.Add(Pardesc_articulo);

                SqlParameter Partipo = Gettipo(Articulo);
                Cmd.Parameters.Add(Partipo);

                SqlParameter Parorigen = Getorigen(Articulo);
                Cmd.Parameters.Add(Parorigen);

                SqlParameter Paritem = Getitem(Articulo);
                Cmd.Parameters.Add(Paritem);

                SqlParameter Parreferencia = Getreferencia(Articulo);
                Cmd.Parameters.Add(Parreferencia);

                SqlParameter Parmodelo = Getmodelo(Articulo);
                Cmd.Parameters.Add(Parmodelo);

                SqlParameter Pargarantia = Getgarantia(Articulo);
                Cmd.Parameters.Add(Pargarantia);

                SqlParameter Parpunto_min = Getpunto_min(Articulo);
                Cmd.Parameters.Add(Parpunto_min);

                SqlParameter Parpunto_max = Getpunto_max(Articulo);
                Cmd.Parameters.Add(Parpunto_max);

                SqlParameter Parpunto_ped = Getpunto_ped(Articulo);
                Cmd.Parameters.Add(Parpunto_ped);

                SqlParameter Parpeso = Getpeso(Articulo);
                Cmd.Parameters.Add(Parpeso);

                SqlParameter Parvolumen = Getvolumen(Articulo);
                Cmd.Parameters.Add(Parvolumen);

                SqlParameter Paralto = Getalto(Articulo);
                Cmd.Parameters.Add(Paralto);

                SqlParameter Parancho = Getancho(Articulo);
                Cmd.Parameters.Add(Parancho);

                SqlParameter Parpuntos = Getpuntos(Articulo);
                Cmd.Parameters.Add(Parpuntos);

                SqlParameter Parporcentaje = Getporcentaje(Articulo);
                Cmd.Parameters.Add(Parporcentaje);

                SqlParameter Parfecha_reg = Getfecha_reg(Articulo);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Paractivo = Getactivo(Articulo);
                Cmd.Parameters.Add(Paractivo);

                SqlParameter Paresserial = Getesserial(Articulo);
                Cmd.Parameters.Add(Paresserial);

                SqlParameter Pareslote = Geteslote(Articulo);
                Cmd.Parameters.Add(Pareslote);

                SqlParameter Parcampo1 = Getcampo1(Articulo);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Articulo);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Articulo);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Articulo);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Articulo);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Articulo);
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
        public string Editar(DArticulo Articulo)
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
                    CommandText = "articulo_editar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_articulo = Getcod_articulo(Articulo);
                Cmd.Parameters.Add(Parcod_articulo);

                SqlParameter Parcod_articulov = Getcod_articulov(Articulo);
                Cmd.Parameters.Add(Parcod_articulov);

                SqlParameter Parcod_categoria = Getcod_categoria(Articulo);
                Cmd.Parameters.Add(Parcod_categoria);

                SqlParameter Parcod_linea = Getcod_linea(Articulo);
                Cmd.Parameters.Add(Parcod_linea);

                SqlParameter Parcod_sublinea = Getcod_sublinea(Articulo);
                Cmd.Parameters.Add(Parcod_sublinea);

                SqlParameter Parcod_color = Getcod_color(Articulo);
                Cmd.Parameters.Add(Parcod_color);

                SqlParameter Parcod_ubicacion = Getcod_ubicacion(Articulo);
                Cmd.Parameters.Add(Parcod_ubicacion);

                SqlParameter Parcod_impuesto = Getcod_impuesto(Articulo);
                Cmd.Parameters.Add(Parcod_impuesto);

                SqlParameter Pardesc_articulo = Getdesc_articulo(Articulo);
                Cmd.Parameters.Add(Pardesc_articulo);

                SqlParameter Partipo = Gettipo(Articulo);
                Cmd.Parameters.Add(Partipo);

                SqlParameter Parorigen = Getorigen(Articulo);
                Cmd.Parameters.Add(Parorigen);

                SqlParameter Paritem = Getitem(Articulo);
                Cmd.Parameters.Add(Paritem);

                SqlParameter Parreferencia = Getreferencia(Articulo);
                Cmd.Parameters.Add(Parreferencia);

                SqlParameter Parmodelo = Getmodelo(Articulo);
                Cmd.Parameters.Add(Parmodelo);

                SqlParameter Pargarantia = Getgarantia(Articulo);
                Cmd.Parameters.Add(Pargarantia);

                SqlParameter Parpunto_min = Getpunto_min(Articulo);
                Cmd.Parameters.Add(Parpunto_min);

                SqlParameter Parpunto_max = Getpunto_max(Articulo);
                Cmd.Parameters.Add(Parpunto_max);

                SqlParameter Parpunto_ped = Getpunto_ped(Articulo);
                Cmd.Parameters.Add(Parpunto_ped);

                SqlParameter Parpeso = Getpeso(Articulo);
                Cmd.Parameters.Add(Parpeso);

                SqlParameter Parvolumen = Getvolumen(Articulo);
                Cmd.Parameters.Add(Parvolumen);

                SqlParameter Paralto = Getalto(Articulo);
                Cmd.Parameters.Add(Paralto);

                SqlParameter Parancho = Getancho(Articulo);
                Cmd.Parameters.Add(Parancho);

                SqlParameter Parpuntos = Getpuntos(Articulo);
                Cmd.Parameters.Add(Parpuntos);

                SqlParameter Parporcentaje = Getporcentaje(Articulo);
                Cmd.Parameters.Add(Parporcentaje);

                SqlParameter Parfecha_reg = Getfecha_reg(Articulo);
                Cmd.Parameters.Add(Parfecha_reg);

                SqlParameter Paractivo = Getactivo(Articulo);
                Cmd.Parameters.Add(Paractivo);

                SqlParameter Paresserial = Getesserial(Articulo);
                Cmd.Parameters.Add(Paresserial);

                SqlParameter Pareslote = Geteslote(Articulo);
                Cmd.Parameters.Add(Pareslote);

                SqlParameter Parcampo1 = Getcampo1(Articulo);
                Cmd.Parameters.Add(Parcampo1);

                SqlParameter Parcampo2 = Getcampo2(Articulo);
                Cmd.Parameters.Add(Parcampo2);

                SqlParameter Parcampo3 = Getcampo3(Articulo);
                Cmd.Parameters.Add(Parcampo3);

                SqlParameter Parcampo4 = Getcampo4(Articulo);
                Cmd.Parameters.Add(Parcampo4);

                SqlParameter Parcampo5 = Getcampo5(Articulo);
                Cmd.Parameters.Add(Parcampo5);

                SqlParameter Parcampo6 = Getcampo6(Articulo);
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
        public string Eliminar(DArticulo Articulo)
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
                    CommandText = "articulo_eliminar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_articulo = Getcod_articulo(Articulo);
                Cmd.Parameters.Add(Parcod_articulo);

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
        public DataTable Buscar(DArticulo Articulo)
        {
            DataTable DtRpta = new DataTable("TbArticulo");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "articulo_buscar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscar = Getbuscar(Articulo);
                Cmd.Parameters.Add(Parbuscar);

                SqlParameter Parbtipo = Getbtipo(Articulo);
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
        public DataTable RepBuscar(DArticulo Articulo)
        {
            DataTable DtRpta = new DataTable("TbArticulo");
            SqlConnection SqlConn = new SqlConnection();

            try
            {
                SqlConn.ConnectionString = DConexion.Cn;
                SqlConn.Open();

                SqlCommand Cmd = new SqlCommand
                {
                    Connection = SqlConn,
                    CommandText = "articulo_rptlistar",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parbuscard = Getbuscard(Articulo);
                Cmd.Parameters.Add(Parbuscard);

                SqlParameter Parbuscarh = Getbuscarh(Articulo);
                Cmd.Parameters.Add(Parbuscarh);

                SqlParameter Parbtipo = Getbtipo(Articulo);
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
                    CommandText = "articulo_primero",
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
                    CommandText = "articulo_ultimo",
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
        /// <param name="Listar Anterior Articulo"></param>
        public DataSet Anterior(DArticulo Articulo)
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
                    CommandText = "articulo_anterior",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_articulo = Getcod_articulo(Articulo);
                Cmd.Parameters.Add(Parcod_articulo);

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
        /// <param name="Listar Siguiente Articulo"></param>
        public DataSet Siguiente(DArticulo Articulo)
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
                    CommandText = "articulo_siguiente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter Parcod_articulo = Getcod_articulo(Articulo);
                Cmd.Parameters.Add(Parcod_articulo);

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
        public string GenerarCod(DArticulo Articulo)
        {
            SqlConnection SqlConn = new SqlConnection
            {
                ConnectionString = DConexion.Cn
            };

            SqlConn.Open();
            SqlCommand Cmd = new SqlCommand
            {
                Connection = SqlConn,
                CommandText = "articulo_generar_cod",
                CommandType = CommandType.StoredProcedure,
            };

            try
            {
                SqlParameter ParCod_articulo = new SqlParameter("@cod_articulo", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                    Value = Articulo.Dcod_articulo
                };
                Cmd.Parameters.Add(ParCod_articulo);

                if (Cmd.ExecuteNonQuery() == 0)
                {
                    return Cmd.Parameters[ParCod_articulo.ToString()].Value.ToString();
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
            return Cmd.Parameters["@cod_articulo"].Value.ToString();
        }
    }
}
