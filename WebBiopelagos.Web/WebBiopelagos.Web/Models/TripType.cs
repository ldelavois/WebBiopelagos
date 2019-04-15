using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class TripType
    {
        public TripType()
        {
            Trip = new HashSet<Trip>();
        }

        public byte TripTypeId { get; set; }
        public string TripTypeDesc { get; set; }
        public string TripGroup { get; set; }

        public ICollection<Trip> Trip { get; set; }
    }
}
