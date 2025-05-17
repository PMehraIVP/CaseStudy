using Case_Study_2025.EquitiesRepo;
using Case_Study_2025.Models;
using Microsoft.AspNetCore.Mvc;

namespace Case_Study_2025.Controllers
{
   
        [Route("Equity/[controller]")]
        [ApiController]
        public class EquityTableController : ControllerBase
        {
            private readonly IEquityTable _eq;

            public EquityTableController(IEquityTable eq)
            {
                _eq = eq;
            }

            [HttpGet("get")]
            public async Task<IActionResult> GetAllData()
            {
                var info = await _eq.GetAllData();
                return info == null ? NotFound() : Ok(info);
            }

            [HttpGet("getData/{tabName}")]
            public async Task<IActionResult> GetTabData(string tabName)
            {
                var info = await _eq.GetTableDataByColumnValue(tabName.Replace("%20"," "));
                return (info == null ) ? NotFound() : Ok(info);
            }

            [HttpPost("addSecurity")]
            public async Task<IActionResult> AddSec([FromBody] EquityTable table)
            {
                if (table == null) return BadRequest();
                var result = await _eq.AddSecurity(table);
                return result != null ? Ok(result) : BadRequest();
            }

            [HttpGet("getSecById/{secId}")]
            public async Task<IActionResult> getSecById(int secId)
            {
                var res = await _eq.getSecById(secId);
                return res != null ? Ok(res) : NotFound();
            }

            [HttpDelete("delete/{secId}")]
            public async Task<IActionResult> DelSecurity(int secId)
            {
                if (secId == 0) return BadRequest();
                var result = await _eq.DeleteSecurity(secId);
                return result != null ? Ok(result) : BadRequest();
            }

            [HttpPut("updateEquity")]
            public async Task<IActionResult> UpdatSecById([FromBody] EquityTable table)
            {
                var result = await _eq.UpdateSecurityById(table);
                return result != null ? Ok(result) : BadRequest("Equity Not Found");
            }

            [HttpGet("getSecByName/{secName}")]
            public async Task<IActionResult> getSecByName(string secName)
            {
                var res = await _eq.GetSecByName(secName);
                return res != null ? Ok(res) : NotFound();
            }
        }
    
}
