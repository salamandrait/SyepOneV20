using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EUsuario
    {

        public static string Insertar(string cod_usuario, string desc_usuario, string cod_mapa, string clave, string estatus,string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DUsuario Obj = new DUsuario
            {
                Dcod_usuario = cod_usuario,
                Ddesc_usuario = desc_usuario,
                Dcod_mapa = cod_mapa,
                Dclave = clave,
                Destatus = estatus,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_usuario, string cod_usuariov, string desc_usuario, string cod_mapa, string clave, string estatus, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6)
        {
            DUsuario Obj = new DUsuario
            {
                Dcod_usuario = cod_usuario,
                Dcod_usuariov = cod_usuariov,
                Ddesc_usuario = desc_usuario,
                Dcod_mapa = cod_mapa,
                Dclave = clave,
                Destatus = estatus,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_usuario)
        {
            DUsuario Obj = new DUsuario
            {
                Dcod_usuario = cod_usuario,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DUsuario().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DUsuario().Listar();
        }

        public static DataSet Primero()
        {
            return new DUsuario().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DUsuario().Ultimo();
        }

        public static DataSet Anterior(string cod_usuario)
        {
            DUsuario Obj = new DUsuario()
            {
                Dcod_usuario = cod_usuario
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_usuario)
        {
            DUsuario Obj = new DUsuario()
            {
                Dcod_usuario = cod_usuario
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DUsuario Obj = new DUsuario()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DUsuario Obj = new DUsuario()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_usuario)
        {
            DUsuario Obj = new DUsuario
            {
                Dcod_usuario = cod_usuario
            };
            return Obj.GenerarCod(Obj);
        }

        public static DataSet UsiarioAcceso(string cod_usuario)
        {
            DUsuario Obj = new DUsuario
            {
                Dcod_usuario = cod_usuario,
            };
            return Obj.UsuarioAcceso(Obj);
        }

        public static DataSet SelecUsuario(string cod_usuario)
        {
            DUsuario Obj = new DUsuario
            {
                Dcod_usuario = cod_usuario,
            };
            return Obj.SelecUsuario(Obj);
        }

        public static DataTable Login(string cod_usuario, string clave)
        {
            DUsuario Obj = new DUsuario
            {
                Dcod_usuario = cod_usuario,
                Dclave = clave,
            };
            return Obj.Login(Obj);
        }
    }
}
