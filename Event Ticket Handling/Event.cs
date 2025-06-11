using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Event_Ticket_Handling.Classes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

using MySql.Data.MySqlClient;

namespace Event_Ticket_Handling
{
    public class Event
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public DateTime Date { get; set; }
        public string Venue { get; set; }
        public string Description { get; set; }

        public Event() { }

        
    }
}

