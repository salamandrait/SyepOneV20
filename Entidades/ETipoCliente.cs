using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ETipoCliente
    {

        public static string Insertar(string cod_tipocliente, string desc_tipocliente, string cod_precio,string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DTipoCliente Obj = new DTipoCliente
            {
                Dcod_tipocliente = cod_tipocliente,
                Ddesc_tipocliente = desc_tipocliente,
                Dcod_precio = cod_precio,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_tipocliente, string cod_tipoclientev, string desc_tipocliente, string cod_precio,string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DTipoCliente Obj = new DTipoCliente
            {
                Dcod_tipocliente = cod_tipocliente,
                Dcod_tipoclientev = cod_tipoclientev,
                Ddesc_tipocliente = desc_tipocliente,
                Dcod_precio = cod_precio,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_tipocliente)
        {
            DTipoCliente Obj = new DTipoCliente
            {
                Dcod_tipocliente = cod_tipocliente,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DTipoCliente().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DTipoCliente().Listar();
        }

        public static DataSet Primero()
        {
            return new DTipoCliente().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DTipoCliente().Ultimo();
        }

        public static DataSet Anterior(string cod_tipocliente)
        {
            DTipoCliente Obj = new DTipoCliente()
            {
                Dcod_tipocliente = cod_tipocliente
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_tipocliente)
        {
            DTipoCliente Obj = new DTipoCliente()
            {
                Dcod_tipocliente = cod_tipocliente
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DTipoCliente Obj = new DTipoCliente()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DTipoCliente Obj = new DTipoCliente()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_tipocliente)
        {
            DTipoCliente Obj = new DTipoCliente
            {
                Dcod_tipocliente = cod_tipocliente
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
