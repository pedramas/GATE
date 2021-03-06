﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using GATE.Models;

namespace GATE.Models
{
    public class StudentTests
    {
        [Key]
        public int Id { get; set; }

        [Range(0, 20)]
        public int Grade { get; set; }

        public bool Accepted { get; set; }

        [Required]
        [DisplayName("Date")]
        public DateTime CreationTime { get; set; }

        // Foreign keys
        [DisplayName("Student")]
        public int StudentId { get; set; }
        [DisplayName("Test")]
        public int TestId { get; set; }

        // Navigation Properties
        public virtual Student Student { get; set; }
        public virtual Test Test { get; set; }

    }
}