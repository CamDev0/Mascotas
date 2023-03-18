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
    public partial class EditarMascota : Form
    {
        private Validaciones _validaciones;
        public EditarMascota()
        {
            InitializeComponent();
            _validaciones = new Validaciones();
        }

        private void EditarMascota_Load(object sender, EventArgs e)
        {
            List<DatosTabla> datos = _validaciones.guardarDatos();
            //Le agregamos una fuente de datos a la grilla
            dataGridEdit.DataSource = datos;
        }

        private void dataGridEdit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //Obtenemos el campo completo de donde han dado click, casteamos el resultado al tipo correcto de dato para evitar el error.
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dataGridEdit.Rows[e.RowIndex].Cells[e.ColumnIndex];

            //Validamos si se dió click donde se debe dar para poder Editar
            if (cell.Value.ToString() == "Actualizar")
            {
                DataRegister data = new DataRegister();

                data.LoadMascota(new DatosTabla
                {
                    id = int.Parse(dataGridEdit.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    Nombre = dataGridEdit.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Edad = int.Parse (dataGridEdit.Rows[e.RowIndex].Cells[2].Value.ToString() ),
                    Raza = dataGridEdit.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Color = dataGridEdit.Rows[e.RowIndex].Cells[4].Value.ToString()
                });

                data.ShowDialog(this);
            }

            populateMascotasEditar();
        }

        public void populateMascotasEditar()
        {

            List<DatosTabla> datos = _validaciones.guardarDatos();
            //Le agregamos una fuente de datos a la grilla
            dataGridEdit.DataSource = datos;
        }
    }
}
