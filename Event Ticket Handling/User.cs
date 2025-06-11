using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Event_Ticket_Handling.Classes
{
    public abstract class User
    {
        public string Email { get; set; }       // For Attendee
        public string Username { get; set; }    // For Admin
        public string Password { get; set; }
        public int UserID { get; protected set; }
       

        protected string connectionString = "server=localhost;user=root;password=;database=eventdata;";

        public abstract bool Login();  // No more out parameters
    }

}
