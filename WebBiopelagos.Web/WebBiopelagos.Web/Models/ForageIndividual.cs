using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class ForageIndividual
    {
        public ForageIndividual()
        {
            FishForageIndividualLink = new HashSet<FishForageIndividualLink>();
        }

        public int ForageIndividualId { get; set; }
        public int ForageItemId { get; set; }
        public double? LengthMm1 { get; set; }
        public string LengthCodeId1 { get; set; }
        public double? LengthMm2 { get; set; }
        public string LengthCodeId2 { get; set; }
        public double? LengthMm3 { get; set; }
        public string LengthCodeId3 { get; set; }
        public double? WeightGr { get; set; }
        public double? WeightLossGr { get; set; }
        public string SexId { get; set; }
        public string CollectionReference { get; set; }
        public string Photo1 { get; set; }
        public string Photo2 { get; set; }
        public string Photo3 { get; set; }
        public string Photo4 { get; set; }
        public string PhotoXray { get; set; }
        public string Comment { get; set; }
        public string PreservationComment { get; set; }
        public string EnteredBy { get; set; }
        public string VerifiedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? TmpId { get; set; }

        public ForageItem ForageItem { get; set; }
        public LengthCode LengthCodeId1Navigation { get; set; }
        public LengthCode LengthCodeId2Navigation { get; set; }
        public LengthCode LengthCodeId3Navigation { get; set; }
        public Sex Sex { get; set; }
        public ICollection<FishForageIndividualLink> FishForageIndividualLink { get; set; }
    }
}
