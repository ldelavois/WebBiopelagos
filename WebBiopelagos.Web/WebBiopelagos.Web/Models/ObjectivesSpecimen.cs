using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class ObjectivesSpecimen
    {
        public ObjectivesSpecimen()
        {
            ObjectivesBs = new HashSet<ObjectivesBs>();
        }

        public int ObjectivesSpecimenId { get; set; }
        public int ObjectivesId { get; set; }
        public int SpeciesId { get; set; }
        public short NbSpecimens { get; set; }
        public string Comment { get; set; }

        public Objectives Objectives { get; set; }
        public Species Species { get; set; }
        public ICollection<ObjectivesBs> ObjectivesBs { get; set; }
    }
}
