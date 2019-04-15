using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class AnalysisStomachPreyItem
    {
        public AnalysisStomachPreyItem()
        {
            AnalysisStomachPreyIndividual = new HashSet<AnalysisStomachPreyIndividual>();
            FishPreyItemLink = new HashSet<FishPreyItemLink>();
        }

        public int AnalysisStomachPreyItemId { get; set; }
        public int AnalysisBaseStomachId { get; set; }
        public int SpeciesId { get; set; }
        public string PreyDevelopmentId { get; set; }
        public byte PreyDigestionId { get; set; }
        public int? IndividualsNb { get; set; }
        public double? TotalWeightGr { get; set; }
        public string CollectionReference { get; set; }
        public string Comment { get; set; }
        public int? TmpId { get; set; }

        public AnalysisStomachContent AnalysisBaseStomach { get; set; }
        public PreyDevelopment PreyDevelopment { get; set; }
        public PreyDigestion PreyDigestion { get; set; }
        public Species Species { get; set; }
        public ICollection<AnalysisStomachPreyIndividual> AnalysisStomachPreyIndividual { get; set; }
        public ICollection<FishPreyItemLink> FishPreyItemLink { get; set; }
    }
}
