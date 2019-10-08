using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EPago
    {

        public static string Insertar(string cod_pago, string cod_proveedor, string desc_pago, bool anulado, string estatus,decimal total,DateTime fecha_reg,string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string cod_usuario)
        {
            DPago Obj = new DPago
            {
                Dcod_pago = cod_pago,
                Dcod_proveedor =cod_proveedor,
                Ddesc_pago = desc_pago,
                Danulado = anulado,
                Destatus=estatus,
                Dtotal=total,
                Dfecha_reg=fecha_reg,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
                Dcod_usuario = cod_usuario
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_pago, string cod_pagov,string cod_proveedor, string desc_pago, bool anulado, string estatus, decimal total, DateTime fecha_reg, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string cod_usuario)
        {
            DPago Obj = new DPago
            {
                Dcod_pago = cod_pago,
                Dcod_pagov = cod_pagov,
                Dcod_proveedor = cod_proveedor,
                Ddesc_pago = desc_pago,
                Danulado = anulado,
                Destatus = estatus,
                Dtotal = total,
                Dfecha_reg = fecha_reg,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
                Dcod_usuario = cod_usuario
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_pago)
        {
            DPago Obj = new DPago
            {
                Dcod_pago = cod_pago,
            };
            return Obj.Eliminar(Obj);
        }

        public static string Anular(string cod_pago, bool anulado, string estatus, string cod_usuario)
        {
            DPago Obj = new DPago
            {
                Dcod_pago = cod_pago,
                Danulado = anulado,
                Destatus = estatus,
                Dcod_usuario = cod_usuario
            };
            return Obj.Anular(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DPago().Mostrar();
        }

        public static DataTable MostrarProv(string cod_proveedor)
        {
            DPago Obj = new DPago()
            {
                Dcod_proveedor = cod_proveedor
            };
            return Obj.MostrarProv(Obj);
        }

        public static DataTable MostrarSaldoTodos()
        {
            return new DPago().MostrarSaldoTodos();
        }

        public static DataSet Listar()
        {
            return new DPago().Listar();
        }

        public static DataSet Primero()
        {
            return new DPago().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DPago().Ultimo();
        }

        public static DataSet Anterior(string cod_pago)
        {
            DPago Obj = new DPago()
            {
                Dcod_pago = cod_pago
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_pago)
        {
            DPago Obj = new DPago()
            {
                Dcod_pago = cod_pago
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DPago Obj = new DPago()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DPago Obj = new DPago()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_pago)
        {
            DPago Obj = new DPago
            {
                Dcod_pago = cod_pago
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
