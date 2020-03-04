using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using ReservCopyWFA.BL.Models;

namespace ReservCopyWFA.BL.Controller
{
    public class CopyFilesController
    {
        private string TargetPath { get; }
        private readonly SourceModel model;

        public CopyFilesController(TargetPathController targetPath, SourcePathController sourceFiles)
        {
            TargetPath = targetPath.GetTargetFolder();
            
            model = sourceFiles.GetSourceModel();
            
            
        }

        /// <summary>
        /// Выполняем копирование файлов
        /// </summary>
        /// <returns>Возвращаем результат операции(флаг и список нескопированных файлов)</returns>
        public (bool, List<string>) Copy()
        {
            var ex = new List<string>();
            //по умолчанию флаг равен True, если возникнет ошибка флаг измениться
            var flag = true;
            var t = Task.Run(() =>
            {
                for (var i = 0; i < model.FilesNames.Count; i++)
                {
                    var currentTargerFolder = Path.Combine(TargetPath, model.DirectoriesNeedCopy[i]);
                    if (!Directory.Exists(currentTargerFolder))
                    {
                        Directory.CreateDirectory(currentTargerFolder);
                    }

                    try
                    {
                        FileSystem.CopyFile(model.FullFilesNames[i], Path.Combine(currentTargerFolder, model.FilesNames[i]), UIOption.AllDialogs, UICancelOption.DoNothing);
                    }
                    catch (Exception)
                    {
                        ex.Add(model.FullFilesNames[i]);
                        flag = false;
                        continue;
                    }

                }
            });
            t.Wait();
            return (flag, ex);

        }
    }
}
