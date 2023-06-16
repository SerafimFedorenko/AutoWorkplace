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
        public InMessagesForm()
        {
            AutoWorkplaceContext db = new AutoWorkplaceContext();
            messageRepository = new InMessageRepository(db);
            InitializeComponent();
            LoadMessages();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (messagesGridView.CurrentCell.RowIndex >= 0)
            {
                messageRepository.Delete(messages[messagesGridView.CurrentCell.RowIndex].Id);
                LoadMessages();
            }
            LoadMessages();
        }

        private void MessagesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        private void LoadMessages()
        {
            messages = messageRepository.SelectAll();
            DataTable dt = new DataTable();
            dt.Columns.Add("Дата");
            dt.Columns.Add("Отправитель");
            dt.Columns.Add("Получатель");
            dt.Columns.Add("Источник");
            foreach (IncomingMessage message in messages)
            {
                dt.Rows.Add(message.Date, message.Sender, message.Recipient, message.Source.ToString());
            }
            messagesGridView.DataSource = dt.DefaultView;
        }

        private void messagesGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
