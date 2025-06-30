namespace Task3
{
    partial class NotepadForm
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
            notepadTextBox = new TextBox();
            ReplaceButton = new Button();
            SuspendLayout();
            // 
            // notepadTextBox
            // 
            notepadTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            notepadTextBox.Location = new Point(67, 29);
            notepadTextBox.Multiline = true;
            notepadTextBox.Name = "notepadTextBox";
            notepadTextBox.Size = new Size(336, 268);
            notepadTextBox.TabIndex = 0;
            // 
            // ReplaceButton
            // 
            ReplaceButton.Anchor = AnchorStyles.Bottom;
            ReplaceButton.Location = new Point(192, 312);
            ReplaceButton.Name = "ReplaceButton";
            ReplaceButton.Size = new Size(98, 32);
            ReplaceButton.TabIndex = 1;
            ReplaceButton.Text = "Заменить";
            ReplaceButton.UseVisualStyleBackColor = true;
            ReplaceButton.Click += OpenReplaceFormButton_Click;
            // 
            // NotepadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 356);
            Controls.Add(ReplaceButton);
            Controls.Add(notepadTextBox);
            Name = "NotepadForm";
            Text = "Блокнот";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox notepadTextBox;
        private Button ReplaceButton;
    }
}
