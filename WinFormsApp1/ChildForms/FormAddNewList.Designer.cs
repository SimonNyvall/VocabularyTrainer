namespace WinFormsApp1.Forms {
    partial class FormAddNewList {
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
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ListNameTextBox = new System.Windows.Forms.TextBox();
            this.LanguagesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKBtn
            // 
            this.OKBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.OKBtn.FlatAppearance.BorderSize = 0;
            this.OKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OKBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.OKBtn.Location = new System.Drawing.Point(103, 192);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 26);
            this.OKBtn.TabIndex = 0;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = false;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.IndianRed;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelBtn.Location = new System.Drawing.Point(12, 192);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 26);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "List Name";
            // 
            // ListNameTextBox
            // 
            this.ListNameTextBox.Location = new System.Drawing.Point(12, 27);
            this.ListNameTextBox.Name = "ListNameTextBox";
            this.ListNameTextBox.Size = new System.Drawing.Size(166, 23);
            this.ListNameTextBox.TabIndex = 3;
            this.ListNameTextBox.Enter += new System.EventHandler(this.ListNameTextBox_Enter);
            this.ListNameTextBox.Leave += new System.EventHandler(this.ListNameTextBox_Leave);
            // 
            // LanguagesTextBox
            // 
            this.LanguagesTextBox.Location = new System.Drawing.Point(12, 86);
            this.LanguagesTextBox.Multiline = true;
            this.LanguagesTextBox.Name = "LanguagesTextBox";
            this.LanguagesTextBox.Size = new System.Drawing.Size(166, 100);
            this.LanguagesTextBox.TabIndex = 4;
            this.LanguagesTextBox.Enter += new System.EventHandler(this.LanguagesTextBox_Enter);
            this.LanguagesTextBox.Leave += new System.EventHandler(this.LanguagesTextBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Languages";
            // 
            // FormAddNewList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 230);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LanguagesTextBox);
            this.Controls.Add(this.ListNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddNewList";
            this.ShowIcon = false;
            this.Text = "New List";
            this.Load += new System.EventHandler(this.FormAddNewList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button OKBtn;
        private Button CancelBtn;
        private Label label1;
        private TextBox ListNameTextBox;
        private TextBox LanguagesTextBox;
        private Label label2;
    }
}