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
    public partial class EliminarAdopcion : Form
    {
        private Validaciones _validaciones;
        public EliminarAdopcion()
        {
            InitializeComponent();
            _validaciones = new Validaciones();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dataGridDeleteAdop.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value.ToString() == "Eliminar")
            {
                deleteAdopcion(int.Parse(dataGridDeleteAdop.Rows[e.RowIndex].Cells[0].Value.ToString()));
            }

            populateAdopcion();
        }
        private void EliminarAdopcion_Load(object sender, EventArgs e)
        {
            populateAdopcion();
        }


        private void deleteAdopcion(int id)
        {
            _validaciones.DeleteAdopcion(id);
        }

        private void populateAdopcion()
        {
            List<DatosTablaAdopcion> datos = _validaciones.guardarDatosAdopcion();
            dataGridDeleteAdop.DataSource = datos;
        }

    }
}
