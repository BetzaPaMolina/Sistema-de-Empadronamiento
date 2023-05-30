using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeEmpadronamiento
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            //Llamamos el metodo y enviamos el form
            AbrirFormulario<Formulario_Registro>();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            //Llamamos el metodo y enviamos el form
            AbrirFormulario<Formulario_Consulta>();
        }

        //Metodo generico para abrir formularios dentro del panel, donde el form sea de tipo form y tenga un constructor vacio
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            //Declaramos un form
            Form formulario;
            //Se busca si el form existe en una coleccion
            formulario =  panel2.Controls.OfType<MiForm>().FirstOrDefault();
            //Si el form no existe
            if (formulario == null)
            {
                //Nueva instancia
                formulario = new MiForm();
                //No es de nivel superior
                formulario.TopLevel = false; 
                //Agregamos el form a la coleccion de paneles
                panel2.Controls.Add(formulario);
                //Especificamos la propiedad tag (almacena datos personalizados que no están directamente relacionados con la funcionalidad principal del control)
                panel2.Tag = formulario;
                //Lo mostramos
                formulario.Show();
            }
            //Si el form existe
            else
            {
                formulario.BringToFront();
            }

        }

        private void btncerrar_Click(object sender, EventArgs e)
        { 
            //Cerramos el programa
            Application.Exit();
        }
    }
}
