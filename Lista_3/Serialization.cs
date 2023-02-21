using System.IO;
using System.Xml.Serialization;

namespace Lista_3
{
    public static class Serialization
    {
        public static T DeserializeToObject<T>(string Filepath) where T : class
        {
            XmlSerializer serlz = new XmlSerializer(typeof(T));
            using (StreamReader srl = new StreamReader(Filepath))
            {
                return (T)serlz.Deserialize(srl);
            }
        }
        public static void SerializeToXml<T>(T anyobject, string xmlFilePath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(anyobject.GetType());
            using (StreamWriter writer = File.CreateText(xmlFilePath))
            {
                xmlSerializer.Serialize(writer, anyobject);
            }
        }
    }
}
