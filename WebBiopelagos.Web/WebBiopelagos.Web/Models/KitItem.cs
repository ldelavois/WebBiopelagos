using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class KitItem
    {
        public short KitItemId { get; set; }
        public byte KitTypeId { get; set; }
        public short ItemId { get; set; }
        public short NbItems { get; set; }

        public RefItem Item { get; set; }
        public RefKitType KitType { get; set; }
    }
}
