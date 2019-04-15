using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class Objectives
    {
        public Objectives()
        {
            ObjectivesSpecimen = new HashSet<ObjectivesSpecimen>();
        }

        public int ObjectivesId { get; set; }
        public string CountryId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public short TotalSpecimens { get; set; }
        public DateTime SampleShipmentLastDate { get; set; }
        public short? BiologicalKitNb { get; set; }
        public short? SeedingKitNb { get; set; }
        public DateTime? TagDataLastDate { get; set; }
        public DateTime? SignatureDate { get; set; }
        public string MouContractPath { get; set; }
        public string MouContractName { get; set; }
        public string Comment { get; set; }
        public DateTime CreationDate { get; set; }

        public Country Country { get; set; }
        public ICollection<ObjectivesSpecimen> ObjectivesSpecimen { get; set; }
    }
}
