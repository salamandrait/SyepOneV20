using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EMoneda
    {

        public static string Insertar(string cod_moneda, string desc_moneda, bool monebase,string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DMoneda Obj = new DMoneda
            {
                Dcod_moneda = cod_moneda,
                Ddesc_moneda = desc_moneda,
                Dmonedbase =monebase,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_moneda, string cod_monedav, string desc_moneda, bool monebase,string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DMoneda Obj = new DMoneda
            {
                Dcod_moneda = cod_moneda,
                Dcod_monedav = cod_monedav,
                Ddesc_moneda = desc_moneda,
                Dmonedbase = monebase,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Editar(Obj);
        }

        public static string EditarBase(string cod_moneda)
        {
            DMoneda Obj = new DMoneda
            {
                Dcod_moneda = cod_moneda,
            };
            return Obj.EditarBase(Obj);
        }

        public static string Eliminar(string cod_moneda)
        {
            DMoneda Obj = new DMoneda
            {
                Dcod_moneda = cod_moneda,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DMoneda().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DMoneda().Listar();
        }

        public static DataSet Primero()
        {
            return new DMoneda().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DMoneda().Ultimo();
        }

        public static DataSet Anterior(string cod_moneda)
        {
            DMoneda Obj = new DMoneda()
            {
                Dcod_moneda = cod_moneda
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_moneda)
        {
            DMoneda Obj = new DMoneda()
            {
                Dcod_moneda = cod_moneda
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DMoneda Obj = new DMoneda()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DMoneda Obj = new DMoneda()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_moneda)
        {
            DMoneda Obj = new DMoneda
            {
                Dcod_moneda = cod_moneda
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
