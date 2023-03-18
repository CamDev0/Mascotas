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
    public partial class AdoptarMascota : Form
    {
        private Validaciones _validaciones;
        public AdoptarMascota()
        {
            InitializeComponent();
            _validaciones = new Validaciones();
        }

        private void AdoptarMascota_Load(object sender, EventArgs e)
        {
            populateAdoptar();
        }

        
        
        private void dataGridAdoptar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewLinkCell cell = (DataGridViewLinkCell)dataGridAdoptar.Rows[e.RowIndex].Cells[e.ColumnIndex];
            
            if (cell.Value.ToString() == "Adoptar")
            {
                int idReference = int.Parse(dataGridAdoptar.Rows[e.RowIndex].Cells[0].Value.ToString());
                string nameRef = dataGridAdoptar.Rows[e.RowIndex].Cells[1].Value.ToString();
                string typeRef = dataGridAdoptar.Rows[e.RowIndex].Cells[3].Value.ToString();
                _validaciones.ingresarAdopcion(idReference, nameRef, typeRef);
            }

            MessageBox.Show("Realizado con éxito!");
            this.Close();
        }

        public void populateAdoptar()
        {
            List<DatosTabla> datos = _validaciones.guardarDatos();
            dataGridAdoptar.DataSource = datos;
        }

    }
}
