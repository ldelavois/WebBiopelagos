using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class Port
    {
        public Port()
        {
            Debriefing = new HashSet<Debriefing>();
            TripDepartureLocationCodeNavigation = new HashSet<Trip>();
            TripReturnLocationCodeNavigation = new HashSet<Trip>();
        }

        public string PortId { get; set; }
        public string CountryId { get; set; }
        public string PortName { get; set; }

        public Country Country { get; set; }
        public ICollection<Debriefing> Debriefing { get; set; }
        public ICollection<Trip> TripDepartureLocationCodeNavigation { get; set; }
        public ICollection<Trip> TripReturnLocationCodeNavigation { get; set; }
    }
}
