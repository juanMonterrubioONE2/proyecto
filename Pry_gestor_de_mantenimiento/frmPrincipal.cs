using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_gestor_de_mantenimiento
{
    public partial class frmPrincipal : Form
    {
        clsPrincipal principal = new clsPrincipal();
        public frmPrincipal()
        {
            InitializeComponent();
            principal = new clsPrincipal();
            //principal.controlUsuarios(this);
           // this.Text = this.Text + "\r\t Perfil:" + clsLogin.rol;
        }

        private void PbcCuentas_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();

        }

        private void PbcClientes_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.AgregarAlContenedor(new frmCliente(), pnlPrincipal);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
