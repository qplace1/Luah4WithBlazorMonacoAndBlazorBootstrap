using Shared.Services;

namespace Shared.Interfaces;

public interface IDataFileService
{
    public Task<List<DataFile>?> GetFiles();
    public Task<List<DataFile>?> GetFiles(int fileCount);
}