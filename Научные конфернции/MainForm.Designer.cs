namespace Научные_конфернции
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            AddButton = new Button();
            DeleteButton = new Button();
            listBoxOfConferences = new ListBox();
            MainHeading = new TextBox();
            EditButton = new Button();
            SaveButtonEditing = new Button();
            SearchBar = new TextBox();
            IconSearch = new PictureBox();
            groupBoxEditing = new GroupBox();
            comboBoxCategoryEditing = new ComboBox();
            dateTimePickerEditing = new DateTimePicker();
            CancelButtonEditing = new Button();
            textBoxParticipantsEditing = new TextBox();
            textBoxTimeEditing = new TextBox();
            textBoxDescriptionEditing = new TextBox();
            textBoxTitleEditing = new TextBox();
            participantsLabelEditing = new Label();
            CategoryLabelEditing = new Label();
            timeLabelEditing = new Label();
            dateLabelEditing = new Label();
            describtionLabelEditing = new Label();
            titleLabelEditing = new Label();
            label6 = new Label();
            panel1 = new Panel();
            labelListOfConferences = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)IconSearch).BeginInit();
            groupBoxEditing.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Location = new Point(13, 673);
            AddButton.Margin = new Padding(4, 3, 4, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(134, 38);
            AddButton.TabIndex = 0;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DeleteButton.Location = new Point(208, 673);
            DeleteButton.Margin = new Padding(4, 2, 4, 2);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(123, 38);
            DeleteButton.TabIndex = 1;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // listBoxOfConferences
            // 
            listBoxOfConferences.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxOfConferences.BackColor = SystemColors.Menu;
            listBoxOfConferences.BorderStyle = BorderStyle.FixedSingle;
            listBoxOfConferences.FormattingEnabled = true;
            listBoxOfConferences.ItemHeight = 15;
            listBoxOfConferences.Location = new Point(11, 84);
            listBoxOfConferences.Margin = new Padding(4, 2, 4, 2);
            listBoxOfConferences.Name = "listBoxOfConferences";
            listBoxOfConferences.Size = new Size(320, 572);
            listBoxOfConferences.TabIndex = 3;
            listBoxOfConferences.SelectedIndexChanged += listBoxOfConferences_SelectedIndexChanged;
            // 
            // MainHeading
            // 
            MainHeading.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MainHeading.Cursor = Cursors.No;
            MainHeading.Enabled = false;
            MainHeading.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainHeading.Location = new Point(438, 39);
            MainHeading.Margin = new Padding(4, 3, 4, 3);
            MainHeading.Name = "MainHeading";
            MainHeading.ReadOnly = true;
            MainHeading.Size = new Size(702, 33);
            MainHeading.TabIndex = 5;
            MainHeading.TextAlign = HorizontalAlignment.Center;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            EditButton.Location = new Point(714, 675);
            EditButton.Margin = new Padding(4, 3, 4, 3);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(217, 36);
            EditButton.TabIndex = 6;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // SaveButtonEditing
            // 
            SaveButtonEditing.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SaveButtonEditing.Location = new Point(7, 549);
            SaveButtonEditing.Margin = new Padding(4, 3, 4, 3);
            SaveButtonEditing.Name = "SaveButtonEditing";
            SaveButtonEditing.Size = new Size(134, 36);
            SaveButtonEditing.TabIndex = 7;
            SaveButtonEditing.Text = "Сохранить";
            SaveButtonEditing.UseVisualStyleBackColor = true;
            SaveButtonEditing.Click += SaveButton_Click;
            // 
            // SearchBar
            // 
            SearchBar.BackColor = SystemColors.Window;
            SearchBar.BorderStyle = BorderStyle.FixedSingle;
            SearchBar.Location = new Point(31, 58);
            SearchBar.Margin = new Padding(4, 2, 4, 2);
            SearchBar.Name = "SearchBar";
            SearchBar.Size = new Size(300, 23);
            SearchBar.TabIndex = 9;
            // 
            // IconSearch
            // 
            IconSearch.BackColor = SystemColors.ControlLightLight;
            IconSearch.BackgroundImageLayout = ImageLayout.None;
            IconSearch.BorderStyle = BorderStyle.FixedSingle;
            IconSearch.Image = Properties.Resources.icon_magnifier;
            IconSearch.Location = new Point(11, 58);
            IconSearch.Margin = new Padding(4, 2, 4, 2);
            IconSearch.Name = "IconSearch";
            IconSearch.Size = new Size(24, 23);
            IconSearch.TabIndex = 10;
            IconSearch.TabStop = false;
            // 
            // groupBoxEditing
            // 
            groupBoxEditing.Controls.Add(comboBoxCategoryEditing);
            groupBoxEditing.Controls.Add(dateTimePickerEditing);
            groupBoxEditing.Controls.Add(CancelButtonEditing);
            groupBoxEditing.Controls.Add(textBoxParticipantsEditing);
            groupBoxEditing.Controls.Add(textBoxTimeEditing);
            groupBoxEditing.Controls.Add(SaveButtonEditing);
            groupBoxEditing.Controls.Add(textBoxDescriptionEditing);
            groupBoxEditing.Controls.Add(textBoxTitleEditing);
            groupBoxEditing.Controls.Add(participantsLabelEditing);
            groupBoxEditing.Controls.Add(CategoryLabelEditing);
            groupBoxEditing.Controls.Add(timeLabelEditing);
            groupBoxEditing.Controls.Add(dateLabelEditing);
            groupBoxEditing.Controls.Add(describtionLabelEditing);
            groupBoxEditing.Controls.Add(titleLabelEditing);
            groupBoxEditing.Font = new Font("Microsoft Sans Serif", 8.25F);
            groupBoxEditing.Location = new Point(438, 78);
            groupBoxEditing.Name = "groupBoxEditing";
            groupBoxEditing.Size = new Size(697, 591);
            groupBoxEditing.TabIndex = 11;
            groupBoxEditing.TabStop = false;
            groupBoxEditing.Visible = false;
            // 
            // comboBoxCategoryEditing
            // 
            comboBoxCategoryEditing.FormattingEnabled = true;
            comboBoxCategoryEditing.ImeMode = ImeMode.NoControl;
            comboBoxCategoryEditing.Items.AddRange(new object[] { "Физика", "Химия", "Биология", "Астрология", "Математика" });
            comboBoxCategoryEditing.Location = new Point(150, 365);
            comboBoxCategoryEditing.Name = "comboBoxCategoryEditing";
            comboBoxCategoryEditing.Size = new Size(481, 21);
            comboBoxCategoryEditing.TabIndex = 20;
            // 
            // dateTimePickerEditing
            // 
            dateTimePickerEditing.Location = new Point(150, 266);
            dateTimePickerEditing.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerEditing.Name = "dateTimePickerEditing";
            dateTimePickerEditing.Size = new Size(481, 20);
            dateTimePickerEditing.TabIndex = 13;
            // 
            // CancelButtonEditing
            // 
            CancelButtonEditing.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CancelButtonEditing.Location = new Point(556, 549);
            CancelButtonEditing.Margin = new Padding(4, 3, 4, 3);
            CancelButtonEditing.Name = "CancelButtonEditing";
            CancelButtonEditing.Size = new Size(134, 36);
            CancelButtonEditing.TabIndex = 16;
            CancelButtonEditing.Text = "Отмена";
            CancelButtonEditing.UseVisualStyleBackColor = true;
            CancelButtonEditing.Click += CancelButton_Click;
            // 
            // textBoxParticipantsEditing
            // 
            textBoxParticipantsEditing.Location = new Point(150, 414);
            textBoxParticipantsEditing.Multiline = true;
            textBoxParticipantsEditing.Name = "textBoxParticipantsEditing";
            textBoxParticipantsEditing.Size = new Size(481, 127);
            textBoxParticipantsEditing.TabIndex = 15;
            // 
            // textBoxTimeEditing
            // 
            textBoxTimeEditing.Location = new Point(150, 317);
            textBoxTimeEditing.Name = "textBoxTimeEditing";
            textBoxTimeEditing.Size = new Size(481, 20);
            textBoxTimeEditing.TabIndex = 13;
            // 
            // textBoxDescriptionEditing
            // 
            textBoxDescriptionEditing.Location = new Point(150, 115);
            textBoxDescriptionEditing.Multiline = true;
            textBoxDescriptionEditing.Name = "textBoxDescriptionEditing";
            textBoxDescriptionEditing.Size = new Size(481, 127);
            textBoxDescriptionEditing.TabIndex = 9;
            // 
            // textBoxTitleEditing
            // 
            textBoxTitleEditing.Location = new Point(150, 44);
            textBoxTitleEditing.Name = "textBoxTitleEditing";
            textBoxTitleEditing.Size = new Size(481, 20);
            textBoxTitleEditing.TabIndex = 8;
            // 
            // participantsLabelEditing
            // 
            participantsLabelEditing.AutoSize = true;
            participantsLabelEditing.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            participantsLabelEditing.Location = new Point(29, 405);
            participantsLabelEditing.Name = "participantsLabelEditing";
            participantsLabelEditing.Size = new Size(113, 30);
            participantsLabelEditing.TabIndex = 7;
            participantsLabelEditing.Text = "Участники";
            // 
            // CategoryLabelEditing
            // 
            CategoryLabelEditing.AutoSize = true;
            CategoryLabelEditing.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CategoryLabelEditing.Location = new Point(25, 356);
            CategoryLabelEditing.Name = "CategoryLabelEditing";
            CategoryLabelEditing.Size = new Size(111, 30);
            CategoryLabelEditing.TabIndex = 4;
            CategoryLabelEditing.Text = "Категория";
            // 
            // timeLabelEditing
            // 
            timeLabelEditing.AutoSize = true;
            timeLabelEditing.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            timeLabelEditing.Location = new Point(25, 308);
            timeLabelEditing.Name = "timeLabelEditing";
            timeLabelEditing.Size = new Size(74, 30);
            timeLabelEditing.TabIndex = 3;
            timeLabelEditing.Text = "Время";
            // 
            // dateLabelEditing
            // 
            dateLabelEditing.AutoSize = true;
            dateLabelEditing.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateLabelEditing.Location = new Point(29, 259);
            dateLabelEditing.Name = "dateLabelEditing";
            dateLabelEditing.Size = new Size(59, 30);
            dateLabelEditing.TabIndex = 2;
            dateLabelEditing.Text = "Дата";
            // 
            // describtionLabelEditing
            // 
            describtionLabelEditing.AutoSize = true;
            describtionLabelEditing.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            describtionLabelEditing.Location = new Point(25, 115);
            describtionLabelEditing.Name = "describtionLabelEditing";
            describtionLabelEditing.Size = new Size(109, 30);
            describtionLabelEditing.TabIndex = 1;
            describtionLabelEditing.Text = "Описание";
            // 
            // titleLabelEditing
            // 
            titleLabelEditing.AutoSize = true;
            titleLabelEditing.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            titleLabelEditing.Location = new Point(25, 34);
            titleLabelEditing.Name = "titleLabelEditing";
            titleLabelEditing.Size = new Size(105, 30);
            titleLabelEditing.TabIndex = 0;
            titleLabelEditing.Text = "Название";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 37);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(labelListOfConferences);
            panel1.Location = new Point(12, 29);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 25);
            panel1.TabIndex = 13;
            // 
            // labelListOfConferences
            // 
            labelListOfConferences.AutoSize = true;
            labelListOfConferences.BackColor = Color.CornflowerBlue;
            labelListOfConferences.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelListOfConferences.Location = new Point(51, 3);
            labelListOfConferences.Name = "labelListOfConferences";
            labelListOfConferences.Size = new Size(199, 25);
            labelListOfConferences.TabIndex = 0;
            labelListOfConferences.Text = "Список конференций";
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1140, 21);
            panel2.TabIndex = 14;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1142, 736);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(groupBoxEditing);
            Controls.Add(IconSearch);
            Controls.Add(SearchBar);
            Controls.Add(EditButton);
            Controls.Add(MainHeading);
            Controls.Add(listBoxOfConferences);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Controls.Add(panel2);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "ScienceManager";
            ((System.ComponentModel.ISupportInitialize)IconSearch).EndInit();
            groupBoxEditing.ResumeLayout(false);
            groupBoxEditing.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ListBox listBoxOfConferences;
        private System.Windows.Forms.TextBox MainHeading;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button SaveButtonEditing;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.PictureBox IconSearch;
        private GroupBox groupBoxEditing;
        private Label participantsLabelEditing;
        private Label CategoryLabelEditing;
        private Label timeLabelEditing;
        private Label dateLabelEditing;
        private Label describtionLabelEditing;
        private Label titleLabelEditing;
        private TextBox textBoxTitleEditing;
        private TextBox textBoxDescriptionEditing;
        private TextBox textBoxTimeEditing;
        private TextBox textBoxParticipantsEditing;
        private Button CancelButtonEditing;
        private Label label6;
        private DateTimePicker dateTimePickerEditing;
        private Panel panel1;
        private Label labelListOfConferences;
        private Panel panel2;
        private ComboBox comboBoxCategoryEditing;
    }
}
