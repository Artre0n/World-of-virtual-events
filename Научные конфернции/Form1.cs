using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Научные_конфернции
{
    public partial class Form1 : Form
    {
        private ApplicationContext context;
        private BindingSource conferencesBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            context = new ApplicationContext();
            context.Database.EnsureCreated();
            LoadConferencesToListBox();
            
        }
        private void LoadConferencesToListBox()
        {
            listBox.Items.Clear();
            var conferences = context.Conferences.ToList();
            foreach (var ev in conferences)
            {
                listBox.Items.Add(ev.Title);
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
