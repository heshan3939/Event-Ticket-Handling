namespace Event_Ticket_Handling
{
    partial class Ticket_Manager
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
            lblEventName = new Label();
            dataGridViewTickets = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTicketID = new TextBox();
            txtTickettype = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTickets).BeginInit();
            SuspendLayout();
            // 
            // lblEventName
            // 
            lblEventName.AutoSize = true;
            lblEventName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEventName.Location = new Point(478, 26);
            lblEventName.Name = "lblEventName";
            lblEventName.Size = new Size(76, 31);
            lblEventName.TabIndex = 0;
            lblEventName.Text = "label1";
            lblEventName.Click += label1_Click;
            // 
            // dataGridViewTickets
            // 
            dataGridViewTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTickets.Location = new Point(97, 80);
            dataGridViewTickets.Name = "dataGridViewTickets";
            dataGridViewTickets.ReadOnly = true;
            dataGridViewTickets.RowHeadersWidth = 51;
            dataGridViewTickets.Size = new Size(870, 206);
            dataGridViewTickets.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 308);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 2;
            label2.Text = "Ticket ID";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 354);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 3;
            label3.Text = "Ticket type";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(132, 396);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 4;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(132, 435);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 5;
            label5.Text = "Quantity";
            // 
            // txtTicketID
            // 
            txtTicketID.Location = new Point(245, 305);
            txtTicketID.Name = "txtTicketID";
            txtTicketID.Size = new Size(125, 27);
            txtTicketID.TabIndex = 6;
            // 
            // txtTickettype
            // 
            txtTickettype.Location = new Point(245, 351);
            txtTickettype.Name = "txtTickettype";
            txtTickettype.Size = new Size(125, 27);
            txtTickettype.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(245, 396);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(245, 435);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LimeGreen;
            btnAdd.Location = new Point(510, 322);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 56);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Chocolate;
            btnEdit.Location = new Point(673, 325);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(132, 53);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.Location = new Point(587, 406);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(152, 56);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Ticket_Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(1015, 504);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtTickettype);
            Controls.Add(txtTicketID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridViewTickets);
            Controls.Add(lblEventName);
            Name = "Ticket_Manager";
            Text = "Ticket_Manager";
            Load += Ticket_Manager_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTickets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEventName;
        private DataGridView dataGridViewTickets;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTicketID;
        private TextBox txtTickettype;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}