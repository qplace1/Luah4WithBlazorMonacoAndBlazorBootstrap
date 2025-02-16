using Shared.Interfaces;

namespace Shared.Services;

public class DataFileServerService : IDataFileService
{
    public async Task<List<DataFile>?> GetFiles()
    {
        return await GetFiles(10);
    }

    public async Task<List<DataFile>?> GetFiles(int fileCount)
    {
        List<DataFile> dataFiles = [];
        for (int i = 0; i < fileCount; i++)
        {
            DataFile file = new DataFile
            {
                FileName = $"File {i + 1}"
            };
            for (int j = 0; j < 20; ++j)
                file.Content.Add($"Line {j + 1}");
            dataFiles.Add(file);
        }

        await Task.CompletedTask;
        return dataFiles;
    }
}