using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EPais
    {

        public static string Insertar(string cod_pais, string desc_pais, string cod_moneda,string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DPais Obj = new DPais
            {
                Dcod_pais = cod_pais,
                Ddesc_pais = desc_pais,
                Dcod_moneda = cod_moneda,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_pais, string cod_paisv, string desc_pais, string cod_moneda,string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DPais Obj = new DPais
            {
                Dcod_pais = cod_pais,
                Dcod_paisv = cod_paisv,
                Ddesc_pais = desc_pais,
                Dcod_moneda = cod_moneda,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_pais)
        {
            DPais Obj = new DPais
            {
                Dcod_pais = cod_pais,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DPais().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DPais().Listar();
        }

        public static DataSet Primero()
        {
            return new DPais().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DPais().Ultimo();
        }

        public static DataSet Anterior(string cod_pais)
        {
            DPais Obj = new DPais()
            {
                Dcod_pais = cod_pais
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_pais)
        {
            DPais Obj = new DPais()
            {
                Dcod_pais = cod_pais
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DPais Obj = new DPais()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DPais Obj = new DPais()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_pais)
        {
            DPais Obj = new DPais
            {
                Dcod_pais = cod_pais
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
