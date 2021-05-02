using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiciosAutomotrices
{
    public partial class FormaPrincipal : Form
    {
        public FormaPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Actualiza las regiones para visualizar en el ComboBoxRegiones
        /// </summary>
        private void ActualizaListBoxPlacas()
        {
            ListBoxPlacas.DataSource = null;
            ListBoxPlacas.DataSource = AccesoDatos.ObtenerPlacas();
            ListBoxPlacas.DisplayMember = "placa";

            // Se selecciona el primer item del ComboBox
            ListBoxPlacas.SelectedIndex = 0;
        }

        private void FormaPrincipal_Load(object sender, EventArgs e)
        {
            ActualizaListBoxPlacas();
            InicializaDataGridViewMarcas();
            InicializaDataGridViewSedes();
            InicializaDataGridViewServicios();
            InicializaTextBoxDBJson();
        }

        private void ListBoxPlacas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vehiculo unVehiculo = AccesoDatos.ObtieneVehiculo(ListBoxPlacas.SelectedItem.ToString());

            TextoPlacaVehiculo.Text = unVehiculo.Placa;
            TextoMarcaVehiculo.Text = unVehiculo.Marca;
            TextoModeloVehiculo.Text = unVehiculo.Modelo.ToString();

            //Aqui llenamos el DatagridView de los servicios atendidos para este vehiculo
            dataGridViewServiciosVehiculo.DataSource = null;
            dataGridViewServiciosVehiculo.DataSource = AccesoDatos.ObtieneServiciosPlaca(unVehiculo.Placa);

            //Aqui obtenemos el json del vehiculo y lo visualizamos en el textbox
            textBoxJsonVehiculo.Text = AccesoDatos.ObtieneJsonVehiculo(unVehiculo.Placa);
        }

        private void InicializaTextBoxDBJson()
        {
            textBoxDBJson.Text = AccesoDatos.ObtieneJsonDBVehiculos();
        }

        private void InicializaDataGridViewMarcas()
        {
            dataGridViewMarcas.DataSource = null;
            dataGridViewMarcas.DataSource = AccesoDatos.ObtieneTotalMarca();
        }

        private void InicializaDataGridViewSedes()
        {
            dataGridViewSedes.DataSource = null;
            dataGridViewSedes.DataSource = AccesoDatos.ObtieneTotalSede();
        }

        private void InicializaDataGridViewServicios()
        {
            dataGridViewServicios.DataSource = null;
            dataGridViewServicios.DataSource = AccesoDatos.ObtieneTotalServicio();
        }

    }
}
