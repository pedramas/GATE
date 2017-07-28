﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GATE.Models
{
    public class Staff
    {
        [Key, ForeignKey("User")]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [DisplayName("Family Name")]
        [MaxLength(50)]
        [Required(ErrorMessage = "The field Family Name is Required")]
        public string FamilyName { get; set; }

        [Required]
        public bool ReadControl { get; set; }
        [Required]
        public bool FullControl { get; set; }

        [Required]
        public DateTime CreationTime { get; set; }
        public DateTime LastUpdate { get; set; }

        // Foreign Keys
        public int UserId { get; set; }
        
        // Navigation Property
        public User User { get; set; }

    }
}