using System.Net.Http.Json;
using Shared.Interfaces;

namespace Shared.Services;

public class DataFileClientService : IDataFileService
{
    private readonly HttpClient _httpClient;

    public DataFileClientService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<DataFile>?> GetFiles()
    {
        return await GetFiles(10);
    }

    public async Task<List<DataFile>?> GetFiles(int fileCount)
    {
        return await _httpClient.GetFromJsonAsync<List<DataFile>>("api/files");
    }
}