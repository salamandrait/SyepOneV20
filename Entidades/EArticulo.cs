using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EArticulo
    {

        public static string Insertar(string cod_articulo, string cod_categoria, string cod_linea, string cod_sublinea, string cod_color, string cod_ubicacion, string cod_impuesto, string desc_articulo, string tipo, string origen, string item, string referencia, string modelo, string garantia, decimal punto_min, decimal punto_max, decimal punto_ped, decimal peso, decimal volumen, decimal alto, decimal ancho, decimal porcentaje, decimal puntos, DateTime fecha_reg, bool activo, bool esserial, bool eslote, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DArticulo Obj = new DArticulo
            {
                Dcod_articulo = cod_articulo,
                Dcod_categoria = cod_categoria,
                Dcod_linea = cod_linea,
                Dcod_sublinea = cod_sublinea,
                Dcod_color = cod_color,
                Dcod_ubicacion = cod_ubicacion,
                Dcod_impuesto = cod_impuesto,
                Ddesc_articulo = desc_articulo,
                Dtipo = tipo,
                Dorigen = origen,
                Ditem = item,
                Dreferencia = referencia,
                Dmodelo = modelo,
                Dgarantia = garantia,
                Dpunto_min = punto_min,
                Dpunto_max = punto_max,
                Dpunto_ped = punto_ped,
                Dpeso = peso,
                Dvolumen = volumen,
                Dalto = alto,
                Dancho = ancho,
                Dporcentaje = porcentaje,
                Dpuntos = puntos,
                Dfecha_reg = fecha_reg,
                Dactivo = activo,
                Desserial = esserial,
                Deslote = eslote,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_articulo, string cod_articulov, string cod_categoria, string cod_linea, string cod_sublinea, string cod_color, string cod_ubicacion, string cod_impuesto, string desc_articulo, string tipo, string origen, string item, string referencia, string modelo, string garantia, decimal punto_min, decimal punto_max, decimal punto_ped, decimal peso, decimal volumen, decimal alto, decimal ancho, decimal porcentaje, decimal puntos, DateTime fecha_reg, bool activo, bool esserial, bool eslote, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DArticulo Obj = new DArticulo
            {
                Dcod_articulo = cod_articulo,
                Dcod_articulov = cod_articulov,
                Dcod_categoria = cod_categoria,
                Dcod_linea = cod_linea,
                Dcod_sublinea = cod_sublinea,
                Dcod_color = cod_color,
                Dcod_ubicacion = cod_ubicacion,
                Dcod_impuesto = cod_impuesto,
                Ddesc_articulo = desc_articulo,
                Dtipo = tipo,
                Dorigen = origen,
                Ditem = item,
                Dreferencia = referencia,
                Dmodelo = modelo,
                Dgarantia = garantia,
                Dpunto_min = punto_min,
                Dpunto_max = punto_max,
                Dpunto_ped = punto_ped,
                Dpeso = peso,
                Dvolumen = volumen,
                Dalto = alto,
                Dancho = ancho,
                Dporcentaje = porcentaje,
                Dpuntos = puntos,
                Dfecha_reg = fecha_reg,
                Dactivo = activo,
                Desserial = esserial,
                Deslote = eslote,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_articulo)
        {
            DArticulo Obj = new DArticulo
            {
                Dcod_articulo = cod_articulo,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DArticulo().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DArticulo().Listar();
        }

        public static DataSet Primero()
        {
            return new DArticulo().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DArticulo().Ultimo();
        }

        public static DataSet Anterior(string cod_articulo)
        {
            DArticulo Obj = new DArticulo()
            {
                Dcod_articulo = cod_articulo
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_articulo)
        {
            DArticulo Obj = new DArticulo()
            {
                Dcod_articulo = cod_articulo
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DArticulo Obj = new DArticulo()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DArticulo Obj = new DArticulo()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_articulo)
        {
            DArticulo Obj = new DArticulo
            {
                Dcod_articulo = cod_articulo
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
