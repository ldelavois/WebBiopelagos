using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebBiopelagos.Web.Models
{
    public partial class AnalysisBase
    {
        public AnalysisBase()
        {
            AnalysisAging = new HashSet<AnalysisAging>();
            AnalysisContaminant = new HashSet<AnalysisContaminant>();
            AnalysisFatmeter = new HashSet<AnalysisFatmeter>();
            AnalysisGenetic = new HashSet<AnalysisGenetic>();
            AnalysisIsotope = new HashSet<AnalysisIsotope>();
            AnalysisLipid = new HashSet<AnalysisLipid>();
            AnalysisQuantity = new HashSet<AnalysisQuantity>();
            AnalysisSizeStructure = new HashSet<AnalysisSizeStructure>();
            AnalysisStomachContent = new HashSet<AnalysisStomachContent>();
            PublicationAnalysisLink = new HashSet<PublicationAnalysisLink>();
        }

        [Display(Name = "ID Analyse")]
        public int AnalysisBaseId { get; set; }

        [Display(Name = "ID Echantillon")]
        public int SampleBaseId { get; set; }

        [Display(Name = "Type Tissue")]
        public string TissueTypeId { get; set; }

        [Display(Name = "Type")]
        public string AnalysisTypeId { get; set; }

        [Display(Name = "Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime AnalysisDate { get; set; }

        [Display(Name = "Date création")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreationDate { get; set; }

        public short LaboratoryLocationId { get; set; }
        public string LocationDetails { get; set; }

        public short AnalyserStaffId { get; set; }
        public short? AnalyserStaffId2 { get; set; }
        public short? AnalyserStaffId3 { get; set; }
        public string Comment { get; set; }

        public int? TmpId { get; set; }
        public string AnalyzedByOld { get; set; }
        public byte? LaboratoryIdOld { get; set; }

        [Display(Name = "Equipe analyse")]
        public Staff AnalyserStaff { get; set; }
        public Staff AnalyserStaffId2Navigation { get; set; }
        public Staff AnalyserStaffId3Navigation { get; set; }
        public AnalysisSampleType AnalysisSampleType { get; set; }
        public AnalysisType AnalysisType { get; set; }

        [Display(Name = "Laboratoire")]
        public Location LaboratoryLocation { get; set; }
        public SampleBase SampleBase { get; set; }
        public TissueType TissueType { get; set; }
        public AnalysisHistology AnalysisHistology { get; set; }
        public ICollection<AnalysisAging> AnalysisAging { get; set; }
        public ICollection<AnalysisContaminant> AnalysisContaminant { get; set; }
        public ICollection<AnalysisFatmeter> AnalysisFatmeter { get; set; }
        public ICollection<AnalysisGenetic> AnalysisGenetic { get; set; }
        public ICollection<AnalysisIsotope> AnalysisIsotope { get; set; }
        public ICollection<AnalysisLipid> AnalysisLipid { get; set; }
        public ICollection<AnalysisQuantity> AnalysisQuantity { get; set; }
        public ICollection<AnalysisSizeStructure> AnalysisSizeStructure { get; set; }
        public ICollection<AnalysisStomachContent> AnalysisStomachContent { get; set; }
        public ICollection<PublicationAnalysisLink> PublicationAnalysisLink { get; set; }
    }
}
