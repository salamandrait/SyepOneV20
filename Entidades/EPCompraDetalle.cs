using System;
using Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entidades
{
    public class EPCompraDetalle
    {

        public static string Insertar(string cod_pcompra ,string cod_deposito ,string cod_articulo ,string cod_unidad ,string cod_impuesto ,string optipo ,decimal cantidad ,decimal equivalencia,decimal montound ,decimal descuento ,decimal descuentop ,decimal subtotalund ,decimal montoimp ,decimal totalund, int rorigen)
        {
            DPCompraDetalle Obj = new DPCompraDetalle
            {
                Dcod_pcompra = cod_pcompra,
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
                Drorigen = rorigen,
            };
            return Obj.Insertar(Obj);
        }

        public static DataTable Mostrar(string cod_pcompra)
        {
            DPCompraDetalle Obj = new DPCompraDetalle
            {
                Dcod_pcompra = cod_pcompra
            };
            return Obj.Mostrar(Obj);
        }

        public static string Eliminar(int reng, string cod_deposito, string cod_articulo, decimal equivalencia)
        {
            DPCompraDetalle Obj = new DPCompraDetalle
            {
                Dreng = reng,
                Dcod_deposito = cod_deposito,
                Dcod_articulo = cod_articulo,
                Dequivalencia = equivalencia,
            };
            return Obj.Eliminar(Obj);
        }

        public static string Importar(int reng, string cod_deposito, string cod_articulo, decimal equivalencia)
        {
            DPCompraDetalle Obj = new DPCompraDetalle
            {
                Dreng = reng,
                Dcod_deposito = cod_deposito,
                Dcod_articulo = cod_articulo,
                Dequivalencia = equivalencia,
            };
            return Obj.Importar(Obj);
        }

        public static string EliminarImportar(int reng, string cod_deposito, string cod_articulo, decimal equivalencia)
        {
            DPCompraDetalle Obj = new DPCompraDetalle
            {
                Dreng = reng,
                Dcod_deposito = cod_deposito,
                Dcod_articulo = cod_articulo,
                Dequivalencia = equivalencia,
            };
            return Obj.EliminarImportar(Obj);
        }

        public static string Anular(string cod_pcompra, string cod_deposito, string cod_articulo, decimal equivalencia)
        {
            DPCompraDetalle Obj = new DPCompraDetalle
            {
                Dcod_pcompra = cod_pcompra,
                Dcod_deposito = cod_deposito,
                Dcod_articulo = cod_articulo,
                Dequivalencia = equivalencia,
            };
            return Obj.Anular(Obj);
        }
    }
}
