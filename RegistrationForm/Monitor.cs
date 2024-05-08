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
    public partial class Monitor : Form
    {
        public Monitor()
        {
            InitializeComponent();
        }

        private void dgv_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Monitor_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-PRASEGR;Initial Catalog=wfd2;Integrated Security=True;Trust Server Certificate=True");

            SqlCommand selectData = new SqlCommand("Select * from userdata", con);

            con.Open();

            SqlDataReader dr = selectData.ExecuteReader();

            List<UserData> users = new List<UserData>();

            while (dr.Read())
            {
                UserData u = new UserData
                {
                    Id = (int)dr["id"],
                    Name = (string)dr["name"],
                    Age = (int)dr["age"],
                    Email = (string)dr["email"],
                    Password = (string)dr["password"]
                };

                users.Add(u);
            }

            dgv_data.DataSource = users;

            con.Close();



        }
    }
}
