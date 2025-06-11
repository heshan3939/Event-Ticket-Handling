using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Event_Ticket_Handling.Classes
{
    public class Admin : User
    {

        public override bool Login()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT AdminID, Username FROM tbl_admin WHERE Username = @Username AND Password = @Password";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", this.Username);
                    cmd.Parameters.AddWithValue("@Password", this.Password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            UserID = reader.GetInt32("AdminID");
                            Username = reader.GetString("Username");
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }

}
