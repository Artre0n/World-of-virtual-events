namespace Science_Conferences
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
            panel3 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)IconSearch).BeginInit();
            groupBoxEditing.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.BackColor = Color.CornflowerBlue;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Popup;
            AddButton.ForeColor = SystemColors.ControlLightLight;
            AddButton.Location = new Point(11, 622);
            AddButton.Margin = new Padding(4, 3, 4, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(156, 38);
            AddButton.TabIndex = 0;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DeleteButton.BackColor = Color.CornflowerBlue;
            DeleteButton.FlatStyle = FlatStyle.Popup;
            DeleteButton.ForeColor = SystemColors.ControlLightLight;
            DeleteButton.Location = new Point(175, 622);
            DeleteButton.Margin = new Padding(4, 3, 4, 3);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(156, 38);
            DeleteButton.TabIndex = 1;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // listBoxOfConferences
            // 
            listBoxOfConferences.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxOfConferences.BackColor = SystemColors.Menu;
            listBoxOfConferences.BorderStyle = BorderStyle.FixedSingle;
            listBoxOfConferences.FormattingEnabled = true;
            listBoxOfConferences.ItemHeight = 15;
            listBoxOfConferences.Location = new Point(11, 108);
            listBoxOfConferences.Margin = new Padding(4, 2, 4, 2);
            listBoxOfConferences.Name = "listBoxOfConferences";
            listBoxOfConferences.Size = new Size(320, 497);
            listBoxOfConferences.TabIndex = 3;
            listBoxOfConferences.SelectedIndexChanged += listBoxOfConferences_SelectedIndexChanged;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            EditButton.BackColor = Color.CornflowerBlue;
            EditButton.FlatStyle = FlatStyle.Popup;
            EditButton.ForeColor = SystemColors.ControlLightLight;
            EditButton.Location = new Point(11, 675);
            EditButton.Margin = new Padding(4, 3, 4, 3);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(320, 38);
            EditButton.TabIndex = 6;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = false;
            // 
            // SaveButtonEditing
            // 
            SaveButtonEditing.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SaveButtonEditing.BackColor = Color.CornflowerBlue;
            SaveButtonEditing.FlatStyle = FlatStyle.Popup;
            SaveButtonEditing.ForeColor = SystemColors.ControlLightLight;
            SaveButtonEditing.Location = new Point(370, 606);
            SaveButtonEditing.Margin = new Padding(4, 3, 4, 3);
            SaveButtonEditing.Name = "SaveButtonEditing";
            SaveButtonEditing.Size = new Size(156, 38);
            SaveButtonEditing.TabIndex = 7;
            SaveButtonEditing.Text = "Сохранить";
            SaveButtonEditing.UseVisualStyleBackColor = false;
            SaveButtonEditing.Click += SaveButton_Click;
            // 
            // SearchBar
            // 
            SearchBar.BackColor = SystemColors.Window;
            SearchBar.BorderStyle = BorderStyle.FixedSingle;
            SearchBar.Location = new Point(31, 78);
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
            IconSearch.Image = (Image)resources.GetObject("IconSearch.Image");
            IconSearch.Location = new Point(11, 78);
            IconSearch.Margin = new Padding(4, 2, 4, 2);
            IconSearch.Name = "IconSearch";
            IconSearch.Size = new Size(24, 23);
            IconSearch.TabIndex = 10;
            IconSearch.TabStop = false;
            // 
            // groupBoxEditing
            // 
            groupBoxEditing.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBoxEditing.BackColor = SystemColors.GradientActiveCaption;
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
            groupBoxEditing.Location = new Point(408, 63);
            groupBoxEditing.Name = "groupBoxEditing";
            groupBoxEditing.Size = new Size(697, 650);
            groupBoxEditing.TabIndex = 11;
            groupBoxEditing.TabStop = false;
            groupBoxEditing.Visible = false;
            // 
            // comboBoxCategoryEditing
            // 
            comboBoxCategoryEditing.Anchor = AnchorStyles.Right;
            comboBoxCategoryEditing.FormattingEnabled = true;
            comboBoxCategoryEditing.ImeMode = ImeMode.NoControl;
            comboBoxCategoryEditing.Items.AddRange(new object[] { "Физика", "Химия", "Биология", "Астрология", "Математика" });
            comboBoxCategoryEditing.Location = new Point(150, 351);
            comboBoxCategoryEditing.Name = "comboBoxCategoryEditing";
            comboBoxCategoryEditing.Size = new Size(481, 21);
            comboBoxCategoryEditing.TabIndex = 20;
            // 
            // dateTimePickerEditing
            // 
            dateTimePickerEditing.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerEditing.Location = new Point(150, 252);
            dateTimePickerEditing.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerEditing.Name = "dateTimePickerEditing";
            dateTimePickerEditing.Size = new Size(481, 20);
            dateTimePickerEditing.TabIndex = 13;
            // 
            // CancelButtonEditing
            // 
            CancelButtonEditing.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelButtonEditing.BackColor = Color.CornflowerBlue;
            CancelButtonEditing.BackgroundImageLayout = ImageLayout.None;
            CancelButtonEditing.FlatStyle = FlatStyle.Popup;
            CancelButtonEditing.ForeColor = SystemColors.ControlLightLight;
            CancelButtonEditing.Location = new Point(534, 606);
            CancelButtonEditing.Margin = new Padding(4, 3, 4, 3);
            CancelButtonEditing.Name = "CancelButtonEditing";
            CancelButtonEditing.Size = new Size(156, 38);
            CancelButtonEditing.TabIndex = 16;
            CancelButtonEditing.Text = "Отмена";
            CancelButtonEditing.UseVisualStyleBackColor = false;
            CancelButtonEditing.Click += CancelButton_Click;
            // 
            // textBoxParticipantsEditing
            // 
            textBoxParticipantsEditing.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxParticipantsEditing.Location = new Point(150, 405);
            textBoxParticipantsEditing.Multiline = true;
            textBoxParticipantsEditing.Name = "textBoxParticipantsEditing";
            textBoxParticipantsEditing.Size = new Size(481, 127);
            textBoxParticipantsEditing.TabIndex = 15;
            // 
            // textBoxTimeEditing
            // 
            textBoxTimeEditing.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTimeEditing.Location = new Point(150, 304);
            textBoxTimeEditing.Name = "textBoxTimeEditing";
            textBoxTimeEditing.Size = new Size(481, 20);
            textBoxTimeEditing.TabIndex = 13;
            // 
            // textBoxDescriptionEditing
            // 
            textBoxDescriptionEditing.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxDescriptionEditing.Location = new Point(150, 100);
            textBoxDescriptionEditing.Multiline = true;
            textBoxDescriptionEditing.Name = "textBoxDescriptionEditing";
            textBoxDescriptionEditing.Size = new Size(481, 119);
            textBoxDescriptionEditing.TabIndex = 9;
            // 
            // textBoxTitleEditing
            // 
            textBoxTitleEditing.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTitleEditing.Location = new Point(150, 44);
            textBoxTitleEditing.Name = "textBoxTitleEditing";
            textBoxTitleEditing.Size = new Size(481, 20);
            textBoxTitleEditing.TabIndex = 8;
            // 
            // participantsLabelEditing
            // 
            participantsLabelEditing.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            participantsLabelEditing.AutoSize = true;
            participantsLabelEditing.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            participantsLabelEditing.ForeColor = Color.MidnightBlue;
            participantsLabelEditing.Location = new Point(29, 405);
            participantsLabelEditing.Name = "participantsLabelEditing";
            participantsLabelEditing.Size = new Size(113, 30);
            participantsLabelEditing.TabIndex = 7;
            participantsLabelEditing.Text = "Участники";
            // 
            // CategoryLabelEditing
            // 
            CategoryLabelEditing.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CategoryLabelEditing.AutoSize = true;
            CategoryLabelEditing.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CategoryLabelEditing.ForeColor = Color.MidnightBlue;
            CategoryLabelEditing.Location = new Point(25, 341);
            CategoryLabelEditing.Name = "CategoryLabelEditing";
            CategoryLabelEditing.Size = new Size(111, 30);
            CategoryLabelEditing.TabIndex = 4;
            CategoryLabelEditing.Text = "Категория";
            // 
            // timeLabelEditing
            // 
            timeLabelEditing.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            timeLabelEditing.AutoSize = true;
            timeLabelEditing.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            timeLabelEditing.ForeColor = Color.MidnightBlue;
            timeLabelEditing.Location = new Point(25, 294);
            timeLabelEditing.Name = "timeLabelEditing";
            timeLabelEditing.Size = new Size(74, 30);
            timeLabelEditing.TabIndex = 3;
            timeLabelEditing.Text = "Время";
            // 
            // dateLabelEditing
            // 
            dateLabelEditing.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateLabelEditing.AutoSize = true;
            dateLabelEditing.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateLabelEditing.ForeColor = Color.MidnightBlue;
            dateLabelEditing.Location = new Point(29, 252);
            dateLabelEditing.Name = "dateLabelEditing";
            dateLabelEditing.Size = new Size(59, 30);
            dateLabelEditing.TabIndex = 2;
            dateLabelEditing.Text = "Дата";
            // 
            // describtionLabelEditing
            // 
            describtionLabelEditing.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            describtionLabelEditing.AutoSize = true;
            describtionLabelEditing.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            describtionLabelEditing.ForeColor = Color.MidnightBlue;
            describtionLabelEditing.Location = new Point(21, 100);
            describtionLabelEditing.Name = "describtionLabelEditing";
            describtionLabelEditing.Size = new Size(109, 30);
            describtionLabelEditing.TabIndex = 1;
            describtionLabelEditing.Text = "Описание";
            // 
            // titleLabelEditing
            // 
            titleLabelEditing.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            titleLabelEditing.AutoSize = true;
            titleLabelEditing.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            titleLabelEditing.ForeColor = Color.MidnightBlue;
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
            panel1.Location = new Point(12, 39);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 33);
            panel1.TabIndex = 13;
            // 
            // labelListOfConferences
            // 
            labelListOfConferences.AutoSize = true;
            labelListOfConferences.BackColor = Color.CornflowerBlue;
            labelListOfConferences.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelListOfConferences.ForeColor = SystemColors.ControlLightLight;
            labelListOfConferences.Location = new Point(55, 2);
            labelListOfConferences.Name = "labelListOfConferences";
            labelListOfConferences.Size = new Size(199, 25);
            labelListOfConferences.TabIndex = 0;
            labelListOfConferences.Text = "Список конференций";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1140, 21);
            panel2.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.CornflowerBlue;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(408, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(697, 35);
            panel3.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(330, 2);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1142, 736);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(groupBoxEditing);
            Controls.Add(SearchBar);
            Controls.Add(EditButton);
            Controls.Add(listBoxOfConferences);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Controls.Add(panel2);
            Controls.Add(IconSearch);
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
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ListBox listBoxOfConferences;
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
        private Panel panel3;
        private Label label1;
    }
}
