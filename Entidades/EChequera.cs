using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EChequera
    {

        public static string Insertar(string cod_chequera, string desc_chequera, string cod_cuenta,decimal cantidad, string estatus, DateTime fecha_reg,string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DChequera Obj = new DChequera
            {
                Dcod_chequera = cod_chequera,
                Ddesc_chequera = desc_chequera,
                Dcod_cuenta =cod_cuenta,
                Dcantidad = cantidad,
                Destatus = estatus,
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

        public static string Editar(string cod_chequera, string cod_chequerav, string desc_chequera,string cod_cuenta, decimal cantidad, string estatus, DateTime fecha_reg, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DChequera Obj = new DChequera
            {
                Dcod_chequera = cod_chequera,
                Dcod_chequerav = cod_chequerav,
                Ddesc_chequera = desc_chequera,
                Dcod_cuenta = cod_cuenta,
                Dcantidad = cantidad,
                Destatus = estatus,
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

        public static string Eliminar(string cod_chequera)
        {
            DChequera Obj = new DChequera
            {
                Dcod_chequera = cod_chequera,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DChequera().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DChequera().Listar();
        }

        public static DataSet Primero()
        {
            return new DChequera().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DChequera().Ultimo();
        }

        public static DataSet Anterior(string cod_chequera)
        {
            DChequera Obj = new DChequera()
            {
                Dcod_chequera = cod_chequera
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_chequera)
        {
            DChequera Obj = new DChequera()
            {
                Dcod_chequera = cod_chequera
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DChequera Obj = new DChequera()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DChequera Obj = new DChequera()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_chequera)
        {
            DChequera Obj = new DChequera
            {
                Dcod_chequera = cod_chequera
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
