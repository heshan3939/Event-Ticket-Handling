namespace Event_Ticket_Handling
{
    partial class My_Tickets
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
            dgvMyTickets = new DataGridView();
            btnCancelTicket = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMyTickets).BeginInit();
            SuspendLayout();
            // 
            // dgvMyTickets
            // 
            dgvMyTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMyTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyTickets.Location = new Point(66, 90);
            dgvMyTickets.Name = "dgvMyTickets";
            dgvMyTickets.ReadOnly = true;
            dgvMyTickets.RowHeadersWidth = 51;
            dgvMyTickets.Size = new Size(800, 208);
            dgvMyTickets.TabIndex = 0;
            // 
            // btnCancelTicket
            // 
            btnCancelTicket.BackColor = Color.SandyBrown;
            btnCancelTicket.Location = new Point(398, 351);
            btnCancelTicket.Name = "btnCancelTicket";
            btnCancelTicket.Size = new Size(161, 45);
            btnCancelTicket.TabIndex = 1;
            btnCancelTicket.Text = "CANCEL TICKET";
            btnCancelTicket.UseVisualStyleBackColor = false;
            btnCancelTicket.Click += btnCancelTicket_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(407, 33);
            label1.Name = "label1";
            label1.Size = new Size(122, 31);
            label1.TabIndex = 2;
            label1.Text = "My Tickets";
            // 
            // My_Tickets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(917, 450);
            Controls.Add(label1);
            Controls.Add(btnCancelTicket);
            Controls.Add(dgvMyTickets);
            Name = "My_Tickets";
            Text = "My_Tickets";
            Load += My_Tickets_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMyTickets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMyTickets;
        private Button btnCancelTicket;
        private Label label1;
    }
}