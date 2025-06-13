using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Ticket_Handling
{

    public static class AttendeeHelper
    {
        public static void Logout(Form currentForm, Form dashboardForm = null)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                dashboardForm?.Close();
                currentForm.Close();

                
                Attendee_Login loginForm = new Attendee_Login();
                loginForm.Show();
            }
        }
    }
}
