using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ECorrelativos
    {

        public static string Insertar(string cod_correlativos, string desc_correlativos, string tabla, string precadena, string cadena, int cod_num, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DCorrelativos Obj = new DCorrelativos
            {
                Dcod_correlativos = cod_correlativos,
                Ddesc_correlativos = desc_correlativos,
                Dtabla = tabla,
                Dcadena = cadena,
                Dprecadena = precadena,
                Dcod_num = cod_num,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_correlativos, string cod_correlativosv, string desc_correlativos, string tabla, string precadena, string cadena, int cod_num, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DCorrelativos Obj = new DCorrelativos
            {
                Dcod_correlativos = cod_correlativos,
                Dcod_correlativosv = cod_correlativosv,
                Ddesc_correlativos = desc_correlativos,
                Dtabla = tabla,
                Dcadena = cadena,
                Dprecadena = precadena,
                Dcod_num = cod_num,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_correlativos)
        {
            DCorrelativos Obj = new DCorrelativos
            {
                Dcod_correlativos = cod_correlativos,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DCorrelativos().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DCorrelativos().Listar();
        }

        public static DataSet Primero()
        {
            return new DCorrelativos().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DCorrelativos().Ultimo();
        }

        public static DataSet Anterior(string desc_correlativos)
        {
            DCorrelativos Obj = new DCorrelativos()
            {
                Ddesc_correlativos = desc_correlativos
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string desc_correlativos)
        {
            DCorrelativos Obj = new DCorrelativos()
            {
                Ddesc_correlativos = desc_correlativos
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DCorrelativos Obj = new DCorrelativos()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DCorrelativos Obj = new DCorrelativos()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_correlativos)
        {
            DCorrelativos Obj = new DCorrelativos
            {
                Dcod_correlativos = cod_correlativos
            };
            return Obj.GenerarCod(Obj);
        }

        public static string GenerarCodMuestra(string cod_correlativos, string tabla)
        {
            DCorrelativos Obj = new DCorrelativos
            {
                Dcod_correlativos = cod_correlativos,
                Dtabla = tabla,
            };
            return Obj.GenerarCod_Muestra(Obj);
        }

        public static DataSet GetCorrelativo(string tabla)
        {
            DCorrelativos Obj = new DCorrelativos
            {
                Dtabla = tabla,
            };
            return Obj.Top_Serie(Obj);
        }

        public static DataSet Muestra(string tabla)
        {
            DCorrelativos Obj = new DCorrelativos
            {
                Dtabla = tabla,
            };
            return Obj.Muestra(Obj);
        }
    }
}
