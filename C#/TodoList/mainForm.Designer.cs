namespace TodoList {
    partial class MainForm {
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
            this.components = new System.ComponentModel.Container();
            this.btn_close = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TaskItem1 = new System.Windows.Forms.Label();
            this.TaskItem2 = new System.Windows.Forms.Label();
            this.TaskItem3 = new System.Windows.Forms.Label();
            this.TaskItem4 = new System.Windows.Forms.Label();
            this.TaskItem5 = new System.Windows.Forms.Label();
            this.PageIndex = new System.Windows.Forms.Label();
            this.btn_pgUp = new System.Windows.Forms.Button();
            this.btn_pgDn = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.mainFormTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_del1 = new System.Windows.Forms.Label();
            this.btn_edit1 = new System.Windows.Forms.Label();
            this.btn_edit2 = new System.Windows.Forms.Label();
            this.btn_del2 = new System.Windows.Forms.Label();
            this.btn_edit3 = new System.Windows.Forms.Label();
            this.btn_del3 = new System.Windows.Forms.Label();
            this.btn_edit4 = new System.Windows.Forms.Label();
            this.btn_del4 = new System.Windows.Forms.Label();
            this.btn_edit5 = new System.Windows.Forms.Label();
            this.btn_del5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_close.Location = new System.Drawing.Point(274, 0);
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
            // TaskItem1
            // 
            this.TaskItem1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TaskItem1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaskItem1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskItem1.ForeColor = System.Drawing.Color.Black;
            this.TaskItem1.Location = new System.Drawing.Point(6, 61);
            this.TaskItem1.Margin = new System.Windows.Forms.Padding(0);
            this.TaskItem1.Name = "TaskItem1";
            this.TaskItem1.Size = new System.Drawing.Size(322, 65);
            this.TaskItem1.TabIndex = 3;
            this.TaskItem1.Text = "undefined";
            this.TaskItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TaskItem1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TaskItem1_MouseClick);
            this.TaskItem1.MouseLeave += new System.EventHandler(this.TaskItem1_MouseLeave);
            this.TaskItem1.MouseHover += new System.EventHandler(this.TaskItem1_MouseHover);
            // 
            // TaskItem2
            // 
            this.TaskItem2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TaskItem2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaskItem2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskItem2.ForeColor = System.Drawing.Color.Black;
            this.TaskItem2.Location = new System.Drawing.Point(6, 135);
            this.TaskItem2.Margin = new System.Windows.Forms.Padding(0);
            this.TaskItem2.Name = "TaskItem2";
            this.TaskItem2.Size = new System.Drawing.Size(322, 65);
            this.TaskItem2.TabIndex = 4;
            this.TaskItem2.Text = "undefined";
            this.TaskItem2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TaskItem2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TaskItem2_MouseClick);
            this.TaskItem2.MouseLeave += new System.EventHandler(this.TaskItem2_MouseLeave);
            this.TaskItem2.MouseHover += new System.EventHandler(this.TaskItem2_MouseHover);
            // 
            // TaskItem3
            // 
            this.TaskItem3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TaskItem3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaskItem3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskItem3.ForeColor = System.Drawing.Color.Black;
            this.TaskItem3.Location = new System.Drawing.Point(6, 207);
            this.TaskItem3.Margin = new System.Windows.Forms.Padding(0);
            this.TaskItem3.Name = "TaskItem3";
            this.TaskItem3.Size = new System.Drawing.Size(322, 65);
            this.TaskItem3.TabIndex = 5;
            this.TaskItem3.Text = "undefined";
            this.TaskItem3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TaskItem3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TaskItem3_MouseClick);
            this.TaskItem3.MouseLeave += new System.EventHandler(this.TaskItem3_MouseLeave);
            this.TaskItem3.MouseHover += new System.EventHandler(this.TaskItem3_MouseHover);
            // 
            // TaskItem4
            // 
            this.TaskItem4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TaskItem4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaskItem4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskItem4.ForeColor = System.Drawing.Color.Black;
            this.TaskItem4.Location = new System.Drawing.Point(6, 280);
            this.TaskItem4.Margin = new System.Windows.Forms.Padding(0);
            this.TaskItem4.Name = "TaskItem4";
            this.TaskItem4.Size = new System.Drawing.Size(322, 65);
            this.TaskItem4.TabIndex = 6;
            this.TaskItem4.Text = "undefined";
            this.TaskItem4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TaskItem4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TaskItem4_MouseClick);
            this.TaskItem4.MouseLeave += new System.EventHandler(this.TaskItem4_MouseLeave);
            this.TaskItem4.MouseHover += new System.EventHandler(this.TaskItem4_MouseHover);
            // 
            // TaskItem5
            // 
            this.TaskItem5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TaskItem5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaskItem5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskItem5.ForeColor = System.Drawing.Color.Black;
            this.TaskItem5.Location = new System.Drawing.Point(6, 354);
            this.TaskItem5.Margin = new System.Windows.Forms.Padding(0);
            this.TaskItem5.Name = "TaskItem5";
            this.TaskItem5.Size = new System.Drawing.Size(322, 65);
            this.TaskItem5.TabIndex = 7;
            this.TaskItem5.Text = "undefined";
            this.TaskItem5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TaskItem5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TaskItem5_MouseClick);
            this.TaskItem5.MouseLeave += new System.EventHandler(this.TaskItem5_MouseLeave);
            this.TaskItem5.MouseHover += new System.EventHandler(this.TaskItem5_MouseHover);
            // 
            // PageIndex
            // 
            this.PageIndex.BackColor = System.Drawing.Color.Transparent;
            this.PageIndex.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PageIndex.ForeColor = System.Drawing.Color.DimGray;
            this.PageIndex.Location = new System.Drawing.Point(125, 430);
            this.PageIndex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PageIndex.Name = "PageIndex";
            this.PageIndex.Size = new System.Drawing.Size(75, 19);
            this.PageIndex.TabIndex = 8;
            this.PageIndex.Text = "1  ·  ·  ·  · ";
            this.PageIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_pgUp
            // 
            this.btn_pgUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pgUp.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pgUp.ForeColor = System.Drawing.Color.DimGray;
            this.btn_pgUp.Location = new System.Drawing.Point(286, 458);
            this.btn_pgUp.Margin = new System.Windows.Forms.Padding(2);
            this.btn_pgUp.Name = "btn_pgUp";
            this.btn_pgUp.Size = new System.Drawing.Size(38, 32);
            this.btn_pgUp.TabIndex = 10;
            this.btn_pgUp.Text = "→";
            this.btn_pgUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_pgUp.UseVisualStyleBackColor = true;
            this.btn_pgUp.Click += new System.EventHandler(this.btn_pgUp_Click);
            // 
            // btn_pgDn
            // 
            this.btn_pgDn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pgDn.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pgDn.ForeColor = System.Drawing.Color.DimGray;
            this.btn_pgDn.Location = new System.Drawing.Point(244, 458);
            this.btn_pgDn.Margin = new System.Windows.Forms.Padding(2);
            this.btn_pgDn.Name = "btn_pgDn";
            this.btn_pgDn.Size = new System.Drawing.Size(38, 32);
            this.btn_pgDn.TabIndex = 9;
            this.btn_pgDn.Text = "←";
            this.btn_pgDn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_pgDn.UseVisualStyleBackColor = true;
            this.btn_pgDn.Click += new System.EventHandler(this.btn_pgDn_Click);
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.DimGray;
            this.btn_add.Location = new System.Drawing.Point(10, 458);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(38, 32);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // mainFormTimer
            // 
            this.mainFormTimer.Enabled = true;
            this.mainFormTimer.Interval = 10;
            this.mainFormTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_del1
            // 
            this.btn_del1.BackColor = System.Drawing.Color.Tomato;
            this.btn_del1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del1.Location = new System.Drawing.Point(192, 61);
            this.btn_del1.Name = "btn_del1";
            this.btn_del1.Size = new System.Drawing.Size(70, 65);
            this.btn_del1.TabIndex = 12;
            this.btn_del1.Text = "Delete";
            this.btn_del1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_del1.Click += new System.EventHandler(this.btn_del1_Click);
            // 
            // btn_edit1
            // 
            this.btn_edit1.BackColor = System.Drawing.Color.Gray;
            this.btn_edit1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_edit1.Location = new System.Drawing.Point(262, 61);
            this.btn_edit1.Name = "btn_edit1";
            this.btn_edit1.Size = new System.Drawing.Size(66, 65);
            this.btn_edit1.TabIndex = 13;
            this.btn_edit1.Text = "Edit";
            this.btn_edit1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_edit1.Click += new System.EventHandler(this.btn_edit1_Click);
            // 
            // btn_edit2
            // 
            this.btn_edit2.BackColor = System.Drawing.Color.Gray;
            this.btn_edit2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_edit2.Location = new System.Drawing.Point(262, 135);
            this.btn_edit2.Name = "btn_edit2";
            this.btn_edit2.Size = new System.Drawing.Size(66, 65);
            this.btn_edit2.TabIndex = 15;
            this.btn_edit2.Text = "Edit";
            this.btn_edit2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_edit2.Click += new System.EventHandler(this.btn_edit2_Click);
            // 
            // btn_del2
            // 
            this.btn_del2.BackColor = System.Drawing.Color.Tomato;
            this.btn_del2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del2.Location = new System.Drawing.Point(192, 135);
            this.btn_del2.Name = "btn_del2";
            this.btn_del2.Size = new System.Drawing.Size(70, 65);
            this.btn_del2.TabIndex = 14;
            this.btn_del2.Text = "Delete";
            this.btn_del2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_del2.Click += new System.EventHandler(this.btn_del2_Click);
            // 
            // btn_edit3
            // 
            this.btn_edit3.BackColor = System.Drawing.Color.Gray;
            this.btn_edit3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_edit3.Location = new System.Drawing.Point(262, 207);
            this.btn_edit3.Name = "btn_edit3";
            this.btn_edit3.Size = new System.Drawing.Size(66, 65);
            this.btn_edit3.TabIndex = 17;
            this.btn_edit3.Text = "Edit";
            this.btn_edit3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_edit3.Click += new System.EventHandler(this.btn_edit3_Click);
            // 
            // btn_del3
            // 
            this.btn_del3.BackColor = System.Drawing.Color.Tomato;
            this.btn_del3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del3.Location = new System.Drawing.Point(192, 207);
            this.btn_del3.Name = "btn_del3";
            this.btn_del3.Size = new System.Drawing.Size(70, 65);
            this.btn_del3.TabIndex = 16;
            this.btn_del3.Text = "Delete";
            this.btn_del3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_del3.Click += new System.EventHandler(this.btn_del3_Click);
            // 
            // btn_edit4
            // 
            this.btn_edit4.BackColor = System.Drawing.Color.Gray;
            this.btn_edit4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_edit4.Location = new System.Drawing.Point(262, 280);
            this.btn_edit4.Name = "btn_edit4";
            this.btn_edit4.Size = new System.Drawing.Size(66, 65);
            this.btn_edit4.TabIndex = 19;
            this.btn_edit4.Text = "Edit";
            this.btn_edit4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_edit4.Click += new System.EventHandler(this.btn_edit4_Click);
            // 
            // btn_del4
            // 
            this.btn_del4.BackColor = System.Drawing.Color.Tomato;
            this.btn_del4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del4.Location = new System.Drawing.Point(192, 280);
            this.btn_del4.Name = "btn_del4";
            this.btn_del4.Size = new System.Drawing.Size(70, 65);
            this.btn_del4.TabIndex = 18;
            this.btn_del4.Text = "Delete";
            this.btn_del4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_del4.Click += new System.EventHandler(this.btn_del4_Click);
            // 
            // btn_edit5
            // 
            this.btn_edit5.BackColor = System.Drawing.Color.Gray;
            this.btn_edit5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_edit5.Location = new System.Drawing.Point(262, 354);
            this.btn_edit5.Name = "btn_edit5";
            this.btn_edit5.Size = new System.Drawing.Size(66, 65);
            this.btn_edit5.TabIndex = 21;
            this.btn_edit5.Text = "Edit";
            this.btn_edit5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_edit5.Click += new System.EventHandler(this.btn_edit5_Click);
            // 
            // btn_del5
            // 
            this.btn_del5.BackColor = System.Drawing.Color.Tomato;
            this.btn_del5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del5.Location = new System.Drawing.Point(192, 354);
            this.btn_del5.Name = "btn_del5";
            this.btn_del5.Size = new System.Drawing.Size(70, 65);
            this.btn_del5.TabIndex = 20;
            this.btn_del5.Text = "Delete";
            this.btn_del5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_del5.Click += new System.EventHandler(this.btn_del5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 500);
            this.Controls.Add(this.btn_edit5);
            this.Controls.Add(this.btn_del5);
            this.Controls.Add(this.btn_edit4);
            this.Controls.Add(this.btn_del4);
            this.Controls.Add(this.btn_edit3);
            this.Controls.Add(this.btn_del3);
            this.Controls.Add(this.btn_edit2);
            this.Controls.Add(this.btn_del2);
            this.Controls.Add(this.btn_edit1);
            this.Controls.Add(this.btn_del1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_pgUp);
            this.Controls.Add(this.btn_pgDn);
            this.Controls.Add(this.PageIndex);
            this.Controls.Add(this.TaskItem5);
            this.Controls.Add(this.TaskItem4);
            this.Controls.Add(this.TaskItem3);
            this.Controls.Add(this.TaskItem2);
            this.Controls.Add(this.TaskItem1);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.btn_close);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TodoList";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label TaskItem1;
        private System.Windows.Forms.Label TaskItem2;
        private System.Windows.Forms.Label TaskItem3;
        private System.Windows.Forms.Label TaskItem4;
        private System.Windows.Forms.Label TaskItem5;
        private System.Windows.Forms.Label PageIndex;
        private System.Windows.Forms.Button btn_pgUp;
        private System.Windows.Forms.Button btn_pgDn;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Timer mainFormTimer;
        private System.Windows.Forms.Label btn_del1;
        private System.Windows.Forms.Label btn_edit1;
        private System.Windows.Forms.Label btn_edit2;
        private System.Windows.Forms.Label btn_del2;
        private System.Windows.Forms.Label btn_edit3;
        private System.Windows.Forms.Label btn_del3;
        private System.Windows.Forms.Label btn_edit4;
        private System.Windows.Forms.Label btn_del4;
        private System.Windows.Forms.Label btn_edit5;
        private System.Windows.Forms.Label btn_del5;
    }
}

