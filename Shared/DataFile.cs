using Shared.Interfaces;

namespace Shared
{
    public class DataFile : IDataFile
    {
        public string FileName { get; set; } = "Unknown";
        public List<string> Content { get; set; } = new List<string>();
    }
}
