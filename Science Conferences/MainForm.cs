using ClosedXML.Excel;
using System.Text.RegularExpressions;

namespace Science_Conferences
{
    /// <summary>
    /// Главная форма 
    /// </summary>
    public partial class MainForm : Form
    {
        private ApplicationContext db;
        private Conference? selectedConference;

        /// <summary>
        /// Конструктор главной формы
        /// </summary>
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
        public TimeSpan ConvertTextBoxToTimeSpan(MaskedTextBox textBox)
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
        /// <returns>время в формате string</returns>
        public string ConvertTimeSpanToString(TimeSpan time)
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
                maskedTextBoxTimeEditing.Text = ConvertTimeSpanToString(selectedConference.Time);
                comboBoxCategoryEditing.SelectedItem = selectedConference.Category;
                textBoxParticipantsEditing.Text = selectedConference.Participants;

                label1.Text = selectedConference.Title;

                groupBoxEditing.Visible = true;
                groupBoxEditing.Enabled = false;
            }
            else
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
                    selectedConference = null;
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
            if (selectedConference != null)
            {
                groupBoxEditing.Enabled = true;
                groupBoxEditing.Visible = true;
            }
        }

        /// <summary>
        /// Событие при клике на кнопку изменить
        /// </summary>
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxTitleEditing.Text) &&
                maskedTextBoxTimeEditing.Text.Replace(":", "").Trim('_').Length != 0 &&
                !string.IsNullOrEmpty(comboBoxCategoryEditing.Text))
            {
                try
                {
                    selectedConference.Title = textBoxTitleEditing.Text;
                    selectedConference.Description = textBoxDescriptionEditing.Text;
                    selectedConference.Date = dateTimePickerEditing.Value;
                    selectedConference.Time = ConvertTextBoxToTimeSpan(maskedTextBoxTimeEditing);
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
            else
            {
                MessageBox.Show("Заполните обязательные поля", "Оповещение", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // каждый символ в базу идет, слишком перегружает, через выборку из базы и её фильтровать но в момент может
            // редактировать кто то
            // нагрузочное тестирование
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

        #region Обработка

        /// <summary>
        /// Обработка поля Название(обязательное поле)
        /// </summary>
        private void textBoxTitleEditing_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTitleEditing.Text))
            {
                textBoxTitleEditing.Focus();
                textBoxTitleEditing.BackColor = System.Drawing.Color.Red;
                e.Cancel = true;
            }
            else
            {
                textBoxTitleEditing.BackColor = System.Drawing.Color.White;
            }
        }

        /// <summary>
        /// Обработка поля Время (обязательное поле, соотаветствие формата времени)
        /// </summary>
        private void maskedTextBoxTimeEditing_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string pattern = @"^(?:[01]?[0-9]|2[0-3]):[0-5][0-9](?::[0-5][0-9])?$";
            if (!Regex.IsMatch(maskedTextBoxTimeEditing.Text, pattern))
            {
                MessageBox.Show("Введите корректное время в формате ЧЧ:мм", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedTextBoxTimeEditing.Focus();
                maskedTextBoxTimeEditing.BackColor = System.Drawing.Color.Red;
                e.Cancel = true;
            }
            else
            {
                maskedTextBoxTimeEditing.BackColor = System.Drawing.Color.White;
            }
        }

        /// <summary>
        /// Обработка поля Категория(обязательное поле) 
        /// </summary>
        private void comboBoxCategoryEditing_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxCategoryEditing.Text))
            {
                comboBoxCategoryEditing.Focus();
                comboBoxCategoryEditing.BackColor = System.Drawing.Color.Red;
                e.Cancel = true;
            }
            else
            {
                comboBoxCategoryEditing.BackColor = System.Drawing.Color.White;
            }
        }

        /// <summary>
        /// Обработка поля Дата(обязательное поле, нельзя поставить дату раньше сегодняшней)
        /// </summary>
        private void dateTimePickerEditing_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dateTimePickerEditing.Value.Date < DateTime.Today.Date)
            {
                MessageBox.Show("Некорректный ввод даты: прошедшую дату поставить нельзя", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePickerEditing.Focus();
                comboBoxCategoryEditing.BackColor = System.Drawing.Color.Red;
                e.Cancel = true;
            }
            else
            {
                dateTimePickerEditing.BackColor = System.Drawing.Color.White;
            }
        }

        #endregion

        #region Генерация отчета

        /// <summary>
        /// Метод, генерирующий отчет
        /// </summary>
        private void GenerateReport()
        {
            try
            {
                var conferences = db.Conferences.ToList();

                var report = new XLWorkbook();
                var worksheet = report.Worksheets.Add("Conferences");

                worksheet.Cell(1, 1).Value = "Id";
                worksheet.Cell(1, 2).Value = "Title";
                worksheet.Cell(1, 3).Value = "Description";
                worksheet.Cell(1, 4).Value = "Date";
                worksheet.Cell(1, 5).Value = "Time";
                worksheet.Cell(1, 6).Value = "Category";
                worksheet.Cell(1, 7).Value = "Participants";
                

                int row = 2;
                foreach (var conference in conferences)
                {
                    worksheet.Cell(row, 1).Value = conference.ConferenceId;
                    worksheet.Cell(row, 2).Value = conference.Title;
                    worksheet.Cell(row, 3).Value = conference.Description;
                    worksheet.Cell(row, 4).Value = conference.Date.ToShortDateString();
                    worksheet.Cell(row, 5).Value = conference.Time;
                    worksheet.Cell(row, 6).Value = conference.Category;
                    worksheet.Cell(row, 7).Value = conference.Participants;
                    row++;
                }

                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, $"Конференции_{DateTime.Now:dd.MM.yyyy}.xlsx");

                report.SaveAs(filePath);

                MessageBox.Show($"Отчёт {filePath} сохранён", "Оповещение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании отчёта: {ex.Message}");            
            }
        }
        /// <summary>
        /// Событие при закрытии приложения
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GenerateReport();
        }
        #endregion
        #endregion

    }
}
