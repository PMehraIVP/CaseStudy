using Case_Study_2025.Models;

namespace Case_Study_2025.EquitiesRepo
{
    public interface IBondsTable
    {
        Task<List<BondsTable>> GetAllData();
        Task<List<object>> GetTableDataByColumnValue(string tabName);
        Task<BondsTable> AddBond(BondsTable table);
        Task<BondsTable> GetBondById(int secId);
        Task<BondsTable> GetBondByName(string secName);
        Task<BondsTable> UpdateBondById(BondsTable table);
        Task<BondsTable> DeleteBondByName(string bondName);
    }
}