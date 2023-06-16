namespace AutoWorkspaceWFA
{
    partial class InMessagesForm
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
            AddButton = new Button();
            DeleteButton = new Button();
            messagesGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)messagesGridView).BeginInit();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(12, 415);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(103, 23);
            AddButton.TabIndex = 1;
            AddButton.Text = "Регистрация";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(685, 415);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(103, 23);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // messagesGridView
            // 
            messagesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            messagesGridView.Location = new Point(12, 12);
            messagesGridView.Name = "messagesGridView";
            messagesGridView.RowTemplate.Height = 25;
            messagesGridView.Size = new Size(776, 386);
            messagesGridView.TabIndex = 3;
            messagesGridView.MouseDoubleClick += messagesGridView_MouseDoubleClick;
            // 
            // InMessagesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(messagesGridView);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Name = "InMessagesForm";
            Text = "InMessagesForm";
            ((System.ComponentModel.ISupportInitialize)messagesGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button AddButton;
        private Button DeleteButton;
        private DataGridView messagesGridView;
    }
}