using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebAppElHuerfanito
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand cmd;
            SqlDataReader datosTabla;

            try
            {
                conn = new SqlConnection("Data Source= Su_servidor_SQL; Initial Catalog= MascotasElHuerfanito; integrated security= true;");
                conn.Open();
                String query = "SELECT * FROM DataMascotas WHERE id = " + Int32.Parse(txtID.Text);

                cmd = new SqlCommand(query, conn);
                datosTabla = cmd.ExecuteReader();

                if (datosTabla.Read())
                {
                    txtNombre.Text = datosTabla[1].ToString();
                    txtEdad.Text =  datosTabla[2].ToString();
                    txtTipo.Text = datosTabla[3].ToString();
                    txtColor.Text = datosTabla[4].ToString();
                    lbMessage.Text = "Mascota Encontrada!";
                }
                else
                {
                    lbMessage.Text = "No existe mascota con ese código";
                    txtID.Text = "";
                    txtNombre.Text = "";
                    txtEdad.Text = "";
                    txtColor.Text = "";
                    txtTipo.Text = "";
                    txtID.Focus();
                }
            }
            catch (SqlException err)
            {
                lbMessage.Text = "Error de conexión, reintente por favor. " + err.Message ;
            }

        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtColor.Text = "";
            txtTipo.Text = "";
            lbMessage.Text = "";
            txtID.Focus();
        }
    }
}