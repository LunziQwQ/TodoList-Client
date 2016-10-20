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
            this.TaskItem1 = new System.Windows.Forms.Label();
            this.TaskItem2 = new System.Windows.Forms.Label();
            this.TaskItem3 = new System.Windows.Forms.Label();
            this.TaskItem4 = new System.Windows.Forms.Label();
            this.TaskItem5 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_pgUp = new System.Windows.Forms.Button();
            this.btn_pgDn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_close.Location = new System.Drawing.Point(365, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_close.Name = "btn_close";
            this.btn_close.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_close.Size = new System.Drawing.Size(83, 41);
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
            this.TitleLabel.Location = new System.Drawing.Point(15, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(135, 32);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "TodoList";
            // 
            // TaskItem1
            // 
            this.TaskItem1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TaskItem1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaskItem1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskItem1.ForeColor = System.Drawing.Color.Black;
            this.TaskItem1.Location = new System.Drawing.Point(8, 75);
            this.TaskItem1.Margin = new System.Windows.Forms.Padding(0);
            this.TaskItem1.Name = "TaskItem1";
            this.TaskItem1.Size = new System.Drawing.Size(430, 80);
            this.TaskItem1.TabIndex = 3;
            this.TaskItem1.Text = "今天三点去厚德楼";
            this.TaskItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TaskItem1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TaskItem2
            // 
            this.TaskItem2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TaskItem2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaskItem2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskItem2.ForeColor = System.Drawing.Color.Black;
            this.TaskItem2.Location = new System.Drawing.Point(8, 166);
            this.TaskItem2.Margin = new System.Windows.Forms.Padding(0);
            this.TaskItem2.Name = "TaskItem2";
            this.TaskItem2.Size = new System.Drawing.Size(430, 80);
            this.TaskItem2.TabIndex = 4;
            this.TaskItem2.Text = "今天三点去厚德楼";
            this.TaskItem2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TaskItem3
            // 
            this.TaskItem3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TaskItem3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaskItem3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskItem3.ForeColor = System.Drawing.Color.Black;
            this.TaskItem3.Location = new System.Drawing.Point(8, 255);
            this.TaskItem3.Margin = new System.Windows.Forms.Padding(0);
            this.TaskItem3.Name = "TaskItem3";
            this.TaskItem3.Size = new System.Drawing.Size(430, 80);
            this.TaskItem3.TabIndex = 5;
            this.TaskItem3.Text = "今天三点去厚德楼";
            this.TaskItem3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TaskItem4
            // 
            this.TaskItem4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TaskItem4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaskItem4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskItem4.ForeColor = System.Drawing.Color.Black;
            this.TaskItem4.Location = new System.Drawing.Point(6, 344);
            this.TaskItem4.Margin = new System.Windows.Forms.Padding(0);
            this.TaskItem4.Name = "TaskItem4";
            this.TaskItem4.Size = new System.Drawing.Size(430, 80);
            this.TaskItem4.TabIndex = 6;
            this.TaskItem4.Text = "今天三点去厚德楼";
            this.TaskItem4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TaskItem5
            // 
            this.TaskItem5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TaskItem5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaskItem5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskItem5.ForeColor = System.Drawing.Color.Black;
            this.TaskItem5.Location = new System.Drawing.Point(8, 436);
            this.TaskItem5.Margin = new System.Windows.Forms.Padding(0);
            this.TaskItem5.Name = "TaskItem5";
            this.TaskItem5.Size = new System.Drawing.Size(430, 80);
            this.TaskItem5.TabIndex = 7;
            this.TaskItem5.Text = "今天三点去厚德楼";
            this.TaskItem5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(167, 529);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "1  ·  ·  ·  · ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_pgUp
            // 
            this.btn_pgUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pgUp.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pgUp.ForeColor = System.Drawing.Color.DimGray;
            this.btn_pgUp.Location = new System.Drawing.Point(382, 564);
            this.btn_pgUp.Name = "btn_pgUp";
            this.btn_pgUp.Size = new System.Drawing.Size(51, 40);
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
            this.btn_pgDn.Location = new System.Drawing.Point(325, 564);
            this.btn_pgDn.Name = "btn_pgDn";
            this.btn_pgDn.Size = new System.Drawing.Size(51, 40);
            this.btn_pgDn.TabIndex = 9;
            this.btn_pgDn.Text = "←";
            this.btn_pgDn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_pgDn.UseVisualStyleBackColor = true;
            this.btn_pgDn.Click += new System.EventHandler(this.btn_pgDn_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DimGray;
            this.button4.Location = new System.Drawing.Point(14, 564);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 40);
            this.button4.TabIndex = 11;
            this.button4.Text = "S";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 616);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_pgUp);
            this.Controls.Add(this.btn_pgDn);
            this.Controls.Add(this.label5);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.Opacity = 0.95D;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_pgUp;
        private System.Windows.Forms.Button btn_pgDn;
        private System.Windows.Forms.Button button4;
    }
}

