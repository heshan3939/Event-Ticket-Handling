namespace Event_Ticket_Handling
{
    partial class Ticket_Purchase
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
            btnLogout = new Button();
            btnViewMyTickets = new Button();
            btnBuyTckets = new Button();
            dgvTickets = new DataGridView();
            label1 = new Label();
            lblWelcome = new Label();
            txtQuantity = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(647, 22);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(123, 52);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnViewMyTickets
            // 
            btnViewMyTickets.Location = new Point(485, 319);
            btnViewMyTickets.Name = "btnViewMyTickets";
            btnViewMyTickets.Size = new Size(188, 55);
            btnViewMyTickets.TabIndex = 10;
            btnViewMyTickets.Text = "VIEW MY TICKETS";
            btnViewMyTickets.UseVisualStyleBackColor = true;
            btnViewMyTickets.Click += btnViewMyTickets_Click;
            // 
            // btnBuyTckets
            // 
            btnBuyTckets.Location = new Point(123, 366);
            btnBuyTckets.Name = "btnBuyTckets";
            btnBuyTckets.Size = new Size(188, 55);
            btnBuyTckets.TabIndex = 9;
            btnBuyTckets.Text = "BUY TICKETS";
            btnBuyTckets.UseVisualStyleBackColor = true;
            btnBuyTckets.Click += btnBuyTckets_Click;
            // 
            // dgvTickets
            // 
            dgvTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTickets.Location = new Point(46, 93);
            dgvTickets.Name = "dgvTickets";
            dgvTickets.RowHeadersWidth = 51;
            dgvTickets.Size = new Size(724, 188);
            dgvTickets.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 38);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 7;
            label1.Text = "Available Tickets";
            label1.Click += label1_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(288, 22);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 20);
            lblWelcome.TabIndex = 6;
            lblWelcome.Click += lblWelcome_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(195, 316);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 316);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 13;
            label2.Text = "Enter Quantity";
            // 
            // Ticket_Purchase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtQuantity);
            Controls.Add(btnLogout);
            Controls.Add(btnViewMyTickets);
            Controls.Add(btnBuyTckets);
            Controls.Add(dgvTickets);
            Controls.Add(label1);
            Controls.Add(lblWelcome);
            Name = "Ticket_Purchase";
            Text = "Ticket_Purchase";
            Load += Ticket_Purchase_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private Button btnViewMyTickets;
        private Button btnBuyTckets;
        private DataGridView dgvTickets;
        private Label label1;
        private Label lblWelcome;
        private TextBox txtQuantity;
        private Label label2;
    }
}