namespace RegistrationForm
{
    partial class frm_register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_id = new TextBox();
            lbl_id = new Label();
            lbl_name = new Label();
            txt_name = new TextBox();
            lbl_age = new Label();
            lbl_email = new Label();
            lbl_pass = new Label();
            txt_age = new TextBox();
            txt_email = new TextBox();
            txt_pass = new TextBox();
            cb_dept = new ComboBox();
            lbl_dept = new Label();
            btn_register = new Button();
            btn_login = new Button();
            SuspendLayout();
            // 
            // txt_id
            // 
            txt_id.Location = new Point(296, 53);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(108, 23);
            txt_id.TabIndex = 1;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(218, 56);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(17, 15);
            lbl_id.TabIndex = 2;
            lbl_id.Text = "Id";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(218, 93);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(37, 15);
            lbl_name.TabIndex = 3;
            lbl_name.Text = "name";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(296, 90);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(108, 23);
            txt_name.TabIndex = 4;
            // 
            // lbl_age
            // 
            lbl_age.AutoSize = true;
            lbl_age.Location = new Point(218, 134);
            lbl_age.Name = "lbl_age";
            lbl_age.Size = new Size(26, 15);
            lbl_age.TabIndex = 5;
            lbl_age.Text = "age";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(218, 180);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(36, 15);
            lbl_email.TabIndex = 6;
            lbl_email.Text = "email";
            // 
            // lbl_pass
            // 
            lbl_pass.AutoSize = true;
            lbl_pass.Location = new Point(218, 221);
            lbl_pass.Name = "lbl_pass";
            lbl_pass.Size = new Size(57, 15);
            lbl_pass.TabIndex = 7;
            lbl_pass.Text = "Password";
            // 
            // txt_age
            // 
            txt_age.Location = new Point(296, 131);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(108, 23);
            txt_age.TabIndex = 9;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(296, 177);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(108, 23);
            txt_email.TabIndex = 10;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(296, 218);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(108, 23);
            txt_pass.TabIndex = 11;
            // 
            // cb_dept
            // 
            cb_dept.FormattingEnabled = true;
            cb_dept.Location = new Point(296, 272);
            cb_dept.Name = "cb_dept";
            cb_dept.Size = new Size(108, 23);
            cb_dept.TabIndex = 12;
            // 
            // lbl_dept
            // 
            lbl_dept.AutoSize = true;
            lbl_dept.Location = new Point(218, 275);
            lbl_dept.Name = "lbl_dept";
            lbl_dept.Size = new Size(70, 15);
            lbl_dept.TabIndex = 13;
            lbl_dept.Text = "Department";
            // 
            // btn_register
            // 
            btn_register.Location = new Point(218, 326);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(186, 30);
            btn_register.TabIndex = 14;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(218, 362);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(186, 31);
            btn_login.TabIndex = 15;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // frm_register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_login);
            Controls.Add(btn_register);
            Controls.Add(lbl_dept);
            Controls.Add(cb_dept);
            Controls.Add(txt_pass);
            Controls.Add(txt_email);
            Controls.Add(txt_age);
            Controls.Add(lbl_pass);
            Controls.Add(lbl_email);
            Controls.Add(lbl_age);
            Controls.Add(txt_name);
            Controls.Add(lbl_name);
            Controls.Add(lbl_id);
            Controls.Add(txt_id);
            Name = "frm_register";
            Text = "Register";
            Load += frm_register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_id;
        private Label lbl_id;
        private Label lbl_name;
        private TextBox txt_name;
        private Label lbl_age;
        private Label lbl_email;
        private Label lbl_pass;
        private TextBox txt_age;
        private TextBox txt_email;
        private TextBox txt_pass;
        private ComboBox cb_dept;
        private Label lbl_dept;
        private Button btn_register;
        private Button btn_login;
    }
}
