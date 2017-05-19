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
    public partial class RegistrarCliente : Form
    {
        public RegistrarCliente()
        {
            InitializeComponent();
        }

        private void buttonRegistrarCliente_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

            SqlCommand cmd = new SqlCommand("dbo.insertaCliente", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            var param1 = new SqlParameter("@cedula", SqlDbType.Int);
            param1.Direction = ParameterDirection.Input;
            param1.Value = textBoxCedulaCliente.Text;
            cmd.Parameters.Add(param1);

            var param2 = new SqlParameter("@nombre", SqlDbType.VarChar);
            param2.Direction = ParameterDirection.Input;
            param2.Value = textBoxNombreCliente.Text;
            param2.Size = 50;
            cmd.Parameters.Add(param2);

            var param3 = new SqlParameter("@apellido1", SqlDbType.VarChar);
            param3.Direction = ParameterDirection.Input;
            param3.Value = textBoxPrimerApellido.Text;
            param3.Size = 50;
            cmd.Parameters.Add(param3);

            var param4 = new SqlParameter("@apellido2", SqlDbType.VarChar);
            param4.Direction = ParameterDirection.Input;
            param4.Value = textBoxSegundoApellido.Text;            param4.Size = 50;
            cmd.Parameters.Add(param4);

            var param5 = new SqlParameter("@ciudad", SqlDbType.VarChar);
            param5.Direction = ParameterDirection.Input;
            param5.Value = textBoxCiudad.Text;
            param5.Size = 50;
            cmd.Parameters.Add(param5);

            var param6 = new SqlParameter("@pais", SqlDbType.VarChar);
            param6.Direction = ParameterDirection.Input;
            param6.Value = textBoxPais.Text;
            param6.Size = 50;
            cmd.Parameters.Add(param6);

            var param7 = new SqlParameter("@correoElectronico", SqlDbType.VarChar);
            param7.Direction = ParameterDirection.Input;
            param7.Value = textBoxCorreoElectronico.Text;
            param7.Size = 50;
            cmd.Parameters.Add(param7);

            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Cliente creado correctamente");
        }
    }
}
