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
            this.ValidationErrorLabel = new System.Windows.Forms.Label();
            this.ClassCInputLabel = new System.Windows.Forms.Label();
            this.ClassBInputLabel = new System.Windows.Forms.Label();
            this.ClassAInputLabel = new System.Windows.Forms.Label();
            this.ClassCInputTextBox = new System.Windows.Forms.TextBox();
            this.ClassBInputTextBox = new System.Windows.Forms.TextBox();
            this.ClassAInputTextBox = new System.Windows.Forms.TextBox();
            this.EnterNumberOfTicketsLabel = new System.Windows.Forms.Label();
            this.OutputGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalOutputLabel = new System.Windows.Forms.Label();
            this.TotalOutputTextBox = new System.Windows.Forms.TextBox();
            this.ClassCOutputLabel = new System.Windows.Forms.Label();
            this.ClassBOutputLabel = new System.Windows.Forms.Label();
            this.ClassAOutputLabel = new System.Windows.Forms.Label();
            this.ClassCOutputTextBox = new System.Windows.Forms.TextBox();
            this.ClassBOutputTextBox = new System.Windows.Forms.TextBox();
            this.ClassAOutputTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.InputGroupBox.SuspendLayout();
            this.OutputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputGroupBox
            // 
            this.InputGroupBox.Controls.Add(this.ValidationErrorLabel);
            this.InputGroupBox.Controls.Add(this.ClassCInputLabel);
            this.InputGroupBox.Controls.Add(this.ClassBInputLabel);
            this.InputGroupBox.Controls.Add(this.ClassAInputLabel);
            this.InputGroupBox.Controls.Add(this.ClassCInputTextBox);
            this.InputGroupBox.Controls.Add(this.ClassBInputTextBox);
            this.InputGroupBox.Controls.Add(this.ClassAInputTextBox);
            this.InputGroupBox.Controls.Add(this.EnterNumberOfTicketsLabel);
            this.InputGroupBox.Location = new System.Drawing.Point(13, 13);
            this.InputGroupBox.Name = "InputGroupBox";
            this.InputGroupBox.Size = new System.Drawing.Size(247, 242);
            this.InputGroupBox.TabIndex = 0;
            this.InputGroupBox.TabStop = false;
            this.InputGroupBox.Text = "Tickets Sold";
            // 
            // ValidationErrorLabel
            // 
            this.ValidationErrorLabel.AutoSize = true;
            this.ValidationErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ValidationErrorLabel.Location = new System.Drawing.Point(17, 205);
            this.ValidationErrorLabel.Name = "ValidationErrorLabel";
            this.ValidationErrorLabel.Size = new System.Drawing.Size(174, 13);
            this.ValidationErrorLabel.TabIndex = 7;
            this.ValidationErrorLabel.Text = "Please enter correct ticket amounts";
            this.ValidationErrorLabel.Visible = false;
            // 
            // ClassCInputLabel
            // 
            this.ClassCInputLabel.AutoSize = true;
            this.ClassCInputLabel.Location = new System.Drawing.Point(20, 172);
            this.ClassCInputLabel.Name = "ClassCInputLabel";
            this.ClassCInputLabel.Size = new System.Drawing.Size(45, 13);
            this.ClassCInputLabel.TabIndex = 6;
            this.ClassCInputLabel.Text = "Class C:";
            // 
            // ClassBInputLabel
            // 
            this.ClassBInputLabel.AutoSize = true;
            this.ClassBInputLabel.Location = new System.Drawing.Point(20, 133);
            this.ClassBInputLabel.Name = "ClassBInputLabel";
            this.ClassBInputLabel.Size = new System.Drawing.Size(45, 13);
            this.ClassBInputLabel.TabIndex = 5;
            this.ClassBInputLabel.Text = "Class B:";
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
            // ClassCInputTextBox
            // 
            this.ClassCInputTextBox.Location = new System.Drawing.Point(73, 172);
            this.ClassCInputTextBox.Name = "ClassCInputTextBox";
            this.ClassCInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClassCInputTextBox.TabIndex = 3;
            // 
            // ClassBInputTextBox
            // 
            this.ClassBInputTextBox.Location = new System.Drawing.Point(73, 133);
            this.ClassBInputTextBox.Name = "ClassBInputTextBox";
            this.ClassBInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClassBInputTextBox.TabIndex = 2;
            // 
            // ClassAInputTextBox
            // 
            this.ClassAInputTextBox.Location = new System.Drawing.Point(73, 97);
            this.ClassAInputTextBox.Name = "ClassAInputTextBox";
            this.ClassAInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClassAInputTextBox.TabIndex = 1;
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
            this.OutputGroupBox.Controls.Add(this.TotalOutputLabel);
            this.OutputGroupBox.Controls.Add(this.TotalOutputTextBox);
            this.OutputGroupBox.Controls.Add(this.ClassCOutputLabel);
            this.OutputGroupBox.Controls.Add(this.ClassBOutputLabel);
            this.OutputGroupBox.Controls.Add(this.ClassAOutputLabel);
            this.OutputGroupBox.Controls.Add(this.ClassCOutputTextBox);
            this.OutputGroupBox.Controls.Add(this.ClassBOutputTextBox);
            this.OutputGroupBox.Controls.Add(this.ClassAOutputTextBox);
            this.OutputGroupBox.Location = new System.Drawing.Point(266, 13);
            this.OutputGroupBox.Name = "OutputGroupBox";
            this.OutputGroupBox.Size = new System.Drawing.Size(229, 242);
            this.OutputGroupBox.TabIndex = 1;
            this.OutputGroupBox.TabStop = false;
            this.OutputGroupBox.Text = "Revenue Generated";
            // 
            // TotalOutputLabel
            // 
            this.TotalOutputLabel.AutoSize = true;
            this.TotalOutputLabel.Location = new System.Drawing.Point(34, 198);
            this.TotalOutputLabel.Name = "TotalOutputLabel";
            this.TotalOutputLabel.Size = new System.Drawing.Size(34, 13);
            this.TotalOutputLabel.TabIndex = 14;
            this.TotalOutputLabel.Text = "Total:";
            // 
            // TotalOutputTextBox
            // 
            this.TotalOutputTextBox.Enabled = false;
            this.TotalOutputTextBox.Location = new System.Drawing.Point(87, 198);
            this.TotalOutputTextBox.Name = "TotalOutputTextBox";
            this.TotalOutputTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalOutputTextBox.TabIndex = 13;
            // 
            // ClassCOutputLabel
            // 
            this.ClassCOutputLabel.AutoSize = true;
            this.ClassCOutputLabel.Location = new System.Drawing.Point(34, 165);
            this.ClassCOutputLabel.Name = "ClassCOutputLabel";
            this.ClassCOutputLabel.Size = new System.Drawing.Size(45, 13);
            this.ClassCOutputLabel.TabIndex = 12;
            this.ClassCOutputLabel.Text = "Class C:";
            // 
            // ClassBOutputLabel
            // 
            this.ClassBOutputLabel.AutoSize = true;
            this.ClassBOutputLabel.Location = new System.Drawing.Point(34, 133);
            this.ClassBOutputLabel.Name = "ClassBOutputLabel";
            this.ClassBOutputLabel.Size = new System.Drawing.Size(45, 13);
            this.ClassBOutputLabel.TabIndex = 11;
            this.ClassBOutputLabel.Text = "Class B:";
            // 
            // ClassAOutputLabel
            // 
            this.ClassAOutputLabel.AutoSize = true;
            this.ClassAOutputLabel.Location = new System.Drawing.Point(34, 97);
            this.ClassAOutputLabel.Name = "ClassAOutputLabel";
            this.ClassAOutputLabel.Size = new System.Drawing.Size(45, 13);
            this.ClassAOutputLabel.TabIndex = 10;
            this.ClassAOutputLabel.Text = "Class A:";
            // 
            // ClassCOutputTextBox
            // 
            this.ClassCOutputTextBox.Enabled = false;
            this.ClassCOutputTextBox.Location = new System.Drawing.Point(87, 165);
            this.ClassCOutputTextBox.Name = "ClassCOutputTextBox";
            this.ClassCOutputTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClassCOutputTextBox.TabIndex = 9;
            // 
            // ClassBOutputTextBox
            // 
            this.ClassBOutputTextBox.Enabled = false;
            this.ClassBOutputTextBox.Location = new System.Drawing.Point(87, 133);
            this.ClassBOutputTextBox.Name = "ClassBOutputTextBox";
            this.ClassBOutputTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClassBOutputTextBox.TabIndex = 8;
            // 
            // ClassAOutputTextBox
            // 
            this.ClassAOutputTextBox.Enabled = false;
            this.ClassAOutputTextBox.Location = new System.Drawing.Point(87, 97);
            this.ClassAOutputTextBox.Name = "ClassAOutputTextBox";
            this.ClassAOutputTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClassAOutputTextBox.TabIndex = 7;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(51, 261);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 41);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Calculate\r\nRevenue";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(204, 261);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 41);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(353, 261);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 41);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 314);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.OutputGroupBox);
            this.Controls.Add(this.InputGroupBox);
            this.Name = "Form1";
            this.Text = "Stadium Seating";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.InputGroupBox.ResumeLayout(false);
            this.InputGroupBox.PerformLayout();
            this.OutputGroupBox.ResumeLayout(false);
            this.OutputGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox InputGroupBox;
        private System.Windows.Forms.Label EnterNumberOfTicketsLabel;
        private System.Windows.Forms.GroupBox OutputGroupBox;
        private System.Windows.Forms.Label ClassBInputLabel;
        private System.Windows.Forms.Label ClassAInputLabel;
        private System.Windows.Forms.TextBox ClassCInputTextBox;
        private System.Windows.Forms.TextBox ClassBInputTextBox;
        private System.Windows.Forms.TextBox ClassAInputTextBox;
        private System.Windows.Forms.Label ClassCInputLabel;
        private System.Windows.Forms.Label ClassCOutputLabel;
        private System.Windows.Forms.Label ClassBOutputLabel;
        private System.Windows.Forms.Label ClassAOutputLabel;
        private System.Windows.Forms.TextBox ClassCOutputTextBox;
        private System.Windows.Forms.TextBox ClassBOutputTextBox;
        private System.Windows.Forms.TextBox ClassAOutputTextBox;
        private System.Windows.Forms.Label TotalOutputLabel;
        private System.Windows.Forms.TextBox TotalOutputTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label ValidationErrorLabel;
    }
}

