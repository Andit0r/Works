namespace Task3
{
    partial class ReplaceForm
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
            searchTextBox = new TextBox();
            searchLabel = new Label();
            replaceTextBox = new TextBox();
            replaceLabel = new Label();
            SearchAndReplaceButton = new Button();
            SuspendLayout();
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(68, 44);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(260, 23);
            searchTextBox.TabIndex = 0;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(68, 26);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(41, 15);
            searchLabel.TabIndex = 1;
            searchLabel.Text = "Найти";
            searchLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // replaceTextBox
            // 
            replaceTextBox.Location = new Point(68, 117);
            replaceTextBox.Name = "replaceTextBox";
            replaceTextBox.Size = new Size(260, 23);
            replaceTextBox.TabIndex = 0;
            // 
            // replaceLabel
            // 
            replaceLabel.AutoSize = true;
            replaceLabel.Location = new Point(68, 99);
            replaceLabel.Name = "replaceLabel";
            replaceLabel.Size = new Size(60, 15);
            replaceLabel.TabIndex = 1;
            replaceLabel.Text = "Заменить";
            replaceLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // SearchAndReplaceButton
            // 
            SearchAndReplaceButton.Location = new Point(245, 168);
            SearchAndReplaceButton.Name = "SearchAndReplaceButton";
            SearchAndReplaceButton.Size = new Size(149, 33);
            SearchAndReplaceButton.TabIndex = 2;
            SearchAndReplaceButton.Text = "Найти и заменить";
            SearchAndReplaceButton.UseVisualStyleBackColor = true;
            SearchAndReplaceButton.Click += ReplaceButton_Click;
            // 
            // ReplaceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 212);
            Controls.Add(SearchAndReplaceButton);
            Controls.Add(replaceLabel);
            Controls.Add(searchLabel);
            Controls.Add(replaceTextBox);
            Controls.Add(searchTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ReplaceForm";
            Text = "Поиск и замена";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchTextBox;
        private Label searchLabel;
        private TextBox replaceTextBox;
        private Label replaceLabel;
        private Button SearchAndReplaceButton;
    }
}