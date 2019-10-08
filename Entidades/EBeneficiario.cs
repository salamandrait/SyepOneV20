using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EBeneficiario
    {

        public static string Insertar(string cod_beneficiario, string cod_islr, string desc_beneficiario, string rif, string direccion, string telefono, bool activo, DateTime fecha_reg, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DBeneficiario Obj = new DBeneficiario
            {
                Dcod_beneficiario = cod_beneficiario,
                Dcod_islr = cod_islr,
                Ddesc_beneficiario = desc_beneficiario,
                Drif = rif,
                Ddireccion = direccion,
                Dtelefono = telefono,
                Dactivo = activo,
                Dfecha_reg = fecha_reg,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_beneficiario, string cod_beneficiariov, string cod_islr, string desc_beneficiario, string rif, string direccion, string telefono, bool activo, DateTime fecha_reg, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DBeneficiario Obj = new DBeneficiario
            {
                Dcod_beneficiario = cod_beneficiario,
                Dcod_beneficiariov = cod_beneficiariov,
                Dcod_islr = cod_islr,
                Ddesc_beneficiario = desc_beneficiario,
                Drif = rif,
                Ddireccion = direccion,
                Dtelefono = telefono,
                Dactivo = activo,
                Dfecha_reg = fecha_reg,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_beneficiario)
        {
            DBeneficiario Obj = new DBeneficiario
            {
                Dcod_beneficiario = cod_beneficiario,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DBeneficiario().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DBeneficiario().Listar();
        }

        public static DataSet Primero()
        {
            return new DBeneficiario().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DBeneficiario().Ultimo();
        }

        public static DataSet Anterior(string cod_beneficiario)
        {
            DBeneficiario Obj = new DBeneficiario()
            {
                Dcod_beneficiario = cod_beneficiario
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_beneficiario)
        {
            DBeneficiario Obj = new DBeneficiario()
            {
                Dcod_beneficiario = cod_beneficiario
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DBeneficiario Obj = new DBeneficiario()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DBeneficiario Obj = new DBeneficiario()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_beneficiario)
        {
            DBeneficiario Obj = new DBeneficiario
            {
                Dcod_beneficiario = cod_beneficiario
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
