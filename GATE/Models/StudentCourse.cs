﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using GATE.Models;

namespace GATE.Models
{
    public partial class StudentCourses
    {
        [Key]
        public int Id { get; set; }

        public bool Paid { get; set; }

        [Required]
        public DateTime CreationTime { get; set; }

        // Foreign keys
        [DisplayName("Student")]
        public int StudentId { get; set; }
        [DisplayName("Course")]
        public int CourseId { get; set; }

        // Navigation Properties
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}