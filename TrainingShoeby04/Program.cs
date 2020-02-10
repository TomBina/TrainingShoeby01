using System.Threading.Tasks;

namespace TrainingShoeby04
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var reportGenerator = new ReportGenerator("data/data.json");
            var report = await reportGenerator.GenerateAsync();
        }
    }
}