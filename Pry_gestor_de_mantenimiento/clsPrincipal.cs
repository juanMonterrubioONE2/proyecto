using System.Windows.Forms;

namespace Pry_gestor_de_mantenimiento
{
    internal class clsPrincipal
    {
        public void AgregarAlContenedor(Form formulario, Panel panel)
        {
            panel.Controls.Clear();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.Sizable;
            formulario.Dock = DockStyle.Fill;
            panel.Controls.Add(formulario);

            panel.Tag = formulario;
            formulario.Show();

        }
    }
}
