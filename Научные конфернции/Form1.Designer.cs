namespace Научные_конфернции
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            AddButton = new Button();
            DeleteButton = new Button();
            listBox = new ListBox();
            MainHeading = new TextBox();
            EditButton = new Button();
            SaveButton = new Button();
            OpenButton = new Button();
            SearchBar = new TextBox();
            IconSearch = new PictureBox();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            CancelButton = new Button();
            textBoxParticipants = new TextBox();
            textBoxCategory = new TextBox();
            textBoxTime = new TextBox();
            textBoxDescription = new TextBox();
            textBoxTitle = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)IconSearch).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Location = new Point(16, 906);
            AddButton.Margin = new Padding(5, 4, 5, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(153, 51);
            AddButton.TabIndex = 0;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DeleteButton.Location = new Point(201, 680);
            DeleteButton.Margin = new Padding(4, 3, 4, 3);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(134, 38);
            DeleteButton.TabIndex = 1;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            listBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBox.BackColor = SystemColors.Menu;
            listBox.BorderStyle = BorderStyle.FixedSingle;
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(13, 112);
            listBox.Margin = new Padding(4, 3, 4, 3);
            listBox.Name = "listBox";
            listBox.Size = new Size(320, 557);
            listBox.TabIndex = 3;
            // 
            // MainHeading
            // 
            MainHeading.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MainHeading.Cursor = Cursors.No;
            MainHeading.Enabled = false;
            MainHeading.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainHeading.Location = new Point(501, 52);
            MainHeading.Margin = new Padding(5, 4, 5, 4);
            MainHeading.Name = "MainHeading";
            MainHeading.ReadOnly = true;
            MainHeading.Size = new Size(964, 39);
            MainHeading.TabIndex = 5;
            MainHeading.TextAlign = HorizontalAlignment.Center;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            EditButton.Location = new Point(1217, 907);
            EditButton.Margin = new Padding(5, 4, 5, 4);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(248, 48);
            EditButton.TabIndex = 6;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SaveButton.Location = new Point(8, 732);
            SaveButton.Margin = new Padding(5, 4, 5, 4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(153, 48);
            SaveButton.TabIndex = 7;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // OpenButton
            // 
            OpenButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OpenButton.Location = new Point(501, 907);
            OpenButton.Margin = new Padding(5, 4, 5, 4);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(248, 48);
            OpenButton.TabIndex = 8;
            OpenButton.Text = "Просмотр";
            OpenButton.UseVisualStyleBackColor = true;
            // 
            // SearchBar
            // 
            SearchBar.BackColor = SystemColors.Window;
            SearchBar.BorderStyle = BorderStyle.FixedSingle;
            SearchBar.Location = new Point(35, 78);
            SearchBar.Margin = new Padding(4, 3, 4, 3);
            SearchBar.Name = "SearchBar";
            SearchBar.Size = new Size(343, 27);
            SearchBar.TabIndex = 9;
            // 
            // IconSearch
            // 
            IconSearch.BackColor = SystemColors.ControlLightLight;
            IconSearch.BackgroundImageLayout = ImageLayout.None;
            IconSearch.BorderStyle = BorderStyle.FixedSingle;
            IconSearch.Image = Properties.Resources.icon_magnifier;
            IconSearch.Location = new Point(14, 78);
            IconSearch.Margin = new Padding(4, 3, 4, 3);
            IconSearch.Name = "IconSearch";
            IconSearch.Size = new Size(28, 27);
            IconSearch.TabIndex = 10;
            IconSearch.TabStop = false;
            IconSearch.Click += IconSearch_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(CancelButton);
            groupBox1.Controls.Add(textBoxParticipants);
            groupBox1.Controls.Add(textBoxCategory);
            groupBox1.Controls.Add(textBoxTime);
            groupBox1.Controls.Add(SaveButton);
            groupBox1.Controls.Add(textBoxDescription);
            groupBox1.Controls.Add(textBoxTitle);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 8.25F);
            groupBox1.Location = new Point(501, 104);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(965, 788);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Visible = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(140, 269);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(481, 20);
            dateTimePicker1.TabIndex = 13;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CancelButton.Location = new Point(803, 732);
            CancelButton.Margin = new Padding(5, 4, 5, 4);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(153, 48);
            CancelButton.TabIndex = 16;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // textBoxParticipants
            // 
            textBoxParticipants.Location = new Point(171, 552);
            textBoxParticipants.Margin = new Padding(3, 4, 3, 4);
            textBoxParticipants.Multiline = true;
            textBoxParticipants.Name = "textBoxParticipants";
            textBoxParticipants.Size = new Size(549, 168);
            textBoxParticipants.TabIndex = 15;
            // 
            // textBoxCategory
            // 
            textBoxCategory.Location = new Point(171, 487);
            textBoxCategory.Margin = new Padding(3, 4, 3, 4);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(549, 23);
            textBoxCategory.TabIndex = 14;
            // 
            // textBoxTime
            // 
            textBoxTime.Location = new Point(171, 423);
            textBoxTime.Margin = new Padding(3, 4, 3, 4);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.Size = new Size(549, 23);
            textBoxTime.TabIndex = 13;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(176, 153);
            textBoxDescription.Margin = new Padding(3, 4, 3, 4);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(549, 168);
            textBoxDescription.TabIndex = 9;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(171, 59);
            textBoxTitle.Margin = new Padding(3, 4, 3, 4);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(549, 23);
            textBoxTitle.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(33, 540);
            label8.Name = "label8";
            label8.Size = new Size(145, 37);
            label8.TabIndex = 7;
            label8.Text = "Участники";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(29, 475);
            label5.Name = "label5";
            label5.Size = new Size(144, 37);
            label5.TabIndex = 4;
            label5.Text = "Категория";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(29, 411);
            label4.Name = "label4";
            label4.Size = new Size(95, 37);
            label4.TabIndex = 3;
            label4.Text = "Время";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(33, 345);
            label3.Name = "label3";
            label3.Size = new Size(75, 37);
            label3.TabIndex = 2;
            label3.Text = "Дата";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(29, 153);
            label2.Name = "label2";
            label2.Size = new Size(141, 37);
            label2.TabIndex = 1;
            label2.Text = "Описание";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(29, 45);
            label1.Name = "label1";
            label1.Size = new Size(136, 37);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(100, 49);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(14, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 33);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.CornflowerBlue;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(58, 4);
            label7.Name = "label7";
            label7.Size = new Size(199, 25);
            label7.TabIndex = 0;
            label7.Text = "Список конференций";
            label7.Click += label7_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1297, 28);
            panel2.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1296, 742);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(IconSearch);
            Controls.Add(SearchBar);
            Controls.Add(OpenButton);
            Controls.Add(EditButton);
            Controls.Add(MainHeading);
            Controls.Add(listBox);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Controls.Add(panel2);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "ScienceManager";
            ((System.ComponentModel.ISupportInitialize)IconSearch).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox MainHeading;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.PictureBox IconSearch;
        private GroupBox groupBox1;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxTitle;
        private TextBox textBoxDescription;
        private TextBox textBoxTime;
        private TextBox textBoxParticipants;
        private TextBox textBoxCategory;
        private Button CancelButton;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
        private Label label7;
        private Panel panel2;
    }
}
