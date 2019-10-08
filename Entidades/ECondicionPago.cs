using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ECondicionPago
    {

        public static string Insertar(string cod_condicionpago, string desc_condicionpago, decimal diascredito,string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DCondicionPago Obj = new DCondicionPago
            {
                Dcod_condicionpago = cod_condicionpago,
                Ddesc_condicionpago = desc_condicionpago,
                Ddiascredito = diascredito,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_condicionpago, string cod_condicionpagov, string desc_condicionpago, decimal diascredito, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DCondicionPago Obj = new DCondicionPago
            {
                Dcod_condicionpago = cod_condicionpago,
                Dcod_condicionpagov = cod_condicionpagov,
                Ddesc_condicionpago = desc_condicionpago,
                Ddiascredito = diascredito,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_condicionpago)
        {
            DCondicionPago Obj = new DCondicionPago
            {
                Dcod_condicionpago = cod_condicionpago,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DCondicionPago().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DCondicionPago().Listar();
        }

        public static DataSet Primero()
        {
            return new DCondicionPago().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DCondicionPago().Ultimo();
        }

        public static DataSet Anterior(string cod_condicionpago)
        {
            DCondicionPago Obj = new DCondicionPago()
            {
                Dcod_condicionpago = cod_condicionpago
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_condicionpago)
        {
            DCondicionPago Obj = new DCondicionPago()
            {
                Dcod_condicionpago = cod_condicionpago
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DCondicionPago Obj = new DCondicionPago()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DCondicionPago Obj = new DCondicionPago()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_condicionpago)
        {
            DCondicionPago Obj = new DCondicionPago
            {
                Dcod_condicionpago = cod_condicionpago
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
