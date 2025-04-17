namespace Science_Conferences
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            groupBoxAdding = new GroupBox();
            maskedTextBoxTimeAdding = new MaskedTextBox();
            comboBoxCategoryAdding = new ComboBox();
            CancelButtonAdding = new Button();
            SaveButtonAdding = new Button();
            dateTimePickerAdding = new DateTimePicker();
            textBoxParticipantsAdding = new TextBox();
            textBoxDescriptionAdding = new TextBox();
            textBoxTitleAdding = new TextBox();
            participantsLabelAdding = new Label();
            categorylabelAdding = new Label();
            timeLabelAdding = new Label();
            dateLabelAdding = new Label();
            decriptionLabelAdding = new Label();
            titleLabelAdding = new Label();
            groupBoxAdding.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxAdding
            // 
            groupBoxAdding.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxAdding.BackColor = SystemColors.GradientActiveCaption;
            groupBoxAdding.Controls.Add(maskedTextBoxTimeAdding);
            groupBoxAdding.Controls.Add(comboBoxCategoryAdding);
            groupBoxAdding.Controls.Add(CancelButtonAdding);
            groupBoxAdding.Controls.Add(SaveButtonAdding);
            groupBoxAdding.Controls.Add(dateTimePickerAdding);
            groupBoxAdding.Controls.Add(textBoxParticipantsAdding);
            groupBoxAdding.Controls.Add(textBoxDescriptionAdding);
            groupBoxAdding.Controls.Add(textBoxTitleAdding);
            groupBoxAdding.Controls.Add(participantsLabelAdding);
            groupBoxAdding.Controls.Add(categorylabelAdding);
            groupBoxAdding.Controls.Add(timeLabelAdding);
            groupBoxAdding.Controls.Add(dateLabelAdding);
            groupBoxAdding.Controls.Add(decriptionLabelAdding);
            groupBoxAdding.Controls.Add(titleLabelAdding);
            groupBoxAdding.Font = new Font("Microsoft Sans Serif", 8.25F);
            groupBoxAdding.Location = new Point(121, 19);
            groupBoxAdding.Margin = new Padding(3, 4, 3, 4);
            groupBoxAdding.Name = "groupBoxAdding";
            groupBoxAdding.Padding = new Padding(3, 4, 3, 4);
            groupBoxAdding.Size = new Size(826, 841);
            groupBoxAdding.TabIndex = 12;
            groupBoxAdding.TabStop = false;
            // 
            // maskedTextBoxTimeAdding
            // 
            maskedTextBoxTimeAdding.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBoxTimeAdding.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBoxTimeAdding.Location = new Point(181, 425);
            maskedTextBoxTimeAdding.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxTimeAdding.Mask = "00:00";
            maskedTextBoxTimeAdding.Name = "maskedTextBoxTimeAdding";
            maskedTextBoxTimeAdding.Size = new Size(549, 23);
            maskedTextBoxTimeAdding.TabIndex = 20;
            maskedTextBoxTimeAdding.ValidatingType = typeof(DateTime);
            maskedTextBoxTimeAdding.Validating += maskedTextBoxTimeAdding_Validating;
            // 
            // comboBoxCategoryAdding
            // 
            comboBoxCategoryAdding.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxCategoryAdding.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategoryAdding.FormattingEnabled = true;
            comboBoxCategoryAdding.ImeMode = ImeMode.NoControl;
            comboBoxCategoryAdding.Items.AddRange(new object[] { "Физика", "Химия", "Биология", "Астрология", "Математика", "Без категории" });
            comboBoxCategoryAdding.Location = new Point(181, 487);
            comboBoxCategoryAdding.Margin = new Padding(3, 4, 3, 4);
            comboBoxCategoryAdding.Name = "comboBoxCategoryAdding";
            comboBoxCategoryAdding.Size = new Size(549, 25);
            comboBoxCategoryAdding.TabIndex = 19;
            comboBoxCategoryAdding.Validating += comboBoxCategoryAdding_Validating;
            // 
            // CancelButtonAdding
            // 
            CancelButtonAdding.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelButtonAdding.BackColor = Color.CornflowerBlue;
            CancelButtonAdding.FlatStyle = FlatStyle.Popup;
            CancelButtonAdding.ForeColor = SystemColors.ControlLightLight;
            CancelButtonAdding.Location = new Point(610, 772);
            CancelButtonAdding.Margin = new Padding(5, 4, 5, 4);
            CancelButtonAdding.Name = "CancelButtonAdding";
            CancelButtonAdding.Size = new Size(178, 51);
            CancelButtonAdding.TabIndex = 18;
            CancelButtonAdding.Text = "Отмена";
            CancelButtonAdding.UseVisualStyleBackColor = false;
            CancelButtonAdding.Click += CancelButtonAdding_Click;
            // 
            // SaveButtonAdding
            // 
            SaveButtonAdding.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveButtonAdding.BackColor = Color.CornflowerBlue;
            SaveButtonAdding.FlatStyle = FlatStyle.Popup;
            SaveButtonAdding.ForeColor = SystemColors.ControlLightLight;
            SaveButtonAdding.Location = new Point(423, 772);
            SaveButtonAdding.Margin = new Padding(5, 4, 5, 4);
            SaveButtonAdding.Name = "SaveButtonAdding";
            SaveButtonAdding.Size = new Size(178, 51);
            SaveButtonAdding.TabIndex = 17;
            SaveButtonAdding.Text = "Сохранить";
            SaveButtonAdding.UseVisualStyleBackColor = false;
            SaveButtonAdding.Click += SaveButtonAdding_Click;
            // 
            // dateTimePickerAdding
            // 
            dateTimePickerAdding.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerAdding.Location = new Point(181, 355);
            dateTimePickerAdding.Name = "dateTimePickerAdding";
            dateTimePickerAdding.Size = new Size(549, 23);
            dateTimePickerAdding.TabIndex = 13;
            dateTimePickerAdding.Value = new DateTime(2025, 4, 17, 0, 6, 5, 383);
            dateTimePickerAdding.Validating += dateTimePickerAdding_Validating;
            // 
            // textBoxParticipantsAdding
            // 
            textBoxParticipantsAdding.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxParticipantsAdding.Location = new Point(181, 551);
            textBoxParticipantsAdding.Margin = new Padding(3, 4, 3, 4);
            textBoxParticipantsAdding.MaxLength = 531;
            textBoxParticipantsAdding.Multiline = true;
            textBoxParticipantsAdding.Name = "textBoxParticipantsAdding";
            textBoxParticipantsAdding.Size = new Size(549, 168);
            textBoxParticipantsAdding.TabIndex = 15;
            // 
            // textBoxDescriptionAdding
            // 
            textBoxDescriptionAdding.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDescriptionAdding.Location = new Point(181, 153);
            textBoxDescriptionAdding.Margin = new Padding(3, 4, 3, 4);
            textBoxDescriptionAdding.MaxLength = 472;
            textBoxDescriptionAdding.Multiline = true;
            textBoxDescriptionAdding.Name = "textBoxDescriptionAdding";
            textBoxDescriptionAdding.Size = new Size(549, 168);
            textBoxDescriptionAdding.TabIndex = 9;
            // 
            // textBoxTitleAdding
            // 
            textBoxTitleAdding.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTitleAdding.Location = new Point(181, 57);
            textBoxTitleAdding.Margin = new Padding(3, 4, 3, 4);
            textBoxTitleAdding.MaxLength = 78;
            textBoxTitleAdding.Name = "textBoxTitleAdding";
            textBoxTitleAdding.Size = new Size(549, 23);
            textBoxTitleAdding.TabIndex = 8;
            textBoxTitleAdding.Validating += textBoxTitleAdding_Validating;
            // 
            // participantsLabelAdding
            // 
            participantsLabelAdding.AutoSize = true;
            participantsLabelAdding.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            participantsLabelAdding.ForeColor = Color.MidnightBlue;
            participantsLabelAdding.Location = new Point(33, 539);
            participantsLabelAdding.Name = "participantsLabelAdding";
            participantsLabelAdding.Size = new Size(151, 37);
            participantsLabelAdding.TabIndex = 7;
            participantsLabelAdding.Text = "Участники:";
            // 
            // categorylabelAdding
            // 
            categorylabelAdding.AutoSize = true;
            categorylabelAdding.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            categorylabelAdding.ForeColor = Color.MidnightBlue;
            categorylabelAdding.Location = new Point(33, 475);
            categorylabelAdding.Name = "categorylabelAdding";
            categorylabelAdding.Size = new Size(150, 37);
            categorylabelAdding.TabIndex = 4;
            categorylabelAdding.Text = "Категория:";
            // 
            // timeLabelAdding
            // 
            timeLabelAdding.AutoSize = true;
            timeLabelAdding.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            timeLabelAdding.ForeColor = Color.MidnightBlue;
            timeLabelAdding.Location = new Point(33, 411);
            timeLabelAdding.Name = "timeLabelAdding";
            timeLabelAdding.Size = new Size(101, 37);
            timeLabelAdding.TabIndex = 3;
            timeLabelAdding.Text = "Время:";
            // 
            // dateLabelAdding
            // 
            dateLabelAdding.AutoSize = true;
            dateLabelAdding.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateLabelAdding.ForeColor = Color.MidnightBlue;
            dateLabelAdding.Location = new Point(33, 345);
            dateLabelAdding.Name = "dateLabelAdding";
            dateLabelAdding.Size = new Size(81, 37);
            dateLabelAdding.TabIndex = 2;
            dateLabelAdding.Text = "Дата:";
            // 
            // decriptionLabelAdding
            // 
            decriptionLabelAdding.AutoSize = true;
            decriptionLabelAdding.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            decriptionLabelAdding.ForeColor = Color.MidnightBlue;
            decriptionLabelAdding.Location = new Point(33, 153);
            decriptionLabelAdding.Name = "decriptionLabelAdding";
            decriptionLabelAdding.Size = new Size(147, 37);
            decriptionLabelAdding.TabIndex = 1;
            decriptionLabelAdding.Text = "Описание:";
            // 
            // titleLabelAdding
            // 
            titleLabelAdding.AutoSize = true;
            titleLabelAdding.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            titleLabelAdding.ForeColor = Color.MidnightBlue;
            titleLabelAdding.Location = new Point(33, 45);
            titleLabelAdding.Name = "titleLabelAdding";
            titleLabelAdding.Size = new Size(142, 37);
            titleLabelAdding.TabIndex = 0;
            titleLabelAdding.Text = "Название:";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1056, 873);
            Controls.Add(groupBoxAdding);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddForm";
            Text = "Редактор";
            groupBoxAdding.ResumeLayout(false);
            groupBoxAdding.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxAdding;
        private DateTimePicker dateTimePickerAdding;
        private TextBox textBoxParticipantsAdding;
        private TextBox textBoxDescriptionAdding;
        private TextBox textBoxTitleAdding;
        private Label participantsLabelAdding;
        private Label categorylabelAdding;
        private Label timeLabelAdding;
        private Label dateLabelAdding;
        private Label decriptionLabelAdding;
        private Label titleLabelAdding;
        private Button SaveButtonAdding;
        private Button CancelButtonAdding;
        private ComboBox comboBoxCategoryAdding;
        private MaskedTextBox maskedTextBoxTimeAdding;
    }
}