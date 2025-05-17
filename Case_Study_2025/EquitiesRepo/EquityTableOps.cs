using Case_Study_2025.Models;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Data;


namespace Case_Study_2025.EquitiesRepo
{
    public class EquityTableOps : IEquityTable
    {
        NewcsContext _context;
        public EquityTableOps(NewcsContext context)
        {
            _context = context;
        }


        //-----------------------------------------------------------------------------

        //read
        public async Task<List<EquityTable>> GetAllData()
        {
            try
            {
                var data = await _context.EquityTables.ToListAsync();
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "Equity:GetAllData");
                return null;
            }

            //below is how i can make it deffered , ie table only loaded when u need for iteration not like above 
            //defered = lazy exec -> query run when u do tolist in here or somewhere else 
            //public IQueryable<EquityTable> GetAllData()
            //{
            //    return _context.EquityTables; // Deferred Execution
            //}-------------------------------------------------------------------------------------------------------------
            //TOLIST -> GOOD -> await _context.EquityTables.ToListAsync(); RUN HERE ONLY, THEN SENT , USER CANNOT CHANGE IN F.E
            //IQUERYABLE BAD -> WHY? -> await _context.EquityTables.ToListAsync(); X RUN HERE, F.E ADD Where(X>100) SMTH -> NEW ->PB

        }



        //get tab wise data
        public async Task<List<object>> GetTableData(string tableName)
        {
            try
            {
                var results = new List<object>();
                string connectionString = _context.Database.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    await conn.OpenAsync();

                    using SqlCommand cmd = new SqlCommand("GetEquityDataByTabName", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TabName", tableName);

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var record = new Dictionary<string, object>();

                            for (int i = 0; i < reader.FieldCount; i++) //fieldcount = no. of cols
                            {
                                record[reader.GetName(i)] = reader[i]; //getname = colname -> colame:value ......
                            }

                            results.Add(record);
                        }
                    }
                    conn.Close();
                }

