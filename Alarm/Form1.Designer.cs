namespace Alarm
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.alarmTimeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AlarmStatusLabel = new System.Windows.Forms.Label();
            this.WorkTimeBox = new System.Windows.Forms.TextBox();
            this.FreeTimeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FreeTimeLabel = new System.Windows.Forms.Label();
            this.WorkTimeButton = new System.Windows.Forms.Button();
            this.FreeTimeButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.availableFreeTimeLabel = new System.Windows.Forms.Label();
            this.WorkTimeElapsedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Set alarm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // alarmTimeInput
            // 
            this.alarmTimeInput.Location = new System.Drawing.Point(353, 370);
            this.alarmTimeInput.Name = "alarmTimeInput";
            this.alarmTimeInput.Size = new System.Drawing.Size(122, 20);
            this.alarmTimeInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alarm time";
            // 
            // AlarmStatusLabel
            // 
            this.AlarmStatusLabel.AutoSize = true;
            this.AlarmStatusLabel.Location = new System.Drawing.Point(9, 176);
            this.AlarmStatusLabel.Name = "AlarmStatusLabel";
            this.AlarmStatusLabel.Size = new System.Drawing.Size(48, 13);
            this.AlarmStatusLabel.TabIndex = 3;
            this.AlarmStatusLabel.Text = "Alarm off";
            // 
            // WorkTimeBox
            // 
            this.WorkTimeBox.Location = new System.Drawing.Point(12, 75);
            this.WorkTimeBox.Name = "WorkTimeBox";
            this.WorkTimeBox.Size = new System.Drawing.Size(106, 20);
            this.WorkTimeBox.TabIndex = 5;
            // 
            // FreeTimeBox
            // 
            this.FreeTimeBox.Location = new System.Drawing.Point(124, 75);
            this.FreeTimeBox.Name = "FreeTimeBox";
            this.FreeTimeBox.Size = new System.Drawing.Size(106, 20);
            this.FreeTimeBox.TabIndex = 6;
            this.FreeTimeBox.TextChanged += new System.EventHandler(this.FreeTimeBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Work time";
            // 
            // FreeTimeLabel
            // 
            this.FreeTimeLabel.AutoSize = true;
            this.FreeTimeLabel.Location = new System.Drawing.Point(121, 98);
            this.FreeTimeLabel.Name = "FreeTimeLabel";
            this.FreeTimeLabel.Size = new System.Drawing.Size(50, 13);
            this.FreeTimeLabel.TabIndex = 8;
            this.FreeTimeLabel.Text = "Free time";
            // 
            // WorkTimeButton
            // 
            this.WorkTimeButton.Location = new System.Drawing.Point(12, 135);
            this.WorkTimeButton.Name = "WorkTimeButton";
            this.WorkTimeButton.Size = new System.Drawing.Size(106, 23);
            this.WorkTimeButton.TabIndex = 9;
            this.WorkTimeButton.Text = "Set work";
            this.WorkTimeButton.UseVisualStyleBackColor = true;
            this.WorkTimeButton.Click += new System.EventHandler(this.WorkTimeButton_Click);
            // 
            // FreeTimeButton
            // 
            this.FreeTimeButton.Location = new System.Drawing.Point(124, 135);
            this.FreeTimeButton.Name = "FreeTimeButton";
            this.FreeTimeButton.Size = new System.Drawing.Size(106, 23);
            this.FreeTimeButton.TabIndex = 10;
            this.FreeTimeButton.Text = "Set free";
            this.FreeTimeButton.UseVisualStyleBackColor = true;
            this.FreeTimeButton.Click += new System.EventHandler(this.FreeTimeButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(236, 75);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 13);
            this.messageLabel.TabIndex = 11;
            // 
            // availableFreeTimeLabel
            // 
            this.availableFreeTimeLabel.AutoSize = true;
            this.availableFreeTimeLabel.Location = new System.Drawing.Point(121, 59);
            this.availableFreeTimeLabel.Name = "availableFreeTimeLabel";
            this.availableFreeTimeLabel.Size = new System.Drawing.Size(0, 13);
            this.availableFreeTimeLabel.TabIndex = 12;
            // 
            // WorkTimeElapsedLabel
            // 
            this.WorkTimeElapsedLabel.AutoSize = true;
            this.WorkTimeElapsedLabel.Location = new System.Drawing.Point(9, 59);
            this.WorkTimeElapsedLabel.Name = "WorkTimeElapsedLabel";
            this.WorkTimeElapsedLabel.Size = new System.Drawing.Size(0, 13);
            this.WorkTimeElapsedLabel.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 230);
            this.Controls.Add(this.WorkTimeElapsedLabel);
            this.Controls.Add(this.availableFreeTimeLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.FreeTimeButton);
            this.Controls.Add(this.WorkTimeButton);
            this.Controls.Add(this.FreeTimeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FreeTimeBox);
            this.Controls.Add(this.WorkTimeBox);
            this.Controls.Add(this.AlarmStatusLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alarmTimeInput);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox alarmTimeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AlarmStatusLabel;
        private System.Windows.Forms.TextBox WorkTimeBox;
        private System.Windows.Forms.TextBox FreeTimeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FreeTimeLabel;
        private System.Windows.Forms.Button WorkTimeButton;
        private System.Windows.Forms.Button FreeTimeButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label availableFreeTimeLabel;
        private System.Windows.Forms.Label WorkTimeElapsedLabel;
    }
}

