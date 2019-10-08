using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EMovBanco
    {

        public static string Insertar(string cod_movbanco, string cod_cuenta, string cod_cuentasie, string desc_movbanco, string tipomov, string optipo, string numdoc, string numop, string origen, string estatus, decimal montod, decimal montoh, DateTime fecha_reg, bool saldoinicial, bool anulado, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string cod_usuario)
        {
            DMovBanco Obj = new DMovBanco
            {
                Dcod_movbanco = cod_movbanco,
                Dcod_cuenta = cod_cuenta,
                Dcod_cuentasie = cod_cuentasie,
                Ddesc_movbanco = desc_movbanco,
                Dtipomov = tipomov,
                Doptipo = optipo,
                Dnumdoc = numdoc,
                Dnumop = numop,
                Dorigen = origen,
                Destatus = estatus,
                Dmontod = montod,
                Dmontoh = montoh,
                Dfecha_reg = fecha_reg,
                Dsaldoinicial = saldoinicial,
                Danulado = anulado,
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

        public static string Editar(string cod_movbanco, string cod_movbancov,string cod_cuenta, string cod_cuentasie, string desc_movbanco, string tipomov, string optipo, string numdoc, string numop, string origen, string estatus, decimal montod, decimal montoh, DateTime fecha_reg, bool saldoinicial, bool anulado, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string cod_usuario)
        {
            DMovBanco Obj = new DMovBanco
            {
                Dcod_movbanco = cod_movbanco,
                Dcod_cuenta = cod_cuenta,
                Dcod_cuentasie = cod_cuentasie,
                Ddesc_movbanco = desc_movbanco,
                Dtipomov = tipomov,
                Doptipo = optipo,
                Dnumdoc = numdoc,
                Dnumop = numop,
                Dorigen = origen,
                Destatus = estatus,
                Dmontod = montod,
                Dmontoh = montoh,
                Dfecha_reg = fecha_reg,
                Dsaldoinicial = saldoinicial,
                Danulado = anulado,
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

        public static string Eliminar(string cod_movbanco, string cod_cuenta, string optipo, decimal montod, decimal montoh)
        {
            DMovBanco Obj = new DMovBanco
            {
                Dcod_movbanco = cod_movbanco,
                Dcod_cuenta = cod_cuenta,
                Doptipo = optipo,
                Dmontod = montod,
                Dmontoh = montoh,
            };
            return Obj.Eliminar(Obj);
        }

        public static string Anular(string cod_movbanco, string cod_cuenta, string optipo, string estatus,decimal montod, decimal montoh, bool anulado, string cod_usuario)
        {
            DMovBanco Obj = new DMovBanco
            {
                Dcod_movbanco = cod_movbanco,
                Dcod_cuenta = cod_cuenta,
                Doptipo = optipo,
                Destatus = estatus,
                Dmontod = montod,
                Dmontoh = montoh,
                Danulado = anulado,
                Dcod_usuario = cod_usuario,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DMovBanco().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DMovBanco().Listar();
        }

        public static DataSet Primero()
        {
            return new DMovBanco().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DMovBanco().Ultimo();
        }

        public static DataSet Anterior(string cod_movbanco)
        {
            DMovBanco Obj = new DMovBanco()
            {
                Dcod_movbanco = cod_movbanco
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_movbanco)
        {
            DMovBanco Obj = new DMovBanco()
            {
                Dcod_movbanco = cod_movbanco
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DMovBanco Obj = new DMovBanco()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DMovBanco Obj = new DMovBanco()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_movbanco)
        {
            DMovBanco Obj = new DMovBanco
            {
                Dcod_movbanco = cod_movbanco
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
