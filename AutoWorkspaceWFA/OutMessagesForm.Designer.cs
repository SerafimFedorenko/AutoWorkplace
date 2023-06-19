using System.Windows.Forms;

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
            dataGridView = new DataGridView();
            textBoxNumber = new TextBox();
            textBoxSender = new TextBox();
            textBoxRecipient = new TextBox();
            textBoxAdressee = new TextBox();
            comboBoxSource = new ComboBox();
            addButton = new Button();
            groupBox1 = new GroupBox();
            saveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(12, 415);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(103, 23);
            DeleteButton.TabIndex = 5;
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
            dataGridView.Size = new Size(836, 397);
            dataGridView.TabIndex = 6;
            dataGridView.CellClick += dataGridView_CellContentClick;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(6, 22);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(192, 23);
            textBoxNumber.TabIndex = 7;
            textBoxNumber.Enter += textBoxNumber_Enter;
            textBoxNumber.Leave += textBoxNumber_Leave;
            // 
            // textBoxSender
            // 
            textBoxSender.Location = new Point(6, 51);
            textBoxSender.Name = "textBoxSender";
            textBoxSender.Size = new Size(192, 23);
            textBoxSender.TabIndex = 8;
            textBoxSender.Enter += textBoxSender_Enter;
            textBoxSender.Leave += textBoxSender_Leave;
            // 
            // textBoxRecipient
            // 
            textBoxRecipient.Location = new Point(6, 80);
            textBoxRecipient.Name = "textBoxRecipient";
            textBoxRecipient.Size = new Size(192, 23);
            textBoxRecipient.TabIndex = 9;
            textBoxRecipient.Enter += textBoxRecipient_Enter;
            textBoxRecipient.Leave += textBoxRecipient_Leave;
            // 
            // textBoxAdressee
            // 
            textBoxAdressee.ForeColor = Color.Gray;
            textBoxAdressee.Location = new Point(6, 109);
            textBoxAdressee.Name = "textBoxAdressee";
            textBoxAdressee.Size = new Size(192, 23);
            textBoxAdressee.TabIndex = 10;
            textBoxAdressee.Enter += textBoxAdressee_Enter;
            textBoxAdressee.Leave += textBoxAdressee_Leave;
            // 
            // comboBoxSource
            // 
            comboBoxSource.FormattingEnabled = true;
            comboBoxSource.Location = new Point(6, 138);
            comboBoxSource.Name = "comboBoxSource";
            comboBoxSource.Size = new Size(192, 23);
            comboBoxSource.TabIndex = 11;
            // 
            // addButton
            // 
            addButton.Location = new Point(6, 167);
            addButton.Name = "addButton";
            addButton.Size = new Size(90, 23);
            addButton.TabIndex = 12;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(saveButton);
            groupBox1.Controls.Add(textBoxNumber);
            groupBox1.Controls.Add(addButton);
            groupBox1.Controls.Add(textBoxSender);
            groupBox1.Controls.Add(comboBoxSource);
            groupBox1.Controls.Add(textBoxRecipient);
            groupBox1.Controls.Add(textBoxAdressee);
            groupBox1.Location = new Point(854, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(208, 396);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(108, 167);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(90, 23);
            saveButton.TabIndex = 13;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // OutMessagesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 450);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView);
            Controls.Add(DeleteButton);
            Name = "OutMessagesForm";
            Text = "OutMessagesForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button DeleteButton;
        private DataGridView dataGridView;
        private TextBox textBoxNumber;
        private TextBox textBoxSender;
        private TextBox textBoxRecipient;
        private TextBox textBoxAdressee;
        private ComboBox comboBoxSource;
        private Button addButton;
        private GroupBox groupBox1;
        private Button saveButton;
    }
}