using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
    }
}
