using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MascotasElHuerfanito
{
    public class AccesoData
    {

              //Local
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=MascotasElHuerfanito;Data Source=CAM\\CAMSQLSERVER");

        //MASCOTAS
        public List<DatosTabla> getDatos(string search = null)
        {
            List<DatosTabla> data = new List<DatosTabla>();

            try
            {
                conn.Open();
                string query = "SELECT id, Nombre, Edad, Tipo, Color FROM DataMascotas ";

                SqlCommand cmd = new SqlCommand();

                //cuando la variable search no sea nula ni esté vacía..
                if (!string.IsNullOrEmpty(search))
                {
                    query += "WHERE Nombre LIKE @search OR id LIKE @search";
                    cmd.Parameters.Add(new SqlParameter("@search", $"%{search}%"));
                }

                //Le pasamos los parámetros después de la verificación.
                cmd.CommandText = query;
                cmd.Connection = conn;

                //Como queremos que devuelva los datos y no los números de columnas afectadas, usamos datareader
                SqlDataReader reader = cmd.ExecuteReader();

                //Por cada una de la iteraciones creamos un contacto y lo agregamos a nuestra lista.
                while(reader.Read())
                {
                    data.Add(new DatosTabla
                    {
                        id = Int32.Parse(reader["id"].ToString()),
                        Nombre = reader["Nombre"].ToString(),
                        Edad = Int32.Parse(reader["Edad"].ToString()),
                        Raza = reader["Tipo"].ToString(),
                        Color = reader["Color"].ToString(),
                    });
                }

            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                conn.Close();
            }
                return data;
        }

        public void InsertMascota(DatosTabla datos)
        {
            try
            {
                conn.Open();
                string query = " INSERT INTO DataMascotas  VALUES (@Nombre, @Edad, @Tipo, @Color)";
                
                //agregamos los valores de la consulta
                SqlParameter nombre = new SqlParameter("@Nombre", datos.Nombre);
                SqlParameter edad = new SqlParameter("@Edad", datos.Edad);
                SqlParameter tipo = new SqlParameter("@Tipo", datos.Raza);
                SqlParameter color = new SqlParameter("@Color", datos.Color);

                //Al command le pasamos la consulta y la conexión, ya que es el que se ejecuta.
                SqlCommand cmd = new SqlCommand(query, conn);

                //Agregamos los parámetros al objeto cmd de la clase command.
                cmd.Parameters.Add(nombre);
                cmd.Parameters.Add(edad);
                cmd.Parameters.Add(tipo);
                cmd.Parameters.Add(color);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

            //cierra de manera mas segura la conexión
            finally
            {
                conn.Close();
            }
        }


        public void UpdateMascota(DatosTabla datos)
        {
            try
            {
                conn.Open();
                string query = @"UPDATE DataMascotas
                                SET Nombre = @Nombre,
                                    Edad  = @Edad,
                                    Tipo = @Tipo,
                                    Color = @Color 
                                WHERE id = @id" ;

                SqlParameter id = new SqlParameter("@id", datos.id);
                SqlParameter nombre = new SqlParameter("@Nombre", datos.Nombre);
                SqlParameter edad = new SqlParameter("@Edad", int.Parse(datos.Edad.ToString()));
                SqlParameter tipo = new SqlParameter("@Tipo", datos.Raza);
                SqlParameter color = new SqlParameter("@Color", datos.Color);

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.Add(id);
                cmd.Parameters.Add(nombre);
                cmd.Parameters.Add(edad);
                cmd.Parameters.Add(tipo);
                cmd.Parameters.Add(color);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                conn.Close();
            }
        }


        public void DeleteMascota(int ID)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM DataMascotas WHERE id = @id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.Add(new SqlParameter("@id", ID));

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }


        //CLIENTES

        public List<DatosTablaClientes> getDatosClientes()
        {
            List<DatosTablaClientes> data = new List<DatosTablaClientes>();

            try
            {
                conn.Open();
                string query = "SELECT id_CLI, idAdop, nombre, apellido, telefono, direccion FROM tblClientes";

                SqlCommand cmd = new SqlCommand(query, conn);

                //Como queremos que devuelva los datos y no los números de columnas afectadas, usamos datareader
                SqlDataReader reader = cmd.ExecuteReader();

                //Por cada una de la iteraciones creamos un contacto y lo agregamos a nuestra lista.
                while (reader.Read())
                {
                    data.Add(new DatosTablaClientes
                    {
                        id_CLI = Int32.Parse(reader["id_CLI"].ToString()),
                        idAdop = Int32.Parse(reader["idAdop"].ToString()),
                        nombre = reader["nombre"].ToString(),
                        apellido = reader["apellido"].ToString(),
                        telefono = reader["telefono"].ToString(),
                        direccion = reader["direccion"].ToString()
                    });
                }

            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                conn.Close();
            }
            return data;
        }


        public void InsertCliente(DatosTablaClientes datos)
        {
            try
            {
                conn.Open();
                string query = " INSERT INTO tblClientes  VALUES (@idAdop, @nombre, @apellido, @telefono, @direccion)";

                //agregamos los valores de la consulta
                SqlParameter idAd = new SqlParameter("@idAdop", datos.idAdop);
                SqlParameter nombre = new SqlParameter("@nombre", datos.nombre);
                SqlParameter apellido = new SqlParameter("@apellido", datos.apellido);
                SqlParameter telefono = new SqlParameter("@telefono", datos.telefono);
                SqlParameter direccion = new SqlParameter("@direccion", datos.direccion);

                //Al command le pasamos la consulta y la conexión, ya que es el que se ejecuta.
                SqlCommand cmd = new SqlCommand(query, conn);

                //Agregamos los parámetros al objeto cmd de la clase command.
                cmd.Parameters.Add(idAd);
                cmd.Parameters.Add(nombre);
                cmd.Parameters.Add(apellido);
                cmd.Parameters.Add(telefono);
                cmd.Parameters.Add(direccion);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

            //cierra de manera mas segura la conexión
            finally
            {
                conn.Close();
            }
        }


        public void DeleteClientes(int ID)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM tblClientes WHERE id_CLI = @id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.Add(new SqlParameter("@id", ID));

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }


        //ADOPCION

        public List<DatosTablaAdopcion> getDatosAdopcion()
        {
            List<DatosTablaAdopcion> data = new List<DatosTablaAdopcion>();

            try
            {
                conn.Open();
                string query = "SELECT  idMascota, nombreMascota, tipoMascota FROM tblAdopcion";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(new DatosTablaAdopcion
                    {
                        idMascota = Int32.Parse(reader["idMascota"].ToString()),
                        nombreMascota = reader["nombreMascota"].ToString(),
                        tipoMascota = reader["tipoMascota"].ToString()
                    });
                }

            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                conn.Close();
            }
            return data;
        }


        public void InsertAdopcion(int id, string name, string type)
        {
            try
            {
                conn.Open();
                string query = @"IF EXISTS (SELECT * FROM tblAdopcion WHERE idMascota = " + id + ")" + @"
                                    SELECT '-1'
                                 ELSE
                                   INSERT INTO tblAdopcion  VALUES 
                                   (@idMascota, @nombreMascota, @tipoMascota)";
                                
                //agregamos los valores de la consulta
                SqlParameter idMascota = new SqlParameter("@idMascota", id);
                SqlParameter nameMascota = new SqlParameter("@nombreMascota", name);
                SqlParameter tipoMascota = new SqlParameter("@tipoMascota", type);

                //Al command le pasamos la consulta y la conexión, ya que es el que se ejecuta.
                SqlCommand cmd = new SqlCommand(query, conn);

                //Agregamos los parámetros al objeto cmd de la clase command.
                cmd.Parameters.Add(idMascota);
                cmd.Parameters.Add(nameMascota);
                cmd.Parameters.Add(tipoMascota);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

            //cierra de manera mas segura la conexión
            finally
            {
                conn.Close();
            }
        }


        public void DeleteAdopcion(int ID)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM tblAdopcion WHERE idMascota = @id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.Add(new SqlParameter("@id", ID));

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }


    }
}
