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
    public partial class MaestroMDI : Form
    {
        private Validaciones _validaciones;
        public MaestroMDI()
        {
            InitializeComponent();
            _validaciones = new Validaciones();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            container objR = new container();
            objR.MdiParent = this;
            objR.Show();
        }

        private void ingresaUnaMascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRegister objD = new DataRegister();
            objD.MdiParent = this;
            objD.Show();
        }

        private void actualizarMascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarMascota objEdit = new EditarMascota();
            objEdit.MdiParent = this;
            objEdit.Show();
          
        }

        private void retiraUnaMascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarMascota objDelete = new EliminarMascota();
            objDelete.MdiParent = this;
            objDelete.Show();
        }


        private void realizarAdopciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarCliente objCli = new RegistrarCliente();
            objCli.MdiParent = this;
            objCli.Show();
        }


        private void cancelarAdopciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarCliente objE = new EliminarCliente();
            objE.MdiParent = this;
            objE.Show();
        }
        private void consultarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroClientes objR = new RegistroClientes();
            objR.MdiParent = this;
            objR.Show();
        }
        private void realizarAdopciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AdoptarMascota objAd = new AdoptarMascota();
            objAd.MdiParent = this;
            objAd.Show();
        }

        private void mascotasAdoptadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MascotasAdoptadas objMa = new MascotasAdoptadas();
            objMa.MdiParent = this;
            objMa.Show();
        }
        private void cancelarAdopciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EliminarAdopcion objD = new EliminarAdopcion();
            objD.MdiParent = this;
            objD.Show();
        }

        private void webToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebApp web = new WebApp();
            web.MdiParent = this;
            web.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
