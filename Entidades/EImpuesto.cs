using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EImpuesto
    {

        public static string Insertar(string cod_impuesto, string desc_impuesto, bool compras, bool ventas, decimal tasaimp, DateTime fecha_reg, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DImpuesto Obj = new DImpuesto
            {
                Dcod_impuesto = cod_impuesto,
                Ddesc_impuesto = desc_impuesto,
                Dcompras = compras,
                Dventas = ventas,
                Dtasaimp = tasaimp,
                Dfecha_reg = fecha_reg,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_impuesto, bool compras, bool ventas, decimal tasaimp, DateTime fecha_reg, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DImpuesto Obj = new DImpuesto
            {
                Dcod_impuesto = cod_impuesto,
                Dcompras = compras,
                Dventas = ventas,
                Dtasaimp = tasaimp,
                Dfecha_reg = fecha_reg,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_impuesto)
        {
            DImpuesto Obj = new DImpuesto
            {
                Dcod_impuesto = cod_impuesto,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DImpuesto().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DImpuesto().Listar();
        }

        public static DataSet ListarTasa(string desc_impuesto)
        {
            DImpuesto Obj = new DImpuesto
            {
                Ddesc_impuesto = desc_impuesto,
            };
            return Obj.ListarTasa(Obj);
        }

        public static DataSet Primero()
        {
            return new DImpuesto().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DImpuesto().Ultimo();
        }

        public static DataSet Anterior(string cod_impuesto)
        {
            DImpuesto Obj = new DImpuesto()
            {
                Dcod_impuesto = cod_impuesto
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_impuesto)
        {
            DImpuesto Obj = new DImpuesto()
            {
                Dcod_impuesto = cod_impuesto
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DImpuesto Obj = new DImpuesto()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DImpuesto Obj = new DImpuesto()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_impuesto)
        {
            DImpuesto Obj = new DImpuesto
            {
                Dcod_impuesto = cod_impuesto
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
