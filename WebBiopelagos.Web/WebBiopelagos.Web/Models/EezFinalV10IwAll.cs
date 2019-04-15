using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class EezFinalV10IwAll
    {
        public int EezV10Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Subcountry { get; set; }
        public decimal? SubcountryTz { get; set; }
    }
}
