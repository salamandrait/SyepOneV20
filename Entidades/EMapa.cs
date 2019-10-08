using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
    {
        public class EMapa
        {
            public static string Insertar(string cod_mapa, string desc_mapa, bool ainventario, bool acompras, bool aventas, bool abanco, bool aconfig, bool tsioperaciones, bool tsitablas, bool tsireportes, bool tscoperaciones, bool tsctablas, bool tscreportes, bool tsvoperaciones, bool tsvtablas, bool tsvreportes, bool tsboperaciones, bool tsbtablas, bool tsbreportes, bool tscfoperaciones, bool tscftablas, bool tscfreportes)
            {
                DMapa Obj = new DMapa
                {
                    Dcod_mapa = cod_mapa,
                    Ddesc_mapa = desc_mapa,
                    Dainventario = ainventario,
                    Dacompras = acompras,
                    Daventas = aventas,
                    Dabanco = abanco,
                    Daconfig = aconfig,
                    Dtsioperaciones = tsioperaciones,
                    Dtsitablas = tsitablas,
                    Dtsireportes = tsireportes,
                    Dtscoperaciones = tscoperaciones,
                    Dtsctablas = tsctablas,
                    Dtscreportes = tscreportes,
                    Dtsvoperaciones = tsvoperaciones,
                    Dtsvtablas = tsvtablas,
                    Dtsvreportes = tsvreportes,
                    Dtsboperaciones = tsboperaciones,
                    Dtsbtablas = tsbtablas,
                    Dtsbreportes = tsbreportes,
                    Dtscfoperaciones = tscfoperaciones,
                    Dtscftablas = tscftablas,
                    Dtscfreportes = tscfreportes,
                };
                return Obj.Insertar(Obj);
            }

            public static string Editar(string cod_mapa, string desc_mapa, bool ainventario, bool acompras, bool aventas, bool abanco, bool aconfig, bool tsioperaciones, bool tsitablas, bool tsireportes, bool tscoperaciones, bool tsctablas, bool tscreportes, bool tsvoperaciones, bool tsvtablas, bool tsvreportes, bool tsboperaciones, bool tsbtablas, bool tsbreportes, bool tscfoperaciones, bool tscftablas, bool tscfreportes)
            {
                DMapa Obj = new DMapa
                {
                    Dcod_mapa = cod_mapa,
                    Ddesc_mapa = desc_mapa,
                    Dainventario = ainventario,
                    Dacompras = acompras,
                    Daventas = aventas,
                    Dabanco = abanco,
                    Daconfig = aconfig,
                    Dtsioperaciones = tsioperaciones,
                    Dtsitablas = tsitablas,
                    Dtsireportes = tsireportes,
                    Dtscoperaciones = tscoperaciones,
                    Dtsctablas = tsctablas,
                    Dtscreportes = tscreportes,
                    Dtsvoperaciones = tsvoperaciones,
                    Dtsvtablas = tsvtablas,
                    Dtsvreportes = tsvreportes,
                    Dtsboperaciones = tsboperaciones,
                    Dtsbtablas = tsbtablas,
                    Dtsbreportes = tsbreportes,
                    Dtscfoperaciones = tscfoperaciones,
                    Dtscftablas = tscftablas,
                    Dtscfreportes = tscfreportes,
                };
                return Obj.Editar(Obj);
            }

            public static string Eliminar(string cod_mapa)
            {
                DMapa Obj = new DMapa
                {
                    Dcod_mapa = cod_mapa,
                };
                return Obj.Eliminar(Obj);
            }

            public static DataTable Mostrar()
            {
                return new DMapa().Mostrar();
            }

            public static DataSet Listar()
            {
                return new DMapa().Listar();
            }

            public static DataSet Primero()
            {
                return new DMapa().Primero();
            }

            public static DataSet Ultimo()
            {
                return new DMapa().Ultimo();
            }

            public static DataSet Anterior(string cod_mapa)
            {
                DMapa Obj = new DMapa()
                {
                    Dcod_mapa = cod_mapa
                };
                return Obj.Anterior(Obj);
            }

            public static DataSet Siguiente(string cod_mapa)
            {
                DMapa Obj = new DMapa()
                {
                    Dcod_mapa = cod_mapa
                };
                return Obj.Siguiente(Obj);
            }

            public static DataTable Buscar(string buscar, string btipo)
            {
                DMapa Obj = new DMapa()
                {
                    Dbuscar = buscar,
                    Dbtipo = btipo,
                };
                return Obj.Buscar(Obj);
            }

            public static string GenerarCod(string cod_mapa)
            {
                DMapa Obj = new DMapa
                {
                    Dcod_mapa = cod_mapa
                };
                return Obj.GenerarCod(Obj);
            }
        }
    }
    

