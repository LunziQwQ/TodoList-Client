namespace TodoList {
    partial class noticeForm {
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
            this.NoticeText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NoticeText
            // 
            this.NoticeText.AllowDrop = true;
            this.NoticeText.AutoEllipsis = true;
            this.NoticeText.AutoSize = true;
            this.NoticeText.Location = new System.Drawing.Point(14, 31);
            this.NoticeText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NoticeText.Name = "NoticeText";
            this.NoticeText.Size = new System.Drawing.Size(41, 21);
            this.NoticeText.TabIndex = 0;
            this.NoticeText.Text = "Test";
            this.NoticeText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // noticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 85);
            this.Controls.Add(this.NoticeText);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "noticeForm";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Notice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NoticeText;
    }
}