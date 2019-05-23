using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebBiopelagos.Web.Models
{
    public partial class BioDaSysContext : DbContext
    {
        public BioDaSysContext()
        {
        }

        public BioDaSysContext(DbContextOptions<BioDaSysContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AnalysisAging> AnalysisAging { get; set; }
        public virtual DbSet<AnalysisAgingAnnualZone> AnalysisAgingAnnualZone { get; set; }
        public virtual DbSet<AnalysisBase> AnalysisBase { get; set; }
        public virtual DbSet<AnalysisContaminant> AnalysisContaminant { get; set; }
        public virtual DbSet<AnalysisFatmeter> AnalysisFatmeter { get; set; }
        public virtual DbSet<AnalysisFatmeterData> AnalysisFatmeterData { get; set; }
        public virtual DbSet<AnalysisGenetic> AnalysisGenetic { get; set; }
        public virtual DbSet<AnalysisHistology> AnalysisHistology { get; set; }
        public virtual DbSet<AnalysisHistologyData> AnalysisHistologyData { get; set; }
        public virtual DbSet<AnalysisIsotope> AnalysisIsotope { get; set; }
        public virtual DbSet<AnalysisLipid> AnalysisLipid { get; set; }
        public virtual DbSet<AnalysisLipidData> AnalysisLipidData { get; set; }
        public virtual DbSet<AnalysisQuantity> AnalysisQuantity { get; set; }
        public virtual DbSet<AnalysisSampleType> AnalysisSampleType { get; set; }
        public virtual DbSet<AnalysisSizeStructure> AnalysisSizeStructure { get; set; }
        public virtual DbSet<AnalysisStomachContent> AnalysisStomachContent { get; set; }
        public virtual DbSet<AnalysisStomachHardMaterial> AnalysisStomachHardMaterial { get; set; }
        public virtual DbSet<AnalysisStomachParasite> AnalysisStomachParasite { get; set; }
        public virtual DbSet<AnalysisStomachPreyIndividual> AnalysisStomachPreyIndividual { get; set; }
        public virtual DbSet<AnalysisStomachPreyItem> AnalysisStomachPreyItem { get; set; }
        public virtual DbSet<AnalysisType> AnalysisType { get; set; }
        public virtual DbSet<AreaReliability> AreaReliability { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<BetRegion> BetRegion { get; set; }
        public virtual DbSet<BirdDevelopment> BirdDevelopment { get; set; }
        public virtual DbSet<BirdLengthCode> BirdLengthCode { get; set; }
        public virtual DbSet<BirdReproduction> BirdReproduction { get; set; }
        public virtual DbSet<BirdStatus> BirdStatus { get; set; }
        public virtual DbSet<CabinetOo> CabinetOo { get; set; }
        public virtual DbSet<ChildSpecimenSampleLink> ChildSpecimenSampleLink { get; set; }
        public virtual DbSet<CodendType> CodendType { get; set; }
        public virtual DbSet<ConditionSampleType> ConditionSampleType { get; set; }
        public virtual DbSet<Contaminant> Contaminant { get; set; }
        public virtual DbSet<ContaminantWeight> ContaminantWeight { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<DayNight> DayNight { get; set; }
        public virtual DbSet<DbSamplingFile> DbSamplingFile { get; set; }
        public virtual DbSet<DbTask> DbTask { get; set; }
        public virtual DbSet<DbTransfer> DbTransfer { get; set; }
        public virtual DbSet<Debriefing> Debriefing { get; set; }
        public virtual DbSet<EezFinalV10IwAll> EezFinalV10IwAll { get; set; }
        public virtual DbSet<EezIw> EezIw { get; set; }
        public virtual DbSet<EtopoGrid05> EtopoGrid05 { get; set; }
        public virtual DbSet<FatmeterMeasure> FatmeterMeasure { get; set; }
        public virtual DbSet<Fish> Fish { get; set; }
        public virtual DbSet<FishForageIndividualLink> FishForageIndividualLink { get; set; }
        public virtual DbSet<FishForageItemLink> FishForageItemLink { get; set; }
        public virtual DbSet<FishPreyIndividualLink> FishPreyIndividualLink { get; set; }
        public virtual DbSet<FishPreyItemLink> FishPreyItemLink { get; set; }
        public virtual DbSet<FishType> FishType { get; set; }
        public virtual DbSet<ForageIndividual> ForageIndividual { get; set; }
        public virtual DbSet<ForageItem> ForageItem { get; set; }
        public virtual DbSet<ForageState> ForageState { get; set; }
        public virtual DbSet<FreezerLocation> FreezerLocation { get; set; }
        public virtual DbSet<FreightOrphanLink> FreightOrphanLink { get; set; }
        public virtual DbSet<FreightSampleLink> FreightSampleLink { get; set; }
        public virtual DbSet<FreightSamplingLink> FreightSamplingLink { get; set; }
        public virtual DbSet<FreightType> FreightType { get; set; }
        public virtual DbSet<FullnessCoeff> FullnessCoeff { get; set; }
        public virtual DbSet<Gear> Gear { get; set; }
        public virtual DbSet<Haplotype> Haplotype { get; set; }
        public virtual DbSet<HardMaterial> HardMaterial { get; set; }
        public virtual DbSet<HardMaterialOtolith> HardMaterialOtolith { get; set; }
        public virtual DbSet<HistologyCell> HistologyCell { get; set; }
        public virtual DbSet<HistoryFish> HistoryFish { get; set; }
        public virtual DbSet<HistorySampleBase> HistorySampleBase { get; set; }
        public virtual DbSet<InventoryLocationOld> InventoryLocationOld { get; set; }
        public virtual DbSet<KitItem> KitItem { get; set; }
        public virtual DbSet<KitSamplingLink> KitSamplingLink { get; set; }
        public virtual DbSet<LaboratoryOld> LaboratoryOld { get; set; }
        public virtual DbSet<LengthCode> LengthCode { get; set; }
        public virtual DbSet<LipidFatty> LipidFatty { get; set; }
        public virtual DbSet<LipidHomogenization> LipidHomogenization { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Longhurst> Longhurst { get; set; }
        public virtual DbSet<MagoStage> MagoStage { get; set; }
        public virtual DbSet<ManagementEntity> ManagementEntity { get; set; }
        public virtual DbSet<MicroscopicStage> MicroscopicStage { get; set; }
        public virtual DbSet<Movement> Movement { get; set; }
        public virtual DbSet<MovementKit> MovementKit { get; set; }
        public virtual DbSet<Objectives> Objectives { get; set; }
        public virtual DbSet<ObjectivesBs> ObjectivesBs { get; set; }
        public virtual DbSet<ObjectivesSpecimen> ObjectivesSpecimen { get; set; }
        public virtual DbSet<OldTrainingCourse> OldTrainingCourse { get; set; }
        public virtual DbSet<OtolithMarginType> OtolithMarginType { get; set; }
        public virtual DbSet<OtolithSectionType> OtolithSectionType { get; set; }
        public virtual DbSet<Parasite> Parasite { get; set; }
        public virtual DbSet<ParasiteMode> ParasiteMode { get; set; }
        public virtual DbSet<Port> Port { get; set; }
        public virtual DbSet<PositionSampleType> PositionSampleType { get; set; }
        public virtual DbSet<PreyDevelopment> PreyDevelopment { get; set; }
        public virtual DbSet<PreyDigestion> PreyDigestion { get; set; }
        public virtual DbSet<Publication> Publication { get; set; }
        public virtual DbSet<PublicationAnalysisLink> PublicationAnalysisLink { get; set; }
        public virtual DbSet<PurchaseItem> PurchaseItem { get; set; }
        public virtual DbSet<Quality> Quality { get; set; }
        public virtual DbSet<QueryList> QueryList { get; set; }
        public virtual DbSet<RecapturedBird> RecapturedBird { get; set; }
        public virtual DbSet<RefItem> RefItem { get; set; }
        public virtual DbSet<RefKitType> RefKitType { get; set; }
        public virtual DbSet<RefStockType> RefStockType { get; set; }
        public virtual DbSet<SampleBase> SampleBase { get; set; }
        public virtual DbSet<SampleCommunity> SampleCommunity { get; set; }
        public virtual DbSet<SampleGonad> SampleGonad { get; set; }
        public virtual DbSet<SampleOther> SampleOther { get; set; }
        public virtual DbSet<SampleOtolith> SampleOtolith { get; set; }
        public virtual DbSet<SamplePendingAnalysis> SamplePendingAnalysis { get; set; }
        public virtual DbSet<SamplerTrip> SamplerTrip { get; set; }
        public virtual DbSet<SampleUnknown> SampleUnknown { get; set; }
        public virtual DbSet<Sampling> Sampling { get; set; }
        public virtual DbSet<SamplingFinance> SamplingFinance { get; set; }
        public virtual DbSet<SamplingFreight> SamplingFreight { get; set; }
        public virtual DbSet<SamplingKit> SamplingKit { get; set; }
        public virtual DbSet<SchoolAssociation> SchoolAssociation { get; set; }
        public virtual DbSet<SetBase> SetBase { get; set; }
        public virtual DbSet<SetBiological> SetBiological { get; set; }
        public virtual DbSet<SetBiologicalGear> SetBiologicalGear { get; set; }
        public virtual DbSet<SetBiologicalGearLink> SetBiologicalGearLink { get; set; }
        public virtual DbSet<SetBiologicalStep> SetBiologicalStep { get; set; }
        public virtual DbSet<SetBiologicalZooplankton> SetBiologicalZooplankton { get; set; }
        public virtual DbSet<SetDws> SetDws { get; set; }
        public virtual DbSet<SetPsa> SetPsa { get; set; }
        public virtual DbSet<Sex> Sex { get; set; }
        public virtual DbSet<Shipper> Shipper { get; set; }
        public virtual DbSet<Side> Side { get; set; }
        public virtual DbSet<SourceVolumeFiltered> SourceVolumeFiltered { get; set; }
        public virtual DbSet<Species> Species { get; set; }
        public virtual DbSet<SpeciesCategory> SpeciesCategory { get; set; }
        public virtual DbSet<SpeciesGroup> SpeciesGroup { get; set; }
        public virtual DbSet<SpeciesLenwt> SpeciesLenwt { get; set; }
        public virtual DbSet<SpeciesNameCategory> SpeciesNameCategory { get; set; }
        public virtual DbSet<SpecimenBird> SpecimenBird { get; set; }
        public virtual DbSet<SpecimenBirdLength> SpecimenBirdLength { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<StomachStatus> StomachStatus { get; set; }
        public virtual DbSet<StorageQuality> StorageQuality { get; set; }
        public virtual DbSet<StorageQualityCondition> StorageQualityCondition { get; set; }
        public virtual DbSet<Swimbladder> Swimbladder { get; set; }
        public virtual DbSet<TargetGroup> TargetGroup { get; set; }
        public virtual DbSet<TissueCondition> TissueCondition { get; set; }
        public virtual DbSet<TissuePosition> TissuePosition { get; set; }
        public virtual DbSet<TissueSide> TissueSide { get; set; }
        public virtual DbSet<TissueStateOld> TissueStateOld { get; set; }
        public virtual DbSet<TissueType> TissueType { get; set; }
        public virtual DbSet<TowMethod> TowMethod { get; set; }
        public virtual DbSet<Training> Training { get; set; }
        public virtual DbSet<TrainingModule> TrainingModule { get; set; }
        public virtual DbSet<TrainingStaff> TrainingStaff { get; set; }
        public virtual DbSet<TrainingStaffCourse> TrainingStaffCourse { get; set; }
        public virtual DbSet<TrainingType> TrainingType { get; set; }
        public virtual DbSet<Trip> Trip { get; set; }
        public virtual DbSet<TripTubsLink> TripTubsLink { get; set; }
        public virtual DbSet<TripType> TripType { get; set; }
        public virtual DbSet<VerticalClass> VerticalClass { get; set; }
        public virtual DbSet<VolumeSamplingFreight> VolumeSamplingFreight { get; set; }
        public virtual DbSet<WeightCode> WeightCode { get; set; }
        public virtual DbSet<YearCalendar> YearCalendar { get; set; }
        public virtual DbSet<ZooplanktonDepthSpecimen> ZooplanktonDepthSpecimen { get; set; }

        // Unable to generate entity type for table 'dbo.predator_all'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AspNetRoleClaims'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AspNetRoles'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AspNetUserLogins'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AspNetUserRoles'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AspNetUserTokens'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SPC142130;Database=BioDaSys;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnalysisAging>(entity =>
            {
                entity.HasKey(e => e.AnalysisBaseId);

                entity.ToTable("analysis_aging", "BIO");

                entity.HasIndex(e => e.OtolithMarginTypeId)
                    .HasName("IX_analysis_aging_otolith_margin");

                entity.HasIndex(e => e.OtolithSectionTypeId)
                    .HasName("IX_analysis_aging_otolith_section");

                entity.HasIndex(e => e.ReadibilityQualityId)
                    .HasName("IX_analysis_aging_readability");

                entity.HasIndex(e => e.SideId)
                    .HasName("IX_analysis_aging_side");

                entity.Property(e => e.AnalysisBaseId)
                    .HasColumnName("analysis_base_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnalysisTypeId)
                    .IsRequired()
                    .HasColumnName("analysis_type_id")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'AG')");

                entity.Property(e => e.AnnualFinalZoneCnt).HasColumnName("annual_final_zone_cnt");

                entity.Property(e => e.AnnualIncrements)
                    .HasColumnName("annual_increments")
                    .HasColumnType("decimal(6, 4)");

                entity.Property(e => e.DailyIncrements).HasColumnName("daily_increments");

                entity.Property(e => e.DepthMm)
                    .HasColumnName("depth_mm")
                    .HasColumnType("decimal(10, 5)");

                entity.Property(e => e.LengthMm)
                    .HasColumnName("length_mm")
                    .HasMaxLength(50);

                entity.Property(e => e.Meas365Mm)
                    .HasColumnName("meas_365_mm")
                    .HasColumnType("decimal(6, 4)");

                entity.Property(e => e.Meas730Mm)
                    .HasColumnName("meas_730_mm")
                    .HasColumnType("decimal(6, 4)");

                entity.Property(e => e.MeasEdgeMm)
                    .HasColumnName("meas_edge_mm")
                    .HasColumnType("decimal(6, 4)");

                entity.Property(e => e.OtolithMarginTypeId)
                    .HasColumnName("otolith_margin_type_id")
                    .HasMaxLength(1);

                entity.Property(e => e.OtolithSectionTypeId)
                    .HasColumnName("otolith_section_type_id")
                    .HasMaxLength(2);

                entity.Property(e => e.Picture1)
                    .HasColumnName("picture1")
                    .HasMaxLength(255);

                entity.Property(e => e.Picture2)
                    .HasColumnName("picture2")
                    .HasMaxLength(255);

                entity.Property(e => e.Picture3)
                    .HasColumnName("picture3")
                    .HasMaxLength(255);

                entity.Property(e => e.Picture4)
                    .HasColumnName("picture4")
                    .HasMaxLength(255);

                entity.Property(e => e.RadiusMm)
                    .HasColumnName("radius_mm")
                    .HasMaxLength(50);

                entity.Property(e => e.ReadibilityQualityId)
                    .HasColumnName("readibility_quality_id")
                    .HasMaxLength(1);

                entity.Property(e => e.SectionThicknessMm).HasColumnName("section_thickness_mm");

                entity.Property(e => e.SideId)
                    .HasColumnName("side_id")
                    .HasMaxLength(1);

                entity.Property(e => e.WeightGr)
                    .HasColumnName("weight_gr")
                    .HasColumnType("decimal(10, 5)");

                entity.Property(e => e.WeightStorageQualityId)
                    .HasColumnName("weight_storage_quality_id")
                    .HasMaxLength(1);

                entity.Property(e => e.WidthMm)
                    .HasColumnName("width_mm")
                    .HasColumnType("decimal(10, 5)");

                entity.HasOne(d => d.OtolithMarginType)
                    .WithMany(p => p.AnalysisAging)
                    .HasForeignKey(d => d.OtolithMarginTypeId)
                    .HasConstraintName("FK_analysis_aging_otolith_margin_type");

                entity.HasOne(d => d.OtolithSectionType)
                    .WithMany(p => p.AnalysisAging)
                    .HasForeignKey(d => d.OtolithSectionTypeId)
                    .HasConstraintName("FK_analysis_aging_otolith_section_type");

                entity.HasOne(d => d.ReadibilityQuality)
                    .WithMany(p => p.AnalysisAging)
                    .HasForeignKey(d => d.ReadibilityQualityId)
                    .HasConstraintName("FK_analysis_aging_quality");

                entity.HasOne(d => d.Side)
                    .WithMany(p => p.AnalysisAging)
                    .HasForeignKey(d => d.SideId)
                    .HasConstraintName("FK_analysis_aging_side");

                entity.HasOne(d => d.Analysis)
                    .WithMany(p => p.AnalysisAging)
                    .HasPrincipalKey(p => new { p.AnalysisBaseId, p.AnalysisTypeId })
                    .HasForeignKey(d => new { d.AnalysisBaseId, d.AnalysisTypeId })
                    .HasConstraintName("FK_analysis_aging_analysis_base");
            });

            modelBuilder.Entity<AnalysisAgingAnnualZone>(entity =>
            {
                entity.ToTable("analysis_aging_annual_zone", "BIO");

                entity.HasIndex(e => new { e.AnalysisBaseId, e.AnnualZoneNb })
                    .HasName("UX_analysis_aging_annual_zone")
                    .IsUnique();

                entity.Property(e => e.AnalysisAgingAnnualZoneId).HasColumnName("analysis_aging_annual_zone_id");

                entity.Property(e => e.AnalysisBaseId).HasColumnName("analysis_base_id");

                entity.Property(e => e.AnnualZoneMm)
                    .HasColumnName("annual_zone_mm")
                    .HasColumnType("decimal(6, 4)");

                entity.Property(e => e.AnnualZoneNb).HasColumnName("annual_zone_nb");

                entity.HasOne(d => d.AnalysisBase)
                    .WithMany(p => p.AnalysisAgingAnnualZone)
                    .HasForeignKey(d => d.AnalysisBaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_analysis_aging_annual_zone_analysis_aging");
            });

            modelBuilder.Entity<AnalysisBase>(entity =>
            {
                entity.ToTable("analysis_base", "BIO");

                entity.HasIndex(e => e.AnalyserStaffId)
                    .HasName("IX_analysis_base_staff_1");

                entity.HasIndex(e => e.AnalyserStaffId2)
                    .HasName("IX_analysis_base_staff_2");

                entity.HasIndex(e => e.AnalyserStaffId3)
                    .HasName("IX_analysis_base_staff_3");

                entity.HasIndex(e => e.AnalysisTypeId)
                    .HasName("IX_analysis_base_analysis_type");

                entity.HasIndex(e => e.LaboratoryLocationId)
                    .HasName("IX_analysis_base_laboratory");

                entity.HasIndex(e => e.SampleBaseId)
                    .HasName("IX_analysis_base_sample_base");

                entity.HasIndex(e => new { e.AnalysisBaseId, e.AnalysisTypeId })
                    .HasName("UX_analysis_base")
                    .IsUnique();

                entity.Property(e => e.AnalysisBaseId).HasColumnName("analysis_base_id");

                entity.Property(e => e.AnalyserStaffId).HasColumnName("analyser_staff_id");

                entity.Property(e => e.AnalyserStaffId2).HasColumnName("analyser_staff_id_2");

                entity.Property(e => e.AnalyserStaffId3).HasColumnName("analyser_staff_id_3");

                entity.Property(e => e.AnalysisDate)
                    .HasColumnName("analysis_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AnalysisTypeId)
                    .IsRequired()
                    .HasColumnName("analysis_type_id")
                    .HasMaxLength(2);

                entity.Property(e => e.AnalyzedByOld)
                    .HasColumnName("analyzed_by_OLD")
                    .HasMaxLength(100);

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([date],getdate(),(0)))");

                entity.Property(e => e.LaboratoryIdOld).HasColumnName("laboratory_id_OLD");

                entity.Property(e => e.LaboratoryLocationId).HasColumnName("laboratory_location_id");

                entity.Property(e => e.LocationDetails)
                    .HasColumnName("location_details")
                    .HasMaxLength(250);

                entity.Property(e => e.SampleBaseId).HasColumnName("sample_base_id");

                entity.Property(e => e.TissueTypeId)
                    .IsRequired()
                    .HasColumnName("tissue_type_id")
                    .HasMaxLength(2);

                entity.Property(e => e.TmpId).HasColumnName("TMP_id");

                entity.HasOne(d => d.AnalyserStaff)
                    .WithMany(p => p.AnalysisBaseAnalyserStaff)
                    .HasForeignKey(d => d.AnalyserStaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_analysis_base_staff_1");

                entity.HasOne(d => d.AnalyserStaffId2Navigation)
                    .WithMany(p => p.AnalysisBaseAnalyserStaffId2Navigation)
                    .HasForeignKey(d => d.AnalyserStaffId2)
                    .HasConstraintName("FK_analysis_base_staff_2");

                entity.HasOne(d => d.AnalyserStaffId3Navigation)
                    .WithMany(p => p.AnalysisBaseAnalyserStaffId3Navigation)
                    .HasForeignKey(d => d.AnalyserStaffId3)
                    .HasConstraintName("FK_analysis_base_staff_3");

                entity.HasOne(d => d.AnalysisType)
                    .WithMany(p => p.AnalysisBase)
                    .HasForeignKey(d => d.AnalysisTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_analysis_base_analysis_type");

                entity.HasOne(d => d.LaboratoryLocation)
                    .WithMany(p => p.AnalysisBase)
                    .HasForeignKey(d => d.LaboratoryLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_analysis_base_laboratory");

                entity.HasOne(d => d.AnalysisSampleType)
                    .WithMany(p => p.AnalysisBase)
                    .HasPrincipalKey(p => new { p.AnalysisTypeId, p.TissueTypeId })
                    .HasForeignKey(d => new { d.AnalysisTypeId, d.TissueTypeId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QRY_analysis_base_analysis_sample_type");

                entity.HasOne(d => d.SampleBase)
                    .WithMany(p => p.AnalysisBase)
                    .HasPrincipalKey(p => new { p.SampleBaseId, p.TissueTypeId })
                    .HasForeignKey(d => new { d.SampleBaseId, d.TissueTypeId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_analysis_base_sample_base");
            });

            modelBuilder.Entity<AnalysisContaminant>(entity =>
            {
                entity.HasKey(e => e.AnalysisBaseId);

                entity.ToTable("analysis_contaminant", "BIO");

                entity.HasIndex(e => e.ContaminantId)
                    .HasName("IX_analysis_contaminant_contaminant");

                entity.Property(e => e.AnalysisBaseId)
                    .HasColumnName("analysis_base_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnalysisTypeId)
                    .IsRequired()
                    .HasColumnName("analysis_type_id")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'CO')");

                entity.Property(e => e.ComparedContaminantId)
                    .HasColumnName("compared_contaminant_id")
                    .HasMaxLength(4);

                entity.Property(e => e.ComparedPercent).HasColumnName("compared_percent");

                entity.Property(e => e.ContaminantId)
                    .IsRequired()
                    .HasColumnName("contaminant_id")
                    .HasMaxLength(4);

                entity.Property(e => e.ContaminantWeightId)
                    .HasColumnName("contaminant_weight_id")
                    .HasMaxLength(2);

                entity.Property(e => e.DwUnit)
                    .HasColumnName("DW_unit")
                    .HasMaxLength(10);

                entity.Property(e => e.DwValue)
                    .HasColumnName("DW_value")
                    .HasColumnType("decimal(20, 15)");

                entity.Property(e => e.Instrumentation)
                    .HasColumnName("instrumentation")
                    .HasMaxLength(255);

                entity.Property(e => e.LabIdNo)
                    .HasColumnName("lab_id_no")
                    .HasMaxLength(50);

                entity.Property(e => e.Project)
                    .IsRequired()
                    .HasColumnName("project")
                    .HasMaxLength(255);

                entity.Property(e => e.Rsd)
                    .HasColumnName("RSD")
                    .HasColumnType("decimal(20, 15)");

                entity.Property(e => e.SampleWeightGr)
                    .HasColumnName("sample_weight_gr")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.WwUnit)
                    .HasColumnName("WW_unit")
                    .HasMaxLength(10);

                entity.Property(e => e.WwValue)
                    .HasColumnName("WW_value")
                    .HasColumnType("decimal(20, 15)");

                entity.HasOne(d => d.ComparedContaminant)
                    .WithMany(p => p.AnalysisContaminantComparedContaminant)
                    .HasForeignKey(d => d.ComparedContaminantId)
                    .HasConstraintName("FK_analysis_contaminant_contaminant1");

                entity.HasOne(d => d.Contaminant)
                    .WithMany(p => p.AnalysisContaminantContaminant)
                    .HasForeignKey(d => d.ContaminantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_analysis_contaminant_contaminant");

                entity.HasOne(d => d.ContaminantWeight)
                    .WithMany(p => p.AnalysisContaminant)
                    .HasForeignKey(d => d.ContaminantWeightId)
                    .HasConstraintName("FK_analysis_contaminant_contaminant_weight");

                entity.HasOne(d => d.Analysis)
                    .WithMany(p => p.AnalysisContaminant)
                    .HasPrincipalKey(p => new { p.AnalysisBaseId, p.AnalysisTypeId })
                    .HasForeignKey(d => new { d.AnalysisBaseId, d.AnalysisTypeId })
                    .HasConstraintName("FK_analysis_contaminant_analysis_base");
            });

            modelBuilder.Entity<AnalysisFatmeter>(entity =>
            {
                entity.HasKey(e => e.AnalysisBaseFatmeterId);

                entity.ToTable("analysis_fatmeter", "BIO");

                entity.Property(e => e.AnalysisBaseFatmeterId)
                    .HasColumnName("analysis_base_fatmeter_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnalysisTypeId)
                    .IsRequired()
                    .HasColumnName("analysis_type_id")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'FT')");

                entity.Property(e => e.FatmeterNo)
                    .IsRequired()
                    .HasColumnName("fatmeter_no")
                    .HasMaxLength(50);

                entity.Property(e => e.IsCorrectOldFat).HasColumnName("is_correct_old_fat");

                entity.Property(e => e.IsCorrectWrongProc).HasColumnName("is_correct_wrong_proc");

                entity.Property(e => e.Produce)
                    .IsRequired()
                    .HasColumnName("produce")
                    .HasMaxLength(52);

                entity.Property(e => e.RecordsNb).HasColumnName("records_nb");

                entity.Property(e => e.SampleCalib)
                    .HasColumnName("sample_calib")
                    .HasMaxLength(30);

                entity.Property(e => e.TransferDbDate)
                    .HasColumnName("transfer_DB_date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Analysis)
                    .WithMany(p => p.AnalysisFatmeter)
                    .HasPrincipalKey(p => new { p.AnalysisBaseId, p.AnalysisTypeId })
                    .HasForeignKey(d => new { d.AnalysisBaseFatmeterId, d.AnalysisTypeId })
                    .HasConstraintName("FK_analysis_fatmeter_analysis_base");
            });

            modelBuilder.Entity<AnalysisFatmeterData>(entity =>
            {
                entity.ToTable("analysis_fatmeter_data", "BIO");

                entity.HasIndex(e => e.AnalysisBaseFatmeterId)
                    .HasName("IX_analysis_fatmeter");

                entity.HasIndex(e => e.FatmeterMeasureId)
                    .HasName("IX_analysis_fatmeter_data_measure");

                entity.Property(e => e.AnalysisFatmeterDataId).HasColumnName("analysis_fatmeter_data_id");

                entity.Property(e => e.AnalysisBaseFatmeterId).HasColumnName("analysis_base_fatmeter_id");

                entity.Property(e => e.Average).HasColumnName("average");

                entity.Property(e => e.AvgChosenVal).HasColumnName("avg_chosen_val");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.FatmeterMeasureId)
                    .IsRequired()
                    .HasColumnName("fatmeter_measure_id")
                    .HasMaxLength(1);

                entity.Property(e => e.IsAvgRecalc).HasColumnName("is_avg_recalc");

                entity.Property(e => e.IsOutlierDetect).HasColumnName("is_outlier_detect");

                entity.Property(e => e.IsValid).HasColumnName("is_valid");

                entity.Property(e => e.JustVal).HasColumnName("just_val");

                entity.Property(e => e.StdDev).HasColumnName("std_dev");

                entity.Property(e => e.ValFat1).HasColumnName("val_fat_1");

                entity.Property(e => e.ValFat2).HasColumnName("val_fat_2");

                entity.Property(e => e.ValFat3).HasColumnName("val_fat_3");

                entity.Property(e => e.ValFat4).HasColumnName("val_fat_4");

                entity.Property(e => e.ValFat5).HasColumnName("val_fat_5");

                entity.Property(e => e.ValFat6).HasColumnName("val_fat_6");

                entity.Property(e => e.ValFat7).HasColumnName("val_fat_7");

                entity.Property(e => e.ValFat8).HasColumnName("val_fat_8");

                entity.HasOne(d => d.AnalysisBaseFatmeter)
                    .WithMany(p => p.AnalysisFatmeterData)
                    .HasForeignKey(d => d.AnalysisBaseFatmeterId)
                    .HasConstraintName("FK_analysis_fatmeter_data_analysis_fatmeter");

                entity.HasOne(d => d.FatmeterMeasure)
                    .WithMany(p => p.AnalysisFatmeterData)
                    .HasForeignKey(d => d.FatmeterMeasureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_analysis_fatmeter_data_fatmeter_measure");
            });

            modelBuilder.Entity<AnalysisGenetic>(entity =>
            {
                entity.HasKey(e => e.AnalysisBaseId);

                entity.ToTable("analysis_genetic", "BIO");

                entity.HasIndex(e => e.HaplotypeCodeId)
                    .HasName("IX_analysis_genetic_haplotype");

                entity.Property(e => e.AnalysisBaseId)
                    .HasColumnName("analysis_base_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnalysisTypeId)
                    .IsRequired()
                    .HasColumnName("analysis_type_id")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'GE')");

                entity.Property(e => e.HaplotypeCodeId)
                    .IsRequired()
                    .HasColumnName("haplotype_code_id")
                    .HasMaxLength(6);

                entity.HasOne(d => d.Analysis)
                    .WithMany(p => p.AnalysisGenetic)
                    .HasPrincipalKey(p => new { p.AnalysisBaseId, p.AnalysisTypeId })
                    .HasForeignKey(d => new { d.AnalysisBaseId, d.AnalysisTypeId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_analysis_genetic_analysis_base");
            });

            modelBuilder.Entity<AnalysisHistology>(entity =>
            {
                entity.HasKey(e => e.AnalysisBaseHistologyId);

                entity.ToTable("analysis_histology", "BIO");

                entity.HasIndex(e => e.MicroscopicStageId)
                    .HasName("IX_analysis_histology_stage");

                entity.HasIndex(e => e.SexId)
                    .HasName("IX_analysis_histology_sex");

                entity.Property(e => e.AnalysisBaseHistologyId)
                    .HasColumnName("analysis_base_histology_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnalysisTypeId)
                    .IsRequired()
                    .HasColumnName("analysis_type_id")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'HI')");

                entity.Property(e => e.BatchFecundity).HasColumnName("batch_fecundity");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsMature).HasColumnName("is_mature");

                entity.Property(e => e.IsPof).HasColumnName("is_POF");

                entity.Property(e => e.MagoDiameter).HasColumnName("MAGO_diameter");

                entity.Property(e => e.MagoStageId).HasColumnName("MAGO_stage_id");

                entity.Property(e => e.MicroscopicStageId)
                    .HasColumnName("microscopic_stage_id")
                    .HasMaxLength(3);

                entity.Property(e => e.RelativeFecundity).HasColumnName("relative_fecundity");

                entity.Property(e => e.SexId)
                    .IsRequired()
                    .HasColumnName("sex_id")
                    .HasMaxLength(1);

                entity.HasOne(d => d.AnalysisBaseHistology)
                    .WithOne(p => p.AnalysisHistology)
                    .HasForeignKey<AnalysisHistology>(d => d.AnalysisBaseHistologyId)
                    .HasConstraintName("FK_analysis_histology_analysis_base");

                entity.HasOne(d => d.MagoStage)
                    .WithMany(p => p.AnalysisHistology)
                    .HasForeignKey(d => d.MagoStageId)
                    .HasConstraintName("FK_analysis_histology_MAGO_stage");

                entity.HasOne(d => d.MicroscopicStage)
                    .WithMany(p => p.AnalysisHistology)
                    .HasForeignKey(d => d.MicroscopicStageId)
                    .HasConstraintName("FK_analysis_histology_microscopic_stage");

                entity.HasOne(d => d.Sex)
                    .WithMany(p => p.AnalysisHistology)
                    .HasForeignKey(d => d.SexId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_analysis_histology_sex");
            });

            modelBuilder.Entity<AnalysisHistologyData>(entity =>
            {
                entity.ToTable("analysis_histology_data", "BIO");

                entity.HasIndex(e => e.AnalysisBaseHistologyId)
                    .HasName("IX_analysis_histology_data");

                entity.HasIndex(e => e.HistologyCellId)
                    .HasName("IX_analysis_histology_data_cell");

                entity.Property(e => e.AnalysisHistologyDataId).HasColumnName("analysis_histology_data_id");

                entity.Property(e => e.AnalysisBaseHistologyId).HasColumnName("analysis_base_histology_id");

                entity.Property(e => e.HistologyCellId)
                    .IsRequired()
                    .HasColumnName("histology_cell_id")
                    .HasMaxLength(3);

                entity.HasOne(d => d.AnalysisBaseHistology)
                    .WithMany(p => p.AnalysisHistologyData)
                    .HasForeignKey(d => d.AnalysisBaseHistologyId)
                    .HasConstraintName("FK_analysis_histology_data_analysis_histology");

                entity.HasOne(d => d.HistologyCell)
                    .WithMany(p => p.AnalysisHistologyData)
                    .HasForeignKey(d => d.HistologyCellId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_analysis_histology_data_histology_cell");
            });

            modelBuilder.Entity<AnalysisIsotope>(entity =>
            {
                entity.HasKey(e => e.AnalysisBaseId);

                entity.ToTable("analysis_isotope", "BIO");

                entity.Property(e => e.AnalysisBaseId)
                    .HasColumnName("analysis_base_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnalysisTypeId)
                    .IsRequired()
                    .HasColumnName("analysis_type_id")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'IS')");

                entity.Property(e => e.Cn).HasColumnName("CN");

                entity.Property(e => e.D13C).HasColumnName("d13C");

                entity.Property(e => e.D13CCsia).HasColumnName("d13C_CSIA");

                entity.Property(e => e.D15N).HasColumnName("d15N");

                entity.Property(e => e.D199Hg).HasColumnName("d199Hg");

                entity.Property(e => e.D199hg1).HasColumnName("D_199Hg");

                entity.Property(e => e.D200Hg).HasColumnName("d200Hg");

                entity.Property(e => e.D200hg1).HasColumnName("D_200Hg");

                entity.Property(e => e.D201Hg).HasColumnName("d201Hg");

                entity.Property(e => e.D201hg1).HasColumnName("D_201Hg");

                entity.Property(e => e.D202Hg).HasColumnName("d202Hg");

                entity.Property(e => e.D204Hg).HasColumnName("d204Hg");

                entity.Property(e => e.D204hg1).HasColumnName("D_204Hg");

                entity.Property(e => e.D34S).HasColumnName("d34S");

                entity.Property(e => e.DwUnit)
                    .HasColumnName("DW_unit")
                    .HasMaxLength(10);

                entity.Property(e => e.DwValue)
                    .HasColumnName("DW_value")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Instrumentation)
                    .HasColumnName("instrumentation")
                    .HasMaxLength(255);

                entity.Property(e => e.IsLipidExtracted).HasColumnName("is_lipid_extracted");

                entity.Property(e => e.LabIdNo)
                    .HasColumnName("lab_id_no")
                    .HasMaxLength(50);

                entity.Property(e => e.LeDate)
                    .HasColumnName("LE_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PercentC).HasColumnName("percent_C");

                entity.Property(e => e.PercentN).HasColumnName("percent_N");

                entity.Property(e => e.Project)
                    .IsRequired()
                    .HasColumnName("project")
                    .HasMaxLength(255);

                entity.Property(e => e.SiaDate)
                    .HasColumnName("SIA_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.WwUnit)
                    .HasColumnName("WW_unit")
                    .HasMaxLength(10);

                entity.Property(e => e.WwValue)
                    .HasColumnName("WW_value")
                    .HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Analysis)
                    .WithMany(p => p.AnalysisIsotope)
                    .HasPrincipalKey(p => new { p.AnalysisBaseId, p.AnalysisTypeId })
                    .HasForeignKey(d => new { d.AnalysisBaseId, d.AnalysisTypeId })
                    .HasConstraintName("FK_analysis_isotope_analysis_base");
            });

            modelBuilder.Entity<AnalysisLipid>(entity =>
            {
                entity.HasKey(e => e.AnalysisBaseLipidId);

                entity.ToTable("analysis_lipid", "BIO");

                entity.HasIndex(e => e.LipidHomogenizationId)
                    .HasName("IX_analysis_lipid_lipid_homogenization");

                entity.HasIndex(e => e.TissueSideId)
                    .HasName("IX_analysis_lipid_tissue_side");

                entity.Property(e => e.AnalysisBaseLipidId)
                    .HasColumnName("analysis_base_lipid_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnalysisTypeId)
                    .IsRequired()
                    .HasColumnName("analysis_type_id")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'LI')");

                entity.Property(e => e.CalibrationId)
                    .IsRequired()
                    .HasColumnName("calibration_id")
                    .HasMaxLength(50);

                entity.Property(e => e.ClassAnalysisDate)
                    .HasColumnName("class_analysis_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FfaClass).HasColumnName("FFA_class");

                entity.Property(e => e.IsValid).HasColumnName("is_valid");

                entity.Property(e => e.LabSampleCode).HasColumnName("lab_sample_code");

                entity.Property(e => e.LipidHomogenizationId)
                    .HasColumnName("lipid_homogenization_id")
                    .HasMaxLength(1);

                entity.Property(e => e.LipidProportion).HasColumnName("lipid_proportion");

                entity.Property(e => e.LipidWeightMgr).HasColumnName("lipid_weight_mgr");

                entity.Property(e => e.PlClass).HasColumnName("PL_class");

                entity.Property(e => e.StClass).HasColumnName("ST_class");

                entity.Property(e => e.TagClass).HasColumnName("TAG_class");

                entity.Property(e => e.TissueSideId)
                    .HasColumnName("tissue_side_id")
                    .HasMaxLength(1);

                entity.Property(e => e.TissueWeightGr).HasColumnName("tissue_weight_gr");

                entity.HasOne(d => d.LipidHomogenization)
                    .WithMany(p => p.AnalysisLipid)
                    .HasForeignKey(d => d.LipidHomogenizationId)
                    .HasConstraintName("FK_analysis_lipid_lipid_homogenization");

                entity.HasOne(d => d.TissueSide)
                    .WithMany(p => p.AnalysisLipid)
                    .HasForeignKey(d => d.TissueSideId)
                    .HasConstraintName("FK_analysis_lipid_tissue_side");

                entity.HasOne(d => d.Analysis)
                    .WithMany(p => p.AnalysisLipid)
                    .HasPrincipalKey(p => new { p.AnalysisBaseId, p.AnalysisTypeId })
                    .HasForeignKey(d => new { d.AnalysisBaseLipidId, d.AnalysisTypeId })
                    .HasConstraintName("FK_analysis_lipid_analysis_base");
            });

            modelBuilder.Entity<AnalysisLipidData>(entity =>
            {
                entity.ToTable("analysis_lipid_data", "BIO");

                entity.HasIndex(e => e.AnalysisBaseLipidId)
                    .HasName("IX_analysis_lipid_data_analysis_lipid");

                entity.HasIndex(e => e.LipidFattyId)
                    .HasName("IX_analysis_lipid_data_lipid_fatty");

                entity.Property(e => e.AnalysisLipidDataId).HasColumnName("analysis_lipid_data_id");

                entity.Property(e => e.AnalysisBaseLipidId).HasColumnName("analysis_base_lipid_id");

                entity.Property(e => e.FattyAnalysisDate)
                    .HasColumnName("fatty_analysis_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LipidFattyId)
                    .IsRequired()
                    .HasColumnName("lipid_fatty_id")
                    .HasMaxLength(20);

                entity.Property(e => e.LipidValue).HasColumnName("lipid_value");

                entity.HasOne(d => d.AnalysisBaseLipid)
                    .WithMany(p => p.AnalysisLipidData)
                    .HasForeignKey(d => d.AnalysisBaseLipidId)
                    .HasConstraintName("FK_analysis_lipid_data_analysis_lipid");

                entity.HasOne(d => d.LipidFatty)
                    .WithMany(p => p.AnalysisLipidData)
                    .HasForeignKey(d => d.LipidFattyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_analysis_lipid_data_lipid_fatty");
            });

            modelBuilder.Entity<AnalysisQuantity>(entity =>
            {
                entity.HasKey(e => e.AnalysisBaseId);

                entity.ToTable("analysis_quantity", "BIO");

                entity.Property(e => e.AnalysisBaseId)
                    .HasColumnName("analysis_base_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnalysisTypeId)
                    .IsRequired()
                    .HasColumnName("analysis_type_id")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'QU')");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.QuantityUnit)
                    .IsRequired()
                    .HasColumnName("quantity_unit")
                    .HasMaxLength(40);

                entity.Property(e => e.QuantityValue).HasColumnName("quantity_value");

                entity.Property(e => e.SubAnalysisType)
                    .HasColumnName("sub_analysis_type")
                    .HasMaxLength(20);

                entity.HasOne(d => d.Analysis)
                    .WithMany(p => p.AnalysisQuantity)
                    .HasPrincipalKey(p => new { p.AnalysisBaseId, p.AnalysisTypeId })
                    .HasForeignKey(d => new { d.AnalysisBaseId, d.AnalysisTypeId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_analysis_quantity_analysis_base");
            });

            modelBuilder.Entity<AnalysisSampleType>(entity =>
            {
                entity.HasKey(e => e.AnalysisSampleId);

                entity.ToTable("analysis_sample_type", "QRY");

                entity.HasIndex(e => e.AnalysisTypeId)
                    .HasName("IX_analysis_sample_type_analysis");

                entity.HasIndex(e => e.TissueTypeId)
                    .HasName("IX_analysis_sample_type_tissue");

                entity.HasIndex(e => new { e.AnalysisTypeId, e.TissueTypeId })
                    .HasName("UX_analysis_sample_type")
                    .IsUnique();

                entity.Property(e => e.AnalysisSampleId).HasColumnName("analysis_sample_id");

                entity.Property(e => e.AnalysisTypeId)
                    .IsRequired()
                    .HasColumnName("analysis_type_id")
                    .HasMaxLength(2);

                entity.Property(e => e.TissueTypeId)
                    .IsRequired()
                    .HasColumnName("tissue_type_id")
                    .HasMaxLength(2);

                entity.HasOne(d => d.AnalysisType)
                    .WithMany(p => p.AnalysisSampleType)
                    .HasForeignKey(d => d.AnalysisTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_analysis_sample_type_analysis_type");

                entity.HasOne(d => d.TissueType)
                    .WithMany(p => p.AnalysisSampleType)
                    .HasForeignKey(d => d.TissueTypeId)
                    .HasConstraintName("FK_analysis_sample_type_tissue_type");
            });

            modelBuilder.Entity<AnalysisSizeStructure>(entity =>
            {
                entity.HasKey(e => e.AnalysisBaseId);

                entity.ToTable("analysis_size_structure", "BIO");

                entity.Property(e => e.AnalysisBaseId)
                    .HasColumnName("analysis_base_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnalysisTypeId)
                    .IsRequired()
                    .HasColumnName("analysis_type_id")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'SS')");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment");

                entity.Property(e => e.Esd).HasColumnName("ESD");

                entity.Property(e => e.SizeStructureUnit)
                    .HasColumnName("size_structure_unit")
                    .HasMaxLength(40);

                entity.Property(e => e.SizeStructureValue).HasColumnName("size_structure_value");

                entity.HasOne(d => d.Analysis)
                    .WithMany(p => p.AnalysisSizeStructure)
                    .HasPrincipalKey(p => new { p.AnalysisBaseId, p.AnalysisTypeId })
                    .HasForeignKey(d => new { d.AnalysisBaseId, d.AnalysisTypeId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_analysis_size_structure_analysis_base");
            });

            modelBuilder.Entity<AnalysisStomachContent>(entity =>
            {
                entity.HasKey(e => e.AnalysisBaseStomachId);

                entity.ToTable("analysis_stomach_content", "BIO");

                entity.HasIndex(e => e.FullnessCoeffId)
                    .HasName("IX_analysis_stomach_content_fullness_coeff");

                entity.HasIndex(e => e.StomachStatusId)
                    .HasName("IX_analysis_stomach_content_stomach_status");

                entity.Property(e => e.AnalysisBaseStomachId)
                    .HasColumnName("analysis_base_stomach_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnalysisTypeId)
                    .IsRequired()
                    .HasColumnName("analysis_type_id")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'ST')");

                entity.Property(e => e.BaitNb).HasColumnName("bait_nb");

                entity.Property(e => e.BaitWeightGr).HasColumnName("bait_weight_gr");

                entity.Property(e => e.CleanedWeightGr).HasColumnName("cleaned_weight_gr");

                entity.Property(e => e.ContentWeightGr)
                    .HasColumnName("content_weight_gr")
                    .HasComputedColumnSql("(round([whole_weight_gr]-[cleaned_weight_gr],(2)))");

                entity.Property(e => e.FullnessCoeffId).HasColumnName("fullness_coeff_id");

                entity.Property(e => e.StomachStatusId)
                    .IsRequired()
                    .HasColumnName("stomach_status_id")
                    .HasMaxLength(3);

                entity.Property(e => e.WholeWeightGr).HasColumnName("whole_weight_gr");

                entity.HasOne(d => d.FullnessCoeff)
                    .WithMany(p => p.AnalysisStomachContent)
                    .HasForeignKey(d => d.FullnessCoeffId)
                    .HasConstraintName("FK_analysis_stomach_content_fullness_coeff");

                entity.HasOne(d => d.StomachStatus)
                    .WithMany(p => p.AnalysisStomachContent)
                    .HasForeignKey(d => d.StomachStatusId)
                    .HasConstraintName("FK_analysis_stomach_content_stomach_status");

                entity.HasOne(d => d.Analysis)
                    .WithMany(p => p.AnalysisStomachContent)
                    .HasPrincipalKey(p => new { p.AnalysisBaseId, p.AnalysisTypeId })
                    .HasForeignKey(d => new { d.AnalysisBaseStomachId, d.AnalysisTypeId })
                    .HasConstraintName("FK_analysis_stomach_content_analysis_base");
            });

            modelBuilder.Entity<AnalysisStomachHardMaterial>(entity =>
            {
                entity.ToTable("analysis_stomach_hard_material", "BIO");

                entity.HasIndex(e => e.AnalysisBaseStomachId)
                    .HasName("IX_analysis_stomach_hard_material_analysis_stomach_content");

                entity.HasIndex(e => e.AnalysisStomachHardMaterialId)
                    .HasName("IX_analysis_stomach_hard_material_otolith");

                entity.HasIndex(e => e.HardMaterialId)
                    .HasName("IX_analysis_stomach_hard_material_hard_material");

                entity.Property(e => e.AnalysisStomachHardMaterialId).HasColumnName("analysis_stomach_hard_material_id");

                entity.Property(e => e.AnalysisBaseStomachId).HasColumnName("analysis_base_stomach_id");

                entity.Property(e => e.HardMaterialId).HasColumnName("hard_material_id");

                entity.Property(e => e.HardMaterialNb).HasColumnName("hard_material_nb");

                entity.Property(e => e.HardMaterialOtolithId).HasColumnName("hard_material_otolith_id");

                entity.HasOne(d => d.AnalysisBaseStomach)
                    .WithMany(p => p.AnalysisStomachHardMaterial)
                    .HasForeignKey(d => d.AnalysisBaseStomachId)
                    .HasConstraintName("FK_analysis_stomach_hard_material_analysis_stomach_content");

                entity.HasOne(d => d.HardMaterial)
                    .WithMany(p => p.AnalysisStomachHardMaterial)
                    .HasForeignKey(d => d.HardMaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_stomach_hard_material_hard_material");

                entity.HasOne(d => d.HardMaterialOtolith)
                    .WithMany(p => p.AnalysisStomachHardMaterial)
                    .HasForeignKey(d => d.HardMaterialOtolithId)
                    .HasConstraintName("FK_stomach_hard_material_hard_material_otolith");
            });

            modelBuilder.Entity<AnalysisStomachParasite>(entity =>
            {
                entity.ToTable("analysis_stomach_parasite", "BIO");

                entity.HasIndex(e => e.AnalysisBaseStomachId)
                    .HasName("IX_analysis_stomach_parasite_analysis_stomach_content");

                entity.HasIndex(e => e.ParasiteId)
                    .HasName("IX_analysis_stomach_parasite_parasite");

                entity.HasIndex(e => e.ParasiteModeId)
                    .HasName("IX_analysis_stomach_parasite_parasite_mode");

                entity.Property(e => e.AnalysisStomachParasiteId).HasColumnName("analysis_stomach_parasite_id");

                entity.Property(e => e.AnalysisBaseStomachId).HasColumnName("analysis_base_stomach_id");

                entity.Property(e => e.ParasiteId).HasColumnName("parasite_id");

                entity.Property(e => e.ParasiteModeId).HasColumnName("parasite_mode_id");

                entity.Property(e => e.ParasiteNb).HasColumnName("parasite_nb");

                entity.HasOne(d => d.AnalysisBaseStomach)
                    .WithMany(p => p.AnalysisStomachParasite)
                    .HasForeignKey(d => d.AnalysisBaseStomachId)
                    .HasConstraintName("FK_analysis_stomach_parasite_analysis_stomach_content");

                entity.HasOne(d => d.Parasite)
                    .WithMany(p => p.AnalysisStomachParasite)
                    .HasForeignKey(d => d.ParasiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_analysis_stomach_parasite_parasite");

                entity.HasOne(d => d.ParasiteMode)
                    .WithMany(p => p.AnalysisStomachParasite)
                    .HasForeignKey(d => d.ParasiteModeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_analysis_stomach_parasite_parasite_mode");
            });

            modelBuilder.Entity<AnalysisStomachPreyIndividual>(entity =>
            {
                entity.ToTable("analysis_stomach_prey_individual", "BIO");

                entity.HasIndex(e => e.AnalysisStomachPreyItemId)
                    .HasName("IX_analysis_stomach_prey_individual_prey_item");

                entity.HasIndex(e => e.LengthCodeId1)
                    .HasName("IX_analysis_stomach_prey_individual_length_code_1");

                entity.HasIndex(e => e.LengthCodeId2)
                    .HasName("IX_analysis_stomach_prey_individual_length_code_2");

                entity.HasIndex(e => e.LengthCodeId3)
                    .HasName("IX_analysis_stomach_prey_individual_length_code_3");

                entity.HasIndex(e => e.SexId)
                    .HasName("IX_analysis_stomach_prey_individual_sex");

                entity.Property(e => e.AnalysisStomachPreyIndividualId).HasColumnName("analysis_stomach_prey_individual_id");

                entity.Property(e => e.AnalysisStomachPreyItemId).HasColumnName("analysis_stomach_prey_item_id");

                entity.Property(e => e.CollectionReference)
                    .HasColumnName("collection_reference")
                    .HasMaxLength(50);

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.LengthCodeId1)
                    .HasColumnName("length_code_id_1")
                    .HasMaxLength(2);

                entity.Property(e => e.LengthCodeId2)
                    .HasColumnName("length_code_id_2")
                    .HasMaxLength(2);

                entity.Property(e => e.LengthCodeId3)
                    .HasColumnName("length_code_id_3")
                    .HasMaxLength(2);

                entity.Property(e => e.LengthMm1).HasColumnName("length_mm_1");

                entity.Property(e => e.LengthMm2).HasColumnName("length_mm_2");

                entity.Property(e => e.LengthMm3).HasColumnName("length_mm_3");

                entity.Property(e => e.Muscle)
                    .HasColumnName("muscle")
                    .HasMaxLength(25);

                entity.Property(e => e.Photo1)
                    .HasColumnName("photo_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Photo2)
                    .HasColumnName("photo_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Photo3)
                    .HasColumnName("photo_3")
                    .HasMaxLength(255);

                entity.Property(e => e.Photo4)
                    .HasColumnName("photo_4")
                    .HasMaxLength(255);

                entity.Property(e => e.SexId)
                    .HasColumnName("sex_id")
                    .HasMaxLength(1);

                entity.Property(e => e.StomachSubSample)
                    .HasColumnName("stomach_sub_sample")
                    .HasMaxLength(25);

                entity.Property(e => e.TmpId).HasColumnName("TMP_id");

                entity.Property(e => e.WeightGr).HasColumnName("weight_gr");

                entity.HasOne(d => d.AnalysisStomachPreyItem)
                    .WithMany(p => p.AnalysisStomachPreyIndividual)
                    .HasForeignKey(d => d.AnalysisStomachPreyItemId)
                    .HasConstraintName("FK_analysis_stomach_prey_individual_prey_item");

                entity.HasOne(d => d.LengthCodeId1Navigation)
                    .WithMany(p => p.AnalysisStomachPreyIndividualLengthCodeId1Navigation)
                    .HasForeignKey(d => d.LengthCodeId1)
                    .HasConstraintName("FK_analysis_stomach_prey_individual_length_code_1");

                entity.HasOne(d => d.LengthCodeId2Navigation)
                    .WithMany(p => p.AnalysisStomachPreyIndividualLengthCodeId2Navigation)
                    .HasForeignKey(d => d.LengthCodeId2)
                    .HasConstraintName("FK_analysis_stomach_prey_individual_length_code_2");

                entity.HasOne(d => d.LengthCodeId3Navigation)
                    .WithMany(p => p.AnalysisStomachPreyIndividualLengthCodeId3Navigation)
                    .HasForeignKey(d => d.LengthCodeId3)
                    .HasConstraintName("FK_analysis_stomach_prey_individual_length_code_3");

                entity.HasOne(d => d.Sex)
                    .WithMany(p => p.AnalysisStomachPreyIndividual)
                    .HasForeignKey(d => d.SexId)
                    .HasConstraintName("FK_analysis_stomach_prey_individual_sex");
            });

            modelBuilder.Entity<AnalysisStomachPreyItem>(entity =>
            {
                entity.ToTable("analysis_stomach_prey_item", "BIO");

                entity.HasIndex(e => e.AnalysisBaseStomachId)
                    .HasName("IX_analysis_stomach_prey_item_analysis_stomach_content");

                entity.HasIndex(e => e.PreyDevelopmentId)
                    .HasName("IX_analysis_stomach_prey_item_prey_development");

                entity.HasIndex(e => e.PreyDigestionId)
                    .HasName("IX_analysis_stomach_prey_item_prey_digestion");

                entity.HasIndex(e => e.SpeciesId)
                    .HasName("IX_analysis_stomach_prey_item_species");

                entity.HasIndex(e => new { e.AnalysisBaseStomachId, e.PreyDigestionId, e.PreyDevelopmentId, e.SpeciesId })
                    .HasName("UX_analysis_stomach_prey_item")
                    .IsUnique();

                entity.Property(e => e.AnalysisStomachPreyItemId).HasColumnName("analysis_stomach_prey_item_id");

                entity.Property(e => e.AnalysisBaseStomachId).HasColumnName("analysis_base_stomach_id");

                entity.Property(e => e.CollectionReference)
                    .HasColumnName("collection_reference")
                    .HasMaxLength(30);

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.IndividualsNb).HasColumnName("individuals_nb");

                entity.Property(e => e.PreyDevelopmentId)
                    .IsRequired()
                    .HasColumnName("prey_development_id")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'U')");

                entity.Property(e => e.PreyDigestionId)
                    .HasColumnName("prey_digestion_id")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.SpeciesId).HasColumnName("species_id");

                entity.Property(e => e.TmpId).HasColumnName("TMP_id");

                entity.Property(e => e.TotalWeightGr).HasColumnName("total_weight_gr");

                entity.HasOne(d => d.AnalysisBaseStomach)
                    .WithMany(p => p.AnalysisStomachPreyItem)
                    .HasForeignKey(d => d.AnalysisBaseStomachId)
                    .HasConstraintName("FK_analysis_stomach_prey_item_analysis_stomach_content");

                entity.HasOne(d => d.PreyDevelopment)
                    .WithMany(p => p.AnalysisStomachPreyItem)
                    .HasForeignKey(d => d.PreyDevelopmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_analysis_stomach_prey_item_prey_development");

                entity.HasOne(d => d.PreyDigestion)
                    .WithMany(p => p.AnalysisStomachPreyItem)
                    .HasForeignKey(d => d.PreyDigestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_analysis_stomach_prey_item_prey_digestion");

                entity.HasOne(d => d.Species)
                    .WithMany(p => p.AnalysisStomachPreyItem)
                    .HasForeignKey(d => d.SpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_analysis_stomach_prey_item_species");
            });

            modelBuilder.Entity<AnalysisType>(entity =>
            {
                entity.ToTable("analysis_type", "REF");

                entity.HasIndex(e => e.AnalysisTypeDesc)
                    .HasName("UX_analysis_type")
                    .IsUnique();

                entity.Property(e => e.AnalysisTypeId)
                    .HasColumnName("analysis_type_id")
                    .HasMaxLength(2)
                    .ValueGeneratedNever();

                entity.Property(e => e.AnalysisColor)
                    .HasColumnName("analysis_color")
                    .HasMaxLength(7);

                entity.Property(e => e.AnalysisTypeDesc)
                    .IsRequired()
                    .HasColumnName("analysis_type_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AreaReliability>(entity =>
            {
                entity.ToTable("area_reliability", "REF");

                entity.HasIndex(e => e.AreaReliabilityDesc)
                    .HasName("UX_area_reliability")
                    .IsUnique();

                entity.Property(e => e.AreaReliabilityId)
                    .HasColumnName("area_reliability_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AreaReliabilityDesc)
                    .IsRequired()
                    .HasColumnName("area_reliability_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserClaims_AspNetUsers");
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<BetRegion>(entity =>
            {
                entity.ToTable("BET_region", "REF");

                entity.Property(e => e.BetRegionId).HasColumnName("BET_region_id");

                entity.Property(e => e.BetRegionDesc)
                    .HasColumnName("BET_region_desc")
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<BirdDevelopment>(entity =>
            {
                entity.ToTable("bird_development", "REF");

                entity.HasIndex(e => e.BirdDevelopmentDesc)
                    .HasName("UX_bird_development")
                    .IsUnique();

                entity.Property(e => e.BirdDevelopmentId)
                    .HasColumnName("bird_development_id")
                    .HasMaxLength(1)
                    .ValueGeneratedNever();

                entity.Property(e => e.BirdDevelopmentDesc)
                    .IsRequired()
                    .HasColumnName("bird_development_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BirdLengthCode>(entity =>
            {
                entity.ToTable("bird_length_code", "REF");

                entity.HasIndex(e => e.BirdLengthCodeDesc)
                    .HasName("UX_bird_length_code")
                    .IsUnique();

                entity.Property(e => e.BirdLengthCodeId)
                    .HasColumnName("bird_length_code_id")
                    .HasMaxLength(3)
                    .ValueGeneratedNever();

                entity.Property(e => e.BirdLengthCodeDesc)
                    .IsRequired()
                    .HasColumnName("bird_length_code_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BirdReproduction>(entity =>
            {
                entity.ToTable("bird_reproduction", "REF");

                entity.HasIndex(e => e.BirdReproductionDesc)
                    .HasName("UX_bird_reproduction")
                    .IsUnique();

                entity.Property(e => e.BirdReproductionId)
                    .HasColumnName("bird_reproduction_id")
                    .HasMaxLength(1)
                    .ValueGeneratedNever();

                entity.Property(e => e.BirdReproductionDesc)
                    .IsRequired()
                    .HasColumnName("bird_reproduction_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BirdStatus>(entity =>
            {
                entity.ToTable("bird_status", "REF");

                entity.HasIndex(e => e.BirdStatusId)
                    .HasName("UX_bird_status")
                    .IsUnique();

                entity.Property(e => e.BirdStatusId)
                    .HasColumnName("bird_status_id")
                    .HasMaxLength(1)
                    .ValueGeneratedNever();

                entity.Property(e => e.BirdStatusDesc)
                    .IsRequired()
                    .HasColumnName("bird_status_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CabinetOo>(entity =>
            {
                entity.ToTable("cabinet_OO", "LAB");

                entity.HasIndex(e => e.AsfisCode)
                    .HasName("UX_cabinet_OO")
                    .IsUnique();

                entity.Property(e => e.CabinetOoId)
                    .HasColumnName("cabinet_OO_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AsfisCode)
                    .IsRequired()
                    .HasColumnName("asfis_code")
                    .HasMaxLength(3);

                entity.Property(e => e.Cabinet)
                    .IsRequired()
                    .HasColumnName("cabinet")
                    .HasMaxLength(4);

                entity.Property(e => e.NbRacks).HasColumnName("nb_racks");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.SpeciesRack)
                    .IsRequired()
                    .HasColumnName("species_rack")
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<ChildSpecimenSampleLink>(entity =>
            {
                entity.HasKey(e => new { e.ParentSampleBaseId, e.ChildSpecimenId });

                entity.ToTable("child_specimen_sample_link", "QRY");

                entity.Property(e => e.ParentSampleBaseId).HasColumnName("parent_sample_base_id");

                entity.Property(e => e.ChildSpecimenId).HasColumnName("child_specimen_id");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([date],getdate(),(0)))");

                entity.HasOne(d => d.ChildSpecimen)
                    .WithMany(p => p.ChildSpecimenSampleLink)
                    .HasForeignKey(d => d.ChildSpecimenId)
                    .HasConstraintName("FK_child_specimen_sample_link_fish");

                entity.HasOne(d => d.ParentSampleBase)
                    .WithMany(p => p.ChildSpecimenSampleLink)
                    .HasForeignKey(d => d.ParentSampleBaseId)
                    .HasConstraintName("FK_child_specimen_sample_link_sample_base");
            });

            modelBuilder.Entity<CodendType>(entity =>
            {
                entity.ToTable("codend_type", "REF");

                entity.HasIndex(e => e.CodendTypeDesc)
                    .HasName("UX_codend_type")
                    .IsUnique();

                entity.Property(e => e.CodendTypeId)
                    .HasColumnName("codend_type_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodendTypeDesc)
                    .IsRequired()
                    .HasColumnName("codend_type_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ConditionSampleType>(entity =>
            {
                entity.HasKey(e => e.ConditionSampleId);

                entity.ToTable("condition_sample_type", "QRY");

                entity.HasIndex(e => e.TissueConditionId)
                    .HasName("IX_condition_sample_type_condition");

                entity.HasIndex(e => e.TissueTypeId)
                    .HasName("IX_condition_sample_type_tissue");

                entity.HasIndex(e => new { e.TissueConditionId, e.TissueTypeId })
                    .HasName("UX_condition_sample_type")
                    .IsUnique();

                entity.Property(e => e.ConditionSampleId).HasColumnName("condition_sample_id");

                entity.Property(e => e.TissueConditionId)
                    .IsRequired()
                    .HasColumnName("tissue_condition_id")
                    .HasMaxLength(2);

                entity.Property(e => e.TissueTypeId)
                    .IsRequired()
                    .HasColumnName("tissue_type_id")
                    .HasMaxLength(2);

                entity.HasOne(d => d.TissueCondition)
                    .WithMany(p => p.ConditionSampleType)
                    .HasForeignKey(d => d.TissueConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_condition_sample_type_tissue_condition");

                entity.HasOne(d => d.TissueType)
                    .WithMany(p => p.ConditionSampleType)
                    .HasForeignKey(d => d.TissueTypeId)
                    .HasConstraintName("FK_condition_sample_type_tissue_type");
            });

            modelBuilder.Entity<Contaminant>(entity =>
            {
                entity.ToTable("contaminant", "REF");

                entity.HasIndex(e => e.ContaminantDesc)
                    .HasName("UX_contaminant")
                    .IsUnique();

                entity.Property(e => e.ContaminantId)
                    .HasColumnName("contaminant_id")
                    .HasMaxLength(4)
                    .ValueGeneratedNever();

                entity.Property(e => e.ContaminantDesc)
                    .IsRequired()
                    .HasColumnName("contaminant_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ContaminantWeight>(entity =>
            {
                entity.ToTable("contaminant_weight", "REF");

                entity.Property(e => e.ContaminantWeightId)
                    .HasColumnName("contaminant_weight_id")
                    .HasMaxLength(2)
                    .ValueGeneratedNever();

                entity.Property(e => e.ContaminantWeightDesc)
                    .IsRequired()
                    .HasColumnName("contaminant_weight_desc")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Contract>(entity =>
            {
                entity.ToTable("contract", "DOC");

                entity.HasIndex(e => e.ContractName)
                    .HasName("UX_contract")
                    .IsUnique();

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.ContactStaffId).HasColumnName("contact_staff_id");

                entity.Property(e => e.ContractName)
                    .IsRequired()
                    .HasColumnName("contract_name")
                    .HasMaxLength(250);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([date],getdate(),(0)))");

                entity.Property(e => e.EntityLocationId).HasColumnName("entity_location_id");

                entity.Property(e => e.EstimatedFeedbackDate)
                    .HasColumnName("estimated_feedback_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FreightLastFinal)
                    .HasColumnName("freight_last_final")
                    .HasColumnType("datetime");

                entity.Property(e => e.OwnershipLocationId).HasColumnName("ownership_location_id");

                entity.Property(e => e.PrepName)
                    .HasColumnName("prep_name")
                    .HasMaxLength(100);

                entity.Property(e => e.PrepPath).HasColumnName("prep_path");

                entity.Property(e => e.SamplesNb).HasColumnName("samples_nb");

                entity.Property(e => e.ScanName)
                    .HasColumnName("scan_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ScanPath).HasColumnName("scan_path");

                entity.Property(e => e.SignatureFinalDate)
                    .HasColumnName("signature_final_date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.ContactStaff)
                    .WithMany(p => p.Contract)
                    .HasForeignKey(d => d.ContactStaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_contract_staff");

                entity.HasOne(d => d.EntityLocation)
                    .WithMany(p => p.ContractEntityLocation)
                    .HasForeignKey(d => d.EntityLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_contract_location_entity");

                entity.HasOne(d => d.OwnershipLocation)
                    .WithMany(p => p.ContractOwnershipLocation)
                    .HasForeignKey(d => d.OwnershipLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_contract_location_ownership");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("country", "REF");

                entity.HasIndex(e => e.CountryName)
                    .HasName("UX_country")
                    .IsUnique();

                entity.Property(e => e.CountryId)
                    .HasColumnName("country_id")
                    .HasMaxLength(2)
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryFull)
                    .HasColumnName("country_full")
                    .HasMaxLength(30);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasColumnName("country_name")
                    .HasMaxLength(30);

                entity.Property(e => e.IsPacificOcean).HasColumnName("is_Pacific_Ocean");
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.Property(e => e.IdentityId).HasMaxLength(450);

                entity.HasOne(d => d.Identity)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.IdentityId);
            });

            modelBuilder.Entity<DayNight>(entity =>
            {
                entity.ToTable("day_night", "REF");

                entity.Property(e => e.DayNightId)
                    .HasColumnName("day_night_id")
                    .HasMaxLength(5)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<DbSamplingFile>(entity =>
            {
                entity.ToTable("db_sampling_file", "ADMIN");

                entity.Property(e => e.DbSamplingFileId).HasColumnName("db_sampling_file_id");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("file_name")
                    .HasMaxLength(255);

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasColumnName("file_path");

                entity.Property(e => e.Loader)
                    .IsRequired()
                    .HasColumnName("loader")
                    .HasMaxLength(50);

                entity.Property(e => e.LoadingDate)
                    .HasColumnName("loading_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoadingOption).HasColumnName("loading_option");

                entity.Property(e => e.Trip)
                    .IsRequired()
                    .HasColumnName("trip")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<DbTask>(entity =>
            {
                entity.ToTable("db_task", "ADMIN");

                entity.Property(e => e.DbTaskId).HasColumnName("DB_task_id");

                entity.Property(e => e.FileComplete).HasColumnName("file_complete");

                entity.Property(e => e.RecordNb).HasColumnName("record_nb");

                entity.Property(e => e.TaskDate)
                    .HasColumnName("task_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TaskDesc).HasColumnName("task_desc");

                entity.Property(e => e.TaskType)
                    .IsRequired()
                    .HasColumnName("task_type")
                    .HasMaxLength(255);

                entity.Property(e => e.Tasker)
                    .IsRequired()
                    .HasColumnName("tasker")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DbTransfer>(entity =>
            {
                entity.ToTable("db_transfer", "ADMIN");

                entity.HasIndex(e => e.IsDbUpdated);

                entity.HasIndex(e => e.SampleBaseId);

                entity.HasIndex(e => new { e.TransferBlockId, e.SampleBaseId, e.TypeTransfer, e.ToLocationId })
                    .HasName("UX_db_transfer")
                    .IsUnique();

                entity.Property(e => e.DbTransferId).HasColumnName("db_transfer_id");

                entity.Property(e => e.AnalysisTypeId)
                    .HasColumnName("analysis_type_id")
                    .HasMaxLength(2);

                entity.Property(e => e.ContactNameOld)
                    .HasColumnName("contact_name_OLD")
                    .HasMaxLength(100);

                entity.Property(e => e.ContactStaffId).HasColumnName("contact_staff_id");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.DateTransfer)
                    .HasColumnName("date_transfer")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExpectedDate)
                    .HasColumnName("expected_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FreezerLocationIdOld).HasColumnName("freezer_location_id_OLD");

                entity.Property(e => e.FromConditionId)
                    .HasColumnName("from_condition_id")
                    .HasMaxLength(2);

                entity.Property(e => e.FromFreezerId).HasColumnName("from_freezer_id");

                entity.Property(e => e.FromIdOld)
                    .HasColumnName("from_id_OLD")
                    .HasMaxLength(50);

                entity.Property(e => e.FromLocationId).HasColumnName("from_location_id");

                entity.Property(e => e.FromStorageQualityId)
                    .HasColumnName("from_storage_quality_id")
                    .HasMaxLength(1);

                entity.Property(e => e.GivenDateOld)
                    .HasColumnName("given_date_OLD")
                    .HasColumnType("datetime");

                entity.Property(e => e.InventoryDate)
                    .HasColumnName("inventory_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsDbUpdated).HasColumnName("is_db_updated");

                entity.Property(e => e.IsExcelUpdated).HasColumnName("is_excel_updated");

                entity.Property(e => e.LaboratoryLocationIdOld).HasColumnName("laboratory_location_id_OLD");

                entity.Property(e => e.LocationDate)
                    .HasColumnName("location_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocationDetails)
                    .HasColumnName("location_details")
                    .HasMaxLength(250);

                entity.Property(e => e.SampleBaseId).HasColumnName("sample_base_id");

                entity.Property(e => e.ToConditionId)
                    .HasColumnName("to_condition_id")
                    .HasMaxLength(2);

                entity.Property(e => e.ToFreezerId).HasColumnName("to_freezer_id");

                entity.Property(e => e.ToIdOld)
                    .HasColumnName("to_id_OLD")
                    .HasMaxLength(50);

                entity.Property(e => e.ToLocationId).HasColumnName("to_location_id");

                entity.Property(e => e.ToStorageQualityId)
                    .HasColumnName("to_storage_quality_id")
                    .HasMaxLength(1);

                entity.Property(e => e.TransferBlockId).HasColumnName("transfer_block_id");

                entity.Property(e => e.TypeTransfer).HasColumnName("type_transfer");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasMaxLength(50);

                entity.Property(e => e.VolumeSamplingFreightId)
                    .HasColumnName("volume_sampling_freight_id")
                    .HasMaxLength(1);

                entity.HasOne(d => d.SampleBase)
                    .WithMany(p => p.DbTransfer)
                    .HasForeignKey(d => d.SampleBaseId)
                    .HasConstraintName("FK_db_transfer_sample_base");
            });

            modelBuilder.Entity<Debriefing>(entity =>
            {
                entity.ToTable("debriefing", "STAFF");

                entity.HasIndex(e => e.DebrieferStaffId)
                    .HasName("IX_debriefing_debriefer1");

                entity.HasIndex(e => e.DebrieferStaffId2)
                    .HasName("IX_debriefing_debriefer2");

                entity.HasIndex(e => e.PortLocationCode)
                    .HasName("IX_debriefing_port");

                entity.HasIndex(e => e.SamplerStaffId)
                    .HasName("IX_debriefing_sampler");

                entity.HasIndex(e => e.TripId)
                    .HasName("IX_debriefing_trip");

                entity.HasIndex(e => new { e.DebrieferStaffId, e.SamplerStaffId, e.TripId })
                    .HasName("UX_debriefing")
                    .IsUnique();

                entity.Property(e => e.DebriefingId).HasColumnName("debriefing_id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.DebrieferStaffId).HasColumnName("debriefer_staff_id");

                entity.Property(e => e.DebrieferStaffId2).HasColumnName("debriefer_staff_id_2");

                entity.Property(e => e.DebriefingDate)
                    .HasColumnName("debriefing_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsDebriefReceived).HasColumnName("is_debrief_received");

                entity.Property(e => e.PortLocationCode)
                    .IsRequired()
                    .HasColumnName("port_location_code")
                    .HasMaxLength(5);

                entity.Property(e => e.SamplerStaffId).HasColumnName("sampler_staff_id");

                entity.Property(e => e.TripId).HasColumnName("trip_id");

                entity.HasOne(d => d.DebrieferStaff)
                    .WithMany(p => p.DebriefingDebrieferStaff)
                    .HasForeignKey(d => d.DebrieferStaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_debriefing_staff_debriefer1");

                entity.HasOne(d => d.DebrieferStaffId2Navigation)
                    .WithMany(p => p.DebriefingDebrieferStaffId2Navigation)
                    .HasForeignKey(d => d.DebrieferStaffId2)
                    .HasConstraintName("FK_debriefing_staff_debriefer2");

                entity.HasOne(d => d.PortLocationCodeNavigation)
                    .WithMany(p => p.Debriefing)
                    .HasForeignKey(d => d.PortLocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_debriefing_port");

                entity.HasOne(d => d.SamplerStaff)
                    .WithMany(p => p.DebriefingSamplerStaff)
                    .HasForeignKey(d => d.SamplerStaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_debriefing_staff_sampler");

                entity.HasOne(d => d.Trip)
                    .WithMany(p => p.Debriefing)
                    .HasForeignKey(d => d.TripId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_debriefing_trip");
            });

            modelBuilder.Entity<EezFinalV10IwAll>(entity =>
            {
                entity.HasKey(e => e.EezV10Id);

                entity.ToTable("EEZ_Final_v10_IW_All", "REF");

                entity.HasIndex(e => e.Subcountry)
                    .HasName("UX_EEZ_Final_v10_IW_All")
                    .IsUnique();

                entity.Property(e => e.EezV10Id).HasColumnName("eez_v10_id");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasMaxLength(2);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Subcountry)
                    .IsRequired()
                    .HasColumnName("subcountry")
                    .HasMaxLength(2);

                entity.Property(e => e.SubcountryTz)
                    .HasColumnName("subcountry_tz")
                    .HasColumnType("decimal(3, 1)");
            });

            modelBuilder.Entity<EezIw>(entity =>
            {
                entity.ToTable("eez_iw", "REF");

                entity.HasIndex(e => e.EezSubcountryId)
                    .HasName("UX_eez_iw_subcountry_id")
                    .IsUnique();

                entity.HasIndex(e => e.SubcountryName)
                    .IsUnique();

                entity.Property(e => e.EezIwId)
                    .HasColumnName("eez_iw_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaName)
                    .HasColumnName("area_name")
                    .HasMaxLength(50);

                entity.Property(e => e.EezCountryId)
                    .HasColumnName("eez_country_id")
                    .HasMaxLength(2);

                entity.Property(e => e.EezSubcountryId)
                    .IsRequired()
                    .HasColumnName("eez_subcountry_id")
                    .HasMaxLength(2);

                entity.Property(e => e.SubcountryName)
                    .HasColumnName("subcountry_name")
                    .HasMaxLength(255);

                entity.Property(e => e.SubcountryTz)
                    .HasColumnName("subcountry_tz")
                    .HasColumnType("decimal(3, 1)");

                entity.HasOne(d => d.EezCountry)
                    .WithMany(p => p.EezIw)
                    .HasForeignKey(d => d.EezCountryId)
                    .HasConstraintName("FK_eez_iw_country");
            });

            modelBuilder.Entity<EtopoGrid05>(entity =>
            {
                entity.ToTable("ETOPO_grid05", "GEO");

                entity.Property(e => e.EtopoGrid05Id).HasColumnName("ETOPO_grid05_id");

                entity.Property(e => e.BathyMeters)
                    .HasColumnName("bathy_meters")
                    .HasColumnType("decimal(6, 1)");

                entity.Property(e => e.ShpId).HasColumnName("shp_id");

                entity.Property(e => e.XCenter)
                    .HasColumnName("X_center")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Xmax).HasColumnName("xmax");

                entity.Property(e => e.Xmin).HasColumnName("xmin");

                entity.Property(e => e.YCenter)
                    .HasColumnName("Y_center")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Ymax).HasColumnName("ymax");

                entity.Property(e => e.Ymin).HasColumnName("ymin");
            });

            modelBuilder.Entity<FatmeterMeasure>(entity =>
            {
                entity.ToTable("fatmeter_measure", "REF");

                entity.HasIndex(e => e.FatmeterMeasureDesc)
                    .HasName("UX_fatmeter_measure")
                    .IsUnique();

                entity.Property(e => e.FatmeterMeasureId)
                    .HasColumnName("fatmeter_measure_id")
                    .HasMaxLength(1)
                    .ValueGeneratedNever();

                entity.Property(e => e.FatmeterMeasureDesc)
                    .IsRequired()
                    .HasColumnName("fatmeter_measure_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Fish>(entity =>
            {
                entity.ToTable("fish", "BIO");

                entity.HasIndex(e => e.EditorStaffId)
                    .HasName("IX_fish_editor_staff_1");

                entity.HasIndex(e => e.EditorStaffId2)
                    .HasName("IX_fish_editor_staff_2");

                entity.HasIndex(e => e.FishTypeId)
                    .HasName("IX_fish_fish_type");

                entity.HasIndex(e => e.LengthCodeId)
                    .HasName("IX_fish_length_code");

                entity.HasIndex(e => e.SetBaseId)
                    .HasName("IX_fish_sex");

                entity.HasIndex(e => e.SpeciesId)
                    .HasName("IX_fish_species");

                entity.HasIndex(e => e.WeightCodeId)
                    .HasName("IX_fish_weight_code");

                entity.HasIndex(e => new { e.SetBaseId, e.FishNo, e.SpeciesId })
                    .HasName("UX_fish")
                    .IsUnique();

                entity.Property(e => e.FishId).HasColumnName("fish_id");

                entity.Property(e => e.CalculatedWtGr).HasColumnName("calculated_wt_gr");

                entity.Property(e => e.CatchTime)
                    .HasColumnName("catch_time")
                    .HasMaxLength(4);

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([date],getdate(),(0)))");

                entity.Property(e => e.CsiroId)
                    .HasColumnName("CSIRO_id")
                    .HasMaxLength(20);

                entity.Property(e => e.DataReceptionDate)
                    .HasColumnName("data_reception_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DropNo).HasColumnName("drop_no");

                entity.Property(e => e.EditorStaffId).HasColumnName("editor_staff_id");

                entity.Property(e => e.EditorStaffId2).HasColumnName("editor_staff_id_2");

                entity.Property(e => e.EnteredByOld)
                    .HasColumnName("entered_by_OLD")
                    .HasMaxLength(15);

                entity.Property(e => e.FishNo)
                    .IsRequired()
                    .HasColumnName("fish_no")
                    .HasMaxLength(20);

                entity.Property(e => e.FishTypeId)
                    .IsRequired()
                    .HasColumnName("fish_type_id")
                    .HasMaxLength(1);

                entity.Property(e => e.GonadWeightGr).HasColumnName("gonad_weight_gr");

                entity.Property(e => e.HookNo).HasColumnName("hook_no");

                entity.Property(e => e.IsOfInterest).HasColumnName("is_of_interest");

                entity.Property(e => e.LengthCodeId)
                    .HasColumnName("length_code_id")
                    .HasMaxLength(2);

                entity.Property(e => e.LengthCodeId2)
                    .HasColumnName("length_code_id_2")
                    .HasMaxLength(2);

                entity.Property(e => e.LengthCodeId3)
                    .HasColumnName("length_code_id_3")
                    .HasMaxLength(2);

                entity.Property(e => e.LengthMm).HasColumnName("length_mm");

                entity.Property(e => e.LengthMm2).HasColumnName("length_mm_2");

                entity.Property(e => e.LengthMm3).HasColumnName("length_mm_3");

                entity.Property(e => e.OwnershipId).HasColumnName("ownership_id");

                entity.Property(e => e.PaiementDate)
                    .HasColumnName("paiement_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Photo1)
                    .HasColumnName("photo_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Photo2)
                    .HasColumnName("photo_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Photo3)
                    .HasColumnName("photo_3")
                    .HasMaxLength(255);

                entity.Property(e => e.Photo4)
                    .HasColumnName("photo_4")
                    .HasMaxLength(255);

                entity.Property(e => e.ReelNo).HasColumnName("reel_no");

                entity.Property(e => e.SamplingDate)
                    .HasColumnName("sampling_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SetBaseId).HasColumnName("set_base_id");

                entity.Property(e => e.SexId)
                    .IsRequired()
                    .HasColumnName("sex_id")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'U')");

                entity.Property(e => e.SpeciesId).HasColumnName("species_id");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TmpId).HasColumnName("TMP_id");

                entity.Property(e => e.TmpPredatorId).HasColumnName("TMP_predator_id");

                entity.Property(e => e.WeightCodeId)
                    .HasColumnName("weight_code_id")
                    .HasMaxLength(2);

                entity.Property(e => e.WeightGr).HasColumnName("weight_gr");

                entity.HasOne(d => d.EditorStaff)
                    .WithMany(p => p.FishEditorStaff)
                    .HasForeignKey(d => d.EditorStaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_fish_staff");

                entity.HasOne(d => d.EditorStaffId2Navigation)
                    .WithMany(p => p.FishEditorStaffId2Navigation)
                    .HasForeignKey(d => d.EditorStaffId2)
                    .HasConstraintName("FK_fish_staff_2");

                entity.HasOne(d => d.FishType)
                    .WithMany(p => p.Fish)
                    .HasForeignKey(d => d.FishTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_fish_fish_type");

                entity.HasOne(d => d.LengthCode)
                    .WithMany(p => p.FishLengthCode)
                    .HasForeignKey(d => d.LengthCodeId)
                    .HasConstraintName("FK_fish_length_code");

                entity.HasOne(d => d.LengthCodeId2Navigation)
                    .WithMany(p => p.FishLengthCodeId2Navigation)
                    .HasForeignKey(d => d.LengthCodeId2)
                    .HasConstraintName("FK_fish_length_code_2");

                entity.HasOne(d => d.LengthCodeId3Navigation)
                    .WithMany(p => p.FishLengthCodeId3Navigation)
                    .HasForeignKey(d => d.LengthCodeId3)
                    .HasConstraintName("FK_fish_length_code_3");

                entity.HasOne(d => d.SetBase)
                    .WithMany(p => p.Fish)
                    .HasForeignKey(d => d.SetBaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_fish_set_base");

                entity.HasOne(d => d.Sex)
                    .WithMany(p => p.Fish)
                    .HasForeignKey(d => d.SexId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_fish_sex");

                entity.HasOne(d => d.Species)
                    .WithMany(p => p.Fish)
                    .HasForeignKey(d => d.SpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_fish_species");

                entity.HasOne(d => d.WeightCode)
                    .WithMany(p => p.Fish)
                    .HasForeignKey(d => d.WeightCodeId)
                    .HasConstraintName("FK_fish_weight_code");
            });

            modelBuilder.Entity<FishForageIndividualLink>(entity =>
            {
                entity.HasKey(e => new { e.FishId, e.ForageIndividualId });

                entity.ToTable("fish_forage_individual_link", "QRY");

                entity.Property(e => e.FishId).HasColumnName("fish_id");

                entity.Property(e => e.ForageIndividualId).HasColumnName("forage_individual_id");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([date],getdate(),(0)))");

                entity.HasOne(d => d.Fish)
                    .WithMany(p => p.FishForageIndividualLink)
                    .HasForeignKey(d => d.FishId)
                    .HasConstraintName("FK_fish_forage_individual_link");

                entity.HasOne(d => d.ForageIndividual)
                    .WithMany(p => p.FishForageIndividualLink)
                    .HasForeignKey(d => d.ForageIndividualId)
                    .HasConstraintName("FK_fish_forage_individual_link_forage_individual");
            });

            modelBuilder.Entity<FishForageItemLink>(entity =>
            {
                entity.HasKey(e => new { e.FishId, e.ForageItemId });

                entity.ToTable("fish_forage_item_link", "QRY");

                entity.Property(e => e.FishId).HasColumnName("fish_id");

                entity.Property(e => e.ForageItemId).HasColumnName("forage_item_id");

                entity.HasOne(d => d.Fish)
                    .WithMany(p => p.FishForageItemLink)
                    .HasForeignKey(d => d.FishId)
                    .HasConstraintName("FK_fish_forage_item_link");

                entity.HasOne(d => d.ForageItem)
                    .WithMany(p => p.FishForageItemLink)
                    .HasForeignKey(d => d.ForageItemId)
                    .HasConstraintName("FK_fish_forage_item_link_forage_item");
            });

            modelBuilder.Entity<FishPreyIndividualLink>(entity =>
            {
                entity.HasKey(e => new { e.FishId, e.AnalysisStomachPreyIndividualId });

                entity.ToTable("fish_prey_individual_link", "QRY");

                entity.HasIndex(e => e.AnalysisStomachPreyIndividualId)
                    .HasName("UX2_fish_prey_individual_link")
                    .IsUnique();

                entity.HasIndex(e => e.FishId)
                    .HasName("UX1_fish_prey_individual_link")
                    .IsUnique();

                entity.Property(e => e.FishId).HasColumnName("fish_id");

                entity.Property(e => e.AnalysisStomachPreyIndividualId).HasColumnName("analysis_stomach_prey_individual_id");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([date],getdate(),(0)))");

                entity.HasOne(d => d.AnalysisStomachPreyIndividual)
                    .WithOne(p => p.FishPreyIndividualLink)
                    .HasForeignKey<FishPreyIndividualLink>(d => d.AnalysisStomachPreyIndividualId)
                    .HasConstraintName("FK_fish_prey_individual_link_analysis_stomach_prey_individual");

                entity.HasOne(d => d.Fish)
                    .WithOne(p => p.FishPreyIndividualLink)
                    .HasForeignKey<FishPreyIndividualLink>(d => d.FishId)
                    .HasConstraintName("FK_fish_prey_individual_link_fish");
            });

            modelBuilder.Entity<FishPreyItemLink>(entity =>
            {
                entity.HasKey(e => new { e.FishId, e.AnalysisStomachPreyItemId });

                entity.ToTable("fish_prey_item_link", "QRY");

                entity.Property(e => e.FishId).HasColumnName("fish_id");

                entity.Property(e => e.AnalysisStomachPreyItemId).HasColumnName("analysis_stomach_prey_item_id");

                entity.HasOne(d => d.AnalysisStomachPreyItem)
                    .WithMany(p => p.FishPreyItemLink)
                    .HasForeignKey(d => d.AnalysisStomachPreyItemId)
                    .HasConstraintName("FK_fish_prey_item_link_analysis_stomach_prey_item");

                entity.HasOne(d => d.Fish)
                    .WithMany(p => p.FishPreyItemLink)
                    .HasForeignKey(d => d.FishId)
                    .HasConstraintName("FK_fish_prey_item_link_fish");
            });

            modelBuilder.Entity<FishType>(entity =>
            {
                entity.ToTable("fish_type", "REF");

                entity.HasIndex(e => e.FishTypeDesc)
                    .HasName("UX_fish_type")
                    .IsUnique();

                entity.Property(e => e.FishTypeId)
                    .HasColumnName("fish_type_id")
                    .HasMaxLength(1)
                    .ValueGeneratedNever();

                entity.Property(e => e.FishTypeDesc)
                    .IsRequired()
                    .HasColumnName("fish_type_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ForageIndividual>(entity =>
            {
                entity.ToTable("forage_individual", "BIO");

                entity.HasIndex(e => e.ForageItemId)
                    .HasName("IX_forage_individual_item");

                entity.HasIndex(e => e.LengthCodeId1)
                    .HasName("IX_forage_individual_length_code_1");

                entity.HasIndex(e => e.LengthCodeId2)
                    .HasName("IX_forage_individual_length_code_2");

                entity.HasIndex(e => e.LengthCodeId3)
                    .HasName("IX_forage_individual_length_code_3");

                entity.HasIndex(e => e.SexId)
                    .HasName("IX_forage_individual_sex");

                entity.Property(e => e.ForageIndividualId).HasColumnName("forage_individual_id");

                entity.Property(e => e.CollectionReference)
                    .HasColumnName("collection_reference")
                    .HasMaxLength(50);

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([date],getdate(),(0)))");

                entity.Property(e => e.EnteredBy)
                    .HasColumnName("entered_by")
                    .HasMaxLength(50);

                entity.Property(e => e.ForageItemId).HasColumnName("forage_item_id");

                entity.Property(e => e.LengthCodeId1)
                    .HasColumnName("length_code_id_1")
                    .HasMaxLength(2);

                entity.Property(e => e.LengthCodeId2)
                    .HasColumnName("length_code_id_2")
                    .HasMaxLength(2);

                entity.Property(e => e.LengthCodeId3)
                    .HasColumnName("length_code_id_3")
                    .HasMaxLength(2);

                entity.Property(e => e.LengthMm1).HasColumnName("length_mm_1");

                entity.Property(e => e.LengthMm2).HasColumnName("length_mm_2");

                entity.Property(e => e.LengthMm3).HasColumnName("length_mm_3");

                entity.Property(e => e.Photo1)
                    .HasColumnName("photo_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Photo2)
                    .HasColumnName("photo_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Photo3)
                    .HasColumnName("photo_3")
                    .HasMaxLength(255);

                entity.Property(e => e.Photo4)
                    .HasColumnName("photo_4")
                    .HasMaxLength(255);

                entity.Property(e => e.PhotoXray)
                    .HasColumnName("photo_xray")
                    .HasMaxLength(255);

                entity.Property(e => e.PreservationComment).HasColumnName("preservation_comment");

                entity.Property(e => e.SexId)
                    .HasColumnName("sex_id")
                    .HasMaxLength(1);

                entity.Property(e => e.TmpId).HasColumnName("TMP_id");

                entity.Property(e => e.VerifiedBy)
                    .HasColumnName("verified_by")
                    .HasMaxLength(50);

                entity.Property(e => e.WeightGr).HasColumnName("weight_gr");

                entity.Property(e => e.WeightLossGr).HasColumnName("weight_loss_gr");

                entity.HasOne(d => d.ForageItem)
                    .WithMany(p => p.ForageIndividual)
                    .HasForeignKey(d => d.ForageItemId)
                    .HasConstraintName("FK_forage_individual_forage_item");

                entity.HasOne(d => d.LengthCodeId1Navigation)
                    .WithMany(p => p.ForageIndividualLengthCodeId1Navigation)
                    .HasForeignKey(d => d.LengthCodeId1)
                    .HasConstraintName("FK_forage_individual_length_code_1");

                entity.HasOne(d => d.LengthCodeId2Navigation)
                    .WithMany(p => p.ForageIndividualLengthCodeId2Navigation)
                    .HasForeignKey(d => d.LengthCodeId2)
                    .HasConstraintName("FK_forage_individual_length_code_2");

                entity.HasOne(d => d.LengthCodeId3Navigation)
                    .WithMany(p => p.ForageIndividualLengthCodeId3Navigation)
                    .HasForeignKey(d => d.LengthCodeId3)
                    .HasConstraintName("FK_forage_individual_length_code_3");

                entity.HasOne(d => d.Sex)
                    .WithMany(p => p.ForageIndividual)
                    .HasForeignKey(d => d.SexId)
                    .HasConstraintName("FK_forage_individual_sex");
            });

            modelBuilder.Entity<ForageItem>(entity =>
            {
                entity.ToTable("forage_item", "BIO");

                entity.HasIndex(e => e.ForageStateId);

                entity.HasIndex(e => e.PreyDevelopmentId);

                entity.HasIndex(e => e.SetBaseId)
                    .HasName("IX_forage_item_set_base");

                entity.HasIndex(e => e.SpeciesId);

                entity.HasIndex(e => new { e.SetBaseId, e.PreyDevelopmentId, e.ForageStateId, e.SpeciesId })
                    .HasName("UX_forage_item")
                    .IsUnique();

                entity.Property(e => e.ForageItemId).HasColumnName("forage_item_id");

                entity.Property(e => e.CollectionReference)
                    .HasColumnName("collection_reference")
                    .HasMaxLength(30);

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.ForageStateId)
                    .HasColumnName("forage_state_id")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.IndividualsNb).HasColumnName("individuals_nb");

                entity.Property(e => e.PreyDevelopmentId)
                    .IsRequired()
                    .HasColumnName("prey_development_id")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'U')");

                entity.Property(e => e.SetBaseId).HasColumnName("set_base_id");

                entity.Property(e => e.SpeciesId).HasColumnName("species_id");

                entity.Property(e => e.TmpId).HasColumnName("TMP_id");

                entity.Property(e => e.TotalWeightGr).HasColumnName("total_weight_gr");

                entity.Property(e => e.WeightLossGr).HasColumnName("weight_loss_gr");

                entity.HasOne(d => d.ForageState)
                    .WithMany(p => p.ForageItem)
                    .HasForeignKey(d => d.ForageStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_forage_item_forage_state");

                entity.HasOne(d => d.PreyDevelopment)
                    .WithMany(p => p.ForageItem)
                    .HasForeignKey(d => d.PreyDevelopmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_forage_item_prey_development");

                entity.HasOne(d => d.SetBase)
                    .WithMany(p => p.ForageItem)
                    .HasForeignKey(d => d.SetBaseId)
                    .HasConstraintName("FK_forage_item_set_base");

                entity.HasOne(d => d.Species)
                    .WithMany(p => p.ForageItem)
                    .HasForeignKey(d => d.SpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_forage_item_species");
            });

            modelBuilder.Entity<ForageState>(entity =>
            {
                entity.ToTable("forage_state", "REF");

                entity.HasIndex(e => e.ForageStateDesc)
                    .HasName("UX_forage_state")
                    .IsUnique();

                entity.Property(e => e.ForageStateId).HasColumnName("forage_state_id");

                entity.Property(e => e.ForageStateDesc)
                    .IsRequired()
                    .HasColumnName("forage_state_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FreezerLocation>(entity =>
            {
                entity.ToTable("freezer_location", "REF");

                entity.HasIndex(e => e.FreezerLocationName)
                    .HasName("UX_freezer_location")
                    .IsUnique();

                entity.HasIndex(e => e.InventoryLocationId)
                    .HasName("IX_freezer_location_location");

                entity.HasIndex(e => new { e.FreezerLocationId, e.InventoryLocationId })
                    .HasName("UX_freezer_location_sample_base")
                    .IsUnique();

                entity.Property(e => e.FreezerLocationId)
                    .HasColumnName("freezer_location_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FreezerLocationDesc)
                    .IsRequired()
                    .HasColumnName("freezer_location_desc")
                    .HasMaxLength(100);

                entity.Property(e => e.FreezerLocationName)
                    .IsRequired()
                    .HasColumnName("freezer_location_name")
                    .HasMaxLength(50);

                entity.Property(e => e.InventoryLocationId).HasColumnName("inventory_location_id");

                entity.Property(e => e.InventoryLocationIdOld)
                    .HasColumnName("inventory_location_id_OLD")
                    .HasMaxLength(50);

                entity.Property(e => e.PurchaseDate)
                    .HasColumnName("purchase_date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.InventoryLocation)
                    .WithMany(p => p.FreezerLocation)
                    .HasForeignKey(d => d.InventoryLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_freezer_location_inventory_location");
            });

            modelBuilder.Entity<FreightOrphanLink>(entity =>
            {
                entity.HasKey(e => new { e.SamplingFreightId, e.SampleOrphanId });

                entity.ToTable("freight_orphan_link", "QRY");

                entity.Property(e => e.SamplingFreightId).HasColumnName("sampling_freight_id");

                entity.Property(e => e.SampleOrphanId).HasColumnName("sample_orphan_id");

                entity.HasOne(d => d.SamplingFreight)
                    .WithMany(p => p.FreightOrphanLink)
                    .HasForeignKey(d => d.SamplingFreightId)
                    .HasConstraintName("FK_freight_orphan_link_sampling_freight");
            });

            modelBuilder.Entity<FreightSampleLink>(entity =>
            {
                entity.HasKey(e => new { e.SamplingFreightId, e.SampleBaseId });

                entity.ToTable("freight_sample_link", "QRY");

                entity.Property(e => e.SamplingFreightId).HasColumnName("sampling_freight_id");

                entity.Property(e => e.SampleBaseId).HasColumnName("sample_base_id");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VolumeSamplingFreightId)
                    .IsRequired()
                    .HasColumnName("volume_sampling_freight_id")
                    .HasMaxLength(1);

                entity.HasOne(d => d.SampleBase)
                    .WithMany(p => p.FreightSampleLink)
                    .HasForeignKey(d => d.SampleBaseId)
                    .HasConstraintName("FK_freight_sample_link_sample_base");

                entity.HasOne(d => d.SamplingFreight)
                    .WithMany(p => p.FreightSampleLink)
                    .HasForeignKey(d => d.SamplingFreightId)
                    .HasConstraintName("FK_freight_sample_link_sampling_freight");
            });

            modelBuilder.Entity<FreightSamplingLink>(entity =>
            {
                entity.HasKey(e => new { e.SamplingFreightId, e.SamplingId });

                entity.ToTable("freight_sampling_link", "QRY");

                entity.HasIndex(e => e.VolumeSamplingFreightId)
                    .HasName("IX_freight_sampling_link_volume");

                entity.Property(e => e.SamplingFreightId).HasColumnName("sampling_freight_id");

                entity.Property(e => e.SamplingId).HasColumnName("sampling_id");

                entity.Property(e => e.VolumeSamplingFreightId)
                    .IsRequired()
                    .HasColumnName("volume_sampling_freight_id")
                    .HasMaxLength(1);

                entity.HasOne(d => d.SamplingFreight)
                    .WithMany(p => p.FreightSamplingLink)
                    .HasForeignKey(d => d.SamplingFreightId)
                    .HasConstraintName("FK_freight_sampling_link_sampling_freight");

                entity.HasOne(d => d.Sampling)
                    .WithMany(p => p.FreightSamplingLink)
                    .HasForeignKey(d => d.SamplingId)
                    .HasConstraintName("FK_freight_sampling_link_sampling");

                entity.HasOne(d => d.VolumeSamplingFreight)
                    .WithMany(p => p.FreightSamplingLink)
                    .HasForeignKey(d => d.VolumeSamplingFreightId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_freight_sampling_link_volume_sampling_freight");
            });

            modelBuilder.Entity<FreightType>(entity =>
            {
                entity.ToTable("freight_type", "BIO");

                entity.HasIndex(e => e.FreightTypeDesc)
                    .HasName("UX_freight_type")
                    .IsUnique();

                entity.Property(e => e.FreightTypeId)
                    .HasColumnName("freight_type_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FreightTypeDesc)
                    .IsRequired()
                    .HasColumnName("freight_type_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FullnessCoeff>(entity =>
            {
                entity.ToTable("fullness_coeff", "REF");

                entity.HasIndex(e => e.FullnessCoeffDesc)
                    .HasName("UX_fullness_coeff")
                    .IsUnique();

                entity.Property(e => e.FullnessCoeffId).HasColumnName("fullness_coeff_id");

                entity.Property(e => e.FullnessCoeffDesc)
                    .IsRequired()
                    .HasColumnName("fullness_coeff_desc")
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<Gear>(entity =>
            {
                entity.ToTable("gear", "REF");

                entity.HasIndex(e => e.GearDesc)
                    .HasName("UX_gear")
                    .IsUnique();

                entity.Property(e => e.GearId)
                    .HasColumnName("gear_id")
                    .HasMaxLength(1)
                    .ValueGeneratedNever();

                entity.Property(e => e.GearDesc)
                    .IsRequired()
                    .HasColumnName("gear_desc")
                    .HasMaxLength(50);

                entity.Property(e => e.GearTubs)
                    .HasColumnName("gear_TUBS")
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<Haplotype>(entity =>
            {
                entity.HasKey(e => e.HaplotypeCodeId);

                entity.ToTable("haplotype", "REF");

                entity.HasIndex(e => e.HaplotypeCodeDesc)
                    .HasName("UX_haplotype")
                    .IsUnique();

                entity.Property(e => e.HaplotypeCodeId)
                    .HasColumnName("haplotype_code_id")
                    .HasMaxLength(6)
                    .ValueGeneratedNever();

                entity.Property(e => e.HaplotypeCodeDesc)
                    .IsRequired()
                    .HasColumnName("haplotype_code_desc")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<HardMaterial>(entity =>
            {
                entity.ToTable("hard_material", "REF");

                entity.HasIndex(e => e.HardMaterialDesc)
                    .HasName("UX_hard_material")
                    .IsUnique();

                entity.Property(e => e.HardMaterialId)
                    .HasColumnName("hard_material_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.HardMaterialDesc)
                    .IsRequired()
                    .HasColumnName("hard_material_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<HardMaterialOtolith>(entity =>
            {
                entity.ToTable("hard_material_otolith", "REF");

                entity.HasIndex(e => e.HardMaterialOtolithDesc)
                    .HasName("UX_hard_material_otolith")
                    .IsUnique();

                entity.Property(e => e.HardMaterialOtolithId).HasColumnName("hard_material_otolith_id");

                entity.Property(e => e.HardMaterialOtolithDesc)
                    .IsRequired()
                    .HasColumnName("hard_material_otolith_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<HistologyCell>(entity =>
            {
                entity.ToTable("histology_cell", "REF");

                entity.HasIndex(e => e.HistologyCellDesc)
                    .HasName("UX_histology_cell")
                    .IsUnique();

                entity.Property(e => e.HistologyCellId)
                    .HasColumnName("histology_cell_id")
                    .HasMaxLength(3)
                    .ValueGeneratedNever();

                entity.Property(e => e.HistologyCellDesc)
                    .IsRequired()
                    .HasColumnName("histology_cell_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<HistoryFish>(entity =>
            {
                entity.ToTable("history_fish", "ADMIN");

                entity.HasIndex(e => e.FishId)
                    .HasName("IX_history_fish");

                entity.Property(e => e.HistoryFishId).HasColumnName("history_fish_id");

                entity.Property(e => e.FishId).HasColumnName("fish_id");

                entity.Property(e => e.LengthCodeId)
                    .HasColumnName("length_code_id")
                    .HasMaxLength(2);

                entity.Property(e => e.LengthMm).HasColumnName("length_mm");

                entity.Property(e => e.SexId)
                    .IsRequired()
                    .HasColumnName("sex_id")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'U')");

                entity.Property(e => e.SpeciesId).HasColumnName("species_id");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WeightCodeId)
                    .HasColumnName("weight_code_id")
                    .HasMaxLength(2);

                entity.Property(e => e.WeightGr).HasColumnName("weight_gr");

                entity.HasOne(d => d.Fish)
                    .WithMany(p => p.HistoryFish)
                    .HasForeignKey(d => d.FishId)
                    .HasConstraintName("FK_history_fish_fish");
            });

            modelBuilder.Entity<HistorySampleBase>(entity =>
            {
                entity.ToTable("history_sample_base", "ADMIN");

                entity.HasIndex(e => e.SampleBaseId)
                    .HasName("IX_history_sample_base");

                entity.Property(e => e.HistorySampleBaseId).HasColumnName("history_sample_base_id");

                entity.Property(e => e.FreezerLocationId).HasColumnName("freezer_location_id");

                entity.Property(e => e.InventoryDate)
                    .HasColumnName("inventory_date")
                    .HasColumnType("date");

                entity.Property(e => e.InventoryLocationId).HasColumnName("inventory_location_id");

                entity.Property(e => e.IsAvailable).HasColumnName("is_available");

                entity.Property(e => e.IsDiscarded).HasColumnName("is_discarded");

                entity.Property(e => e.IsLost).HasColumnName("is_lost");

                entity.Property(e => e.LocationDate)
                    .HasColumnName("location_date")
                    .HasColumnType("date");

                entity.Property(e => e.LocationDetails)
                    .HasColumnName("location_details")
                    .HasMaxLength(250);

                entity.Property(e => e.QualityStaffId).HasColumnName("quality_staff_id");

                entity.Property(e => e.SampleBaseId).HasColumnName("sample_base_id");

                entity.Property(e => e.StorageQualityId)
                    .IsRequired()
                    .HasColumnName("storage_quality_id")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'U')");

                entity.Property(e => e.TissueConditionId)
                    .IsRequired()
                    .HasColumnName("tissue_condition_id")
                    .HasMaxLength(2);

                entity.Property(e => e.TissuePositionId)
                    .IsRequired()
                    .HasColumnName("tissue_position_id")
                    .HasMaxLength(1);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.SampleBase)
                    .WithMany(p => p.HistorySampleBase)
                    .HasForeignKey(d => d.SampleBaseId)
                    .HasConstraintName("FK_history_sample_base_sample_base");
            });

            modelBuilder.Entity<InventoryLocationOld>(entity =>
            {
                entity.HasKey(e => e.InventoryLocationId);

                entity.ToTable("inventory_location_OLD", "REF");

                entity.Property(e => e.InventoryLocationId)
                    .HasColumnName("inventory_location_id")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactAddress)
                    .HasColumnName("contact_address")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactEmail)
                    .HasColumnName("contact_email")
                    .HasMaxLength(100);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ContactPhone)
                    .HasColumnName("contact_phone")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<KitItem>(entity =>
            {
                entity.ToTable("kit_item", "STOCK");

                entity.HasIndex(e => new { e.ItemId, e.KitTypeId })
                    .HasName("UX_stock_kit_item")
                    .IsUnique();

                entity.Property(e => e.KitItemId).HasColumnName("kit_item_id");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.KitTypeId).HasColumnName("kit_type_id");

                entity.Property(e => e.NbItems).HasColumnName("nb_items");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.KitItem)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_stock_kit_item_ref_item");

                entity.HasOne(d => d.KitType)
                    .WithMany(p => p.KitItem)
                    .HasForeignKey(d => d.KitTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_stock_kit_item_ref_stock_kit");
            });

            modelBuilder.Entity<KitSamplingLink>(entity =>
            {
                entity.HasKey(e => new { e.SamplingId, e.SamplingKitId });

                entity.ToTable("kit_sampling_link", "QRY");

                entity.HasIndex(e => e.KitSamplingLinkId)
                    .HasName("UX_kit_sampling_link")
                    .IsUnique();

                entity.HasIndex(e => e.SamplingId)
                    .HasName("IX_kit_sample_link_sampling");

                entity.HasIndex(e => e.SamplingKitId)
                    .HasName("IX_kit_sample_link_kit");

                entity.Property(e => e.SamplingId).HasColumnName("sampling_id");

                entity.Property(e => e.SamplingKitId).HasColumnName("sampling_kit_id");

                entity.Property(e => e.KitSamplingLinkId)
                    .HasColumnName("kit_sampling_link_id")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.Sampling)
                    .WithMany(p => p.KitSamplingLink)
                    .HasForeignKey(d => d.SamplingId)
                    .HasConstraintName("FK_kit_sampling_link_sampling");

                entity.HasOne(d => d.SamplingKit)
                    .WithMany(p => p.KitSamplingLink)
                    .HasForeignKey(d => d.SamplingKitId)
                    .HasConstraintName("FK_kit_sample_link_sampling_kit");
            });

            modelBuilder.Entity<LaboratoryOld>(entity =>
            {
                entity.HasKey(e => e.LaboratoryId);

                entity.ToTable("laboratory_OLD", "REF");

                entity.HasIndex(e => e.LaboratoryDesc)
                    .HasName("UX_laboratory")
                    .IsUnique();

                entity.Property(e => e.LaboratoryId)
                    .HasColumnName("laboratory_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LaboratoryAddress)
                    .HasColumnName("laboratory_address")
                    .HasColumnType("text");

                entity.Property(e => e.LaboratoryDesc)
                    .IsRequired()
                    .HasColumnName("laboratory_desc")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<LengthCode>(entity =>
            {
                entity.ToTable("length_code", "REF");

                entity.HasIndex(e => e.LengthCodeDesc)
                    .HasName("UX_length_code")
                    .IsUnique();

                entity.Property(e => e.LengthCodeId)
                    .HasColumnName("length_code_id")
                    .HasMaxLength(2)
                    .ValueGeneratedNever();

                entity.Property(e => e.LengthCodeDesc)
                    .IsRequired()
                    .HasColumnName("length_code_desc")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<LipidFatty>(entity =>
            {
                entity.ToTable("lipid_fatty", "REF");

                entity.HasIndex(e => e.CommonName)
                    .HasName("UX_lipid_fatty_common")
                    .IsUnique()
                    .HasFilter("([common_name] IS NOT NULL)");

                entity.HasIndex(e => e.SystematicName)
                    .HasName("UX_lipid_fatty_systematic")
                    .IsUnique()
                    .HasFilter("([SYSTEMATIC_NAME] IS NOT NULL)");

                entity.Property(e => e.LipidFattyId)
                    .HasColumnName("lipid_fatty_id")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.CommonCode)
                    .HasColumnName("common_code")
                    .HasMaxLength(10);

                entity.Property(e => e.CommonName)
                    .HasColumnName("common_name")
                    .HasMaxLength(100);

                entity.Property(e => e.LipidGroup)
                    .IsRequired()
                    .HasColumnName("lipid_group")
                    .HasMaxLength(10);

                entity.Property(e => e.SystematicName)
                    .HasColumnName("systematic_name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LipidHomogenization>(entity =>
            {
                entity.ToTable("lipid_homogenization", "REF");

                entity.HasIndex(e => e.LipidHomogenizationDesc)
                    .HasName("UX_lipid_homogenization")
                    .IsUnique();

                entity.Property(e => e.LipidHomogenizationId)
                    .HasColumnName("lipid_homogenization_id")
                    .HasMaxLength(1)
                    .ValueGeneratedNever();

                entity.Property(e => e.LipidHomogenizationDesc)
                    .IsRequired()
                    .HasColumnName("lipid_homogenization_desc")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("location", "REF");

                entity.HasIndex(e => e.CountryId)
                    .HasName("IX_location_country");

                entity.HasIndex(e => e.LocationName)
                    .HasName("UX_location")
                    .IsUnique();

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.ContactStaffId).HasColumnName("contact_staff_id");

                entity.Property(e => e.CountryId)
                    .IsRequired()
                    .HasColumnName("country_id")
                    .HasMaxLength(2);

                entity.Property(e => e.IsLaboratory).HasColumnName("is_laboratory");

                entity.Property(e => e.IsSampleOwner).HasColumnName("is_sample_owner");

                entity.Property(e => e.IsStockManager).HasColumnName("is_stock_manager");

                entity.Property(e => e.IsStorageInventory).HasColumnName("is_storage_inventory");

                entity.Property(e => e.LocationAddress)
                    .HasColumnName("location_address")
                    .HasMaxLength(250);

                entity.Property(e => e.LocationContactOld)
                    .HasColumnName("location_contact_OLD")
                    .HasMaxLength(100);

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasColumnName("location_name")
                    .HasMaxLength(100);

                entity.Property(e => e.NormalizedName)
                    .HasColumnName("normalized_name")
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(lower(replace(replace(replace([location_name],'''',''),'-',''),' ','')))");

                entity.Property(e => e.TmpId).HasColumnName("TMP_id");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_location_country");
            });

            modelBuilder.Entity<Longhurst>(entity =>
            {
                entity.ToTable("longhurst", "REF");

                entity.HasIndex(e => e.ProvinceCode)
                    .HasName("UX_longhurst")
                    .IsUnique();

                entity.Property(e => e.LonghurstId)
                    .HasColumnName("longhurst_id")
                    .HasMaxLength(4)
                    .ValueGeneratedNever();

                entity.Property(e => e.ProvinceCode)
                    .IsRequired()
                    .HasColumnName("province_code")
                    .HasMaxLength(4);

                entity.Property(e => e.ProvinceDesc)
                    .IsRequired()
                    .HasColumnName("province_desc")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MagoStage>(entity =>
            {
                entity.ToTable("MAGO_stage", "REF");

                entity.HasIndex(e => e.MagoStageDesc)
                    .HasName("UX_MAGO_stage")
                    .IsUnique();

                entity.Property(e => e.MagoStageId)
                    .HasColumnName("MAGO_stage_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MagoStageDesc)
                    .IsRequired()
                    .HasColumnName("MAGO_stage_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ManagementEntity>(entity =>
            {
                entity.ToTable("management_entity", "REF");

                entity.HasIndex(e => e.ManagementEntityName)
                    .HasName("UX_management_entity")
                    .IsUnique();

                entity.Property(e => e.ManagementEntityId)
                    .HasColumnName("management_entity_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CountryId)
                    .IsRequired()
                    .HasColumnName("country_id")
                    .HasMaxLength(2);

                entity.Property(e => e.ManagementEntityDesc).HasColumnName("management_entity_desc");

                entity.Property(e => e.ManagementEntityName)
                    .IsRequired()
                    .HasColumnName("management_entity_name")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.ManagementEntity)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_management_entity_country");
            });

            modelBuilder.Entity<MicroscopicStage>(entity =>
            {
                entity.ToTable("microscopic_stage", "REF");

                entity.HasIndex(e => e.MicroscopicStageDesc)
                    .HasName("UX_microscopic_stage")
                    .IsUnique();

                entity.Property(e => e.MicroscopicStageId)
                    .HasColumnName("microscopic_stage_id")
                    .HasMaxLength(3)
                    .ValueGeneratedNever();

                entity.Property(e => e.MicroscopicStageDesc)
                    .IsRequired()
                    .HasColumnName("microscopic_stage_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Movement>(entity =>
            {
                entity.ToTable("movement", "STOCK");

                entity.HasIndex(e => e.FromLocationId)
                    .HasName("IX_movement_location_from");

                entity.HasIndex(e => e.FromStaffId)
                    .HasName("IX_movement_staff_from");

                entity.HasIndex(e => e.ItemId)
                    .HasName("IX_movement_item");

                entity.HasIndex(e => e.ToLocationId)
                    .HasName("IX_movement_location_to");

                entity.HasIndex(e => e.ToStaffId)
                    .HasName("IX_movement_staff_id");

                entity.Property(e => e.MovementId).HasColumnName("movement_id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorName)
                    .IsRequired()
                    .HasColumnName("creator_name")
                    .HasMaxLength(50);

                entity.Property(e => e.FromLocationId).HasColumnName("from_location_id");

                entity.Property(e => e.FromStaffId).HasColumnName("from_staff_id");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.MovementDate)
                    .HasColumnName("movement_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.StockTypeId).HasColumnName("stock_type_id");

                entity.Property(e => e.ToLocationId).HasColumnName("to_location_id");

                entity.Property(e => e.ToStaffId).HasColumnName("to_staff_id");

                entity.Property(e => e.TransportedBy)
                    .HasColumnName("transported_by")
                    .HasMaxLength(255);

                entity.HasOne(d => d.FromLocation)
                    .WithMany(p => p.MovementFromLocation)
                    .HasForeignKey(d => d.FromLocationId)
                    .HasConstraintName("FK_movement_location_from");

                entity.HasOne(d => d.FromStaff)
                    .WithMany(p => p.MovementFromStaff)
                    .HasForeignKey(d => d.FromStaffId)
                    .HasConstraintName("FK_movement_staff_from");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Movement)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_movement_ref_item");

                entity.HasOne(d => d.StockType)
                    .WithMany(p => p.Movement)
                    .HasForeignKey(d => d.StockTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_movement_ref_stock_type");

                entity.HasOne(d => d.ToLocation)
                    .WithMany(p => p.MovementToLocation)
                    .HasForeignKey(d => d.ToLocationId)
                    .HasConstraintName("FK_movement_location_to");

                entity.HasOne(d => d.ToStaff)
                    .WithMany(p => p.MovementToStaff)
                    .HasForeignKey(d => d.ToStaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_movement_staff_to");
            });

            modelBuilder.Entity<MovementKit>(entity =>
            {
                entity.ToTable("movement_kit", "STOCK");

                entity.Property(e => e.MovementKitId).HasColumnName("movement_kit_id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorName)
                    .IsRequired()
                    .HasColumnName("creator_name")
                    .HasMaxLength(50);

                entity.Property(e => e.FromLocationId).HasColumnName("from_location_id");

                entity.Property(e => e.FromStaffId).HasColumnName("from_staff_id");

                entity.Property(e => e.KitTypeId).HasColumnName("kit_type_id");

                entity.Property(e => e.MovementDate)
                    .HasColumnName("movement_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.StockTypeId).HasColumnName("stock_type_id");

                entity.Property(e => e.ToLocationId).HasColumnName("to_location_id");

                entity.Property(e => e.ToStaffId).HasColumnName("to_staff_id");

                entity.Property(e => e.TransportedBy)
                    .IsRequired()
                    .HasColumnName("transported_by")
                    .HasMaxLength(255);

                entity.HasOne(d => d.KitType)
                    .WithMany(p => p.MovementKit)
                    .HasForeignKey(d => d.KitTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_movement_kit_ref_kit_type");

                entity.HasOne(d => d.ToLocation)
                    .WithMany(p => p.MovementKit)
                    .HasForeignKey(d => d.ToLocationId)
                    .HasConstraintName("FK_movement_kit_location_to");

                entity.HasOne(d => d.ToStaff)
                    .WithMany(p => p.MovementKit)
                    .HasForeignKey(d => d.ToStaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_movement_kit_staff_to");
            });

            modelBuilder.Entity<Objectives>(entity =>
            {
                entity.ToTable("objectives", "MOU");

                entity.HasIndex(e => e.CountryId)
                    .HasName("IX_objectives_country");

                entity.Property(e => e.ObjectivesId).HasColumnName("objectives_id");

                entity.Property(e => e.BiologicalKitNb).HasColumnName("biological_kit_nb");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CountryId)
                    .IsRequired()
                    .HasColumnName("country_id")
                    .HasMaxLength(2);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FromDate)
                    .HasColumnName("from_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MouContractName)
                    .HasColumnName("MOU_contract_name")
                    .HasMaxLength(100);

                entity.Property(e => e.MouContractPath).HasColumnName("MOU_contract_path");

                entity.Property(e => e.SampleShipmentLastDate)
                    .HasColumnName("sample_shipment_last_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SeedingKitNb).HasColumnName("seeding_kit_nb");

                entity.Property(e => e.SignatureDate)
                    .HasColumnName("signature_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TagDataLastDate)
                    .HasColumnName("tag_data_last_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ToDate)
                    .HasColumnName("to_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TotalSpecimens).HasColumnName("total_specimens");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Objectives)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_objectives_country");
            });

            modelBuilder.Entity<ObjectivesBs>(entity =>
            {
                entity.ToTable("objectives_BS", "MOU");

                entity.HasIndex(e => e.TissuePositionId)
                    .HasName("IX_objectives_BS_position");

                entity.HasIndex(e => e.TissueTypeId)
                    .HasName("IX_objectives_BS_type");

                entity.HasIndex(e => new { e.ObjectivesSpecimenId, e.TissueTypeId, e.TissuePositionId })
                    .HasName("UX_objectives_BS")
                    .IsUnique();

                entity.Property(e => e.ObjectivesBsId).HasColumnName("objectives_BS_id");

                entity.Property(e => e.NbSamples).HasColumnName("nb_samples");

                entity.Property(e => e.ObjectivesSpecimenId).HasColumnName("objectives_specimen_id");

                entity.Property(e => e.TissuePositionId)
                    .IsRequired()
                    .HasColumnName("tissue_position_id")
                    .HasMaxLength(2);

                entity.Property(e => e.TissueTypeId)
                    .IsRequired()
                    .HasColumnName("tissue_type_id")
                    .HasMaxLength(2);

                entity.HasOne(d => d.ObjectivesSpecimen)
                    .WithMany(p => p.ObjectivesBs)
                    .HasForeignKey(d => d.ObjectivesSpecimenId)
                    .HasConstraintName("FK_objectives_BS_objectives_specimen");

                entity.HasOne(d => d.TissuePosition)
                    .WithMany(p => p.ObjectivesBs)
                    .HasForeignKey(d => d.TissuePositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_objectives_BS_tissue_position");

                entity.HasOne(d => d.TissueType)
                    .WithMany(p => p.ObjectivesBs)
                    .HasForeignKey(d => d.TissueTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_objectives_BS_tissue_type");

                entity.HasOne(d => d.Tissue)
                    .WithMany(p => p.ObjectivesBs)
                    .HasPrincipalKey(p => new { p.TissuePositionId, p.TissueTypeId })
                    .HasForeignKey(d => new { d.TissuePositionId, d.TissueTypeId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_objectives_BS_position_sample_type");
            });

            modelBuilder.Entity<ObjectivesSpecimen>(entity =>
            {
                entity.ToTable("objectives_specimen", "MOU");

                entity.HasIndex(e => e.ObjectivesId)
                    .HasName("IX_objectives_specimen");

                entity.HasIndex(e => e.SpeciesId)
                    .HasName("IX_objectives_specimen_species");

                entity.HasIndex(e => new { e.ObjectivesId, e.SpeciesId })
                    .HasName("UX_objectives_specimen")
                    .IsUnique();

                entity.Property(e => e.ObjectivesSpecimenId).HasColumnName("objectives_specimen_id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.NbSpecimens).HasColumnName("nb_specimens");

                entity.Property(e => e.ObjectivesId).HasColumnName("objectives_id");

                entity.Property(e => e.SpeciesId).HasColumnName("species_id");

                entity.HasOne(d => d.Objectives)
                    .WithMany(p => p.ObjectivesSpecimen)
                    .HasForeignKey(d => d.ObjectivesId)
                    .HasConstraintName("FK_objectives_specimen_objectives");

                entity.HasOne(d => d.Species)
                    .WithMany(p => p.ObjectivesSpecimen)
                    .HasForeignKey(d => d.SpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_objectives_specimen_species");
            });

            modelBuilder.Entity<OldTrainingCourse>(entity =>
            {
                entity.HasKey(e => e.TrainingCourseId);

                entity.ToTable("OLD_training_course", "STAFF");

                entity.Property(e => e.TrainingCourseId).HasColumnName("training_course_id");

                entity.Property(e => e.TrainingId).HasColumnName("training_id");

                entity.Property(e => e.TrainingModuleId).HasColumnName("training_module_id");
            });

            modelBuilder.Entity<OtolithMarginType>(entity =>
            {
                entity.ToTable("otolith_margin_type", "REF");

                entity.HasIndex(e => e.OtolithMarginTypeDesc)
                    .HasName("UX_otolith_margin_type")
                    .IsUnique();

                entity.Property(e => e.OtolithMarginTypeId)
                    .HasColumnName("otolith_margin_type_id")
                    .HasMaxLength(1)
                    .ValueGeneratedNever();

                entity.Property(e => e.OtolithMarginTypeDesc)
                    .IsRequired()
                    .HasColumnName("otolith_margin_type_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OtolithSectionType>(entity =>
            {
                entity.ToTable("otolith_section_type", "REF");

                entity.HasIndex(e => e.OtolithSectionTypeDesc)
                    .HasName("UX_otolith_section_type")
                    .IsUnique();

                entity.Property(e => e.OtolithSectionTypeId)
                    .HasColumnName("otolith_section_type_id")
                    .HasMaxLength(2)
                    .ValueGeneratedNever();

                entity.Property(e => e.OtolithSectionTypeDesc)
                    .IsRequired()
                    .HasColumnName("otolith_section_type_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Parasite>(entity =>
            {
                entity.ToTable("parasite", "REF");

                entity.HasIndex(e => e.ParasiteDesc)
                    .HasName("UX_parasite")
                    .IsUnique();

                entity.Property(e => e.ParasiteId)
                    .HasColumnName("parasite_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ParasiteDesc)
                    .IsRequired()
                    .HasColumnName("parasite_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ParasiteMode>(entity =>
            {
                entity.ToTable("parasite_mode", "REF");

                entity.HasIndex(e => e.ParasiteModeDesc)
                    .HasName("UX_parasite_mode")
                    .IsUnique();

                entity.Property(e => e.ParasiteModeId).HasColumnName("parasite_mode_id");

                entity.Property(e => e.ParasiteModeDesc)
                    .IsRequired()
                    .HasColumnName("parasite_mode_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Port>(entity =>
            {
                entity.ToTable("port", "REF");

                entity.HasIndex(e => e.CountryId)
                    .HasName("IX_port_country");

                entity.HasIndex(e => e.PortName)
                    .HasName("UX_port")
                    .IsUnique();

                entity.Property(e => e.PortId)
                    .HasColumnName("port_id")
                    .HasMaxLength(5)
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryId)
                    .HasColumnName("country_id")
                    .HasMaxLength(2);

                entity.Property(e => e.PortName)
                    .IsRequired()
                    .HasColumnName("port_name")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Port)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_port_country");
            });

            modelBuilder.Entity<PositionSampleType>(entity =>
            {
                entity.HasKey(e => e.PositionSampleId);

                entity.ToTable("position_sample_type", "QRY");

                entity.HasIndex(e => e.TissuePositionId)
                    .HasName("IX_position_sample_type_tissue_position");

                entity.HasIndex(e => e.TissueTypeId)
                    .HasName("IX_position_sample_type_tissue_type");

                entity.HasIndex(e => new { e.TissuePositionId, e.TissueTypeId })
                    .HasName("UX_position_sample_type")
                    .IsUnique();

                entity.Property(e => e.PositionSampleId).HasColumnName("position_sample_id");

                entity.Property(e => e.TissuePositionId)
                    .IsRequired()
                    .HasColumnName("tissue_position_id")
                    .HasMaxLength(2);

                entity.Property(e => e.TissueTypeId)
                    .IsRequired()
                    .HasColumnName("tissue_type_id")
                    .HasMaxLength(2);

                entity.HasOne(d => d.TissuePosition)
                    .WithMany(p => p.PositionSampleType)
                    .HasForeignKey(d => d.TissuePositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_position_sample_type_tissue_position");

                entity.HasOne(d => d.TissueType)
                    .WithMany(p => p.PositionSampleType)
                    .HasForeignKey(d => d.TissueTypeId)
                    .HasConstraintName("FK_position_sample_type_tissue_type");
            });

            modelBuilder.Entity<PreyDevelopment>(entity =>
            {
                entity.ToTable("prey_development", "REF");

                entity.HasIndex(e => e.PreyDevelopmentDesc)
                    .HasName("UX_prey_development")
                    .IsUnique();

                entity.Property(e => e.PreyDevelopmentId)
                    .HasColumnName("prey_development_id")
                    .HasMaxLength(2)
                    .ValueGeneratedNever();

                entity.Property(e => e.PreyDevelopmentDesc)
                    .IsRequired()
                    .HasColumnName("prey_development_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PreyDigestion>(entity =>
            {
                entity.ToTable("prey_digestion", "REF");

                entity.HasIndex(e => e.PreyDigestionDesc)
                    .HasName("UX_prey_digestion")
                    .IsUnique();

                entity.Property(e => e.PreyDigestionId).HasColumnName("prey_digestion_id");

                entity.Property(e => e.PreyDigestionDesc)
                    .IsRequired()
                    .HasColumnName("prey_digestion_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Publication>(entity =>
            {
                entity.ToTable("publication", "DOC");

                entity.HasIndex(e => e.Title)
                    .HasName("UX_publication")
                    .IsUnique();

                entity.Property(e => e.PublicationId).HasColumnName("publication_id");

                entity.Property(e => e.AuthorName)
                    .IsRequired()
                    .HasColumnName("author_name")
                    .HasMaxLength(250);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([date],getdate(),(0)))");

                entity.Property(e => e.Doi)
                    .HasColumnName("doi")
                    .HasMaxLength(150);

                entity.Property(e => e.IssuedDate)
                    .HasColumnName("issued_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PublisherName)
                    .IsRequired()
                    .HasColumnName("publisher_name")
                    .HasMaxLength(150);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(250);

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<PublicationAnalysisLink>(entity =>
            {
                entity.HasKey(e => new { e.PublicationId, e.AnalysisBaseId });

                entity.ToTable("publication_analysis_link", "QRY");

                entity.Property(e => e.PublicationId).HasColumnName("publication_id");

                entity.Property(e => e.AnalysisBaseId).HasColumnName("analysis_base_id");

                entity.HasOne(d => d.AnalysisBase)
                    .WithMany(p => p.PublicationAnalysisLink)
                    .HasForeignKey(d => d.AnalysisBaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_publication_analysis_link_analysis_base");

                entity.HasOne(d => d.Publication)
                    .WithMany(p => p.PublicationAnalysisLink)
                    .HasForeignKey(d => d.PublicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_publication_analysis_link_publication");
            });

            modelBuilder.Entity<PurchaseItem>(entity =>
            {
                entity.ToTable("purchase_item", "STOCK");

                entity.HasIndex(e => e.ItemId)
                    .HasName("IX_purchase_item_item");

                entity.HasIndex(e => e.ToLocationId)
                    .HasName("IX_purchase_item_location");

                entity.HasIndex(e => new { e.ItemId, e.ToLocationId })
                    .HasName("UX_purchase_item")
                    .IsUnique();

                entity.Property(e => e.PurchaseItemId).HasColumnName("purchase_item_id");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ToLocationId).HasColumnName("to_location_id");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.PurchaseItem)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_purchase_item_ref_item");

                entity.HasOne(d => d.ToLocation)
                    .WithMany(p => p.PurchaseItem)
                    .HasForeignKey(d => d.ToLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_purchase_item_location");
            });

            modelBuilder.Entity<Quality>(entity =>
            {
                entity.ToTable("quality", "REF");

                entity.HasIndex(e => e.QualityDesc)
                    .HasName("UX_sampler_quality")
                    .IsUnique();

                entity.Property(e => e.QualityId)
                    .HasColumnName("quality_id")
                    .HasMaxLength(1)
                    .ValueGeneratedNever();

                entity.Property(e => e.QualityDesc)
                    .IsRequired()
                    .HasColumnName("quality_desc")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<QueryList>(entity =>
            {
                entity.ToTable("QueryList", "QRY");

                entity.Property(e => e.QueryListId).ValueGeneratedNever();

                entity.Property(e => e.Caption).HasMaxLength(100);

                entity.Property(e => e.QueryName).HasMaxLength(50);
            });

            modelBuilder.Entity<RecapturedBird>(entity =>
            {
                entity.HasKey(e => new { e.NewBirdSpecimenId, e.FirstBirdSpecimenId });

                entity.ToTable("recaptured_bird", "QRY");

                entity.Property(e => e.NewBirdSpecimenId).HasColumnName("new_bird_specimen_id");

                entity.Property(e => e.FirstBirdSpecimenId).HasColumnName("first_bird_specimen_id");

                entity.HasOne(d => d.NewBirdSpecimen)
                    .WithMany(p => p.RecapturedBird)
                    .HasForeignKey(d => d.NewBirdSpecimenId)
                    .HasConstraintName("FK_recaptured_bird_fish_new");
            });

            modelBuilder.Entity<RefItem>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("ref_item", "STOCK");

                entity.HasIndex(e => e.ItemName)
                    .HasName("UX_ref_item")
                    .IsUnique();

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemDesc)
                    .HasColumnName("item_desc")
                    .HasMaxLength(255);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasColumnName("item_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<RefKitType>(entity =>
            {
                entity.HasKey(e => e.KitTypeId);

                entity.ToTable("ref_kit_type", "STOCK");

                entity.HasIndex(e => e.KitTypeName)
                    .HasName("UX_ref_kit_type")
                    .IsUnique();

                entity.Property(e => e.KitTypeId)
                    .HasColumnName("kit_type_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.KitTypeName)
                    .IsRequired()
                    .HasColumnName("kit_type_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RefStockType>(entity =>
            {
                entity.HasKey(e => e.StockTypeId);

                entity.ToTable("ref_stock_type", "STOCK");

                entity.HasIndex(e => e.StockTypeDesc)
                    .HasName("UX_ref_stocktype")
                    .IsUnique();

                entity.Property(e => e.StockTypeId).HasColumnName("stock_type_id");

                entity.Property(e => e.StockTypeDesc)
                    .IsRequired()
                    .HasColumnName("stock_type_desc")
                    .HasMaxLength(15);

                entity.Property(e => e.StockTypeFull).HasColumnName("stock_type_full");
            });

            modelBuilder.Entity<SampleBase>(entity =>
            {
                entity.ToTable("sample_base", "BIO");

                entity.HasIndex(e => e.FreezerLocationId)
                    .HasName("IX_sample_base_freezer");

                entity.HasIndex(e => e.InventoryLocationId)
                    .HasName("IX_sample_base_inventory_location");

                entity.HasIndex(e => e.InventoryStaffId)
                    .HasName("IX_sample_base");

                entity.HasIndex(e => e.IsAvailable);

                entity.HasIndex(e => e.IsTransfered);

                entity.HasIndex(e => e.StorageQualityId)
                    .HasName("IX_sample_base_storage_quality");

                entity.HasIndex(e => e.TissueConditionId)
                    .HasName("IX_sample_base_tissue_condition");

                entity.HasIndex(e => e.TissuePositionId)
                    .HasName("IX_sample_base_tissue_position");

                entity.HasIndex(e => e.TissueTypeId)
                    .HasName("IX_sample_base_tissue_type");

                entity.HasIndex(e => new { e.SampleBaseId, e.TissueTypeId })
                    .HasName("UX_Sample_base_2")
                    .IsUnique();

                entity.HasIndex(e => new { e.FishId, e.TissueTypeId, e.TissuePositionId, e.TissueConditionId })
                    .HasName("UX_sample_base")
                    .IsUnique();

                entity.Property(e => e.SampleBaseId).HasColumnName("sample_base_id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([date],getdate(),(0)))");

                entity.Property(e => e.FishId).HasColumnName("fish_id");

                entity.Property(e => e.FreezerLocationId).HasColumnName("freezer_location_id");

                entity.Property(e => e.InventoryDate)
                    .HasColumnName("inventory_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InventoryLocationId).HasColumnName("inventory_location_id");

                entity.Property(e => e.InventoryLocationIdOld)
                    .HasColumnName("inventory_location_id_OLD")
                    .HasMaxLength(50);

                entity.Property(e => e.InventoryStaffId).HasColumnName("inventory_staff_id");

                entity.Property(e => e.IsAnalyzed)
                    .HasColumnName("is_analyzed")
                    .HasComputedColumnSql("([DB].[IsAnalysis_Sample]([sample_base_id]))");

                entity.Property(e => e.IsAvailable).HasColumnName("is_available");

                entity.Property(e => e.IsDiscarded).HasColumnName("is_discarded");

                entity.Property(e => e.IsLost).HasColumnName("is_lost");

                entity.Property(e => e.IsPendingAnalysis)
                    .HasColumnName("is_pending_analysis")
                    .HasComputedColumnSql("([DB].[IsBeingAnalysed_Sample]([sample_base_id]))");

                entity.Property(e => e.IsTransfered).HasColumnName("is_transfered");

                entity.Property(e => e.LastLocationId).HasColumnName("last_location_id");

                entity.Property(e => e.LocationDate)
                    .HasColumnName("location_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocationDetails)
                    .HasColumnName("location_details")
                    .HasMaxLength(250);

                entity.Property(e => e.MissingDate)
                    .HasColumnName("missing_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OwnershipLocationId).HasColumnName("ownership_location_id");

                entity.Property(e => e.PriceUsd).HasColumnName("price_USD");

                entity.Property(e => e.QualityStaffId).HasColumnName("quality_staff_id");

                entity.Property(e => e.SampleNo)
                    .IsRequired()
                    .HasColumnName("sample_no")
                    .HasMaxLength(20);

                entity.Property(e => e.StorageQualityId)
                    .IsRequired()
                    .HasColumnName("storage_quality_id")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'U')");

                entity.Property(e => e.TissueConditionId)
                    .IsRequired()
                    .HasColumnName("tissue_condition_id")
                    .HasMaxLength(2);

                entity.Property(e => e.TissuePositionId)
                    .IsRequired()
                    .HasColumnName("tissue_position_id")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'X')");

                entity.Property(e => e.TissueTypeId)
                    .IsRequired()
                    .HasColumnName("tissue_type_id")
                    .HasMaxLength(2);

                entity.Property(e => e.TmpId).HasColumnName("TMP_id");

                entity.HasOne(d => d.Fish)
                    .WithMany(p => p.SampleBase)
                    .HasForeignKey(d => d.FishId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sample_base_fish");

                entity.HasOne(d => d.FreezerLocation)
                    .WithMany(p => p.SampleBase)
                    .HasForeignKey(d => d.FreezerLocationId)
                    .HasConstraintName("FK_sample_base_freezer_location");

                entity.HasOne(d => d.InventoryLocation)
                    .WithMany(p => p.SampleBaseInventoryLocation)
                    .HasForeignKey(d => d.InventoryLocationId)
                    .HasConstraintName("FK_sample_base_inventory_location");

                entity.HasOne(d => d.InventoryStaff)
                    .WithMany(p => p.SampleBase)
                    .HasForeignKey(d => d.InventoryStaffId)
                    .HasConstraintName("FK_sample_base_staff");

                entity.HasOne(d => d.OwnershipLocation)
                    .WithMany(p => p.SampleBaseOwnershipLocation)
                    .HasForeignKey(d => d.OwnershipLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sample_base_location");

                entity.HasOne(d => d.StorageQuality)
                    .WithMany(p => p.SampleBase)
                    .HasForeignKey(d => d.StorageQualityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sample_base_storage_quality");

                entity.HasOne(d => d.TissueCondition)
                    .WithMany(p => p.SampleBase)
                    .HasForeignKey(d => d.TissueConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sample_base_tissue_condition");

                entity.HasOne(d => d.TissuePosition)
                    .WithMany(p => p.SampleBase)
                    .HasForeignKey(d => d.TissuePositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sample_base_tissue_position");

                entity.HasOne(d => d.TissueType)
                    .WithMany(p => p.SampleBase)
                    .HasForeignKey(d => d.TissueTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sample_base_tissue_type");

                entity.HasOne(d => d.StorageQualityCondition)
                    .WithMany(p => p.SampleBase)
                    .HasPrincipalKey(p => new { p.StorageQualityId, p.TissueConditionId })
                    .HasForeignKey(d => new { d.StorageQualityId, d.TissueConditionId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sample_base_storage_quality_condition");

                entity.HasOne(d => d.Tissue)
                    .WithMany(p => p.SampleBase)
                    .HasPrincipalKey(p => new { p.TissueConditionId, p.TissueTypeId })
                    .HasForeignKey(d => new { d.TissueConditionId, d.TissueTypeId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sample_base_condition_sample_type");

                entity.HasOne(d => d.TissueNavigation)
                    .WithMany(p => p.SampleBase)
                    .HasPrincipalKey(p => new { p.TissuePositionId, p.TissueTypeId })
                    .HasForeignKey(d => new { d.TissuePositionId, d.TissueTypeId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sample_base_position_sample_type");
            });

            modelBuilder.Entity<SampleCommunity>(entity =>
            {
                entity.HasKey(e => e.SampleBaseId);

                entity.ToTable("sample_community", "BIO");

                entity.Property(e => e.SampleBaseId)
                    .HasColumnName("sample_base_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ProportionInitialSample)
                    .HasColumnName("proportion_initial_sample")
                    .HasDefaultValueSql("((100))");

                entity.Property(e => e.TissueTypeId)
                    .IsRequired()
                    .HasColumnName("tissue_type_id")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'WC')");

                entity.HasOne(d => d.TissueType)
                    .WithMany(p => p.SampleCommunity)
                    .HasForeignKey(d => d.TissueTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sample_community_tissue_type");

                entity.HasOne(d => d.SampleBase)
                    .WithMany(p => p.SampleCommunity)
                    .HasPrincipalKey(p => new { p.SampleBaseId, p.TissueTypeId })
                    .HasForeignKey(d => new { d.SampleBaseId, d.TissueTypeId })
                    .HasConstraintName("FK_sample_community_sample_base");
            });

            modelBuilder.Entity<SampleGonad>(entity =>
            {
                entity.HasKey(e => e.SampleBaseId);

                entity.ToTable("sample_gonad", "BIO");

                entity.HasIndex(e => e.SampleBaseId)
                    .HasName("IX_sample_gonad_sample_base");

                entity.HasIndex(e => e.TissueTypeId)
                    .HasName("IX_sample_gonad_tissue_type");

                entity.Property(e => e.SampleBaseId)
                    .HasColumnName("sample_base_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.GonadIndex).HasColumnName("gonad_index");

                entity.Property(e => e.IsBlockPrepared).HasColumnName("is_block_prepared");

                entity.Property(e => e.TissueTypeId)
                    .IsRequired()
                    .HasColumnName("tissue_type_id")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'GO')");

                entity.Property(e => e.WeightGr).HasColumnName("weight_gr");

                entity.HasOne(d => d.TissueType)
                    .WithMany(p => p.SampleGonad)
                    .HasForeignKey(d => d.TissueTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sample_gonad_tissue_type");

                entity.HasOne(d => d.SampleBase)
                    .WithMany(p => p.SampleGonad)
                    .HasPrincipalKey(p => new { p.SampleBaseId, p.TissueTypeId })
                    .HasForeignKey(d => new { d.SampleBaseId, d.TissueTypeId })
                    .HasConstraintName("FK_sample_gonad_sample_base");
            });

            modelBuilder.Entity<SampleOther>(entity =>
            {
                entity.HasKey(e => e.SampleBaseId);

                entity.ToTable("sample_other", "BIO");

                entity.HasIndex(e => e.SampleBaseId)
                    .HasName("IX_sample_other_sample_base");

                entity.HasIndex(e => e.TissueTypeId)
                    .HasName("IX_sample_other_tissue_type");

                entity.Property(e => e.SampleBaseId)
                    .HasColumnName("sample_base_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.SampleType)
                    .IsRequired()
                    .HasColumnName("sample_type")
                    .HasMaxLength(50);

                entity.Property(e => e.TissueTypeId)
                    .IsRequired()
                    .HasColumnName("tissue_type_id")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'OT')");

                entity.HasOne(d => d.TissueType)
                    .WithMany(p => p.SampleOther)
                    .HasForeignKey(d => d.TissueTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sample_other_tissue_type");

                entity.HasOne(d => d.SampleBase)
                    .WithMany(p => p.SampleOther)
                    .HasPrincipalKey(p => new { p.SampleBaseId, p.TissueTypeId })
                    .HasForeignKey(d => new { d.SampleBaseId, d.TissueTypeId })
                    .HasConstraintName("FK_sample_other_sample_base");
            });

            modelBuilder.Entity<SampleOtolith>(entity =>
            {
                entity.HasKey(e => e.SampleBaseId);

                entity.ToTable("sample_otolith", "BIO");

                entity.HasIndex(e => e.SampleBaseId)
                    .HasName("FK_sample_otolith_sample_base");

                entity.HasIndex(e => e.TissueTypeId)
                    .HasName("IX_sample_otolith_tissue_type");

                entity.Property(e => e.SampleBaseId)
                    .HasColumnName("sample_base_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsPrepared).HasColumnName("is_prepared");

                entity.Property(e => e.TissueTypeId)
                    .IsRequired()
                    .HasColumnName("tissue_type_id")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'OO')");

                entity.HasOne(d => d.TissueType)
                    .WithMany(p => p.SampleOtolith)
                    .HasForeignKey(d => d.TissueTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sample_otolith_tissue_type");

                entity.HasOne(d => d.SampleBase)
                    .WithMany(p => p.SampleOtolith)
                    .HasPrincipalKey(p => new { p.SampleBaseId, p.TissueTypeId })
                    .HasForeignKey(d => new { d.SampleBaseId, d.TissueTypeId })
                    .HasConstraintName("FK_sample_otolith_sample_base");
            });

            modelBuilder.Entity<SamplePendingAnalysis>(entity =>
            {
                entity.ToTable("sample_pending_analysis", "BIO");

                entity.HasIndex(e => e.AnalysisTypeId)
                    .HasName("IX_sample_pending_analysis_analysis");

                entity.HasIndex(e => e.ContactStaffId)
                    .HasName("IX_sample_pending_analysis_contact");

                entity.HasIndex(e => e.ContractId)
                    .HasName("IX_sample_pending_analysis_contract");

                entity.HasIndex(e => e.LaboratoryLocationId)
                    .HasName("IX_sample_pending_analysis_laboratory");

                entity.HasIndex(e => e.SampleBaseId)
                    .HasName("IX_sample_pending_analysis_sample_base");

                entity.HasIndex(e => e.VolumeSamplingFreightId)
                    .HasName("IX_sample_pending_analysis_volume");

                entity.HasIndex(e => new { e.SampleBaseId, e.LaboratoryLocationId, e.AnalysisTypeId })
                    .HasName("UX_sample_pending")
                    .IsUnique();

                entity.Property(e => e.SamplePendingAnalysisId).HasColumnName("sample_pending_analysis_id");

                entity.Property(e => e.AnalysisTypeId)
                    .HasColumnName("analysis_type_id")
                    .HasMaxLength(2);

                entity.Property(e => e.ContactNameOld)
                    .HasColumnName("contact_name_OLD")
                    .HasMaxLength(100);

                entity.Property(e => e.ContactStaffId).HasColumnName("contact_staff_id");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([date],getdate(),(0)))");

                entity.Property(e => e.ExpectedDate)
                    .HasColumnName("expected_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.GivenDate)
                    .HasColumnName("given_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsAnalysisReceived).HasColumnName("is_analysis_received");

                entity.Property(e => e.IsSampleReturned).HasColumnName("is_sample_returned");

                entity.Property(e => e.LaboratoryIdOld).HasColumnName("laboratory_id_OLD");

                entity.Property(e => e.LaboratoryLocationId).HasColumnName("laboratory_location_id");

                entity.Property(e => e.SampleBaseId).HasColumnName("sample_base_id");

                entity.Property(e => e.VolumeSamplingFreightId)
                    .IsRequired()
                    .HasColumnName("volume_sampling_freight_id")
                    .HasMaxLength(1);

                entity.HasOne(d => d.AnalysisType)
                    .WithMany(p => p.SamplePendingAnalysis)
                    .HasForeignKey(d => d.AnalysisTypeId)
                    .HasConstraintName("FK_sample_pending_analysis_analysis_type");

                entity.HasOne(d => d.ContactStaff)
                    .WithMany(p => p.SamplePendingAnalysis)
                    .HasForeignKey(d => d.ContactStaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sample_pending_analysis_staff");

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.SamplePendingAnalysis)
                    .HasForeignKey(d => d.ContractId)
                    .HasConstraintName("FK_sample_pending_analysis_contract");

                entity.HasOne(d => d.LaboratoryLocation)
                    .WithMany(p => p.SamplePendingAnalysis)
                    .HasForeignKey(d => d.LaboratoryLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sample_pending_analysis_laboratory");

                entity.HasOne(d => d.SampleBase)
                    .WithMany(p => p.SamplePendingAnalysis)
                    .HasForeignKey(d => d.SampleBaseId)
                    .HasConstraintName("FK_sample_pending_analysis_sample_base");

                entity.HasOne(d => d.VolumeSamplingFreight)
                    .WithMany(p => p.SamplePendingAnalysis)
                    .HasForeignKey(d => d.VolumeSamplingFreightId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sample_pending_analysis_volume_sampling_freight");
            });

            modelBuilder.Entity<SamplerTrip>(entity =>
            {
                entity.ToTable("sampler_trip");

                entity.HasIndex(e => new { e.StaffId, e.TripId })
                    .HasName("UX_sampler_trip")
                    .IsUnique();

                entity.Property(e => e.SamplerTripId)
                    .HasColumnName("sampler_trip_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.StaffId).HasColumnName("staff_id");

                entity.Property(e => e.TripId).HasColumnName("trip_id");
            });

            modelBuilder.Entity<SampleUnknown>(entity =>
            {
                entity.ToTable("sample_unknown", "BIO");

                entity.HasIndex(e => e.FreezerLocationId)
                    .HasName("IX_sample_unknown_freezer");

                entity.HasIndex(e => e.FromCountryCodeId)
                    .HasName("IX_sample_unknown_country");

                entity.HasIndex(e => e.InventoryLocationId)
                    .HasName("IX_sample_unknown_inventory_location");

                entity.HasIndex(e => e.InventoryStaffId)
                    .HasName("IX_sample_unknown_inventory");

                entity.HasIndex(e => e.OwnershipLocationId)
                    .HasName("IX_sample_unknown_owner");

                entity.HasIndex(e => e.SamplingFreightId)
                    .HasName("IX_sample_unknown");

                entity.HasIndex(e => e.StorageQualityId)
                    .HasName("IX_sample_unknown_storage_quality");

                entity.HasIndex(e => e.TissueConditionId)
                    .HasName("IX_sample_unknown_tissue_condition");

                entity.HasIndex(e => e.TissueTypeId)
                    .HasName("IX_sample_unknown_tissue_type");

                entity.HasIndex(e => new { e.SampleNo, e.TissueConditionId, e.TissueTypeId })
                    .HasName("UX_sample_unknown")
                    .IsUnique();

                entity.Property(e => e.SampleUnknownId).HasColumnName("sample_unknown_id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([date],getdate(),(0)))");

                entity.Property(e => e.FreezerLocationId).HasColumnName("freezer_location_id");

                entity.Property(e => e.FromCountryCodeId)
                    .IsRequired()
                    .HasColumnName("from_country_code_id")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'XX')");

                entity.Property(e => e.InventoryDate)
                    .HasColumnName("inventory_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InventoryLocationId).HasColumnName("inventory_location_id");

                entity.Property(e => e.InventoryStaffId).HasColumnName("inventory_staff_id");

                entity.Property(e => e.KitGivenDate)
                    .HasColumnName("kit_given_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.KitGivenTo)
                    .HasColumnName("kit_given_to")
                    .HasMaxLength(2);

                entity.Property(e => e.LocationDetails)
                    .HasColumnName("location_details")
                    .HasMaxLength(250);

                entity.Property(e => e.OwnershipLocationId).HasColumnName("ownership_location_id");

                entity.Property(e => e.ReceptionDate)
                    .HasColumnName("reception_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SampleNo)
                    .IsRequired()
                    .HasColumnName("sample_no")
                    .HasMaxLength(20);

                entity.Property(e => e.SamplingFreightId).HasColumnName("sampling_freight_id");

                entity.Property(e => e.StorageQualityId)
                    .IsRequired()
                    .HasColumnName("storage_quality_id")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'U')");

                entity.Property(e => e.TissueConditionId)
                    .IsRequired()
                    .HasColumnName("tissue_condition_id")
                    .HasMaxLength(2);

                entity.Property(e => e.TissuePositionId)
                    .IsRequired()
                    .HasColumnName("tissue_position_id")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'X')");

                entity.Property(e => e.TissueTypeId)
                    .IsRequired()
                    .HasColumnName("tissue_type_id")
                    .HasMaxLength(2);

                entity.HasOne(d => d.FreezerLocation)
                    .WithMany(p => p.SampleUnknown)
                    .HasForeignKey(d => d.FreezerLocationId)
                    .HasConstraintName("FK_sample_unknown_freezer_location");

                entity.HasOne(d => d.FromCountryCode)
                    .WithMany(p => p.SampleUnknown)
                    .HasForeignKey(d => d.FromCountryCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sample_unknown_country");

                entity.HasOne(d => d.InventoryLocation)
                    .WithMany(p => p.SampleUnknownInventoryLocation)
                    .HasForeignKey(d => d.InventoryLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sample_unknown_location");

                entity.HasOne(d => d.InventoryStaff)
                    .WithMany(p => p.SampleUnknown)
                    .HasForeignKey(d => d.InventoryStaffId)
                    .HasConstraintName("FK_sample_unknown_staff");

                entity.HasOne(d => d.OwnershipLocation)
                    .WithMany(p => p.SampleUnknownOwnershipLocation)
                    .HasForeignKey(d => d.OwnershipLocationId)
                    .HasConstraintName("FK_sample_unknown_location_owner");

                entity.HasOne(d => d.SamplingFreight)
                    .WithMany(p => p.SampleUnknown)
                    .HasForeignKey(d => d.SamplingFreightId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_sample_unknown_sampling_freight");

                entity.HasOne(d => d.StorageQuality)
                    .WithMany(p => p.SampleUnknown)
                    .HasForeignKey(d => d.StorageQualityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sample_unknown_storage_quality");

                entity.HasOne(d => d.TissueCondition)
                    .WithMany(p => p.SampleUnknown)
                    .HasForeignKey(d => d.TissueConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sample_unknown_tissue_condition");

                entity.HasOne(d => d.TissuePosition)
                    .WithMany(p => p.SampleUnknown)
                    .HasForeignKey(d => d.TissuePositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sample_unknown_tissue_position");

                entity.HasOne(d => d.TissueType)
                    .WithMany(p => p.SampleUnknown)
                    .HasForeignKey(d => d.TissueTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sample_unknown_tissue_type");

                entity.HasOne(d => d.Tissue)
                    .WithMany(p => p.SampleUnknown)
                    .HasPrincipalKey(p => new { p.TissueConditionId, p.TissueTypeId })
                    .HasForeignKey(d => new { d.TissueConditionId, d.TissueTypeId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sample_unknown_condition_sample_type");

                entity.HasOne(d => d.TissueNavigation)
                    .WithMany(p => p.SampleUnknown)
                    .HasPrincipalKey(p => new { p.TissuePositionId, p.TissueTypeId })
                    .HasForeignKey(d => new { d.TissuePositionId, d.TissueTypeId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sample_unknown_position_sample_type");
            });

            modelBuilder.Entity<Sampling>(entity =>
            {
                entity.ToTable("sampling", "BIO");

                entity.HasIndex(e => e.BsFormQualityId)
                    .HasName("IX_sampling_BS_form");

                entity.HasIndex(e => e.InstructionsQualityId)
                    .HasName("IX_sampling_instructions");

                entity.HasIndex(e => e.PackagingQualityId)
                    .HasName("IX_sampling_packaging");

                entity.HasIndex(e => e.TripId)
                    .HasName("UX_sampling")
                    .IsUnique();

                entity.Property(e => e.SamplingId).HasColumnName("sampling_id");

                entity.Property(e => e.BsFormQualityId)
                    .HasColumnName("BS_form_quality_id")
                    .HasMaxLength(1);

                entity.Property(e => e.CommentsSampler).HasColumnName("comments_sampler");

                entity.Property(e => e.DateLastUpdate).HasColumnType("datetime");

                entity.Property(e => e.FishNb).HasColumnName("fish_nb");

                entity.Property(e => e.FollowerName)
                    .HasColumnName("follower_name")
                    .HasMaxLength(20);

                entity.Property(e => e.GeneralComments).HasColumnName("general_comments");

                entity.Property(e => e.InstructionsQualityId)
                    .HasColumnName("instructions_quality_id")
                    .HasMaxLength(1);

                entity.Property(e => e.IsBsFormHardcopy).HasColumnName("is_bs_form_hardcopy");

                entity.Property(e => e.IsBsFormScanSaved).HasColumnName("is_bs_form_scan_saved");

                entity.Property(e => e.IsDataChecked).HasColumnName("is_data_checked");

                entity.Property(e => e.IsDebriefed).HasColumnName("is_debriefed");

                entity.Property(e => e.IsFinalImportation).HasColumnName("is_final_importation");

                entity.Property(e => e.IsFreezerInventory).HasColumnName("is_freezer_inventory");

                entity.Property(e => e.IsSampleChecked).HasColumnName("is_sample_checked");

                entity.Property(e => e.IsTemporaryImportation).HasColumnName("is_temporary_importation");

                entity.Property(e => e.IsTripToFollow).HasColumnName("is_trip_to_follow");

                entity.Property(e => e.IsTroFileSaved).HasColumnName("is_tro_file_saved");

                entity.Property(e => e.ManagementEntityId).HasColumnName("management_entity_id");

                entity.Property(e => e.OtolithLocation)
                    .HasColumnName("otolith_location")
                    .HasMaxLength(250)
                    .HasComputedColumnSql("([DB].[GetOtolithLocations_Sampling]([trip_id]))");

                entity.Property(e => e.PackagingQualityId)
                    .HasColumnName("packaging_quality_id")
                    .HasMaxLength(1);

                entity.Property(e => e.SampleLocation)
                    .HasColumnName("sample_location")
                    .HasMaxLength(250)
                    .HasComputedColumnSql("([DB].[GetSampleLocations_Sampling]([trip_id]))");

                entity.Property(e => e.SamplingDate)
                    .HasColumnName("sampling_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TmpId).HasColumnName("TMP_id");

                entity.Property(e => e.TripId).HasColumnName("trip_id");

                entity.HasOne(d => d.BsFormQuality)
                    .WithMany(p => p.SamplingBsFormQuality)
                    .HasForeignKey(d => d.BsFormQualityId)
                    .HasConstraintName("FK_sampling_quality_BS_form");

                entity.HasOne(d => d.InstructionsQuality)
                    .WithMany(p => p.SamplingInstructionsQuality)
                    .HasForeignKey(d => d.InstructionsQualityId)
                    .HasConstraintName("FK_sampling_quality_instructions");

                entity.HasOne(d => d.ManagementEntity)
                    .WithMany(p => p.Sampling)
                    .HasForeignKey(d => d.ManagementEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sampling_management_entity");

                entity.HasOne(d => d.PackagingQuality)
                    .WithMany(p => p.SamplingPackagingQuality)
                    .HasForeignKey(d => d.PackagingQualityId)
                    .HasConstraintName("FK_sampling_quality_packaging");

                entity.HasOne(d => d.Trip)
                    .WithOne(p => p.Sampling)
                    .HasForeignKey<Sampling>(d => d.TripId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sampling_trip");
            });

            modelBuilder.Entity<SamplingFinance>(entity =>
            {
                entity.ToTable("sampling_finance", "BIO");

                entity.HasIndex(e => e.ManagementEntityId)
                    .HasName("IX_sampling_finance_management");

                entity.HasIndex(e => e.SamplingId)
                    .HasName("IX_sampling_finance_sampling");

                entity.Property(e => e.SamplingFinanceId).HasColumnName("sampling_finance_id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([date],getdate(),(0)))");

                entity.Property(e => e.Currency)
                    .HasColumnName("currency")
                    .HasMaxLength(3);

                entity.Property(e => e.IsPaymentDone).HasColumnName("is_payment_done");

                entity.Property(e => e.IsPaymentNeeded)
                    .IsRequired()
                    .HasColumnName("is_payment_needed")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.ManagementEntityId).HasColumnName("management_entity_id");

                entity.Property(e => e.PaymentAmount).HasColumnName("payment_amount");

                entity.Property(e => e.PaymentDate)
                    .HasColumnName("payment_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PayslipName)
                    .HasColumnName("payslip_name")
                    .HasMaxLength(100);

                entity.Property(e => e.PayslipPath).HasColumnName("payslip_path");

                entity.Property(e => e.SamplingId).HasColumnName("sampling_id");

                entity.HasOne(d => d.ManagementEntity)
                    .WithMany(p => p.SamplingFinance)
                    .HasForeignKey(d => d.ManagementEntityId)
                    .HasConstraintName("FK_sampling_finance_management_entity");

                entity.HasOne(d => d.Sampling)
                    .WithMany(p => p.SamplingFinance)
                    .HasForeignKey(d => d.SamplingId)
                    .HasConstraintName("FK_sampling_finance_sampling");
            });

            modelBuilder.Entity<SamplingFreight>(entity =>
            {
                entity.ToTable("sampling_freight", "BIO");

                entity.HasIndex(e => e.ArrivalLocationId)
                    .HasName("IX_sampling_freight_arrival");

                entity.HasIndex(e => e.DepartureLocationId)
                    .HasName("IX_sampling_freight_departure");

                entity.HasIndex(e => new { e.ArrivalLocationId, e.DepartureLocationId, e.DispatchDate })
                    .HasName("UX_sampling_freight")
                    .IsUnique();

                entity.Property(e => e.SamplingFreightId).HasColumnName("sampling_freight_id");

                entity.Property(e => e.ArrivalInventoryLocationIdOld)
                    .HasColumnName("arrival_inventory_location_id_OLD")
                    .HasMaxLength(50);

                entity.Property(e => e.ArrivalLocationId).HasColumnName("arrival_location_id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([date],getdate(),(0)))");

                entity.Property(e => e.DepartureInventoryLocationIdOld)
                    .HasColumnName("departure_inventory_location_id_OLD")
                    .HasMaxLength(50);

                entity.Property(e => e.DepartureLocationId).HasColumnName("departure_location_id");

                entity.Property(e => e.DispatchDate)
                    .HasColumnName("dispatch_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnName("effective_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExpectedDate)
                    .HasColumnName("expected_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FreightDetails).HasColumnName("freight_details");

                entity.Property(e => e.FreightTypeId).HasColumnName("freight_type_id");

                entity.Property(e => e.PriceUsd).HasColumnName("price_USD");

                entity.Property(e => e.QuarantineNo)
                    .HasColumnName("quarantine_no")
                    .HasMaxLength(20);

                entity.Property(e => e.TmpId).HasColumnName("TMP_id");

                entity.HasOne(d => d.ArrivalLocation)
                    .WithMany(p => p.SamplingFreightArrivalLocation)
                    .HasForeignKey(d => d.ArrivalLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sampling_freight_inventory_location_arrival");

                entity.HasOne(d => d.DepartureLocation)
                    .WithMany(p => p.SamplingFreightDepartureLocation)
                    .HasForeignKey(d => d.DepartureLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sampling_freight_inventory_location_departure");
            });

            modelBuilder.Entity<SamplingKit>(entity =>
            {
                entity.ToTable("sampling_kit", "BIO");

                entity.HasIndex(e => e.CableTie)
                    .HasName("UX_sampling_kit")
                    .IsUnique();

                entity.HasIndex(e => e.CountryId)
                    .HasName("IX_sampling_kit_country");

                entity.Property(e => e.SamplingKitId).HasColumnName("sampling_kit_id");

                entity.Property(e => e.CableTie)
                    .IsRequired()
                    .HasColumnName("cable_tie")
                    .HasMaxLength(21)
                    .HasComputedColumnSql("(([first_tag]+'-')+[last_tag])");

                entity.Property(e => e.CableTieNb).HasColumnName("cable_tie_nb");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CountryId)
                    .HasColumnName("country_id")
                    .HasMaxLength(2);

                entity.Property(e => e.DispatchDate)
                    .HasColumnName("dispatch_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FirstTag)
                    .IsRequired()
                    .HasColumnName("first_tag")
                    .HasMaxLength(10);

                entity.Property(e => e.GivenTo).HasColumnName("given_to");

                entity.Property(e => e.LabelFishUsed).HasColumnName("label_fish_used");

                entity.Property(e => e.LastTag)
                    .IsRequired()
                    .HasColumnName("last_tag")
                    .HasMaxLength(10);

                entity.Property(e => e.TmpId).HasColumnName("TMP_id");

                entity.Property(e => e.TransportedBy)
                    .HasColumnName("transported_by")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.SamplingKit)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_sampling_kit_country");
            });

            modelBuilder.Entity<SchoolAssociation>(entity =>
            {
                entity.ToTable("school_association", "REF");

                entity.HasIndex(e => e.SchoolAssociationDesc)
                    .HasName("UX_school_association");

                entity.Property(e => e.SchoolAssociationId)
                    .HasColumnName("school_association_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SchoolAssociationDesc)
                    .IsRequired()
                    .HasColumnName("school_association_desc")
                    .HasMaxLength(50);

                entity.Property(e => e.SchoolAssociationGroup)
                    .IsRequired()
                    .HasColumnName("school_association_group")
                    .HasMaxLength(255);

                entity.Property(e => e.SchoolTagdager)
                    .HasColumnName("school_tagdager")
                    .HasMaxLength(1);

                entity.Property(e => e.SchoolTubs).HasColumnName("school_TUBS");
            });

            modelBuilder.Entity<SetBase>(entity =>
            {
                entity.ToTable("set_base", "BIO");

                entity.HasIndex(e => e.GearId)
                    .HasName("IX_set_base_gear");

                entity.HasIndex(e => e.SchoolAssociationId)
                    .HasName("IX_set_base_school");

                entity.HasIndex(e => e.StaffId)
                    .HasName("IX_set_base_staff");

                entity.HasIndex(e => e.TripId)
                    .HasName("IX_set_base_trip");

                entity.HasIndex(e => new { e.TripId, e.SetNo, e.GearId })
                    .HasName("UX_set_base_set")
                    .IsUnique();

                entity.Property(e => e.SetBaseId).HasColumnName("set_base_id");

                entity.Property(e => e.BaitList).HasColumnName("bait_list");

                entity.Property(e => e.BathyMeters)
                    .HasColumnName("bathy_meters")
                    .HasColumnType("decimal(6, 1)");

                entity.Property(e => e.BetRegionId).HasColumnName("BET_region_id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([date],getdate(),(0)))");

                entity.Property(e => e.DayNightId)
                    .HasColumnName("day_night_id")
                    .HasMaxLength(5);

                entity.Property(e => e.EezClosest)
                    .HasColumnName("eez_closest")
                    .HasMaxLength(2);

                entity.Property(e => e.EezSubcountryId)
                    .HasColumnName("eez_subcountry_id")
                    .HasMaxLength(2);

                entity.Property(e => e.EndLatitude)
                    .HasColumnName("end_latitude")
                    .HasMaxLength(9);

                entity.Property(e => e.EndLongitude)
                    .HasColumnName("end_longitude")
                    .HasMaxLength(10);

                entity.Property(e => e.GearId)
                    .IsRequired()
                    .HasColumnName("gear_id")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'O')");

                entity.Property(e => e.Latitude)
                    .IsRequired()
                    .HasColumnName("latitude")
                    .HasMaxLength(9);

                entity.Property(e => e.LatitudeDec)
                    .HasColumnName("latitude_dec")
                    .HasColumnType("decimal(25, 15)")
                    .HasComputedColumnSql("([QRY].[CoordDegDec]([latitude]))");

                entity.Property(e => e.LogIdTubsOld).HasColumnName("log_id_TUBS_OLD");

                entity.Property(e => e.LonghurstCode)
                    .HasColumnName("longhurst_code")
                    .HasMaxLength(4);

                entity.Property(e => e.Longitude)
                    .IsRequired()
                    .HasColumnName("longitude")
                    .HasMaxLength(10);

                entity.Property(e => e.LongitudeDec)
                    .HasColumnName("longitude_dec")
                    .HasColumnType("decimal(25, 15)")
                    .HasComputedColumnSql("([QRY].[CoordDegDec]([longitude]))");

                entity.Property(e => e.OniNoaa).HasColumnName("ONI_NOAA");

                entity.Property(e => e.SchoolAssociationId).HasColumnName("school_association_id");

                entity.Property(e => e.SetDateLocal)
                    .HasColumnName("set_date_local")
                    .HasColumnType("datetime");

                entity.Property(e => e.SetEndDateLocal)
                    .HasColumnName("set_end_date_local")
                    .HasColumnType("datetime");

                entity.Property(e => e.SetEndTimeLocal)
                    .HasColumnName("set_end_time_local")
                    .HasMaxLength(4);

                entity.Property(e => e.SetNo).HasColumnName("set_no");

                entity.Property(e => e.SetTimeLocal)
                    .HasColumnName("set_time_local")
                    .HasMaxLength(4);

                entity.Property(e => e.SstCelsius)
                    .HasColumnName("sst_celsius")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.StaffId).HasColumnName("staff_id");

                entity.Property(e => e.T2LogId).HasColumnName("T2_log_id");

                entity.Property(e => e.TripId).HasColumnName("trip_id");

                entity.HasOne(d => d.DayNight)
                    .WithMany(p => p.SetBase)
                    .HasForeignKey(d => d.DayNightId)
                    .HasConstraintName("FK_set_base_day_night");

                entity.HasOne(d => d.Gear)
                    .WithMany(p => p.SetBase)
                    .HasForeignKey(d => d.GearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_set_base_gear");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.SetBase)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK_set_base_staff");

                entity.HasOne(d => d.Trip)
                    .WithMany(p => p.SetBase)
                    .HasForeignKey(d => d.TripId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_set_base_trip");
            });

            modelBuilder.Entity<SetBiological>(entity =>
            {
                entity.HasKey(e => e.SetBaseId);

                entity.ToTable("set_biological", "BIO");

                entity.HasIndex(e => e.DayNightId)
                    .HasName("IX_set_biological_day_night");

                entity.HasIndex(e => e.SetBaseId)
                    .HasName("UX_set_biological_set_base")
                    .IsUnique();

                entity.HasIndex(e => e.TowMethodId)
                    .HasName("IX_set_biological_tow");

                entity.Property(e => e.SetBaseId)
                    .HasColumnName("set_base_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BagNb).HasColumnName("bag_nb");

                entity.Property(e => e.BioSetNo)
                    .IsRequired()
                    .HasColumnName("bio_set_no")
                    .HasMaxLength(10);

                entity.Property(e => e.BottomDepthM).HasColumnName("bottom_depth_m");

                entity.Property(e => e.CableLengthMOld).HasColumnName("cable_length_m_OLD");

                entity.Property(e => e.Catch)
                    .HasColumnName("catch")
                    .HasMaxLength(15);

                entity.Property(e => e.CodendDeckTimeUtc)
                    .HasColumnName("codend_deck_time_UTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.CodendMeshOld).HasColumnName("codend_mesh_OLD");

                entity.Property(e => e.CodendWaterTimeUtc)
                    .HasColumnName("codend_water_time_UTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.Composition).HasColumnName("composition");

                entity.Property(e => e.CtdCastNb)
                    .HasColumnName("CTD_cast_nb")
                    .HasMaxLength(50);

                entity.Property(e => e.DayNightId)
                    .HasColumnName("day_night_id")
                    .HasMaxLength(5);

                entity.Property(e => e.DepthRangeOld)
                    .HasColumnName("depth_range_OLD")
                    .HasMaxLength(50);

                entity.Property(e => e.DetectionDepthM)
                    .HasColumnName("detection_depth_m")
                    .HasMaxLength(100);

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.FlowmeterCalibration).HasColumnName("flowmeter_calibration");

                entity.Property(e => e.FlowmeterNo)
                    .HasColumnName("flowmeter_no")
                    .HasMaxLength(50);

                entity.Property(e => e.FlowmeterRevolution).HasColumnName("flowmeter_revolution");

                entity.Property(e => e.GearBrandOld)
                    .HasColumnName("gear_brand_OLD")
                    .HasMaxLength(255);

                entity.Property(e => e.GearOwnerOld)
                    .HasColumnName("gear_owner_OLD")
                    .HasMaxLength(100);

                entity.Property(e => e.HaulDurationOld)
                    .HasColumnName("haul_duration_OLD")
                    .HasMaxLength(4);

                entity.Property(e => e.HaulEndLatOld)
                    .HasColumnName("haul_end_lat_OLD")
                    .HasMaxLength(9);

                entity.Property(e => e.HaulEndLonOld)
                    .HasColumnName("haul_end_lon_OLD")
                    .HasMaxLength(10);

                entity.Property(e => e.HaulEndTimeUtcOld)
                    .HasColumnName("haul_end_time_UTC_OLD")
                    .HasMaxLength(4);

                entity.Property(e => e.HaulStartLatOld)
                    .HasColumnName("haul_start_lat_OLD")
                    .HasMaxLength(9);

                entity.Property(e => e.HaulStartLonOld)
                    .HasColumnName("haul_start_lon_OLD")
                    .HasMaxLength(10);

                entity.Property(e => e.HaulStartTimeUtcOld)
                    .HasColumnName("haul_start_time_UTC_OLD")
                    .HasMaxLength(4);

                entity.Property(e => e.HorizontalMouthOpeningObsMOld).HasColumnName("horizontal_mouth_opening_obs_m_OLD");

                entity.Property(e => e.HorizontalMouthOpeningSetObservedM).HasColumnName("horizontal_mouth_opening_set_observed_m");

                entity.Property(e => e.MeshRangeOld)
                    .HasColumnName("mesh_range_OLD")
                    .HasMaxLength(50);

                entity.Property(e => e.NetDeckDateLocalOld)
                    .HasColumnName("net_deck_date_local_OLD")
                    .HasColumnType("datetime");

                entity.Property(e => e.NetDeckDateUtcOld)
                    .HasColumnName("net_deck_date_UTC_OLD")
                    .HasColumnType("datetime");

                entity.Property(e => e.NetNbOld).HasColumnName("net_nb_OLD");

                entity.Property(e => e.NetWaterDateLocalOld)
                    .HasColumnName("net_water_date_local_OLD")
                    .HasColumnType("datetime");

                entity.Property(e => e.NetWaterDateUtcOld)
                    .HasColumnName("net_water_date_UTC_OLD")
                    .HasColumnType("datetime");

                entity.Property(e => e.ObservedDepthAvgOld).HasColumnName("observed_depth_avg_OLD");

                entity.Property(e => e.ObservedDepthMaxOld)
                    .HasColumnName("observed_depth_max_OLD")
                    .HasMaxLength(10);

                entity.Property(e => e.ObservedDepthMinOld).HasColumnName("observed_depth_min_OLD");

                entity.Property(e => e.OpeningClosingSystOld)
                    .IsRequired()
                    .HasColumnName("opening_closing_syst_OLD")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'N')");

                entity.Property(e => e.OverallLengthOld).HasColumnName("overall_length_OLD");

                entity.Property(e => e.ScanmarDepthOld).HasColumnName("scanmar_depth_OLD");

                entity.Property(e => e.SetDurationOld)
                    .HasColumnName("set_duration_OLD")
                    .HasMaxLength(4);

                entity.Property(e => e.SetEndLatOld)
                    .HasColumnName("set_end_lat_OLD")
                    .HasMaxLength(9);

                entity.Property(e => e.SetEndLonOld)
                    .HasColumnName("set_end_lon_OLD")
                    .HasMaxLength(10);

                entity.Property(e => e.SetEndTimeUtcOld)
                    .HasColumnName("set_end_time_UTC_OLD")
                    .HasMaxLength(4);

                entity.Property(e => e.SourceVolumeSetFilteredId).HasColumnName("source_volume_set_filtered_id");

                entity.Property(e => e.Speed).HasColumnName("speed");

                entity.Property(e => e.StationNo)
                    .IsRequired()
                    .HasColumnName("station_no")
                    .HasMaxLength(20);

                entity.Property(e => e.SurfaceMouthOpeningObsM2Old).HasColumnName("surface_mouth_opening_obs_m2_OLD");

                entity.Property(e => e.SurfaceMouthOpeningSetObservedM2).HasColumnName("surface_mouth_opening_set_observed_m2");

                entity.Property(e => e.TargetDepthMOld).HasColumnName("target_depth_m_OLD");

                entity.Property(e => e.TimeZone).HasColumnName("time_zone");

                entity.Property(e => e.TotalDurationOld)
                    .HasColumnName("total_duration_OLD")
                    .HasMaxLength(4);

                entity.Property(e => e.TowMethodId)
                    .HasColumnName("tow_method_id")
                    .HasMaxLength(1);

                entity.Property(e => e.TrawlDurationOld)
                    .HasColumnName("trawl_duration_OLD")
                    .HasMaxLength(4);

                entity.Property(e => e.TrawlTotalDuration)
                    .HasColumnName("trawl_total_duration")
                    .HasColumnType("time(0)");

                entity.Property(e => e.VerticalMouthOpeningObsMOld).HasColumnName("vertical_mouth_opening_obs_m_OLD");

                entity.Property(e => e.VerticalMouthOpeningSetObservedM).HasColumnName("vertical_mouth_opening_set_observed_m");

                entity.Property(e => e.VolumeFilteredObsM3Old).HasColumnName("volume_filtered_obs_m3_OLD");

                entity.Property(e => e.VolumeFilteredSetObservedM3).HasColumnName("volume_filtered_set_observed_m3");

                entity.HasOne(d => d.DayNight)
                    .WithMany(p => p.SetBiological)
                    .HasForeignKey(d => d.DayNightId)
                    .HasConstraintName("FK_set_biological_day_night");

                entity.HasOne(d => d.SetBase)
                    .WithOne(p => p.SetBiological)
                    .HasForeignKey<SetBiological>(d => d.SetBaseId)
                    .HasConstraintName("FK_set_biological_set_base");

                entity.HasOne(d => d.TowMethod)
                    .WithMany(p => p.SetBiological)
                    .HasForeignKey(d => d.TowMethodId)
                    .HasConstraintName("FK_sop_set_biological_tow_method");
            });

            modelBuilder.Entity<SetBiologicalGear>(entity =>
            {
                entity.ToTable("set_biological_gear", "BIO");

                entity.HasIndex(e => e.GearName)
                    .HasName("UX_set_biological_gear")
                    .IsUnique();

                entity.Property(e => e.SetBiologicalGearId).HasColumnName("set_biological_gear_id");

                entity.Property(e => e.CodendMesh).HasColumnName("codend_mesh");

                entity.Property(e => e.CodendTypeId).HasColumnName("codend_type_id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.GearBrand)
                    .IsRequired()
                    .HasColumnName("gear_brand")
                    .HasMaxLength(255);

                entity.Property(e => e.GearId)
                    .IsRequired()
                    .HasColumnName("gear_id")
                    .HasMaxLength(1);

                entity.Property(e => e.GearName)
                    .IsRequired()
                    .HasColumnName("gear_name")
                    .HasMaxLength(100);

                entity.Property(e => e.GearOwner)
                    .IsRequired()
                    .HasColumnName("gear_owner")
                    .HasMaxLength(100);

                entity.Property(e => e.HorizontalMouthOpeningTheory).HasColumnName("horizontal_mouth_opening_theory");

                entity.Property(e => e.IsOpenClose).HasColumnName("is_open_close");

                entity.Property(e => e.MeshRange)
                    .HasColumnName("mesh_range")
                    .HasMaxLength(50);

                entity.Property(e => e.NetNb).HasColumnName("net_nb");

                entity.Property(e => e.OverallLengthM).HasColumnName("overall_length_m");

                entity.Property(e => e.PhotoLnk)
                    .HasColumnName("photo_lnk")
                    .HasMaxLength(100);

                entity.Property(e => e.ReferenceDoc)
                    .HasColumnName("reference_doc")
                    .HasMaxLength(100);

                entity.Property(e => e.SurfaceMouthOpeningTheoryM2).HasColumnName("surface_mouth_opening_theory_m2");

                entity.Property(e => e.TargetGroupId).HasColumnName("target_group_id");

                entity.Property(e => e.VerticalMouthOpeningTheory).HasColumnName("vertical_mouth_opening_theory");

                entity.HasOne(d => d.CodendType)
                    .WithMany(p => p.SetBiologicalGear)
                    .HasForeignKey(d => d.CodendTypeId)
                    .HasConstraintName("FK_set_biological_gear_codend_type");

                entity.HasOne(d => d.TargetGroup)
                    .WithMany(p => p.SetBiologicalGear)
                    .HasForeignKey(d => d.TargetGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_set_biological_gear_target_group");
            });

            modelBuilder.Entity<SetBiologicalGearLink>(entity =>
            {
                entity.HasKey(e => new { e.SetBiologicalGearId, e.SetBaseId });

                entity.ToTable("set_biological_gear_link", "QRY");

                entity.Property(e => e.SetBiologicalGearId).HasColumnName("set_biological_gear_id");

                entity.Property(e => e.SetBaseId).HasColumnName("set_base_id");

                entity.HasOne(d => d.SetBase)
                    .WithMany(p => p.SetBiologicalGearLink)
                    .HasForeignKey(d => d.SetBaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_set_biological_gear_link_set_base");

                entity.HasOne(d => d.SetBiologicalGear)
                    .WithMany(p => p.SetBiologicalGearLink)
                    .HasForeignKey(d => d.SetBiologicalGearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_set_biological_gear_link_set_biological_gear");
            });

            modelBuilder.Entity<SetBiologicalStep>(entity =>
            {
                entity.HasKey(e => new { e.SetBaseId, e.StepNo });

                entity.ToTable("set_biological_step", "BIO");

                entity.Property(e => e.SetBaseId).HasColumnName("set_base_id");

                entity.Property(e => e.StepNo).HasColumnName("step_no");

                entity.Property(e => e.CableLengthStepM).HasColumnName("cable_length_step_m");

                entity.Property(e => e.HaulEndStepLat)
                    .HasColumnName("haul_end_step_lat")
                    .HasMaxLength(9);

                entity.Property(e => e.HaulEndStepLon)
                    .HasColumnName("haul_end_step_lon")
                    .HasMaxLength(10);

                entity.Property(e => e.HaulEndStepUtcDt)
                    .HasColumnName("haul_end_step_UTC_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.HaulStartStepLat)
                    .HasColumnName("haul_start_step_lat")
                    .HasMaxLength(9);

                entity.Property(e => e.HaulStartStepLon)
                    .HasColumnName("haul_start_step_lon")
                    .HasMaxLength(10);

                entity.Property(e => e.HaulStartStepUtcDt)
                    .HasColumnName("haul_start_step_UTC_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.HaulStepDuration)
                    .HasColumnName("haul_step_duration")
                    .HasColumnType("time(0)");

                entity.Property(e => e.HorizontalMouthOpeningStepObservedM).HasColumnName("horizontal_mouth_opening_step_observed_m");

                entity.Property(e => e.ObservedDepthStepM).HasColumnName("observed_depth_step_m");

                entity.Property(e => e.ObservedDepthStepMaxM).HasColumnName("observed_depth_step_max_m");

                entity.Property(e => e.ObservedDepthStepMinM).HasColumnName("observed_depth_step_min_m");

                entity.Property(e => e.SetEndStepLat)
                    .HasColumnName("set_end_step_lat")
                    .HasMaxLength(9);

                entity.Property(e => e.SetEndStepLon)
                    .HasColumnName("set_end_step_lon")
                    .HasMaxLength(10);

                entity.Property(e => e.SetEndStepUtcDt)
                    .HasColumnName("set_end_step_UTC_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.SetStartStepLat)
                    .HasColumnName("set_start_step_lat")
                    .HasMaxLength(9);

                entity.Property(e => e.SetStartStepLon)
                    .HasColumnName("set_start_step_lon")
                    .HasMaxLength(10);

                entity.Property(e => e.SetStartStepUtcDt)
                    .HasColumnName("set_start_step_UTC_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.SetStepDuration)
                    .HasColumnName("set_step_duration")
                    .HasColumnType("time(0)");

                entity.Property(e => e.SourceVolumeStepFilteredId).HasColumnName("source_volume_step_filtered_id");

                entity.Property(e => e.SurfaceMouthOpeningStepObservedM2).HasColumnName("surface_mouth_opening_step_observed_m2");

                entity.Property(e => e.TargetDepthStepM).HasColumnName("target_depth_step_m");

                entity.Property(e => e.TrawlStepDuration)
                    .HasColumnName("trawl_step_duration")
                    .HasColumnType("time(0)");

                entity.Property(e => e.VerticalMouthOpeningStepObservedM).HasColumnName("vertical_mouth_opening_step_observed_m");

                entity.Property(e => e.VolumeFilteredStepObservedM3).HasColumnName("volume_filtered_step_observed_m3");

                entity.HasOne(d => d.SetBase)
                    .WithMany(p => p.SetBiologicalStep)
                    .HasForeignKey(d => d.SetBaseId)
                    .HasConstraintName("FK_set_biological_step_set_base");

                entity.HasOne(d => d.SourceVolumeStepFiltered)
                    .WithMany(p => p.SetBiologicalStep)
                    .HasForeignKey(d => d.SourceVolumeStepFilteredId)
                    .HasConstraintName("FK_set_biological_step_source_volume_filtered");
            });

            modelBuilder.Entity<SetBiologicalZooplankton>(entity =>
            {
                entity.HasKey(e => e.SetZooplanktonId);

                entity.ToTable("set_biological_zooplankton", "BIO");

                entity.HasIndex(e => e.SetBaseId)
                    .HasName("IX_set_biological_zooplankton_set_base");

                entity.Property(e => e.SetZooplanktonId).HasColumnName("set_zooplankton_id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.DepthMaxM).HasColumnName("depth_max_m");

                entity.Property(e => e.DepthMinM).HasColumnName("depth_min_m");

                entity.Property(e => e.DepthNo).HasColumnName("depth_no");

                entity.Property(e => e.SetBaseId).HasColumnName("set_base_id");

                entity.Property(e => e.TmpId).HasColumnName("TMP_id");

                entity.Property(e => e.VolumeFilteredM3).HasColumnName("volume_filtered_m3");

                entity.HasOne(d => d.SetBase)
                    .WithMany(p => p.SetBiologicalZooplankton)
                    .HasForeignKey(d => d.SetBaseId)
                    .HasConstraintName("FK_set_biological_zooplankton_set_base");
            });

            modelBuilder.Entity<SetDws>(entity =>
            {
                entity.HasKey(e => e.SetBaseId);

                entity.ToTable("set_dws", "BIO");

                entity.HasIndex(e => e.SetBaseId)
                    .HasName("UX_set_dws_set_base")
                    .IsUnique();

                entity.Property(e => e.SetBaseId)
                    .HasColumnName("set_base_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bait)
                    .HasColumnName("bait")
                    .HasMaxLength(20);

                entity.Property(e => e.DepthEnd).HasColumnName("depth_end");

                entity.Property(e => e.DepthStart).HasColumnName("depth_start");

                entity.Property(e => e.HooksNo).HasColumnName("hooks_no");

                entity.Property(e => e.IsBurley).HasColumnName("is_burley");

                entity.Property(e => e.LatEnd)
                    .HasColumnName("lat_end")
                    .HasMaxLength(9);

                entity.Property(e => e.LinesNo).HasColumnName("lines_no");

                entity.Property(e => e.LonEnd)
                    .HasColumnName("lon_end")
                    .HasMaxLength(10);

                entity.Property(e => e.TimeEnd)
                    .HasColumnName("time_end")
                    .HasMaxLength(4);

                entity.HasOne(d => d.SetBase)
                    .WithOne(p => p.SetDws)
                    .HasForeignKey<SetDws>(d => d.SetBaseId)
                    .HasConstraintName("FK_set_dws_set_base");
            });

            modelBuilder.Entity<SetPsa>(entity =>
            {
                entity.HasKey(e => e.SetBaseId);

                entity.ToTable("set_psa", "BIO");

                entity.HasIndex(e => e.AreaReliabilityId)
                    .HasName("IX_set_psa_area_reliability");

                entity.HasIndex(e => e.SetBaseId)
                    .HasName("UX_set_psa_set_base")
                    .IsUnique();

                entity.Property(e => e.SetBaseId)
                    .HasColumnName("set_base_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaReliabilityId).HasColumnName("area_reliability_id");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LatMax)
                    .IsRequired()
                    .HasColumnName("lat_max")
                    .HasMaxLength(9);

                entity.Property(e => e.LatMin)
                    .IsRequired()
                    .HasColumnName("lat_min")
                    .HasMaxLength(9);

                entity.Property(e => e.LonMax)
                    .IsRequired()
                    .HasColumnName("lon_max")
                    .HasMaxLength(10);

                entity.Property(e => e.LonMin)
                    .IsRequired()
                    .HasColumnName("lon_min")
                    .HasMaxLength(10);

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.VesselName)
                    .IsRequired()
                    .HasColumnName("vessel_name")
                    .HasMaxLength(200);

                entity.HasOne(d => d.AreaReliability)
                    .WithMany(p => p.SetPsa)
                    .HasForeignKey(d => d.AreaReliabilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_set_psa_area_reliability");

                entity.HasOne(d => d.SetBase)
                    .WithOne(p => p.SetPsa)
                    .HasForeignKey<SetPsa>(d => d.SetBaseId)
                    .HasConstraintName("FK_set_base_psa_set");
            });

            modelBuilder.Entity<Sex>(entity =>
            {
                entity.ToTable("sex", "REF");

                entity.HasIndex(e => e.SexDesc)
                    .HasName("UX_sex")
                    .IsUnique();

                entity.Property(e => e.SexId)
                    .HasColumnName("sex_id")
                    .HasMaxLength(1)
                    .ValueGeneratedNever();

                entity.Property(e => e.SexDesc)
                    .IsRequired()
                    .HasColumnName("sex_desc")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Shipper>(entity =>
            {
                entity.ToTable("shipper", "BIO");

                entity.HasIndex(e => e.ShipperName)
                    .HasName("UX_shipper")
                    .IsUnique();

                entity.Property(e => e.ShipperId)
                    .HasColumnName("shipper_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ContactDetails)
                    .HasColumnName("contact_details")
                    .HasMaxLength(50);

                entity.Property(e => e.FullAddress)
                    .HasColumnName("full_address")
                    .HasMaxLength(150);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(15);

                entity.Property(e => e.ShipperName)
                    .IsRequired()
                    .HasColumnName("shipper_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Side>(entity =>
            {
                entity.ToTable("side", "REF");

                entity.HasIndex(e => e.SideDesc)
                    .HasName("UX_side")
                    .IsUnique();

                entity.Property(e => e.SideId)
                    .HasColumnName("side_id")
                    .HasMaxLength(1)
                    .ValueGeneratedNever();

                entity.Property(e => e.SideDesc)
                    .IsRequired()
                    .HasColumnName("side_desc")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<SourceVolumeFiltered>(entity =>
            {
                entity.ToTable("source_volume_filtered", "REF");

                entity.HasIndex(e => e.SourceVolumeFilteredDesc)
                    .HasName("UX_source_volume_filtered")
                    .IsUnique();

                entity.Property(e => e.SourceVolumeFilteredId)
                    .HasColumnName("source_volume_filtered_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SourceVolumeFilteredDesc)
                    .IsRequired()
                    .HasColumnName("source_volume_filtered_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Species>(entity =>
            {
                entity.ToTable("species", "REF");

                entity.HasIndex(e => e.LengthCodeId)
                    .HasName("IX_species_length_code");

                entity.HasIndex(e => e.ScientificName)
                    .HasName("UX_species")
                    .IsUnique();

                entity.HasIndex(e => e.SpeciesCategoryId)
                    .HasName("IX_species_category");

                entity.HasIndex(e => e.SpeciesGroupId)
                    .HasName("IX_species_group");

                entity.HasIndex(e => e.SpeciesNameCategoryId)
                    .HasName("IX_species_species_name_category");

                entity.HasIndex(e => e.SwimbladderId)
                    .HasName("IX_species_swimbladder");

                entity.HasIndex(e => e.VerticalClassId)
                    .HasName("IX_species_vertical_class");

                entity.Property(e => e.SpeciesId).HasColumnName("species_id");

                entity.Property(e => e.AsfisCode)
                    .HasColumnName("asfis_code")
                    .HasMaxLength(3);

                entity.Property(e => e.ClassTaxo)
                    .HasColumnName("class_taxo")
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ecopath2010Class)
                    .HasColumnName("Ecopath2010_class")
                    .HasMaxLength(255);

                entity.Property(e => e.EnglishName)
                    .HasColumnName("english_name")
                    .HasMaxLength(70);

                entity.Property(e => e.FamilyTaxo)
                    .HasColumnName("family_taxo")
                    .HasMaxLength(50);

                entity.Property(e => e.FrenchName)
                    .HasColumnName("french_name")
                    .HasMaxLength(70);

                entity.Property(e => e.GbifKey).HasColumnName("GBIF_key");

                entity.Property(e => e.GenusTaxo)
                    .HasColumnName("genus_taxo")
                    .HasMaxLength(50);

                entity.Property(e => e.Infraclass)
                    .HasColumnName("infraclass")
                    .HasMaxLength(50);

                entity.Property(e => e.Infraorder)
                    .HasColumnName("infraorder")
                    .HasMaxLength(50);

                entity.Property(e => e.IsIdentificationSheet).HasColumnName("is_identification_sheet");

                entity.Property(e => e.IsPelagicJuvenile).HasColumnName("is_pelagic_juvenile");

                entity.Property(e => e.IsReefAssociated).HasColumnName("is_reef_associated");

                entity.Property(e => e.IsSpecies)
                    .HasColumnName("is_species")
                    .HasComputedColumnSql("(CONVERT([bit],case when [species_name_category_id] IS NOT NULL then (1) else (0) end))");

                entity.Property(e => e.JaponeseName)
                    .HasColumnName("japonese_name")
                    .HasMaxLength(70);

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("datetime");

                entity.Property(e => e.LenMaxMm)
                    .HasColumnName("len_max_mm")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LenMinMm)
                    .HasColumnName("len_min_mm")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LengthCodeId)
                    .HasColumnName("length_code_id")
                    .HasMaxLength(2);

                entity.Property(e => e.MaturitySize).HasColumnName("maturity_size");

                entity.Property(e => e.OrderTaxo)
                    .HasColumnName("order_taxo")
                    .HasMaxLength(50);

                entity.Property(e => e.PhylumTaxo)
                    .HasColumnName("phylum_taxo")
                    .HasMaxLength(50);

                entity.Property(e => e.PreyLenMaxMm)
                    .HasColumnName("prey_len_max_mm")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.PreyLenMinMm)
                    .HasColumnName("prey_len_min_mm")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ScientificName)
                    .IsRequired()
                    .HasColumnName("scientific_name")
                    .HasMaxLength(70);

                entity.Property(e => e.SpeciesCategoryId).HasColumnName("species_category_id");

                entity.Property(e => e.SpeciesColor)
                    .HasColumnName("species_color")
                    .HasMaxLength(7);

                entity.Property(e => e.SpeciesGroupId)
                    .HasColumnName("species_group_id")
                    .HasMaxLength(3);

                entity.Property(e => e.SpeciesNameCategoryId)
                    .HasColumnName("species_name_category_id")
                    .HasMaxLength(3);

                entity.Property(e => e.SpeciesTaxo)
                    .HasColumnName("species_taxo")
                    .HasMaxLength(50);

                entity.Property(e => e.Subclass)
                    .HasColumnName("subclass")
                    .HasMaxLength(50);

                entity.Property(e => e.Subfamily)
                    .HasColumnName("subfamily")
                    .HasMaxLength(50);

                entity.Property(e => e.Suborder)
                    .HasColumnName("suborder")
                    .HasMaxLength(50);

                entity.Property(e => e.Subphylum)
                    .HasColumnName("subphylum")
                    .HasMaxLength(50);

                entity.Property(e => e.Superfamily)
                    .HasColumnName("superfamily")
                    .HasMaxLength(50);

                entity.Property(e => e.Superorder)
                    .HasColumnName("superorder")
                    .HasMaxLength(50);

                entity.Property(e => e.SwimbladderId).HasColumnName("swimbladder_id");

                entity.Property(e => e.VerticalClassId)
                    .HasColumnName("vertical_class_id")
                    .HasMaxLength(2);

                entity.Property(e => e.WormsKey).HasColumnName("WORMS_key");

                entity.HasOne(d => d.LengthCode)
                    .WithMany(p => p.Species)
                    .HasForeignKey(d => d.LengthCodeId)
                    .HasConstraintName("FK_species_length_code");

                entity.HasOne(d => d.SpeciesCategory)
                    .WithMany(p => p.Species)
                    .HasForeignKey(d => d.SpeciesCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_species_species_category");

                entity.HasOne(d => d.SpeciesGroup)
                    .WithMany(p => p.Species)
                    .HasForeignKey(d => d.SpeciesGroupId)
                    .HasConstraintName("FK_species_species_group");

                entity.HasOne(d => d.SpeciesNameCategory)
                    .WithMany(p => p.Species)
                    .HasForeignKey(d => d.SpeciesNameCategoryId)
                    .HasConstraintName("FK_species_species_name_category");

                entity.HasOne(d => d.Swimbladder)
                    .WithMany(p => p.Species)
                    .HasForeignKey(d => d.SwimbladderId)
                    .HasConstraintName("FK_species_swimbladder");

                entity.HasOne(d => d.VerticalClass)
                    .WithMany(p => p.Species)
                    .HasForeignKey(d => d.VerticalClassId)
                    .HasConstraintName("FK_species_vertical_class");
            });

            modelBuilder.Entity<SpeciesCategory>(entity =>
            {
                entity.ToTable("species_category", "REF");

                entity.HasIndex(e => e.SpeciesCategoryDesc)
                    .HasName("UX_species_category")
                    .IsUnique();

                entity.Property(e => e.SpeciesCategoryId).HasColumnName("species_category_id");

                entity.Property(e => e.SpeciesCategoryDesc)
                    .IsRequired()
                    .HasColumnName("species_category_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SpeciesGroup>(entity =>
            {
                entity.ToTable("species_group", "REF");

                entity.HasIndex(e => e.SpeciesGroupDesc)
                    .HasName("UX_species_group")
                    .IsUnique();

                entity.Property(e => e.SpeciesGroupId)
                    .HasColumnName("species_group_id")
                    .HasMaxLength(3)
                    .ValueGeneratedNever();

                entity.Property(e => e.SpeciesGroupDesc)
                    .IsRequired()
                    .HasColumnName("species_group_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SpeciesLenwt>(entity =>
            {
                entity.HasKey(e => e.SpId);

                entity.ToTable("species_lenwt", "QRY");

                entity.Property(e => e.SpId)
                    .HasColumnName("sp_id")
                    .HasMaxLength(3)
                    .ValueGeneratedNever();

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.LenId)
                    .HasColumnName("len_id")
                    .HasMaxLength(2);

                entity.Property(e => e.LenwtA)
                    .HasColumnName("lenwt_a")
                    .HasColumnType("decimal(16, 12)");

                entity.Property(e => e.LenwtB)
                    .HasColumnName("lenwt_b")
                    .HasColumnType("decimal(16, 12)");

                entity.Property(e => e.Main)
                    .HasColumnName("main")
                    .HasMaxLength(1);

                entity.Property(e => e.N)
                    .HasColumnName("n")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.RSq)
                    .HasColumnName("r_sq")
                    .HasColumnType("decimal(6, 4)");

                entity.Property(e => e.SexId)
                    .HasColumnName("sex_id")
                    .HasMaxLength(1);

                entity.Property(e => e.Source).HasColumnName("source");

                entity.Property(e => e.SubSpId)
                    .HasColumnName("sub_sp_id")
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<SpeciesNameCategory>(entity =>
            {
                entity.ToTable("species_name_category", "REF");

                entity.HasIndex(e => e.SpeciesNameCategoryDesc)
                    .HasName("UX_species_name_category")
                    .IsUnique();

                entity.Property(e => e.SpeciesNameCategoryId)
                    .HasColumnName("species_name_category_id")
                    .HasMaxLength(3)
                    .ValueGeneratedNever();

                entity.Property(e => e.SpeciesNameCategoryDesc)
                    .IsRequired()
                    .HasColumnName("species_name_category_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SpecimenBird>(entity =>
            {
                entity.ToTable("specimen_bird", "BIO");

                entity.Property(e => e.SpecimenBirdId).HasColumnName("specimen_bird_id");

                entity.Property(e => e.BirdDevelopmentId)
                    .HasColumnName("bird_development_id")
                    .HasMaxLength(1);

                entity.Property(e => e.BirdReproductionId)
                    .HasColumnName("bird_reproduction_id")
                    .HasMaxLength(1);

                entity.Property(e => e.BirdStatusId)
                    .HasColumnName("bird_status_id")
                    .HasMaxLength(1);

                entity.Property(e => e.BurrowNo)
                    .HasColumnName("burrow_no")
                    .HasMaxLength(50);

                entity.Property(e => e.SpecimenId).HasColumnName("specimen_id");

                entity.HasOne(d => d.BirdDevelopment)
                    .WithMany(p => p.SpecimenBird)
                    .HasForeignKey(d => d.BirdDevelopmentId)
                    .HasConstraintName("FK_specimen_bird_bird_development");

                entity.HasOne(d => d.BirdReproduction)
                    .WithMany(p => p.SpecimenBird)
                    .HasForeignKey(d => d.BirdReproductionId)
                    .HasConstraintName("FK_specimen_bird_bird_reproduction");

                entity.HasOne(d => d.BirdStatus)
                    .WithMany(p => p.SpecimenBird)
                    .HasForeignKey(d => d.BirdStatusId)
                    .HasConstraintName("FK_specimen_bird_bird_status");

                entity.HasOne(d => d.Specimen)
                    .WithMany(p => p.SpecimenBird)
                    .HasForeignKey(d => d.SpecimenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_specimen_bird_specimen");
            });

            modelBuilder.Entity<SpecimenBirdLength>(entity =>
            {
                entity.ToTable("specimen_bird_length", "BIO");

                entity.HasIndex(e => new { e.SpecimenBirdId, e.BirdLengthCodeId })
                    .HasName("UX_specimen_bird_length")
                    .IsUnique();

                entity.Property(e => e.SpecimenBirdLengthId).HasColumnName("specimen_bird_length_id");

                entity.Property(e => e.BirdLengthCodeId)
                    .IsRequired()
                    .HasColumnName("bird_length_code_id")
                    .HasMaxLength(3);

                entity.Property(e => e.BirdLengthMm).HasColumnName("bird_length_mm");

                entity.Property(e => e.SpecimenBirdId).HasColumnName("specimen_bird_id");

                entity.HasOne(d => d.BirdLengthCode)
                    .WithMany(p => p.SpecimenBirdLength)
                    .HasForeignKey(d => d.BirdLengthCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_specimen_bird_length_bird_length_code");

                entity.HasOne(d => d.SpecimenBird)
                    .WithMany(p => p.SpecimenBirdLength)
                    .HasForeignKey(d => d.SpecimenBirdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_specimen_bird_length_specimen_bird");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.ToTable("staff", "STAFF");

                entity.HasIndex(e => e.FullName)
                    .HasName("UX_staff")
                    .IsUnique();

                entity.Property(e => e.StaffId).HasColumnName("staff_id");

                entity.Property(e => e.BirthDate)
                    .HasColumnName("birth_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CountryId)
                    .IsRequired()
                    .HasColumnName("country_id")
                    .HasMaxLength(2);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([date],getdate(),(0)))");

                entity.Property(e => e.CreatorName)
                    .HasColumnName("creator_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.FamilyName)
                    .IsRequired()
                    .HasColumnName("family_name")
                    .HasMaxLength(30);

                entity.Property(e => e.FinishingDate)
                    .HasColumnName("finishing_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(30);

                entity.Property(e => e.FullName)
                    .HasColumnName("full_name")
                    .HasMaxLength(61)
                    .HasComputedColumnSql("((ltrim(rtrim([first_name]))+' ')+ltrim(rtrim([family_name])))");

                entity.Property(e => e.IsAnalyser).HasColumnName("is_analyser");

                entity.Property(e => e.IsContact).HasColumnName("is_contact");

                entity.Property(e => e.IsDataEditor).HasColumnName("is_data_editor");

                entity.Property(e => e.IsDebriefer).HasColumnName("is_debriefer");

                entity.Property(e => e.IsInventoryOfficer).HasColumnName("is_inventory_officer");

                entity.Property(e => e.IsSampler).HasColumnName("is_sampler");

                entity.Property(e => e.IsStillActive)
                    .IsRequired()
                    .HasColumnName("is_still_active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsStockSupervisor).HasColumnName("is_stock_supervisor");

                entity.Property(e => e.IsTrainee).HasColumnName("is_trainee");

                entity.Property(e => e.IsTrainer).HasColumnName("is_trainer");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phone_number")
                    .HasMaxLength(20);

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasMaxLength(50);

                entity.Property(e => e.StartingDate)
                    .HasColumnName("starting_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TmpId).HasColumnName("TMP_id");

                entity.Property(e => e.TubsCode)
                    .HasColumnName("TUBS_code")
                    .HasMaxLength(3);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Staff)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_staff_country");
            });

            modelBuilder.Entity<StomachStatus>(entity =>
            {
                entity.ToTable("stomach_status", "REF");

                entity.HasIndex(e => e.StomachStatusDesc)
                    .HasName("UX_stomach_status")
                    .IsUnique();

                entity.Property(e => e.StomachStatusId)
                    .HasColumnName("stomach_status_id")
                    .HasMaxLength(3)
                    .ValueGeneratedNever();

                entity.Property(e => e.StomachStatusDesc)
                    .IsRequired()
                    .HasColumnName("stomach_status_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<StorageQuality>(entity =>
            {
                entity.ToTable("storage_quality", "REF");

                entity.HasIndex(e => e.StorageQualityDesc)
                    .HasName("UX_storage_quality")
                    .IsUnique();

                entity.Property(e => e.StorageQualityId)
                    .HasColumnName("storage_quality_id")
                    .HasMaxLength(1)
                    .ValueGeneratedNever();

                entity.Property(e => e.OoWeight).HasColumnName("OO_weight");

                entity.Property(e => e.StorageQualityDesc)
                    .IsRequired()
                    .HasColumnName("storage_quality_desc")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<StorageQualityCondition>(entity =>
            {
                entity.HasKey(e => e.StorageConditionId);

                entity.ToTable("storage_quality_condition", "QRY");

                entity.HasIndex(e => e.StorageQualityId)
                    .HasName("IX_storage_quality_condition_storage");

                entity.HasIndex(e => e.TissueConditionId)
                    .HasName("IX_storage_quality_condition_condition");

                entity.HasIndex(e => new { e.StorageQualityId, e.TissueConditionId })
                    .HasName("UX_storage_quality_condition")
                    .IsUnique();

                entity.Property(e => e.StorageConditionId).HasColumnName("storage_condition_id");

                entity.Property(e => e.StorageQualityId)
                    .IsRequired()
                    .HasColumnName("storage_quality_id")
                    .HasMaxLength(1);

                entity.Property(e => e.TissueConditionId)
                    .IsRequired()
                    .HasColumnName("tissue_condition_id")
                    .HasMaxLength(2);

                entity.HasOne(d => d.StorageQuality)
                    .WithMany(p => p.StorageQualityCondition)
                    .HasForeignKey(d => d.StorageQualityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_storage_quality_condition_storage_quality");

                entity.HasOne(d => d.TissueCondition)
                    .WithMany(p => p.StorageQualityCondition)
                    .HasForeignKey(d => d.TissueConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_storage_quality_condition_tissue_condition");
            });

            modelBuilder.Entity<Swimbladder>(entity =>
            {
                entity.ToTable("swimbladder", "REF");

                entity.HasIndex(e => e.SwimbladderAttribute)
                    .HasName("UX_swimbladder")
                    .IsUnique();

                entity.Property(e => e.SwimbladderId)
                    .HasColumnName("swimbladder_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SwimbladderAttribute)
                    .IsRequired()
                    .HasColumnName("swimbladder_attribute")
                    .HasMaxLength(50);

                entity.Property(e => e.SwimbladderDesc)
                    .IsRequired()
                    .HasColumnName("swimbladder_desc");
            });

            modelBuilder.Entity<TargetGroup>(entity =>
            {
                entity.ToTable("target_group", "REF");

                entity.HasIndex(e => e.TargetGroupDesc)
                    .HasName("UX_target_group")
                    .IsUnique();

                entity.Property(e => e.TargetGroupId)
                    .HasColumnName("target_group_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TargetGroupDesc)
                    .IsRequired()
                    .HasColumnName("target_group_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TissueCondition>(entity =>
            {
                entity.ToTable("tissue_condition", "REF");

                entity.HasIndex(e => e.TissueConditionDesc)
                    .HasName("UX_tissue_condition")
                    .IsUnique();

                entity.Property(e => e.TissueConditionId)
                    .HasColumnName("tissue_condition_id")
                    .HasMaxLength(2)
                    .ValueGeneratedNever();

                entity.Property(e => e.TissueConditionDesc)
                    .IsRequired()
                    .HasColumnName("tissue_condition_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TissuePosition>(entity =>
            {
                entity.ToTable("tissue_position", "REF");

                entity.HasIndex(e => e.TissuePositionDesc)
                    .HasName("UX_Tissue_Position")
                    .IsUnique();

                entity.Property(e => e.TissuePositionId)
                    .HasColumnName("tissue_position_id")
                    .HasMaxLength(2)
                    .ValueGeneratedNever();

                entity.Property(e => e.TissuePositionDesc)
                    .IsRequired()
                    .HasColumnName("tissue_position_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TissueSide>(entity =>
            {
                entity.ToTable("tissue_side", "REF");

                entity.HasIndex(e => e.TissueSideDesc)
                    .HasName("UX_tissue_side")
                    .IsUnique();

                entity.Property(e => e.TissueSideId)
                    .HasColumnName("tissue_side_id")
                    .HasMaxLength(1)
                    .ValueGeneratedNever();

                entity.Property(e => e.TissueSideDesc)
                    .IsRequired()
                    .HasColumnName("tissue_side_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TissueStateOld>(entity =>
            {
                entity.HasKey(e => e.TissueStateId);

                entity.ToTable("tissue_state_OLD", "REF");

                entity.HasIndex(e => e.TissueStateDesc)
                    .HasName("UX_tissue_state")
                    .IsUnique();

                entity.Property(e => e.TissueStateId)
                    .HasColumnName("tissue_state_id")
                    .HasMaxLength(1)
                    .ValueGeneratedNever();

                entity.Property(e => e.TissueStateDesc)
                    .IsRequired()
                    .HasColumnName("tissue_state_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TissueType>(entity =>
            {
                entity.ToTable("tissue_type", "REF");

                entity.HasIndex(e => e.TissueTypeDesc)
                    .HasName("UX_Tissue_Type")
                    .IsUnique();

                entity.Property(e => e.TissueTypeId)
                    .HasColumnName("tissue_type_id")
                    .HasMaxLength(2)
                    .ValueGeneratedNever();

                entity.Property(e => e.IsWeb).HasColumnName("is_web");

                entity.Property(e => e.TissueColor)
                    .HasColumnName("tissue_color")
                    .HasMaxLength(7);

                entity.Property(e => e.TissueTypeDesc)
                    .IsRequired()
                    .HasColumnName("tissue_type_desc")
                    .HasMaxLength(50);

                entity.Property(e => e.TissueTypeGroup)
                    .IsRequired()
                    .HasColumnName("tissue_type_group")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TowMethod>(entity =>
            {
                entity.ToTable("tow_method", "REF");

                entity.HasIndex(e => e.TowMethodDesc)
                    .HasName("UX_tow_method")
                    .IsUnique();

                entity.Property(e => e.TowMethodId)
                    .HasColumnName("tow_method_id")
                    .HasMaxLength(1)
                    .ValueGeneratedNever();

                entity.Property(e => e.TowMethodDesc)
                    .IsRequired()
                    .HasColumnName("tow_method_desc")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Training>(entity =>
            {
                entity.ToTable("training", "STAFF");

                entity.HasIndex(e => e.TrainerStaffId);

                entity.HasIndex(e => e.TrainingTypeId)
                    .HasName("IX_training_type");

                entity.HasIndex(e => new { e.TrainingTypeId, e.TrainingDate, e.TrainingLocation })
                    .HasName("UX_training")
                    .IsUnique();

                entity.Property(e => e.TrainingId).HasColumnName("training_id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.TrainerStaffId).HasColumnName("trainer_staff_id");

                entity.Property(e => e.TrainerStaffId2).HasColumnName("trainer_staff_id_2");

                entity.Property(e => e.TrainerStaffId3).HasColumnName("trainer_staff_id_3");

                entity.Property(e => e.TrainingDate)
                    .HasColumnName("training_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TrainingLocation)
                    .IsRequired()
                    .HasColumnName("training_location")
                    .HasMaxLength(50);

                entity.Property(e => e.TrainingTypeId).HasColumnName("training_type_id");

                entity.HasOne(d => d.TrainerStaff)
                    .WithMany(p => p.TrainingTrainerStaff)
                    .HasForeignKey(d => d.TrainerStaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_training_trainer");

                entity.HasOne(d => d.TrainerStaffId2Navigation)
                    .WithMany(p => p.TrainingTrainerStaffId2Navigation)
                    .HasForeignKey(d => d.TrainerStaffId2)
                    .HasConstraintName("FK_training_trainer_2");

                entity.HasOne(d => d.TrainerStaffId3Navigation)
                    .WithMany(p => p.TrainingTrainerStaffId3Navigation)
                    .HasForeignKey(d => d.TrainerStaffId3)
                    .HasConstraintName("FK_training_trainer_3");

                entity.HasOne(d => d.TrainingType)
                    .WithMany(p => p.Training)
                    .HasForeignKey(d => d.TrainingTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_training_training_type");
            });

            modelBuilder.Entity<TrainingModule>(entity =>
            {
                entity.ToTable("training_module", "REF");

                entity.Property(e => e.TrainingModuleId).HasColumnName("training_module_id");

                entity.Property(e => e.TrainingModuleDesc)
                    .IsRequired()
                    .HasColumnName("training_module_desc")
                    .HasMaxLength(50);

                entity.Property(e => e.TrainingModuleFull).HasColumnName("training_module_full");
            });

            modelBuilder.Entity<TrainingStaff>(entity =>
            {
                entity.ToTable("training_staff", "STAFF");

                entity.HasIndex(e => e.StaffId)
                    .HasName("IX_training_staff_staff");

                entity.HasIndex(e => e.TrainingId);

                entity.HasIndex(e => new { e.TrainingId, e.StaffId })
                    .HasName("UX_training_staff")
                    .IsUnique();

                entity.Property(e => e.TrainingStaffId).HasColumnName("training_staff_id");

                entity.Property(e => e.CertificateNo)
                    .HasColumnName("certificate_no")
                    .HasMaxLength(10);

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.OverallResult).HasColumnName("overall_result");

                entity.Property(e => e.StaffId).HasColumnName("staff_id");

                entity.Property(e => e.TrainingId).HasColumnName("training_id");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.TrainingStaff)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK_training_staff_staff");

                entity.HasOne(d => d.Training)
                    .WithMany(p => p.TrainingStaff)
                    .HasForeignKey(d => d.TrainingId)
                    .HasConstraintName("FK_training_staff_training");
            });

            modelBuilder.Entity<TrainingStaffCourse>(entity =>
            {
                entity.ToTable("training_staff_course", "STAFF");

                entity.HasIndex(e => e.TrainingModuleId)
                    .HasName("IX_training_staff_module");

                entity.HasIndex(e => e.TrainingStaffId)
                    .HasName("IX_training_staff_course_staff");

                entity.HasIndex(e => new { e.TrainingStaffId, e.TrainingModuleId })
                    .HasName("UX_training_staff_course")
                    .IsUnique();

                entity.Property(e => e.TrainingStaffCourseId).HasColumnName("training_staff_course_id");

                entity.Property(e => e.CourseDetails)
                    .HasColumnName("course_details")
                    .HasMaxLength(200);

                entity.Property(e => e.CourseResult).HasColumnName("course_result");

                entity.Property(e => e.TrainingCourseIdOld).HasColumnName("training_course_id_OLD");

                entity.Property(e => e.TrainingModuleId).HasColumnName("training_module_id");

                entity.Property(e => e.TrainingStaffId).HasColumnName("training_staff_id");

                entity.HasOne(d => d.TrainingModule)
                    .WithMany(p => p.TrainingStaffCourse)
                    .HasForeignKey(d => d.TrainingModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_training_staff_course_training_course");

                entity.HasOne(d => d.TrainingStaff)
                    .WithMany(p => p.TrainingStaffCourse)
                    .HasForeignKey(d => d.TrainingStaffId)
                    .HasConstraintName("FK_training_staff_course_training_staff");
            });

            modelBuilder.Entity<TrainingType>(entity =>
            {
                entity.ToTable("training_type", "REF");

                entity.Property(e => e.TrainingTypeId).HasColumnName("training_type_id");

                entity.Property(e => e.TrainingTypeDesc)
                    .IsRequired()
                    .HasColumnName("training_type_desc")
                    .HasMaxLength(50);

                entity.Property(e => e.TrainingTypeFull).HasColumnName("training_type_full");
            });

            modelBuilder.Entity<Trip>(entity =>
            {
                entity.ToTable("trip", "BIO");

                entity.HasIndex(e => e.CountryCodeId)
                    .HasName("IX_trip_country_code");

                entity.HasIndex(e => e.CountryFlagId)
                    .HasName("IX_trip_flag");

                entity.HasIndex(e => e.DepartureLocationCode)
                    .HasName("IX_trip_departure");

                entity.HasIndex(e => e.GearId)
                    .HasName("IX_trip_gear");

                entity.HasIndex(e => e.ReturnLocationCode)
                    .HasName("IX_trip_return");

                entity.HasIndex(e => e.TripTypeId)
                    .HasName("IX_trip_type");

                entity.HasIndex(e => new { e.TripName, e.TripNo })
                    .HasName("UX_trip")
                    .IsUnique();

                entity.Property(e => e.TripId).HasColumnName("trip_id");

                entity.Property(e => e.AlternateTripName)
                    .HasColumnName("alternate_trip_name")
                    .HasMaxLength(30);

                entity.Property(e => e.CheckComment).HasColumnName("check_comment");

                entity.Property(e => e.CheckDate)
                    .HasColumnName("check_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CheckerName)
                    .HasColumnName("checker_name")
                    .HasMaxLength(50);

                entity.Property(e => e.CheckingStatus).HasColumnName("checking_status");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CountryCodeId)
                    .IsRequired()
                    .HasColumnName("country_code_id")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'XX')");

                entity.Property(e => e.CountryFlagId)
                    .HasColumnName("country_flag_id")
                    .HasMaxLength(2);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([date],getdate(),(0)))");

                entity.Property(e => e.DepartureDate)
                    .HasColumnName("departure_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartureLocationCode)
                    .HasColumnName("departure_location_code")
                    .HasMaxLength(5);

                entity.Property(e => e.GearId)
                    .HasColumnName("gear_id")
                    .HasMaxLength(1);

                entity.Property(e => e.IsDbChecked).HasColumnName("is_db_checked");

                entity.Property(e => e.ObsprgCode)
                    .HasColumnName("obsprg_code")
                    .HasMaxLength(4);

                entity.Property(e => e.ObstripIdOld).HasColumnName("obstrip_id_OLD");

                entity.Property(e => e.ReturnDate)
                    .HasColumnName("return_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReturnLocationCode)
                    .HasColumnName("return_location_code")
                    .HasMaxLength(5);

                entity.Property(e => e.SamplerStaffId).HasColumnName("sampler_staff_id");

                entity.Property(e => e.SamplerStaffId2).HasColumnName("sampler_staff_id_2");

                entity.Property(e => e.SamplerStaffId3).HasColumnName("sampler_staff_id_3");

                entity.Property(e => e.T2TripId).HasColumnName("T2_trip_id");

                entity.Property(e => e.TagdagerNo)
                    .HasColumnName("tagdager_no")
                    .HasMaxLength(70);

                entity.Property(e => e.TripName)
                    .IsRequired()
                    .HasColumnName("trip_name")
                    .HasMaxLength(30);

                entity.Property(e => e.TripNo)
                    .IsRequired()
                    .HasColumnName("trip_no")
                    .HasMaxLength(15);

                entity.Property(e => e.TripTypeId).HasColumnName("trip_type_id");

                entity.Property(e => e.VesselName)
                    .HasColumnName("vessel_name")
                    .HasMaxLength(200);

                entity.HasOne(d => d.CountryCode)
                    .WithMany(p => p.Trip)
                    .HasForeignKey(d => d.CountryCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_trip_country_departure");

                entity.HasOne(d => d.DepartureLocationCodeNavigation)
                    .WithMany(p => p.TripDepartureLocationCodeNavigation)
                    .HasForeignKey(d => d.DepartureLocationCode)
                    .HasConstraintName("FK_trip_port_departure");

                entity.HasOne(d => d.ReturnLocationCodeNavigation)
                    .WithMany(p => p.TripReturnLocationCodeNavigation)
                    .HasForeignKey(d => d.ReturnLocationCode)
                    .HasConstraintName("FK_trip_port_return");

                entity.HasOne(d => d.SamplerStaff)
                    .WithMany(p => p.TripSamplerStaff)
                    .HasForeignKey(d => d.SamplerStaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_trip_staff");

                entity.HasOne(d => d.SamplerStaffId2Navigation)
                    .WithMany(p => p.TripSamplerStaffId2Navigation)
                    .HasForeignKey(d => d.SamplerStaffId2)
                    .HasConstraintName("FK_trip_staff_2");

                entity.HasOne(d => d.SamplerStaffId3Navigation)
                    .WithMany(p => p.TripSamplerStaffId3Navigation)
                    .HasForeignKey(d => d.SamplerStaffId3)
                    .HasConstraintName("FK_trip_staff_3");

                entity.HasOne(d => d.TripType)
                    .WithMany(p => p.Trip)
                    .HasForeignKey(d => d.TripTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_trip_trip_type");
            });

            modelBuilder.Entity<TripTubsLink>(entity =>
            {
                entity.HasKey(e => new { e.TripId, e.ObstripId });

                entity.ToTable("trip_TUBS_link", "QRY");

                entity.Property(e => e.TripId).HasColumnName("trip_id");

                entity.Property(e => e.ObstripId).HasColumnName("obstrip_id");

                entity.HasOne(d => d.Trip)
                    .WithMany(p => p.TripTubsLink)
                    .HasForeignKey(d => d.TripId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_trip_TUBS_link_trip");
            });

            modelBuilder.Entity<TripType>(entity =>
            {
                entity.ToTable("trip_type", "REF");

                entity.HasIndex(e => e.TripTypeDesc)
                    .HasName("UX_trip_type")
                    .IsUnique();

                entity.Property(e => e.TripTypeId).HasColumnName("trip_type_id");

                entity.Property(e => e.TripGroup)
                    .IsRequired()
                    .HasColumnName("trip_group")
                    .HasMaxLength(3);

                entity.Property(e => e.TripTypeDesc)
                    .IsRequired()
                    .HasColumnName("trip_type_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VerticalClass>(entity =>
            {
                entity.ToTable("vertical_class", "REF");

                entity.HasIndex(e => e.VerticalClassDesc)
                    .HasName("UX_vertical_class")
                    .IsUnique();

                entity.Property(e => e.VerticalClassId)
                    .HasColumnName("vertical_class_id")
                    .HasMaxLength(2)
                    .ValueGeneratedNever();

                entity.Property(e => e.VerticalClassDesc)
                    .IsRequired()
                    .HasColumnName("vertical_class_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VolumeSamplingFreight>(entity =>
            {
                entity.ToTable("volume_sampling_freight", "REF");

                entity.HasIndex(e => e.VolumeSamplingFreightDesc)
                    .HasName("UX_volume_sampling_freight")
                    .IsUnique();

                entity.Property(e => e.VolumeSamplingFreightId)
                    .HasColumnName("volume_sampling_freight_id")
                    .HasMaxLength(1)
                    .ValueGeneratedNever();

                entity.Property(e => e.VolumeSamplingFreightDesc)
                    .IsRequired()
                    .HasColumnName("volume_sampling_freight_desc")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<WeightCode>(entity =>
            {
                entity.ToTable("weight_code", "REF");

                entity.HasIndex(e => e.WeightCodeDesc)
                    .HasName("UX_weight_code")
                    .IsUnique();

                entity.Property(e => e.WeightCodeId)
                    .HasColumnName("weight_code_id")
                    .HasMaxLength(2)
                    .ValueGeneratedNever();

                entity.Property(e => e.WeightCodeDesc)
                    .IsRequired()
                    .HasColumnName("weight_code_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<YearCalendar>(entity =>
            {
                entity.HasKey(e => e.YearDb);

                entity.ToTable("year_calendar", "DB");

                entity.Property(e => e.YearDb)
                    .HasColumnName("year_db")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ZooplanktonDepthSpecimen>(entity =>
            {
                entity.HasKey(e => new { e.SetZooplanktonId, e.FishId });

                entity.ToTable("zooplankton_depth_specimen", "QRY");

                entity.Property(e => e.SetZooplanktonId).HasColumnName("set_zooplankton_id");

                entity.Property(e => e.FishId).HasColumnName("fish_id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.HasOne(d => d.Fish)
                    .WithMany(p => p.ZooplanktonDepthSpecimen)
                    .HasForeignKey(d => d.FishId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_zooplankton_depth_specimen_fish");

                entity.HasOne(d => d.SetZooplankton)
                    .WithMany(p => p.ZooplanktonDepthSpecimen)
                    .HasForeignKey(d => d.SetZooplanktonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_zooplankton_depth_specimen_set_biological_zooplankton");
            });
        }
    }
}
