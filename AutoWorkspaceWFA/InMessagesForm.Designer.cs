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
            DeleteButton = new Button();
            dataGridView = new DataGridView();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            comboBoxSource = new ComboBox();
            textBoxRecipient = new TextBox();
            textBoxAdressee = new TextBox();
            textBoxSender = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(12, 415);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(103, 23);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(771, 386);
            dataGridView.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBoxSource);
            groupBox1.Controls.Add(textBoxRecipient);
            groupBox1.Controls.Add(textBoxAdressee);
            groupBox1.Controls.Add(textBoxSender);
            groupBox1.Location = new Point(789, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(202, 220);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button2
            // 
            button2.Location = new Point(108, 138);
            button2.Name = "button2";
            button2.Size = new Size(83, 23);
            button2.TabIndex = 5;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(6, 138);
            button1.Name = "button1";
            button1.Size = new Size(83, 23);
            button1.TabIndex = 4;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxSource
            // 
            comboBoxSource.FormattingEnabled = true;
            comboBoxSource.Location = new Point(6, 109);
            comboBoxSource.Name = "comboBoxSource";
            comboBoxSource.Size = new Size(185, 23);
            comboBoxSource.TabIndex = 3;
            // 
            // textBoxRecipient
            // 
            textBoxRecipient.Location = new Point(6, 80);
            textBoxRecipient.Name = "textBoxRecipient";
            textBoxRecipient.Size = new Size(185, 23);
            textBoxRecipient.TabIndex = 2;
            // 
            // textBoxAdressee
            // 
            textBoxAdressee.Location = new Point(6, 51);
            textBoxAdressee.Name = "textBoxAdressee";
            textBoxAdressee.Size = new Size(185, 23);
            textBoxAdressee.TabIndex = 1;
            // 
            // textBoxSender
            // 
            textBoxSender.Location = new Point(6, 22);
            textBoxSender.Name = "textBoxSender";
            textBoxSender.Size = new Size(185, 23);
            textBoxSender.TabIndex = 0;
            // 
            // InMessagesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 450);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView);
            Controls.Add(DeleteButton);
            Name = "InMessagesForm";
            Text = "InMessagesForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button DeleteButton;
        private DataGridView dataGridView;
        private GroupBox groupBox1;
        private ComboBox comboBoxSource;
        private TextBox textBoxRecipient;
        private TextBox textBoxAdressee;
        private TextBox textBoxSender;
        private Button button2;
        private Button button1;
    }
}