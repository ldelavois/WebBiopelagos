using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class AnalysisStomachPreyIndividual
    {
        public int AnalysisStomachPreyIndividualId { get; set; }
        public int AnalysisStomachPreyItemId { get; set; }
        public double? LengthMm1 { get; set; }
        public string LengthCodeId1 { get; set; }
        public double? LengthMm2 { get; set; }
        public string LengthCodeId2 { get; set; }
        public double? LengthMm3 { get; set; }
        public string LengthCodeId3 { get; set; }
        public double? WeightGr { get; set; }
        public string SexId { get; set; }
        public string StomachSubSample { get; set; }
        public string Muscle { get; set; }
        public string CollectionReference { get; set; }
        public string Photo1 { get; set; }
        public string Photo2 { get; set; }
        public string Photo3 { get; set; }
        public string Photo4 { get; set; }
        public string Comment { get; set; }
        public int? TmpId { get; set; }

        public AnalysisStomachPreyItem AnalysisStomachPreyItem { get; set; }
        public LengthCode LengthCodeId1Navigation { get; set; }
        public LengthCode LengthCodeId2Navigation { get; set; }
        public LengthCode LengthCodeId3Navigation { get; set; }
        public Sex Sex { get; set; }
        public FishPreyIndividualLink FishPreyIndividualLink { get; set; }
    }
}
