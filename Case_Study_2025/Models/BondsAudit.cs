using System;
using System.Collections.Generic;

namespace Case_Study_2025.Models;

public partial class BondsAudit
{
    public int AuditId { get; set; }

    public DateTime? TxnDate { get; set; }

    public string TxnType { get; set; } = null!;

    public int? SecurityId { get; set; }

    public string? NewSecurityDescription { get; set; }

    public string? OldSecurityDescription { get; set; }

    public string? NewSecurityName { get; set; }

    public string? OldSecurityName { get; set; }

    public string? NewAssetType { get; set; }

    public string? OldAssetType { get; set; }

    public string? NewInvestmentType { get; set; }

    public string? OldInvestmentType { get; set; }

    public string? NewTradingFactor { get; set; }

    public string? OldTradingFactor { get; set; }

    public string? NewPricingFactor { get; set; }

    public string? OldPricingFactor { get; set; }

    public string? NewIsin { get; set; }

    public string? OldIsin { get; set; }

    public string? NewBloombergTicker { get; set; }

    public string? OldBloombergTicker { get; set; }

    public string? NewBloombergUniqueId { get; set; }

    public string? OldBloombergUniqueId { get; set; }

    public string? NewCusip { get; set; }

    public string? OldCusip { get; set; }

    public string? NewSedol { get; set; }

    public string? OldSedol { get; set; }

    public string? NewFirstCouponDate { get; set; }

    public string? OldFirstCouponDate { get; set; }

    public string? NewCouponCap { get; set; }

    public string? OldCouponCap { get; set; }

    public string? NewCouponFloor { get; set; }

    public string? OldCouponFloor { get; set; }

    public string? NewCouponFrequency { get; set; }

    public string? OldCouponFrequency { get; set; }

    public string? NewCouponRate { get; set; }

    public string? OldCouponRate { get; set; }

    public string? NewCouponType { get; set; }

    public string? OldCouponType { get; set; }

    public string? NewFloatSpread { get; set; }

    public string? OldFloatSpread { get; set; }

    public string? NewIsCallable { get; set; }

    public string? OldIsCallable { get; set; }

    public string? NewIsFixToFloat { get; set; }

    public string? OldIsFixToFloat { get; set; }

    public string? NewIsPutable { get; set; }

    public string? OldIsPutable { get; set; }

    public string? NewIssueDate { get; set; }

    public string? OldIssueDate { get; set; }

    public string? NewLastResetDate { get; set; }

    public string? OldLastResetDate { get; set; }

    public string? NewMaturityDate { get; set; }

    public string? OldMaturityDate { get; set; }

    public string? NewMaximumCallNoticeDays { get; set; }

    public string? OldMaximumCallNoticeDays { get; set; }

    public string? NewMaximumPutNoticeDays { get; set; }

    public string? OldMaximumPutNoticeDays { get; set; }

    public string? NewPenultimateCouponDate { get; set; }

    public string? OldPenultimateCouponDate { get; set; }

    public string? NewResetFrequency { get; set; }

    public string? OldResetFrequency { get; set; }

    public string? NewHasPosition { get; set; }

    public string? OldHasPosition { get; set; }

    public string? NewDuration { get; set; }

    public string? OldDuration { get; set; }

    public string? NewVolatility30D { get; set; }

    public string? OldVolatility30D { get; set; }

    public string? NewVolatility90D { get; set; }

    public string? OldVolatility90D { get; set; }

    public string? NewConvexity { get; set; }

    public string? OldConvexity { get; set; }

    public string? NewAverageVolume30D { get; set; }

    public string? OldAverageVolume30D { get; set; }

    public string? NewFormPfassetClass { get; set; }

    public string? OldFormPfassetClass { get; set; }

    public string? NewFormPfcountry { get; set; }

    public string? OldFormPfcountry { get; set; }

    public string? NewFormPfcreditRating { get; set; }

    public string? OldFormPfcreditRating { get; set; }

    public string? NewFormPfcurrency { get; set; }

    public string? OldFormPfcurrency { get; set; }

    public string? NewFormPfinstrument { get; set; }

    public string? OldFormPfinstrument { get; set; }

    public string? NewFormPfliquidityProfile { get; set; }

    public string? OldFormPfliquidityProfile { get; set; }

    public string? NewFormPfmaturity { get; set; }

    public string? OldFormPfmaturity { get; set; }

    public string? NewFormPfnaicscode { get; set; }

    public string? OldFormPfnaicscode { get; set; }

    public string? NewFormPfregion { get; set; }

    public string? OldFormPfregion { get; set; }

    public string? NewFormPfsector { get; set; }

    public string? OldFormPfsector { get; set; }

    public string? NewFormPfsubAssetClass { get; set; }

    public string? OldFormPfsubAssetClass { get; set; }

    public string? NewBloombergIndustryGroup { get; set; }

    public string? OldBloombergIndustryGroup { get; set; }

    public string? NewBloombergIndustrySubGroup { get; set; }

    public string? OldBloombergIndustrySubGroup { get; set; }

    public string? NewBloombergSector { get; set; }

    public string? OldBloombergSector { get; set; }

    public string? NewIssueCountry { get; set; }

    public string? OldIssueCountry { get; set; }

    public string? NewIssueCurrency { get; set; }

    public string? OldIssueCurrency { get; set; }

    public string? NewIssuer { get; set; }

    public string? OldIssuer { get; set; }

    public string? NewRiskCurrency { get; set; }

    public string? OldRiskCurrency { get; set; }

    public string? NewPutDate { get; set; }

    public string? OldPutDate { get; set; }

    public string? NewPutPrice { get; set; }

    public string? OldPutPrice { get; set; }

    public string? NewAskPrice { get; set; }

    public string? OldAskPrice { get; set; }

    public string? NewHighPrice { get; set; }

    public string? OldHighPrice { get; set; }

    public string? NewLowPrice { get; set; }

    public string? OldLowPrice { get; set; }

    public string? NewOpenPrice { get; set; }

    public string? OldOpenPrice { get; set; }

    public string? NewVolume { get; set; }

    public string? OldVolume { get; set; }

    public string? NewBidPrice { get; set; }

    public string? OldBidPrice { get; set; }

    public string? NewLastPrice { get; set; }

    public string? OldLastPrice { get; set; }

    public string? NewCallDate { get; set; }

    public string? OldCallDate { get; set; }

    public string? NewCallPrice { get; set; }

    public string? OldCallPrice { get; set; }
}
