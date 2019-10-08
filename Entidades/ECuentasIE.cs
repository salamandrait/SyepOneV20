using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ECuentasIE
    {

        public static string Insertar(string cod_cuentasie, string desc_cuentasie, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DCuentasIE Obj = new DCuentasIE
            {
                Dcod_cuentasie = cod_cuentasie,
                Ddesc_cuentasie = desc_cuentasie,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_cuentasie, string cod_cuentasiev, string desc_cuentasie, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DCuentasIE Obj = new DCuentasIE
            {
                Dcod_cuentasie = cod_cuentasie,
                Dcod_cuentasiev = cod_cuentasiev,
                Ddesc_cuentasie = desc_cuentasie,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_cuentasie)
        {
            DCuentasIE Obj = new DCuentasIE
            {
                Dcod_cuentasie = cod_cuentasie,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DCuentasIE().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DCuentasIE().Listar();
        }

        public static DataSet Primero()
        {
            return new DCuentasIE().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DCuentasIE().Ultimo();
        }

        public static DataSet Anterior(string cod_cuentasie)
        {
            DCuentasIE Obj = new DCuentasIE()
            {
                Dcod_cuentasie = cod_cuentasie
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_cuentasie)
        {
            DCuentasIE Obj = new DCuentasIE()
            {
                Dcod_cuentasie = cod_cuentasie
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DCuentasIE Obj = new DCuentasIE()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DCuentasIE Obj = new DCuentasIE()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_cuentasie)
        {
            DCuentasIE Obj = new DCuentasIE
            {
                Dcod_cuentasie = cod_cuentasie
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
