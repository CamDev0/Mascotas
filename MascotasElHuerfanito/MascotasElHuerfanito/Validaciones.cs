using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MascotasElHuerfanito
{
    public class Validaciones
    {
        private AccesoData _accesoData;

        public Validaciones()
        {
            _accesoData = new AccesoData();
        }

        //MASCOTAS
        public DatosTabla SaveDatosMascota(DatosTabla datos)
        {
            //Envía la información a nuestra capa de acceso a datos
            if (datos.id == 0)
                _accesoData.InsertMascota(datos);
            else
              _accesoData.UpdateMascota(datos);

            return datos;
        }

        public List<DatosTabla> guardarDatos(string search = null)
        {
           return  _accesoData.getDatos(search);
        }

        public void DeleteMascota(int id)
        {
            _accesoData.DeleteMascota(id);
        }

        //CLIENTES  

        public List<DatosTablaClientes> guardarDatosClientes()
        {
            return _accesoData.getDatosClientes();
        }

        public DatosTablaClientes SaveDatosClientes (DatosTablaClientes datos)
        {
            //Envía la información a nuestra capa de acceso a datos
           _accesoData.InsertCliente(datos);
            return datos;
        }

        public void DeleteClientes(int id)
        {
            _accesoData.DeleteClientes(id);
        }



        //ADOPCION

        public DatosTablaAdopcion SaveDatosAdopcion(DatosTablaAdopcion datos, int id, string name, string type)
        {
            _accesoData.InsertAdopcion(id, name, type);
            return datos;
        }

        public void ingresarAdopcion(int id, string name, string type)
        {
            DatosTablaAdopcion obj = new DatosTablaAdopcion();
            SaveDatosAdopcion(obj, id, name, type);
        }

        public List<DatosTablaAdopcion> guardarDatosAdopcion()
        {
            return _accesoData.getDatosAdopcion();
        }

        public void DeleteAdopcion(int id)
        {
            _accesoData.DeleteAdopcion(id);
        }
    }
}
