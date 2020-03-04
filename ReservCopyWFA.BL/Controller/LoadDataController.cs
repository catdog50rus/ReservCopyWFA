using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ReservCopyWFA.BL.Controller
{
    public class LoadDataController
    {
        private string TargetPath { get; set; }
        private readonly List<string> FullFileNames = new List<string>();
        private readonly List<string> FileNames = new List<string>();
        private readonly List<string> Dirs = new List<string>();

        private readonly List<string> errorFileList = new List<string>();

        private TargetPathController targetFolderController;
        private SourcePathController sourceFilesController;

        public LoadDataController()
        {
            SerializateLists loadData = new SerializateLists();
            
            //Если каталог существует 
            TargetPath = loadData.LoadTargetPath("targetlist.xml");

            FullFileNames.AddRange(loadData.Load("fullfilenames.xml").ToList());
            FileNames.AddRange(loadData.Load("filenames.xml").ToList());
            Dirs.AddRange(loadData.Load("directories.xml").ToList());

            if (FullFileNames.Count > 0 && FileNames.Count > 0 && Dirs.Count > 0)
            {
                SourceSet();
            }

            if (TargetPath.Length > 0)
            {
                TargetSet();
            }
        }

        /// <summary>
        /// Записываем в модель загруженный каталог
        /// </summary>
        private void TargetSet()
        {
            DirectoryInfo di = new DirectoryInfo(TargetPath);

            for(var i = 0; i < 4; i++)
            {
                di = di.Parent;
            }
            targetFolderController = new TargetPathController();
            targetFolderController.SetTargetFolder(di.FullName);
        }
        /// <summary>
        /// Записываем в модель загружаемые списки
        /// </summary>
        private void SourceSet()
        {
            //Проверка на наличие копируемых файлов
            //Создаем локальные списки
            var fullFileNames = new List<string>();
            var fileNames = new List<string>();
            var dirs = new List<string>();
            //создаем локальный список путей файлов
            var fileInfo = new List<FileInfo>();
            foreach (var item in FullFileNames)
            {
                fileInfo.Add(new FileInfo(item));
            }
            //Проверяем пути файлов на наличие файлов
            for (var i = 0; i < fileInfo.Count; i++)
            {
                //Если файл есть, добавляем его в списки
                if (fileInfo[i].Exists)
                {

                    fullFileNames.Add(FullFileNames[i]);
                    fileNames.Add(FileNames[i]);
                    dirs.Add(Dirs[i]);

                }
                //Если файла нет, добавляем его путь в сисок ошибок пути
                else
                {
                    errorFileList.Add(FullFileNames[i]);
                }
            }
            //Создаем контроллер с указаем всех имеющихся в списках файлов
            sourceFilesController = new SourcePathController(fullFileNames, dirs, fileNames);
        }

        /// <summary>
        /// Возвращаем кортеж (Контроллеры и список ошибок путей)
        /// </summary>
        /// <returns></returns>
        public (TargetPathController, SourcePathController, List<string>) GetLoadResult()
        {
            return (targetFolderController, sourceFilesController, errorFileList);
        }
    }

}
