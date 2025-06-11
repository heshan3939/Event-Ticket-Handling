namespace Event_Ticket_Handling
{
    partial class View_Sales
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
            dgvsales = new DataGridView();
            btnShowAttendees = new Button();
            label1 = new Label();
            cmbEvents = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvsales).BeginInit();
            SuspendLayout();
            // 
            // dgvsales
            // 
            dgvsales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsales.Location = new Point(101, 127);
            dgvsales.Name = "dgvsales";
            dgvsales.RowHeadersWidth = 51;
            dgvsales.Size = new Size(597, 302);
            dgvsales.TabIndex = 0;
            dgvsales.CellContentClick += dgvsales_CellContentClick;
            // 
            // btnShowAttendees
            // 
            btnShowAttendees.Location = new Point(483, 47);
            btnShowAttendees.Name = "btnShowAttendees";
            btnShowAttendees.Size = new Size(133, 29);
            btnShowAttendees.TabIndex = 6;
            btnShowAttendees.Text = "View Sales";
            btnShowAttendees.UseVisualStyleBackColor = true;
            btnShowAttendees.Click += btnShowAttendees_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 47);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 5;
            label1.Text = "Select Event";
            // 
            // cmbEvents
            // 
            cmbEvents.FormattingEnabled = true;
            cmbEvents.Location = new Point(326, 47);
            cmbEvents.Name = "cmbEvents";
            cmbEvents.Size = new Size(151, 28);
            cmbEvents.TabIndex = 4;
            // 
            // View_Sales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowAttendees);
            Controls.Add(label1);
            Controls.Add(cmbEvents);
            Controls.Add(dgvsales);
            Name = "View_Sales";
            Text = "View_Sales";
            Load += View_Sales_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvsales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvsales;
        private Button btnShowAttendees;
        private Label label1;
        private ComboBox cmbEvents;
    }
}