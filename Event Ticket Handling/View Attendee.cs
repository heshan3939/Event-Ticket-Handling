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

namespace Event_Ticket_Handling
{
    public partial class View_Attendee : Form
    {
        private AttendeeService attendeeService;
        public View_Attendee()
        {
            InitializeComponent();
            attendeeService = new AttendeeService();
        }

        private void dgvAttendees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_Attendee_Load(object sender, EventArgs e)
        {
            
           
            LoadEvents();
        }

        private void cmbEvents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadEvents()
        {
            EventService eventService = new EventService();
            DataTable dt = eventService.GetAllEvents(); // This method must return EventID and EventName
            cmbEvents.DataSource = dt;
            cmbEvents.DisplayMember = "EventName";
            cmbEvents.ValueMember = "EventID";
        }

        private void btnShowAttendees_Click(object sender, EventArgs e)
        {
            if (cmbEvents.SelectedValue != null)
            {
                int eventId = Convert.ToInt32(cmbEvents.SelectedValue);
                AttendeeService attendeeService = new AttendeeService();
                DataTable dt = attendeeService.GetAttendeesByEvent(eventId);
                dgvAttendees.DataSource = dt;
            }
        }
    }
}
