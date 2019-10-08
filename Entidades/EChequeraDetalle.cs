using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EChequeraDetalle
    {

        public static string Insertar(int rengchequera, string cod_chequera, string numcheque, string estatus, decimal monto)
        {
            DChequeraDetalle Obj = new DChequeraDetalle
            {
                Drengchequera = rengchequera,
                Dcod_chequera = cod_chequera,
                Dnumcheque = numcheque,
                Destatus = estatus,
                Dmonto = monto,
            };
            return Obj.Insertar(Obj);
        }

        public static DataTable Seleccionar(string cod_chequera, string cod_cuenta)
        {
            DChequeraDetalle Obj = new DChequeraDetalle
            {
                Dcod_chequera = cod_chequera,
                Dcod_cuenta = cod_cuenta,
            };
            return Obj.Seleccionar(Obj);
        }

        public static DataTable Mostrar(string cod_chequera, string cod_cuenta, string estatus)
        {
            DChequeraDetalle Obj = new DChequeraDetalle
            {
                Dcod_chequera = cod_chequera,
                Dcod_cuenta = cod_cuenta,
                Destatus = estatus,
            };
            return Obj.MostrarCh(Obj);
        }

        //public static string Editar(string cod_chequeradetalle, string desc_chequeradetalle, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        //{
        //    DChequeraDetalle Obj = new DChequeraDetalle
        //    {
        //        Dcod_chequeradetalle = cod_chequeradetalle,
        //        Ddesc_chequeradetalle = desc_chequeradetalle,
        //        Dcampo1 = campo1,
        //        Dcampo2 = campo2,
        //        Dcampo3 = campo3,
        //        Dcampo4 = campo4,
        //        Dcampo5 = campo5,
        //        Dcampo6 = campo6,
        //    };
        //    return Obj.Editar(Obj);
        //}

        public static string EstatusChequera(string numcheque, string estatus)
        {
            DChequeraDetalle Obj = new DChequeraDetalle
            {
               Dnumcheque = numcheque,
               Destatus = estatus,
            };
            return Obj.EstatusCheque(Obj);
        }

        //public static DataSet Listar()
        //{
        //    return new DChequeraDetalle().Listar();
        //}

        //public static DataSet Primero()
        //{
        //    return new DChequeraDetalle().Primero();
        //}

        //public static DataSet Ultimo()
        //{
        //    return new DChequeraDetalle().Ultimo();
        //}

        //public static DataSet Anterior(string cod_chequeradetalle)
        //{
        //    DChequeraDetalle Obj = new DChequeraDetalle()
        //    {
        //        Dcod_chequeradetalle = cod_chequeradetalle
        //    };
        //    return Obj.Anterior(Obj);
        //}

        //public static DataSet Siguiente(string cod_chequeradetalle)
        //{
        //    DChequeraDetalle Obj = new DChequeraDetalle()
        //    {
        //        Dcod_chequeradetalle = cod_chequeradetalle
        //    };
        //    return Obj.Siguiente(Obj);
        //}

        //public static DataTable Buscar(string buscar, string btipo)
        //{
        //    DChequeraDetalle Obj = new DChequeraDetalle()
        //    {
        //        Dbuscar = buscar,
        //        Dbtipo = btipo,
        //    };
        //    return Obj.Buscar(Obj);
        //}

        //public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        //{
        //    DChequeraDetalle Obj = new DChequeraDetalle()
        //    {
        //        Dbuscard = buscard,
        //        Dbuscarh = buscarh,
        //        Dbtipo = btipo,
        //    };
        //    return Obj.Buscar(Obj);
        //}

        //public static string GenerarCod(string cod_chequeradetalle)
        //{
        //    DChequeraDetalle Obj = new DChequeraDetalle
        //    {
        //        Dcod_chequeradetalle = cod_chequeradetalle
        //    };
        //    return Obj.GenerarCod(Obj);
        //}
    }
}
