using System;
using System.Collections.Generic;

namespace Case_Study_2025.Models;

public partial class EquityTable
{
    public int SecurityId { get; set; }

    public string? SecurityName { get; set; }

    public string? SecurityDescription { get; set; }

    public string? HasPosition { get; set; }

    public string? IsActive { get; set; }

    public string? RoundLotSize { get; set; }

    public string? BloombergUniqueName { get; set; }

    public string? Cusip { get; set; }

    public string? Isin { get; set; }

    public string? Sedol { get; set; }

    public string? BloombergTicker { get; set; }

    public string? BloombergUniqueId { get; set; }

    public string? BloombergGlobalId { get; set; }

    public string? BloombergTickerAndExchange { get; set; }

    public string? IsAdr { get; set; }

    public string? AdrUnderlyingTicker { get; set; }

    public string? AdrUnderlyingCurrency { get; set; }

    public string? SharesPerAdr { get; set; }

    public string? IpoDate { get; set; }

    public string? PriceCurrency { get; set; }

    public string? SettleDays { get; set; }

    public string? SharesOutstanding { get; set; }

    public string? VotingRightsPerShare { get; set; }

    public string? TwentyDayAverageVolume { get; set; }

    public string? Beta { get; set; }

    public string? ShortInterest { get; set; }

    public string? YtdReturn { get; set; }

    public string? NinetyDayPriceVolatility { get; set; }

    public string? FormPfAssetClass { get; set; }

    public string? FormPfCountry { get; set; }

    public string? FormPfCreditRating { get; set; }

    public string? FormPfCurrency { get; set; }

    public string? FormPfInstrument { get; set; }

    public string? FormPfLiquidityProfile { get; set; }

    public string? FormPfMaturity { get; set; }

    public string? FormPfNaicsCode { get; set; }

    public string? FormPfRegion { get; set; }

    public string? FormPfSector { get; set; }

    public string? FormPfSubAssetClass { get; set; }

    public string? IssueCountry { get; set; }

    public string? Exchange { get; set; }

    public string? Issuer { get; set; }

    public string? IssueCurrency { get; set; }

    public string? TradingCurrency { get; set; }

    public string? BloombergIndustrySubGroup { get; set; }

    public string? BloombergIndustryGroup { get; set; }

    public string? BloombergIndustrySector { get; set; }

    public string? CountryOfIncorporation { get; set; }

    public string? RiskCurrency { get; set; }

    public string? OpenPrice { get; set; }

    public string? ClosePrice { get; set; }

    public string? Volume { get; set; }

    public string? LastPrice { get; set; }

    public string? AskPrice { get; set; }

    public string? BidPrice { get; set; }

    public string? PeRatio { get; set; }

    public string? DeclaredDate { get; set; }

    public string? ExDate { get; set; }

    public string? RecordDate { get; set; }

    public string? PayDate { get; set; }

    public string? Amount { get; set; }

    public string? Frequency { get; set; }

    public string? DividendType { get; set; }
}
