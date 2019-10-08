using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EArtPrecio
    {

        public static string Insertar(string cod_articulo, string cod_precio, string cod_deposito, decimal monto, DateTime fecha_reg, DateTime fecha_venc, bool venc_precio)
        {
            DArtPrecio Obj = new DArtPrecio
            {
                Dcod_articulo = cod_articulo,
                Dcod_precio = cod_precio,
                Dcod_deposito = cod_deposito,
                Dmonto = monto,
                Dfecha_reg = fecha_reg,
                Dfecha_venc = fecha_venc,
                Dvenc_precio = venc_precio
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_articulo, string cod_articulov, string cod_precio, string cod_preciov, string cod_deposito, string cod_depositov, decimal monto, DateTime fecha_reg, DateTime fecha_venc, bool venc_precio)
        {
            DArtPrecio Obj = new DArtPrecio
            {
                Dcod_articulo = cod_articulo,
                Dcod_articulov = cod_articulov,
                Dcod_precio = cod_precio,
                Dcod_preciov = cod_preciov,
                Dcod_deposito = cod_deposito,
                Dcod_depositov = cod_depositov,
                Dmonto = monto,
                Dfecha_reg = fecha_reg,
                Dfecha_venc = fecha_venc,
                Dvenc_precio = venc_precio
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_articulo, string cod_precio, string cod_deposito)
        {
            DArtPrecio Obj = new DArtPrecio
            {
                Dcod_articulo = cod_articulo,
                Dcod_precio = cod_precio,
                Dcod_deposito = cod_deposito,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar(string cod_articulo)
        {
            DArtPrecio Obj = new DArtPrecio
            {
                Dcod_articulo = cod_articulo,
            };
            return Obj.Mostrar(Obj);
        }

        public static DataTable Mostrar_Precio_Venta(string cod_articulo)
        {
            DArtPrecio Obj = new DArtPrecio
            {
                Dcod_articulo = cod_articulo,
            };
            return Obj.Mostrar_Precio_Venta(Obj);
        }

        public static DataTable Seleccionar_Precio_Venta(string cod_articulo, string cod_deposito)
        {
            DArtPrecio Obj = new DArtPrecio
            {
                Dcod_articulo = cod_articulo,
                Dcod_deposito = cod_deposito,
            };
            return Obj.Seleccionar_Precio_Venta(Obj);
        }

    }
}
