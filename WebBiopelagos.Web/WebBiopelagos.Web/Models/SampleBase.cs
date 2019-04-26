using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebBiopelagos.Web.Models
{
    public partial class SampleBase
    {
        public SampleBase()
        {
            AnalysisBase = new HashSet<AnalysisBase>();
            ChildSpecimenSampleLink = new HashSet<ChildSpecimenSampleLink>();
            DbTransfer = new HashSet<DbTransfer>();
            FreightSampleLink = new HashSet<FreightSampleLink>();
            HistorySampleBase = new HashSet<HistorySampleBase>();
            SampleCommunity = new HashSet<SampleCommunity>();
            SampleGonad = new HashSet<SampleGonad>();
            SampleOther = new HashSet<SampleOther>();
            SampleOtolith = new HashSet<SampleOtolith>();
            SamplePendingAnalysis = new HashSet<SamplePendingAnalysis>();
        }

        [Display(Name = "ID Espèce associée")]
        public int FishId { get; set; }

        [Display(Name = "ID Echantillon")]
        public int SampleBaseId { get; set; }



        [Display(Name = "Numéro")]
        public string SampleNo { get; set; }

        [Display(Name = "Disponibilité")]
        public bool IsAvailable { get; set; }

        [Display(Name = "En attente d'analyse")]
        public bool IsPendingAnalysis { get; set; }

        [Display(Name = "Analysé")]
        public bool IsAnalyzed { get; set; }

        [Display(Name = "Equipe qualité")]
        public short? QualityStaffId { get; set; }

        [Display(Name = "Date position")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? LocationDate { get; set; }

        [Display(Name = "Date inventaire")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? InventoryDate { get; set; }

        [Display(Name = "Détail position")]
        public string LocationDetails { get; set; }

        [Display(Name = "Commentaires")]
        public string Comment { get; set; }

        [Display(Name = "Date de création")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreationDate { get; set; }

        public int? TmpId { get; set; }

        [Display(Name = "Numéro Espèce")]
        public Fish Fish { get; set; }

        [Display(Name = "Position congélateur")]
        public FreezerLocation FreezerLocation { get; set; }

        [Display(Name = "Position inventaire")]
        public Location InventoryLocation { get; set; }

        [Display(Name = "Equipe inventaire")]
        public Staff InventoryStaff { get; set; }

        [Display(Name = "Position propriétaire")]
        public Location OwnershipLocation { get; set; }

        [Display(Name = "Qualité stockage")]
        public StorageQuality StorageQuality { get; set; }

        [Display(Name = "Condition qualité stockage")]
        public StorageQualityCondition StorageQualityCondition { get; set; }

        public ConditionSampleType Tissue { get; set; }

        [Display(Name = "Condition tissue")]
        public TissueCondition TissueCondition { get; set; }

        [Display(Name = "Navigation tissue")]
        public PositionSampleType TissueNavigation { get; set; }

        [Display(Name = "Position tissue")]
        public TissuePosition TissuePosition { get; set; }

        [Display(Name = "Type tissue")]
        public TissueType TissueType { get; set; }


        public short OwnershipLocationId { get; set; }
        public double? PriceUsd { get; set; }
        public bool IsLost { get; set; }
        public DateTime? MissingDate { get; set; }
        public bool IsDiscarded { get; set; }
        public string TissueTypeId { get; set; }
        public string TissuePositionId { get; set; }
        public string TissueConditionId { get; set; }
        public string StorageQualityId { get; set; }
        public short? LastLocationId { get; set; }
        public short? InventoryLocationId { get; set; }
        public short? InventoryStaffId { get; set; }
        public byte? FreezerLocationId { get; set; }
        public bool IsTransfered { get; set; }
        public string InventoryLocationIdOld { get; set; }



        public ICollection<AnalysisBase> AnalysisBase { get; set; }
        public ICollection<ChildSpecimenSampleLink> ChildSpecimenSampleLink { get; set; }
        public ICollection<DbTransfer> DbTransfer { get; set; }
        public ICollection<FreightSampleLink> FreightSampleLink { get; set; }
        public ICollection<HistorySampleBase> HistorySampleBase { get; set; }
        public ICollection<SampleCommunity> SampleCommunity { get; set; }
        public ICollection<SampleGonad> SampleGonad { get; set; }
        public ICollection<SampleOther> SampleOther { get; set; }
        public ICollection<SampleOtolith> SampleOtolith { get; set; }
        public ICollection<SamplePendingAnalysis> SamplePendingAnalysis { get; set; }
    }
}
