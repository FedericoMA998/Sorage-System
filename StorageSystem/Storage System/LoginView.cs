using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Storage_System
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                string CMD = string.Format("select * from SYS_PASSWORD WHERE ID_PASSWORD = '{0}' and ID_USER = '{1}'", txtUserPass.Text.Trim(), txtUserName.Text.Trim()); // String de consulta
                
                if(txtUserName.Text == "Federico" && txtUserPass.Text == "123456")
                {
                    MessageBox.Show("Ingreso con exito");
                }
                else 
                {
                    MessageBox.Show("Error al intentar ingresar, revise las credenciales e intente de nuevo");
                    txtUserName.Text = "";
                    txtUserPass.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar ingresar, revise las credenciales e intente de nuevo" + ex);
                txtUserName.Text = "";
                txtUserPass.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
