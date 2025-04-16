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
        /// <summary>
        /// Метод, загружающий конференции в listBox
        /// </summary>
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
        /// <summary>
        /// Метод, обновляющий конференцию (участвует при редактировании)
        /// </summary>
        /// <param name="conference">конференция</param>
        private void UpdateConference(Conference conference)
        {
            db.Conferences.Update(conference);
            db.SaveChanges();
        }
        /// <summary>
        /// Метод, удаляющий конференцию
        /// </summary>
        /// <param name="conference">конференция</param>
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

            MessageBox.Show("Введите корректное время в формате ЧЧ:мм", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);

            textBox.Focus();
            textBox.SelectAll();

            return TimeSpan.Zero;
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
        /// <summary>
        /// Событие при выборе элемента в ListBox
        /// </summary>
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
            else//Без else всегда приходит сюда
            {

                label1.Text = String.Empty;

                groupBoxEditing.Visible = false;
                groupBoxEditing.Enabled = false;
            }
        }
        #endregion

        #region Добавление
        /// <summary>
        /// Событие при клике на кнопку добавить
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e) => new AddForm(this).ShowDialog();
        /// <summary>
        /// Событие при клике на кнопку удалить
        /// </summary>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedConference != null && MessageBox.Show("Вы хотите удалить эту конференцию?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    DeleteConference(selectedConference);
                    MessageBox.Show("Конференция удалена", "Оповещение", MessageBoxButtons.OK);
                    LoadConferencesToListBox();
                    groupBoxEditing.Visible = false;
                    label1.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Редактирование
        /// <summary>
        /// Событие при клике на кнопку редактировать
        /// </summary>
        private void EditButton_Click(object sender, EventArgs e)
        {
            groupBoxEditing.Enabled = true;
            groupBoxEditing.Visible = true;
        }
        /// <summary>
        /// Событие при клике на кнопку изменить
        /// </summary>
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (selectedConference != null)
            {
                try
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
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Событие при клике на кнопку отмена
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            groupBoxEditing.Enabled = false;
            groupBoxEditing.Visible = false;
        }
        #endregion

        #region Сортировка
        /// <summary>
        /// Событие при написании текста в SearchBar
        /// </summary>
        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            listBoxOfConferences.DataSource = db.Conferences
                .Where(conf => conf.Title.ToLower()
                .Contains(SearchBar.Text.ToLower()))
                .ToList();
        }
        /// <summary>
        /// Событие при выборе элемента в comboBox
        /// </summary>
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
        #endregion

        #endregion


        
    }
}
