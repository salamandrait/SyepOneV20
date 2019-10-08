using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EDCompra
    {
        public static string Insertar(string cod_dcompra, string cod_proveedor, string cod_condicionpago, string desc_dcompra, string optipo, string numdocumento, string numcontrol, string numserial,string doc_asociado, string origen, string estatus, bool anulado, decimal monto_base, decimal monto_r, decimal monto_d, decimal monto_o, decimal monto_imp, decimal subtotal, decimal total, DateTime fecha_doc, DateTime fecha_reg, DateTime fecha_ven, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string cod_usuario)
        {
            DDCompra Obj = new DDCompra
            {
                Dcod_dcompra = cod_dcompra,
                Dcod_proveedor = cod_proveedor,
                Dcod_condicionpago = cod_condicionpago,
                Ddesc_dcompra = desc_dcompra,
                Doptipo = optipo,
                Dnumdocumento = numdocumento,
                Dnumcontrol = numcontrol,
                Dnumserial = numserial,
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

        public static string Editar(string cod_dcompra, string cod_dcomprav, string cod_proveedor, string cod_condicionpago, string desc_dcompra, string optipo, string numdocumento, string numcontrol, string numserial,string doc_asociado, string origen, string estatus, bool anulado, decimal monto_base, decimal monto_r, decimal monto_d, decimal monto_o, decimal monto_imp, decimal subtotal, decimal total, DateTime fecha_doc, DateTime fecha_reg, DateTime fecha_ven, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string cod_usuario)
        {
            DDCompra Obj = new DDCompra
            {
                Dcod_dcompra = cod_dcompra,
                Dcod_dcomprav = cod_dcomprav,
                Dcod_proveedor = cod_proveedor,
                Dcod_condicionpago = cod_condicionpago,
                Ddesc_dcompra = desc_dcompra,
                Doptipo = optipo,
                Dnumdocumento = numdocumento,
                Dnumcontrol = numcontrol,
                Dnumserial = numserial,
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

        public static string Anular(string cod_dcompra, string estatus, bool anulado, string cod_usuario)
        {
            DDCompra Obj = new DDCompra
            {
                Dcod_dcompra = cod_dcompra,
                Destatus = estatus,
                Danulado = anulado,
                Dcod_usuario = cod_usuario,
            };
            return Obj.Anular(Obj);
        }

        public static string Procesar(string cod_dcompra, string estatus, string cod_usuario)
        {
            DDCompra Obj = new DDCompra
            {
                Dcod_dcompra = cod_dcompra,
                Destatus = estatus,
                Dcod_usuario = cod_usuario,
            };
            return Obj.Procesar(Obj);
        }

        public static string Eliminar(string cod_dcompra)
        {
            DDCompra Obj = new DDCompra
            {
                Dcod_dcompra = cod_dcompra,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DDCompra().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DDCompra().Listar();
        }

        public static DataSet Primero()
        {
            return new DDCompra().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DDCompra().Ultimo();
        }

        public static DataSet Anterior(string cod_dcompra)
        {
            DDCompra Obj = new DDCompra()
            {
                Dcod_dcompra = cod_dcompra
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_dcompra)
        {
            DDCompra Obj = new DDCompra()
            {
                Dcod_dcompra = cod_dcompra
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DDCompra Obj = new DDCompra()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_dcompra)
        {
            DDCompra Obj = new DDCompra
            {
                Dcod_dcompra = cod_dcompra
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
