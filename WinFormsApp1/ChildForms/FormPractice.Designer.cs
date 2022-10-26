namespace WinFormsApp1.Forms {
    partial class FormPractice {
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
            this.RestartBtn = new System.Windows.Forms.Button();
            this.EndPracticeBtn = new System.Windows.Forms.Button();
            this.StatsLabel = new System.Windows.Forms.Label();
            this.TranslationLabel = new System.Windows.Forms.Label();
            this.AwnserTextBox = new System.Windows.Forms.TextBox();
            this.LanguageSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.StartPracticeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelRightAwnser = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // RestartBtn
            // 
            this.RestartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.RestartBtn.FlatAppearance.BorderSize = 0;
            this.RestartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RestartBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RestartBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.RestartBtn.Location = new System.Drawing.Point(171, 275);
            this.RestartBtn.Name = "RestartBtn";
            this.RestartBtn.Size = new System.Drawing.Size(190, 63);
            this.RestartBtn.TabIndex = 0;
            this.RestartBtn.Text = "Restart";
            this.RestartBtn.UseVisualStyleBackColor = false;
            this.RestartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // EndPracticeBtn
            // 
            this.EndPracticeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.EndPracticeBtn.FlatAppearance.BorderSize = 0;
            this.EndPracticeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EndPracticeBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EndPracticeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.EndPracticeBtn.Location = new System.Drawing.Point(367, 275);
            this.EndPracticeBtn.Name = "EndPracticeBtn";
            this.EndPracticeBtn.Size = new System.Drawing.Size(190, 63);
            this.EndPracticeBtn.TabIndex = 1;
            this.EndPracticeBtn.Text = "End Practice";
            this.EndPracticeBtn.UseVisualStyleBackColor = false;
            this.EndPracticeBtn.Click += new System.EventHandler(this.EndPracticeBtn_Click);
            // 
            // StatsLabel
            // 
            this.StatsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StatsLabel.Location = new System.Drawing.Point(3, -12);
            this.StatsLabel.Name = "StatsLabel";
            this.StatsLabel.Size = new System.Drawing.Size(724, 50);
            this.StatsLabel.TabIndex = 2;
            this.StatsLabel.Text = "0 of 0 words were correct.";
            this.StatsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TranslationLabel
            // 
            this.TranslationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TranslationLabel.Location = new System.Drawing.Point(0, 0);
            this.TranslationLabel.Name = "TranslationLabel";
            this.TranslationLabel.Size = new System.Drawing.Size(730, 75);
            this.TranslationLabel.TabIndex = 3;
            this.TranslationLabel.Text = "Translation";
            this.TranslationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AwnserTextBox
            // 
            this.AwnserTextBox.Location = new System.Drawing.Point(171, 142);
            this.AwnserTextBox.Name = "AwnserTextBox";
            this.AwnserTextBox.Size = new System.Drawing.Size(384, 31);
            this.AwnserTextBox.TabIndex = 4;
            this.AwnserTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AwnserTextBox_KeyUp);
            // 
            // LanguageSelectionComboBox
            // 
            this.LanguageSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageSelectionComboBox.FormattingEnabled = true;
            this.LanguageSelectionComboBox.Location = new System.Drawing.Point(11, 12);
            this.LanguageSelectionComboBox.Name = "LanguageSelectionComboBox";
            this.LanguageSelectionComboBox.Size = new System.Drawing.Size(183, 33);
            this.LanguageSelectionComboBox.TabIndex = 5;
            // 
            // StartPracticeBtn
            // 
            this.StartPracticeBtn.Location = new System.Drawing.Point(201, 12);
            this.StartPracticeBtn.Name = "StartPracticeBtn";
            this.StartPracticeBtn.Size = new System.Drawing.Size(76, 38);
            this.StartPracticeBtn.TabIndex = 6;
            this.StartPracticeBtn.Text = "Start";
            this.StartPracticeBtn.UseVisualStyleBackColor = true;
            this.StartPracticeBtn.Click += new System.EventHandler(this.StartPracticeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.StatsLabel);
            this.panel1.Location = new System.Drawing.Point(-1, 188);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 55);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TranslationLabel);
            this.panel2.Location = new System.Drawing.Point(-1, 58);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 75);
            this.panel2.TabIndex = 8;
            // 
            // labelRightAwnser
            // 
            this.labelRightAwnser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRightAwnser.Location = new System.Drawing.Point(0, 0);
            this.labelRightAwnser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRightAwnser.Name = "labelRightAwnser";
            this.labelRightAwnser.Size = new System.Drawing.Size(727, 43);
            this.labelRightAwnser.TabIndex = 9;
            this.labelRightAwnser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelRightAwnser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 347);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(727, 43);
            this.panel3.TabIndex = 10;
            // 
            // FormPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 390);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StartPracticeBtn);
            this.Controls.Add(this.LanguageSelectionComboBox);
            this.Controls.Add(this.AwnserTextBox);
            this.Controls.Add(this.EndPracticeBtn);
            this.Controls.Add(this.RestartBtn);
            this.Controls.Add(this.panel3);
            this.Name = "FormPractice";
            this.Text = "FormPractice";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button RestartBtn;
        private Button EndPracticeBtn;
        private Label StatsLabel;
        private Label TranslationLabel;
        private TextBox AwnserTextBox;
        private ComboBox LanguageSelectionComboBox;
        private Button StartPracticeBtn;
        private Panel panel1;
        private Panel panel2;
        private Label labelRightAwnser;
        private Panel panel3;
    }
}