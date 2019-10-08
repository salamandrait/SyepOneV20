using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ECuenta
    {

        public static string Insertar(string cod_cuenta, string desc_cuenta, string cod_banco, string cod_moneda, string tipocuenta, string numcuenta, string responsable, string agencia, string ejecutivo, string direccion, string telefono, string email, decimal saldod, decimal saldoh, decimal saldo, DateTime fecha_reg, DateTime fecharegcheq, bool activa, bool chequera, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DCuenta Obj = new DCuenta
            {
                Dcod_cuenta = cod_cuenta,
                Ddesc_cuenta = desc_cuenta,
                Dcod_banco = cod_banco,
                Dcod_moneda = cod_moneda,
                Dtipocuenta = tipocuenta,
                Dnumcuenta = numcuenta,
                Dresponsable = responsable,
                Dagencia = agencia,
                Dejecutivo = ejecutivo,
                Ddireccion = direccion,
                Dtelefono = telefono,
                Demail = email,
                Dsaldod = saldod,
                Dsaldoh = saldoh,
                Dsaldo = saldo,
                Dfecha_reg = fecha_reg,
                Dfecharegcheq = fecharegcheq,
                Dactiva = activa,
                Dchequera = chequera,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_cuenta, string cod_cuentav, string desc_cuenta, string cod_banco, string cod_moneda, string tipocuenta, string numcuenta, string responsable, string agencia, string ejecutivo, string direccion, string telefono, string email, decimal saldod, decimal saldoh, decimal saldo, DateTime fecha_reg, DateTime fecharegcheq, bool activa, bool chequera, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DCuenta Obj = new DCuenta
            {
                Dcod_cuenta = cod_cuenta,
                Dcod_cuentav = cod_cuentav,
                Ddesc_cuenta = desc_cuenta,
                Dcod_banco = cod_banco,
                Dcod_moneda = cod_moneda,
                Dtipocuenta = tipocuenta,
                Dnumcuenta = numcuenta,
                Dresponsable = responsable,
                Dagencia = agencia,
                Dejecutivo = ejecutivo,
                Ddireccion = direccion,
                Dtelefono = telefono,
                Demail = email,
                Dsaldod = saldod,
                Dsaldoh = saldoh,
                Dsaldo = saldo,
                Dfecha_reg = fecha_reg,
                Dfecharegcheq = fecharegcheq,
                Dactiva = activa,
                Dchequera = chequera,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_cuenta)
        {
            DCuenta Obj = new DCuenta
            {
                Dcod_cuenta = cod_cuenta,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DCuenta().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DCuenta().Listar();
        }

        //public static DataSet BuscarCodCuenta(string cod_cuenta)
        //{
        //    DCuenta Obj = new DCuenta
        //    {
        //        Dcod_cuenta = cod_cuenta,
        //    };
        //    return Obj.BuscarCodCuenta(Obj);
        //}

        public static DataSet Primero()
        {
            return new DCuenta().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DCuenta().Ultimo();
        }

        public static DataSet Anterior(string cod_cuenta)
        {
            DCuenta Obj = new DCuenta()
            {
                Dcod_cuenta = cod_cuenta
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_cuenta)
        {
            DCuenta Obj = new DCuenta()
            {
                Dcod_cuenta = cod_cuenta
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DCuenta Obj = new DCuenta()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DCuenta Obj = new DCuenta()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_cuenta)
        {
            DCuenta Obj = new DCuenta
            {
                Dcod_cuenta = cod_cuenta
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
