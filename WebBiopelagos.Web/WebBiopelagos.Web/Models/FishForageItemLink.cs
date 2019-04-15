using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class FishForageItemLink
    {
        public int FishId { get; set; }
        public int ForageItemId { get; set; }

        public Fish Fish { get; set; }
        public ForageItem ForageItem { get; set; }
    }
}
