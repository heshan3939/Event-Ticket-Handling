namespace Event_Ticket_Handling
{
    partial class Attendee_Registration
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
            btnRegister = new Button();
            txtConfirmPassword = new TextBox();
            txtUseremail = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtPassword = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SandyBrown;
            btnRegister.Location = new Point(333, 332);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(151, 50);
            btnRegister.TabIndex = 23;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(426, 250);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(125, 27);
            txtConfirmPassword.TabIndex = 22;
            // 
            // txtUseremail
            // 
            txtUseremail.Location = new Point(426, 150);
            txtUseremail.Name = "txtUseremail";
            txtUseremail.Size = new Size(125, 27);
            txtUseremail.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 253);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 20;
            label3.Text = "Confirm Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(287, 153);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 19;
            label4.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(426, 198);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 18;
            // 
            // txtName
            // 
            txtName.Location = new Point(426, 101);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 205);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 16;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(287, 101);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 15;
            label1.Text = "Name";
            // 
            // Attendee_Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtUseremail);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Attendee_Registration";
            Text = "Attendee_Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private TextBox txtConfirmPassword;
        private TextBox txtUseremail;
        private Label label3;
        private Label label4;
        private TextBox txtPassword;
        private TextBox txtName;
        private Label label2;
        private Label label1;
    }
}