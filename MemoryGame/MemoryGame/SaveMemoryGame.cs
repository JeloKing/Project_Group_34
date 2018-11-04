using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MemoryGame
{
    public static class SaveMemoryGame
    {
        /// <summary>
        /// Writes given information to a xml file
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="Filename"></param>
        public static void SaveData(object obj, string Filename)
        {
            XmlSerializer sr = new XmlSerializer(obj.GetType());
            TextWriter writer = new StreamWriter(Filename);

            sr.Serialize(writer, obj);
            writer.Close();
        }

    }
}
