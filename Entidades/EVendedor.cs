using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EVendedor
    {

        public static string Insertar(string cod_vendedor, string desc_vendedor, string rif, string telefono, string direccion, string nivel, decimal comisionventa, decimal comisioncobro, decimal tventas_item, decimal tventas_monto, DateTime fecha_reg, bool cobra, bool venta, bool activo, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DVendedor Obj = new DVendedor
            {
                Dcod_vendedor = cod_vendedor,
                Ddesc_vendedor = desc_vendedor,
                Drif = rif,
                Dtelefono = telefono,
                Ddireccion = direccion,
                Dnivel = nivel,
                Dcomisionventa = comisionventa,
                Dcomisioncobro = comisioncobro,
                Dtventas_item = tventas_item,
                Dtventas_monto = tventas_monto,
                Dfecha_reg = fecha_reg,
                Dcobra = cobra,
                Dventa = venta,
                Dactivo = activo,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_vendedor, string cod_vendedorv, string desc_vendedor, string rif, string telefono, string direccion, string nivel, decimal comisionventa, decimal comisioncobro, decimal tventas_item, decimal tventas_monto, DateTime fecha_reg, bool cobra, bool venta, bool activo, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DVendedor Obj = new DVendedor
            {
                Dcod_vendedor = cod_vendedor,
                Dcod_vendedorv = cod_vendedorv,
                Ddesc_vendedor = desc_vendedor,
                Drif = rif,
                Dtelefono = telefono,
                Ddireccion = direccion,
                Dnivel = nivel,
                Dcomisionventa = comisionventa,
                Dcomisioncobro = comisioncobro,
                Dtventas_item = tventas_item,
                Dtventas_monto = tventas_monto,
                Dfecha_reg = fecha_reg,
                Dcobra = cobra,
                Dventa = venta,
                Dactivo = activo,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_vendedor)
        {
            DVendedor Obj = new DVendedor
            {
                Dcod_vendedor = cod_vendedor,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DVendedor().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DVendedor().Listar();
        }

        public static DataSet Primero()
        {
            return new DVendedor().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DVendedor().Ultimo();
        }

        public static DataSet Anterior(string cod_vendedor)
        {
            DVendedor Obj = new DVendedor()
            {
                Dcod_vendedor = cod_vendedor
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_vendedor)
        {
            DVendedor Obj = new DVendedor()
            {
                Dcod_vendedor = cod_vendedor
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DVendedor Obj = new DVendedor()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DVendedor Obj = new DVendedor()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_vendedor)
        {
            DVendedor Obj = new DVendedor
            {
                Dcod_vendedor = cod_vendedor
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
