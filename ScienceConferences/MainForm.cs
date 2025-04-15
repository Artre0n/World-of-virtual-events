using ScienceConferences.Data;

namespace Science_Conferences
{
    public partial class MainForm : Form
    {
        private Conference? selectedConference;
        private ConferencesRepository conferencesRepository;

        public MainForm()
        {
            InitializeComponent();

            AppDbContext db = new AppDbContext();
            conferencesRepository = new ConferencesRepository(db);

            LoadConferencesToListBox();

        }
        #region Методы
        private void LoadConferencesToListBox()
        {
            listBoxOfConferences.DataSource = conferencesRepository.GetAllConferences();
            listBoxOfConferences.DisplayMember = "Title";
        }
        /// <summary>
        /// Метод добавления конференции в бд
        /// </summary>
        /// <param name="conference">конференция</param>
        public void AddConference(Conference conference)
        {
            conferencesRepository.AddConference(conference);
            LoadConferencesToListBox();
        }
        private void UpdateConference(Conference conference)
        {
            conferencesRepository.UpdateConference(conference);
        }
        private void DeleteConference(Conference conference)
        {
            conferencesRepository.DeleteConference(conference);
        }
        /// <summary>
        /// Метод перевода из TextBox в TimeSpan
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        /// <exception cref="FormatException"></exception>
        public TimeSpan GetTimeSpanFromTextBox(TextBox textBox) // Переделать без исключения
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
        /// <summary>
        /// Метод перевода из TimeSpan в TextBox
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public string GetStringFromTimeSpan(TimeSpan time)
        {
            return time.ToString();
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

                label1.Text = selectedConference.Title;

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
                label1.Text = string.Empty;
            }
        }
    }
}
