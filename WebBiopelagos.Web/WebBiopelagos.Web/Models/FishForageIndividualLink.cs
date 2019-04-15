using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class FishForageIndividualLink
    {
        public int FishId { get; set; }
        public int ForageIndividualId { get; set; }
        public DateTime CreationDate { get; set; }

        public Fish Fish { get; set; }
        public ForageIndividual ForageIndividual { get; set; }
    }
}
