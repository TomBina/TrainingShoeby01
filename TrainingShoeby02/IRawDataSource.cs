namespace TrainingShoeby02
{
    public interface IRawDataSource
    {
        (DataType type, string data) GetData();
    }
}