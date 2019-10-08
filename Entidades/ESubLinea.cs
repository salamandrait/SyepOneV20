using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ESubLinea
    {

        public static string Insertar(string cod_sublinea, string desc_sublinea, string cod_linea,string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DSubLinea Obj = new DSubLinea
            {
                Dcod_sublinea = cod_sublinea,
                Ddesc_sublinea = desc_sublinea,
                Dcod_linea = cod_linea,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_sublinea, string cod_sublineav, string cod_linea,string desc_sublinea, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DSubLinea Obj = new DSubLinea
            {
                Dcod_sublinea = cod_sublinea,
                Dcod_sublineav = cod_sublineav,
                Ddesc_sublinea = desc_sublinea,
                Dcod_linea = cod_linea,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_sublinea)
        {
            DSubLinea Obj = new DSubLinea
            {
                Dcod_sublinea = cod_sublinea,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DSubLinea().Mostrar();
        }

        public static DataTable MostrarOpc(string cod_linea)
        {
            DSubLinea Obj = new DSubLinea
            {
                Dcod_linea = cod_linea,
            };
            return Obj.MostrarOpc(Obj);
        }

        public static DataSet Listar()
        {
            return new DSubLinea().Listar();
        }

        public static DataSet Primero()
        {
            return new DSubLinea().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DSubLinea().Ultimo();
        }

        public static DataSet Anterior(string cod_sublinea)
        {
            DSubLinea Obj = new DSubLinea()
            {
                Dcod_sublinea = cod_sublinea
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_sublinea)
        {
            DSubLinea Obj = new DSubLinea()
            {
                Dcod_sublinea = cod_sublinea
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DSubLinea Obj = new DSubLinea()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DSubLinea Obj = new DSubLinea()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_sublinea)
        {
            DSubLinea Obj = new DSubLinea
            {
                Dcod_sublinea = cod_sublinea
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
