using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Научные_конфернции
{
    public partial class Form1 : Form
    {
        private ApplicationContext context;

        public Form1()
        {
            InitializeComponent();
            context = new ApplicationContext();
            context.Database.EnsureCreated();
            LoadConferencesToListBox();

        }
        private void LoadConferencesToListBox()
        {
            context.ChangeTracker.DetectChanges();
            listBox.Items.Clear();
            var conferences = context.Conferences.ToList();
            foreach (var one in conferences)
            {
                listBox.Items.Add(one.Title);
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            ClearInputs();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void ClearInputs()
        {
            textBoxTitle.Clear();
            textBoxDescription.Clear();
            dateTimePicker1.Value = DateTime.Today;
            textBoxTime.Clear();
            textBoxCategory.Clear();
            textBoxParticipants.Clear();
        }
        private TimeSpan GetTimeSpanFromTextBox(TextBox textBox)
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
        private void SaveButton_Click(object sender, EventArgs e)
        {
            var newConference = new Conference
            {
                Title = textBoxTitle.Text,
                Description = textBoxDescription.Text,
                Date = dateTimePicker1.Value,
                Time = GetTimeSpanFromTextBox(textBoxTime),
                Category = textBoxCategory.Text,
                Participants = textBoxParticipants.Text
            };

            context.Conferences.Add(newConference);
            context.SaveChanges();

            LoadConferencesToListBox();
            groupBox1.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            ClearInputs();
        }

        private void IconSearch_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
