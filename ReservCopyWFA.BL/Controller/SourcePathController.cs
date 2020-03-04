using ReservCopyWFA.BL.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace ReservCopyWFA.BL
{
    [Serializable]
    public class SourcePathController
    {

        private readonly SourceModel model;
        

        public SourcePathController()
        {
            model = new SourceModel();

        }
        public SourcePathController(List<string> fullFilesNames, List<string> directoriesNeedCopy, List<string> filesNames)
        {
            model = new SourceModel
            {
                DirectoriesNeedCopy = directoriesNeedCopy,
                FilesNames = filesNames,
                FullFilesNames = fullFilesNames
            };
        }

        public void AddSourceFile(List<string> files)
        {

            DirectoryInfo info = new DirectoryInfo(Path.GetDirectoryName(files[0]));
            var selectedDir = info.Name;

            foreach (var file in files)
            {
                model.FullFilesNames.Add(file);
                model.FilesNames.Add(Path.GetFileName(file));
                model.DirectoriesNeedCopy.Add(selectedDir);
            }

        }

        public void AddSourceDirectory(string selectPath)
        {

            List<string> subDirs = new List<string>();

            DirectoryInfo info = new DirectoryInfo(selectPath);
            var selectedDir = info.Name;

            subDirs.AddRange(Directory.GetDirectories(selectPath, "*", SearchOption.AllDirectories).ToList());

            foreach (var dir in subDirs)
            {

                foreach (var file in Directory.EnumerateFiles(dir))
                {
                    model.FullFilesNames.Add(file);
                    model.FilesNames.Add(Path.GetFileName(file));
                    model.DirectoriesNeedCopy.Add(dir.Substring(selectPath.Length - selectedDir.Length));
                }

            }
            

        }

        public void ClearSourceFile()
        {
            model.FullFilesNames.Clear();
            model.FilesNames.Clear();
            model.DirectoriesNeedCopy.Clear();
        }

        public void RemoveSourceFile(List<string> removeFiles)
        {
            while(removeFiles.Count > 0)
            {
                for (var i = 0; i < model.FullFilesNames.Count; i++)
                {
                    if (model.FullFilesNames[i] == removeFiles.FirstOrDefault())
                    {
                        model.FullFilesNames.RemoveAt(i);
                        model.FilesNames.RemoveAt(i);
                        model.DirectoriesNeedCopy.RemoveAt(i);
                        removeFiles.RemoveAt(0);
                    }
                }
            }
        }

        public List<string> GetFileNamesList()
        {
            return model.FullFilesNames;
        }

        public SourceModel GetSourceModel()
        {
            return model;
        }

    }
}
