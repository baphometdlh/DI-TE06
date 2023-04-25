using ElementosVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichaEmpleados
{
    public partial class Ficha : Form
    {
        public Ficha()
        {
            InitializeComponent();
        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        public void UnEmpleado(EmpleadosVO unEmpleado)
        {
            EmpleadosVO elEmpleado = unEmpleado;
            try
            {
                textBoxTelefono.AppendText(elEmpleado.Telefono.ToString());
                TextBoxExtension.AppendText(elEmpleado.Extension.ToString());
                textBoxNombre.AppendText(elEmpleado.Nombre.ToString());
                textBoxApellido.AppendText(elEmpleado.Apellido.ToString());
                textBoxTitulo.AppendText(elEmpleado.TituloDeCortesia.ToString());
                textBoxPuesto.AppendText(elEmpleado.Titulo.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
