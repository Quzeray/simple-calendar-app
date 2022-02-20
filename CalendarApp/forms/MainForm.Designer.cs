namespace CalendarApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.menuBorder1 = new System.Windows.Forms.Panel();
            this.panelActivity = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.switchActivityButton = new System.Windows.Forms.Button();
            this.menuBorder2 = new System.Windows.Forms.Panel();
            this.dateTimer = new System.Windows.Forms.Timer(this.components);
            this.mainLayout.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.White;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.titleLabel.Size = new System.Drawing.Size(784, 80);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Текст";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.titleLabel, 0, 0);
            this.mainLayout.Controls.Add(this.menuBorder1, 0, 1);
            this.mainLayout.Controls.Add(this.panelActivity, 0, 2);
            this.mainLayout.Controls.Add(this.panelButtons, 0, 4);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Margin = new System.Windows.Forms.Padding(0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 5;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.Size = new System.Drawing.Size(784, 761);
            this.mainLayout.TabIndex = 2;
            // 
            // menuBorder1
            // 
            this.menuBorder1.BackColor = System.Drawing.Color.Silver;
            this.menuBorder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuBorder1.Location = new System.Drawing.Point(0, 80);
            this.menuBorder1.Margin = new System.Windows.Forms.Padding(0);
            this.menuBorder1.Name = "menuBorder1";
            this.menuBorder1.Size = new System.Drawing.Size(784, 1);
            this.menuBorder1.TabIndex = 2;
            // 
            // panelActivity
            // 
            this.panelActivity.AutoScroll = true;
            this.panelActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActivity.Location = new System.Drawing.Point(0, 81);
            this.panelActivity.Margin = new System.Windows.Forms.Padding(0);
            this.panelActivity.Name = "panelActivity";
            this.panelActivity.Size = new System.Drawing.Size(784, 579);
            this.panelActivity.TabIndex = 4;
            // 
            // panelButtons
            // 
            this.panelButtons.AutoSize = true;
            this.panelButtons.Controls.Add(this.addButton);
            this.panelButtons.Controls.Add(this.switchActivityButton);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(0, 661);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(784, 100);
            this.panelButtons.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(50, 30);
            this.addButton.Margin = new System.Windows.Forms.Padding(50, 30, 0, 0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 40);
            this.addButton.TabIndex = 0;
            this.addButton.TabStop = false;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddActivity);
            // 
            // switchActivityButton
            // 
            this.switchActivityButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.switchActivityButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.switchActivityButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.switchActivityButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.switchActivityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchActivityButton.Location = new System.Drawing.Point(220, 30);
            this.switchActivityButton.Margin = new System.Windows.Forms.Padding(50, 30, 0, 0);
            this.switchActivityButton.Name = "switchActivityButton";
            this.switchActivityButton.Size = new System.Drawing.Size(120, 40);
            this.switchActivityButton.TabIndex = 0;
            this.switchActivityButton.TabStop = false;
            this.switchActivityButton.Text = "Показать всё";
            this.switchActivityButton.UseVisualStyleBackColor = false;
            this.switchActivityButton.Click += new System.EventHandler(this.SwitchClick);
            // 
            // menuBorder2
            // 
            this.menuBorder2.AutoSize = true;
            this.menuBorder2.BackColor = System.Drawing.Color.Silver;
            this.menuBorder2.Location = new System.Drawing.Point(0, 659);
            this.menuBorder2.Margin = new System.Windows.Forms.Padding(0);
            this.menuBorder2.Name = "menuBorder2";
            this.menuBorder2.Size = new System.Drawing.Size(784, 1);
            this.menuBorder2.TabIndex = 3;
            // 
            // dateTimer
            // 
            this.dateTimer.Enabled = true;
            this.dateTimer.Interval = 1000;
            this.dateTimer.Tick += new System.EventHandler(this.TimeUpdate);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.menuBorder2);
            this.Controls.Add(this.mainLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Календарь";
            this.Resize += new System.EventHandler(this.BorderResize);
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Panel menuBorder1;
        private System.Windows.Forms.Panel menuBorder2;
        private System.Windows.Forms.Panel panelActivity;
        private System.Windows.Forms.Timer dateTimer;
        private System.Windows.Forms.FlowLayoutPanel panelButtons;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button switchActivityButton;
    }
}

