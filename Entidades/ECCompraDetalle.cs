using System;
using Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entidades
{
    public class ECCompraDetalle
    {

        public static string Insertar(string cod_ccompra ,string cod_deposito ,string cod_articulo ,string cod_unidad ,string cod_impuesto ,string optipo ,decimal cantidad , decimal equivalencia, decimal montound ,decimal descuento ,decimal descuentop ,decimal subtotalund ,decimal montoimp ,decimal totalund, int rorigen)
        {
            DCCompraDetalle Obj = new DCCompraDetalle
            {
                Dcod_ccompra = cod_ccompra,
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

        public static DataTable Mostrar(string cod_ccompra)
        {
            DCCompraDetalle Obj = new DCCompraDetalle
            {
                Dcod_ccompra = cod_ccompra
            };
            return Obj.Mostrar(Obj);
        }

        public static string Eliminar(int reng)
        {
            DCCompraDetalle Obj = new DCCompraDetalle
            {
                Dreng = reng,
            };
            return Obj.Eliminar(Obj);
        }

        public static string Anular(string cod_ccompra)
        {
            DCCompraDetalle Obj = new DCCompraDetalle
            {
                Dcod_ccompra = cod_ccompra
            };
            return Obj.Anular(Obj);
        }

        public static string Importar(int reng)
        {
            DCCompraDetalle Obj = new DCCompraDetalle
            {
                Dreng = reng,
            };
            return Obj.Importar(Obj);
        }

        public static string EliminarImportar(int reng)
        {
            DCCompraDetalle Obj = new DCCompraDetalle
            {
                Dreng = reng,
            };
            return Obj.EliminarImportar(Obj);
        }
    }
}
