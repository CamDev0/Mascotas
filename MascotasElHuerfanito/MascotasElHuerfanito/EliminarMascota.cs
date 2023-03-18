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
    public partial class EliminarMascota : Form
    {
        private Validaciones _validaciones;
        public EliminarMascota()
        {
            InitializeComponent();
            _validaciones = new Validaciones();
        }

        private void EliminarMascota_Load(object sender, EventArgs e)
        {
            populateMascotasEliminar();
        }


        private void dataGridDelete_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            //Obtenemos el campo completo de donde han dado click, casteamos el resultado al tipo correcto de dato para evitar el error.
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dataGridDelete.Rows[e.RowIndex].Cells[e.ColumnIndex];

            //Validamos si se dió click donde se debe dar para poder Editar
            if (cell.Value.ToString() == "Eliminar")
            {
                //eliminamos el id.
                DeleteMascota(int.Parse(dataGridDelete.Rows[e.RowIndex].Cells[0].Value.ToString()));
                
            }

            populateMascotasEliminar();
        }


        //Métodos creados
        private void DeleteMascota(int id)
        {
            _validaciones.DeleteMascota(id);
        }

        public void populateMascotasEliminar()
        {
            List<DatosTabla> datos = _validaciones.guardarDatos();
            //Le agregamos una fuente de datos a la grilla
            dataGridDelete.DataSource = datos;
        }
    }
}
