namespace Научные_конфернции
{
    public partial class MainForm : Form
    {
        private ApplicationContext db;
        private Conference? selectedConference;

        public MainForm()
        {
            InitializeComponent();
            db = new ApplicationContext();
            LoadConferencesToListBox();

        }
        #region Методы
        private void LoadConferencesToListBox()
        {
            var conferences = db.Conferences.ToList();
            listBoxOfConferences.DataSource = conferences;
            listBoxOfConferences.DisplayMember = "Title";
        }
        public void AddConference(Conference conference)
        {
            db.Conferences.Add(conference);
            db.SaveChanges();
            LoadConferencesToListBox();
        }
        private void UpdateConference(Conference conference)
        {
            db.Conferences.Update(conference);
            db.SaveChanges();
        }
        private void DeleteConference(Conference conference)
        {
            db.Conferences.Remove(conference);
            db.SaveChanges();
        }

        public TimeSpan GetTimeSpanFromTextBox(TextBox textBox)
        {
            if (TimeSpan.TryParse(textBox.Text, out TimeSpan result))
            {
                return result;
            }
            else
            {
                MessageBox.Show("Введите корректное время в формате ЧЧ:мм:сс", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                textBox.SelectAll();
                throw new FormatException("Некорректный формат времени");
            }
        }
        public string GetStringFromTimeSpan(TimeSpan time)
        {
            string timeString = time.ToString();
            return timeString;
        }
        #endregion

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm(this);
            addForm.ShowDialog();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }

        private void listBoxOfConferences_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedConference = (Conference?)listBoxOfConferences.SelectedItem;
            if (selectedConference != null)
            {
                textBoxTitleEditing.Text = selectedConference.Title;
                textBoxDescriptionEditing.Text = selectedConference.Description;
                dateTimePickerEditing.Value = selectedConference.Date;
                textBoxTimeEditing.Text = GetStringFromTimeSpan(selectedConference.Time);
                comboBoxCategoryEditing.SelectedItem = selectedConference.Category;
                textBoxParticipantsEditing.Text = selectedConference.Participants;

                MainHeading.Text = selectedConference.Title;

                groupBoxEditing.Visible = true;
                groupBoxEditing.Enabled = false;
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedConference != null)
            {
                DeleteConference(selectedConference);
                MessageBox.Show("Конференция удалена", "Оповещение", MessageBoxButtons.OK);
                LoadConferencesToListBox();
                groupBoxEditing.Visible = false;
                MainHeading.Clear();
            }
        }
    }
}
