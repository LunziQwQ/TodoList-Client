namespace TodoList {
    partial class ItemEditForm {
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
            this.editText = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.btn_isStar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_isStar)).BeginInit();
            this.SuspendLayout();
            // 
            // editText
            // 
            this.editText.Location = new System.Drawing.Point(51, 27);
            this.editText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editText.Multiline = true;
            this.editText.Name = "editText";
            this.editText.Size = new System.Drawing.Size(367, 36);
            this.editText.TabIndex = 0;
            this.editText.TextChanged += new System.EventHandler(this.editText_TextChanged);
            this.editText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editText_KeyPress);
            // 
            // btn_confirm
            // 
            this.btn_confirm.AutoSize = true;
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.Location = new System.Drawing.Point(81, 119);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(93, 27);
            this.btn_confirm.TabIndex = 1;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(315, 119);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(78, 27);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_isStar
            // 
            this.btn_isStar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_isStar.Location = new System.Drawing.Point(213, 80);
            this.btn_isStar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_isStar.Name = "btn_isStar";
            this.btn_isStar.Size = new System.Drawing.Size(43, 41);
            this.btn_isStar.TabIndex = 4;
            this.btn_isStar.TabStop = false;
            this.btn_isStar.Click += new System.EventHandler(this.btn_isStar_Click);
            // 
            // ItemEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 166);
            this.ControlBox = false;
            this.Controls.Add(this.btn_isStar);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.editText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ItemEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemEdit";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ItemEditForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ItemEditForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ItemEditForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.btn_isStar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editText;
        private System.Windows.Forms.Label btn_confirm;
        private System.Windows.Forms.Label btn_cancel;
        private System.Windows.Forms.PictureBox btn_isStar;
    }
}