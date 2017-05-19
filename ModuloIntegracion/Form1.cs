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

namespace ModuloIntegracion
{
    public partial class FormModuloIntegracion : Form
    {
        public FormModuloIntegracion()
        {
            InitializeComponent();
        }

        private void buttonListaClientesMercadeo_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

            String consulta = "select Cliente.cedula, nombre, apellido1, apellido2, ciudad, Pais.nombrePais, correoElectronico, Servicio.descripcion, RedSocialCliente.nombreRedSocial from Cliente join IntermediaClienteyServicio on Cliente.cedula = IntermediaClienteyServicio.cedula join Servicio on Servicio.idServicio = IntermediaClienteyServicio.idServicio join IntermediaRSClienteyCliente on IntermediaRSClienteyCliente.cedula = Cliente.cedula join RedSocialCliente on RedSocialCliente.idRedSocial =IntermediaRSClienteyCliente.idRedSocial join Pais on Cliente.pais= Pais.idPais";

            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);
            var dataAdapter = new SqlDataAdapter(consulta, conexion);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridViewModuloIntegracion.ReadOnly = true;
            dataGridViewModuloIntegracion.DataSource = dataSet.Tables[0];
        }

        private void buttonRegistroNuevoCliente_Click(object sender, EventArgs e)
        {
            RegistrarCliente formRegistrarCliente = new RegistrarCliente();
            formRegistrarCliente.Show();
        }
    }
}
