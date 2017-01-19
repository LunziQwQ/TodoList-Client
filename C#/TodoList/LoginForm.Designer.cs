namespace TodoList
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
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.LoginMessageBox = new System.Windows.Forms.TextBox();
            this.ConnectTest = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(30, 49);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(100, 25);
            this.UserName.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(30, 105);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 25);
            this.Password.TabIndex = 1;
            // 
            // LoginMessageBox
            // 
            this.LoginMessageBox.BackColor = System.Drawing.SystemColors.Control;
            this.LoginMessageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginMessageBox.Location = new System.Drawing.Point(30, 216);
            this.LoginMessageBox.Multiline = true;
            this.LoginMessageBox.Name = "LoginMessageBox";
            this.LoginMessageBox.Size = new System.Drawing.Size(290, 141);
            this.LoginMessageBox.TabIndex = 2;
            // 
            // ConnectTest
            // 
            this.ConnectTest.Location = new System.Drawing.Point(245, 129);
            this.ConnectTest.Name = "ConnectTest";
            this.ConnectTest.Size = new System.Drawing.Size(75, 23);
            this.ConnectTest.TabIndex = 23;
            this.ConnectTest.Text = "button1";
            this.ConnectTest.UseVisualStyleBackColor = true;
            this.ConnectTest.Click += new System.EventHandler(this.ConnectTest_Click);
            // 
            // btn_close
            // 
            this.btn_close.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_close.Location = new System.Drawing.Point(258, -13);
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
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 383);
            this.ControlBox = false;
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.ConnectTest);
            this.Controls.Add(this.LoginMessageBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox LoginMessageBox;
        private System.Windows.Forms.Button ConnectTest;
        private System.Windows.Forms.Button btn_close;
    }
}