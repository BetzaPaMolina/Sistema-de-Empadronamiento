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
    }
}
