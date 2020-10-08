using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ssdLab1.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        [Required, Display(Name = "Team Name")]
        public string TeamName { get; set; }
        [Required, Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Established Date")]
        [DataType(DataType.DateTime)]
        public DateTime EstablishedDate { get; set; }
    }
}

