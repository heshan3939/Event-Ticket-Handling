namespace Event_Ticket_Handling
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
            btnRefresh = new Button();
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
            btnAddevent.Location = new Point(21, 304);
            btnAddevent.Name = "btnAddevent";
            btnAddevent.Size = new Size(160, 49);
            btnAddevent.TabIndex = 0;
            btnAddevent.Text = "ADD";
            btnAddevent.UseVisualStyleBackColor = true;
            btnAddevent.Click += btnAddevent_Click;
            // 
            // btnUpdateevent
            // 
            btnUpdateevent.Location = new Point(199, 309);
            btnUpdateevent.Name = "btnUpdateevent";
            btnUpdateevent.Size = new Size(160, 44);
            btnUpdateevent.TabIndex = 1;
            btnUpdateevent.Text = "UPDATE";
            btnUpdateevent.UseVisualStyleBackColor = true;
            btnUpdateevent.Click += btnUpdateevent_Click;
            // 
            // btnDeleteevent
            // 
            btnDeleteevent.Location = new Point(21, 381);
            btnDeleteevent.Name = "btnDeleteevent";
            btnDeleteevent.Size = new Size(160, 44);
            btnDeleteevent.TabIndex = 2;
            btnDeleteevent.Text = "DELETE";
            btnDeleteevent.UseVisualStyleBackColor = true;
            btnDeleteevent.Click += btnDeleteevent_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(199, 381);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(160, 44);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 35);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 4;
            label1.Text = "Event Name";
            // 
            // txtEventName
            // 
            txtEventName.Location = new Point(178, 35);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(125, 27);
            txtEventName.TabIndex = 5;
            // 
            // txtEventID
            // 
            txtEventID.Location = new Point(178, 84);
            txtEventID.Name = "txtEventID";
            txtEventID.Size = new Size(125, 27);
            txtEventID.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 84);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 6;
            label2.Text = "Event ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 146);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 8;
            label3.Text = "Date";
            // 
            // txtVenue
            // 
            txtVenue.Location = new Point(178, 193);
            txtVenue.Name = "txtVenue";
            txtVenue.Size = new Size(125, 27);
            txtVenue.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 200);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 10;
            label4.Text = "Veneua";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(178, 245);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 252);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 12;
            label5.Text = "Description";
            // 
            // dataGridViewEvents
            // 
            dataGridViewEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEvents.Location = new Point(375, 12);
            dataGridViewEvents.Name = "dataGridViewEvents";
            dataGridViewEvents.RowHeadersWidth = 51;
            dataGridViewEvents.Size = new Size(623, 279);
            dataGridViewEvents.TabIndex = 14;
            dataGridViewEvents.CellContentClick += dataGridViewEvents_CellContentClick;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(128, 146);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(219, 27);
            txtDate.TabIndex = 15;
            txtDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnManagetickets
            // 
            btnManagetickets.Location = new Point(603, 335);
            btnManagetickets.Name = "btnManagetickets";
            btnManagetickets.Size = new Size(239, 61);
            btnManagetickets.TabIndex = 16;
            btnManagetickets.Text = "MANAGE TICKETS";
            btnManagetickets.UseVisualStyleBackColor = true;
            btnManagetickets.Click += btnManagetickets_Click;
            // 
            // Event_Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 450);
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
            Controls.Add(btnRefresh);
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
        private Button btnRefresh;
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