using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EBanco
    {

        public static string Insertar(string cod_banco, string desc_banco, string cod_moneda, string telefono, int plazo1, int plazo2, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DBanco Obj = new DBanco
            {
                Dcod_banco = cod_banco,
                Ddesc_banco = desc_banco,
                Dcod_moneda = cod_moneda,
                Dtelefono = telefono,
                Dplazo1 = plazo1,
                Dplazo2 = plazo2,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_banco, string cod_bancov, string desc_banco, string cod_moneda, string telefono, int plazo1, int plazo2, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DBanco Obj = new DBanco
            {
                Dcod_banco = cod_banco,
                Dcod_bancov = cod_bancov,
                Ddesc_banco = desc_banco,
                Dcod_moneda = cod_moneda,
                Dtelefono = telefono,
                Dplazo1 = plazo1,
                Dplazo2 = plazo2,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_banco)
        {
            DBanco Obj = new DBanco
            {
                Dcod_banco = cod_banco,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DBanco().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DBanco().Listar();
        }

        public static DataSet Primero()
        {
            return new DBanco().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DBanco().Ultimo();
        }

        public static DataSet Anterior(string cod_banco)
        {
            DBanco Obj = new DBanco()
            {
                Dcod_banco = cod_banco
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_banco)
        {
            DBanco Obj = new DBanco()
            {
                Dcod_banco = cod_banco
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DBanco Obj = new DBanco()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DBanco Obj = new DBanco()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_banco)
        {
            DBanco Obj = new DBanco
            {
                Dcod_banco = cod_banco
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
