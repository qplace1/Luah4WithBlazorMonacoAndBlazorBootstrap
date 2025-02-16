using Shared.Interfaces;

namespace Shared.Services
{
    public class DataFile : IDataFile
    {
        public string FileName { get; set; } = "Unknown";
        public List<string> Content { get; set; } = [];
    }
}
