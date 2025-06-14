namespace Event_Ticket_Handling
{
    partial class AttendeeDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new Label();
            label1 = new Label();
            dgvEvents = new DataGridView();
            btnRegisterForEvent = new Button();
            btnViewMyTickets = new Button();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEvents).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(326, 34);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(186, 20);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "WELCOME! attendee name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(364, 102);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 1;
            label1.Text = "Available Events";
            // 
            // dgvEvents
            // 
            dgvEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvents.Location = new Point(68, 152);
            dgvEvents.Name = "dgvEvents";
            dgvEvents.ReadOnly = true;
            dgvEvents.RowHeadersWidth = 51;
            dgvEvents.Size = new Size(724, 188);
            dgvEvents.TabIndex = 2;
            // 
            // btnRegisterForEvent
            // 
            btnRegisterForEvent.BackColor = Color.DarkSalmon;
            btnRegisterForEvent.Location = new Point(162, 386);
            btnRegisterForEvent.Name = "btnRegisterForEvent";
            btnRegisterForEvent.Size = new Size(188, 55);
            btnRegisterForEvent.TabIndex = 3;
            btnRegisterForEvent.Text = "REGISTER FOR EVENT";
            btnRegisterForEvent.UseVisualStyleBackColor = false;
            btnRegisterForEvent.Click += button1_Click;
            // 
            // btnViewMyTickets
            // 
            btnViewMyTickets.BackColor = Color.DarkSalmon;
            btnViewMyTickets.Location = new Point(435, 386);
            btnViewMyTickets.Name = "btnViewMyTickets";
            btnViewMyTickets.Size = new Size(188, 55);
            btnViewMyTickets.TabIndex = 4;
            btnViewMyTickets.Text = "VIEW MY TICKETS";
            btnViewMyTickets.UseVisualStyleBackColor = false;
            btnViewMyTickets.Click += button2_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.Location = new Point(685, 34);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(123, 52);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // AttendeeDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(833, 495);
            Controls.Add(btnLogout);
            Controls.Add(btnViewMyTickets);
            Controls.Add(btnRegisterForEvent);
            Controls.Add(dgvEvents);
            Controls.Add(label1);
            Controls.Add(lblWelcome);
            Name = "AttendeeDashboard";
            Text = "AttendeeDashboard";
            Load += AttendeeDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEvents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label label1;
        private DataGridView dgvEvents;
        private Button btnRegisterForEvent;
        private Button btnViewMyTickets;
        private Button btnLogout;
    }
}