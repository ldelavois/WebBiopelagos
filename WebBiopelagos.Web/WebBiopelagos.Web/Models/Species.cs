using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        [Display(Name = "Code ASFIS")]
        public string AsfisCode { get; set; }

        [Display(Name = "Nom scientifique")]
        public string ScientificName { get; set; }

        [Display(Name = "Nom anglais")]
        public string EnglishName { get; set; }

        [Display(Name = "Nom japonais")]
        public string JaponeseName { get; set; }

        [Display(Name = "Nom")]
        public string FrenchName { get; set; }

        [Display(Name = "Groupe")]
        public string SpeciesGroupId { get; set; }

        [Display(Name = "Categorie")]
        public string SpeciesNameCategoryId { get; set; }

        [Display(Name = "Catégorie")]
        public byte SpeciesCategoryId { get; set; }

        [Display(Name = "Couleur")]
        public string SpeciesColor { get; set; }

        [Display(Name = "Taxonomie")]
        public string SpeciesTaxo { get; set; }

        [Display(Name = "Taxo Genus")]
        public string GenusTaxo { get; set; }

        [Display(Name = "Sous-famille")]
        public string Subfamily { get; set; }

        [Display(Name = "Famille")]
        public string FamilyTaxo { get; set; }

        [Display(Name = "Sur-famille")]
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
