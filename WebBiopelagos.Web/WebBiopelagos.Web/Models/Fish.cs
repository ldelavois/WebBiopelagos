using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebBiopelagos.Web.Models
{
    public partial class Fish
    {
        public Fish()
        {
            ChildSpecimenSampleLink = new HashSet<ChildSpecimenSampleLink>();
            FishForageIndividualLink = new HashSet<FishForageIndividualLink>();
            FishForageItemLink = new HashSet<FishForageItemLink>();
            FishPreyItemLink = new HashSet<FishPreyItemLink>();
            HistoryFish = new HashSet<HistoryFish>();
            RecapturedBird = new HashSet<RecapturedBird>();
            SampleBase = new HashSet<SampleBase>();
            SpecimenBird = new HashSet<SpecimenBird>();
            ZooplanktonDepthSpecimen = new HashSet<ZooplanktonDepthSpecimen>();
        }


        public int SetBaseId { get; set; }
        public string FishTypeId { get; set; }

        [Display(Name = "Date d'échantillonnage")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime SamplingDate { get; set; }

        [Display(Name = "Numéro")]
        public string FishNo { get; set; }

        [Display(Name = "Propriétaire")]
        public short? OwnershipId { get; set; }

        [Display(Name = "Espèce")]
        public int SpeciesId { get; set; }

        [Display(Name = "Sexe id")]
        public string SexId { get; set; }

        [Display(Name = "Commentaire")]
        public string Comment { get; set; }

        [Display(Name = "Date de création")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? CreationDate { get; set; }

        [Display(Name = "Equipe éditeur")]
        public short EditorStaffId { get; set; }

        [Display(Name = "Type d'éspèces")]
        public FishType FishType { get; set; }

        [Display(Name = "ID Station associée")]
        public SetBase SetBase { get; set; }

        [Display(Name = "Sexe")]
        public Sex Sex { get; set; }

        [Display(Name = "Espèce")]
        public Species Species { get; set; }

        [Display(Name = "Equipe éditeur")]
        public Staff EditorStaff { get; set; }



        [Display(Name = "ID Espèce")]
        public int FishId { get; set; } //pas affiché
        public int? TmpPredatorId { get; set; } //pas affiché
        public string CsiroId { get; set; } //pas affiché
        public string CatchTime { get; set; } //pas affiché
        public short? HookNo { get; set; } //pas affiché
        public short? ReelNo { get; set; }//pas affiché
        public short? DropNo { get; set; }//pas affiché
        public bool IsOfInterest { get; set; } //pas affiché
        public double? LengthMm { get; set; } //pas affiché
        public string LengthCodeId { get; set; } //pas affiché
        public double? LengthMm2 { get; set; }//pas affiché
        public string LengthCodeId2 { get; set; } //pas affiché
        public double? LengthMm3 { get; set; }//pas affiché
        public string LengthCodeId3 { get; set; }//pas affiché
        public double? CalculatedWtGr { get; set; }//pas affiché
        public double? WeightGr { get; set; }//pas affiché
        public string WeightCodeId { get; set; }//pas affiché
        public double? GonadWeightGr { get; set; }//pas affiché
        public string Photo1 { get; set; }//pas affiché
        public string Photo2 { get; set; }//pas affiché
        public string Photo3 { get; set; }//pas affiché
        public string Photo4 { get; set; }//pas affiché
        public DateTime? DataReceptionDate { get; set; }//pas affiché
        public DateTime? PaiementDate { get; set; }//pas affiché
        public string EnteredByOld { get; set; }//pas affiché
        public short? EditorStaffId2 { get; set; }//pas affiché
        public byte[] Timestamp { get; set; }//pas affiché
        public int? TmpId { get; set; }//pas affiché
        public Staff EditorStaffId2Navigation { get; set; }//pas affiché
        public LengthCode LengthCode { get; set; }//pas affiché
        public LengthCode LengthCodeId2Navigation { get; set; }//pas affiché
        public LengthCode LengthCodeId3Navigation { get; set; }//pas affiché
        public WeightCode WeightCode { get; set; }//pas affiché

        public Trip Trip { get;}


        public FishPreyIndividualLink FishPreyIndividualLink { get; set; }
        public ICollection<ChildSpecimenSampleLink> ChildSpecimenSampleLink { get; set; }
        public ICollection<FishForageIndividualLink> FishForageIndividualLink { get; set; }
        public ICollection<FishForageItemLink> FishForageItemLink { get; set; }
        public ICollection<FishPreyItemLink> FishPreyItemLink { get; set; }
        public ICollection<HistoryFish> HistoryFish { get; set; }
        public ICollection<RecapturedBird> RecapturedBird { get; set; }
        public ICollection<SampleBase> SampleBase { get; set; }
        public ICollection<SpecimenBird> SpecimenBird { get; set; }
        public ICollection<ZooplanktonDepthSpecimen> ZooplanktonDepthSpecimen { get; set; }
    }
}
