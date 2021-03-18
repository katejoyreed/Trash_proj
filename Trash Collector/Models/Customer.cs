using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trash_Collector.Models
{
    public class Customer
    {
        [Key]
        public int ID;

        [Display(Name = "First Name")]
        public string FirstName;
        [Display(Name = "Last Name")]
        public string LastName;
        public string Address;
        [Display(Name = "Trash Day")]
        public DayOfWeek TrashDay;
        [Display(Name = "Balance Due")]
        public int Balance;

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

    }
}
