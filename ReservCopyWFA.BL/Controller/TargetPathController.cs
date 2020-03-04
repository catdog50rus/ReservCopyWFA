using ReservCopyWFA.BL.Models;
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
        
        private readonly DateTime NowDate = DateTime.Now;
        private readonly TargetModel target;

        public TargetPathController()
        {
            target = new TargetModel();
        }

        /// <summary>
        /// Прибавляем к имени каталога год/месяц/день/время и создаем этот каталог
        /// </summary>
        /// <param name="targetPath"></param>
        /// <returns>Если каталог создан возвращаем True, иначе возвращаем False</returns>
        public bool SetTargetFolder(string targetPath)
        {
            var currentTargerFolder = Path.Combine(targetPath, NowDate.ToString("yyyy"));

            currentTargerFolder = Path.Combine(currentTargerFolder, (NowDate.ToString("MM") + " " + NowDate.ToString("MMM")));
            currentTargerFolder = Path.Combine(currentTargerFolder, NowDate.ToString("dd"));
            currentTargerFolder = Path.Combine(currentTargerFolder, NowDate.ToString("HHmmss"));

            //обращаемся к методу записи имени каталога в модель
            return SetTarget(currentTargerFolder);
            
        }
        
        /// <summary>
        /// Метод для записи имени каталога в модель
        /// </summary>
        /// <param name="targetPath"></param>
        /// <returns></returns>
        public bool SetTarget(string targetPath)
        {
            //Провряем, удалось ли создать каталог, если да, то записываем его имя в модель
            if(CreatFolder(targetPath))
            {
                //Присваеваем полный путь каталога хранения текущего дня
                target.TargetFolderName = targetPath;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Создаем каталог для копирования. 
        /// </summary>
        /// <param name="folder"></param>
        /// <returns>Если каталог создан возвращаем True, иначе возвращаем False</returns>
        private bool CreatFolder(string folder) 
        {
            // Проверить существует ли папка
            bool exist = Directory.Exists(folder);

            // Если нет, то создать данную папку.
            if (!exist)
            {
                try
                {
                    Directory.CreateDirectory(folder);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                
            }
            return true;

        }

        /// <summary>
        /// Возвращаем имя каталога из модели
        /// </summary>
        /// <returns></returns>
        public string GetTargetFolder()
        {
            return target.TargetFolderName;
        }

        public bool DeleteFolder(string folder)
        {
            bool exist = Directory.Exists(folder);

            // Если нет, то создать данную папку.
            if (exist)
            {
                try
                {
                    Directory.Delete(folder);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }

            }
            return false;
        }
    }
}
