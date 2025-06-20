﻿namespace Event_Ticket_Handling
{
    partial class Event_Manager
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
            btnAddevent = new Button();
            btnUpdateevent = new Button();
            btnDeleteevent = new Button();
            label1 = new Label();
            txtEventName = new TextBox();
            txtEventID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtVenue = new TextBox();
            label4 = new Label();
            txtDescription = new TextBox();
            label5 = new Label();
            dataGridViewEvents = new DataGridView();
            txtDate = new DateTimePicker();
            btnManagetickets = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).BeginInit();
            SuspendLayout();
            // 
            // btnAddevent
            // 
            btnAddevent.BackColor = Color.LimeGreen;
            btnAddevent.Location = new Point(25, 359);
            btnAddevent.Name = "btnAddevent";
            btnAddevent.Size = new Size(160, 49);
            btnAddevent.TabIndex = 0;
            btnAddevent.Text = "ADD";
            btnAddevent.UseVisualStyleBackColor = false;
            btnAddevent.Click += btnAddevent_Click;
            // 
            // btnUpdateevent
            // 
            btnUpdateevent.BackColor = Color.Orange;
            btnUpdateevent.Location = new Point(191, 359);
            btnUpdateevent.Name = "btnUpdateevent";
            btnUpdateevent.Size = new Size(167, 49);
            btnUpdateevent.TabIndex = 1;
            btnUpdateevent.Text = "UPDATE";
            btnUpdateevent.UseVisualStyleBackColor = false;
            btnUpdateevent.Click += btnUpdateevent_Click;
            // 
            // btnDeleteevent
            // 
            btnDeleteevent.BackColor = Color.Red;
            btnDeleteevent.Location = new Point(97, 430);
            btnDeleteevent.Name = "btnDeleteevent";
            btnDeleteevent.Size = new Size(160, 44);
            btnDeleteevent.TabIndex = 2;
            btnDeleteevent.Text = "DELETE";
            btnDeleteevent.UseVisualStyleBackColor = false;
            btnDeleteevent.Click += btnDeleteevent_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 59);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 4;
            label1.Text = "Event Name";
            // 
            // txtEventName
            // 
            txtEventName.Location = new Point(178, 59);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(125, 27);
            txtEventName.TabIndex = 5;
            // 
            // txtEventID
            // 
            txtEventID.Location = new Point(178, 114);
            txtEventID.Name = "txtEventID";
            txtEventID.Size = new Size(125, 27);
            txtEventID.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 114);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 6;
            label2.Text = "Event ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 176);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 8;
            label3.Text = "Date";
            // 
            // txtVenue
            // 
            txtVenue.Location = new Point(178, 225);
            txtVenue.Name = "txtVenue";
            txtVenue.Size = new Size(125, 27);
            txtVenue.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 232);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 10;
            label4.Text = "Venue";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(178, 280);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 287);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 12;
            label5.Text = "Description";
            // 
            // dataGridViewEvents
            // 
            dataGridViewEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEvents.Location = new Point(377, 42);
            dataGridViewEvents.Name = "dataGridViewEvents";
            dataGridViewEvents.ReadOnly = true;
            dataGridViewEvents.RowHeadersWidth = 51;
            dataGridViewEvents.Size = new Size(655, 297);
            dataGridViewEvents.TabIndex = 14;
            dataGridViewEvents.CellContentClick += dataGridViewEvents_CellContentClick;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(139, 176);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(219, 27);
            txtDate.TabIndex = 15;
            txtDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnManagetickets
            // 
            btnManagetickets.BackColor = Color.MediumTurquoise;
            btnManagetickets.Location = new Point(584, 422);
            btnManagetickets.Name = "btnManagetickets";
            btnManagetickets.Size = new Size(239, 61);
            btnManagetickets.TabIndex = 16;
            btnManagetickets.Text = "MANAGE TICKETS";
            btnManagetickets.UseVisualStyleBackColor = false;
            btnManagetickets.Click += btnManagetickets_Click;
            // 
            // Event_Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(1063, 540);
            Controls.Add(btnManagetickets);
            Controls.Add(txtDate);
            Controls.Add(dataGridViewEvents);
            Controls.Add(txtDescription);
            Controls.Add(label5);
            Controls.Add(txtVenue);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtEventID);
            Controls.Add(label2);
            Controls.Add(txtEventName);
            Controls.Add(label1);
            Controls.Add(btnDeleteevent);
            Controls.Add(btnUpdateevent);
            Controls.Add(btnAddevent);
            Name = "Event_Manager";
            Text = "Event_Manager";
            Load += Event_Manager_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddevent;
        private Button btnUpdateevent;
        private Button btnDeleteevent;
        private Label label1;
        private TextBox txtEventName;
        private TextBox txtEventID;
        private Label label2;
        private Label label3;
        private TextBox txtVenue;
        private Label label4;
        private TextBox txtDescription;
        private Label label5;
        private DataGridView dataGridViewEvents;
        private DateTimePicker txtDate;
        private Button btnManagetickets;
    }
}