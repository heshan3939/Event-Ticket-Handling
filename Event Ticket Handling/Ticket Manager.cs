using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Event_Ticket_Handling.Models;
using Event_Ticket_Handling.Services;
using Event_Ticket_Handling.Classes;
using MySql.Data.MySqlClient;

namespace Event_Ticket_Handling
{
    public partial class Ticket_Manager : Form
    {
        private TicketService ticketService = new TicketService();

        private int selectedEventID;
        public Ticket_Manager(int eventID, string eventName)
        {
            InitializeComponent();
            selectedEventID = eventID;
            lblEventName.Text = eventName;

            ticketService = new TicketService(); // create service object
            LoadTicketsToGrid();
        }
        private void LoadTicketsToGrid()
        {
            DataTable dt = ticketService.GetTicketsByEvent(selectedEventID);
            dataGridViewTickets.DataSource = dt;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadTicketsToGrid();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid non-negative price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Please enter a valid non-negative quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Ticket ticket = new Ticket
            {
                EventID = selectedEventID,
                TicketType = txtTickettype.Text,
                Price = price,
                Quantity = quantity
            };

            ticketService.AddTicket(ticket);
            MessageBox.Show("Ticket added successfully!");
            LoadTicketsToGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid non-negative price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Please enter a valid non-negative quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Ticket ticket = new Ticket
            {
                TicketID = int.Parse(txtTicketID.Text),
                EventID = selectedEventID,
                TicketType = txtTickettype.Text,
                Price = price,
                Quantity = quantity
            };

            ticketService.UpdateTicket(ticket);
            MessageBox.Show("Ticket updated successfully!");
            LoadTicketsToGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ticketID = int.Parse(txtTicketID.Text);
            ticketService.DeleteTicket(ticketID, selectedEventID);
            MessageBox.Show("Ticket deleted successfully!");
            LoadTicketsToGrid();
        }

    }
}
