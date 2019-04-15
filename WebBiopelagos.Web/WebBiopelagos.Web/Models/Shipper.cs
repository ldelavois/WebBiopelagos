using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class Shipper
    {
        public byte ShipperId { get; set; }
        public string ShipperName { get; set; }
        public string ContactDetails { get; set; }
        public string FullAddress { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
    }
}
