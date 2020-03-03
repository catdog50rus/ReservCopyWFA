using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservCopyWFA.BL.Controller
{
    public interface IListSaver
    {

        void Save(List<string> item);

        List<string> Load();
    }
        
    
}
