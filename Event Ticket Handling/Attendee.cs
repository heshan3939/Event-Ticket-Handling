using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Event_Ticket_Handling.Classes
{
    public class Attendee : User
    {
        public override bool Login()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT AttendeeID, FullName FROM tbl_attendee WHERE Email = @Email AND Password = @Password";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", this.Email);
                    cmd.Parameters.AddWithValue("@Password", this.Password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            UserID = reader.GetInt32("AttendeeID");
                            Username = reader.GetString("FullName");
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }


}