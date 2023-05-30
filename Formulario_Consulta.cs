using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace SistemaDeEmpadronamiento
{
    public partial class Formulario_Consulta : Form
    {
        private Ciudadanos objCiudadanos;
        public Formulario_Consulta()
        {
            InitializeComponent();
            objCiudadanos = new Ciudadanos();

        }

        ConexionBD Conexion = new ConexionBD();

        private void Formulario_Consulta_Load(object sender, EventArgs e)
        {
            ListarCiudadanosDGV();
        }
        private void ListarCiudadanosDGV()
        {
            //El data source del combo box sera igual al objeto ciudadanos y su metodo de listar departamentos
            dgvRegistro.DataSource = objCiudadanos.ListarCiudadanosDGV();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            ListarCiudadanosDGV();
        }
    }
}
