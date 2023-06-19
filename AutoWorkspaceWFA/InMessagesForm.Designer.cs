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
            saveButton = new Button();
            addButton = new Button();
            comboBoxSource = new ComboBox();
            textBoxRecipient = new TextBox();
            textBoxAdressee = new TextBox();
            textBoxSender = new TextBox();
            groupBox2 = new GroupBox();
            resetButton = new Button();
            textBoxAdresseeFilter = new TextBox();
            dateTimePickerFrom = new DateTimePicker();
            textBoxRecipientFilter = new TextBox();
            label1 = new Label();
            textBoxSenderFilter = new TextBox();
            dateTimePickerTo = new DateTimePicker();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(saveButton);
            groupBox1.Controls.Add(addButton);
            groupBox1.Controls.Add(comboBoxSource);
            groupBox1.Controls.Add(textBoxRecipient);
            groupBox1.Controls.Add(textBoxAdressee);
            groupBox1.Controls.Add(textBoxSender);
            groupBox1.Location = new Point(789, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(202, 176);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление и изменение";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(108, 138);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(83, 23);
            saveButton.TabIndex = 5;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(6, 138);
            addButton.Name = "addButton";
            addButton.Size = new Size(83, 23);
            addButton.TabIndex = 4;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
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
            textBoxRecipient.Enter += textBoxRecipient_Enter;
            textBoxRecipient.Leave += textBoxRecipient_Leave;
            // 
            // textBoxAdressee
            // 
            textBoxAdressee.Location = new Point(6, 51);
            textBoxAdressee.Name = "textBoxAdressee";
            textBoxAdressee.Size = new Size(185, 23);
            textBoxAdressee.TabIndex = 1;
            textBoxAdressee.Enter += textBoxAdressee_Enter;
            textBoxAdressee.Leave += textBoxAdressee_Leave;
            // 
            // textBoxSender
            // 
            textBoxSender.Location = new Point(6, 22);
            textBoxSender.Name = "textBoxSender";
            textBoxSender.Size = new Size(185, 23);
            textBoxSender.TabIndex = 0;
            textBoxSender.Enter += textBoxSender_Enter;
            textBoxSender.Leave += textBoxSender_Leave;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(resetButton);
            groupBox2.Controls.Add(textBoxAdresseeFilter);
            groupBox2.Controls.Add(dateTimePickerFrom);
            groupBox2.Controls.Add(textBoxRecipientFilter);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBoxSenderFilter);
            groupBox2.Controls.Add(dateTimePickerTo);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(789, 202);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(202, 236);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Фильтры";
            // 
            // resetButton
            // 
            resetButton.Location = new Point(8, 207);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(183, 23);
            resetButton.TabIndex = 29;
            resetButton.Text = "Сбросить фильтры";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // textBoxAdresseeFilter
            // 
            textBoxAdresseeFilter.Location = new Point(8, 179);
            textBoxAdresseeFilter.Name = "textBoxAdresseeFilter";
            textBoxAdresseeFilter.Size = new Size(183, 23);
            textBoxAdresseeFilter.TabIndex = 28;
            textBoxAdresseeFilter.TextChanged += textBoxAdresseeFilter_TextChanged;
            textBoxAdresseeFilter.Enter += textBoxAdresseeFilter_Enter;
            textBoxAdresseeFilter.Leave += textBoxAdresseeFilter_Leave;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Location = new Point(8, 36);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(183, 23);
            dateTimePickerFrom.TabIndex = 22;
            dateTimePickerFrom.ValueChanged += dateTimePickerFrom_ValueChanged;
            // 
            // textBoxRecipientFilter
            // 
            textBoxRecipientFilter.Location = new Point(8, 150);
            textBoxRecipientFilter.Name = "textBoxRecipientFilter";
            textBoxRecipientFilter.Size = new Size(183, 23);
            textBoxRecipientFilter.TabIndex = 27;
            textBoxRecipientFilter.TextChanged += textBoxRecipientFilter_TextChanged;
            textBoxRecipientFilter.Enter += textBoxRecipientFilter_Enter;
            textBoxRecipientFilter.Leave += textBoxRecipientFilter_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 18);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 23;
            label1.Text = "С";
            // 
            // textBoxSenderFilter
            // 
            textBoxSenderFilter.Location = new Point(8, 121);
            textBoxSenderFilter.Name = "textBoxSenderFilter";
            textBoxSenderFilter.Size = new Size(183, 23);
            textBoxSenderFilter.TabIndex = 26;
            textBoxSenderFilter.TextChanged += textBoxSenderFilter_TextChanged;
            textBoxSenderFilter.Enter += textBoxSenderFilter_Enter;
            textBoxSenderFilter.Leave += textBoxSenderFilter_Leave;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Location = new Point(8, 84);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(183, 23);
            dateTimePickerTo.TabIndex = 24;
            dateTimePickerTo.ValueChanged += dateTimePickerTo_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 66);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 25;
            label2.Text = "По";
            // 
            // InMessagesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView);
            Controls.Add(DeleteButton);
            Name = "InMessagesForm";
            Text = "Входящие письма";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private Button saveButton;
        private Button addButton;
        private GroupBox groupBox2;
        private Button resetButton;
        private TextBox textBoxAdresseeFilter;
        private DateTimePicker dateTimePickerFrom;
        private TextBox textBoxRecipientFilter;
        private Label label1;
        private TextBox textBoxSenderFilter;
        private DateTimePicker dateTimePickerTo;
        private Label label2;
    }
}