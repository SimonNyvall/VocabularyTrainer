namespace WinFormsApp1.Forms {
    partial class FormEditMode {
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
            this.AddWordBtn = new System.Windows.Forms.Button();
            this.RemoveWordBtn = new System.Windows.Forms.Button();
            this.PracticeBtn = new System.Windows.Forms.Button();
            this.WordListDataGridView = new System.Windows.Forms.DataGridView();
            this.WordListComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.WordListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddWordBtn
            // 
            this.AddWordBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.AddWordBtn.FlatAppearance.BorderSize = 0;
            this.AddWordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddWordBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddWordBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddWordBtn.Location = new System.Drawing.Point(241, 333);
            this.AddWordBtn.Name = "AddWordBtn";
            this.AddWordBtn.Size = new System.Drawing.Size(153, 38);
            this.AddWordBtn.TabIndex = 0;
            this.AddWordBtn.Text = "Add Word";
            this.AddWordBtn.UseVisualStyleBackColor = false;
            this.AddWordBtn.Click += new System.EventHandler(this.AddWordBtn_Click);
            // 
            // RemoveWordBtn
            // 
            this.RemoveWordBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.RemoveWordBtn.FlatAppearance.BorderSize = 0;
            this.RemoveWordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveWordBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveWordBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.RemoveWordBtn.Location = new System.Drawing.Point(400, 333);
            this.RemoveWordBtn.Name = "RemoveWordBtn";
            this.RemoveWordBtn.Size = new System.Drawing.Size(153, 38);
            this.RemoveWordBtn.TabIndex = 1;
            this.RemoveWordBtn.Text = "Remove Word";
            this.RemoveWordBtn.UseVisualStyleBackColor = false;
            this.RemoveWordBtn.Click += new System.EventHandler(this.RemoveWordBtn_Click);
            // 
            // PracticeBtn
            // 
            this.PracticeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.PracticeBtn.FlatAppearance.BorderSize = 0;
            this.PracticeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PracticeBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PracticeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.PracticeBtn.Location = new System.Drawing.Point(559, 333);
            this.PracticeBtn.Name = "PracticeBtn";
            this.PracticeBtn.Size = new System.Drawing.Size(153, 38);
            this.PracticeBtn.TabIndex = 2;
            this.PracticeBtn.Text = "Practice";
            this.PracticeBtn.UseVisualStyleBackColor = false;
            this.PracticeBtn.Click += new System.EventHandler(this.PracticeBtn_Click);
            // 
            // WordListDataGridView
            // 
            this.WordListDataGridView.AllowUserToAddRows = false;
            this.WordListDataGridView.AllowUserToDeleteRows = false;
            this.WordListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WordListDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.WordListDataGridView.Location = new System.Drawing.Point(0, 0);
            this.WordListDataGridView.Name = "WordListDataGridView";
            this.WordListDataGridView.ReadOnly = true;
            this.WordListDataGridView.RowHeadersWidth = 62;
            this.WordListDataGridView.RowTemplate.Height = 33;
            this.WordListDataGridView.Size = new System.Drawing.Size(727, 312);
            this.WordListDataGridView.TabIndex = 3;
            this.WordListDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WordListDataGridView_MouseDown);
            // 
            // WordListComboBox
            // 
            this.WordListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WordListComboBox.FormattingEnabled = true;
            this.WordListComboBox.Location = new System.Drawing.Point(16, 333);
            this.WordListComboBox.Name = "WordListComboBox";
            this.WordListComboBox.Size = new System.Drawing.Size(218, 33);
            this.WordListComboBox.TabIndex = 4;
            this.WordListComboBox.SelectedIndexChanged += new System.EventHandler(this.WordListComboBox_SelectedIndexChanged);
            // 
            // FormEditMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 390);
            this.Controls.Add(this.WordListComboBox);
            this.Controls.Add(this.WordListDataGridView);
            this.Controls.Add(this.PracticeBtn);
            this.Controls.Add(this.RemoveWordBtn);
            this.Controls.Add(this.AddWordBtn);
            this.Name = "FormEditMode";
            this.Text = "FormEditMode";
            ((System.ComponentModel.ISupportInitialize)(this.WordListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button AddWordBtn;
        private Button RemoveWordBtn;
        private Button PracticeBtn;
        private DataGridView WordListDataGridView;
        private ComboBox WordListComboBox;
    }
}