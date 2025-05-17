using System;
using System.Collections.Generic;

namespace Case_Study_2025.Models;

public partial class EquityAudit
{
    public int AuditId { get; set; }

    public DateTime? TxnDate { get; set; }

    public string TxnType { get; set; } = null!;

    public string? SecurityId { get; set; }

    public string? NewSecurityName { get; set; }

    public string? OldSecurityName { get; set; }

    public string? NewSecurityDescription { get; set; }

    public string? OldSecurityDescription { get; set; }

    public string? NewHasPosition { get; set; }

    public string? OldHasPosition { get; set; }

    public string? NewIsActive { get; set; }

    public string? OldIsActive { get; set; }

    public string? NewRoundLotSize { get; set; }

    public string? OldRoundLotSize { get; set; }

    public string? NewBloombergUniqueName { get; set; }

    public string? OldBloombergUniqueName { get; set; }

    public string? NewCusip { get; set; }

    public string? OldCusip { get; set; }

    public string? NewIsin { get; set; }

    public string? OldIsin { get; set; }

    public string? NewSedol { get; set; }

    public string? OldSedol { get; set; }

    public string? NewBloombergTicker { get; set; }

    public string? OldBloombergTicker { get; set; }

    public string? NewBloombergUniqueId { get; set; }

    public string? OldBloombergUniqueId { get; set; }

    public string? NewBloombergGlobalId { get; set; }

    public string? OldBloombergGlobalId { get; set; }

    public string? NewBloombergTickerAndExchange { get; set; }

    public string? OldBloombergTickerAndExchange { get; set; }

    public string? NewIsAdr { get; set; }

    public string? OldIsAdr { get; set; }

    public string? NewAdrUnderlyingTicker { get; set; }

    public string? OldAdrUnderlyingTicker { get; set; }

    public string? NewAdrUnderlyingCurrency { get; set; }

    public string? OldAdrUnderlyingCurrency { get; set; }

    public string? NewSharesPerAdr { get; set; }

    public string? OldSharesPerAdr { get; set; }

    public string? NewIpoDate { get; set; }

    public string? OldIpoDate { get; set; }

    public string? NewPriceCurrency { get; set; }

    public string? OldPriceCurrency { get; set; }

    public string? NewSettleDays { get; set; }

    public string? OldSettleDays { get; set; }

    public string? NewSharesOutstanding { get; set; }

    public string? OldSharesOutstanding { get; set; }

    public string? NewVotingRightsPerShare { get; set; }

    public string? OldVotingRightsPerShare { get; set; }

    public string? NewTwentyDayAverageVolume { get; set; }

    public string? OldTwentyDayAverageVolume { get; set; }

    public string? NewBeta { get; set; }

    public string? OldBeta { get; set; }

    public string? NewShortInterest { get; set; }

    public string? OldShortInterest { get; set; }

    public string? NewYtdReturn { get; set; }

    public string? OldYtdReturn { get; set; }

    public string? NewNinetyDayPriceVolatility { get; set; }

    public string? OldNinetyDayPriceVolatility { get; set; }

    public string? NewFormPfAssetClass { get; set; }

    public string? OldFormPfAssetClass { get; set; }

    public string? NewFormPfCountry { get; set; }

    public string? OldFormPfCountry { get; set; }

    public string? NewFormPfCreditRating { get; set; }

    public string? OldFormPfCreditRating { get; set; }

    public string? NewFormPfCurrency { get; set; }

    public string? OldFormPfCurrency { get; set; }

    public string? NewFormPfInstrument { get; set; }

    public string? OldFormPfInstrument { get; set; }

    public string? NewFormPfLiquidityProfile { get; set; }

    public string? OldFormPfLiquidityProfile { get; set; }

    public string? NewFormPfMaturity { get; set; }

    public string? OldFormPfMaturity { get; set; }

    public string? NewFormPfNaicsCode { get; set; }

    public string? OldFormPfNaicsCode { get; set; }

    public string? NewFormPfRegion { get; set; }

    public string? OldFormPfRegion { get; set; }

    public string? NewFormPfSector { get; set; }

    public string? OldFormPfSector { get; set; }

    public string? NewFormPfSubAssetClass { get; set; }

    public string? OldFormPfSubAssetClass { get; set; }

    public string? NewIssueCountry { get; set; }

    public string? OldIssueCountry { get; set; }

    public string? NewExchange { get; set; }

    public string? OldExchange { get; set; }

    public string? NewIssuer { get; set; }

    public string? OldIssuer { get; set; }

    public string? NewIssueCurrency { get; set; }

    public string? OldIssueCurrency { get; set; }

    public string? NewTradingCurrency { get; set; }

    public string? OldTradingCurrency { get; set; }

    public string? NewBloombergIndustrySubGroup { get; set; }

    public string? OldBloombergIndustrySubGroup { get; set; }

    public string? NewBloombergIndustryGroup { get; set; }

    public string? OldBloombergIndustryGroup { get; set; }

    public string? NewBloombergIndustrySector { get; set; }

    public string? OldBloombergIndustrySector { get; set; }

    public string? NewCountryOfIncorporation { get; set; }

    public string? OldCountryOfIncorporation { get; set; }

    public string? NewRiskCurrency { get; set; }

    public string? OldRiskCurrency { get; set; }

    public string? NewOpenPrice { get; set; }

    public string? OldOpenPrice { get; set; }

    public string? NewClosePrice { get; set; }

    public string? OldClosePrice { get; set; }

    public string? NewVolume { get; set; }

    public string? OldVolume { get; set; }

    public string? NewLastPrice { get; set; }

    public string? OldLastPrice { get; set; }

    public string? NewAskPrice { get; set; }

    public string? OldAskPrice { get; set; }

    public string? NewBidPrice { get; set; }

    public string? OldBidPrice { get; set; }

    public string? NewPeRatio { get; set; }

    public string? OldPeRatio { get; set; }

    public string? NewDeclaredDate { get; set; }

    public string? OldDeclaredDate { get; set; }

    public string? NewExDate { get; set; }

    public string? OldExDate { get; set; }

    public string? NewRecordDate { get; set; }

    public string? OldRecordDate { get; set; }

    public string? NewPayDate { get; set; }

    public string? OldPayDate { get; set; }

    public string? NewAmount { get; set; }

    public string? OldAmount { get; set; }

    public string? NewFrequency { get; set; }

    public string? OldFrequency { get; set; }

    public string? NewDividendType { get; set; }

    public string? OldDividendType { get; set; }
}
