using DRrestapi.Managers;
using DRrestapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DRrestapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordsController : ControllerBase
    {
        private readonly RecordsManager _manager = new RecordsManager();

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Record> GetAll([FromHeader] int? amount, [FromQuery] string? subString)
        {
            IEnumerable<Record> records = _manager.GetAll(amount, subString);
            if (records == null) return NotFound("No list found");
            return Ok(records);
        }
    }
}
