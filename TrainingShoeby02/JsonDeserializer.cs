using Newtonsoft.Json;

namespace TrainingShoeby02
{
    public class JsonDeserializer : IDeserializer
    {
        public T Deserialize<T>(string data) 
            => JsonConvert.DeserializeObject<T>(data);
    }
}