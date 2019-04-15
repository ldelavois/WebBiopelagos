using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class ManagementEntity
    {
        public ManagementEntity()
        {
            Sampling = new HashSet<Sampling>();
            SamplingFinance = new HashSet<SamplingFinance>();
        }

        public byte ManagementEntityId { get; set; }
        public string ManagementEntityName { get; set; }
        public string ManagementEntityDesc { get; set; }
        public string CountryId { get; set; }

        public Country Country { get; set; }
        public ICollection<Sampling> Sampling { get; set; }
        public ICollection<SamplingFinance> SamplingFinance { get; set; }
    }
}
