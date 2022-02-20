namespace CalendarApp.forms
{
    partial class EditForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.activivtyCheckBox = new System.Windows.Forms.CheckBox();
            this.titleTextBox = new System.Windows.Forms.MaskedTextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.border1 = new System.Windows.Forms.Panel();
            this.border2 = new System.Windows.Forms.Panel();
            this.border3 = new System.Windows.Forms.Panel();
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(56, 16);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(111, 26);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Название";
            // 
            // activivtyCheckBox
            // 
            this.activivtyCheckBox.AutoSize = true;
            this.activivtyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activivtyCheckBox.Location = new System.Drawing.Point(24, 248);
            this.activivtyCheckBox.Name = "activivtyCheckBox";
            this.activivtyCheckBox.Size = new System.Drawing.Size(118, 21);
            this.activivtyCheckBox.TabIndex = 1;
            this.activivtyCheckBox.TabStop = false;
            this.activivtyCheckBox.Text = "Напоминание";
            this.activivtyCheckBox.UseVisualStyleBackColor = true;
            this.activivtyCheckBox.CheckedChanged += new System.EventHandler(this.ActivityChange);
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.titleTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.titleTextBox.Location = new System.Drawing.Point(16, 48);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(190, 22);
            this.titleTextBox.TabIndex = 3;
            this.titleTextBox.TabStop = false;
            this.titleTextBox.Text = "Новое событие";
            this.titleTextBox.Enter += new System.EventHandler(this.TextBoxFocus);
            this.titleTextBox.Leave += new System.EventHandler(this.TextBoxUnfocus);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Enabled = false;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(72, 176);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(79, 26);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "Время";
            // 
            // dateTextBox
            // 
            this.dateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.dateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dateTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.dateTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.dateTextBox.Location = new System.Drawing.Point(16, 128);
            this.dateTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.dateTextBox.Mask = "00/00";
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.PromptChar = 'ᅠ';
            this.dateTextBox.Size = new System.Drawing.Size(190, 22);
            this.dateTextBox.TabIndex = 3;
            this.dateTextBox.TabStop = false;
            this.dateTextBox.ValidatingType = typeof(System.DateTime);
            this.dateTextBox.TextChanged += new System.EventHandler(this.DisableChangeByBackspace);
            this.dateTextBox.Enter += new System.EventHandler(this.TextBoxFocus);
            this.dateTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SaveTextOnKeyPress);
            this.dateTextBox.Leave += new System.EventHandler(this.TextBoxUnfocus);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.Location = new System.Drawing.Point(80, 96);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(63, 26);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Дата";
            // 
            // timeTextBox
            // 
            this.timeTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.timeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeTextBox.Enabled = false;
            this.timeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.timeTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.timeTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.timeTextBox.Location = new System.Drawing.Point(16, 208);
            this.timeTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.PromptChar = 'ᅠ';
            this.timeTextBox.Size = new System.Drawing.Size(190, 22);
            this.timeTextBox.TabIndex = 3;
            this.timeTextBox.TabStop = false;
            this.timeTextBox.ValidatingType = typeof(System.DateTime);
            this.timeTextBox.TextChanged += new System.EventHandler(this.DisableChangeByBackspace);
            this.timeTextBox.Enter += new System.EventHandler(this.TextBoxFocus);
            this.timeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SaveTextOnKeyPress);
            this.timeTextBox.Leave += new System.EventHandler(this.TextBoxUnfocus);
            // 
            // border1
            // 
            this.border1.BackColor = System.Drawing.Color.Gainsboro;
            this.border1.Location = new System.Drawing.Point(16, 73);
            this.border1.Name = "border1";
            this.border1.Size = new System.Drawing.Size(190, 2);
            this.border1.TabIndex = 4;
            // 
            // border2
            // 
            this.border2.BackColor = System.Drawing.Color.Gainsboro;
            this.border2.Location = new System.Drawing.Point(16, 153);
            this.border2.Name = "border2";
            this.border2.Size = new System.Drawing.Size(190, 2);
            this.border2.TabIndex = 5;
            // 
            // border3
            // 
            this.border3.BackColor = System.Drawing.Color.Gainsboro;
            this.border3.Location = new System.Drawing.Point(16, 230);
            this.border3.Name = "border3";
            this.border3.Size = new System.Drawing.Size(190, 2);
            this.border3.TabIndex = 6;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.confirmButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.confirmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.confirmButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.confirmButton.Location = new System.Drawing.Point(50, 280);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(0);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(130, 40);
            this.confirmButton.TabIndex = 7;
            this.confirmButton.TabStop = false;
            this.confirmButton.Text = "Подтвердить";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.Confirm);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(224, 336);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.border3);
            this.Controls.Add(this.border2);
            this.Controls.Add(this.border1);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.activivtyCheckBox);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реадктирование";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.CheckBox activivtyCheckBox;
        private System.Windows.Forms.MaskedTextBox titleTextBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.MaskedTextBox dateTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.MaskedTextBox timeTextBox;
        private System.Windows.Forms.Panel border1;
        private System.Windows.Forms.Panel border2;
        private System.Windows.Forms.Panel border3;
        private System.Windows.Forms.Button confirmButton;
    }
}