
using ReservCopyWFA.BL.Models;

namespace ReservCopyWFA.BL.Controller
{
    public class SaveDataController
    {
        private string TargetFolder { get; }
        private readonly SourceModel source;

        public SaveDataController(string targetFolder, SourcePathController sourceFilesController)
        {
            TargetFolder = targetFolder;
            source = sourceFilesController.GetSourceModel();
            SerializateLists dataSource = new SerializateLists();
            SerializateLists dataTarget = new SerializateLists();
            if (source != null)
            {
                dataSource.Save(source.FullFilesNames, "fullfilenames.xml");
                dataSource.Save(source.FilesNames, "filenames.xml");
                dataSource.Save(source.DirectoriesNeedCopy, "directories.xml");
            }
            if (TargetFolder != null)
            {
                dataTarget.Save(TargetFolder);
            }
        }
    }
}
