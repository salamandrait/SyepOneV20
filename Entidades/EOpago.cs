using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EOPago
    {

        public static string Insertar(string cod_opago, string cod_beneficiario, string cod_cuentasie, string cod_caja, string cod_cuenta, string cod_moneda, string cod_impuesto, string desc_opago, string estatus, string numdocumento, string forma, bool anulado, decimal montobase, decimal montoimp, decimal montototal, DateTime fecha_reg, DateTime fecha_pag, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string cod_usuario)
        {
            DOPago Obj = new DOPago
            {
                Dcod_opago = cod_opago,
                Dcod_beneficiario = cod_beneficiario,
                Dcod_cuentasie = cod_cuentasie,
                Dcod_caja = cod_caja,
                Dcod_cuenta = cod_cuenta,
                Dcod_moneda = cod_moneda,
                Dcod_impuesto = cod_impuesto,
                Ddesc_opago = desc_opago,
                Destatus = estatus,
                Dnumdocumento = numdocumento,
                Dforma = forma,
                Danulado = anulado,
                Dmontobase = montobase,
                Dmontoimp = montoimp,
                Dmontototal = montototal,
                Dfecha_reg = fecha_reg,
                Dfecha_pag = fecha_pag,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
                Dcod_usuario = cod_usuario,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_opago, string cod_opagov,string cod_beneficiario, string cod_cuentasie, string cod_caja, string cod_cuenta, string cod_moneda, string cod_impuesto, string desc_opago, string estatus, string numdocumento, string forma, bool anulado, decimal montobase, decimal montoimp, decimal montototal, DateTime fecha_reg, DateTime fecha_pag, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string cod_usuario)
        {
            DOPago Obj = new DOPago
            {
                Dcod_opago = cod_opago,
                Dcod_opagov = cod_opagov,
                Dcod_beneficiario = cod_beneficiario,
                Dcod_cuentasie = cod_cuentasie,
                Dcod_caja = cod_caja,
                Dcod_cuenta = cod_cuenta,
                Dcod_moneda = cod_moneda,
                Dcod_impuesto = cod_impuesto,
                Ddesc_opago = desc_opago,
                Destatus = estatus,
                Dnumdocumento = numdocumento,
                Dforma = forma,
                Danulado = anulado,
                Dmontobase = montobase,
                Dmontoimp = montoimp,
                Dmontototal = montototal,
                Dfecha_reg = fecha_reg,
                Dfecha_pag = fecha_pag,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
                Dcod_usuario = cod_usuario,
            };
            return Obj.Editar(Obj);
        }

        public static string Procesar(string cod_opago, string estatus, string cod_usuario)
        {
            DOPago Obj = new DOPago
            {
                Dcod_opago = cod_opago,
                Destatus = estatus,
                Dcod_usuario = cod_usuario,
            };
            return Obj.Procesar(Obj);
        }

        public static string Anular(string cod_opago, string estatus, bool anulado, string cod_usuario)
        {
            DOPago Obj = new DOPago
            {
                Dcod_opago = cod_opago,
                Destatus = estatus,
                Danulado = anulado,
                Dcod_usuario = cod_usuario,
            };
            return Obj.Anular(Obj);
        }

        public static string Eliminar(string cod_opago)
        {
            DOPago Obj = new DOPago
            {
                Dcod_opago = cod_opago,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DOPago().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DOPago().Listar();
        }

        public static DataSet Primero()
        {
            return new DOPago().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DOPago().Ultimo();
        }

        public static DataSet Anterior(string cod_opago)
        {
            DOPago Obj = new DOPago()
            {
                Dcod_opago = cod_opago
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_opago)
        {
            DOPago Obj = new DOPago()
            {
                Dcod_opago = cod_opago
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DOPago Obj = new DOPago()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DOPago Obj = new DOPago()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_opago)
        {
            DOPago Obj = new DOPago
            {
                Dcod_opago = cod_opago
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
