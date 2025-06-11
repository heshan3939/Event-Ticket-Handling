using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Event_Ticket_Handling.Classes;

namespace Event_Ticket_Handling
{
    public partial class Event_Manager : Form
    {
        private EventService eventService;
        public Event_Manager()
        {
            InitializeComponent();
            eventService = new EventService();
        }

        private void Event_Manager_Load(object sender, EventArgs e)
        {
            LoadEvents();
        }

        private void LoadEvents()
        {
            DataTable dt = eventService.GetAllEvents();
            dataGridViewEvents.DataSource = dt;
        }

        private void btnAddevent_Click(object sender, EventArgs e)
        {
            Event ev = new Event
            {
                EventName = txtEventName.Text,
                Date = txtDate.Value.Date,
                Venue = txtVenue.Text,
                Description = txtDescription.Text
            };

            if (eventService.AddEvent(ev))
            {
                MessageBox.Show("Event added successfully!");
                LoadEvents();
            }
        }



        private void btnUpdateevent_Click(object sender, EventArgs e)
        {
            Event ev = new Event
            {
                EventID = int.Parse(txtEventID.Text),
                EventName = txtEventName.Text,
                Date = txtDate.Value.Date,
                Venue = txtVenue.Text,
                Description = txtDescription.Text
            };

            if (eventService.UpdateEvent(ev))
            {
                MessageBox.Show("Event updated successfully!");
                LoadEvents();
            }
            else
            {
                MessageBox.Show("Update failed.");
            }
        }




        private void btnDeleteevent_Click(object sender, EventArgs e)
        {
            int eventId = int.Parse(txtEventID.Text);
            if (eventService.DeleteEvent(eventId))
            {
                MessageBox.Show("Event deleted successfully!");
                LoadEvents();
            }
            else
            {
                MessageBox.Show("Delete failed.");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadEvents();
        }




        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewEvents.Rows[e.RowIndex];

                txtEventID.Text = row.Cells["EventID"].Value.ToString();
                txtEventName.Text = row.Cells["EventName"].Value.ToString();
                txtDate.Value = Convert.ToDateTime(row.Cells["Date"].Value);
                txtVenue.Text = row.Cells["Venue"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
            }
        }

        private void btnManagetickets_Click(object sender, EventArgs e)
        {
            if (dataGridViewEvents.CurrentRow != null)
            {
                int eventID = Convert.ToInt32(dataGridViewEvents.CurrentRow.Cells["EventID"].Value);
                string eventName = dataGridViewEvents.CurrentRow.Cells["EventName"].Value.ToString();

                Ticket_Manager ticketForm = new Ticket_Manager(eventID, eventName);
                ticketForm.Show();
            }
            else
            {
                MessageBox.Show("Please select an event to manage tickets.");
            }
        }
    }
}
