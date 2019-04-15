using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class Country
    {
        public Country()
        {
            EezIw = new HashSet<EezIw>();
            Location = new HashSet<Location>();
            ManagementEntity = new HashSet<ManagementEntity>();
            Objectives = new HashSet<Objectives>();
            Port = new HashSet<Port>();
            SampleUnknown = new HashSet<SampleUnknown>();
            SamplingKit = new HashSet<SamplingKit>();
            Staff = new HashSet<Staff>();
            Trip = new HashSet<Trip>();
        }

        public string CountryId { get; set; }
        public string CountryName { get; set; }
        public bool IsPacificOcean { get; set; }
        public string CountryFull { get; set; }

        public ICollection<EezIw> EezIw { get; set; }
        public ICollection<Location> Location { get; set; }
        public ICollection<ManagementEntity> ManagementEntity { get; set; }
        public ICollection<Objectives> Objectives { get; set; }
        public ICollection<Port> Port { get; set; }
        public ICollection<SampleUnknown> SampleUnknown { get; set; }
        public ICollection<SamplingKit> SamplingKit { get; set; }
        public ICollection<Staff> Staff { get; set; }
        public ICollection<Trip> Trip { get; set; }
    }
}
