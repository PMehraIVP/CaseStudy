using Case_Study_2025.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Case_Study_2025.EquitiesRepo
{
    public class BondsTableOps : IBondsTable
    {
        private readonly NewcsContext _context;

        public BondsTableOps(NewcsContext context)
        {
            _context = context;
        }

        public async Task<List<BondsTable>> GetAllData()
        {
            return await _context.BondsTables.ToListAsync();
        }

        public async Task<BondsTable?> GetBondById(int id)
        {
            return await _context.BondsTables.FindAsync(id);
        }

        public async Task<List<object>> GetTableDataByColumnValue(string tabName)
        {
            try
            {
                var result = new List<object>();
                var connStr = _context.Database.GetConnectionString();
                using var conn = new SqlConnection(connStr);
                await conn.OpenAsync();

                using var cmd = new SqlCommand("GetBondsDataByTabName", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TabName", tabName);

                using var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    var row = new Dictionary<string, object>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[reader.GetName(i)] = reader.GetValue(i);
                    }
                    result.Add(row);
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + " in GetDataFromTabNameUsingSP");
                return null;
            }
        }

        public async Task<BondsTable?> AddBond(BondsTable bond)
        {
            await _context.BondsTables.AddAsync(bond);
            await _context.SaveChangesAsync();
            return bond;
        }

        public async Task<BondsTable?> UpdateBondById(BondsTable bond)
        {
            var existing = await _context.BondsTables.FindAsync(bond.SecurityId);
            if (existing == null) return null;

            _context.Entry(existing).CurrentValues.SetValues(bond);
            await _context.SaveChangesAsync();
            return bond;
        }

        public async Task<BondsTable?> DeleteBondByName(string bondName)
        {
            var bond = await _context.BondsTables.FirstOrDefaultAsync(x => x.SecurityName == bondName); 
            if (bond == null) return null;

            _context.BondsTables.Remove(bond);
            await _context.SaveChangesAsync();
            return bond;
        }

        public async Task<BondsTable?> GetBondByName(string name)
        {
            return await _context.BondsTables.FirstOrDefaultAsync(b => b.SecurityName == name);
        }

        
    }
}
