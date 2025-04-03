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
            ((System.ComponentModel.ISupportInitialize)IconSearch).BeginInit();
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
            ListHeading.Location = new Point(14, 39);
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
            listBox.Location = new Point(14, 67);
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
            IconSearch.Location = new Point(14, 67);
            IconSearch.Margin = new Padding(4, 3, 4, 3);
            IconSearch.Name = "IconSearch";
            IconSearch.Size = new Size(24, 23);
            IconSearch.TabIndex = 10;
            IconSearch.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1296, 742);
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

    }
}
