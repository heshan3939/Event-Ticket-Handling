using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Event_Ticket_Handling.Models;
using Event_Ticket_Handling.Classes;
namespace Event_Ticket_Handling.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public int EventID { get; set; }
        public string TicketType { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Ticket() { }

      
    }
}
