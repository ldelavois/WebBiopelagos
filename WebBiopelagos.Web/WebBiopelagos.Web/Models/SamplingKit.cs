using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class SamplingKit
    {
        public SamplingKit()
        {
            KitSamplingLink = new HashSet<KitSamplingLink>();
        }

        public int SamplingKitId { get; set; }
        public string CountryId { get; set; }
        public string FirstTag { get; set; }
        public string LastTag { get; set; }
        public string CableTie { get; set; }
        public short CableTieNb { get; set; }
        public int? LabelFishUsed { get; set; }
        public DateTime? DispatchDate { get; set; }
        public string TransportedBy { get; set; }
        public string GivenTo { get; set; }
        public string Comment { get; set; }
        public int? TmpId { get; set; }

        public Country Country { get; set; }
        public ICollection<KitSamplingLink> KitSamplingLink { get; set; }
    }
}
