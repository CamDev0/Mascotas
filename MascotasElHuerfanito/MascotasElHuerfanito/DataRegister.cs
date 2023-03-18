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
    public partial class DataRegister : Form
    {
        //Creamos una variable
        private Validaciones _validaciones;
        private DatosTabla _datosTabla;
        public DataRegister()
        {
            InitializeComponent();
            //Creamos nueva instancia para que no sea nulo.
            _validaciones = new Validaciones();
        }

        private void btnRegisterMascota_Click(object sender, EventArgs e)
        {
            //Creamos un objeto de la clase DatosTabla y le agregamos los valores que ingresa el usuario.
            
            DatosTabla objDatos = new DatosTabla();
            objDatos.Nombre = txtName.Text;
            objDatos.Edad = Int32.Parse(txtEdad.Text);
            objDatos.Raza = txtRaza.Text;
            objDatos.Color = txtColor.Text;

            objDatos.id = _datosTabla != null ? _datosTabla.id : 0;

            _validaciones.SaveDatosMascota(objDatos);

            MessageBox.Show("Realizado con éxito!");
            this.Close();
            
        }

        public void LoadMascota(DatosTabla datos)
        {
            //Para obtener el ID del campo
            _datosTabla = datos;
 
            if (datos != null)
            {
                clearForm();

                txtName.Text = datos.Nombre;
                txtEdad.Text = datos.Edad.ToString();
                txtRaza.Text = datos.Raza;
                txtColor.Text = datos.Color;
            }
        }

        private void clearForm()
        {
            txtName.Text = string.Empty;
            txtEdad.Text = string.Empty;
            txtRaza.Text = string.Empty;
            txtColor.Text = string.Empty;
          
        }

        private void btnCalcelMascota_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
