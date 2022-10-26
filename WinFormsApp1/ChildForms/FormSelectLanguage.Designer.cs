namespace WinFormsApp1.Forms {
    partial class FormSelectLanguage {
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
            this.SelectBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.NewListBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WordListCount = new System.Windows.Forms.Label();
            this.WordListsListBox = new System.Windows.Forms.ListBox();
            this.LanguagesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SelectBtn
            // 
            this.SelectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.SelectBtn.FlatAppearance.BorderSize = 0;
            this.SelectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.SelectBtn.Location = new System.Drawing.Point(412, 205);
            this.SelectBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(94, 32);
            this.SelectBtn.TabIndex = 0;
            this.SelectBtn.Text = "Select";
            this.SelectBtn.UseVisualStyleBackColor = false;
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.CancelBtn.Location = new System.Drawing.Point(310, 205);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(94, 32);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // NewListBtn
            // 
            this.NewListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.NewListBtn.FlatAppearance.BorderSize = 0;
            this.NewListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewListBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewListBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.NewListBtn.Location = new System.Drawing.Point(18, 205);
            this.NewListBtn.Margin = new System.Windows.Forms.Padding(2);
            this.NewListBtn.Name = "NewListBtn";
            this.NewListBtn.Size = new System.Drawing.Size(94, 33);
            this.NewListBtn.TabIndex = 2;
            this.NewListBtn.Text = "New List";
            this.NewListBtn.UseVisualStyleBackColor = false;
            this.NewListBtn.Click += new System.EventHandler(this.NewListBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Word Lists";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Languages";
            // 
            // WordListCount
            // 
            this.WordListCount.AutoSize = true;
            this.WordListCount.Location = new System.Drawing.Point(157, 15);
            this.WordListCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WordListCount.Name = "WordListCount";
            this.WordListCount.Size = new System.Drawing.Size(84, 15);
            this.WordListCount.TabIndex = 7;
            this.WordListCount.Text = "Word Count: 0";
            // 
            // WordListsListBox
            // 
            this.WordListsListBox.FormattingEnabled = true;
            this.WordListsListBox.ItemHeight = 15;
            this.WordListsListBox.Location = new System.Drawing.Point(18, 32);
            this.WordListsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.WordListsListBox.Name = "WordListsListBox";
            this.WordListsListBox.Size = new System.Drawing.Size(223, 169);
            this.WordListsListBox.TabIndex = 8;
            this.WordListsListBox.SelectedIndexChanged += new System.EventHandler(this.WordListsListBox_SelectedIndexChanged);
            // 
            // LanguagesListBox
            // 
            this.LanguagesListBox.FormattingEnabled = true;
            this.LanguagesListBox.ItemHeight = 15;
            this.LanguagesListBox.Location = new System.Drawing.Point(283, 32);
            this.LanguagesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.LanguagesListBox.Name = "LanguagesListBox";
            this.LanguagesListBox.Size = new System.Drawing.Size(223, 169);
            this.LanguagesListBox.TabIndex = 9;
            // 
            // FormSelectLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 248);
            this.Controls.Add(this.LanguagesListBox);
            this.Controls.Add(this.WordListsListBox);
            this.Controls.Add(this.WordListCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewListBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SelectBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSelectLanguage";
            this.Text = "FormSelectLanguage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SelectBtn;
        private Button CancelBtn;
        private Button NewListBtn;
        private Label label1;
        private Label label2;
        private Label WordListCount;
        private ListBox WordListsListBox;
        private ListBox LanguagesListBox;
    }
}