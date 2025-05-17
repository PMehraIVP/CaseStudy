using Case_Study_2025.Models;

namespace Case_Study_2025.EquitiesRepo
{
    public interface IEquityTable
    {
        Task<List<EquityTable>> GetAllData();
        Task<List<object>> GetTableDataByColumnValue(string tabName);
        Task<EquityTable?> getSecById(int secId);
        Task<string> AddSecurity(EquityTable table);
        Task<string> DeleteSecurity(int secId);
        Task<string> UpdateSecurityById(EquityTable table);
        Task<EquityTable> GetSecByName(string secName);
    }
}
