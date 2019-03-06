namespace WindowsFormsApp1
{
    partial class Form1
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
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.adapterComboBox = new System.Windows.Forms.ComboBox();
            this.adapterLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.stopButton = new System.Windows.Forms.Button();
            this.addressesLabel = new System.Windows.Forms.Label();
            this.addressesListBox = new System.Windows.Forms.ListBox();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.communityTextBox = new System.Windows.Forms.TextBox();
            this.responseTextBox = new System.Windows.Forms.TextBox();
            this.hostLabel = new System.Windows.Forms.Label();
            this.communityLabel = new System.Windows.Forms.Label();
            this.askButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(9, 7);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(119, 17);
            this.checkBox.TabIndex = 0;
            this.checkBox.Text = "Ввести IP вручную";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // adapterComboBox
            // 
            this.adapterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.adapterComboBox.FormattingEnabled = true;
            this.adapterComboBox.Location = new System.Drawing.Point(9, 52);
            this.adapterComboBox.Name = "adapterComboBox";
            this.adapterComboBox.Size = new System.Drawing.Size(250, 21);
            this.adapterComboBox.TabIndex = 1;
            this.adapterComboBox.SelectedIndexChanged += new System.EventHandler(this.adapterComboBox_SelectedIndexChanged);
            // 
            // adapterLabel
            // 
            this.adapterLabel.AutoSize = true;
            this.adapterLabel.Location = new System.Drawing.Point(9, 36);
            this.adapterLabel.Name = "adapterLabel";
            this.adapterLabel.Size = new System.Drawing.Size(127, 13);
            this.adapterLabel.TabIndex = 2;
            this.adapterLabel.Text = "Выбрать сетевую карту";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(9, 89);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(169, 16);
            this.progressBar.TabIndex = 3;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(184, 79);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 33);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Стоп скан";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // addressesLabel
            // 
            this.addressesLabel.AutoSize = true;
            this.addressesLabel.Location = new System.Drawing.Point(12, 125);
            this.addressesLabel.Name = "addressesLabel";
            this.addressesLabel.Size = new System.Drawing.Size(79, 13);
            this.addressesLabel.TabIndex = 5;
            this.addressesLabel.Text = "Адреса в сети";
            // 
            // addressesListBox
            // 
            this.addressesListBox.FormattingEnabled = true;
            this.addressesListBox.Location = new System.Drawing.Point(12, 141);
            this.addressesListBox.Name = "addressesListBox";
            this.addressesListBox.Size = new System.Drawing.Size(247, 381);
            this.addressesListBox.TabIndex = 6;
            // 
            // hostTextBox
            // 
            this.hostTextBox.Enabled = false;
            this.hostTextBox.Location = new System.Drawing.Point(273, 27);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(155, 20);
            this.hostTextBox.TabIndex = 7;
            this.hostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hostTextBox_KeyPress);
            // 
            // communityTextBox
            // 
            this.communityTextBox.Location = new System.Drawing.Point(370, 53);
            this.communityTextBox.Name = "communityTextBox";
            this.communityTextBox.Size = new System.Drawing.Size(58, 20);
            this.communityTextBox.TabIndex = 8;
            // 
            // responseTextBox
            // 
            this.responseTextBox.Location = new System.Drawing.Point(273, 89);
            this.responseTextBox.Multiline = true;
            this.responseTextBox.Name = "responseTextBox";
            this.responseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.responseTextBox.Size = new System.Drawing.Size(271, 433);
            this.responseTextBox.TabIndex = 9;
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Enabled = false;
            this.hostLabel.Location = new System.Drawing.Point(270, 11);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(123, 13);
            this.hostLabel.TabIndex = 10;
            this.hostLabel.Text = "Имя устройства или IP";
            // 
            // communityLabel
            // 
            this.communityLabel.AutoSize = true;
            this.communityLabel.Location = new System.Drawing.Point(270, 56);
            this.communityLabel.Name = "communityLabel";
            this.communityLabel.Size = new System.Drawing.Size(94, 13);
            this.communityLabel.TabIndex = 11;
            this.communityLabel.Text = "Имя сообщества";
            // 
            // askButton
            // 
            this.askButton.Location = new System.Drawing.Point(434, 14);
            this.askButton.Name = "askButton";
            this.askButton.Size = new System.Drawing.Size(52, 69);
            this.askButton.TabIndex = 0;
            this.askButton.Text = "Спросить";
            this.askButton.UseVisualStyleBackColor = true;
            this.askButton.Click += new System.EventHandler(this.askButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 69);
            this.button1.TabIndex = 12;
            this.button1.Text = "Спросить всех";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 530);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.askButton);
            this.Controls.Add(this.communityLabel);
            this.Controls.Add(this.hostLabel);
            this.Controls.Add(this.responseTextBox);
            this.Controls.Add(this.communityTextBox);
            this.Controls.Add(this.hostTextBox);
            this.Controls.Add(this.addressesListBox);
            this.Controls.Add(this.addressesLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.adapterLabel);
            this.Controls.Add(this.adapterComboBox);
            this.Controls.Add(this.checkBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тест";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.ComboBox adapterComboBox;
        private System.Windows.Forms.Label adapterLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label addressesLabel;
        private System.Windows.Forms.ListBox addressesListBox;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.TextBox communityTextBox;
        private System.Windows.Forms.TextBox responseTextBox;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.Label communityLabel;
        private System.Windows.Forms.Button askButton;
        private System.Windows.Forms.Button button1;
    }
}

