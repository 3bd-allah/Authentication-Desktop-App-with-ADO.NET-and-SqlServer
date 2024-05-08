using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Data;

namespace RegistrationForm
{
    public partial class frm_register : Form
    {
        SqlConnection con;
        public frm_register()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-PRASEGR;Initial Catalog=wfd2;Integrated Security=True;Trust Server Certificate=True");
        }

        private void frm_register_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from department", con);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            List<Department> depts = new List<Department>();

            while (dr.Read())
            {

                Department dept = new Department
                {
                    Id = (int)dr["id"],
                    Name = (string)dr["name"],
                    Loc = (string)dr["loc"]
                };

                depts.Add(dept);

            }

            //foreach(Department dept in depts)
            //{
            //    cb_dept.Items.Add(dept.Name);
            //}

            cb_dept.DataSource = depts;
            cb_dept.DisplayMember = "Name";
            cb_dept.ValueMember = "Id";


            con.Close();


        }

        private void btn_register_Click(object sender, EventArgs e)
        {

            SqlCommand insertDataCmd = new SqlCommand("Insert into userdata(id, name, age, email, password, depid) values(@id , @name, @age, @email, @password, @depid)", con);

            // 1) first way to add pararmeter  
            insertDataCmd.Parameters.AddWithValue("id", txt_id.Text);
            insertDataCmd.Parameters.AddWithValue("name", txt_name.Text);
            insertDataCmd.Parameters.AddWithValue("age", txt_age.Text);
            insertDataCmd.Parameters.AddWithValue("email", txt_email.Text);
            insertDataCmd.Parameters.AddWithValue("password", txt_pass.Text);
            insertDataCmd.Parameters.AddWithValue("depid", cb_dept.SelectedValue);


            //2) second way to define parameter
            //SqlParameter nameParameter = new SqlParameter
            //{
            //    ParameterName = "@id",
            //    Value = lbl_id.Text,
            //    SqlDbType = SqlDbType.NVarChar,
            //    Direction = ParameterDirection.Input,
            //};

            //insertDataCmd.Parameters.Add(nameParameter);

            con.Open();

            int rowsEffected = insertDataCmd.ExecuteNonQuery();

            if (rowsEffected > 0)
            {
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
            }

            con.Close();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            LoginForm log = new LoginForm();
            log.Show();
            this.Hide();
        }
    }
}
