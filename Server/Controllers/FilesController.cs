using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Shared;

namespace Controllers
{
    [ApiController]
    [Route("api/files")]
    public class FilesController : ControllerBase
    {
        private readonly List<DataFile> DataFiles = new List<DataFile>();
        private int NumFiles = 10;

        public FilesController()
        {
            for (int i = 0; i < NumFiles; i++)
            {
                DataFile file = new DataFile();
                file.FileName = $"File {i + 1}";
                for (int j = 0; j < 20; ++j)
                    file.Content.Add($"Line {j + 1}");
                DataFiles.Add(file);
            }
        }

        [HttpGet]
        public async Task<ActionResult<List<DataFile>>> GetFiles()
        {
            return Ok(DataFiles);
        }
    }

}
