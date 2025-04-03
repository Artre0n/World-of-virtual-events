using System.Resources;

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
            ListHeading = new TextBox();
            listBox = new ListBox();
            StripBackground = new TextBox();
            MainHeading = new TextBox();
            EditButton = new Button();
            SaveButton = new Button();
            OpenButton = new Button();
            SearchBar = new TextBox();
            IconSearch = new PictureBox();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)IconSearch).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Location = new Point(14, 680);
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
            DeleteButton.Location = new Point(201, 680);
            DeleteButton.Margin = new Padding(4, 3, 4, 3);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(134, 38);
            DeleteButton.TabIndex = 1;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // ListHeading
            // 
            ListHeading.BackColor = Color.CornflowerBlue;
            ListHeading.BorderStyle = BorderStyle.FixedSingle;
            ListHeading.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ListHeading.Location = new Point(15, 39);
            ListHeading.Margin = new Padding(4, 3, 4, 3);
            ListHeading.Name = "ListHeading";
            ListHeading.Size = new Size(320, 27);
            ListHeading.TabIndex = 2;
            ListHeading.Text = "Список конференций";
            ListHeading.TextAlign = HorizontalAlignment.Center;
            // 
            // listBox
            // 
            listBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBox.BackColor = SystemColors.Menu;
            listBox.BorderStyle = BorderStyle.FixedSingle;
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(15, 67);
            listBox.Margin = new Padding(4, 3, 4, 3);
            listBox.Name = "listBox";
            listBox.Size = new Size(320, 602);
            listBox.TabIndex = 3;
            // 
            // StripBackground
            // 
            StripBackground.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StripBackground.BackColor = Color.RoyalBlue;
            StripBackground.BorderStyle = BorderStyle.None;
            StripBackground.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            StripBackground.Location = new Point(0, 0);
            StripBackground.Margin = new Padding(4, 3, 4, 3);
            StripBackground.Name = "StripBackground";
            StripBackground.Size = new Size(1306, 28);
            StripBackground.TabIndex = 4;
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
            MainHeading.Size = new Size(844, 33);
            MainHeading.TabIndex = 5;
            MainHeading.TextAlign = HorizontalAlignment.Center;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            EditButton.Location = new Point(1065, 680);
            EditButton.Margin = new Padding(4, 3, 4, 3);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(217, 36);
            EditButton.TabIndex = 6;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom;
            SaveButton.Location = new Point(750, 680);
            SaveButton.Margin = new Padding(4, 3, 4, 3);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(217, 36);
            SaveButton.TabIndex = 7;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // OpenButton
            // 
            OpenButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OpenButton.Location = new Point(438, 680);
            OpenButton.Margin = new Padding(4, 3, 4, 3);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(217, 36);
            OpenButton.TabIndex = 8;
            OpenButton.Text = "Просмотр";
            OpenButton.UseVisualStyleBackColor = true;
            // 
            // SearchBar
            // 
            SearchBar.BackColor = SystemColors.Window;
            SearchBar.BorderStyle = BorderStyle.FixedSingle;
            SearchBar.Location = new Point(35, 67);
            SearchBar.Margin = new Padding(4, 3, 4, 3);
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
            IconSearch.Location = new Point(15, 67);
            IconSearch.Margin = new Padding(4, 3, 4, 3);
            IconSearch.Name = "IconSearch";
            IconSearch.Size = new Size(24, 23);
            IconSearch.TabIndex = 10;
            IconSearch.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(438, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(844, 591);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Редактор";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 287);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 7;
            label8.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 248);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 6;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 213);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 177);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 143);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 110);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 74);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(29, 37);
            label1.Name = "label1";
            label1.Size = new Size(105, 30);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(486, 23);
            textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1296, 742);
            Controls.Add(groupBox1);
            Controls.Add(IconSearch);
            Controls.Add(SearchBar);
            Controls.Add(OpenButton);
            Controls.Add(SaveButton);
            Controls.Add(EditButton);
            Controls.Add(MainHeading);
            Controls.Add(listBox);
            Controls.Add(ListHeading);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Controls.Add(StripBackground);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "ScienceManager";
            ((System.ComponentModel.ISupportInitialize)IconSearch).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox ListHeading;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox StripBackground;
        private System.Windows.Forms.TextBox MainHeading;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.PictureBox IconSearch;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
    }
}
