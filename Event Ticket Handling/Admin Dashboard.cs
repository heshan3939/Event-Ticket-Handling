using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Ticket_Handling
{
    public partial class Admin_Dashboard : Form
    {
        string fullName;
        int adminId;
        public Admin_Dashboard(string name, int id)
        {
            InitializeComponent();
            fullName = name;
            adminId = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Event_Manager eventManager = new Event_Manager();
            eventManager.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnManageattendees_Click(object sender, EventArgs e)
        {
            View_Attendee viewAttendee = new View_Attendee();
            viewAttendee.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            View_Sales salesForm = new View_Sales();
            salesForm.Show();
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
