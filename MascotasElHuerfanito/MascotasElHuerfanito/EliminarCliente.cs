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
    public partial class EliminarCliente : Form
    {

        private Validaciones _validaciones;
        public EliminarCliente()
        {
            InitializeComponent();
            _validaciones = new Validaciones();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //Obtenemos el campo completo de donde han dado click, casteamos el resultado al tipo correcto de dato para evitar el error.
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dataDeleteClientes.Rows[e.RowIndex].Cells[e.ColumnIndex];

            //Validamos si se dió click donde se debe dar para poder Editar
            if (cell.Value.ToString() == "Eliminar")
            {
                //eliminamos el id.
                deleteClientes(int.Parse(dataDeleteClientes.Rows[e.RowIndex].Cells[0].Value.ToString()));

            }

            populateClientes();
        }
        private void EliminarCliente_Load(object sender, EventArgs e)
        {
            populateClientes();
        }


        //Métodos creados
        private void deleteClientes(int id)
        {
            _validaciones.DeleteClientes(id);
        }

        public void populateClientes()
        {
            List<DatosTablaClientes> datos = _validaciones.guardarDatosClientes();
            //Le agregamos una fuente de datos a la grilla
            dataDeleteClientes.DataSource = datos;
        }

    }
}
