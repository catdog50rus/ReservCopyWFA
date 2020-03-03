namespace ReservCopyWFA.CI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.targetFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.targetLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.targetMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectTargetMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setCopyDataMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCopyDataMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadListsMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveListsMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listView1 = new System.Windows.Forms.ListView();
            this.addFilesButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectTragetLabel = new System.Windows.Forms.Label();
            this.selectDataLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.setTargetButton = new System.Windows.Forms.Button();
            this.deleteTargetButton = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.addFolderButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.targetTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.saveListsButton = new System.Windows.Forms.Button();
            this.loadListButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // targetFolderBrowser
            // 
            this.targetFolderBrowser.Description = "Select the directory that you want to use as the default.";
            this.targetFolderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // targetLabel
            // 
            this.targetLabel.AutoSize = true;
            this.targetLabel.Location = new System.Drawing.Point(10, 16);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(65, 13);
            this.targetLabel.TabIndex = 2;
            this.targetLabel.Text = "Хранилище";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Multiselect = true;
            // 
            // MainMenu
            // 
            this.MainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.targetMainMenuItem,
            this.dataMainMenuItem,
            this.loadListsMainMenuItem,
            this.saveListsMainMenuItem,
            this.ExitMainMenuItem});
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(53, 20);
            this.MainMenu.Text = "Меню";
            // 
            // targetMainMenuItem
            // 
            this.targetMainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectTargetMainMenuItem});
            this.targetMainMenuItem.Name = "targetMainMenuItem";
            this.targetMainMenuItem.Size = new System.Drawing.Size(174, 22);
            this.targetMainMenuItem.Text = "Хранилище";
            // 
            // selectTargetMainMenuItem
            // 
            this.selectTargetMainMenuItem.Name = "selectTargetMainMenuItem";
            this.selectTargetMainMenuItem.Size = new System.Drawing.Size(187, 22);
            this.selectTargetMainMenuItem.Text = "Выбрать хранилище";
            // 
            // dataMainMenuItem
            // 
            this.dataMainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setCopyDataMainMenuItem});
            this.dataMainMenuItem.Name = "dataMainMenuItem";
            this.dataMainMenuItem.Size = new System.Drawing.Size(174, 22);
            this.dataMainMenuItem.Text = "Данные";
            // 
            // setCopyDataMainMenuItem
            // 
            this.setCopyDataMainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCopyDataMainMenuItem});
            this.setCopyDataMainMenuItem.Name = "setCopyDataMainMenuItem";
            this.setCopyDataMainMenuItem.Size = new System.Drawing.Size(224, 22);
            this.setCopyDataMainMenuItem.Text = "Выбрать хранимые данные";
            // 
            // addCopyDataMainMenuItem
            // 
            this.addCopyDataMainMenuItem.Name = "addCopyDataMainMenuItem";
            this.addCopyDataMainMenuItem.Size = new System.Drawing.Size(126, 22);
            this.addCopyDataMainMenuItem.Text = "Добавить";
            // 
            // loadListsMainMenuItem
            // 
            this.loadListsMainMenuItem.Name = "loadListsMainMenuItem";
            this.loadListsMainMenuItem.Size = new System.Drawing.Size(174, 22);
            this.loadListsMainMenuItem.Text = "Загрузить списки";
            this.loadListsMainMenuItem.Click += new System.EventHandler(this.LoadListsMainMenuItem_Click);
            // 
            // saveListsMainMenuItem
            // 
            this.saveListsMainMenuItem.Name = "saveListsMainMenuItem";
            this.saveListsMainMenuItem.Size = new System.Drawing.Size(174, 22);
            this.saveListsMainMenuItem.Text = "Сохранить списки";
            this.saveListsMainMenuItem.Click += new System.EventHandler(this.SaveListsMainMenuItem_Click);
            // 
            // ExitMainMenuItem
            // 
            this.ExitMainMenuItem.Name = "ExitMainMenuItem";
            this.ExitMainMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ExitMainMenuItem.Text = "Выход";
            this.ExitMainMenuItem.Click += new System.EventHandler(this.ExitMainMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
            this.menuStrip1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.AllowColumnReorder = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.AutoArrange = false;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(5, 3);
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(441, 278);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // addFilesButton
            // 
            this.addFilesButton.Location = new System.Drawing.Point(3, 287);
            this.addFilesButton.Name = "addFilesButton";
            this.addFilesButton.Size = new System.Drawing.Size(120, 23);
            this.addFilesButton.TabIndex = 6;
            this.addFilesButton.Text = "Добавить файлы";
            this.addFilesButton.UseVisualStyleBackColor = true;
            this.addFilesButton.Click += new System.EventHandler(this.AddFilesButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(166, 287);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(120, 23);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(326, 287);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(120, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Enabled = false;
            this.copyButton.Location = new System.Drawing.Point(62, 39);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(170, 45);
            this.copyButton.TabIndex = 9;
            this.copyButton.Text = "Копировать";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(11, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            // 
            // selectTragetLabel
            // 
            this.selectTragetLabel.AutoSize = true;
            this.selectTragetLabel.ForeColor = System.Drawing.Color.Red;
            this.selectTragetLabel.Location = new System.Drawing.Point(10, 155);
            this.selectTragetLabel.Name = "selectTragetLabel";
            this.selectTragetLabel.Size = new System.Drawing.Size(110, 13);
            this.selectTragetLabel.TabIndex = 11;
            this.selectTragetLabel.Text = "Выбрать хранилище";
            // 
            // selectDataLabel
            // 
            this.selectDataLabel.AutoSize = true;
            this.selectDataLabel.ForeColor = System.Drawing.Color.Red;
            this.selectDataLabel.Location = new System.Drawing.Point(10, 181);
            this.selectDataLabel.Name = "selectDataLabel";
            this.selectDataLabel.Size = new System.Drawing.Size(92, 13);
            this.selectDataLabel.TabIndex = 12;
            this.selectDataLabel.Text = "Выбрать данные";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(10, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Для выполнения копирования необходимо:";
            // 
            // setTargetButton
            // 
            this.setTargetButton.Location = new System.Drawing.Point(8, 87);
            this.setTargetButton.Name = "setTargetButton";
            this.setTargetButton.Size = new System.Drawing.Size(120, 23);
            this.setTargetButton.TabIndex = 15;
            this.setTargetButton.Text = "Установить";
            this.setTargetButton.UseVisualStyleBackColor = true;
            this.setTargetButton.Click += new System.EventHandler(this.SetTargetButton_Click);
            // 
            // deleteTargetButton
            // 
            this.deleteTargetButton.Location = new System.Drawing.Point(199, 87);
            this.deleteTargetButton.Name = "deleteTargetButton";
            this.deleteTargetButton.Size = new System.Drawing.Size(120, 23);
            this.deleteTargetButton.TabIndex = 16;
            this.deleteTargetButton.Text = "Удалить";
            this.deleteTargetButton.UseVisualStyleBackColor = true;
            this.deleteTargetButton.Click += new System.EventHandler(this.DeleteTargetButton_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // addFolderButton
            // 
            this.addFolderButton.Location = new System.Drawing.Point(3, 316);
            this.addFolderButton.Name = "addFolderButton";
            this.addFolderButton.Size = new System.Drawing.Size(120, 23);
            this.addFolderButton.TabIndex = 17;
            this.addFolderButton.Text = "Добавить папки";
            this.addFolderButton.UseVisualStyleBackColor = true;
            this.addFolderButton.Click += new System.EventHandler(this.AddFolderButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.targetTextBox);
            this.panel1.Controls.Add(this.deleteTargetButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.setTargetButton);
            this.panel1.Controls.Add(this.selectDataLabel);
            this.panel1.Controls.Add(this.targetLabel);
            this.panel1.Controls.Add(this.selectTragetLabel);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 346);
            this.panel1.TabIndex = 18;
            // 
            // targetTextBox
            // 
            this.targetTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.targetTextBox.Enabled = false;
            this.targetTextBox.Location = new System.Drawing.Point(8, 41);
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.targetTextBox.Size = new System.Drawing.Size(311, 20);
            this.targetTextBox.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.addFilesButton);
            this.panel2.Controls.Add(this.clearButton);
            this.panel2.Controls.Add(this.addFolderButton);
            this.panel2.Location = new System.Drawing.Point(332, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 346);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.saveListsButton);
            this.panel3.Controls.Add(this.loadListButton);
            this.panel3.Controls.Add(this.copyButton);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 377);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(788, 122);
            this.panel3.TabIndex = 20;
            // 
            // saveListsButton
            // 
            this.saveListsButton.Location = new System.Drawing.Point(586, 39);
            this.saveListsButton.Name = "saveListsButton";
            this.saveListsButton.Size = new System.Drawing.Size(170, 45);
            this.saveListsButton.TabIndex = 15;
            this.saveListsButton.Text = "Сохранить списки";
            this.saveListsButton.UseVisualStyleBackColor = true;
            this.saveListsButton.Click += new System.EventHandler(this.SaveListsButton_Click);
            // 
            // loadListButton
            // 
            this.loadListButton.Location = new System.Drawing.Point(363, 39);
            this.loadListButton.Name = "loadListButton";
            this.loadListButton.Size = new System.Drawing.Size(170, 45);
            this.loadListButton.TabIndex = 14;
            this.loadListButton.Text = "Загрузить списки";
            this.loadListButton.UseVisualStyleBackColor = true;
            this.loadListButton.Click += new System.EventHandler(this.LoadListButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(788, 499);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Резервное копирование файлов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.FolderBrowserDialog targetFolderBrowser;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem MainMenu;
        private System.Windows.Forms.ToolStripMenuItem targetMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectTargetMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setCopyDataMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCopyDataMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMainMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button addFilesButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label selectTragetLabel;
        private System.Windows.Forms.Label selectDataLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button setTargetButton;
        private System.Windows.Forms.Button deleteTargetButton;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button addFolderButton;
        private System.Windows.Forms.ToolStripMenuItem saveListsMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadListsMainMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button saveListsButton;
        private System.Windows.Forms.Button loadListButton;
        private System.Windows.Forms.TextBox targetTextBox;
    }
}

