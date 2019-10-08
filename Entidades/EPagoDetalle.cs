using System;
using Datos;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EPagoDetalle
    {
        public static string Insertar(string cod_pago, string cod_compra, string numdocpago, string optipo, string forma, decimal monto, bool esretenislr, bool esreteniva, DateTime fecha_reg, string cod_movbanco, string cod_movcaja)
        {
            DPagoDetalle Obj = new DPagoDetalle
            {
                Dcod_pago = cod_pago,
                Dcod_compra = cod_compra,
                Dnumdocpago = numdocpago,
                Doptipo = optipo,
                Dforma = forma,
                Dmonto = monto,
                Desretenislr = esretenislr,
                Desreteniva = esreteniva,
                Dfecha_reg = fecha_reg,
                Dcod_movbanco = cod_movbanco,
                Dcod_movcaja = cod_movcaja,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(int reng, string cod_pago, string cod_compra, string numdocpago, string optipo, string forma, decimal monto, bool esretenislr, bool esreteniva, DateTime fecha_reg, string cod_movbanco, string cod_movcaja)
        {
            DPagoDetalle Obj = new DPagoDetalle
            {
                Dreng = reng,
                Dcod_pago = cod_pago,
                Dcod_compra = cod_compra,
                Dnumdocpago = numdocpago,
                Doptipo = optipo,
                Dforma = forma,
                Dmonto = monto,
                Desretenislr = esretenislr,
                Desreteniva = esreteniva,
                Dfecha_reg = fecha_reg,
                Dcod_movbanco = cod_movbanco,
                Dcod_movcaja = cod_movcaja,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_pago, string cod_compra, string optipo, decimal monto)
        {
            DPagoDetalle Obj = new DPagoDetalle()
            {
                Dcod_pago = cod_pago,
                Dcod_compra = cod_compra,
                Doptipo = optipo,
                Dmonto = monto,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar(string cod_pago)
        {
            DPagoDetalle Obj = new DPagoDetalle()
            {
                Dcod_pago = cod_pago,
            };
            return Obj.Mostrar(Obj);
        }

        public static DataTable MostrarP(string cod_pago)
        {
            DPagoDetalle Obj = new DPagoDetalle()
            {
                Dcod_pago = cod_pago,
            };
            return Obj.MostrarP(Obj);
        }

    }
}
