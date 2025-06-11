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
using Event_Ticket_Handling.Classes;
using System.Xml.Linq;


namespace Event_Ticket_Handling
{
    public partial class Attendee_Login : Form
    {
        public Attendee_Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            Attendee_Registration attendee_Registration = new Attendee_Registration();
            attendee_Registration.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            Attendee attendee = new Attendee
            {
                Email = txtUseremail.Text.Trim(),
                Password = txtPassword.Text.Trim()
            };

            if (attendee.Login())
            {
                MessageBox.Show("Login successful!");
                this.Hide();

                AttendeeDashboard dashboard = new AttendeeDashboard(attendee.Username, attendee.UserID);
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }
    }
}
