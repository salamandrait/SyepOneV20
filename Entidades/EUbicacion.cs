using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EUbicacion
    {

        public static string Insertar(string cod_ubicacion, string desc_ubicacion, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DUbicacion Obj = new DUbicacion
            {
                Dcod_ubicacion = cod_ubicacion,
                Ddesc_ubicacion = desc_ubicacion,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_ubicacion, string cod_ubicacionv, string desc_ubicacion, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DUbicacion Obj = new DUbicacion
            {
                Dcod_ubicacion = cod_ubicacion,
                Dcod_ubicacionv = cod_ubicacionv,
                Ddesc_ubicacion = desc_ubicacion,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_ubicacion)
        {
            DUbicacion Obj = new DUbicacion
            {
                Dcod_ubicacion = cod_ubicacion,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DUbicacion().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DUbicacion().Listar();
        }

        public static DataSet Primero()
        {
            return new DUbicacion().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DUbicacion().Ultimo();
        }

        public static DataSet Anterior(string cod_ubicacion)
        {
            DUbicacion Obj = new DUbicacion()
            {
                Dcod_ubicacion = cod_ubicacion
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_ubicacion)
        {
            DUbicacion Obj = new DUbicacion()
            {
                Dcod_ubicacion = cod_ubicacion
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DUbicacion Obj = new DUbicacion()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DUbicacion Obj = new DUbicacion()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_ubicacion)
        {
            DUbicacion Obj = new DUbicacion
            {
                Dcod_ubicacion = cod_ubicacion
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
