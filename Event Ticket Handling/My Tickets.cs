using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Event_Ticket_Handling.Services;
using MySql.Data.MySqlClient;

namespace Event_Ticket_Handling
{
    public partial class My_Tickets : Form
    {
        private int attendeeId; // Store the attendee ID for later use
        public My_Tickets(int attendeeId)
        {
            InitializeComponent();
            this.attendeeId = attendeeId; // Initialize with the attendee ID
        }

        private void My_Tickets_Load(object sender, EventArgs e)
        {
            TicketService ticketService = new TicketService();
            dgvMyTickets.DataSource = ticketService.GetPurchasedTicketsByAttendee(attendeeId);
        }

        private void btnCancelTicket_Click(object sender, EventArgs e)
        {
            if (dgvMyTickets.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a ticket to cancel.");
                return;
            }

            int purchaseId = Convert.ToInt32(dgvMyTickets.SelectedRows[0].Cells["PurchaseID"].Value);
            int ticketId = Convert.ToInt32(dgvMyTickets.SelectedRows[0].Cells["TicketID"].Value);
            int quantity = Convert.ToInt32(dgvMyTickets.SelectedRows[0].Cells["Quantity"].Value);

            DialogResult confirm = MessageBox.Show("Are you sure you want to cancel this ticket?", "Confirm Cancel", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
                return;

            TicketService ticketService = new TicketService();
            bool success = ticketService.CancelTicket(purchaseId, ticketId, quantity);

            if (success)
            {
                MessageBox.Show("Ticket canceled successfully.");
                My_Tickets_Load(null, null);
            }
            else
            {
                MessageBox.Show("Error canceling ticket.");
            }
        }
    }
}
