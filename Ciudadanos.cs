using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaDeEmpadronamiento
{
    internal class Ciudadanos
    {
        //Instanciamos a la clase conexión
        private ConexionBD Conexion = new ConexionBD(); 
        //Instanciamos al objeto sql command para ejecutar instrucciones
        private SqlCommand Comando = new SqlCommand();
        //Instanciamos Sql Data Reader para leer filas
        private SqlDataReader LeerFilas;

        //Creamos un metodo publico de tipo datatable para listar la tabla 
        public DataTable Listar

    }
}
