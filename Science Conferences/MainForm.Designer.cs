﻿namespace Science_Conferences
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
            ChangeButtonEditing = new Button();
            SearchBar = new TextBox();
            IconSearch = new PictureBox();
            groupBoxEditing = new GroupBox();
            maskedTextBoxTimeEditing = new MaskedTextBox();
            comboBoxCategoryEditing = new ComboBox();
            dateTimePickerEditing = new DateTimePicker();
            CancelButtonEditing = new Button();
            textBoxParticipantsEditing = new TextBox();
            textBoxDescriptionEditing = new TextBox();
            textBoxTitleEditing = new TextBox();
            participantsLabelEditing = new Label();
            CategoryLabelEditing = new Label();
            timeLabelEditing = new Label();
            dateLabelEditing = new Label();
            describtionLabelEditing = new Label();
            titleLabelEditing = new Label();
            panel1 = new Panel();
            labelListOfConferences = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            comboBoxSort = new ComboBox();
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
            AddButton.Location = new Point(13, 836);
            AddButton.Margin = new Padding(5, 4, 5, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(178, 51);
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
            DeleteButton.Location = new Point(201, 836);
            DeleteButton.Margin = new Padding(5, 4, 5, 4);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(178, 51);
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
            listBoxOfConferences.Location = new Point(13, 145);
            listBoxOfConferences.Margin = new Padding(5, 3, 5, 3);
            listBoxOfConferences.Name = "listBoxOfConferences";
            listBoxOfConferences.Size = new Size(365, 662);
            listBoxOfConferences.TabIndex = 3;
            listBoxOfConferences.SelectedIndexChanged += listBoxOfConferences_SelectedIndexChanged;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            EditButton.BackColor = Color.CornflowerBlue;
            EditButton.FlatStyle = FlatStyle.Popup;
            EditButton.ForeColor = SystemColors.ControlLightLight;
            EditButton.Location = new Point(13, 907);
            EditButton.Margin = new Padding(5, 4, 5, 4);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(366, 51);
            EditButton.TabIndex = 6;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // ChangeButtonEditing
            // 
            ChangeButtonEditing.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ChangeButtonEditing.BackColor = Color.CornflowerBlue;
            ChangeButtonEditing.FlatStyle = FlatStyle.Popup;
            ChangeButtonEditing.ForeColor = SystemColors.ControlLightLight;
            ChangeButtonEditing.Location = new Point(377, 808);
            ChangeButtonEditing.Margin = new Padding(5, 4, 5, 4);
            ChangeButtonEditing.Name = "ChangeButtonEditing";
            ChangeButtonEditing.Size = new Size(178, 51);
            ChangeButtonEditing.TabIndex = 7;
            ChangeButtonEditing.Text = "Изменить";
            ChangeButtonEditing.UseVisualStyleBackColor = false;
            ChangeButtonEditing.Click += ChangeButton_Click;
            // 
            // SearchBar
            // 
            SearchBar.BackColor = SystemColors.Window;
            SearchBar.BorderStyle = BorderStyle.FixedSingle;
            SearchBar.Location = new Point(35, 104);
            SearchBar.Margin = new Padding(5, 3, 5, 3);
            SearchBar.MaxLength = 20;
            SearchBar.Name = "SearchBar";
            SearchBar.Size = new Size(343, 27);
            SearchBar.TabIndex = 9;
            SearchBar.TextChanged += SearchBar_TextChanged;
            // 
            // IconSearch
            // 
            IconSearch.BackColor = SystemColors.ControlLightLight;
            IconSearch.BackgroundImageLayout = ImageLayout.None;
            IconSearch.BorderStyle = BorderStyle.FixedSingle;
            IconSearch.Image = (Image)resources.GetObject("IconSearch.Image");
            IconSearch.Location = new Point(13, 104);
            IconSearch.Margin = new Padding(5, 3, 5, 3);
            IconSearch.Name = "IconSearch";
            IconSearch.Size = new Size(26, 27);
            IconSearch.TabIndex = 10;
            IconSearch.TabStop = false;
            // 
            // groupBoxEditing
            // 
            groupBoxEditing.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBoxEditing.BackColor = SystemColors.GradientActiveCaption;
            groupBoxEditing.Controls.Add(maskedTextBoxTimeEditing);
            groupBoxEditing.Controls.Add(comboBoxCategoryEditing);
            groupBoxEditing.Controls.Add(dateTimePickerEditing);
            groupBoxEditing.Controls.Add(CancelButtonEditing);
            groupBoxEditing.Controls.Add(textBoxParticipantsEditing);
            groupBoxEditing.Controls.Add(ChangeButtonEditing);
            groupBoxEditing.Controls.Add(textBoxDescriptionEditing);
            groupBoxEditing.Controls.Add(textBoxTitleEditing);
            groupBoxEditing.Controls.Add(participantsLabelEditing);
            groupBoxEditing.Controls.Add(CategoryLabelEditing);
            groupBoxEditing.Controls.Add(timeLabelEditing);
            groupBoxEditing.Controls.Add(dateLabelEditing);
            groupBoxEditing.Controls.Add(describtionLabelEditing);
            groupBoxEditing.Controls.Add(titleLabelEditing);
            groupBoxEditing.Font = new Font("Microsoft Sans Serif", 8.25F);
            groupBoxEditing.Location = new Point(466, 87);
            groupBoxEditing.Margin = new Padding(3, 4, 3, 4);
            groupBoxEditing.Name = "groupBoxEditing";
            groupBoxEditing.Padding = new Padding(3, 4, 3, 4);
            groupBoxEditing.Size = new Size(751, 867);
            groupBoxEditing.TabIndex = 11;
            groupBoxEditing.TabStop = false;
            groupBoxEditing.Visible = false;
            // 
            // maskedTextBoxTimeEditing
            // 
            maskedTextBoxTimeEditing.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBoxTimeEditing.BackColor = Color.White;
            maskedTextBoxTimeEditing.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBoxTimeEditing.Location = new Point(180, 406);
            maskedTextBoxTimeEditing.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxTimeEditing.Mask = "00:00";
            maskedTextBoxTimeEditing.Name = "maskedTextBoxTimeEditing";
            maskedTextBoxTimeEditing.Size = new Size(504, 23);
            maskedTextBoxTimeEditing.TabIndex = 21;
            maskedTextBoxTimeEditing.ValidatingType = typeof(DateTime);
            maskedTextBoxTimeEditing.Validating += maskedTextBoxTimeEditing_Validating;
            // 
            // comboBoxCategoryEditing
            // 
            comboBoxCategoryEditing.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxCategoryEditing.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategoryEditing.FormattingEnabled = true;
            comboBoxCategoryEditing.Items.AddRange(new object[] { "Физика", "Химия", "Биология", "Астрология", "Математика", "Без категории" });
            comboBoxCategoryEditing.Location = new Point(181, 468);
            comboBoxCategoryEditing.Margin = new Padding(3, 4, 3, 4);
            comboBoxCategoryEditing.Name = "comboBoxCategoryEditing";
            comboBoxCategoryEditing.Size = new Size(503, 25);
            comboBoxCategoryEditing.TabIndex = 20;
            comboBoxCategoryEditing.Validating += comboBoxCategoryEditing_Validating;
            // 
            // dateTimePickerEditing
            // 
            dateTimePickerEditing.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerEditing.Location = new Point(181, 337);
            dateTimePickerEditing.Name = "dateTimePickerEditing";
            dateTimePickerEditing.Size = new Size(503, 23);
            dateTimePickerEditing.TabIndex = 13;
            dateTimePickerEditing.Validating += dateTimePickerEditing_Validating;
            // 
            // CancelButtonEditing
            // 
            CancelButtonEditing.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelButtonEditing.BackColor = Color.CornflowerBlue;
            CancelButtonEditing.BackgroundImageLayout = ImageLayout.None;
            CancelButtonEditing.FlatStyle = FlatStyle.Popup;
            CancelButtonEditing.ForeColor = SystemColors.ControlLightLight;
            CancelButtonEditing.Location = new Point(565, 808);
            CancelButtonEditing.Margin = new Padding(5, 4, 5, 4);
            CancelButtonEditing.Name = "CancelButtonEditing";
            CancelButtonEditing.Size = new Size(178, 51);
            CancelButtonEditing.TabIndex = 16;
            CancelButtonEditing.Text = "Отмена";
            CancelButtonEditing.UseVisualStyleBackColor = false;
            CancelButtonEditing.Click += CancelButton_Click;
            // 
            // textBoxParticipantsEditing
            // 
            textBoxParticipantsEditing.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxParticipantsEditing.BorderStyle = BorderStyle.FixedSingle;
            textBoxParticipantsEditing.Location = new Point(181, 540);
            textBoxParticipantsEditing.Margin = new Padding(3, 4, 3, 4);
            textBoxParticipantsEditing.MaxLength = 531;
            textBoxParticipantsEditing.Multiline = true;
            textBoxParticipantsEditing.Name = "textBoxParticipantsEditing";
            textBoxParticipantsEditing.Size = new Size(504, 169);
            textBoxParticipantsEditing.TabIndex = 15;
            // 
            // textBoxDescriptionEditing
            // 
            textBoxDescriptionEditing.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxDescriptionEditing.BackColor = Color.White;
            textBoxDescriptionEditing.BorderStyle = BorderStyle.FixedSingle;
            textBoxDescriptionEditing.Location = new Point(181, 133);
            textBoxDescriptionEditing.Margin = new Padding(3, 4, 3, 4);
            textBoxDescriptionEditing.MaxLength = 472;
            textBoxDescriptionEditing.Multiline = true;
            textBoxDescriptionEditing.Name = "textBoxDescriptionEditing";
            textBoxDescriptionEditing.Size = new Size(504, 158);
            textBoxDescriptionEditing.TabIndex = 9;
            // 
            // textBoxTitleEditing
            // 
            textBoxTitleEditing.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTitleEditing.BackColor = Color.White;
            textBoxTitleEditing.BorderStyle = BorderStyle.FixedSingle;
            textBoxTitleEditing.Location = new Point(181, 59);
            textBoxTitleEditing.Margin = new Padding(3, 4, 3, 4);
            textBoxTitleEditing.MaxLength = 78;
            textBoxTitleEditing.Name = "textBoxTitleEditing";
            textBoxTitleEditing.Size = new Size(504, 23);
            textBoxTitleEditing.TabIndex = 8;
            textBoxTitleEditing.Validating += textBoxTitleEditing_Validating;
            // 
            // participantsLabelEditing
            // 
            participantsLabelEditing.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            participantsLabelEditing.AutoSize = true;
            participantsLabelEditing.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            participantsLabelEditing.ForeColor = Color.MidnightBlue;
            participantsLabelEditing.Location = new Point(33, 527);
            participantsLabelEditing.Name = "participantsLabelEditing";
            participantsLabelEditing.Size = new Size(151, 37);
            participantsLabelEditing.TabIndex = 7;
            participantsLabelEditing.Text = "Участники:";
            // 
            // CategoryLabelEditing
            // 
            CategoryLabelEditing.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CategoryLabelEditing.AutoSize = true;
            CategoryLabelEditing.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CategoryLabelEditing.ForeColor = Color.MidnightBlue;
            CategoryLabelEditing.Location = new Point(33, 456);
            CategoryLabelEditing.Name = "CategoryLabelEditing";
            CategoryLabelEditing.Size = new Size(150, 37);
            CategoryLabelEditing.TabIndex = 4;
            CategoryLabelEditing.Text = "Категория:";
            // 
            // timeLabelEditing
            // 
            timeLabelEditing.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            timeLabelEditing.AutoSize = true;
            timeLabelEditing.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            timeLabelEditing.ForeColor = Color.MidnightBlue;
            timeLabelEditing.Location = new Point(33, 392);
            timeLabelEditing.Name = "timeLabelEditing";
            timeLabelEditing.Size = new Size(101, 37);
            timeLabelEditing.TabIndex = 3;
            timeLabelEditing.Text = "Время:";
            // 
            // dateLabelEditing
            // 
            dateLabelEditing.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateLabelEditing.AutoSize = true;
            dateLabelEditing.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateLabelEditing.ForeColor = Color.MidnightBlue;
            dateLabelEditing.Location = new Point(33, 327);
            dateLabelEditing.Name = "dateLabelEditing";
            dateLabelEditing.Size = new Size(81, 37);
            dateLabelEditing.TabIndex = 2;
            dateLabelEditing.Text = "Дата:";
            // 
            // describtionLabelEditing
            // 
            describtionLabelEditing.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            describtionLabelEditing.AutoSize = true;
            describtionLabelEditing.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            describtionLabelEditing.ForeColor = Color.MidnightBlue;
            describtionLabelEditing.Location = new Point(33, 120);
            describtionLabelEditing.Name = "describtionLabelEditing";
            describtionLabelEditing.Size = new Size(147, 37);
            describtionLabelEditing.TabIndex = 1;
            describtionLabelEditing.Text = "Описание:";
            // 
            // titleLabelEditing
            // 
            titleLabelEditing.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            titleLabelEditing.AutoSize = true;
            titleLabelEditing.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            titleLabelEditing.ForeColor = Color.MidnightBlue;
            titleLabelEditing.Location = new Point(33, 45);
            titleLabelEditing.Name = "titleLabelEditing";
            titleLabelEditing.Size = new Size(142, 37);
            titleLabelEditing.TabIndex = 0;
            titleLabelEditing.Text = "Название:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(labelListOfConferences);
            panel1.Location = new Point(14, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 44);
            panel1.TabIndex = 13;
            // 
            // labelListOfConferences
            // 
            labelListOfConferences.AutoSize = true;
            labelListOfConferences.BackColor = Color.CornflowerBlue;
            labelListOfConferences.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelListOfConferences.ForeColor = SystemColors.ControlLightLight;
            labelListOfConferences.Location = new Point(63, 3);
            labelListOfConferences.Name = "labelListOfConferences";
            labelListOfConferences.Size = new Size(253, 32);
            labelListOfConferences.TabIndex = 0;
            labelListOfConferences.Text = "Список конференций";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1303, 28);
            panel2.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.CornflowerBlue;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(466, 52);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(751, 47);
            panel3.TabIndex = 15;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(325, 3);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxSort
            // 
            comboBoxSort.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Items.AddRange(new object[] { "По дате", "По категории", "По умолчанию" });
            comboBoxSort.Location = new Point(254, 104);
            comboBoxSort.Margin = new Padding(3, 4, 3, 4);
            comboBoxSort.MaxDropDownItems = 2;
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(124, 28);
            comboBoxSort.TabIndex = 16;
            comboBoxSort.SelectedIndexChanged += comboBoxSort_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1239, 988);
            Controls.Add(DeleteButton);
            Controls.Add(panel3);
            Controls.Add(comboBoxSort);
            Controls.Add(panel1);
            Controls.Add(SearchBar);
            Controls.Add(EditButton);
            Controls.Add(listBoxOfConferences);
            Controls.Add(AddButton);
            Controls.Add(panel2);
            Controls.Add(IconSearch);
            Controls.Add(groupBoxEditing);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "MainForm";
            Text = "ScienceManager";
            FormClosing += MainForm_FormClosing;
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
        private System.Windows.Forms.Button ChangeButtonEditing;
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
        private TextBox textBoxParticipantsEditing;
        private Button CancelButtonEditing;
        private DateTimePicker dateTimePickerEditing;
        private Panel panel1;
        private Label labelListOfConferences;
        private Panel panel2;
        private ComboBox comboBoxCategoryEditing;
        private Panel panel3;
        private Label label1;
        private ComboBox comboBoxSort;
        private MaskedTextBox maskedTextBoxTimeEditing;
    }
}
