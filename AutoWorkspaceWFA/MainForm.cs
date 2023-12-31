using AutoWorkplaceLib.Data;

namespace AutoWorkspaceWFA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            DbInitializer.Initialize();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InMessagesForm inMessagesForm = new InMessagesForm();
            inMessagesForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OutMessagesForm outMessagesForm = new OutMessagesForm();
            outMessagesForm.ShowDialog();
        }
    }
}