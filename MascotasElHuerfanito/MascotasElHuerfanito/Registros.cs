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
    public partial class container : Form
    {
        private Validaciones _validaciones;
        public container()
        {
            InitializeComponent();
            _validaciones = new Validaciones();
        }

        private void btnActuReg_Click(object sender, EventArgs e)
        {
            populateMascotas();
        }

        private void container_Load(object sender, EventArgs e)
        {
            populateMascotas();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            populateMascotas(txtSearch.Text);
            txtSearch.Text = string.Empty;
        }

        //Al agregarle null, el parámetro se vuelve opcional
        public void populateMascotas(string searchText = null)
        {

            List<DatosTabla> datos = _validaciones.guardarDatos(searchText);
            //Le agregamos una fuente de datos a la grilla
            gridData.DataSource = datos;
        }

    }
}
