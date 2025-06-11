namespace Event_Ticket_Handling
{
    partial class View_Attendee
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
            dgvAttendees = new DataGridView();
            cmbEvents = new ComboBox();
            label1 = new Label();
            btnShowAttendees = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAttendees).BeginInit();
            SuspendLayout();
            // 
            // dgvAttendees
            // 
            dgvAttendees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendees.Location = new Point(53, 85);
            dgvAttendees.Name = "dgvAttendees";
            dgvAttendees.RowHeadersWidth = 51;
            dgvAttendees.Size = new Size(702, 338);
            dgvAttendees.TabIndex = 0;
            dgvAttendees.CellContentClick += dgvAttendees_CellContentClick;
            // 
            // cmbEvents
            // 
            cmbEvents.FormattingEnabled = true;
            cmbEvents.Location = new Point(373, 31);
            cmbEvents.Name = "cmbEvents";
            cmbEvents.Size = new Size(151, 28);
            cmbEvents.TabIndex = 1;
            cmbEvents.SelectedIndexChanged += cmbEvents_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 31);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 2;
            label1.Text = "Select Event";
            // 
            // btnShowAttendees
            // 
            btnShowAttendees.Location = new Point(530, 31);
            btnShowAttendees.Name = "btnShowAttendees";
            btnShowAttendees.Size = new Size(133, 29);
            btnShowAttendees.TabIndex = 3;
            btnShowAttendees.Text = "Show Attendees";
            btnShowAttendees.UseVisualStyleBackColor = true;
            btnShowAttendees.Click += btnShowAttendees_Click;
            // 
            // View_Attendee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowAttendees);
            Controls.Add(label1);
            Controls.Add(cmbEvents);
            Controls.Add(dgvAttendees);
            Name = "View_Attendee";
            Text = "View_Attendee";
            Load += View_Attendee_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAttendees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAttendees;
        private ComboBox cmbEvents;
        private Label label1;
        private Button btnShowAttendees;
    }
}