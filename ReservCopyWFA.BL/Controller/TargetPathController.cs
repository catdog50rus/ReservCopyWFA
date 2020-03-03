using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservCopyWFA.BL.Controller
{
    
    public class TargetPathController
    {
        
        public string TargetFolderName { get; }
        private readonly DateTime NowDate = DateTime.Now;

        public TargetPathController(string targetPath)
        {
            var currentTargerFolder = Path.Combine(targetPath, NowDate.ToString("yyyy"));

            currentTargerFolder = Path.Combine(currentTargerFolder, (NowDate.ToString("MM") + " " + NowDate.ToString("MMM")));
            currentTargerFolder = Path.Combine(currentTargerFolder, NowDate.ToString("dd"));
            currentTargerFolder = Path.Combine(currentTargerFolder, NowDate.ToString("HHmmss"));

            

            //Присваеваем полный путь каталога хранения текущего дня
            TargetFolderName = currentTargerFolder;

            CreatFolder(TargetFolderName);
        }


        private void CreatFolder(string folder) 
        {
            // Проверить существует ли папка
            bool exist = Directory.Exists(folder);

            // Если нет, то создать данную папку.
            if (!exist)
            {
                Directory.CreateDirectory(folder);
            }

        }
    }
}
