using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class RefKitType
    {
        public RefKitType()
        {
            KitItem = new HashSet<KitItem>();
            MovementKit = new HashSet<MovementKit>();
        }

        public byte KitTypeId { get; set; }
        public string KitTypeName { get; set; }

        public ICollection<KitItem> KitItem { get; set; }
        public ICollection<MovementKit> MovementKit { get; set; }
    }
}
