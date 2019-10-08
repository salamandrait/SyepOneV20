using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EMovCaja
    {

        public static string Insertar(string cod_movcaja, string cod_caja, string cod_banco, string cod_tarjeta, string cod_cuentasie, string desc_movcaja, string tipomov, string optipo, string forma, string numdoc, string numop, string origen, string estatus, decimal montod, decimal montoh, DateTime fecha_reg, bool saldoinicial, bool anulado, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string cod_usuario)
        {
            DMovCaja Obj = new DMovCaja
            {
                Dcod_movcaja = cod_movcaja,
                Dcod_caja = cod_caja,
                Dcod_banco = cod_banco,
                Dcod_tarjeta = cod_tarjeta,
                Dcod_cuentasie = cod_cuentasie,
                Ddesc_movcaja = desc_movcaja,
                Dtipomov = tipomov,
                Doptipo = optipo,
                Dforma = forma,
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

        public static string Editar(string cod_movcaja, string cod_movcajav, string cod_caja, string cod_banco, string cod_tarjeta, string cod_cuentasie, string desc_movcaja, string tipomov, string optipo, string forma, string numdoc, string numop, string origen, string estatus, decimal montod, decimal montoh, DateTime fecha_reg, bool saldoinicial, bool anulado, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string cod_usuario)
        {
            DMovCaja Obj = new DMovCaja
            {
                Dcod_movcaja = cod_movcaja,
                Dcod_movcajav = cod_movcajav,
                Dcod_caja = cod_caja,
                Dcod_banco = cod_banco,
                Dcod_tarjeta = cod_tarjeta,
                Dcod_cuentasie = cod_cuentasie,
                Ddesc_movcaja = desc_movcaja,
                Dtipomov = tipomov,
                Doptipo = optipo,
                Dforma = forma,
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

        public static string Eliminar(string cod_movcaja, string cod_caja, string optipo, string forma, decimal montod, decimal montoh)
        {
            DMovCaja Obj = new DMovCaja
            {
                Dcod_movcaja = cod_movcaja,
                Dcod_caja = cod_caja,
                Doptipo = optipo,
                Dforma = forma,
                Dmontod = montod,
                Dmontoh = montoh,
            };
            return Obj.Eliminar(Obj);
        }

        public static string Anular(string cod_movcaja, string cod_caja, string optipo, string forma, string estatus, decimal montod, decimal montoh, bool anulado, string cod_usuario)
        {
            DMovCaja Obj = new DMovCaja
            {

                Dcod_movcaja = cod_movcaja,
                Dcod_caja = cod_caja,
                Doptipo = optipo,
                Dforma = forma,
                Destatus = estatus,
                Dmontod = montod,
                Dmontoh = montoh,
                Danulado = anulado,
                Dcod_usuario = cod_usuario,
            };
            return Obj.Anular(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DMovCaja().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DMovCaja().Listar();
        }

        public static DataSet Primero()
        {
            return new DMovCaja().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DMovCaja().Ultimo();
        }

        public static DataSet Anterior(string cod_movcaja)
        {
            DMovCaja Obj = new DMovCaja()
            {
                Dcod_movcaja = cod_movcaja
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_movcaja)
        {
            DMovCaja Obj = new DMovCaja()
            {
                Dcod_movcaja = cod_movcaja
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DMovCaja Obj = new DMovCaja()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DMovCaja Obj = new DMovCaja()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_movcaja)
        {
            DMovCaja Obj = new DMovCaja
            {
                Dcod_movcaja = cod_movcaja
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
