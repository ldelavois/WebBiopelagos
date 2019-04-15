using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class HistoryFish
    {
        public int HistoryFishId { get; set; }
        public int FishId { get; set; }
        public int SpeciesId { get; set; }
        public double? LengthMm { get; set; }
        public string LengthCodeId { get; set; }
        public double? WeightGr { get; set; }
        public string WeightCodeId { get; set; }
        public string SexId { get; set; }
        public DateTime UpdatedDate { get; set; }

        public Fish Fish { get; set; }
    }
}
