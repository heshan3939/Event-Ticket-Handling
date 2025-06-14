namespace Event_Ticket_Handling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Login adminLogin = new Admin_Login();
            adminLogin.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Attendee_Login attendee_Login = new Attendee_Login();
            attendee_Login.Show();
        }
    }
}
