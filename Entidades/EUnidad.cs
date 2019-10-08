using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EUnidad
    {

        public static string Insertar(string cod_unidad, string desc_unidad, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DUnidad Obj = new DUnidad
            {
                Dcod_unidad = cod_unidad,
                Ddesc_unidad = desc_unidad,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_unidad, string cod_unidadv, string desc_unidad, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DUnidad Obj = new DUnidad
            {
                Dcod_unidad = cod_unidad,
                Dcod_unidadv = cod_unidadv,
                Ddesc_unidad = desc_unidad,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_unidad)
        {
            DUnidad Obj = new DUnidad
            {
                Dcod_unidad = cod_unidad,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DUnidad().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DUnidad().Listar();
        }

        public static DataSet Primero()
        {
            return new DUnidad().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DUnidad().Ultimo();
        }

        public static DataSet Anterior(string cod_unidad)
        {
            DUnidad Obj = new DUnidad()
            {
                Dcod_unidad = cod_unidad
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_unidad)
        {
            DUnidad Obj = new DUnidad()
            {
                Dcod_unidad = cod_unidad
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DUnidad Obj = new DUnidad()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DUnidad Obj = new DUnidad()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_unidad)
        {
            DUnidad Obj = new DUnidad
            {
                Dcod_unidad = cod_unidad
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
