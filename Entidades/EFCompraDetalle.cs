using System;
using Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entidades
{
    public class EFCompraDetalle
    {

        public static string Insertar(string cod_fcompra ,string cod_deposito ,string cod_articulo ,string cod_unidad ,string cod_impuesto ,string optipo ,decimal cantidad, decimal equivalencia, decimal montound ,decimal descuento ,decimal descuentop ,decimal subtotalund ,decimal montoimp ,decimal totalund, string estatus, int rorigen)
        {
            DFCompraDetalle Obj = new DFCompraDetalle
            {
                Dcod_fcompra = cod_fcompra,
                Dcod_deposito = cod_deposito,
                Dcod_articulo = cod_articulo,
                Dcod_unidad = cod_unidad,
                Dcod_impuesto = cod_impuesto,
                Doptipo = optipo,
                Dcantidad = cantidad,
                Dequivalencia = equivalencia,
                Dmontound = montound,
                Ddescuento = descuento,
                Ddescuentop = descuentop,
                Dsubtotalund = subtotalund,
                Dmontoimp = montoimp,
                Dtotalund = totalund,
                Destatus = estatus,
                Drorigen = rorigen,
            };
            return Obj.Insertar(Obj);
        }

        public static DataTable Mostrar(string cod_fcompra)
        {
            DFCompraDetalle Obj = new DFCompraDetalle
            {
                Dcod_fcompra = cod_fcompra
            };
            return Obj.Mostrar(Obj);
        }

        public static string Eliminar(int reng)
        {
            DFCompraDetalle Obj = new DFCompraDetalle
            {
                Dreng = reng,
            };
            return Obj.Eliminar(Obj);
        }

        public static string Anular(string cod_fcompra)
        {
            DFCompraDetalle Obj = new DFCompraDetalle
            {
                Dcod_fcompra = cod_fcompra,
            };
            return Obj.Anular(Obj);
        }

        public static string ProcesarDetalle(int reng, string cod_deposito, string cod_articulo, decimal equivalencia)
        {
            DFCompraDetalle Obj = new DFCompraDetalle
            {
                Dreng = reng,
                Dcod_deposito = cod_deposito,
                Dcod_articulo = cod_articulo,
                Dequivalencia = equivalencia
            };
            return Obj.ProcesarDetalle(Obj);
        }
    }
}
