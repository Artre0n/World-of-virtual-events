namespace Science_Conferences
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
            try
            {
                var newConference = new Conference
                {
                    Title = textBoxTitleAdding.Text,
                    Description = textBoxDescriptionAdding.Text,
                    Date = dateTimePickerAdding.Value,
                    Time = mainForm.GetTimeSpanFromTextBox(maskedTextBoxTimeAdding),
                    Category = comboBoxCategoryAdding.Text,
                    Participants = textBoxParticipantsAdding.Text
                };

                mainForm.AddConference(newConference);
                MessageBox.Show("Конференция добавлена", "Оповещение", MessageBoxButtons.OK);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButtonAdding_Click(object sender, EventArgs e) => Close();

        #region Обработка
        private void textBoxTitleAdding_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTitleAdding.Text))
            {
                textBoxTitleAdding.Focus();
                textBoxTitleAdding.BackColor = Color.Red;
                e.Cancel = true;
            }
            else
            {
                textBoxTitleAdding.BackColor = Color.White;
            }
        }
        //private void maskedTextBoxTimeAdding_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(maskedTextBoxTimeAdding.Text))
        //    {
        //        maskedTextBoxTimeAdding.Focus();
        //        maskedTextBoxTimeAdding.BackColor = Color.Red;
        //        e.Cancel = true;
        //    }
        //    //if ()
        //    //{
        //    //    //TODO: доделать
        //    //}
        //    else
        //    {
        //        maskedTextBoxTimeAdding.BackColor = Color.White;
        //    }
        //}
        private void comboBoxCategoryAdding_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxCategoryAdding.Text))
            {
                comboBoxCategoryAdding.Focus();
                comboBoxCategoryAdding.BackColor = Color.Red;
                e.Cancel = true;
            }
            else
            {
                comboBoxCategoryAdding.BackColor = Color.White;
            }
        }

        #endregion




    }
}
