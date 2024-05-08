namespace RegistrationForm
{
    partial class LoginForm
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
            txt_email = new TextBox();
            txt_pass = new TextBox();
            btn_login = new Button();
            lbl_error = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 160);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 213);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(374, 152);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(91, 23);
            txt_email.TabIndex = 2;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(374, 205);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(91, 23);
            txt_pass.TabIndex = 3;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(395, 261);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(70, 24);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.BackColor = Color.Firebrick;
            lbl_error.Location = new Point(395, 119);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(0, 15);
            lbl_error.TabIndex = 5;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_error);
            Controls.Add(btn_login);
            Controls.Add(txt_pass);
            Controls.Add(txt_email);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_email;
        private TextBox txt_pass;
        private Button btn_login;
        private Label lbl_error;
    }
}