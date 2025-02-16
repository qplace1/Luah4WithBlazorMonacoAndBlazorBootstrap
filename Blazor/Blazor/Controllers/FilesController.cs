using Microsoft.AspNetCore.Mvc;
using Shared.Interfaces;
using Shared.Services;

namespace Blazor.Controllers
{
    [ApiController]
    [Route("api/files")]
    public class FilesController : ControllerBase
    {
        private readonly IDataFileService _dataFileService;

        public FilesController(IDataFileService dataFileService)
        {
            _dataFileService = dataFileService;
        }

        [HttpGet]
        public async Task<ActionResult<List<DataFile>>> GetFiles()
        {
            var dataFiles = await _dataFileService.GetFiles();
            return Ok(dataFiles);
        }
    }

}
