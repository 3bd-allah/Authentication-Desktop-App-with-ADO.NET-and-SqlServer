using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-PRASEGR;Initial Catalog=wfd2;Integrated Security=True;Trust Server Certificate=True");

            SqlCommand cmd = new SqlCommand("Select id from userdata where email = @email and password = @password" ,con);

            // first method to add parameter to query 
            cmd.Parameters.AddWithValue("email", txt_email.Text);


            // second method to add parameter to query 
            SqlParameter passwordParam = new SqlParameter
            {
                ParameterName = "password",
                Value = txt_pass.Text,
                SqlDbType = SqlDbType.NVarChar,
                Direction = ParameterDirection.Input,
            };
            cmd.Parameters.Add(passwordParam);


            con.Open();

            var dr = cmd.ExecuteScalar();

            if (dr is not null)
            {
                this.Hide();
                Monitor monitor = new Monitor();
                monitor.Show();

            }
            else
            {
                //lbl_error.Text = "email or password is incorrect";
                MessageBox.Show("email or password is incorrect", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            con.Close();

        }
    }
}
