# Conexion SQL

<p>
¿Cómo se conecta la aplicación a la base de datos?
</p>
- Debemos de crear con antelación nuestra base de datos y subir el backup a github

- Creamos una clase para la conexión, y utilizamos sus metodos en el resto de clases.
- Creamos una variable estática de tipo string para la cadena de conexion, en donde especificamos el server, la bd y las credenciales de windows

        static private string CadenaConexion = "Server = IBETH\\SQLEXPRESS ; DataBase = Registro_Empadronamiento ; Integrated Security = true";``

###End
