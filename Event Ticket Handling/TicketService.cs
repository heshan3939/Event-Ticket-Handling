using Event_Ticket_Handling.Models;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Event_Ticket_Handling.Services
{
    public class TicketService
    {
        private string connStr = "server=localhost;user=root;password=;database=eventdata;";

        public DataTable GetTicketsByEvent(int eventID)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = @"
            SELECT 
                TicketID, 
                TicketType, 
                Price, 
                Quantity, 
                Sold, 
                (Quantity - Sold) AS Availability 
            FROM tbl_ticket 
            WHERE EventID = @EventID";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EventID", eventID);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public DataTable GetAvailableTicketsByEvent(int eventID)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = @"
                    SELECT 
                        TicketID, TicketType, Price, 
                        (Quantity - Sold) AS Available 
                    FROM tbl_ticket 
                    WHERE EventID = @EventID";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EventID", eventID);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public DataTable GetPurchasedTicketsByAttendee(int attendeeId)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = @"
            SELECT 
                tp.PurchaseID,
                t.TicketID,
                e.EventName,
                t.TicketType,
                t.Price,
                tp.Quantity,
                (t.Price * tp.Quantity) AS TotalAmount,
                tp.PurchaseDate
            FROM tbl_ticket_purchase tp
            JOIN tbl_ticket t ON tp.TicketID = t.TicketID
            JOIN tbl_events e ON t.EventID = e.EventID
            WHERE tp.AttendeeID = @AttendeeID";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AttendeeID", attendeeId);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public bool CancelTicket(int purchaseId, int ticketId, int quantity)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string deleteQuery = "DELETE FROM tbl_ticket_purchase WHERE PurchaseID = @PurchaseID";
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@PurchaseID", purchaseId);
                        cmd.ExecuteNonQuery();
                    }

                    string updateQuery = "UPDATE tbl_ticket SET Sold = Sold - @Quantity WHERE TicketID = @TicketID AND Sold >= @Quantity";
                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@TicketID", ticketId);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public bool PurchaseTicket(int attendeeId, int ticketId, int quantityToBuy)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    //  Get current availability
                    string checkQuery = "SELECT Quantity, Sold FROM tbl_ticket WHERE TicketID = @TicketID";
                    int available = 0;

                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn, transaction))
                    {
                        checkCmd.Parameters.AddWithValue("@TicketID", ticketId);
                        using (MySqlDataReader reader = checkCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int quantity = reader.GetInt32("Quantity");
                                int sold = reader.GetInt32("Sold");
                                available = quantity - sold;
                            }
                            else
                            {
                                MessageBox.Show("Ticket not found.");
                                transaction.Rollback();
                                return false;
                            }
                        }
                    }

                    // Check if enough tickets are available
                    if (quantityToBuy > available)
                    {
                        MessageBox.Show($"Only {available} tickets are available. Please reduce quantity.");
                        transaction.Rollback();
                        return false;
                    }

                    // Insert into ticket_purchase
                    string insertQuery = @"INSERT INTO tbl_ticket_purchase (AttendeeID, TicketID, Quantity, PurchaseDate)
                                   VALUES (@AttendeeID, @TicketID, @Quantity, @PurchaseDate)";
                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn, transaction))
                    {
                        insertCmd.Parameters.AddWithValue("@AttendeeID", attendeeId);
                        insertCmd.Parameters.AddWithValue("@TicketID", ticketId);
                        insertCmd.Parameters.AddWithValue("@Quantity", quantityToBuy);
                        insertCmd.Parameters.AddWithValue("@PurchaseDate", DateTime.Now);
                        insertCmd.ExecuteNonQuery();
                    }

                    // Update Sold count
                    string updateQuery = "UPDATE tbl_ticket SET Sold = Sold + @Quantity WHERE TicketID = @TicketID";
                    using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn, transaction))
                    {
                        updateCmd.Parameters.AddWithValue("@Quantity", quantityToBuy);
                        updateCmd.Parameters.AddWithValue("@TicketID", ticketId);
                        updateCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error purchasing ticket: " + ex.Message);
                    return false;
                }
            }
        }


        public void AddTicket(Ticket ticket)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "INSERT INTO tbl_ticket (EventID, TicketType, Price, Quantity) VALUES (@EventID, @TicketType, @Price, @Quantity)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EventID", ticket.EventID);
                    cmd.Parameters.AddWithValue("@TicketType", ticket.TicketType);
                    cmd.Parameters.AddWithValue("@Price", ticket.Price);
                    cmd.Parameters.AddWithValue("@Quantity", ticket.Quantity);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateTicket(Ticket ticket)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "UPDATE tbl_ticket SET TicketType=@TicketType, Price=@Price, Quantity=@Quantity WHERE TicketID=@TicketID AND EventID=@EventID";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TicketType", ticket.TicketType);
                    cmd.Parameters.AddWithValue("@Price", ticket.Price);
                    cmd.Parameters.AddWithValue("@Quantity", ticket.Quantity);
                    cmd.Parameters.AddWithValue("@TicketID", ticket.TicketID);
                    cmd.Parameters.AddWithValue("@EventID", ticket.EventID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteTicket(int ticketID, int eventID)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string[] queries = new string[]
                {
            "DELETE FROM tbl_ticket_purchase WHERE TicketID = @TicketID",
            "DELETE FROM tbl_ticket WHERE TicketID = @TicketID AND EventID = @EventID"
                };

                foreach (string query in queries)
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TicketID", ticketID);
                        cmd.Parameters.AddWithValue("@EventID", eventID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

    }
}
