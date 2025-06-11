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
    public partial class View_Sales : Form
    {
        private SalesService salesService;
        public View_Sales()
        {
            InitializeComponent();
            salesService = new SalesService();
        }
        private void View_Sales_Load(object sender, EventArgs e)
        {
            LoadEvents();
        }
       
        private void LoadEvents()
        {
            EventService eventService = new EventService();
            DataTable dt = eventService.GetAllEvents(); // Method to return EventID & EventName
            cmbEvents.DataSource = dt;
            cmbEvents.DisplayMember = "EventName";
            cmbEvents.ValueMember = "EventID";
        }


        private void dgvsales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void View_Sales_Load_1(object sender, EventArgs e)
        {
            LoadEvents();
        }

        private void btnShowAttendees_Click(object sender, EventArgs e)
        {
            if (cmbEvents.SelectedValue != null)
            {
                int eventId = Convert.ToInt32(cmbEvents.SelectedValue);
                SalesService salesService = new SalesService();
                DataTable dt = salesService.GetSalesByEvent(eventId);
                dgvsales.DataSource = dt;
            }
        }
    }
}
