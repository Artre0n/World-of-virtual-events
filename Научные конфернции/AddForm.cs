namespace Научные_конфернции
{
    public partial class AddForm : Form
    {
        private MainForm mainForm;
        public AddForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
       
        private void SaveButtonAdding_Click(object sender, EventArgs e)
        {
            var newConference = new Conference
            {
                Title = textBoxTitleAdding.Text,
                Description = textBoxDescriptionAdding.Text,
                Date = dateTimePickerAdding.Value,
                Time = mainForm.GetTimeSpanFromTextBox(textBoxTimeAdding),
                Category = comboBoxCategoryAdding.Text,
                Participants = textBoxParticipantsAdding.Text
            };

            mainForm.AddConference(newConference);
            MessageBox.Show("Конференция добавлена", "Оповещение", MessageBoxButtons.OK);
            Close();
        }

        private void CancelButtonAdding_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
