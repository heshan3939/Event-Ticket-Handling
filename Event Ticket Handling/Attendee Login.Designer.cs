namespace Event_Ticket_Handling
{
    partial class Attendee_Login
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
            label1 = new Label();
            label2 = new Label();
            txtUseremail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegistration = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 103);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 200);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txtUseremail
            // 
            txtUseremail.Location = new Point(324, 103);
            txtUseremail.Name = "txtUseremail";
            txtUseremail.Size = new Size(125, 27);
            txtUseremail.TabIndex = 2;
            txtUseremail.TextChanged += textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(324, 200);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SandyBrown;
            btnLogin.Location = new Point(314, 267);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(145, 49);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegistration
            // 
            btnRegistration.BackColor = Color.SandyBrown;
            btnRegistration.Location = new Point(247, 341);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(275, 47);
            btnRegistration.TabIndex = 5;
            btnRegistration.Text = "Don't have an account? Register here";
            btnRegistration.UseVisualStyleBackColor = false;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // Attendee_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistration);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUseremail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Attendee_Login";
            Text = "Attendee_Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUseremail;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegistration;
    }
}