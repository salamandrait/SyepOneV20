using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ESegmento
    {

        public static string Insertar(string cod_segmento, string desc_segmento, string tiposeg, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DSegmento Obj = new DSegmento
            {
                Dcod_segmento = cod_segmento,
                Ddesc_segmento = desc_segmento,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_segmento, string cod_segmentov, string desc_segmento, string tiposeg, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DSegmento Obj = new DSegmento
            {
                Dcod_segmento = cod_segmento,
                Dcod_segmentov = cod_segmentov,
                Ddesc_segmento = desc_segmento,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_segmento)
        {
            DSegmento Obj = new DSegmento
            {
                Dcod_segmento = cod_segmento,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar(string tiposeg)
        {
            DSegmento Obj = new DSegmento
            {
                Dtiposeg = tiposeg,
            };
            return Obj.Mostrar(Obj);
        }

        public static DataSet Listar(string tiposeg)
        {
            DSegmento Obj = new DSegmento
            {
                Dtiposeg = tiposeg,
            };
            return Obj.Listar(Obj);
        }

        public static DataSet Primero(string tiposeg)
        {
            DSegmento Obj = new DSegmento
            {
                Dtiposeg = tiposeg,
            };
            return Obj.Primero(Obj);
        }

        public static DataSet Ultimo(string tiposeg)
        {
            DSegmento Obj = new DSegmento
            {
                Dtiposeg = tiposeg,
            };
            return Obj.Ultimo(Obj);
        }

        public static DataSet Anterior(string cod_segmento, string tiposeg)
        {
            DSegmento Obj = new DSegmento()
            {
                Dcod_segmento = cod_segmento,
                Dtiposeg = tiposeg
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_segmento, string tiposeg)
        {
            DSegmento Obj = new DSegmento()
            {
                Dcod_segmento = cod_segmento,
                Dtiposeg = tiposeg
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo, string tiposeg)
        {
            DSegmento Obj = new DSegmento()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
                Dtiposeg = tiposeg
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo, string tiposeg)
        {
            DSegmento Obj = new DSegmento()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
                Dtiposeg = tiposeg
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_segmento, string tiposeg)
        {
            DSegmento Obj = new DSegmento
            {
                Dcod_segmento = cod_segmento,
                Dtiposeg = tiposeg
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
