using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EPrecio
    {

        public static string Insertar(string cod_precio, string desc_precio, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DPrecio Obj = new DPrecio
            {
                Dcod_precio = cod_precio,
                Ddesc_precio = desc_precio,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_precio, string cod_preciov, string desc_precio, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DPrecio Obj = new DPrecio
            {
                Dcod_precio = cod_precio,
                Dcod_preciov = cod_preciov,
                Ddesc_precio = desc_precio,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_precio)
        {
            DPrecio Obj = new DPrecio
            {
                Dcod_precio = cod_precio,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DPrecio().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DPrecio().Listar();
        }

        public static DataSet Primero()
        {
            return new DPrecio().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DPrecio().Ultimo();
        }

        public static DataSet Anterior(string cod_precio)
        {
            DPrecio Obj = new DPrecio()
            {
                Dcod_precio = cod_precio
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_precio)
        {
            DPrecio Obj = new DPrecio()
            {
                Dcod_precio = cod_precio
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DPrecio Obj = new DPrecio()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DPrecio Obj = new DPrecio()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_precio)
        {
            DPrecio Obj = new DPrecio
            {
                Dcod_precio = cod_precio
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
