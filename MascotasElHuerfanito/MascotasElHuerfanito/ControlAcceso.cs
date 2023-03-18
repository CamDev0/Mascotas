using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MascotasElHuerfanito
{
    public partial class ControlAcceso : Form
    {
        public ControlAcceso()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            MaestroMDI maestro = new MaestroMDI();
            string usuario = txtUsuario.Text;
            string clave = txtContra.Text;

                //local
            SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=MascotasElHuerfanito;Data Source=CAM\\CAMSQLSERVER");

            if (String.IsNullOrEmpty(txtUsuario.Text) || String.IsNullOrEmpty(txtContra.Text))
            {
                MessageBox.Show("Faltan campos por llenar.");
                txtUsuario.Clear();
                txtContra.Clear();
                txtUsuario.Focus();
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM tblAcceso WHERE usuario = '" + usuario + "' AND clave = '" + clave + "'";

                    DataTable data = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    //Llenamos la tabla con el método fill, por medio del objeto adapter
                    adapter.Fill(data);

                    //Validamos, si arroja un registro ingresamos, sinó no.
                    if (data.Rows.Count > 0)
                    {
                        String nombre = data.Rows[0]["usuario"].ToString();
                        MessageBox.Show("Bienvenid@ " + nombre);
                        maestro.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña incorrecta, reintente por favor.");
                        txtUsuario.Clear();
                        txtContra.Clear();
                        txtUsuario.Focus();
                    }
                }
                catch (Exception)
                {
                    throw;
                }


            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
