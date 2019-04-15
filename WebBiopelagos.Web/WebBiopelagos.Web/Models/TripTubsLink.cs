using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class TripTubsLink
    {
        public int TripId { get; set; }
        public int ObstripId { get; set; }

        public Trip Trip { get; set; }
    }
}
