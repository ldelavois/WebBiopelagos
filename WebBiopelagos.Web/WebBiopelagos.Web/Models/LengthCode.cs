using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class LengthCode
    {
        public LengthCode()
        {
            AnalysisStomachPreyIndividualLengthCodeId1Navigation = new HashSet<AnalysisStomachPreyIndividual>();
            AnalysisStomachPreyIndividualLengthCodeId2Navigation = new HashSet<AnalysisStomachPreyIndividual>();
            AnalysisStomachPreyIndividualLengthCodeId3Navigation = new HashSet<AnalysisStomachPreyIndividual>();
            FishLengthCode = new HashSet<Fish>();
            FishLengthCodeId2Navigation = new HashSet<Fish>();
            FishLengthCodeId3Navigation = new HashSet<Fish>();
            ForageIndividualLengthCodeId1Navigation = new HashSet<ForageIndividual>();
            ForageIndividualLengthCodeId2Navigation = new HashSet<ForageIndividual>();
            ForageIndividualLengthCodeId3Navigation = new HashSet<ForageIndividual>();
            Species = new HashSet<Species>();
        }

        public string LengthCodeId { get; set; }
        public string LengthCodeDesc { get; set; }

        public ICollection<AnalysisStomachPreyIndividual> AnalysisStomachPreyIndividualLengthCodeId1Navigation { get; set; }
        public ICollection<AnalysisStomachPreyIndividual> AnalysisStomachPreyIndividualLengthCodeId2Navigation { get; set; }
        public ICollection<AnalysisStomachPreyIndividual> AnalysisStomachPreyIndividualLengthCodeId3Navigation { get; set; }
        public ICollection<Fish> FishLengthCode { get; set; }
        public ICollection<Fish> FishLengthCodeId2Navigation { get; set; }
        public ICollection<Fish> FishLengthCodeId3Navigation { get; set; }
        public ICollection<ForageIndividual> ForageIndividualLengthCodeId1Navigation { get; set; }
        public ICollection<ForageIndividual> ForageIndividualLengthCodeId2Navigation { get; set; }
        public ICollection<ForageIndividual> ForageIndividualLengthCodeId3Navigation { get; set; }
        public ICollection<Species> Species { get; set; }
    }
}
