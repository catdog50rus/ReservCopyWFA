
using System.Collections.Generic;
using System.Linq;




namespace ReservCopyWFA.BL.Controller
{
    public class LoadDataController
    {
        public string TargetPath { get; set; }
        public List<string> FullFileNames = new List<string>();
        public List<string> FileNames = new List<string>();
        public List<string> Dirs = new List<string>();

        private TargetPathController targetFolderController;
        public SourcePathController sourceFiles = new SourcePathController();

        public void LoadLists()
        {
            SerializateLists dataSource = new SerializateLists();
            SerializateLists dataTarget = new SerializateLists();
            TargetPath = dataTarget.LoadTargetPath();
            
            FullFileNames.AddRange(dataSource.Load("fullfilenames.xml").ToList());
            FileNames.AddRange(dataSource.Load("filenames.xml").ToList());
            Dirs.AddRange(dataSource.Load("directories.xml").ToList());

            if (FullFileNames.Count > 0 && FileNames.Count > 0 && Dirs.Count > 0)
            {
                SourceSet();
            }
            
            if (TargetPath.Length > 0)
            {
                TargetSet();
            }
        }

        private void TargetSet()
        {

            targetFolderController = new TargetPathController(TargetPath);
        }

        private void SourceSet()
        {
            sourceFiles.FullFilesNames.AddRange(FullFileNames);
            sourceFiles.FilesNames.AddRange(FileNames);
            sourceFiles.DirectoriesNeedCopy.AddRange(Dirs);
        }
    }

}
