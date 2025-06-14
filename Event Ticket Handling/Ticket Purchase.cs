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
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;

namespace Event_Ticket_Handling
{
    public partial class Ticket_Purchase : Form
    {
        private int currentEventId; 
        private int attendeeId;
        int selectedEventId;
        private Form dashboardForm;
        public Ticket_Purchase(int evenId, int attendeeId, Form dashboard)
        {
            InitializeComponent();
            selectedEventId = evenId;
            this.attendeeId = attendeeId; 
            this.dashboardForm = dashboard;
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnViewMyTickets_Click(object sender, EventArgs e)
        {
            My_Tickets ticketsForm = new My_Tickets(attendeeId);
            ticketsForm.Show();


        }

        private void Ticket_Purchase_Load(object sender, EventArgs e)
        {
            TicketService ticketService = new TicketService();
            dgvTickets.DataSource = ticketService.GetAvailableTicketsByEvent(selectedEventId);//method created in ticket service
        }

        private void btnBuyTckets_Click(object sender, EventArgs e)
        {
            if (dgvTickets.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a ticket to buy.");
                return;
            }

            int ticketId = Convert.ToInt32(dgvTickets.SelectedRows[0].Cells["TicketID"].Value);
            int available = Convert.ToInt32(dgvTickets.SelectedRows[0].Cells["Available"].Value);

            if (!int.TryParse(txtQuantity.Text, out int quantityToBuy) || quantityToBuy <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            if (quantityToBuy > available)
            {
                MessageBox.Show("Not enough tickets available.");
                return;
            }

            TicketService ticketService = new TicketService();
            if (ticketService.PurchaseTicket(attendeeId, ticketId, quantityToBuy))
            {
                MessageBox.Show("Ticket purchase successful!");
                dgvTickets.DataSource = ticketService.GetAvailableTicketsByEvent(selectedEventId);
            }
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            AttendeeHelper.Logout(this, dashboardForm);
        }
    }
}
