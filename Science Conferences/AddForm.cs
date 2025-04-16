using System.Linq;
using System.Text.RegularExpressions;

namespace Science_Conferences
{
    /// <summary>
    /// Форма добавления
    /// </summary>
    public partial class AddForm : Form
    {
        private MainForm mainForm;
        /// <summary>
        /// Конструктор формы добавления
        /// </summary>
        /// <param name="mainForm">ссылка на главную форму</param>
        public AddForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        /// <summary>
        /// Событие при клике на кнопку сохранить
        /// </summary>
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
                //Константы в файлы ресурсов
            }
        }
        /// <summary>
        /// Событие при клике на кнопку отмена
        /// </summary>
        private void CancelButtonAdding_Click(object sender, EventArgs e) => Close();

        #region Обработка
        /// <summary>
        /// Обработка поля Название(обязательное поле)
        /// </summary>
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
        /// <summary>
        /// Обработка поля Время (обязательное поле, соотаветствие формата времени)
        /// </summary>
        private void maskedTextBoxTimeAdding_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string pattern = @"^(?:[01]?[0-9]|2[0-3]):[0-5][0-9](?::[0-5][0-9])?$";
            if (!Regex.IsMatch(maskedTextBoxTimeAdding.Text, pattern))
            {
                MessageBox.Show("Введите корректное время в формате ЧЧ:мм", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedTextBoxTimeAdding.Focus();
                maskedTextBoxTimeAdding.BackColor = Color.Red;
                e.Cancel = true;
            }
            else
            {
                maskedTextBoxTimeAdding.BackColor = Color.White;
            }
        }
        /// <summary>
        /// Обработка поля Категория(обязательное поле) 
        /// </summary>
        private void comboBoxCategoryAdding_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxCategoryAdding.Text))
            {
                comboBoxCategoryAdding.Focus();
                comboBoxCategoryAdding.BackColor = Color.Red;
                e.Cancel = true;
            }
            if (!comboBoxCategoryAdding.Items.Contains(comboBoxCategoryAdding.Text))
            {
                MessageBox.Show("Выберите категорию из предложенных", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxCategoryAdding.Focus();
                comboBoxCategoryAdding.BackColor = Color.Red;
                e.Cancel = true;
            }
            else
            {
                comboBoxCategoryAdding.BackColor = Color.White;
            }
        }
        /// <summary>
        /// Обработка поля Дата(обязательное поле, нельзя поставить дату раньше сегодняшней)
        /// </summary>
        private void dateTimePickerAdding_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dateTimePickerAdding.Value.Date < DateTime.Today.Date)
            {
                MessageBox.Show("Некорректный ввод даты: прошедшую дату поставить нельзя", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePickerAdding.Focus();
                comboBoxCategoryAdding.BackColor = Color.Red;
                e.Cancel = true;
            }
            else
            {
                dateTimePickerAdding.BackColor = Color.White;
            }
        }
        #endregion
    }
}
