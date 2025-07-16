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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptaar_Click(object sender, EventArgs e)
        {
            try
            {
                clsLogin login = new clsLogin();
                login.Usuario = txtUsuario.Text;
                login.Password = txtPassword.Text;
                bool resp = login.ValidarAcceso();
                if (resp == true)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
