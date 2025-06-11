﻿using System;
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


namespace Event_Ticket_Handling
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim()
            };

            if (admin.Login())
            {
            
                this.Hide();
                Admin_Dashboard dashboard = new Admin_Dashboard(admin.Username, admin.UserID);
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid admin credentials.");
            }
        }
    }
}
