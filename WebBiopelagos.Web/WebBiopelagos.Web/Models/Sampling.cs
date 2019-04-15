using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class Sampling
    {
        public Sampling()
        {
            FreightSamplingLink = new HashSet<FreightSamplingLink>();
            KitSamplingLink = new HashSet<KitSamplingLink>();
            SamplingFinance = new HashSet<SamplingFinance>();
        }

        public int SamplingId { get; set; }
        public int TripId { get; set; }
        public byte ManagementEntityId { get; set; }
        public DateTime? SamplingDate { get; set; }
        public string InstructionsQualityId { get; set; }
        public string BsFormQualityId { get; set; }
        public string PackagingQualityId { get; set; }
        public short? FishNb { get; set; }
        public string OtolithLocation { get; set; }
        public string SampleLocation { get; set; }
        public bool IsBsFormHardcopy { get; set; }
        public bool IsBsFormScanSaved { get; set; }
        public bool IsTroFileSaved { get; set; }
        public bool IsDataChecked { get; set; }
        public bool IsSampleChecked { get; set; }
        public bool IsFreezerInventory { get; set; }
        public bool IsTemporaryImportation { get; set; }
        public bool IsFinalImportation { get; set; }
        public bool IsDebriefed { get; set; }
        public bool IsTripToFollow { get; set; }
        public string FollowerName { get; set; }
        public string GeneralComments { get; set; }
        public string CommentsSampler { get; set; }
        public DateTime? DateLastUpdate { get; set; }
        public int? TmpId { get; set; }

        public Quality BsFormQuality { get; set; }
        public Quality InstructionsQuality { get; set; }
        public ManagementEntity ManagementEntity { get; set; }
        public Quality PackagingQuality { get; set; }
        public Trip Trip { get; set; }
        public ICollection<FreightSamplingLink> FreightSamplingLink { get; set; }
        public ICollection<KitSamplingLink> KitSamplingLink { get; set; }
        public ICollection<SamplingFinance> SamplingFinance { get; set; }
    }
}
