using CsvHelper.Configuration.Attributes;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [Display(Name = "Zip Code")]
        public string Zipcode { get; set; }

        [ForeignKey("PickupDay")]
        [Display (Name = "Pickup Day")]
        public int WeeklyPickUp { get; set; } //Customer field
        public PickupDay PickupDay { get; set; } //PickupDay field
        [NotMapped]
        public IEnumerable<PickupDay> PickupDays { get; set; }
        [Display(Name = "Suspend Pickup Start Date")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? StartHold { get; set; }
        [Display(Name = "Suspend Pickup End Date")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? EndHold { get; set; }
        [Display(Name = "Extra Pickup Date")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? ExtraPickupDay { get; set; }
        [DataType(System.ComponentModel.DataAnnotations.DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Balance { get; set; }

    }
}
