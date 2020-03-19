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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }

        //This is where I want to start tomorrow
        [ForeignKey("PickupDay")]
        [Display (Name = "Pickup Day")]
        public int WeeklyPickUp { get; set; }
        public string PickupDayId { get; set; }
    }
}
