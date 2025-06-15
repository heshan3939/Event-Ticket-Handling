using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Event_Ticket_Handling
{
    public partial class Attendee_Registration : Form
    {
        public Attendee_Registration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
       string.IsNullOrWhiteSpace(txtUseremail.Text) ||
       string.IsNullOrWhiteSpace(txtPassword.Text) ||
       string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password and Confirm Password do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connStr = "server=localhost;user=root;password=;database=eventdata;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO tbl_attendee (FullName, Email, Password) VALUES (@FullName, @Email, @Password)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtUseremail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Attendee_Login login = new Attendee_Login();
                            login.Show();
                        }
                        else
                        {
                            MessageBox.Show("Registration failed.");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062) // Duplicate entry
                    {
                        MessageBox.Show("Email is already registered.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Database error: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error: " + ex.Message);
                }
            }
        }

        private void Attendee_Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
