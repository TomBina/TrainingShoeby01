using System.IO;

namespace TrainingShoeby02
{
    public class FileDataSource : IRawDataSource
    {
        private readonly string _path;

        public FileDataSource(string path)
        {
            _path = path;
        }

        public (DataType type, string data) GetData()
        {
            var data = File.ReadAllText(_path);

            return _path.EndsWith(".xml") ? (DataType.Xml, data) : (DataType.Json, data);
        }
    }
}