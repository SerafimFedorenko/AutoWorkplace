using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoWorkplaceLib.Data;
using AutoWorkplaceLib.Models;
using AutoWorkplaceLib.Repositories;

namespace AutoWorkspaceWFA
{
    public partial class InMessagesForm : Form
    {
        private List<IncomingMessage> messages = new List<IncomingMessage>();
        readonly private InMessageRepository messageRepository;
        private readonly string text2 = "Отправитель";
        private readonly string text3 = "Получатель";
        private readonly string text4 = "От кого";
        public InMessagesForm()
        {
            AutoWorkplaceContext db = new AutoWorkplaceContext();
            messageRepository = new InMessageRepository();
            InitializeComponent();
            LoadMessages();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell.RowIndex >= 0)
            {
                messageRepository.Delete(messages[dataGridView.CurrentCell.RowIndex].Id);
                LoadMessages();
            }
            LoadMessages();
        }
        private void LoadMessages()
        {
            messages = messageRepository.SelectAll();
            DataTable dt = new DataTable();
            dt.Columns.Add("Дата");
            dt.Columns.Add("Отправитель");
            dt.Columns.Add("От кого");
            dt.Columns.Add("Кому");
            dt.Columns.Add("Источник");
            foreach (IncomingMessage message in messages)
            {
                dt.Rows.Add(message.Date.ToShortDateString(), message.Sender, message.Adressee, message.Recipient, message.Source.ToString());
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
    }
}
