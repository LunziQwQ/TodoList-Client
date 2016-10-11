namespace TodoList {
    partial class mainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            this.btn_close = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TaskList = new System.Windows.Forms.GroupBox();
            this.TaskItem1 = new System.Windows.Forms.Label();
            this.TaskList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_close.Location = new System.Drawing.Point(267, -1);
            this.btn_close.Name = "btn_close";
            this.btn_close.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_close.Size = new System.Drawing.Size(62, 33);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "×";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            this.btn_close.MouseEnter += new System.EventHandler(this.btn_close_MouseEnter);
            this.btn_close.MouseLeave += new System.EventHandler(this.btn_close_MouseLeave);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.DimGray;
            this.TitleLabel.Location = new System.Drawing.Point(11, 7);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(106, 24);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "TodoList";
            // 
            // TaskList
            // 
            this.TaskList.BackColor = System.Drawing.Color.Transparent;
            this.TaskList.Controls.Add(this.TaskItem1);
            this.TaskList.ForeColor = System.Drawing.Color.Transparent;
            this.TaskList.Location = new System.Drawing.Point(15, 38);
            this.TaskList.Name = "TaskList";
            this.TaskList.Size = new System.Drawing.Size(301, 395);
            this.TaskList.TabIndex = 2;
            this.TaskList.TabStop = false;
            // 
            // TaskItem1
            // 
            this.TaskItem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TaskItem1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskItem1.ForeColor = System.Drawing.Color.Black;
            this.TaskItem1.Location = new System.Drawing.Point(3, 16);
            this.TaskItem1.Margin = new System.Windows.Forms.Padding(0);
            this.TaskItem1.Name = "TaskItem1";
            this.TaskItem1.Size = new System.Drawing.Size(295, 55);
            this.TaskItem1.TabIndex = 0;
            this.TaskItem1.Text = "今天三点去厚德楼";
            this.TaskItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(328, 445);
            this.Controls.Add(this.TaskList);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.btn_close);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.Opacity = 0.95D;
            this.Text = "TodoList";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseUp);
            this.TaskList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.GroupBox TaskList;
        private System.Windows.Forms.Label TaskItem1;
    }
}

