using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MascotasElHuerfanito
{
    public partial class RegistrarCliente : Form
    {
        private Validaciones _validaciones;
        public RegistrarCliente()
        {
            InitializeComponent();
            _validaciones = new Validaciones();
        }

        private void btnCancelCli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrarC_Click(object sender, EventArgs e)
        {

            DatosTablaClientes objDatos = new DatosTablaClientes();

            objDatos.nombre = textBoxNomCli.Text;
            objDatos.apellido = textBoxApeCli.Text;
            objDatos.telefono = textBoxTelCli.Text;
            objDatos.direccion = textBoxDirCli.Text;
            objDatos.idAdop = Int32.Parse(textBoxIDAdop.Text);

            _validaciones.SaveDatosClientes(objDatos);
            MessageBox.Show("Realizado con éxito!");
            this.Close();

        }

    }
}
