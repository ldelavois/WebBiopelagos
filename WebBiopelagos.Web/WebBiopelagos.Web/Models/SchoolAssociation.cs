using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class SchoolAssociation
    {
        public byte SchoolAssociationId { get; set; }
        public string SchoolAssociationDesc { get; set; }
        public string SchoolAssociationGroup { get; set; }
        public byte? SchoolTubs { get; set; }
        public string SchoolTagdager { get; set; }
    }
}
