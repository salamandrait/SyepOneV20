using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EDeposito
    {

        public static string Insertar(string cod_deposito, string desc_deposito, string resp_deposito, string ubicacion, DateTime fecha_reg, string direccion_adm, bool scompras, bool sventas, bool activo, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DDeposito Obj = new DDeposito
            {
                Dcod_deposito = cod_deposito,
                Ddesc_deposito = desc_deposito,
                Dresp_deposito = resp_deposito,
                Dubicacion = ubicacion,
                Dfecha_reg = fecha_reg,
                Ddireccion_adm = direccion_adm,
                Dscompras = scompras,
                Dsventas = sventas,
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

        public static string Editar(string cod_deposito, string cod_depositov, string desc_deposito, string resp_deposito, string ubicacion, DateTime fecha_reg, string direccion_adm, bool scompras, bool sventas, bool activo, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DDeposito Obj = new DDeposito
            {
                Dcod_deposito = cod_deposito,
                Dcod_depositov = cod_depositov,
                Ddesc_deposito = desc_deposito,
                Dresp_deposito = resp_deposito,
                Dubicacion = ubicacion,
                Dfecha_reg = fecha_reg,
                Ddireccion_adm = direccion_adm,
                Dscompras = scompras,
                Dsventas = sventas,
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

        public static string Eliminar(string cod_deposito)
        {
            DDeposito Obj = new DDeposito
            {
                Dcod_deposito = cod_deposito,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DDeposito().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DDeposito().Listar();
        }

        public static DataSet ListarOp(string desc_deposito)
        {
            DDeposito Obj = new DDeposito()
            {
                Ddesc_deposito = desc_deposito
            };
            return Obj.ListarOp(Obj);
        }

        public static DataSet Primero()
        {
            return new DDeposito().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DDeposito().Ultimo();
        }

        public static DataSet Anterior(string cod_deposito)
        {
            DDeposito Obj = new DDeposito()
            {
                Dcod_deposito = cod_deposito
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_deposito)
        {
            DDeposito Obj = new DDeposito()
            {
                Dcod_deposito = cod_deposito
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DDeposito Obj = new DDeposito()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DDeposito Obj = new DDeposito()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_deposito)
        {
            DDeposito Obj = new DDeposito
            {
                Dcod_deposito = cod_deposito
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
