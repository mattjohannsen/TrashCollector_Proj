﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Employee Route Zipcode")]
        public string RouteZipcode { get; set; }
        [NotMapped]
        public IEnumerable<Customer> RoutePickUps { get; set; }
        [NotMapped]
        public List<DayOfWeek> workDays = new List<DayOfWeek>();
        [NotMapped]
        public string DayToRoute { get; set; }
        [NotMapped]
        public IEnumerable<Customer> PickupsToConfirm { get; set; }

    }
}
