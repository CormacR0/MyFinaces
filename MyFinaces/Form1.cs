using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Data.SqlClient;

namespace MyFinaces
{
    public partial class Login_Screen : Form
    {
        public Login_Screen()
        {
            InitializeComponent();
        }


        public string GetHash(string input)
        {
            SHA256 hasher = SHA256.Create();

            byte[] bytes = hasher.ComputeHash(Encoding.ASCII.GetBytes(input));
            string hash = "";
            foreach (byte b in bytes)
            {
                hash += $"{b:X2}";
            }
            return hash;
        }

       


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string hash = GetHash(password);
            Debug.WriteLine($"Attempting to generate a password hash for: {password}");


            // connect to the database
            string Connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""W:\008. Computing\Student work\2021-2022\Y12\Cormac Reilly\MyFinaces\MyFinaces\Finaces.mdf"";Integrated Security=True";

            using (SqlConnection c = new SqlConnection(Connection))
            {
                // query the users table
                string sql = "SELECT * FROM Users WHERE  Username =@username AND PasswordHash=@hash";
                SqlCommand cmd = new SqlCommand(sql, c);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("hash", hash);

                c.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                lblStatus.Text = "login failed";
                while(reader.Read())
                {
                    string firstname = reader["FirstName"].ToString();
                    string lastname = reader["LastName"].ToString();
                    int id = int.Parse(reader["Id"].ToString());

                    lblStatus.Text = ($"User ID{id} is {firstname} {lastname}");
                    Finaces finaceForm = new Finaces();
                    finaceForm.Show();
                    
                }

            }

                
            // determine if the username / password is correct

        }
    }
}
