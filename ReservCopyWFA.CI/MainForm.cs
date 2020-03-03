using ReservCopyWFA.BL;
using ReservCopyWFA.BL.Controller;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ReservCopyWFA.CI
{
    public partial class MainForm : Form
    {
        
        //коллекция имен файлов с полным путем
        private SourcePathController sourceFiles = new SourcePathController();
        private TargetPathController targetFolderConrtoller;

        private string TargetFolder { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitMainMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SetTargetButton_Click(object sender, EventArgs e)
        {
            SetTargetFolder();
        }

        private void DeleteTargetButton_Click(object sender, EventArgs e)
        {
            TargetFolder = null;
            ActivatedCopyButton();
            targetTextBox.Text = null;
        }
        
        private void AddFilesButton_Click(object sender, EventArgs e)
        {
            SetSourceFiles();
        }

        private void AddFolderButton_Click(object sender, EventArgs e)
        {
            SetSourseFolder();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
 
            sourceFiles.ClearSourceFile();
            ListUpdate();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var files = new List<string>();
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                files.Add(item.Text);
            }
            
            sourceFiles.RemoveSourceFile(files);
            ListUpdate();

        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            
            CopyFiles();
           

        }

        private void SaveListsMainMenuItem_Click(object sender, EventArgs e)
        {
            //SaveLists();
        }

        private void LoadListsMainMenuItem_Click(object sender, EventArgs e)
        {
            //LoadLists();

        }

        private void LoadListButton_Click(object sender, EventArgs e)
        {
            //LoadLists();
        }

        private void SaveListsButton_Click(object sender, EventArgs e)
        {
            //SaveLists();
        }

        //Вспомогательные методы//

        private void ListUpdate()
        {
            listView1.Items.Clear();

            foreach (var file in sourceFiles.FullFilesNames)
            {
                listView1.Items.Add(file);
   
            }


            // Установка цвета надписи
            if (sourceFiles.FullFilesNames.Count == 0)
            {
                selectDataLabel.ForeColor = Color.Red;
            }
            else
            {
                selectDataLabel.ForeColor = Color.Green;
            }
        }

        private void SetTargetFolder() //Устанавливаем каталог хранения текущего дня
        {
            DialogResult result = targetFolderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Устанавливаем текущий каталог, выбранный пользователем

                //TargetFolder = targetFolderBrowser.SelectedPath;
                
                targetFolderConrtoller = new TargetPathController(targetFolderBrowser.SelectedPath);
               
                //Выводим путь каталога хранения текущего дня на форму

                SetTargetLabel();
            }

        }

        private void SetTargetLabel()
        {
            targetLabel.Text = "Установлено хранилище:";
            targetTextBox.Text = targetFolderConrtoller.TargetFolderName;

            //Даем возможность произвести копирование
            ActivatedCopyButton();
        }

        private void ActivatedCopyButton()
        {
            if(TargetFolder != null)
            {
                copyButton.Enabled = true;
                selectTragetLabel.ForeColor = Color.Green;
                setTargetButton.Text = "Изменить";

            }
            else
            {
                copyButton.Enabled = false ;
                selectTragetLabel.ForeColor = Color.Red;
                setTargetButton.Text = "Установить";
            }
        }

        private void SetSourseFolder()
        {

            DialogResult result = targetFolderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                var files = new List<string>();
                sourceFiles.AddSourceDirectory(targetFolderBrowser.SelectedPath);

            }

            ListUpdate();


        }

        private void SetSourceFiles()
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {

                var files = new List<string>();
                
                files.AddRange(openFileDialog.FileNames);

                sourceFiles.AddSourceFile(files);

            }
            ListUpdate();
        }

        private void CopyFiles()
        {
            
            CopyFilesController copyFiles = new CopyFilesController(targetFolderConrtoller, sourceFiles);
            copyFiles.CopyFiles();
            Thread.Sleep(1500);
            MessageBox.Show("Копирование успешно завершено!", "Выполнено!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadLists()
        {
            LoadDataController loadData = new LoadDataController();
            loadData.LoadLists();

            if (loadData.TargetPath.Length > 0 
                && loadData.sourceFiles.FullFilesNames.Count > 0 
                && loadData.sourceFiles.FilesNames.Count > 0 
                && loadData.sourceFiles.DirectoriesNeedCopy.Count > 0)
            {
                //Выводим путь каталога хранения текущего дня на форму
                MessageBox.Show("Загрузка списков завершена", "Выполнено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                targetFolderConrtoller = new TargetPathController(loadData.TargetPath);
                sourceFiles = loadData.sourceFiles;

                TargetFolder = loadData.TargetPath;


                //Даем возможность произвести копирование
                SetTargetLabel();

                ListUpdate();
            }
            else
            {
                MessageBox.Show("Нет списков для загрузки", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SaveLists()
        {
            if (sourceFiles.FullFilesNames.Count > 0)
            {
                SaveDataController saveData = new SaveDataController(TargetFolder, sourceFiles);
                saveData.SaveData();

                MessageBox.Show("Сохранение настроек успешно завершено!", "Выполнено!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Не все списки сохранены!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}

