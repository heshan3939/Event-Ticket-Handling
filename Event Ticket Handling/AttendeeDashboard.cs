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

namespace Event_Ticket_Handling
{
    public partial class AttendeeDashboard : Form
    {
        string fullname;
        int attendeeId;
        public AttendeeDashboard(string name, int id)
        {
            InitializeComponent();
            fullname = name;
            attendeeId = id;
        }

        private void button1_Click(object sender, EventArgs e)//register for event
        {
            if (dgvEvents.SelectedRows.Count > 0)
            {
                int selectedEventId = Convert.ToInt32(dgvEvents.SelectedRows[0].Cells["EventID"].Value);
                Ticket_Purchase purchaseForm = new Ticket_Purchase(selectedEventId, attendeeId, this);
                purchaseForm.Show();

            }
            else
            {
                MessageBox.Show("Please select an event first.");
            }
        }

        private void AttendeeDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "WELCOME! " + fullname;

            try
            {
                EventService service = new EventService();
                dgvEvents.DataSource = service.GetAllEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading events: " + ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            My_Tickets ticketsForm = new My_Tickets(attendeeId);
            ticketsForm.Show();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            AttendeeHelper.Logout(this);

        }
    }
}
