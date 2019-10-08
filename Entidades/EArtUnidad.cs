using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EArtUnidad
    {
        public static string Insertar(string cod_articulo, string cod_unidad, decimal equivalencia, bool esprincipal, DateTime fecha_reg)
        {
            DArtUnidad Obj = new DArtUnidad
            {
                Dcod_articulo = cod_articulo,
                Dcod_unidad = cod_unidad,
                Dequivalencia = equivalencia,
                Desprincipal = esprincipal,
                Dfecha_reg = fecha_reg,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_articulo, string cod_articulov, string cod_unidad, string cod_unidadv,decimal equivalencia, bool esprincipal, DateTime fecha_reg)
        {
            DArtUnidad Obj = new DArtUnidad
            {
                Dcod_articulo = cod_articulo,
                Dcod_articulov = cod_articulov,
                Dcod_unidad = cod_unidad,
                Dcod_unidadv = cod_unidadv,
                Dequivalencia = equivalencia,
                Desprincipal = esprincipal,
                Dfecha_reg = fecha_reg,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_articulo, string cod_unidad)
        {
            DArtUnidad Obj = new DArtUnidad
            {
                Dcod_articulo = cod_articulo,
                Dcod_unidad = cod_unidad,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar(string cod_articulo)
        {
            DArtUnidad Obj = new DArtUnidad
            {
                Dcod_articulo = cod_articulo,
            };
            return Obj.Mostrar(Obj);
        }

        public static DataTable Listar()
        {
            return new DArtUnidad().Listar();
        }

        public static DataSet SeleccionarUnidad(string cod_articulo, string desc_unidad)
        {
            DArtUnidad Obj = new DArtUnidad
            {
                Dcod_articulo = cod_articulo,
                Ddesc_unidad = desc_unidad,
            };
            return Obj.SeleccionarUnidad(Obj);
        }



    }
}
