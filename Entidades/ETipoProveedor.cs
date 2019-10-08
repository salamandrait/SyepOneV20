using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ETipoProveedor
    {

        public static string Insertar(string cod_tipoproveedor, string desc_tipoproveedor, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DTipoProveedor Obj = new DTipoProveedor
            {
                Dcod_tipoproveedor = cod_tipoproveedor,
                Ddesc_tipoproveedor = desc_tipoproveedor,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_tipoproveedor, string cod_tipoproveedorv, string desc_tipoproveedor, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DTipoProveedor Obj = new DTipoProveedor
            {
                Dcod_tipoproveedor = cod_tipoproveedor,
                Dcod_tipoproveedorv = cod_tipoproveedorv,
                Ddesc_tipoproveedor = desc_tipoproveedor,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_tipoproveedor)
        {
            DTipoProveedor Obj = new DTipoProveedor
            {
                Dcod_tipoproveedor = cod_tipoproveedor,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DTipoProveedor().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DTipoProveedor().Listar();
        }

        public static DataSet Primero()
        {
            return new DTipoProveedor().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DTipoProveedor().Ultimo();
        }

        public static DataSet Anterior(string cod_tipoproveedor)
        {
            DTipoProveedor Obj = new DTipoProveedor()
            {
                Dcod_tipoproveedor = cod_tipoproveedor
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_tipoproveedor)
        {
            DTipoProveedor Obj = new DTipoProveedor()
            {
                Dcod_tipoproveedor = cod_tipoproveedor
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DTipoProveedor Obj = new DTipoProveedor()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DTipoProveedor Obj = new DTipoProveedor()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_tipoproveedor)
        {
            DTipoProveedor Obj = new DTipoProveedor
            {
                Dcod_tipoproveedor = cod_tipoproveedor
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
