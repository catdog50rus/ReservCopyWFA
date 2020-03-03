using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace ReservCopyWFA.BL.Controller
{
    public class CopyFilesController
    {
        private string TargetPath { get; set; }
        private SourcePathController SourceFiles { get; set; }

        public CopyFilesController(TargetPathController targetPath, SourcePathController sourceFiles)
        {
            TargetPath = targetPath.TargetFolderName;
            SourceFiles = sourceFiles;
        }

        public void CopyFiles()
        {

            var t = Task.Run(() =>
            {
                for (var i = 0; i < SourceFiles.FilesNames.Count; i++)
                {
                    var currentTargerFolder = Path.Combine(TargetPath, SourceFiles.DirectoriesNeedCopy[i]);
                    if (!Directory.Exists(currentTargerFolder))
                    {
                        Directory.CreateDirectory(currentTargerFolder);
                    }
                    FileSystem.CopyFile(SourceFiles.FullFilesNames[i], Path.Combine(currentTargerFolder, SourceFiles.FilesNames[i]), UIOption.AllDialogs, UICancelOption.DoNothing);

                    //File.Copy(SourceFiles.FullFilesNames[i], Path.Combine(currentTargerFolder, SourceFiles.FilesNames[i]), true);


                }
                

            });

            t.Wait();

            
        }
    }
}
