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
    public partial class RegistroClientes : Form
    {
        private Validaciones _validaciones;
        public RegistroClientes()
        {
            InitializeComponent();
            _validaciones = new Validaciones();
        }

        private void btnActualiClien_Click(object sender, EventArgs e)
        {
            populateClientes();
        }
        private void RegistroClientes_Load(object sender, EventArgs e)
        {
            populateClientes();
        }

        public void populateClientes()
        {
            List<DatosTablaClientes> datos = _validaciones.guardarDatosClientes();
            //Le agregamos una fuente de datos a la grilla
            gridDataCliCon.DataSource = datos;
        }

    }
}
