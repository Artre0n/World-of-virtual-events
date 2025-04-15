namespace Science_Conferences
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
            listBoxOfConferences.DataSource = db.Conferences.ToList();
            listBoxOfConferences.DisplayMember = "Title";
        }
        /// <summary>
        /// Метод добавления конференции в бд
        /// </summary>
        /// <param name="conference">конференция</param>
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
        /// <summary>
        /// Метод перевода из TextBox в TimeSpan
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        /// <exception cref="FormatException"></exception>
        public TimeSpan GetTimeSpanFromTextBox(MaskedTextBox textBox) // Переделать без исключения
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
        #region Методы для событий
        #region ListOfConferences
        private void listBoxOfConferences_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedConference = (Conference?)listBoxOfConferences.SelectedItem;
            if (selectedConference != null)
            {
                textBoxTitleEditing.Text = selectedConference.Title;
                textBoxDescriptionEditing.Text = selectedConference.Description;
                dateTimePickerEditing.Value = selectedConference.Date;
                maskedTextBoxTimeEditing.Text = GetStringFromTimeSpan(selectedConference.Time);
                comboBoxCategoryEditing.SelectedItem = selectedConference.Category;
                textBoxParticipantsEditing.Text = selectedConference.Participants;

                label1.Text = selectedConference.Title;

                groupBoxEditing.Visible = true;
                groupBoxEditing.Enabled = false;
            }

        }
        #endregion
        #region Добавление
        private void AddButton_Click(object sender, EventArgs e) => new AddForm(this).ShowDialog();

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
        #endregion
        #region Редактирование
        private void EditButton_Click(object sender, EventArgs e)
        {
            groupBoxEditing.Enabled = true;
            groupBoxEditing.Visible = true;
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (selectedConference != null)
            {
                selectedConference.Title = textBoxTitleEditing.Text;
                selectedConference.Description = textBoxDescriptionEditing.Text;
                selectedConference.Date = dateTimePickerEditing.Value;
                selectedConference.Time = GetTimeSpanFromTextBox(maskedTextBoxTimeEditing);
                selectedConference.Category = comboBoxCategoryEditing.Text;
                selectedConference.Participants = textBoxParticipantsEditing.Text;
                UpdateConference(selectedConference);
                MessageBox.Show("Конференция обновлена", "Оповещение", MessageBoxButtons.OK);
                groupBoxEditing.Enabled = false;
                LoadConferencesToListBox();

            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            groupBoxEditing.Enabled = false;
            groupBoxEditing.Visible = false;
        }
        #endregion
        #endregion

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            listBoxOfConferences.DataSource = db.Conferences
                .Where(conf => conf.Title.ToLower()
                .Contains(SearchBar.Text.ToLower()))
                .ToList();
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSort.SelectedIndex)
            {
                case 0:
                    listBoxOfConferences.DataSource = db.Conferences
                        .OrderBy(conf => conf.Date)
                        .ThenBy(conf => conf.Time)
                        .ToList();
                    break;
                case 1:
                    listBoxOfConferences.DataSource = db.Conferences
                        .OrderBy(conf => conf.Category)
                        .ThenBy(conf => conf.Date)
                        .ToList();
                    break;
                case 2:
                    LoadConferencesToListBox();
                    break;
                default:
                    LoadConferencesToListBox();
                    break;
            }
        }
    }
}
