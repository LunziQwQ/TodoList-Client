namespace TodoList
{
    partial class SignInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.textbox_username1 = new System.Windows.Forms.TextBox();
            this.textbox_password1 = new System.Windows.Forms.TextBox();
            this.btn_signin = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label_username1 = new System.Windows.Forms.Label();
            this.label_password1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_signin = new System.Windows.Forms.TabPage();
            this.tab_SignUp = new System.Windows.Forms.TabPage();
            this.label_username2 = new System.Windows.Forms.Label();
            this.label_password2 = new System.Windows.Forms.Label();
            this.label_password3 = new System.Windows.Forms.Label();
            this.btn_signup = new System.Windows.Forms.Button();
            this.textbox_username2 = new System.Windows.Forms.TextBox();
            this.textbox_password2 = new System.Windows.Forms.TextBox();
            this.textbox_password3 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tab_signin.SuspendLayout();
            this.tab_SignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // textbox_username1
            // 
            this.textbox_username1.Location = new System.Drawing.Point(126, 41);
            this.textbox_username1.Name = "textbox_username1";
            this.textbox_username1.Size = new System.Drawing.Size(100, 32);
            this.textbox_username1.TabIndex = 0;
            // 
            // textbox_password1
            // 
            this.textbox_password1.Location = new System.Drawing.Point(126, 93);
            this.textbox_password1.MaxLength = 32;
            this.textbox_password1.Name = "textbox_password1";
            this.textbox_password1.Size = new System.Drawing.Size(100, 32);
            this.textbox_password1.TabIndex = 1;
            // 
            // btn_signin
            // 
            this.btn_signin.Font = new System.Drawing.Font("SimSun", 13F);
            this.btn_signin.Location = new System.Drawing.Point(261, 67);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(84, 37);
            this.btn_signin.TabIndex = 23;
            this.btn_signin.Text = "SignIn";
            this.btn_signin.UseVisualStyleBackColor = true;
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // btn_close
            // 
            this.btn_close.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_close.Location = new System.Drawing.Point(312, -11);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_close.Size = new System.Drawing.Size(95, 48);
            this.btn_close.TabIndex = 24;
            this.btn_close.Text = "×";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            this.btn_close.MouseEnter += new System.EventHandler(this.btn_close_MouseEnter);
            this.btn_close.MouseLeave += new System.EventHandler(this.btn_close_MouseLeave);
            // 
            // label_username1
            // 
            this.label_username1.AutoSize = true;
            this.label_username1.Font = new System.Drawing.Font("SimSun", 13F);
            this.label_username1.Location = new System.Drawing.Point(21, 44);
            this.label_username1.Name = "label_username1";
            this.label_username1.Size = new System.Drawing.Size(109, 22);
            this.label_username1.TabIndex = 25;
            this.label_username1.Text = "username:";
            // 
            // label_password1
            // 
            this.label_password1.AutoSize = true;
            this.label_password1.Font = new System.Drawing.Font("SimSun", 13F);
            this.label_password1.Location = new System.Drawing.Point(21, 96);
            this.label_password1.Name = "label_password1";
            this.label_password1.Size = new System.Drawing.Size(109, 22);
            this.label_password1.TabIndex = 26;
            this.label_password1.Text = "password:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_signin);
            this.tabControl1.Controls.Add(this.tab_SignUp);
            this.tabControl1.Font = new System.Drawing.Font("SimSun", 13F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(387, 211);
            this.tabControl1.TabIndex = 27;
            // 
            // tab_signin
            // 
            this.tab_signin.Controls.Add(this.textbox_password1);
            this.tab_signin.Controls.Add(this.textbox_username1);
            this.tab_signin.Controls.Add(this.label_username1);
            this.tab_signin.Controls.Add(this.btn_signin);
            this.tab_signin.Controls.Add(this.label_password1);
            this.tab_signin.Location = new System.Drawing.Point(4, 32);
            this.tab_signin.Name = "tab_signin";
            this.tab_signin.Padding = new System.Windows.Forms.Padding(3);
            this.tab_signin.Size = new System.Drawing.Size(379, 175);
            this.tab_signin.TabIndex = 0;
            this.tab_signin.Text = "SignIn";
            this.tab_signin.UseVisualStyleBackColor = true;
            // 
            // tab_SignUp
            // 
            this.tab_SignUp.Controls.Add(this.textbox_password3);
            this.tab_SignUp.Controls.Add(this.textbox_password2);
            this.tab_SignUp.Controls.Add(this.textbox_username2);
            this.tab_SignUp.Controls.Add(this.btn_signup);
            this.tab_SignUp.Controls.Add(this.label_password3);
            this.tab_SignUp.Controls.Add(this.label_username2);
            this.tab_SignUp.Controls.Add(this.label_password2);
            this.tab_SignUp.Location = new System.Drawing.Point(4, 32);
            this.tab_SignUp.Name = "tab_SignUp";
            this.tab_SignUp.Padding = new System.Windows.Forms.Padding(3);
            this.tab_SignUp.Size = new System.Drawing.Size(379, 175);
            this.tab_SignUp.TabIndex = 1;
            this.tab_SignUp.Text = "SignUp";
            this.tab_SignUp.UseVisualStyleBackColor = true;
            // 
            // label_username2
            // 
            this.label_username2.AutoSize = true;
            this.label_username2.Font = new System.Drawing.Font("SimSun", 13F);
            this.label_username2.Location = new System.Drawing.Point(20, 23);
            this.label_username2.Name = "label_username2";
            this.label_username2.Size = new System.Drawing.Size(109, 22);
            this.label_username2.TabIndex = 29;
            this.label_username2.Text = "username:";
            // 
            // label_password2
            // 
            this.label_password2.AutoSize = true;
            this.label_password2.Font = new System.Drawing.Font("SimSun", 13F);
            this.label_password2.Location = new System.Drawing.Point(20, 78);
            this.label_password2.Name = "label_password2";
            this.label_password2.Size = new System.Drawing.Size(109, 22);
            this.label_password2.TabIndex = 30;
            this.label_password2.Text = "password:";
            // 
            // label_password3
            // 
            this.label_password3.Font = new System.Drawing.Font("SimSun", 13F);
            this.label_password3.Location = new System.Drawing.Point(20, 107);
            this.label_password3.Name = "label_password3";
            this.label_password3.Size = new System.Drawing.Size(109, 68);
            this.label_password3.TabIndex = 32;
            this.label_password3.Text = "enter password again:";
            // 
            // btn_signup
            // 
            this.btn_signup.Location = new System.Drawing.Point(271, 50);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(85, 79);
            this.btn_signup.TabIndex = 33;
            this.btn_signup.Text = "SignUp";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // textbox_username2
            // 
            this.textbox_username2.Location = new System.Drawing.Point(152, 20);
            this.textbox_username2.Name = "textbox_username2";
            this.textbox_username2.Size = new System.Drawing.Size(100, 32);
            this.textbox_username2.TabIndex = 34;
            // 
            // textbox_password2
            // 
            this.textbox_password2.Location = new System.Drawing.Point(152, 75);
            this.textbox_password2.Name = "textbox_password2";
            this.textbox_password2.Size = new System.Drawing.Size(100, 32);
            this.textbox_password2.TabIndex = 35;
            // 
            // textbox_password3
            // 
            this.textbox_password3.Location = new System.Drawing.Point(152, 132);
            this.textbox_password3.Name = "textbox_password3";
            this.textbox_password3.Size = new System.Drawing.Size(100, 32);
            this.textbox_password3.TabIndex = 36;
            // 
            // SignInForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(411, 235);
            this.ControlBox = false;
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.tabControl1.ResumeLayout(false);
            this.tab_signin.ResumeLayout(false);
            this.tab_signin.PerformLayout();
            this.tab_SignUp.ResumeLayout(false);
            this.tab_SignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_username1;
        private System.Windows.Forms.TextBox textbox_password1;
        private System.Windows.Forms.Button btn_signin;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label_username1;
        private System.Windows.Forms.Label label_password1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_signin;
        private System.Windows.Forms.TabPage tab_SignUp;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Label label_password3;
        private System.Windows.Forms.Label label_username2;
        private System.Windows.Forms.Label label_password2;
        private System.Windows.Forms.TextBox textbox_password3;
        private System.Windows.Forms.TextBox textbox_password2;
        private System.Windows.Forms.TextBox textbox_username2;
    }
}