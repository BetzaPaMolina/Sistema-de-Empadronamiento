using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Windows.Media;

namespace SistemaDeEmpadronamiento
{
    public partial class Formulario_Registro : Form
    {
        private Ciudadanos objCiudadanos;
        public Formulario_Registro()
        {
            InitializeComponent();
            objCiudadanos = new Ciudadanos();
        }

        private void Formulario_Registro_Load(object sender, EventArgs e)
        {
            ListarDepartamentos();
            ListarMunicipios();
        }

        private void ListarDepartamentos()
        {
            //El data source del combo box sera igual al objeto ciudadanos y su metodo de listar departamentos
            cmbdepartamentos.DataSource = objCiudadanos.ListarDepartamentos();
            //Parte visual
            cmbdepartamentos.DisplayMember = "Nombre_Departamento";
            //Objeto real que se toma de la bd
            cmbdepartamentos.ValueMember = "ID_Departamento";
        }

        private void ListarMunicipios()
        {

            string departamentoSeleccionado = (cmbdepartamentos.SelectedItem as DataRowView)["ID_Departamento"].ToString();
            //
            DataTable municipios = objCiudadanos.ListarMunicipios(departamentoSeleccionado);
            cmbmunicipios.DataSource = municipios;
            //Objeto visual que se muestra en el combobox
            cmbmunicipios.DisplayMember = "Nombre_Municipio";
            //Objeto real que se toma de la bd
            cmbmunicipios.ValueMember = "ID_Municipio";


        }

        private void cmbmunicipios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbdepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarMunicipios();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ConexionBD conexionBD = new ConexionBD();
            // Obtener los valores de los TextBox
            string primerNombre = txtprimernombre.Text;
            string segundoNombre = txtsegundonombre.Text;
            string primerApellido = txtprimerapellido.Text;
            string segundoApellido = txtsegundoapellido.Text;
            DateTime fechaNacimiento = datenacimiento.Value;
            string cui = txtcui.Text;
            int idDepartamento = Convert.ToInt32(cmbdepartamentos.SelectedValue);
            int idMunicipio = Convert.ToInt32(cmbmunicipios.SelectedValue);

            // Crear la consulta SQL de inserción
            string query = "INSERT INTO Ciudadanos (Primer_Nombre, Segundo_Nombre, Primer_Apellido, Segundo_Apellido, Fecha_Nacimiento, CUI, ID_Departamento, ID_Municipio) " +
                           "VALUES (@PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @CUI, @IDDepartamento, @IDMunicipio)";

            using (SqlConnection connection = conexionBD.AbrirConexion())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar los parámetros
                    command.Parameters.AddWithValue("@PrimerNombre", primerNombre);
                    command.Parameters.AddWithValue("@SegundoNombre", segundoNombre);
                    command.Parameters.AddWithValue("@PrimerApellido", primerApellido);
                    command.Parameters.AddWithValue("@SegundoApellido", segundoApellido);
                    command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                    command.Parameters.AddWithValue("@CUI", cui);
                    command.Parameters.AddWithValue("@IDDepartamento", idDepartamento);
                    command.Parameters.AddWithValue("@IDMunicipio", idMunicipio);

                    // Ejecutar el comando de inserción
                    command.ExecuteNonQuery();
                }
            }

            // Limpiar los TextBox después de la inserción
            txtprimernombre.Text = "";
            txtsegundonombre.Text = "";
            txtprimerapellido.Text = "";
            txtsegundoapellido.Text = "";
            datenacimiento.ResetText();
            txtcui.Text = ""; 



            // Mostrar un mensaje de éxito
            MessageBox.Show("Los datos se han insertado correctamente en la base de datos.");

        }
    }
}
