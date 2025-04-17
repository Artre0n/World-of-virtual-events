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
            groupBoxAdding.Location = new Point(115, 12);
            groupBoxAdding.Name = "groupBoxAdding";
            groupBoxAdding.Size = new Size(723, 631);
            groupBoxAdding.TabIndex = 12;
            groupBoxAdding.TabStop = false;
            // 
            // maskedTextBoxTimeAdding
            // 
            maskedTextBoxTimeAdding.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBoxTimeAdding.Location = new Point(150, 319);
            maskedTextBoxTimeAdding.Mask = "00:00";
            maskedTextBoxTimeAdding.Name = "maskedTextBoxTimeAdding";
            maskedTextBoxTimeAdding.Size = new Size(481, 20);
            maskedTextBoxTimeAdding.TabIndex = 20;
            maskedTextBoxTimeAdding.ValidatingType = typeof(DateTime);
            maskedTextBoxTimeAdding.Validating += maskedTextBoxTimeAdding_Validating;
            // 
            // comboBoxCategoryAdding
            // 
            comboBoxCategoryAdding.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategoryAdding.FormattingEnabled = true;
            comboBoxCategoryAdding.ImeMode = ImeMode.NoControl;
            comboBoxCategoryAdding.Items.AddRange(new object[] { "Физика", "Химия", "Биология", "Астрология", "Математика", "Без категории" });
            comboBoxCategoryAdding.Location = new Point(150, 366);
            comboBoxCategoryAdding.Name = "comboBoxCategoryAdding";
            comboBoxCategoryAdding.Size = new Size(481, 21);
            comboBoxCategoryAdding.TabIndex = 19;
            comboBoxCategoryAdding.Validating += comboBoxCategoryAdding_Validating;
            // 
            // CancelButtonAdding
            // 
            CancelButtonAdding.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CancelButtonAdding.BackColor = Color.CornflowerBlue;
            CancelButtonAdding.FlatStyle = FlatStyle.Popup;
            CancelButtonAdding.ForeColor = SystemColors.ControlLightLight;
            CancelButtonAdding.Location = new Point(534, 579);
            CancelButtonAdding.Margin = new Padding(4, 3, 4, 3);
            CancelButtonAdding.Name = "CancelButtonAdding";
            CancelButtonAdding.Size = new Size(156, 38);
            CancelButtonAdding.TabIndex = 18;
            CancelButtonAdding.Text = "Отмена";
            CancelButtonAdding.UseVisualStyleBackColor = false;
            CancelButtonAdding.Click += CancelButtonAdding_Click;
            // 
            // SaveButtonAdding
            // 
            SaveButtonAdding.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SaveButtonAdding.BackColor = Color.CornflowerBlue;
            SaveButtonAdding.Enabled = false;
            SaveButtonAdding.FlatStyle = FlatStyle.Popup;
            SaveButtonAdding.ForeColor = SystemColors.ControlLightLight;
            SaveButtonAdding.Location = new Point(370, 579);
            SaveButtonAdding.Margin = new Padding(4, 3, 4, 3);
            SaveButtonAdding.Name = "SaveButtonAdding";
            SaveButtonAdding.Size = new Size(156, 38);
            SaveButtonAdding.TabIndex = 17;
            SaveButtonAdding.Text = "Сохранить";
            SaveButtonAdding.UseVisualStyleBackColor = false;
            SaveButtonAdding.Click += SaveButtonAdding_Click;
            // 
            // dateTimePickerAdding
            // 
            dateTimePickerAdding.Location = new Point(150, 266);
            dateTimePickerAdding.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerAdding.Name = "dateTimePickerAdding";
            dateTimePickerAdding.Size = new Size(481, 20);
            dateTimePickerAdding.TabIndex = 13;
            dateTimePickerAdding.Value = new DateTime(2025, 4, 17, 0, 6, 5, 383);
            dateTimePickerAdding.Validating += dateTimePickerAdding_Validating;
            // 
            // textBoxParticipantsAdding
            // 
            textBoxParticipantsAdding.Location = new Point(150, 414);
            textBoxParticipantsAdding.MaxLength = 531;
            textBoxParticipantsAdding.Multiline = true;
            textBoxParticipantsAdding.Name = "textBoxParticipantsAdding";
            textBoxParticipantsAdding.Size = new Size(481, 127);
            textBoxParticipantsAdding.TabIndex = 15;
            // 
            // textBoxDescriptionAdding
            // 
            textBoxDescriptionAdding.Location = new Point(150, 115);
            textBoxDescriptionAdding.MaxLength = 472;
            textBoxDescriptionAdding.Multiline = true;
            textBoxDescriptionAdding.Name = "textBoxDescriptionAdding";
            textBoxDescriptionAdding.Size = new Size(481, 127);
            textBoxDescriptionAdding.TabIndex = 9;
            // 
            // textBoxTitleAdding
            // 
            textBoxTitleAdding.Location = new Point(150, 44);
            textBoxTitleAdding.MaxLength = 78;
            textBoxTitleAdding.Name = "textBoxTitleAdding";
            textBoxTitleAdding.Size = new Size(481, 20);
            textBoxTitleAdding.TabIndex = 8;
            textBoxTitleAdding.Validating += textBoxTitleAdding_Validating;
            // 
            // participantsLabelAdding
            // 
            participantsLabelAdding.AutoSize = true;
            participantsLabelAdding.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            participantsLabelAdding.ForeColor = Color.MidnightBlue;
            participantsLabelAdding.Location = new Point(29, 404);
            participantsLabelAdding.Name = "participantsLabelAdding";
            participantsLabelAdding.Size = new Size(118, 30);
            participantsLabelAdding.TabIndex = 7;
            participantsLabelAdding.Text = "Участники:";
            // 
            // categorylabelAdding
            // 
            categorylabelAdding.AutoSize = true;
            categorylabelAdding.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            categorylabelAdding.ForeColor = Color.MidnightBlue;
            categorylabelAdding.Location = new Point(29, 356);
            categorylabelAdding.Name = "categorylabelAdding";
            categorylabelAdding.Size = new Size(116, 30);
            categorylabelAdding.TabIndex = 4;
            categorylabelAdding.Text = "Категория:";
            // 
            // timeLabelAdding
            // 
            timeLabelAdding.AutoSize = true;
            timeLabelAdding.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            timeLabelAdding.ForeColor = Color.MidnightBlue;
            timeLabelAdding.Location = new Point(29, 308);
            timeLabelAdding.Name = "timeLabelAdding";
            timeLabelAdding.Size = new Size(79, 30);
            timeLabelAdding.TabIndex = 3;
            timeLabelAdding.Text = "Время:";
            // 
            // dateLabelAdding
            // 
            dateLabelAdding.AutoSize = true;
            dateLabelAdding.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateLabelAdding.ForeColor = Color.MidnightBlue;
            dateLabelAdding.Location = new Point(29, 259);
            dateLabelAdding.Name = "dateLabelAdding";
            dateLabelAdding.Size = new Size(64, 30);
            dateLabelAdding.TabIndex = 2;
            dateLabelAdding.Text = "Дата:";
            // 
            // decriptionLabelAdding
            // 
            decriptionLabelAdding.AutoSize = true;
            decriptionLabelAdding.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            decriptionLabelAdding.ForeColor = Color.MidnightBlue;
            decriptionLabelAdding.Location = new Point(29, 115);
            decriptionLabelAdding.Name = "decriptionLabelAdding";
            decriptionLabelAdding.Size = new Size(114, 30);
            decriptionLabelAdding.TabIndex = 1;
            decriptionLabelAdding.Text = "Описание:";
            // 
            // titleLabelAdding
            // 
            titleLabelAdding.AutoSize = true;
            titleLabelAdding.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            titleLabelAdding.ForeColor = Color.MidnightBlue;
            titleLabelAdding.Location = new Point(29, 34);
            titleLabelAdding.Name = "titleLabelAdding";
            titleLabelAdding.Size = new Size(110, 30);
            titleLabelAdding.TabIndex = 0;
            titleLabelAdding.Text = "Название:";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(924, 655);
            Controls.Add(groupBoxAdding);
            Icon = (Icon)resources.GetObject("$this.Icon");
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