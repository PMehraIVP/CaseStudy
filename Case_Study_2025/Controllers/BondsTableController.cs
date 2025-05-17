using Case_Study_2025.EquitiesRepo;
using Case_Study_2025.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Case_Study_2025.Controllers
{
    [Route("Bonds/[controller]")]
    [ApiController]
    public class BondsTableController : ControllerBase
    {
        private readonly IBondsTable _bond;

        public BondsTableController(IBondsTable bond)
        {
            _bond = bond;
        }

        [HttpGet("get")]
        public async Task<IActionResult> GetAllData()
        {
            var data = await _bond.GetAllData();
            return Ok(data);
        }

        [HttpGet("getDataByColumn/{tabName}")]
        public async Task<IActionResult> GetDataByColumn(string tabName)
        {
            var result = await _bond.GetTableDataByColumnValue(tabName.Replace("%20"," "));
            return result != null ? Ok(result) : NotFound();
        }

        [HttpPost("addBond")]
        public async Task<IActionResult> AddBond([FromBody] BondsTable bond)
        {
            if (bond == null) return BadRequest();
            var result = await _bond.AddBond(bond);
            return result != null ? Ok(result) : BadRequest();
        }

        [HttpGet("getBondById/{secId}")]
        public async Task<IActionResult> GetBondById(int secId)
        {
            var result = await _bond.GetBondById(secId);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet("getBondByName/{secName}")]
        public async Task<IActionResult> GetBondByName(string secName)
        {
            var result = await _bond.GetBondByName(secName);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpPut("updateBond")]
        public async Task<IActionResult> UpdateBond([FromBody] BondsTable bond)
        {
            if (bond == null) return BadRequest();
            var result = await _bond.UpdateBondById(bond);
            return result != null ? Ok(result) : BadRequest("Bond not found");
        }

        [HttpDelete("deleteBondByName/{bondName}")]
        public async Task<IActionResult> DeleteBondByName(string bondName)
        {
            if (bondName.IsNullOrEmpty()) return BadRequest();
            var result = await _bond.DeleteBondByName(bondName);
            return result != null ? Ok(result) : NotFound();
        }
    }
}
