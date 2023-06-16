namespace AutoWorkspaceWFA
{
    partial class OutMessagesForm
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
            DeleteButton = new Button();
            AddButton = new Button();
            MessagesListBox = new ListBox();
            SuspendLayout();
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(685, 415);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(103, 23);
            DeleteButton.TabIndex = 5;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(12, 415);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(103, 23);
            AddButton.TabIndex = 4;
            AddButton.Text = "Регистрация";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // MessagesListBox
            // 
            MessagesListBox.FormattingEnabled = true;
            MessagesListBox.ItemHeight = 15;
            MessagesListBox.Location = new Point(12, 12);
            MessagesListBox.Name = "MessagesListBox";
            MessagesListBox.Size = new Size(776, 379);
            MessagesListBox.TabIndex = 3;
            MessagesListBox.MouseDoubleClick += MessagesListBox_MouseDoubleClick;
            // 
            // OutMessagesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Controls.Add(MessagesListBox);
            Name = "OutMessagesForm";
            Text = "OutMessagesForm";
            ResumeLayout(false);
        }

        #endregion

        private Button DeleteButton;
        private Button AddButton;
        private ListBox MessagesListBox;
    }
}