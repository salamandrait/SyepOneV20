using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ECategoria
    {

        public static string Insertar(string cod_categoria, string desc_categoria, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DCategoria Obj = new DCategoria
            {
                Dcod_categoria = cod_categoria,
                Ddesc_categoria = desc_categoria,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_categoria, string cod_categoriav, string desc_categoria, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DCategoria Obj = new DCategoria
            {
                Dcod_categoria = cod_categoria,
                Dcod_categoriav = cod_categoriav,
                Ddesc_categoria = desc_categoria,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_categoria)
        {
            DCategoria Obj = new DCategoria
            {
                Dcod_categoria = cod_categoria,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DCategoria().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DCategoria().Listar();
        }

        public static DataSet Primero()
        {
            return new DCategoria().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DCategoria().Ultimo();
        }

        public static DataSet Anterior(string cod_categoria)
        {
            DCategoria Obj = new DCategoria()
            {
                Dcod_categoria = cod_categoria
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_categoria)
        {
            DCategoria Obj = new DCategoria()
            {
                Dcod_categoria = cod_categoria
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DCategoria Obj = new DCategoria()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DCategoria Obj = new DCategoria()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_categoria)
        {
            DCategoria Obj = new DCategoria
            {
                Dcod_categoria = cod_categoria
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
