
namespace ReservCopyWFA.BL.Controller
{
    public class SaveDataController
    {
        private string TargetFolder { get; set; }
        private SourcePathController SourceFiles { get; set; }

        public SaveDataController(string targetFolder, SourcePathController sourceFiles)
        {
            TargetFolder = targetFolder;
            SourceFiles = sourceFiles;
        }

        public void SaveData()
        {
            SerializateLists dataSource = new SerializateLists();
            SerializateLists dataTarget = new SerializateLists();
            dataSource.Save(SourceFiles.FullFilesNames, "fullfilenames.xml");
            dataSource.Save(SourceFiles.FilesNames, "filenames.xml");
            dataSource.Save(SourceFiles.DirectoriesNeedCopy, "directories.xml");
            dataTarget.Save(TargetFolder);
        }
    }
}
