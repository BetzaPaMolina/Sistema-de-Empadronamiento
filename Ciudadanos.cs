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

        //Creamos un metodo publico de tipo datatable para listar la tabla deptos
        public DataTable ListarDepartamentos()
        {
            //instanciamos al objeto datatable para almacenar los datos
            DataTable Tabla = new DataTable();
            //Abrimos la conexion
            Comando.Connection = Conexion.AbrirConexion();
            //Establecemos la sentencia sql
            Comando.CommandText = "Select * From Departamentos";

            //Leemos las filas
            LeerFilas = Comando.ExecuteReader();
            //Cargamos filas
            Tabla.Load(LeerFilas);
            //Cerramos la conexion
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        //Creamos un metodo publico de tipo datatable para listar la tabla municipios
        public DataTable ListarMunicipios(string departamento)//!!SE AÑADIO STRING DEPTO
        {
            //!! Obtenemos el valor correcto del departamento seleccionado
            string departamentoID = departamento;

            //instanciamos al objeto datatable para almacenar los datos
            DataTable Tabla = new DataTable();
            //Abrimos la conexion
            Comando.Connection = Conexion.AbrirConexion();
            //Establecemos la sentencia sql
            Comando.CommandText = "SELECT * FROM Municipios WHERE ID_Departamento = @Departamento"; //!!se cambio la consulta
            //!!Limpiamos los parámetros previos
            Comando.Parameters.Clear();

            //!!Se añadieron parametros nuevos
            Comando.Parameters.AddWithValue("@Departamento", departamentoID);

            //Leemos las filas
            LeerFilas = Comando.ExecuteReader();
            //Cargamos filas
            Tabla.Load(LeerFilas);
            //Cerramos la conexion
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        //Creamos un metodo publico de tipo datatable para listar la tabla ciudadanos
        public DataTable ListarCiudadanosDGV()
        {
            //instanciamos al objeto datatable para almacenar los datos
            DataTable Tabla = new DataTable();
            //Abrimos la conexion
            Comando.Connection = Conexion.AbrirConexion();
            //Establecemos la sentencia sql
            Comando.CommandText = "Select * From Ciudadanos";
            //Leemos las filas
            LeerFilas = Comando.ExecuteReader();
            //Cargamos filas
            Tabla.Load(LeerFilas);
            //Cerramos la conexion
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

    }
}
