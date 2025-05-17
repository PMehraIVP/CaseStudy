using System;
using System.Collections.Generic;

namespace Case_Study_2025.Models;

public partial class BondsTable
{
    public int SecurityId { get; set; }

    public string? SecurityDescription { get; set; }

    public string? SecurityName { get; set; }

    public string? AssetType { get; set; }

    public string? InvestmentType { get; set; }

    public string? TradingFactor { get; set; }

    public string? PricingFactor { get; set; }

    public string? Isin { get; set; }

    public string? BloombergTicker { get; set; }

    public string? BloombergUniqueId { get; set; }

    public string? Cusip { get; set; }

    public string? Sedol { get; set; }

    public string? FirstCouponDate { get; set; }

    public string? CouponCap { get; set; }

    public string? CouponFloor { get; set; }

    public string? CouponFrequency { get; set; }

    public string? CouponRate { get; set; }

    public string? CouponType { get; set; }

    public string? FloatSpread { get; set; }

    public string? IsCallable { get; set; }

    public string? IsFixToFloat { get; set; }

    public string? IsPutable { get; set; }

    public string? IssueDate { get; set; }

    public string? LastResetDate { get; set; }

    public string? MaturityDate { get; set; }

    public string? MaximumCallNoticeDays { get; set; }

    public string? MaximumPutNoticeDays { get; set; }

    public string? PenultimateCouponDate { get; set; }

    public string? ResetFrequency { get; set; }

    public string? HasPosition { get; set; }

    public string? Duration { get; set; }

    public string? Volatility30D { get; set; }

    public string? Volatility90D { get; set; }

    public string? Convexity { get; set; }

    public string? AverageVolume30D { get; set; }

    public string? FormPfassetClass { get; set; }

    public string? FormPfcountry { get; set; }

    public string? FormPfcreditRating { get; set; }

    public string? FormPfcurrency { get; set; }

    public string? FormPfinstrument { get; set; }

    public string? FormPfliquidityProfile { get; set; }

    public string? FormPfmaturity { get; set; }

    public string? FormPfnaicscode { get; set; }

    public string? FormPfregion { get; set; }

    public string? FormPfsector { get; set; }

    public string? FormPfsubAssetClass { get; set; }

    public string? BloombergIndustryGroup { get; set; }

    public string? BloombergIndustrySubGroup { get; set; }

    public string? BloombergSector { get; set; }

    public string? IssueCountry { get; set; }

    public string? IssueCurrency { get; set; }

    public string? Issuer { get; set; }

    public string? RiskCurrency { get; set; }

    public string? PutDate { get; set; }

    public string? PutPrice { get; set; }

    public string? AskPrice { get; set; }

    public string? HighPrice { get; set; }

    public string? LowPrice { get; set; }

    public string? OpenPrice { get; set; }

    public string? Volume { get; set; }

    public string? BidPrice { get; set; }

    public string? LastPrice { get; set; }

    public string? CallDate { get; set; }

    public string? CallPrice { get; set; }
}
