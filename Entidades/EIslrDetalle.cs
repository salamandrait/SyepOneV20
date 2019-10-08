using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EIslrDetalle
    {

        public static string Insertar(int reng, string cod_islr, string concepto, string desc_concepto, decimal basep, decimal retencion, decimal sustraendo)
        {
            DIslrDetalle Obj = new DIslrDetalle
            {
                Dreng = reng,
                Dcod_islr = cod_islr,
                Dconcepto = concepto,
                Ddesc_concepto = desc_concepto,
                Dbasep = basep,
                Dretencion = retencion,
                Dsustraendo = sustraendo,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(int reng, int rengv, string cod_islr, string concepto, string desc_concepto, decimal basep, decimal retencion, decimal sustraendo)
        {
            DIslrDetalle Obj = new DIslrDetalle
            {
                Dreng = reng,
                Drengv = rengv,
                Dcod_islr = cod_islr,
                Dconcepto = concepto,
                Ddesc_concepto = desc_concepto,
                Dbasep = basep,
                Dretencion = retencion,
                Dsustraendo = sustraendo,
            };
            return Obj.Editar(Obj);
        }

        public static DataSet Listar(string cod_islr)
        {
            DIslrDetalle Obj = new DIslrDetalle
            {
                Dcod_islr = cod_islr,
            };
            return Obj.Listar(Obj);
        }

        public static DataTable Mostrar(string cod_islr)
        {
            DIslrDetalle Obj = new DIslrDetalle
            {
                Dcod_islr = cod_islr,
            };
            return Obj.Mostrar(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo, string cod_islr)
        {
            DIslrDetalle Obj = new DIslrDetalle()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
                Dcod_islr = cod_islr,
            };
            return Obj.Buscar(Obj);
        }

    }
}
