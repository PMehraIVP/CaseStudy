using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Case_Study_2025.Models;

public partial class NewcsContext : DbContext
{
    public NewcsContext()
    {
    }

    public NewcsContext(DbContextOptions<NewcsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Battribute> Battributes { get; set; }

    public virtual DbSet<BondsAudit> BondsAudits { get; set; }

    public virtual DbSet<BondsTable> BondsTables { get; set; }

    public virtual DbSet<Btab> Btabs { get; set; }

    public virtual DbSet<Eattribute> Eattributes { get; set; }

    public virtual DbSet<EquityAudit> EquityAudits { get; set; }

    public virtual DbSet<EquityTable> EquityTables { get; set; }

    public virtual DbSet<Etab> Etabs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=192.168.0.13\\\\\\\\sqlexpress,49753; database=newcs; trustservercertificate=true; user id=sa; password=sa@12345678;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Battribute>(entity =>
        {
            entity.HasKey(e => e.AttId).HasName("PK__BAttribu__29E012E0D45F4A4E");

            entity.ToTable("BAttributes");

            entity.Property(e => e.AttName)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.HasOne(d => d.Tab).WithMany(p => p.Battributes)
                .HasForeignKey(d => d.TabId)
                .HasConstraintName("FK__BAttribut__TabId__628FA481");
        });

        modelBuilder.Entity<BondsAudit>(entity =>
        {
            entity.HasKey(e => e.AuditId).HasName("PK__BondsAud__A17F2398B54683C8");

            entity.ToTable("BondsAudit");

            entity.Property(e => e.NewBloombergUniqueId).HasColumnName("NewBloombergUniqueID");
            entity.Property(e => e.NewCusip).HasColumnName("NewCUSIP");
            entity.Property(e => e.NewFormPfassetClass).HasColumnName("NewFormPFAssetClass");
            entity.Property(e => e.NewFormPfcountry).HasColumnName("NewFormPFCountry");
            entity.Property(e => e.NewFormPfcreditRating).HasColumnName("NewFormPFCreditRating");
            entity.Property(e => e.NewFormPfcurrency).HasColumnName("NewFormPFCurrency");
            entity.Property(e => e.NewFormPfinstrument).HasColumnName("NewFormPFInstrument");
            entity.Property(e => e.NewFormPfliquidityProfile).HasColumnName("NewFormPFLiquidityProfile");
            entity.Property(e => e.NewFormPfmaturity).HasColumnName("NewFormPFMaturity");
            entity.Property(e => e.NewFormPfnaicscode).HasColumnName("NewFormPFNAICSCode");
            entity.Property(e => e.NewFormPfregion).HasColumnName("NewFormPFRegion");
            entity.Property(e => e.NewFormPfsector).HasColumnName("NewFormPFSector");
            entity.Property(e => e.NewFormPfsubAssetClass).HasColumnName("NewFormPFSubAssetClass");
            entity.Property(e => e.NewIsin).HasColumnName("NewISIN");
            entity.Property(e => e.NewSedol).HasColumnName("NewSEDOL");
            entity.Property(e => e.OldBloombergUniqueId).HasColumnName("OldBloombergUniqueID");
            entity.Property(e => e.OldCusip).HasColumnName("OldCUSIP");
            entity.Property(e => e.OldFormPfassetClass).HasColumnName("OldFormPFAssetClass");
            entity.Property(e => e.OldFormPfcountry).HasColumnName("OldFormPFCountry");
            entity.Property(e => e.OldFormPfcreditRating).HasColumnName("OldFormPFCreditRating");
            entity.Property(e => e.OldFormPfcurrency).HasColumnName("OldFormPFCurrency");
            entity.Property(e => e.OldFormPfinstrument).HasColumnName("OldFormPFInstrument");
            entity.Property(e => e.OldFormPfliquidityProfile).HasColumnName("OldFormPFLiquidityProfile");
            entity.Property(e => e.OldFormPfmaturity).HasColumnName("OldFormPFMaturity");
            entity.Property(e => e.OldFormPfnaicscode).HasColumnName("OldFormPFNAICSCode");
            entity.Property(e => e.OldFormPfregion).HasColumnName("OldFormPFRegion");
            entity.Property(e => e.OldFormPfsector).HasColumnName("OldFormPFSector");
            entity.Property(e => e.OldFormPfsubAssetClass).HasColumnName("OldFormPFSubAssetClass");
            entity.Property(e => e.OldIsin).HasColumnName("OldISIN");
            entity.Property(e => e.OldSedol).HasColumnName("OldSEDOL");
            entity.Property(e => e.TxnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TxnType).HasMaxLength(50);
        });

        modelBuilder.Entity<BondsTable>(entity =>
        {
            entity.HasKey(e => e.SecurityId).HasName("PK__BondsTab__9F8B0930D457CE63");

            entity.ToTable("BondsTable", tb =>
                {
                    tb.HasTrigger("BondsDelete");
                    tb.HasTrigger("BondsInsert");
                    tb.HasTrigger("BondsUpdate");
                });

            entity.Property(e => e.BloombergUniqueId).HasColumnName("BloombergUniqueID");
            entity.Property(e => e.Cusip).HasColumnName("CUSIP");
            entity.Property(e => e.FormPfassetClass).HasColumnName("FormPFAssetClass");
            entity.Property(e => e.FormPfcountry).HasColumnName("FormPFCountry");
            entity.Property(e => e.FormPfcreditRating).HasColumnName("FormPFCreditRating");
            entity.Property(e => e.FormPfcurrency).HasColumnName("FormPFCurrency");
            entity.Property(e => e.FormPfinstrument).HasColumnName("FormPFInstrument");
            entity.Property(e => e.FormPfliquidityProfile).HasColumnName("FormPFLiquidityProfile");
            entity.Property(e => e.FormPfmaturity).HasColumnName("FormPFMaturity");
            entity.Property(e => e.FormPfnaicscode).HasColumnName("FormPFNAICSCode");
            entity.Property(e => e.FormPfregion).HasColumnName("FormPFRegion");
            entity.Property(e => e.FormPfsector).HasColumnName("FormPFSector");
            entity.Property(e => e.FormPfsubAssetClass).HasColumnName("FormPFSubAssetClass");
            entity.Property(e => e.Isin).HasColumnName("ISIN");
            entity.Property(e => e.Sedol).HasColumnName("SEDOL");
        });

        modelBuilder.Entity<Btab>(entity =>
        {
            entity.HasKey(e => e.TabId).HasName("PK__BTabs__80E37C18E06E3345");

            entity.ToTable("BTabs");

            entity.Property(e => e.TabName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Eattribute>(entity =>
        {
            entity.HasKey(e => e.AttId).HasName("PK__EAttribu__29E012E0B22F0E61");

            entity.ToTable("EAttributes");

            entity.Property(e => e.AttName)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.HasOne(d => d.Tab).WithMany(p => p.Eattributes)
                .HasForeignKey(d => d.TabId)
                .HasConstraintName("FK__EAttribut__TabId__4222D4EF");
        });

        modelBuilder.Entity<EquityAudit>(entity =>
        {
            entity.HasKey(e => e.AuditId).HasName("PK__EquityAu__A17F239812B5A68C");

            entity.ToTable("EquityAudit");

            entity.Property(e => e.NewAdrUnderlyingCurrency).HasMaxLength(10);
            entity.Property(e => e.NewAdrUnderlyingTicker).HasMaxLength(50);
            entity.Property(e => e.NewCusip)
                .HasMaxLength(12)
                .HasColumnName("NewCUSIP");
            entity.Property(e => e.NewFormPfNaicsCode).HasMaxLength(50);
            entity.Property(e => e.NewIsin).HasColumnName("NewISIN");
            entity.Property(e => e.NewSedol)
                .HasMaxLength(7)
                .HasColumnName("NewSEDOL");
            entity.Property(e => e.OldAdrUnderlyingCurrency).HasMaxLength(10);
            entity.Property(e => e.OldAdrUnderlyingTicker).HasMaxLength(50);
            entity.Property(e => e.OldCusip)
                .HasMaxLength(12)
                .HasColumnName("OldCUSIP");
            entity.Property(e => e.OldFormPfNaicsCode).HasMaxLength(50);
            entity.Property(e => e.OldIsin).HasColumnName("OldISIN");
            entity.Property(e => e.OldSedol)
                .HasMaxLength(7)
                .HasColumnName("OldSEDOL");
            entity.Property(e => e.TxnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TxnType).HasMaxLength(50);
        });

        modelBuilder.Entity<EquityTable>(entity =>
        {
            entity.HasKey(e => e.SecurityId).HasName("PK__EquityTa__4DDC8246587EC9CB");

            entity.ToTable("EquityTable");

            entity.Property(e => e.SecurityId).HasColumnName("securityId");
            entity.Property(e => e.AdrUnderlyingCurrency)
                .HasMaxLength(10)
                .HasColumnName("adrUnderlyingCurrency");
            entity.Property(e => e.AdrUnderlyingTicker)
                .HasMaxLength(50)
                .HasColumnName("adrUnderlyingTicker");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.AskPrice).HasColumnName("askPrice");
            entity.Property(e => e.Beta).HasColumnName("beta");
            entity.Property(e => e.BidPrice).HasColumnName("bidPrice");
            entity.Property(e => e.BloombergGlobalId).HasColumnName("bloombergGlobalId");
            entity.Property(e => e.BloombergIndustryGroup).HasColumnName("bloombergIndustryGroup");
            entity.Property(e => e.BloombergIndustrySector).HasColumnName("bloombergIndustrySector");
            entity.Property(e => e.BloombergIndustrySubGroup).HasColumnName("bloombergIndustrySubGroup");
            entity.Property(e => e.BloombergTicker).HasColumnName("bloombergTicker");
            entity.Property(e => e.BloombergTickerAndExchange).HasColumnName("bloombergTickerAndExchange");
            entity.Property(e => e.BloombergUniqueId).HasColumnName("bloombergUniqueId");
            entity.Property(e => e.BloombergUniqueName).HasColumnName("bloombergUniqueName");
            entity.Property(e => e.ClosePrice).HasColumnName("closePrice");
            entity.Property(e => e.CountryOfIncorporation).HasColumnName("countryOfIncorporation");
            entity.Property(e => e.Cusip)
                .HasMaxLength(12)
                .HasColumnName("cusip");
            entity.Property(e => e.DeclaredDate).HasColumnName("declaredDate");
            entity.Property(e => e.DividendType).HasColumnName("dividendType");
            entity.Property(e => e.ExDate).HasColumnName("exDate");
            entity.Property(e => e.Exchange).HasColumnName("exchange");
            entity.Property(e => e.FormPfAssetClass).HasColumnName("formPfAssetClass");
            entity.Property(e => e.FormPfCountry).HasColumnName("formPfCountry");
            entity.Property(e => e.FormPfCreditRating).HasColumnName("formPfCreditRating");
            entity.Property(e => e.FormPfCurrency).HasColumnName("formPfCurrency");
            entity.Property(e => e.FormPfInstrument).HasColumnName("formPfInstrument");
            entity.Property(e => e.FormPfLiquidityProfile).HasColumnName("formPfLiquidityProfile");
            entity.Property(e => e.FormPfMaturity).HasColumnName("formPfMaturity");
            entity.Property(e => e.FormPfNaicsCode)
                .HasMaxLength(50)
                .HasColumnName("formPfNaicsCode");
            entity.Property(e => e.FormPfRegion).HasColumnName("formPfRegion");
            entity.Property(e => e.FormPfSector).HasColumnName("formPfSector");
            entity.Property(e => e.FormPfSubAssetClass).HasColumnName("formPfSubAssetClass");
            entity.Property(e => e.Frequency).HasColumnName("frequency");
            entity.Property(e => e.HasPosition).HasColumnName("hasPosition");
            entity.Property(e => e.IpoDate).HasColumnName("ipoDate");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsAdr).HasColumnName("isAdr");
            entity.Property(e => e.Isin)
                .HasMaxLength(12)
                .HasColumnName("isin");
            entity.Property(e => e.IssueCountry).HasColumnName("issueCountry");
            entity.Property(e => e.IssueCurrency).HasColumnName("issueCurrency");
            entity.Property(e => e.Issuer).HasColumnName("issuer");
            entity.Property(e => e.LastPrice).HasColumnName("lastPrice");
            entity.Property(e => e.NinetyDayPriceVolatility).HasColumnName("ninetyDayPriceVolatility");
            entity.Property(e => e.OpenPrice).HasColumnName("openPrice");
            entity.Property(e => e.PayDate).HasColumnName("payDate");
            entity.Property(e => e.PeRatio).HasColumnName("peRatio");
            entity.Property(e => e.PriceCurrency).HasColumnName("priceCurrency");
            entity.Property(e => e.RecordDate).HasColumnName("recordDate");
            entity.Property(e => e.RiskCurrency).HasColumnName("riskCurrency");
            entity.Property(e => e.RoundLotSize).HasColumnName("roundLotSize");
            entity.Property(e => e.SecurityDescription).HasColumnName("securityDescription");
            entity.Property(e => e.SecurityName).HasColumnName("securityName");
            entity.Property(e => e.Sedol)
                .HasMaxLength(7)
                .HasColumnName("sedol");
            entity.Property(e => e.SettleDays).HasColumnName("settleDays");
            entity.Property(e => e.SharesOutstanding).HasColumnName("sharesOutstanding");
            entity.Property(e => e.SharesPerAdr).HasColumnName("sharesPerAdr");
            entity.Property(e => e.ShortInterest).HasColumnName("shortInterest");
            entity.Property(e => e.TradingCurrency).HasColumnName("tradingCurrency");
            entity.Property(e => e.TwentyDayAverageVolume).HasColumnName("twentyDayAverageVolume");
            entity.Property(e => e.Volume).HasColumnName("volume");
            entity.Property(e => e.VotingRightsPerShare).HasColumnName("votingRightsPerShare");
            entity.Property(e => e.YtdReturn).HasColumnName("ytdReturn");
        });

        modelBuilder.Entity<Etab>(entity =>
        {
            entity.HasKey(e => e.TabId).HasName("PK__ETabs__80E37C182E5D40BF");

            entity.ToTable("ETabs");

            entity.Property(e => e.TabName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
