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
    public partial class frmCliente : Form
    {

        private clsClientes cliente;
        public frmCliente()
        {
            InitializeComponent();
            cliente = new clsClientes();
            dgvClientes.DataSource = null;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvClientes.DataSource = cliente.CargarDatagridview();
            LbFecha.Text = cliente.Lblhora;
            // Configurar combos puta hola
            // Cargar categorías de equipos
            cmbCategorias.DataSource = cliente.ObtenerCategorias();
            cmbCategorias.DisplayMember = "vchnombre";
            cmbCategorias.ValueMember = "intidcategoria";

            // Cargar marcas de equipos
            cmbMarcas.DataSource = cliente.ObtenerMarcas();
            cmbMarcas.DisplayMember = "vchnombre";
            cmbMarcas.ValueMember = "intidmarca";

            // Cargar estados de órdenes
            cmbEstado.DataSource = cliente.ObtenerEstados();
            cmbEstado.DisplayMember = "vchnombre";
            cmbEstado.ValueMember = "intidestado";
            // Mostrar datos iniciales

        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Datos del usuario
                cliente.ObtenerRoles();
                cliente.Nombre = txtNombre.Text;
                cliente.Apaterno = txtApaterno.Text;
                cliente.Amaterno = txtAmaterno.Text;
                cliente.Correo = txtCorreo.Text;
                cliente.Password = txtPassword.Text;
                cliente.Telefono = txtTelefono.Text;
                cliente.Direccion = txtDireccion.Text;


                // Datos del equipo (si aplica)
                cliente.Noserie = txtNoSerie.Text;
                cliente.Idcategoria = Convert.ToInt32(cmbCategorias.SelectedValue);
                cliente.Idmarca = Convert.ToInt32(cmbMarcas.SelectedValue);
                cliente.Idestado = Convert.ToInt32(cmbEstado.SelectedValue);
                cliente.Modelo = txtModelo.Text;

                // Datos de la orden (si aplica)
                cliente.Descripcion = txtDescipcion.Text;

                string resultado = cliente.Guardar();
                MessageBox.Show(resultado);
                cliente.limpiarCampos(this);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
