namespace Task3
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
            createMultiplicationTableButton = new Button();
            SuspendLayout();
            // 
            // createMultiplicationTableButton
            // 
            createMultiplicationTableButton.Location = new Point(41, 65);
            createMultiplicationTableButton.Name = "createMultiplicationTableButton";
            createMultiplicationTableButton.Size = new Size(206, 44);
            createMultiplicationTableButton.TabIndex = 0;
            createMultiplicationTableButton.Text = "Создать таблицу умножения";
            createMultiplicationTableButton.UseVisualStyleBackColor = true;
            createMultiplicationTableButton.Click += CreateMultiplicationTableButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 187);
            Controls.Add(createMultiplicationTableButton);
            Name = "Form1";
            Text = "Приложение";
            ResumeLayout(false);
        }

        #endregion

        private Button createMultiplicationTableButton;
    }
}
