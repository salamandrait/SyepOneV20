using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ETarjeta
    {

        public static string Insertar(string cod_tarjeta, string desc_tarjeta, decimal comision, decimal recargo, decimal impuesto, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DTarjeta Obj = new DTarjeta
            {
                Dcod_tarjeta = cod_tarjeta,
                Ddesc_tarjeta = desc_tarjeta,
                Dcomision = comision,
                Drecargo = recargo,
                Dimpuesto = impuesto,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_tarjeta, string cod_tarjetav,string desc_tarjeta, decimal comision, decimal recargo, decimal impuesto, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DTarjeta Obj = new DTarjeta
            {
                Dcod_tarjeta = cod_tarjeta,
                Dcod_tarjetav = cod_tarjetav,
                Ddesc_tarjeta = desc_tarjeta,
                Dcomision = comision,
                Drecargo = recargo,
                Dimpuesto = impuesto,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_tarjeta)
        {
            DTarjeta Obj = new DTarjeta
            {
                Dcod_tarjeta = cod_tarjeta,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DTarjeta().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DTarjeta().Listar();
        }

        public static DataSet Primero()
        {
            return new DTarjeta().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DTarjeta().Ultimo();
        }

        public static DataSet Anterior(string cod_tarjeta)
        {
            DTarjeta Obj = new DTarjeta()
            {
                Dcod_tarjeta = cod_tarjeta
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_tarjeta)
        {
            DTarjeta Obj = new DTarjeta()
            {
                Dcod_tarjeta = cod_tarjeta
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DTarjeta Obj = new DTarjeta()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DTarjeta Obj = new DTarjeta()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_tarjeta)
        {
            DTarjeta Obj = new DTarjeta
            {
                Dcod_tarjeta = cod_tarjeta
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
