using System;
using Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entidades
{
    public class EFCompra
    {
        public static string Insertar(string cod_fcompra, string cod_proveedor, string cod_condicionpago, string desc_fcompra, string optipo, string numdocumento, string numcontrol, string doc_asociado, string origen, string estatus, bool anulado, decimal monto_base, decimal monto_r, decimal monto_d, decimal monto_o, decimal monto_imp, decimal subtotal, decimal total, DateTime fecha_doc, DateTime fecha_reg, DateTime fecha_ven, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string cod_usuario)
        {
            DFCompra Obj = new DFCompra
            {
                Dcod_fcompra = cod_fcompra,
                Dcod_proveedor = cod_proveedor,
                Dcod_condicionpago = cod_condicionpago,
                Ddesc_fcompra = desc_fcompra,
                Doptipo = optipo,
                Dnumdocumento = numdocumento,
                Dnumcontrol = numcontrol,
                Ddoc_asociado = doc_asociado,
                Dorigen = origen,
                Destatus = estatus,
                Danulado = anulado,
                Dmonto_base = monto_base,
                Dmonto_r = monto_r,
                Dmonto_d = monto_d,
                Dmonto_o = monto_o,
                Dmonto_imp = monto_imp,
                Dsubtotal = subtotal,
                Dtotal = total,
                Dfecha_doc = fecha_doc,
                Dfecha_reg = fecha_reg,
                Dfecha_ven = fecha_ven,
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

        public static string Editar(string cod_fcompra, string cod_fcomprav, string cod_proveedor, string cod_condicionpago, string desc_fcompra, string optipo, string numdocumento, string numcontrol, string doc_asociado, string origen, string estatus, bool anulado, decimal monto_base, decimal monto_r, decimal monto_d, decimal monto_o, decimal monto_imp, decimal subtotal, decimal total, DateTime fecha_doc, DateTime fecha_reg, DateTime fecha_ven, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string cod_usuario)
        {
            DFCompra Obj = new DFCompra
            {
                Dcod_fcompra = cod_fcompra,
                Dcod_fcomprav = cod_fcomprav,
                Dcod_proveedor = cod_proveedor,
                Dcod_condicionpago = cod_condicionpago,
                Ddesc_fcompra = desc_fcompra,
                Doptipo = optipo,
                Dnumdocumento = numdocumento,
                Dnumcontrol = numcontrol,
                Ddoc_asociado = doc_asociado,
                Dorigen = origen,
                Destatus = estatus,
                Danulado = anulado,
                Dmonto_base = monto_base,
                Dmonto_r = monto_r,
                Dmonto_d = monto_d,
                Dmonto_o = monto_o,
                Dmonto_imp = monto_imp,
                Dsubtotal = subtotal,
                Dtotal = total,
                Dfecha_doc = fecha_doc,
                Dfecha_reg = fecha_reg,
                Dfecha_ven = fecha_ven,
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

        public static string Anular(string cod_fcompra, string estatus, bool anulado, string cod_usuario)
        {
            DFCompra Obj = new DFCompra
            {
                Dcod_fcompra = cod_fcompra,
                Destatus = estatus,
                Danulado = anulado,
                Dcod_usuario = cod_usuario,
            };
            return Obj.Anular(Obj);
        }

        public static string Procesar(string cod_fcompra, string estatus, string cod_usuario)
        {
            DFCompra Obj = new DFCompra
            {
                Dcod_fcompra = cod_fcompra,
                Destatus = estatus,
                Dcod_usuario = cod_usuario,
            };
            return Obj.Procesar(Obj);
        }

        public static string Eliminar(string cod_fcompra)
        {
            DFCompra Obj = new DFCompra
            {
                Dcod_fcompra = cod_fcompra,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DFCompra().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DFCompra().Listar();
        }

        public static DataSet Primero()
        {
            return new DFCompra().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DFCompra().Ultimo();
        }

        public static DataSet Anterior(string cod_fcompra)
        {
            DFCompra Obj = new DFCompra()
            {
                Dcod_fcompra = cod_fcompra
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_fcompra)
        {
            DFCompra Obj = new DFCompra()
            {
                Dcod_fcompra = cod_fcompra
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DFCompra Obj = new DFCompra()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        //public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        //{
        //    DFCompra Obj = new DFCompra()
        //    {
        //        Dbuscard = buscard,
        //        Dbuscarh = buscarh,
        //        Dbtipo = btipo,
        //    };
        //    return Obj.Buscar(Obj);
        //}

        public static string GenerarCod(string cod_fcompra)
        {
            DFCompra Obj = new DFCompra
            {
                Dcod_fcompra = cod_fcompra
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