                return results;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "Equity : getTableByData");
                return null;
            }

        }


        public async Task<EquityTable?> getSecById(int secId)
        {
            try
            {
                var res = await _context.EquityTables.FindAsync(secId);
                if (res != null)
                    return res;
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "Equity : getSecById");
                return null;
            }
        }


        //create
        public async Task<string> AddSecurity(EquityTable table)
        {
            try
            {
                await _context.EquityTables.AddAsync(table);
                int rowsAffected = await _context.SaveChangesAsync();
                if (rowsAffected > 0)
                {
                    return "added successfully";
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "Equity : AddSecurity");
                return null;
            }

        }


        //delete
        public async Task<string> DeleteSecurity(int secId)
        {
            try
            {
                var data = await _context.EquityTables.FindAsync(secId);

                //CAN ALSO DO BELOW , BUT SLOW 1.FIND 2.FIND TOP 1 -> X LOGICAL BCS PK=SecId
                //var data = await _context.EquityTables
                // .Where(x => x.SecurityId == secId)
                // .FirstOrDefaultAsync();

                if (data != null)
                {
                    _context.EquityTables.Remove(data); // Pass OBJ, not the ID
                    await _context.SaveChangesAsync();
                    return "Equity deleted successfully";
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "Equity : DeleteSec");
                return null;
            }

        }


        //update
        public async Task<string> UpdateSecurityById(EquityTable table)
        {
            try
            {
                var existingEquity = await _context.EquityTables.FindAsync(table.SecurityId);

                if (existingEquity == null)
                {
                    return null;
                }

                existingEquity.SecurityName = table.SecurityName;
                existingEquity.SecurityDescription = table.SecurityDescription;
                existingEquity.HasPosition = table.HasPosition;
                existingEquity.IsActive = table.IsActive;
                existingEquity.RoundLotSize = table.RoundLotSize;
                existingEquity.BloombergUniqueName = table.BloombergUniqueName;
                existingEquity.Cusip = table.Cusip;
                existingEquity.Isin = table.Isin;
                existingEquity.Sedol = table.Sedol;
                existingEquity.BloombergTicker = table.BloombergTicker;
                existingEquity.BloombergUniqueId = table.BloombergUniqueId;
                existingEquity.BloombergGlobalId = table.BloombergGlobalId;
                existingEquity.BloombergTickerAndExchange = table.BloombergTickerAndExchange;
                existingEquity.IsAdr = table.IsAdr;
                existingEquity.AdrUnderlyingTicker = table.AdrUnderlyingTicker;
                existingEquity.AdrUnderlyingCurrency = table.AdrUnderlyingCurrency;
                existingEquity.SharesPerAdr = table.SharesPerAdr;
                existingEquity.IpoDate = table.IpoDate;
                existingEquity.PriceCurrency = table.PriceCurrency;
                existingEquity.SettleDays = table.SettleDays;
                existingEquity.SharesOutstanding = table.SharesOutstanding;
                existingEquity.VotingRightsPerShare = table.VotingRightsPerShare;
                existingEquity.TwentyDayAverageVolume = table.TwentyDayAverageVolume;
                existingEquity.Beta = table.Beta;
                existingEquity.ShortInterest = table.ShortInterest;
                existingEquity.YtdReturn = table.YtdReturn;
                existingEquity.NinetyDayPriceVolatility = table.NinetyDayPriceVolatility;
                existingEquity.FormPfAssetClass = table.FormPfAssetClass;
                existingEquity.FormPfCountry = table.FormPfCountry;
                existingEquity.FormPfCreditRating = table.FormPfCreditRating;
                existingEquity.FormPfCurrency = table.FormPfCurrency;
                existingEquity.FormPfInstrument = table.FormPfInstrument;
                existingEquity.FormPfLiquidityProfile = table.FormPfLiquidityProfile;
                existingEquity.FormPfMaturity = table.FormPfMaturity;
                existingEquity.FormPfNaicsCode = table.FormPfNaicsCode;
                existingEquity.FormPfRegion = table.FormPfRegion;
                existingEquity.FormPfSector = table.FormPfSector;
                existingEquity.FormPfSubAssetClass = table.FormPfSubAssetClass;
                existingEquity.IssueCountry = table.IssueCountry;
                existingEquity.Exchange = table.Exchange;
                existingEquity.Issuer = table.Issuer;
                existingEquity.IssueCurrency = table.IssueCurrency;
                existingEquity.TradingCurrency = table.TradingCurrency;
                existingEquity.BloombergIndustrySubGroup = table.BloombergIndustrySubGroup;
                existingEquity.BloombergIndustryGroup = table.BloombergIndustryGroup;
                existingEquity.BloombergIndustrySector = table.BloombergIndustrySector;
                existingEquity.CountryOfIncorporation = table.CountryOfIncorporation;
                existingEquity.RiskCurrency = table.RiskCurrency;
                existingEquity.OpenPrice = table.OpenPrice;
                existingEquity.ClosePrice = table.ClosePrice;
                existingEquity.Volume = table.Volume;
                existingEquity.LastPrice = table.LastPrice;
                existingEquity.AskPrice = table.AskPrice;
                existingEquity.BidPrice = table.BidPrice;
                existingEquity.PeRatio = table.PeRatio;
                existingEquity.DeclaredDate = table.DeclaredDate;
                existingEquity.ExDate = table.ExDate;
                existingEquity.RecordDate = table.RecordDate;
                existingEquity.PayDate = table.PayDate;
                existingEquity.Amount = table.Amount;
                existingEquity.Frequency = table.Frequency;
                existingEquity.DividendType = table.DividendType;

                await _context.SaveChangesAsync();
                return "Updated";
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex + "Equity : Update");
                return null;
            }

        }


        public async Task<EquityTable> GetSecByName(string secName)
        {
            try
            {
                var data = await _context.EquityTables.Where(x => x.SecurityName.ToLower() == secName.ToLower()).FirstOrDefaultAsync();
                return data;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex + "Equity : getSecByName");
                return null;
            }

        }
    


        public async Task<List<object>> GetTableDataByColumnValue(string tabName)
        {
            try
            {
                var result = new List<object>();
                var connStr = _context.Database.GetConnectionString();
                using var conn = new SqlConnection(connStr);
                await conn.OpenAsync();

                using var cmd = new SqlCommand("GetEquityDataByTabName", conn);
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
    }
}
