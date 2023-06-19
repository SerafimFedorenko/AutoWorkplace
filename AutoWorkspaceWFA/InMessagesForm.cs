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
    public partial class InMessagesForm : Form
    {
        private List<IncomingMessage> messages = new List<IncomingMessage>();
        readonly private InMessageRepository messageRepository;
        private readonly string textNumber = "Номер";
        private readonly string textSender = "Отправитель";
        private readonly string textRecipient = "Получатель";
        private readonly string textAdressee = "Кому";
        private readonly List<Source> sources = new List<Source>();
        public InMessagesForm()
        {
            InitializeComponent();
            messageRepository = new InMessageRepository();
            messages = messageRepository.SelectAll();
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = false;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.ReadOnly = true;
            groupBox1.Text = null;

            SourcesRepository sourcesRepository = new SourcesRepository();
            sources = sourcesRepository.AllItems.OrderBy(s => s.Id).ToList();
            //sources = new List<Source>() { new Source(1, "Электронная почта"), new Source(2, "Бумажная почта"), new Source(3, "СМДО") };
            comboBoxSource.Items.AddRange(sources.Select(s => s.Name).ToArray());
            loadMessages(messages);
            dateTimePickerFrom.Value = messages.OrderBy(m => m.Date).FirstOrDefault().Date;
            dateTimePickerTo.Value = messages.OrderByDescending(m => m.Date).FirstOrDefault().Date;
            makeHelpTextVisible(textBoxSender, textSender);
            makeHelpTextVisible(textBoxRecipient, textRecipient);
            makeHelpTextVisible(textBoxAdressee, textAdressee);
            makeHelpTextVisible(textBoxSenderFilter, textSender);
            makeHelpTextVisible(textBoxRecipientFilter, textRecipient);
            makeHelpTextVisible(textBoxAdresseeFilter, textAdressee);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.CurrentCell.RowIndex >= 0 && dataGridView.CurrentCell.RowIndex < messages.Count)
                {
                    messageRepository.Delete(messages[dataGridView.CurrentCell.RowIndex].Id);
                    //messages = messageRepository.SelectAll();
                    //loadMessages(messages);
                    loadFiltered();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadMessages(List<IncomingMessage> messages)
        {
            this.messages = messages;
            DataTable dt = new DataTable();
            dt.Columns.Add("Дата");
            dt.Columns.Add("От кого");
            dt.Columns.Add("Получатель");
            dt.Columns.Add("Кому");
            dt.Columns.Add("Источник");
            foreach (IncomingMessage message in messages)
            {
                dt.Rows.Add(message.Date.ToShortDateString(), message.Sender, message.Recipient, message.Adressee, message.Source.ToString());
            }
            dataGridView.DataSource = dt.DefaultView;
            dataGridView.Columns[0].Width = 80;
            dataGridView.Columns[1].Width = 150;
            dataGridView.Columns[2].Width = 150;
            dataGridView.Columns[3].Width = 150;
            dataGridView.Columns[4].Width = 150;
        }
        private void makeHelpTextVisible(TextBox textBox, string text)
        {
            if (textBox.Text.Length < 1)
            {
                textBox.ForeColor = Color.Gray;
                textBox.Text = text;
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
            makeHelpTextVisible(textBoxAdressee, textAdressee);
        }

        private void textBoxRecipient_Enter(object sender, EventArgs e)
        {
            makeHelpTextUnvisible(textBoxRecipient);
        }

        private void textBoxRecipient_Leave(object sender, EventArgs e)
        {
            makeHelpTextVisible(textBoxRecipient, textRecipient);
        }

        private void textBoxSender_Leave(object sender, EventArgs e)
        {
            makeHelpTextVisible(textBoxSender, textSender);
        }

        private void textBoxSender_Enter(object sender, EventArgs e)
        {
            makeHelpTextUnvisible(textBoxSender);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                messageRepository.Insert(new IncomingMessage(
                    0,
                    DateTime.Now,
                    textBoxSender.Text,
                    textBoxRecipient.Text,
                    textBoxAdressee.Text,
                    comboBoxSource.SelectedIndex + 1
                    ));
                //messages = messageRepository.SelectAll();
                //loadMessages(messages);
                loadFiltered();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                messageRepository.Update(new IncomingMessage(
                messages[dataGridView.CurrentCell.RowIndex].Id,
                DateTime.Now,
                textBoxSender.Text,
                textBoxRecipient.Text,
                textBoxAdressee.Text,
                comboBoxSource.SelectedIndex + 1
                ));
                //messages = messageRepository.SelectAll();
                //loadMessages(messages);
                loadFiltered();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentCell.RowIndex >= 0 && dataGridView.CurrentCell.RowIndex < messages.Count)
            {
                makeHelpTextUnvisible(textBoxSender);
                makeHelpTextUnvisible(textBoxRecipient);
                makeHelpTextUnvisible(textBoxAdressee);
                textBoxSender.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxRecipient.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxAdressee.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                comboBoxSource.SelectedIndex = sources
                    .Where(s => s.Name.Equals(dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString()))
                    .Select(s => s.Id)
                    .FirstOrDefault() - 1;
            }
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            loadFiltered();
        }

        private void dateTimePickerFrom_DropDown(object sender, EventArgs e)
        {
            dateTimePickerFrom.ValueChanged -= dateTimePickerFrom_ValueChanged;
        }

        private void dateTimePickerFrom_CloseUp(object sender, EventArgs e)
        {
            dateTimePickerFrom.ValueChanged += dateTimePickerFrom_ValueChanged;
            dateTimePickerFrom_ValueChanged(sender, e);
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            loadFiltered();
        }
        private void dateTimePickerTo_DropDown(object sender, EventArgs e)
        {
            dateTimePickerTo.ValueChanged -= dateTimePickerTo_ValueChanged;
        }

        private void dateTimePickerTo_CloseUp(object sender, EventArgs e)
        {
            dateTimePickerTo.ValueChanged += dateTimePickerTo_ValueChanged;
            dateTimePickerTo_ValueChanged(sender, e);
        }

        private void textBoxSenderFilter_TextChanged(object sender, EventArgs e)
        {
            loadFiltered();
        }

        private void textBoxRecipientFilter_TextChanged(object sender, EventArgs e)
        {
            loadFiltered();
        }

        private void textBoxAdresseeFilter_TextChanged(object sender, EventArgs e)
        {
            loadFiltered();
        }

        private void textBoxSenderFilter_Enter(object sender, EventArgs e)
        {
            makeHelpTextUnvisible(textBoxSenderFilter);
        }

        private void textBoxSenderFilter_Leave(object sender, EventArgs e)
        {
            makeHelpTextVisible(textBoxSenderFilter, textSender);
        }

        private void textBoxRecipientFilter_Enter(object sender, EventArgs e)
        {
            makeHelpTextUnvisible(textBoxRecipientFilter);
        }

        private void textBoxRecipientFilter_Leave(object sender, EventArgs e)
        {
            makeHelpTextVisible(textBoxRecipientFilter, textRecipient);
        }

        private void textBoxAdresseeFilter_Enter(object sender, EventArgs e)
        {
            makeHelpTextUnvisible(textBoxAdresseeFilter);
        }

        private void textBoxAdresseeFilter_Leave(object sender, EventArgs e)
        {
            makeHelpTextVisible(textBoxAdresseeFilter, textAdressee);
        }
        private void loadFiltered()
        {
            var messages = messageRepository.SelectAll()
                .Where(m => m.Date > dateTimePickerFrom.Value && m.Date < dateTimePickerTo.Value);
            if (textBoxSenderFilter.Text.Length > 0 && textBoxSenderFilter.ForeColor == Color.Black)
            {
                messages = messages.Where(m => m.Sender.Contains(textBoxSenderFilter.Text));
            }
            if (textBoxRecipientFilter.Text.Length > 0 && textBoxRecipientFilter.ForeColor == Color.Black)
            {
                messages = messages.Where(m => m.Sender.Contains(textBoxRecipientFilter.Text));
            }
            if (textBoxAdresseeFilter.Text.Length > 0 && textBoxAdresseeFilter.ForeColor == Color.Black)
            {
                messages = messages.Where(m => m.Adressee.Contains(textBoxAdresseeFilter.Text));
            }
            this.messages = messages.ToList();
            loadMessages(this.messages);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            messages = messageRepository.SelectAll().ToList();
            dateTimePickerFrom.Value = messages.OrderBy(m => m.Date).FirstOrDefault().Date;
            dateTimePickerTo.Value = messages.OrderByDescending(m => m.Date).FirstOrDefault().Date;
            textBoxSenderFilter.Text = null;
            textBoxRecipientFilter.Text = null;
            textBoxAdresseeFilter.Text = null;
            makeHelpTextVisible(textBoxSenderFilter, textSender);
            makeHelpTextVisible(textBoxRecipientFilter, textRecipient);
            makeHelpTextVisible(textBoxAdresseeFilter, textAdressee);
            loadMessages(messages);
        }
    }
}
