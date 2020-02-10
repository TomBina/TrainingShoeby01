namespace TrainingShoeby02
{
    public interface IDeserializer
    {
        T Deserialize<T>(string data);
    }
}