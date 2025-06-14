using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Event_Ticket_Handling
{
    public class EventService
    {
        private readonly string connStr = "server=localhost;user=root;password=;database=eventdata;";

        public bool AddEvent(Event ev)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "INSERT INTO tbl_events (EventName, Date, Venue, Description) VALUES (@EventName, @Date, @Venue, @Description)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EventName", ev.EventName);
                    cmd.Parameters.AddWithValue("@Date", ev.Date);
                    cmd.Parameters.AddWithValue("@Venue", ev.Venue);
                    cmd.Parameters.AddWithValue("@Description", ev.Description);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateEvent(Event ev)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = @"UPDATE tbl_events 
                                SET EventName = @EventName, Date = @Date, Venue = @Venue, Description = @Description 
                                WHERE EventID = @EventID";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EventName", ev.EventName);
                    cmd.Parameters.AddWithValue("@Date", ev.Date);
                    cmd.Parameters.AddWithValue("@Venue", ev.Venue);
                    cmd.Parameters.AddWithValue("@Description", ev.Description);
                    cmd.Parameters.AddWithValue("@EventID", ev.EventID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteEvent(int eventId)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string[] queries = new string[]
                {
            // Delete ticket purchases related to the event
            @"DELETE tp FROM tbl_ticket_purchase tp
              JOIN tbl_ticket t ON tp.TicketID = t.TicketID
              WHERE t.EventID = @EventID",

            // Delete tickets for the event
            "DELETE FROM tbl_ticket WHERE EventID = @EventID",

            // Finally, delete the event
            "DELETE FROM tbl_events WHERE EventID = @EventID"
                };

                foreach (string query in queries)
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EventID", eventId);
                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
        }
        //uses in view attendees and view sales
        public DataTable GetAllEvents()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM tbl_events";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
