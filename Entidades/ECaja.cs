using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ECaja
    {

        public static string Insertar(string cod_caja, string desc_caja, string cod_moneda, string responsable, decimal saldoefectivo, decimal saldodocumento, decimal saldototal, DateTime fecha_reg, bool activa, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DCaja Obj = new DCaja
            {
                Dcod_caja = cod_caja,
                Ddesc_caja = desc_caja,
                Dcod_moneda = cod_moneda,
                Dresponsable = responsable,
                Dsaldoefectivo = saldoefectivo,
                Dsaldodocumento = saldodocumento,
                Dsaldototal = saldototal,
                Dfecha_reg = fecha_reg,
                Dactiva = activa,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_caja, string cod_cajav, string desc_caja, string cod_moneda, string responsable, decimal saldoefectivo, decimal saldodocumento, decimal saldototal, DateTime fecha_reg, bool activa, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DCaja Obj = new DCaja
            {
                Dcod_caja = cod_caja,
                Dcod_cajav = cod_cajav,
                Ddesc_caja = desc_caja,
                Dcod_moneda = cod_moneda,
                Dresponsable = responsable,
                Dsaldoefectivo = saldoefectivo,
                Dsaldodocumento = saldodocumento,
                Dsaldototal = saldototal,
                Dfecha_reg = fecha_reg,
                Dactiva = activa,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_caja)
        {
            DCaja Obj = new DCaja
            {
                Dcod_caja = cod_caja,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DCaja().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DCaja().Listar();
        }

        public static DataSet Primero()
        {
            return new DCaja().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DCaja().Ultimo();
        }

        public static DataSet Anterior(string cod_caja)
        {
            DCaja Obj = new DCaja()
            {
                Dcod_caja = cod_caja
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_caja)
        {
            DCaja Obj = new DCaja()
            {
                Dcod_caja = cod_caja
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DCaja Obj = new DCaja()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DCaja Obj = new DCaja()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_caja)
        {
            DCaja Obj = new DCaja
            {
                Dcod_caja = cod_caja
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
