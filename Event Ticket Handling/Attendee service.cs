using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Event_Ticket_Handling.Services
{
    public class AttendeeService
    {
        private string connStr = "server=localhost;user=root;password=;database=eventdata;";

        public DataTable GetAttendeesByEvent(int eventId)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = @"
            SELECT a.AttendeeID, a.Fullname, a.Email, tp.Quantity
            FROM tbl_attendee a
            JOIN tbl_ticket_purchase tp ON a.AttendeeID = tp.AttendeeID
            JOIN tbl_ticket t ON tp.TicketID = t.TicketID
            WHERE t.EventID = @EventID";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EventID", eventId);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}

