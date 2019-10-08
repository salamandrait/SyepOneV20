using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EColor
    {

        public static string Insertar(string cod_color, string desc_color, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DColor Obj = new DColor
            {
                Dcod_color = cod_color,
                Ddesc_color = desc_color,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_color, string cod_colorv, string desc_color, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DColor Obj = new DColor
            {
                Dcod_color = cod_color,
                Dcod_colorv = cod_colorv,
                Ddesc_color = desc_color,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_color)
        {
            DColor Obj = new DColor
            {
                Dcod_color = cod_color,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DColor().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DColor().Listar();
        }

        public static DataSet Primero()
        {
            return new DColor().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DColor().Ultimo();
        }

        public static DataSet Anterior(string cod_color)
        {
            DColor Obj = new DColor()
            {
                Dcod_color = cod_color
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_color)
        {
            DColor Obj = new DColor()
            {
                Dcod_color = cod_color
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DColor Obj = new DColor()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DColor Obj = new DColor()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_color)
        {
            DColor Obj = new DColor
            {
                Dcod_color = cod_color
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
