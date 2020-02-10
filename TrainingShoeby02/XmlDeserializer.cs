using System.IO;
using System.Xml.Serialization;

namespace TrainingShoeby02
{
    public class XmlDeserializer : IDeserializer
    {
        public T Deserialize<T>(string data)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));

            return (T) xmlSerializer.Deserialize(new StringReader(data));
        }
    }
}