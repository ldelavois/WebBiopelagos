using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class Species
    {
        public Species()
        {
            AnalysisStomachPreyItem = new HashSet<AnalysisStomachPreyItem>();
            Fish = new HashSet<Fish>();
            ForageItem = new HashSet<ForageItem>();
            ObjectivesSpecimen = new HashSet<ObjectivesSpecimen>();
        }

        public int SpeciesId { get; set; }
        public string AsfisCode { get; set; }
        public string ScientificName { get; set; }
        public string EnglishName { get; set; }
        public string JaponeseName { get; set; }
        public string FrenchName { get; set; }
        public string SpeciesGroupId { get; set; }
        public string SpeciesNameCategoryId { get; set; }
        public byte SpeciesCategoryId { get; set; }
        public string SpeciesColor { get; set; }
        public string SpeciesTaxo { get; set; }
        public string GenusTaxo { get; set; }
        public string Subfamily { get; set; }
        public string FamilyTaxo { get; set; }
        public string Superfamily { get; set; }
        public string Infraorder { get; set; }
        public string Suborder { get; set; }
        public string OrderTaxo { get; set; }
        public string Superorder { get; set; }
        public string Infraclass { get; set; }
        public string Subclass { get; set; }
        public string ClassTaxo { get; set; }
        public string Subphylum { get; set; }
        public string PhylumTaxo { get; set; }
        public bool? IsSpecies { get; set; }
        public int? GbifKey { get; set; }
        public int? WormsKey { get; set; }
        public string VerticalClassId { get; set; }
        public bool IsReefAssociated { get; set; }
        public bool IsPelagicJuvenile { get; set; }
        public byte? SwimbladderId { get; set; }
        public short? MaturitySize { get; set; }
        public string LengthCodeId { get; set; }
        public decimal? LenMinMm { get; set; }
        public decimal? LenMaxMm { get; set; }
        public decimal? PreyLenMinMm { get; set; }
        public decimal? PreyLenMaxMm { get; set; }
        public string Ecopath2010Class { get; set; }
        public bool IsIdentificationSheet { get; set; }
        public DateTime? LastUpdate { get; set; }
        public DateTime? CreationDate { get; set; }

        public LengthCode LengthCode { get; set; }
        public SpeciesCategory SpeciesCategory { get; set; }
        public SpeciesGroup SpeciesGroup { get; set; }
        public SpeciesNameCategory SpeciesNameCategory { get; set; }
        public Swimbladder Swimbladder { get; set; }
        public VerticalClass VerticalClass { get; set; }
        public ICollection<AnalysisStomachPreyItem> AnalysisStomachPreyItem { get; set; }
        public ICollection<Fish> Fish { get; set; }
        public ICollection<ForageItem> ForageItem { get; set; }
        public ICollection<ObjectivesSpecimen> ObjectivesSpecimen { get; set; }
    }
}
