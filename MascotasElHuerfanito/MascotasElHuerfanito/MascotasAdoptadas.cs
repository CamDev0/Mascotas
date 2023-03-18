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
    public partial class MascotasAdoptadas : Form
    {
        private Validaciones _validaciones;
        public MascotasAdoptadas()
        {
            InitializeComponent();
            _validaciones = new Validaciones();
        }

        private void MascotasAdoptadas_Load(object sender, EventArgs e)
        {
            populateAdopcion();
        }
        private void btnActualiClien_Click(object sender, EventArgs e)
        {
            populateAdopcion();
        }

        public void populateAdopcion()
        {
            List<DatosTablaAdopcion> datos = _validaciones.guardarDatosAdopcion();
            //Le agregamos una fuente de datos a la grilla
            dataGridAdopReg.DataSource = datos;
        }

    }
}
