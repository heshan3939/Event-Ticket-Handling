namespace Event_Ticket_Handling
{
    partial class Admin_Dashboard
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
            btnManageevent = new Button();
            btnManageattendees = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnManageevent
            // 
            btnManageevent.BackColor = Color.DarkSalmon;
            btnManageevent.Location = new Point(337, 65);
            btnManageevent.Name = "btnManageevent";
            btnManageevent.Size = new Size(172, 56);
            btnManageevent.TabIndex = 0;
            btnManageevent.Text = "MANAGE EVENTS";
            btnManageevent.UseVisualStyleBackColor = false;
            btnManageevent.Click += button1_Click;
            // 
            // btnManageattendees
            // 
            btnManageattendees.BackColor = Color.DarkSalmon;
            btnManageattendees.Location = new Point(337, 174);
            btnManageattendees.Name = "btnManageattendees";
            btnManageattendees.Size = new Size(172, 67);
            btnManageattendees.TabIndex = 2;
            btnManageattendees.Text = "VIEW ATTENDEES";
            btnManageattendees.UseVisualStyleBackColor = false;
            btnManageattendees.Click += btnManageattendees_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSalmon;
            button1.Location = new Point(337, 290);
            button1.Name = "button1";
            button1.Size = new Size(172, 55);
            button1.TabIndex = 3;
            button1.Text = "VIEW SALES\r\n\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnManageattendees);
            Controls.Add(btnManageevent);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Admin_Dashboard";
            Text = "Admin_Dashboard";
            Load += Admin_Dashboard_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnManageevent;
        private Button btnManageattendees;
        private Button button1;
    }
}