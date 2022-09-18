namespace assignment2_AndreiKazakov
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
            this.InputGroupBox = new System.Windows.Forms.GroupBox();
            this.EnterNumberOfTicketsLabel = new System.Windows.Forms.Label();
            this.OutputGroupBox = new System.Windows.Forms.GroupBox();
            this.ClassAInputTextbot = new System.Windows.Forms.TextBox();
            this.ClassBInputTextBot = new System.Windows.Forms.TextBox();
            this.ClassCInputTextBox = new System.Windows.Forms.TextBox();
            this.ClassAInputLabel = new System.Windows.Forms.Label();
            this.ClassBInputLabel = new System.Windows.Forms.Label();
            this.InputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputGroupBox
            // 
            this.InputGroupBox.Controls.Add(this.ClassBInputLabel);
            this.InputGroupBox.Controls.Add(this.ClassAInputLabel);
            this.InputGroupBox.Controls.Add(this.ClassCInputTextBox);
            this.InputGroupBox.Controls.Add(this.ClassBInputTextBot);
            this.InputGroupBox.Controls.Add(this.ClassAInputTextbot);
            this.InputGroupBox.Controls.Add(this.EnterNumberOfTicketsLabel);
            this.InputGroupBox.Location = new System.Drawing.Point(13, 13);
            this.InputGroupBox.Name = "InputGroupBox";
            this.InputGroupBox.Size = new System.Drawing.Size(384, 288);
            this.InputGroupBox.TabIndex = 0;
            this.InputGroupBox.TabStop = false;
            this.InputGroupBox.Text = "Tickets Sold";
            // 
            // EnterNumberOfTicketsLabel
            // 
            this.EnterNumberOfTicketsLabel.AutoSize = true;
            this.EnterNumberOfTicketsLabel.Location = new System.Drawing.Point(17, 39);
            this.EnterNumberOfTicketsLabel.Name = "EnterNumberOfTicketsLabel";
            this.EnterNumberOfTicketsLabel.Size = new System.Drawing.Size(156, 26);
            this.EnterNumberOfTicketsLabel.TabIndex = 0;
            this.EnterNumberOfTicketsLabel.Text = "Enter the number of tickets sold\r\nfor each class of tickets:";
            // 
            // OutputGroupBox
            // 
            this.OutputGroupBox.Location = new System.Drawing.Point(403, 13);
            this.OutputGroupBox.Name = "OutputGroupBox";
            this.OutputGroupBox.Size = new System.Drawing.Size(384, 288);
            this.OutputGroupBox.TabIndex = 1;
            this.OutputGroupBox.TabStop = false;
            this.OutputGroupBox.Text = "Revenue Generated";
            // 
            // ClassAInputTextbot
            // 
            this.ClassAInputTextbot.Location = new System.Drawing.Point(73, 97);
            this.ClassAInputTextbot.Name = "ClassAInputTextbot";
            this.ClassAInputTextbot.Size = new System.Drawing.Size(100, 20);
            this.ClassAInputTextbot.TabIndex = 1;
            // 
            // ClassBInputTextBot
            // 
            this.ClassBInputTextBot.Location = new System.Drawing.Point(72, 133);
            this.ClassBInputTextBot.Name = "ClassBInputTextBot";
            this.ClassBInputTextBot.Size = new System.Drawing.Size(100, 20);
            this.ClassBInputTextBot.TabIndex = 2;
            // 
            // ClassCInputTextBox
            // 
            this.ClassCInputTextBox.Location = new System.Drawing.Point(71, 172);
            this.ClassCInputTextBox.Name = "ClassCInputTextBox";
            this.ClassCInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClassCInputTextBox.TabIndex = 3;
            // 
            // ClassAInputLabel
            // 
            this.ClassAInputLabel.AutoSize = true;
            this.ClassAInputLabel.Location = new System.Drawing.Point(20, 97);
            this.ClassAInputLabel.Name = "ClassAInputLabel";
            this.ClassAInputLabel.Size = new System.Drawing.Size(45, 13);
            this.ClassAInputLabel.TabIndex = 4;
            this.ClassAInputLabel.Text = "Class A:";
            // 
            // ClassBInputLabel
            // 
            this.ClassBInputLabel.AutoSize = true;
            this.ClassBInputLabel.Location = new System.Drawing.Point(20, 133);
            this.ClassBInputLabel.Name = "ClassBInputLabel";
            this.ClassBInputLabel.Size = new System.Drawing.Size(35, 13);
            this.ClassBInputLabel.TabIndex = 5;
            this.ClassBInputLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutputGroupBox);
            this.Controls.Add(this.InputGroupBox);
            this.Name = "Form1";
            this.Text = "Stadium Seating";
            this.InputGroupBox.ResumeLayout(false);
            this.InputGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox InputGroupBox;
        private System.Windows.Forms.Label EnterNumberOfTicketsLabel;
        private System.Windows.Forms.GroupBox OutputGroupBox;
        private System.Windows.Forms.Label ClassBInputLabel;
        private System.Windows.Forms.Label ClassAInputLabel;
        private System.Windows.Forms.TextBox ClassCInputTextBox;
        private System.Windows.Forms.TextBox ClassBInputTextBot;
        private System.Windows.Forms.TextBox ClassAInputTextbot;
    }
}

