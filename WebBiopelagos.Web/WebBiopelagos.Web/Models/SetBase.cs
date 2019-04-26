using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace WebBiopelagos.Web.Models
{
    public partial class SetBase
    {
        public SetBase()
        {
            Fish = new HashSet<Fish>();
            ForageItem = new HashSet<ForageItem>();
            SetBiologicalGearLink = new HashSet<SetBiologicalGearLink>();
            SetBiologicalStep = new HashSet<SetBiologicalStep>();
            SetBiologicalZooplankton = new HashSet<SetBiologicalZooplankton>();
        }

        [Display(Name = "ID Station")]
        public int SetBaseId { get; set; }

        [Display(Name = "N° Campagne")]
        public int TripId { get; set; }

        public Guid? T2LogId { get; set; }

        [Display(Name = "N° Station")]
        public int SetNo { get; set; }

        [Display(Name = "Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime SetDateLocal { get; set; }




        [Display(Name = "Heure")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public string SetTimeLocal { get; set; }


        [Display(Name = "Day/Night")]
        public string DayNightId { get; set; }


        public byte SchoolAssociationId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public DateTime? SetEndDateLocal { get; set; }
        public string SetEndTimeLocal { get; set; }
        public string EndLatitude { get; set; }
        public string EndLongitude { get; set; }
        public string BaitList { get; set; }

        [Display(Name = "Latitude (Dec.)")]
        public decimal? LatitudeDec { get; set; }

        [Display(Name = "Longitude (Dec.)")]
        public decimal? LongitudeDec { get; set; }

        public string GearId { get; set; }
        public short? StaffId { get; set; }
        public string EezSubcountryId { get; set; }
        public string EezClosest { get; set; }
        public string LonghurstCode { get; set; }
        public byte? BetRegionId { get; set; }
        public decimal? SstCelsius { get; set; }
        public decimal? BathyMeters { get; set; }
        public double? OniNoaa { get; set; }

        [Display(Name = "Commentaires")]
        public string Comment { get; set; }

        [Display(Name = "Date de création")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? CreationDate { get; set; }
        public int? LogIdTubsOld { get; set; }

        [Display(Name = "Day/Night")]
        public DayNight DayNight { get; set; }

        private void daynight()
        {
            if (DayNight.DayNightId == "day")
            {
                DayNight.DayNightId = "jour";
            }
            else if (DayNight.DayNightId == "night")
            {
                DayNight.DayNightId = "nuit";
            }
            else if (DayNight.DayNightId == "dusk")
            {
                DayNight.DayNightId = "crépuscule";
            }

        }
        public Gear Gear { get; set; }
        public Staff Staff { get; set; }

        [Display(Name = "N° Campagne")]
        public Trip Trip { get; set; }

        public SetBiological SetBiological { get; set; }
        public SetDws SetDws { get; set; }
        public SetPsa SetPsa { get; set; }
        public ICollection<Fish> Fish { get; set; }
        public ICollection<ForageItem> ForageItem { get; set; }
        public ICollection<SetBiologicalGearLink> SetBiologicalGearLink { get; set; }
        public ICollection<SetBiologicalStep> SetBiologicalStep { get; set; }
        public ICollection<SetBiologicalZooplankton> SetBiologicalZooplankton { get; set; }
    }
}
