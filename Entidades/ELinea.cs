using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ELinea
    {

        public static string Insertar(string cod_linea, string desc_linea, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DLinea Obj = new DLinea
            {
                Dcod_linea = cod_linea,
                Ddesc_linea = desc_linea,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_linea, string cod_lineav, string desc_linea, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DLinea Obj = new DLinea
            {
                Dcod_linea = cod_linea,
                Dcod_lineav = cod_lineav,
                Ddesc_linea = desc_linea,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_linea)
        {
            DLinea Obj = new DLinea
            {
                Dcod_linea = cod_linea,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DLinea().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DLinea().Listar();
        }

        public static DataSet Primero()
        {
            return new DLinea().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DLinea().Ultimo();
        }

        public static DataSet Anterior(string cod_linea)
        {
            DLinea Obj = new DLinea()
            {
                Dcod_linea = cod_linea
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_linea)
        {
            DLinea Obj = new DLinea()
            {
                Dcod_linea = cod_linea
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DLinea Obj = new DLinea()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DLinea Obj = new DLinea()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_linea)
        {
            DLinea Obj = new DLinea
            {
                Dcod_linea = cod_linea
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
