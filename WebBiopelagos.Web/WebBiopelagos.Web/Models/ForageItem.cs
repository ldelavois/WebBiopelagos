using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class ForageItem
    {
        public ForageItem()
        {
            FishForageItemLink = new HashSet<FishForageItemLink>();
            ForageIndividual = new HashSet<ForageIndividual>();
        }

        public int ForageItemId { get; set; }
        public int SetBaseId { get; set; }
        public int SpeciesId { get; set; }
        public string PreyDevelopmentId { get; set; }
        public byte ForageStateId { get; set; }
        public int? IndividualsNb { get; set; }
        public double? TotalWeightGr { get; set; }
        public double? WeightLossGr { get; set; }
        public string CollectionReference { get; set; }
        public string Comment { get; set; }
        public int? TmpId { get; set; }

        public ForageState ForageState { get; set; }
        public PreyDevelopment PreyDevelopment { get; set; }
        public SetBase SetBase { get; set; }
        public Species Species { get; set; }
        public ICollection<FishForageItemLink> FishForageItemLink { get; set; }
        public ICollection<ForageIndividual> ForageIndividual { get; set; }
    }
}
