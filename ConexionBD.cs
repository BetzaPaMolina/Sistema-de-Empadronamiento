using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeEmpadronamiento
{
    
    class ConexionBD
    {
        //
        //Creamos una variable estática de tipo string para la cadena de conexion, en donde especificamos el server, la bd y las credenciales de windows
        static private string CadenaConexion = "Server = IBETH\\SQLEXPRESS ; DataBase = Registro_Empadronamiento ; Integrated Security = true";
        //Lo declaramos como nueva instancia (nuevo objeto)
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);

        //Abrimos la conexion con un metodo de tipo sql
        public SqlConnection AbrirConexion()
        {

            //Si el estado de la conexion está cerrada la abrimos, para no volver a abrir la conexion 
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            //Retornamos la conexion
            return Conexion;
            

        }

        // Creamos otro metodo de tipo sql para cerrar la conexion
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

    }
}
