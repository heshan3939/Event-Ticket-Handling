using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Event_Ticket_Handling.Services
{
    public class SalesService
    {
        private string connStr = "server=localhost;user=root;password=;database=eventdata;";

        public DataTable GetSalesByEvent(int eventId)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = @"
            SELECT tp.PurchaseID, a.Fullname AS AttendeeName, t.TicketType, t.Price, tp.Quantity,
                   (t.Price * tp.Quantity) AS Total, tp.PurchaseDate
            FROM tbl_ticket_purchase tp
            JOIN tbl_ticket t ON tp.TicketID = t.TicketID
            JOIN tbl_attendee a ON tp.AttendeeID = a.AttendeeID
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
