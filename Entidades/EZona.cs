using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EZona
    {

        public static string Insertar(string cod_zona, string desc_zona, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DZona Obj = new DZona
            {
                Dcod_zona = cod_zona,
                Ddesc_zona = desc_zona,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_zona, string cod_zonav, string desc_zona, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DZona Obj = new DZona
            {
                Dcod_zona = cod_zona,
                Dcod_zonav = cod_zonav,
                Ddesc_zona = desc_zona,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_zona)
        {
            DZona Obj = new DZona
            {
                Dcod_zona = cod_zona,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DZona().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DZona().Listar();
        }

        public static DataSet Primero()
        {
            return new DZona().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DZona().Ultimo();
        }

        public static DataSet Anterior(string cod_zona)
        {
            DZona Obj = new DZona()
            {
                Dcod_zona = cod_zona
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_zona)
        {
            DZona Obj = new DZona()
            {
                Dcod_zona = cod_zona
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DZona Obj = new DZona()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DZona Obj = new DZona()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_zona)
        {
            DZona Obj = new DZona
            {
                Dcod_zona = cod_zona
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
