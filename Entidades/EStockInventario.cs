using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EStockInventario
    {

        //public static string Insertar(string cod_stockinventario, string desc_stockinventario, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        //{
        //    DStockInventario Obj = new DStockInventario
        //    {
        //        Dcod_stockinventario = cod_stockinventario,
        //        Ddesc_stockinventario = desc_stockinventario,
        //        Dcampo1 = campo1,
        //        Dcampo2 = campo2,
        //        Dcampo3 = campo3,
        //        Dcampo4 = campo4,
        //        Dcampo5 = campo5,
        //        Dcampo6 = campo6,
        //    };
        //    return Obj.Insertar(Obj);
        //}

        //public static string Editar(string cod_stockinventario, string cod_stockinventariov,string desc_stockinventario, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        //{
        //    DStockInventario Obj = new DStockInventario
        //    {
        //        Dcod_stockinventario = cod_stockinventario,
        //        Dcod_stockinventariov = cod_stockinventariov,
        //        Ddesc_stockinventario = desc_stockinventario,
        //        Dcampo1 = campo1,
        //        Dcampo2 = campo2,
        //        Dcampo3 = campo3,
        //        Dcampo4 = campo4,
        //        Dcampo5 = campo5,
        //        Dcampo6 = campo6,
        //    };
        //    return Obj.Editar(Obj);
        //}

        //public static string Eliminar(string cod_stockinventario)
        //{
        //    DStockInventario Obj = new DStockInventario
        //    {
        //        Dcod_stockinventario = cod_stockinventario,
        //    };
        //    return Obj.Eliminar(Obj);
        //}

        public static DataTable Mostrar()
        {
            return new DStockInventario().Mostrar();
        }

        public static DataTable VerificarStock(string cod_articulo, string cod_deposito, string tipostock)
        {
            DStockInventario Obj = new DStockInventario()
            {
                Dcod_articulo=cod_articulo,
                Dcod_deposito=cod_deposito,
                Dtipostock=tipostock,
            };
            return Obj.VerificarStock(Obj);         
        }

        //public static DataSet Listar()
        //{
        //    return new DStockInventario().Listar();
        //}

        //public static DataSet Primero()
        //{
        //    return new DStockInventario().Primero();
        //}

        //public static DataSet Ultimo()
        //{
        //    return new DStockInventario().Ultimo();
        //}

        //public static DataSet Anterior(string cod_stockinventario)
        //{
        //    DStockInventario Obj = new DStockInventario()
        //    {
        //        Dcod_stockinventario = cod_stockinventario
        //    };
        //    return Obj.Anterior(Obj);
        //}

        //public static DataSet Siguiente(string cod_stockinventario)
        //{
        //    DStockInventario Obj = new DStockInventario()
        //    {
        //        Dcod_stockinventario = cod_stockinventario
        //    };
        //    return Obj.Siguiente(Obj);
        //}

        //public static DataTable Buscar(string buscar, string btipo)
        //{
        //    DStockInventario Obj = new DStockInventario()
        //    {
        //        Dbuscar = buscar,
        //        Dbtipo = btipo,
        //    };
        //    return Obj.Buscar(Obj);
        //}

        //public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        //{
        //    DStockInventario Obj = new DStockInventario()
        //    {
        //        Dbuscard = buscard,
        //        Dbuscarh = buscarh,
        //        Dbtipo = btipo,
        //    };
        //    return Obj.Buscar(Obj);
        //}

        //public static string GenerarCod(string cod_stockinventario)
        //{
        //    DStockInventario Obj = new DStockInventario
        //    {
        //        Dcod_stockinventario = cod_stockinventario
        //    };
        //    return Obj.GenerarCod(Obj);
        //}
    }
}
