using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservCopyWFA.BL.Models
{
    public class SourceModel
    {
        public List<string> FullFilesNames { get; set; }
        public List<string> DirectoriesNeedCopy { get; set; }
        public List<string> FilesNames { get; set; }
        

        public SourceModel()
        {
            FullFilesNames = new List<string>();
            FilesNames = new List<string>();
            DirectoriesNeedCopy = new List<string>();
        }
    }
}
