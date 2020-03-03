using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace ReservCopyWFA.BL
{
    [Serializable]
    public class SourcePathController
    {

        public List<string> FullFilesNames { get; set;} 
        public List<string> DirectoriesNeedCopy { get; set; } 
        public List<string> FilesNames { get; set; } 
        

        public SourcePathController()
        {
            FullFilesNames = new List<string>();
            FilesNames = new List<string>();
            DirectoriesNeedCopy = new List<string>();
        }

        public void AddSourceFile(List<string> files)
        {

            DirectoryInfo info = new DirectoryInfo(Path.GetDirectoryName(files[0]));
            var selectedDir = info.Name;

            foreach (var file in files)
            {
                FullFilesNames.Add(file);
                FilesNames.Add(Path.GetFileName(file));
                DirectoriesNeedCopy.Add(selectedDir);
            }

        }

        public void AddSourceDirectory(string selectPath)
        {

            List<string> subDirs = new List<string>();

            DirectoryInfo info = new DirectoryInfo(selectPath);
            var selectedDir = info.Name;
            

            subDirs.AddRange(Directory.GetDirectories(selectPath, "*", SearchOption.AllDirectories).ToList());
            //if(subDirs.Count == 0)
            //{
            //    subDirs.Add(selectPath);
            //}

            foreach (var dir in subDirs)
            {

                foreach(var file in Directory.EnumerateFiles(dir))
                {
                    FullFilesNames.Add(file);
                    FilesNames.Add(Path.GetFileName(file));
                    DirectoriesNeedCopy.Add(dir.Substring(selectPath.Length - selectedDir.Length));
                }

            }


        }

        public void ClearSourceFile()
        {
            FullFilesNames.Clear();
            FilesNames.Clear();
            DirectoriesNeedCopy.Clear();
        }

        public void RemoveSourceFile(List<string> removeFiles)
        {
            while(removeFiles.Count > 0)
            {
                for (var i = 0; i < FullFilesNames.Count; i++)
                {
                    if (FullFilesNames[i] == removeFiles.FirstOrDefault())
                    {
                        FullFilesNames.RemoveAt(i);
                        FilesNames.RemoveAt(i);
                        DirectoriesNeedCopy.RemoveAt(i);
                        removeFiles.RemoveAt(0);
                    }
                }
            }
        }

    }
}
