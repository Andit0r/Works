namespace WinFormsApp1
{
    partial class DocumentForm
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
            textLabel = new Label();
            countPagesLabel = new Label();
            inputTextBox = new TextBox();
            createTemplateDocumentButton = new Button();
            saveFileDialog1 = new SaveFileDialog();
            countPagesTextBox = new TextBox();
            SuspendLayout();
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Location = new Point(12, 9);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(81, 15);
            textLabel.TabIndex = 0;
            textLabel.Text = "Введите текст";
            // 
            // countPagesLabel
            // 
            countPagesLabel.AutoSize = true;
            countPagesLabel.Location = new Point(12, 166);
            countPagesLabel.Name = "countPagesLabel";
            countPagesLabel.Size = new Size(164, 15);
            countPagesLabel.TabIndex = 1;
            countPagesLabel.Text = "Введите количество заданий";
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(12, 27);
            inputTextBox.MaximumSize = new Size(345, 115);
            inputTextBox.MinimumSize = new Size(365, 115);
            inputTextBox.Multiline = true;
            inputTextBox.Name = "inputTextBox";
            inputTextBox.ScrollBars = ScrollBars.Vertical;
            inputTextBox.Size = new Size(365, 115);
            inputTextBox.TabIndex = 2;
            // 
            // createTemplateDocumentButton
            // 
            createTemplateDocumentButton.Location = new Point(257, 196);
            createTemplateDocumentButton.Name = "createTemplateDocumentButton";
            createTemplateDocumentButton.Size = new Size(127, 37);
            createTemplateDocumentButton.TabIndex = 4;
            createTemplateDocumentButton.Text = "Создать документ";
            createTemplateDocumentButton.UseVisualStyleBackColor = true;
            createTemplateDocumentButton.Click += CreateTemplateDocumentButton_Click;
            // 
            // countPagesTextBox
            // 
            countPagesTextBox.Location = new Point(182, 164);
            countPagesTextBox.Name = "countPagesTextBox";
            countPagesTextBox.Size = new Size(46, 23);
            countPagesTextBox.TabIndex = 3;
            // 
            // DocumentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 245);
            Controls.Add(createTemplateDocumentButton);
            Controls.Add(countPagesTextBox);
            Controls.Add(inputTextBox);
            Controls.Add(countPagesLabel);
            Controls.Add(textLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DocumentForm";
            Text = "Создание документа";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textLabel;
        private Label countPagesLabel;
        private TextBox inputTextBox;
        private Button createTemplateDocumentButton;
        private SaveFileDialog saveFileDialog1;
        private TextBox countPagesTextBox;
    }
}
