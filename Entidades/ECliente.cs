using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ECliente
    {

        public static string Insertar(string cod_cliente, string desc_cliente, string clasificacion, string rif, string contacto, string direccion, string direccion_alterna, string ciudad, string telefono, string movil, string cod_postal, string web, string email, decimal montofiscal, decimal descuentopp, decimal descuentogb, decimal limite_cred, bool activo, bool nacional, bool fiscal, bool aplica_credito, DateTime fecha_reg, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string cod_vendedor,string cod_tipocliente, string cod_segmento, string cod_condicionpago, string cod_cuentasie, string cod_islr, string cod_pais, string cod_zona)
        {
            DCliente Obj = new DCliente
            {
                Dcod_cliente = cod_cliente,
                Ddesc_cliente = desc_cliente,
                Dclasificacion = clasificacion,
                Drif = rif,
                Dcontacto = contacto,
                Ddireccion = direccion,
                Ddireccion_alterna = direccion_alterna,
                Dciudad = ciudad,
                Dtelefono = telefono,
                Dmovil = movil,
                Dcod_postal = cod_postal,
                Dweb = web,
                Demail = email,
                Dmontofiscal = montofiscal,
                Ddescuentopp = descuentopp,
                Ddescuentogb = descuentogb,
                Dlimite_cred = limite_cred,
                Dactivo = activo,
                Dnacional = nacional,
                Dfiscal = fiscal,
                Daplica_credito = aplica_credito,
                Dfecha_reg = fecha_reg,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
                Dcod_vendedor = cod_vendedor,
                Dcod_tipocliente = cod_tipocliente,
                Dcod_segmento = cod_segmento,
                Dcod_condicionpago = cod_condicionpago,
                Dcod_cuentasie = cod_cuentasie,
                Dcod_islr = cod_islr,
                Dcod_pais = cod_pais,
                Dcod_zona = cod_zona,
            };
            return Obj.Insertar(Obj);
        }

        public static string Editar(string cod_cliente, string cod_clientev, string desc_cliente, string clasificacion, string rif, string contacto, string direccion, string direccion_alterna, string ciudad, string telefono, string movil, string cod_postal, string web, string email, decimal montofiscal, decimal descuentopp, decimal descuentogb, decimal limite_cred, bool activo, bool nacional, bool fiscal, bool aplica_credito, DateTime fecha_reg, string campo1, string campo2, string campo3, string campo4, string campo5, string campo6, string cod_vendedor, string cod_tipocliente, string cod_segmento, string cod_condicionpago, string cod_cuentasie, string cod_islr, string cod_pais, string cod_zona)
        {
            DCliente Obj = new DCliente
            {
                Dcod_cliente = cod_cliente,
                Dcod_clientev = cod_clientev,
                Ddesc_cliente = desc_cliente,
                Dclasificacion = clasificacion,
                Drif = rif,
                Dcontacto = contacto,
                Ddireccion = direccion,
                Ddireccion_alterna = direccion_alterna,
                Dciudad = ciudad,
                Dtelefono = telefono,
                Dmovil = movil,
                Dcod_postal = cod_postal,
                Dweb = web,
                Demail = email,
                Dmontofiscal = montofiscal,
                Ddescuentopp = descuentopp,
                Ddescuentogb = descuentogb,
                Dlimite_cred = limite_cred,
                Dactivo = activo,
                Dnacional = nacional,
                Dfiscal = fiscal,
                Daplica_credito = aplica_credito,
                Dfecha_reg = fecha_reg,
                Dcampo1 = campo1,
                Dcampo2 = campo2,
                Dcampo3 = campo3,
                Dcampo4 = campo4,
                Dcampo5 = campo5,
                Dcampo6 = campo6,
                Dcod_vendedor = cod_vendedor,
                Dcod_tipocliente = cod_tipocliente,
                Dcod_segmento = cod_segmento,
                Dcod_condicionpago = cod_condicionpago,
                Dcod_cuentasie = cod_cuentasie,
                Dcod_islr = cod_islr,
                Dcod_pais = cod_pais,
                Dcod_zona = cod_zona,
            };
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string cod_cliente)
        {
            DCliente Obj = new DCliente
            {
                Dcod_cliente = cod_cliente,
            };
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DCliente().Mostrar();
        }

        public static DataSet Listar()
        {
            return new DCliente().Listar();
        }

        public static DataSet Primero()
        {
            return new DCliente().Primero();
        }

        public static DataSet Ultimo()
        {
            return new DCliente().Ultimo();
        }

        public static DataSet Anterior(string cod_cliente)
        {
            DCliente Obj = new DCliente()
            {
                Dcod_cliente = cod_cliente
            };
            return Obj.Anterior(Obj);
        }

        public static DataSet Siguiente(string cod_cliente)
        {
            DCliente Obj = new DCliente()
            {
                Dcod_cliente = cod_cliente
            };
            return Obj.Siguiente(Obj);
        }

        public static DataTable Buscar(string buscar, string btipo)
        {
            DCliente Obj = new DCliente()
            {
                Dbuscar = buscar,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static DataTable RepBuscar(string buscard, string buscarh, string btipo)
        {
            DCliente Obj = new DCliente()
            {
                Dbuscard = buscard,
                Dbuscarh = buscarh,
                Dbtipo = btipo,
            };
            return Obj.Buscar(Obj);
        }

        public static string GenerarCod(string cod_cliente)
        {
            DCliente Obj = new DCliente
            {
                Dcod_cliente = cod_cliente
            };
            return Obj.GenerarCod(Obj);
        }
    }
}
