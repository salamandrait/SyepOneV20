using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EIslr
    {

        public static string Insertar(string cod_islr, string desc_islr, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DIslr Obj = new DIslr
            {
                Dcod_islr = cod_islr,
                Ddesc_islr = desc_islr,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_islr, string cod_islrv, string desc_islr, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DIslr Obj = new DIslr
            {
                Dcod_islr = cod_islr,
                Dcod_islrv = cod_islrv,
                Ddesc_islr = desc_islr,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_islr)
        {
            DIslr Obj = new DIslr
            {
                Dcod_islr = cod_islr,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DIslr().Mostrar();
        }

        public static DataSet MostrarCB(string cod_islr)
        {
            DIslr Obj = new DIslr
            {
                Dcod_islr = cod_islr,
            };
            return Obj.MostrarCB(Obj);
        }

        public static DataSet Listar()
        {
            return new DIslr().Listar();
        }

        public static DataSet Primero()
        {
            return new DIslr().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DIslr().Ultimo();
        }

        public static DataSet Anterior(string cod_islr)
        {
            DIslr Obj = new DIslr()
            {
                Dcod_islr = cod_islr
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_islr)
        {
            DIslr Obj = new DIslr()
            {
                Dcod_islr = cod_islr
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DIslr Obj = new DIslr()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DIslr Obj = new DIslr()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_islr)
        {
            DIslr Obj = new DIslr
            {
                Dcod_islr = cod_islr
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
