using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReservCopyWFA.BL.Controller
{
    public class SerializateLists
    {
        
        public List<string> Load(string fileName) 
        {
            var formatter = new XmlSerializer(typeof(List<string>));

            if (File.Exists(fileName))
            {
                using (var fs = new FileStream(fileName, FileMode.Open))
                {
                    if (fs.Length > 0 && formatter.Deserialize(fs) is List<string> items)
                    {
                        return items;
                    }
                    else
                    {
                        return new List<string>();
                    }
                }
            }
            else
            {
                
                return new List<string>();
            }
        }

        public string LoadTargetPath()
        {
            var formatter = new XmlSerializer(typeof(string));
            var fileName = "targetlist.xml";

            if (File.Exists(fileName))
            {
                using (var fs = new FileStream(fileName, FileMode.Open))
                {
                    if (fs.Length > 0 && formatter.Deserialize(fs) is string targetPath)
                    {
                        if (Directory.Exists(targetPath))
                            return targetPath;
                        else return "";
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            else
            {
                return "";
            }
        }


        public void Save(List<string> item, string fileName)
        {
            var formatter = new XmlSerializer(typeof(List<string>));
            

            using (var fs = new FileStream(fileName, FileMode.Create))
            {
                formatter.Serialize(fs, item);
            }
        }

        public void Save(string target)
        {
            var formatter = new XmlSerializer(typeof(string));
            var fileName = "targetlist.xml";

            using (var fs = new FileStream(fileName, FileMode.Create))
            {
                formatter.Serialize(fs, target);
            }
        }
    }
        
    
}
