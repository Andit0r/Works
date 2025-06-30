namespace Task_3
{
    partial class CreateForm
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
            inputTextBox = new TextBox();
            textLabel = new Label();
            createDocumentButton = new Button();
            SuspendLayout();
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(12, 37);
            inputTextBox.MaximumSize = new Size(345, 115);
            inputTextBox.MinimumSize = new Size(360, 160);
            inputTextBox.Multiline = true;
            inputTextBox.Name = "inputTextBox";
            inputTextBox.ScrollBars = ScrollBars.Vertical;
            inputTextBox.Size = new Size(360, 160);
            inputTextBox.TabIndex = 4;
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Location = new Point(156, 19);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(81, 15);
            textLabel.TabIndex = 3;
            textLabel.Text = "Введите текст";
            // 
            // createDocumentButton
            // 
            createDocumentButton.Location = new Point(95, 209);
            createDocumentButton.Name = "createDocumentButton";
            createDocumentButton.Size = new Size(201, 41);
            createDocumentButton.TabIndex = 5;
            createDocumentButton.Text = "Создать документ";
            createDocumentButton.UseVisualStyleBackColor = true;
            createDocumentButton.Click += CreateButton_Click;
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 262);
            Controls.Add(createDocumentButton);
            Controls.Add(inputTextBox);
            Controls.Add(textLabel);
            MaximizeBox = false;
            Name = "CreateForm";
            Text = "Создание документа";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTextBox;
        private Label textLabel;
        private Button createDocumentButton;
    }
}
