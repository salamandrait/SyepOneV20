using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ECCompra
    {
        public static string Insertar(string cod_ccompra, string cod_proveedor, string cod_condicionpago, string desc_ccompra, string optipo, string numdocumento, string numcontrol, string doc_asociado, string origen, string estatus, bool anulado, decimal monto_base, decimal monto_r, decimal monto_d, decimal monto_o, decimal monto_imp, decimal subtotal, decimal total, DateTime fecha_doc, DateTime fecha_reg, DateTime fecha_ven, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string cod_usuario)
        {
            DCCompra Obj = new DCCompra
            {
                Dcod_ccompra = cod_ccompra,
                Dcod_proveedor = cod_proveedor,
                Dcod_condicionpago = cod_condicionpago,
                Ddesc_ccompra = desc_ccompra,
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

        public static string Editar(string cod_ccompra, string cod_ccomprav, string cod_proveedor, string cod_condicionpago, string desc_ccompra, string optipo, string numdocumento, string numcontrol, string doc_asociado, string origen, string estatus, bool anulado, decimal monto_base, decimal monto_r, decimal monto_d, decimal monto_o, decimal monto_imp, decimal subtotal, decimal total, DateTime fecha_doc, DateTime fecha_reg, DateTime fecha_ven, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string cod_usuario)
        {
            DCCompra Obj = new DCCompra
            {
                Dcod_ccompra = cod_ccompra,
                Dcod_ccomprav = cod_ccomprav,
                Dcod_proveedor = cod_proveedor,
                Dcod_condicionpago = cod_condicionpago,
                Ddesc_ccompra = desc_ccompra,
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

        public static string Anular(string cod_ccompra, string estatus, bool anulado, string cod_usuario)
        {
            DCCompra Obj = new DCCompra
            {
                Dcod_ccompra = cod_ccompra,
                Destatus = estatus,
                Danulado = anulado,
                Dcod_usuario = cod_usuario,
            };
            return Obj.Anular(Obj);
        }

        public static string Procesar(string cod_ccompra, string estatus, string cod_usuario)
        {
            DCCompra Obj = new DCCompra
            {
                Dcod_ccompra = cod_ccompra,
                Destatus = estatus,
                Dcod_usuario = cod_usuario,
            };
            return Obj.Procesar(Obj);
        }

        public static string Eliminar(string cod_ccompra)
        {
            DCCompra Obj = new DCCompra
            {
                Dcod_ccompra = cod_ccompra,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DCCompra().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DCCompra().Listar();
        }

        public static DataSet Primero()
        {
            return new DCCompra().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DCCompra().Ultimo();
        }

        public static DataSet Anterior(string cod_ccompra)
        {
            DCCompra Obj = new DCCompra()
            {
                Dcod_ccompra = cod_ccompra
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_ccompra)
        {
            DCCompra Obj = new DCCompra()
            {
                Dcod_ccompra = cod_ccompra
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DCCompra Obj = new DCCompra()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_ccompra)
        {
            DCCompra Obj = new DCCompra
            {
                Dcod_ccompra = cod_ccompra
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
