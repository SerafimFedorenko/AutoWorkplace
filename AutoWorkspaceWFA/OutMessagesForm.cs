using AutoWorkplaceLib.Data;
using AutoWorkplaceLib.Models;
using AutoWorkplaceLib.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoWorkspaceWFA
{
    public partial class OutMessagesForm : Form
    {
        private List<OutgoingMessage> messages = new List<OutgoingMessage>();
        readonly private OutMessageRepository messageRepository;
        private readonly string text1 = "Номер";
        private readonly string text2 = "Отправитель";
        private readonly string text3 = "Получатель";
        private readonly string text4 = "Кому";
        private readonly List<Source> sources = new List<Source>();
        public OutMessagesForm()
        {
            messageRepository = new OutMessageRepository();
            InitializeComponent();
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = false;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.ReadOnly = true;
            makeHelpTextVisible(textBoxNumber, text1);
            makeHelpTextVisible(textBoxSender, text2);
            makeHelpTextVisible(textBoxRecipient, text3);
            makeHelpTextVisible(textBoxAdressee, text4);
            //SourcesRepository sourcesRepository = new SourcesRepository();
            //sources = sourcesRepository.AllItems.OrderBy(s => s.Id).ToList();
            sources = new List<Source>() { new Source(1, "Электронная почта"), new Source(2, "Бумажная почта"), new Source(3, "СМДО") };
            comboBoxSource.Items.AddRange(sources.Select(s => s.Name).ToArray());
            loadMessages();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell.RowIndex >= 0 && dataGridView.CurrentCell.RowIndex < messages.Count)
            {
                messageRepository.Delete(messages[dataGridView.CurrentCell.RowIndex].Id);
                loadMessages();
            }
        }

        private void loadMessages()
        {
            messages = messageRepository.SelectAll();
            DataTable dt = new DataTable();
            dt.Columns.Add("Дата");
            dt.Columns.Add("Номер");
            dt.Columns.Add("От кого");
            dt.Columns.Add("Получатель");
            dt.Columns.Add("Кому");
            dt.Columns.Add("Источник");
            foreach (OutgoingMessage message in messages)
            {
                dt.Rows.Add(message.Date.ToShortDateString(), message.Number, message.Sender, message.Recipient, message.Adressee, message.Source.ToString());
            }
            dataGridView.DataSource = dt.DefaultView;
            dataGridView.Columns[0].Width = 80;
            dataGridView.Columns[1].Width = 80;
            dataGridView.Columns[2].Width = 150;
            dataGridView.Columns[3].Width = 150;
            dataGridView.Columns[4].Width = 150;
            dataGridView.Columns[5].Width = 150;
        }
        private void makeHelpTextVisible(TextBox textBox, string text)
        {
            if (textBox.Text.Length < 1)
            {
                textBox.Text = text;
                textBox.ForeColor = Color.Gray;
            }
        }

        private void makeHelpTextUnvisible(TextBox textBox)
        {
            if (textBox.ForeColor == Color.Gray)
            {
                textBox.Text = null;
                textBox.ForeColor = Color.Black;
            }
        }

        private void textBoxAdressee_Enter(object sender, EventArgs e)
        {
            makeHelpTextUnvisible(textBoxAdressee);
        }

        private void textBoxAdressee_Leave(object sender, EventArgs e)
        {
            makeHelpTextVisible(textBoxAdressee, text4);
        }

        private void textBoxRecipient_Enter(object sender, EventArgs e)
        {
            makeHelpTextUnvisible(textBoxRecipient);
        }

        private void textBoxRecipient_Leave(object sender, EventArgs e)
        {
            makeHelpTextVisible(textBoxRecipient, text3);
        }

        private void textBoxSender_Leave(object sender, EventArgs e)
        {
            makeHelpTextVisible(textBoxSender, text2);
        }

        private void textBoxSender_Enter(object sender, EventArgs e)
        {
            makeHelpTextUnvisible(textBoxSender);
        }

        private void textBoxNumber_Enter(object sender, EventArgs e)
        {
            makeHelpTextUnvisible(textBoxNumber);
        }

        private void textBoxNumber_Leave(object sender, EventArgs e)
        {
            makeHelpTextVisible(textBoxNumber, text1);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            messageRepository.Insert(new OutgoingMessage(
                0,
                DateTime.Now,
                textBoxNumber.Text,
                textBoxSender.Text,
                textBoxRecipient.Text,
                textBoxAdressee.Text,
                comboBoxSource.SelectedIndex + 1
                ));
            loadMessages();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            messageRepository.Update(new OutgoingMessage(
                messages[dataGridView.CurrentCell.RowIndex].Id,
                DateTime.Now,
                textBoxNumber.Text,
                textBoxSender.Text,
                textBoxRecipient.Text,
                textBoxAdressee.Text,
                comboBoxSource.SelectedIndex + 1
                ));
            loadMessages();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentCell.RowIndex >= 0 && dataGridView.CurrentCell.RowIndex < messages.Count)
            {
                makeHelpTextUnvisible(textBoxNumber);
                makeHelpTextUnvisible(textBoxSender);
                makeHelpTextUnvisible(textBoxRecipient);
                makeHelpTextUnvisible(textBoxAdressee);
                textBoxNumber.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxSender.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxRecipient.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxAdressee.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                comboBoxSource.SelectedIndex = sources
                    .Where(s => s.Name.Equals(dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString()))
                    .Select(s => s.Id)
                    .FirstOrDefault() - 1;
            }
        }
    }
}
