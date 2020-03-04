using ReservCopyWFA.BL;
using ReservCopyWFA.BL.Controller;
using ReservCopyWFA.CI.AdditionalForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ReservCopyWFA.CI
{
    public partial class MainForm : Form
    {
        
        //контроллеры
        private SourcePathController sourceFilesController;
        private TargetPathController targetFolderConrtoller;

        private string TargetFolder { get; set; }

        public MainForm()
        {
            InitializeComponent();
            SetSourceController();
        }

        //Кнопки
        private void ExitMainMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Кнопки управления выбора целевого каталога
        private void SetTargetButton_Click(object sender, EventArgs e)
        {
            SetTargetFolder();
        }

        private void DeleteTargetButton_Click(object sender, EventArgs e)
        {
            var result = targetFolderConrtoller.DeleteFolder(TargetFolder);
            if (result)
            {
                TargetFolder = null;
                ActivatedCopyButton();
                targetTextBox.Text = null;
                targetLabel.Text = "Хранилище";
                targetLabel.ForeColor = Color.Black;
            }
            
        }
        #endregion

        #region Кнопки управления списком копируемых файлов
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
 
            sourceFilesController.ClearSourceFile();
            ListUpdate();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var files = new List<string>();
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                files.Add(item.Text);
            }
            
            sourceFilesController.RemoveSourceFile(files);
            ListUpdate();

        }
        #endregion

        private void CopyButton_Click(object sender, EventArgs e)
        {
            
            CopyFiles();
        }

        #region Кнопки управления сериализацией списков
        private void SaveListsMainMenuItem_Click(object sender, EventArgs e)
        {
            SaveLists();
        }

        private void LoadListsMainMenuItem_Click(object sender, EventArgs e)
        {
            LoadLists();

        }

        private void LoadListButton_Click(object sender, EventArgs e)
        {
            LoadLists();
        }

        private void SaveListsButton_Click(object sender, EventArgs e)
        {
            SaveLists();
        }
        #endregion

        //Вспомогательные методы//

        /// <summary>
        /// Обновление списка копируемых файлов на форме
        /// </summary>
        private void ListUpdate()
        {
            
            listView1.Items.Clear();

            var fullFilesNames = sourceFilesController.GetFileNamesList();
            foreach (var file in fullFilesNames)
            {
                listView1.Items.Add(file);
            }
            

            // Установка цвета надписи
            if (fullFilesNames.Count == 0)
            {
                selectDataLabel.ForeColor = Color.Red;
            }
            else
            {
                selectDataLabel.ForeColor = Color.Green;
                ActivatedCopyButton();
            }
            
        }

        /// <summary>
        /// Устанавливаем каталог хранения текущего дня
        /// </summary>
        private void SetTargetFolder() 
        {
            DialogResult result = targetFolderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Cоздаем новый контроллер
                targetFolderConrtoller = new TargetPathController();
                //Устанавливаем в модель каталог
                if (targetFolderConrtoller.SetTargetFolder(targetFolderBrowser.SelectedPath))
                {
                    //Если каталог установлен, выводим путь каталога хранения текущего дня на форму
                    TargetFolder = targetFolderConrtoller.GetTargetFolder();
                    SetTargetLabel();
                }
                else
                {
                    //Выводим информацию об оштбке
                    MessageBox.Show("Установить каталог не удалось!", "Что-то пошло не так!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
                
            }

        }

        /// <summary>
        /// Устанавливаем копируемый Каталог
        /// </summary>
        private void SetSourseFolder()
        {

            DialogResult result = targetFolderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                SetSourceController();
                sourceFilesController.AddSourceDirectory(targetFolderBrowser.SelectedPath);
            }

            ListUpdate();


        }

        /// <summary>
        /// Устанавливаем копируемые файлы по файлово
        /// </summary>
        private void SetSourceFiles()
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {

                var files = new List<string>();
                
                files.AddRange(openFileDialog.FileNames);

                SetSourceController();
                sourceFilesController.AddSourceFile(files);

            }
            ListUpdate();
        }

        private void SetTargetLabel()
        {
            targetLabel.Text = "Установлено хранилище:";
            targetLabel.ForeColor = Color.Green;
            targetTextBox.Text = targetFolderConrtoller.GetTargetFolder();

            //Даем возможность произвести копирование
            ActivatedCopyButton();
        }

        private void ActivatedCopyButton()
        {
            if (TargetFolder != null && selectDataLabel.ForeColor == Color.Green)
            {
                copyButton.Enabled = true;
                selectTragetLabel.ForeColor = Color.Green;
                setTargetButton.Text = "Изменить";

            }
            else
            {
                copyButton.Enabled = false;
                selectTragetLabel.ForeColor = Color.Red;
                setTargetButton.Text = "Установить";
            }
        }


        private void CopyFiles()
        {
            CopyFilesController copy = new CopyFilesController(targetFolderConrtoller, sourceFilesController);
            var resultCopy = copy.Copy();
            if (resultCopy.Item1)
            {
                MessageBox.Show("Копирование успешно завершено!", "Выполнено!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Что-то пошло не так!", "Не все файлы скопированы!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new CopyErrorForm(resultCopy.Item2).Show();
            }
        }

        private void LoadLists()
        {
            
            LoadDataController loadData = new LoadDataController();
            
            var resultLoad = loadData.GetLoadResult();
            targetFolderConrtoller = resultLoad.Item1;
            sourceFilesController = resultLoad.Item2;
            var errFileList = resultLoad.Item3;


            if(targetFolderConrtoller != null)
            {
                //Выводим путь каталога хранения текущего дня на форму
                TargetFolder = targetFolderConrtoller.GetTargetFolder();
                SetTargetLabel();
            }
            
            if(sourceFilesController != null && errFileList.Count == 0)
            {
                //Обновляем список файлов
                ListUpdate();
                MessageBox.Show("Загрузка списков завершена", "Выполнено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else if(errFileList.Count != 0)
            {
                if (sourceFilesController != null)
                {
                    ListUpdate();
                }

                MessageBox.Show("Не все файлы в списках есть на диске", "Что-то пошло не так!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                new CopyErrorForm(errFileList).Show();
            }
            else
            {
                MessageBox.Show("Нет списков для загрузки", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void SaveLists()
        {
            if (sourceFilesController.GetFileNamesList().Count > 0)
            {
                new SaveDataController(TargetFolder, sourceFilesController);

                MessageBox.Show("Сохранение настроек успешно завершено!", "Выполнено!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Не все списки сохранены!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SetSourceController()
        {
            if (sourceFilesController == null)
            {
                sourceFilesController = new SourcePathController();
            }
        }
    }
}

