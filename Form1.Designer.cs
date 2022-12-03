namespace ASC_AutomatDeVanzari
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NickelButton = new System.Windows.Forms.Button();
            this.DimeButton = new System.Windows.Forms.Button();
            this.QuarterButton = new System.Windows.Forms.Button();
            this.CentsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HistoryTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NickelButton
            // 
            this.NickelButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NickelButton.Location = new System.Drawing.Point(12, 344);
            this.NickelButton.Name = "NickelButton";
            this.NickelButton.Size = new System.Drawing.Size(225, 120);
            this.NickelButton.TabIndex = 0;
            this.NickelButton.Text = "Nickel (5 Cents)";
            this.NickelButton.UseVisualStyleBackColor = true;
            this.NickelButton.Click += new System.EventHandler(this.NickelButton_Click);
            // 
            // DimeButton
            // 
            this.DimeButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DimeButton.Location = new System.Drawing.Point(291, 344);
            this.DimeButton.Name = "DimeButton";
            this.DimeButton.Size = new System.Drawing.Size(225, 120);
            this.DimeButton.TabIndex = 1;
            this.DimeButton.Text = "Dime (10 Cents)";
            this.DimeButton.UseVisualStyleBackColor = true;
            this.DimeButton.Click += new System.EventHandler(this.DimeButton_Click);
            // 
            // QuarterButton
            // 
            this.QuarterButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QuarterButton.Location = new System.Drawing.Point(563, 344);
            this.QuarterButton.Name = "QuarterButton";
            this.QuarterButton.Size = new System.Drawing.Size(225, 120);
            this.QuarterButton.TabIndex = 2;
            this.QuarterButton.Text = "Quarter (25 Cents)";
            this.QuarterButton.UseVisualStyleBackColor = true;
            this.QuarterButton.Click += new System.EventHandler(this.QuarterButton_Click);
            // 
            // CentsLabel
            // 
            this.CentsLabel.AutoSize = true;
            this.CentsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CentsLabel.Location = new System.Drawing.Point(12, 9);
            this.CentsLabel.Name = "CentsLabel";
            this.CentsLabel.Size = new System.Drawing.Size(175, 65);
            this.CentsLabel.TabIndex = 3;
            this.CentsLabel.Text = "Cents: ";
            this.CentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cost: 20C";
            // 
            // HistoryTextBox
            // 
            this.HistoryTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HistoryTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.HistoryTextBox.Location = new System.Drawing.Point(291, 77);
            this.HistoryTextBox.Multiline = true;
            this.HistoryTextBox.Name = "HistoryTextBox";
            this.HistoryTextBox.ReadOnly = true;
            this.HistoryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HistoryTextBox.Size = new System.Drawing.Size(497, 252);
            this.HistoryTextBox.TabIndex = 5;
            this.HistoryTextBox.TextChanged += new System.EventHandler(this.HistoryTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(667, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "History";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HistoryTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CentsLabel);
            this.Controls.Add(this.QuarterButton);
            this.Controls.Add(this.DimeButton);
            this.Controls.Add(this.NickelButton);
            this.Name = "Form1";
            this.Text = "Automat de vanzari";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button NickelButton;
        private Button DimeButton;
        private Button QuarterButton;
        private Label label1;
        private TextBox HistoryTextBox;
        private Label label2;
        public Label CentsLabel;
    }
}