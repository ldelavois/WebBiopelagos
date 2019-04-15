using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class SamplingFreight
    {
        public SamplingFreight()
        {
            FreightOrphanLink = new HashSet<FreightOrphanLink>();
            FreightSampleLink = new HashSet<FreightSampleLink>();
            FreightSamplingLink = new HashSet<FreightSamplingLink>();
            SampleUnknown = new HashSet<SampleUnknown>();
        }

        public int SamplingFreightId { get; set; }
        public short? FreightTypeId { get; set; }
        public short DepartureLocationId { get; set; }
        public short ArrivalLocationId { get; set; }
        public string QuarantineNo { get; set; }
        public DateTime DispatchDate { get; set; }
        public DateTime? ExpectedDate { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string FreightDetails { get; set; }
        public float? PriceUsd { get; set; }
        public string Comment { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? TmpId { get; set; }
        public string DepartureInventoryLocationIdOld { get; set; }
        public string ArrivalInventoryLocationIdOld { get; set; }

        public Location ArrivalLocation { get; set; }
        public Location DepartureLocation { get; set; }
        public ICollection<FreightOrphanLink> FreightOrphanLink { get; set; }
        public ICollection<FreightSampleLink> FreightSampleLink { get; set; }
        public ICollection<FreightSamplingLink> FreightSamplingLink { get; set; }
        public ICollection<SampleUnknown> SampleUnknown { get; set; }
    }
}
