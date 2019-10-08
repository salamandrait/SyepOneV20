using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EEmpresa
    {

        public static string Insertar(string cod_empresa, string cod_moneda, string cod_pais, string cod_islr, string desc_empresa, string rif, string replegal, string direccion, string telefono, string movil, string codigo_postal, string web, string email, bool fiscal, decimal montofiscal, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, byte[] logo1, byte[] logo2, byte[] logo3)
        {
            DEmpresa Obj = new DEmpresa
            {
                Dcod_empresa = cod_empresa,
                Dcod_moneda = cod_moneda,
                Dcod_pais = cod_pais,
                Dcod_islr = cod_islr,
                Ddesc_empresa = desc_empresa,
                Drif = rif,
                Dreplegal = replegal,
                Ddireccion = direccion,
                Dtelefono = telefono,
                Dmovil = movil,
                Dcodigo_postal = codigo_postal,
                Dweb = web,
                Demail = email,
                Dfiscal = fiscal,
                Dmontofiscal = montofiscal,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
                Dlogo1 = logo1,
                Dlogo2 = logo2,
                Dlogo3 = logo3,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_empresa, string cod_empresav,string cod_moneda,string cod_pais, string cod_islr, string desc_empresa, string rif, string replegal, string direccion, string telefono, string movil, string codigo_postal, string web, string email, bool fiscal, decimal montofiscal, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, byte[] logo1, byte[] logo2, byte[] logo3)
        {
            DEmpresa Obj = new DEmpresa
            {
                Dcod_empresa = cod_empresa,
                Dcod_empresav = cod_empresav,
                Dcod_moneda = cod_moneda,
                Dcod_pais = cod_pais,
                Dcod_islr = cod_islr,
                Ddesc_empresa = desc_empresa,
                Drif = rif,
                Dreplegal = replegal,
                Ddireccion = direccion,
                Dtelefono = telefono,
                Dmovil = movil,
                Dcodigo_postal = codigo_postal,
                Dweb = web,
                Demail = email,
                Dfiscal = fiscal,
                Dmontofiscal = montofiscal,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
                Dlogo1 = logo1,
                Dlogo2 = logo2,
                Dlogo3 = logo3,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_empresa)
        {
            DEmpresa Obj = new DEmpresa
            {
                Dcod_empresa = cod_empresa,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DEmpresa().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DEmpresa().Listar();
        }

        public static DataSet Primero()
        {
            return new DEmpresa().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DEmpresa().Ultimo();
        }

        public static DataSet Anterior(string cod_empresa)
        {
            DEmpresa Obj = new DEmpresa()
            {
                Dcod_empresa = cod_empresa
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_empresa)
        {
            DEmpresa Obj = new DEmpresa()
            {
                Dcod_empresa = cod_empresa
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DEmpresa Obj = new DEmpresa()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DEmpresa Obj = new DEmpresa()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_empresa)
        {
            DEmpresa Obj = new DEmpresa
            {
                Dcod_empresa = cod_empresa
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
