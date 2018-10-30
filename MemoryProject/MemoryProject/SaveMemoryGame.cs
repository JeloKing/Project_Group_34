using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace MemoryProject
{
    public class SaveMemoryGame
    {

        public static void savedata(object obj, string filename)
        {

            XmlSerializer sr = new XmlSerializer(obj.GetType());
            TextWriter writer = new StreamWriter(filename);

            sr.Serialize(writer, obj);
            writer.Close();
        }

    }
}
