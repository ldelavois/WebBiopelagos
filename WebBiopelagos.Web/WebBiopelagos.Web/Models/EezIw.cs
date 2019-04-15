using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class EezIw
    {
        public short EezIwId { get; set; }
        public string EezCountryId { get; set; }
        public string SubcountryName { get; set; }
        public string EezSubcountryId { get; set; }
        public decimal? SubcountryTz { get; set; }
        public string AreaName { get; set; }

        public Country EezCountry { get; set; }
    }
}
