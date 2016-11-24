namespace TodoList {
    partial class NoticeForm {
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
            this.components = new System.ComponentModel.Container();
            this.NoticeText = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // NoticeText
            // 
            this.NoticeText.AllowDrop = true;
            this.NoticeText.AutoEllipsis = true;
            this.NoticeText.BackColor = System.Drawing.Color.Transparent;
            this.NoticeText.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NoticeText.Location = new System.Drawing.Point(14, 9);
            this.NoticeText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NoticeText.Name = "NoticeText";
            this.NoticeText.Size = new System.Drawing.Size(348, 67);
            this.NoticeText.TabIndex = 0;
            this.NoticeText.Text = "This is the noticeForm";
            this.NoticeText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NoticeText.Click += new System.EventHandler(this.noticeForm_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 10;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // NoticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TodoList.Properties.Resources.NoticeBackImage;
            this.ClientSize = new System.Drawing.Size(380, 85);
            this.Controls.Add(this.NoticeText);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "NoticeForm";
            this.Opacity = 0.95D;
            this.Text = "Notice";
            this.Click += new System.EventHandler(this.noticeForm_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NoticeText;
        private System.Windows.Forms.Timer Timer;
    }
}