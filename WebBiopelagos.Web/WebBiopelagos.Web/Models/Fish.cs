using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class Fish
    {
        public Fish()
        {
            ChildSpecimenSampleLink = new HashSet<ChildSpecimenSampleLink>();
            FishForageIndividualLink = new HashSet<FishForageIndividualLink>();
            FishForageItemLink = new HashSet<FishForageItemLink>();
            FishPreyItemLink = new HashSet<FishPreyItemLink>();
            HistoryFish = new HashSet<HistoryFish>();
            RecapturedBird = new HashSet<RecapturedBird>();
            SampleBase = new HashSet<SampleBase>();
            SpecimenBird = new HashSet<SpecimenBird>();
            ZooplanktonDepthSpecimen = new HashSet<ZooplanktonDepthSpecimen>();
        }

        public int FishId { get; set; }
        public int? TmpPredatorId { get; set; }
        public int SetBaseId { get; set; }
        public string CsiroId { get; set; }
        public string FishTypeId { get; set; }
        public DateTime SamplingDate { get; set; }
        public string CatchTime { get; set; }
        public short? HookNo { get; set; }
        public short? ReelNo { get; set; }
        public short? DropNo { get; set; }
        public string FishNo { get; set; }
        public bool IsOfInterest { get; set; }
        public short? OwnershipId { get; set; }
        public int SpeciesId { get; set; }
        public double? LengthMm { get; set; }
        public string LengthCodeId { get; set; }
        public double? LengthMm2 { get; set; }
        public string LengthCodeId2 { get; set; }
        public double? LengthMm3 { get; set; }
        public string LengthCodeId3 { get; set; }
        public double? CalculatedWtGr { get; set; }
        public double? WeightGr { get; set; }
        public string WeightCodeId { get; set; }
        public double? GonadWeightGr { get; set; }
        public string SexId { get; set; }
        public string Photo1 { get; set; }
        public string Photo2 { get; set; }
        public string Photo3 { get; set; }
        public string Photo4 { get; set; }
        public DateTime? DataReceptionDate { get; set; }
        public DateTime? PaiementDate { get; set; }
        public string Comment { get; set; }
        public string EnteredByOld { get; set; }
        public DateTime? CreationDate { get; set; }
        public short EditorStaffId { get; set; }
        public short? EditorStaffId2 { get; set; }
        public byte[] Timestamp { get; set; }
        public int? TmpId { get; set; }

        public Staff EditorStaff { get; set; }
        public Staff EditorStaffId2Navigation { get; set; }
        public FishType FishType { get; set; }
        public LengthCode LengthCode { get; set; }
        public LengthCode LengthCodeId2Navigation { get; set; }
        public LengthCode LengthCodeId3Navigation { get; set; }
        public SetBase SetBase { get; set; }
        public Sex Sex { get; set; }
        public Species Species { get; set; }
        public WeightCode WeightCode { get; set; }
        public FishPreyIndividualLink FishPreyIndividualLink { get; set; }
        public ICollection<ChildSpecimenSampleLink> ChildSpecimenSampleLink { get; set; }
        public ICollection<FishForageIndividualLink> FishForageIndividualLink { get; set; }
        public ICollection<FishForageItemLink> FishForageItemLink { get; set; }
        public ICollection<FishPreyItemLink> FishPreyItemLink { get; set; }
        public ICollection<HistoryFish> HistoryFish { get; set; }
        public ICollection<RecapturedBird> RecapturedBird { get; set; }
        public ICollection<SampleBase> SampleBase { get; set; }
        public ICollection<SpecimenBird> SpecimenBird { get; set; }
        public ICollection<ZooplanktonDepthSpecimen> ZooplanktonDepthSpecimen { get; set; }
    }
}
